namespace MSISVIT_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            richTextBox1 = new RichTextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            Label_CLI_res = new Label();
            Label_cl_res2 = new Label();
            Label_cl_res = new Label();
            Label_CLI = new Label();
            Label_cl_2 = new Label();
            Label_CL = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            Button_Parse = new Button();
            Button_Test = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.75F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 73.25F));
            tableLayoutPanel1.Controls.Add(richTextBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 76.22222F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 23.7777786F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // richTextBox1
            // 
            tableLayoutPanel1.SetColumnSpan(richTextBox1, 2);
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Location = new Point(3, 3);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(794, 337);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel2.Controls.Add(Label_CLI_res, 2, 1);
            tableLayoutPanel2.Controls.Add(Label_cl_res2, 1, 1);
            tableLayoutPanel2.Controls.Add(Label_cl_res, 0, 1);
            tableLayoutPanel2.Controls.Add(Label_CLI, 2, 0);
            tableLayoutPanel2.Controls.Add(Label_cl_2, 1, 0);
            tableLayoutPanel2.Controls.Add(Label_CL, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(217, 346);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 37.5F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 62.5F));
            tableLayoutPanel2.Size = new Size(580, 101);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // Label_CLI_res
            // 
            Label_CLI_res.AutoSize = true;
            Label_CLI_res.Dock = DockStyle.Fill;
            Label_CLI_res.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Label_CLI_res.Location = new Point(389, 37);
            Label_CLI_res.Name = "Label_CLI_res";
            Label_CLI_res.Size = new Size(188, 64);
            Label_CLI_res.TabIndex = 5;
            Label_CLI_res.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label_cl_res2
            // 
            Label_cl_res2.AutoSize = true;
            Label_cl_res2.Dock = DockStyle.Fill;
            Label_cl_res2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Label_cl_res2.Location = new Point(196, 37);
            Label_cl_res2.Name = "Label_cl_res2";
            Label_cl_res2.Size = new Size(187, 64);
            Label_cl_res2.TabIndex = 4;
            Label_cl_res2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label_cl_res
            // 
            Label_cl_res.AutoSize = true;
            Label_cl_res.Dock = DockStyle.Fill;
            Label_cl_res.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Label_cl_res.Location = new Point(3, 37);
            Label_cl_res.Name = "Label_cl_res";
            Label_cl_res.Size = new Size(187, 64);
            Label_cl_res.TabIndex = 3;
            Label_cl_res.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label_CLI
            // 
            Label_CLI.AutoSize = true;
            Label_CLI.Dock = DockStyle.Fill;
            Label_CLI.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Label_CLI.Location = new Point(389, 0);
            Label_CLI.Name = "Label_CLI";
            Label_CLI.Size = new Size(188, 37);
            Label_CLI.TabIndex = 2;
            Label_CLI.Text = "CLI";
            Label_CLI.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label_cl_2
            // 
            Label_cl_2.AutoSize = true;
            Label_cl_2.Dock = DockStyle.Fill;
            Label_cl_2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Label_cl_2.Location = new Point(196, 0);
            Label_cl_2.Name = "Label_cl_2";
            Label_cl_2.Size = new Size(187, 37);
            Label_cl_2.TabIndex = 1;
            Label_cl_2.Text = "cl";
            Label_cl_2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label_CL
            // 
            Label_CL.AutoSize = true;
            Label_CL.Dock = DockStyle.Fill;
            Label_CL.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Label_CL.Location = new Point(3, 0);
            Label_CL.Name = "Label_CL";
            Label_CL.Size = new Size(187, 37);
            Label_CL.TabIndex = 0;
            Label_CL.Text = "CL";
            Label_CL.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(Button_Parse, 0, 0);
            tableLayoutPanel3.Controls.Add(Button_Test, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 346);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(208, 101);
            tableLayoutPanel3.TabIndex = 3;
            // 
            // Button_Parse
            // 
            Button_Parse.BackColor = Color.Lime;
            Button_Parse.Dock = DockStyle.Fill;
            Button_Parse.Location = new Point(3, 3);
            Button_Parse.Name = "Button_Parse";
            Button_Parse.Size = new Size(202, 44);
            Button_Parse.TabIndex = 0;
            Button_Parse.Text = "Parse";
            Button_Parse.UseVisualStyleBackColor = false;
            // 
            // Button_Test
            // 
            Button_Test.BackColor = Color.Lime;
            Button_Test.Dock = DockStyle.Fill;
            Button_Test.Location = new Point(3, 53);
            Button_Test.Name = "Button_Test";
            Button_Test.Size = new Size(202, 45);
            Button_Test.TabIndex = 1;
            Button_Test.Text = "Test";
            Button_Test.UseVisualStyleBackColor = false;
            Button_Test.Click += Button_Test_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "JilboMetrics";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label Label_CL;
        private Label Label_CLI_res;
        private Label Label_cl_res2;
        private Label Label_cl_res;
        private Label Label_CLI;
        private Label Label_cl_2;
        private RichTextBox richTextBox1;
        private TableLayoutPanel tableLayoutPanel3;
        private Button Button_Parse;
        private Button Button_Test;
    }
}
