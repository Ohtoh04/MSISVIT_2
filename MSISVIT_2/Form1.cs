namespace MSISVIT_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Test_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = File.ReadAllText("test.txt");
            Button_Parse_Click_1(sender, e);

        }

        private void Button_Parse_Click_1(object sender, EventArgs e)
        {
            GilbMetrics.CalculateGilbMetrics(richTextBox1.Text);
            Label_cl_res.Text = GilbMetrics.AbsoluteComplexity.ToString();
            Label_cl_res2.Text = GilbMetrics.RelativeComplexity.ToString();
            Label_CLI_res.Text = GilbMetrics.MaxNestingLevel.ToString();
        }
    }
}
