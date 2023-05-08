namespace summer_practice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            comboBox1 = new ComboBox();
            button4 = new Button();
            button5 = new Button();
            button3 = new Button();
            button2 = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            button6 = new Button();
            label1 = new Label();
            label2 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            label4 = new Label();
            button7 = new Button();
            label3 = new Label();
            textBox1 = new TextBox();
            label5 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(112, 25);
            button1.Name = "button1";
            button1.Size = new Size(108, 38);
            button1.TabIndex = 1;
            button1.Text = "Заполнить рандомно";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 51F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 33F));
            tableLayoutPanel1.Location = new Point(112, 69);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel1.Size = new Size(108, 109);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Font = new Font("Rockwell Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(240, 69);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 109);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Выберите операцию";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Matrix", "Scalar" });
            comboBox1.Location = new Point(131, 25);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(63, 27);
            comboBox1.TabIndex = 8;
            comboBox1.Visible = false;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button4
            // 
            button4.Font = new Font("Rockwell Extra Bold", 13F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(22, 58);
            button4.Name = "button4";
            button4.Size = new Size(44, 26);
            button4.TabIndex = 6;
            button4.Text = "+";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Rockwell Extra Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(82, 58);
            button5.Name = "button5";
            button5.Size = new Size(43, 26);
            button5.TabIndex = 7;
            button5.Text = "-";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Rockwell Extra Bold", 13F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(82, 25);
            button3.Name = "button3";
            button3.Size = new Size(43, 29);
            button3.TabIndex = 5;
            button3.Text = "*";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Rockwell Extra Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(22, 23);
            button2.Name = "button2";
            button2.Size = new Size(44, 29);
            button2.TabIndex = 4;
            button2.Text = "DET";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            button2.Leave += button2_Leave;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 51F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 33F));
            tableLayoutPanel2.Location = new Point(460, 69);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel2.Size = new Size(108, 109);
            tableLayoutPanel2.TabIndex = 6;
            // 
            // button6
            // 
            button6.Font = new Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(460, 25);
            button6.Name = "button6";
            button6.Size = new Size(108, 38);
            button6.TabIndex = 5;
            button6.Text = "Заполнить рандомно";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell Extra Bold", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(152, 181);
            label1.Name = "label1";
            label1.Size = new Size(29, 26);
            label1.TabIndex = 7;
            label1.Text = "A";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Rockwell Extra Bold", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(500, 181);
            label2.Name = "label2";
            label2.Size = new Size(31, 26);
            label2.TabIndex = 8;
            label2.Text = "B";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 51F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 33F));
            tableLayoutPanel3.Location = new Point(671, 69);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel3.Size = new Size(108, 109);
            tableLayoutPanel3.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Rockwell Extra Bold", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(694, 181);
            label4.Name = "label4";
            label4.Size = new Size(60, 26);
            label4.TabIndex = 11;
            label4.Text = "Res";
            // 
            // button7
            // 
            button7.Font = new Font("Rockwell Extra Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button7.Location = new Point(585, 112);
            button7.Name = "button7";
            button7.Size = new Size(67, 41);
            button7.TabIndex = 12;
            button7.Text = "Calculate";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Rockwell Extra Bold", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(292, 42);
            label3.Name = "label3";
            label3.Size = new Size(109, 21);
            label3.TabIndex = 13;
            label3.Text = "det(A) = 0";
            label3.Visible = false;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Rockwell Extra Bold", 13F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(446, 118);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(28, 28);
            textBox1.TabIndex = 14;
            textBox1.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Stencil", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(180, 315);
            label5.Name = "label5";
            label5.Size = new Size(472, 32);
            label5.TabIndex = 15;
            label5.Text = "Third Order Matrix Calculator";
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Location = new Point(226, 58);
            panel1.Name = "panel1";
            panel1.Size = new Size(14, 130);
            panel1.TabIndex = 16;
            panel1.Visible = false;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.Location = new Point(92, 58);
            panel2.Name = "panel2";
            panel2.Size = new Size(14, 130);
            panel2.TabIndex = 17;
            panel2.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(button7);
            Controls.Add(label4);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button6);
            Controls.Add(groupBox1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(button1);
            Controls.Add(tableLayoutPanel2);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox1;
        private Button button4;
        private Button button5;
        private Button button3;
        private Button button2;
        private TableLayoutPanel tableLayoutPanel2;
        private Button button6;
        private Label label1;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label4;
        private Button button7;
        private Label label3;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Label label5;
        private Panel panel1;
        private Panel panel2;
    }
}