using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MSISVIT_2
{
    public static class GilbMetrics
    {
        public static int AbsoluteComplexity { get; private set; }
        public static double RelativeComplexity { get; private set; }
        public static int MaxNestingLevel { get; private set; }


        public static void CalculateGilbMetrics(string phpCode)
        {
            CalculateAbsoluteComplexity(phpCode);
            CalculateMaxNestingLevel(phpCode);
            CalculateRelativeComplexity(phpCode);
        }

        private static int CalculateAbsoluteComplexity(string phpCode)
        {
            int count = 0;
            int startIndex = 0;

            while ((startIndex = phpCode.IndexOf("if", startIndex)) != -1)
            {
                count++;
                startIndex += "if".Length;
            }

            var matches = Regex.Matches(phpCode, @"\b(switch)\b");// можно было в один регех, но мне похуй
            var matchesCases = Regex.Matches(phpCode, @"\b(case)\b");
            var matchesWhile = Regex.Matches(phpCode, @"\b(while)\b");
            var matchesFor = Regex.Matches(phpCode, @"\b(for)\b");

            int switchcount = matches.Count();
            int switchcountCases = matchesCases.Count();
            int forCount = matchesWhile.Count();
            int whileCount = matchesFor.Count();

            count += switchcountCases;
            count += forCount;
            count += whileCount;
            count -= switchcount;
            AbsoluteComplexity = count;

            return count;
        }

        private static double CalculateRelativeComplexity(string phpCode)
        {
            int sum2 = 0;
            var OperatorsParsed = GilbMetrics.OperatorParse(phpCode);
            foreach (var _operator in OperatorsParsed)
            {
                sum2 += _operator.Item2;
            }
            RelativeComplexity = AbsoluteComplexity /(double)sum2;
            return AbsoluteComplexity / (double)sum2;
        }

        private static int CalculateMaxNestingLevel(string phpCode)//оно вобщем все фигурные скобки считает, включая классы и функции, но мне похуй+поебать+все равно+индифферентно в высшей степени+запили код чтоб без классов и прочего
        {
            int nestingDepth = 0;
            int maxNestingDepth = 0;

            foreach (char c in phpCode)
            {
                if (c == '{')
                {
                    nestingDepth++;
                    maxNestingDepth = Math.Max(maxNestingDepth, nestingDepth);
                }
                else if (c == '}')
                {
                    nestingDepth--;
                }
            }
            string[] substrings = Regex.Split(phpCode, @"(?=switch)").Where(s => !string.IsNullOrEmpty(s)).ToArray();

            int maxCaseCount = 0;

            foreach (string substring in substrings)
            {
                int caseCount = Regex.Matches(substring, "case").Count;

                if (caseCount > maxCaseCount)
                {
                    maxCaseCount = caseCount;
                }
            }
            maxCaseCount -= 2;
            maxNestingDepth -= 1;
            MaxNestingLevel = maxNestingDepth > maxCaseCount ? maxNestingDepth: maxCaseCount;
            return MaxNestingLevel;
        }

        private static List<Tuple<string, int>> CountOperators(string code)
        {
            string[] operators = { "+", "-", "*", "/", "%", ">", "<", "==", "!=", "&&", "||", "**", "<>", "<=", ">=", "!", "++", "--", "+=", "->", "//" };
            Dictionary<string, int> operatorCounts = new Dictionary<string, int>();
            foreach (string line in code.Split('\n'))
                foreach (string op in operators)
                {
                    int count = CountOccurrences(line, op);
                    if (count > 0)
                    {
                        if (operatorCounts.ContainsKey(op))
                            operatorCounts[op] += count;
                        else
                            operatorCounts[op] = count;
                    }
                }
            List<Tuple<string, int>> result = operatorCounts
                .Select(kv => Tuple.Create(kv.Key, kv.Value))
                .ToList();

            return result;
        }

        private static int CountOccurrences(string text, string substr)
        {
            int count = 0;
            int index = text.IndexOf(substr, StringComparison.Ordinal);
            while (index != -1)
            {
                count++;
                index = text.IndexOf(substr, index + 1, StringComparison.Ordinal);
            }
            return count;
        }

        private static List<Tuple<string, int>> CountPhpOperators(string phpCode)
        {
            var operatorCount = new List<Tuple<string, int>>();
            string pattern = @"\b(?:if|else|while|for|foreach|switch|case|break|continue|return|and|or|xor)\b";
            MatchCollection matches = Regex.Matches(phpCode, pattern);
            foreach (Match match in matches)
            {
                string operatorName = match.Value;
                var existingTuple = operatorCount.Find(t => t.Item1 == operatorName);
                if (existingTuple != null)
                {
                    var index = operatorCount.IndexOf(existingTuple);
                    operatorCount[index] = new Tuple<string, int>(operatorName, existingTuple.Item2 + 1);
                }
                else operatorCount.Add(new Tuple<string, int>(operatorName, 1));

            }
            return operatorCount;
        }


        private static List<Tuple<string, int>> cor(List<Tuple<string, int>> list)
        {
            int i1 = list.FindIndex(tuple => tuple.Item1 == "++");
            int i2 = list.FindIndex(tuple => tuple.Item1 == "+");
            if (i1 != -1) list[i2] = new Tuple<string, int>("+", list[i2].Item2 - list[i1].Item2 * 2);
            i1 = list.FindIndex(tuple => tuple.Item1 == "+=");
            i2 = list.FindIndex(tuple => tuple.Item1 == "+");
            if (i1 != -1) list[i2] = new Tuple<string, int>("+", list[i2].Item2 - list[i1].Item2);
            i1 = list.FindIndex(tuple => tuple.Item1 == ">=");
            i2 = list.FindIndex(tuple => tuple.Item1 == ">");
            if (i1 != -1) list[i2] = new Tuple<string, int>(">", list[i2].Item2 - list[i1].Item2);
            i1 = list.FindIndex(tuple => tuple.Item1 == "<=");
            i2 = list.FindIndex(tuple => tuple.Item1 == "<");
            if (i1 != -1) list[i2] = new Tuple<string, int>("<", list[i2].Item2 - list[i1].Item2);
            i1 = list.FindIndex(tuple => tuple.Item1 == "<>");
            i2 = list.FindIndex(tuple => tuple.Item1 == ">");
            if (i1 != -1) list[i2] = new Tuple<string, int>(">", list[i2].Item2 - list[i1].Item2);
            i1 = list.FindIndex(tuple => tuple.Item1 == "<>");
            i2 = list.FindIndex(tuple => tuple.Item1 == "<");
            if (i1 != -1) list[i2] = new Tuple<string, int>("<", list[i2].Item2 - list[i1].Item2);
            i1 = list.FindIndex(tuple => tuple.Item1 == "-=");
            i2 = list.FindIndex(tuple => tuple.Item1 == "-");
            if (i1 != -1) list[i2] = new Tuple<string, int>("-", list[i2].Item2 - list[i1].Item2);
            i1 = list.FindIndex(tuple => tuple.Item1 == "*=");
            i2 = list.FindIndex(tuple => tuple.Item1 == "*");
            if (i1 != -1) list[i2] = new Tuple<string, int>("*", list[i2].Item2 - list[i1].Item2);
            i1 = list.FindIndex(tuple => tuple.Item1 == "/=");
            i2 = list.FindIndex(tuple => tuple.Item1 == "/");
            if (i1 != -1) list[i2] = new Tuple<string, int>("/", list[i2].Item2 - list[i1].Item2);
            i1 = list.FindIndex(tuple => tuple.Item1 == "**");
            i2 = list.FindIndex(tuple => tuple.Item1 == "*");
            if (i1 != -1) list[i2] = new Tuple<string, int>("*", list[i2].Item2 - list[i1].Item2 * 2);
            i1 = list.FindIndex(tuple => tuple.Item1 == "--");
            i2 = list.FindIndex(tuple => tuple.Item1 == "-");
            if (i1 != -1) list[i2] = new Tuple<string, int>("-", list[i2].Item2 - list[i1].Item2 * 2);
            i1 = list.FindIndex(tuple => tuple.Item1 == "->");
            i2 = list.FindIndex(tuple => tuple.Item1 == ">");
            if (i1 != -1) list[i2] = new Tuple<string, int>(">", list[i2].Item2 - list[i1].Item2);
            i1 = list.FindIndex(tuple => tuple.Item1 == "->");
            i2 = list.FindIndex(tuple => tuple.Item1 == "-");
            if (i1 != -1) list[i2] = new Tuple<string, int>("-", list[i2].Item2 - list[i1].Item2);
            i1 = list.FindIndex(tuple => tuple.Item1 == "//");
            i2 = list.FindIndex(tuple => tuple.Item1 == "/");
            if (i1 != -1) list[i2] = new Tuple<string, int>("/", list[i2].Item2 - list[i1].Item2 * 2);
            return list;
        }
        private static List<Tuple<string, int>> FunctionParse(string input)
        {
            var funcCounts = new Dictionary<string, int>();
            var matches = Regex.Matches(input, @"\b(?<!(function\s+)|(->))(\w+\()");


            foreach (Match match in matches)
            {
                if (funcCounts.ContainsKey(match.Value + ")"))
                {
                    funcCounts[match.Value]++;
                }
                else
                {
                    funcCounts.Add(match.Value + ")", 1);
                }
            }

            //echo

            if (input.Contains("echo"))
            {
                funcCounts.Add("echo", Regex.Matches(input, @"echo").Count());
            }

            var result = new List<Tuple<string, int>>();
            foreach (var pair in funcCounts)
            {
                result.Add(new Tuple<string, int>(pair.Key, pair.Value));
            }

            return result;
        }
        public static List<Tuple<string, int>> OperatorParse(string code)
        {
            var res1 = cor(CountOperators(code));
            var res2 = CountPhpOperators(code);
            var res3 = FunctionParse(code);
            foreach (var item in res2)
                res1.Add(item);
            foreach (var item in res3)
                res1.Add(item);
            return res1;
        }

    }
}
