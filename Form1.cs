using System.Drawing;

namespace summer_practice
{
    public partial class Form1 : Form
    {
        string calc_option = "";
        Matrix A, B;
        private void matrixes_load()
        {
            Matrix null_mtx = new Matrix('f');
            fill_matrix(tableLayoutPanel1, null_mtx);
            fill_matrix(tableLayoutPanel2, null_mtx);

        }
        public Form1()
        {
            InitializeComponent();
            matrixes_load();
        }

        // Метод чтения матрицы из формы
        private Matrix read_matrix(TableLayoutPanel tlp)
        {
            Matrix mtx = new Matrix();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Control mat_elem = tlp.GetControlFromPosition(j, i);
                    mtx[i, j] = Convert.ToInt32(mat_elem.Text);
                }
            }
            return mtx;

        }
        // Метод для записи матриц в форму
        private void fill_matrix(TableLayoutPanel tlp, Matrix mtx)
        {
            tlp.Controls.Clear();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    TextBox textBox = new TextBox();
                    tlp.Controls.Add(textBox, i, j);
                    textBox.Multiline = true;
                    textBox.Dock = DockStyle.Fill;
                    textBox.Text = mtx[j, i].ToString();
                }
            }
        }
        // A fill random
        private void button1_Click(object sender, EventArgs e)
        {
            A = new Matrix();
            fill_matrix(tableLayoutPanel1, A);

        }

        // B fill random
        private void button6_Click(object sender, EventArgs e)
        {
            B = new Matrix();
            fill_matrix(tableLayoutPanel2, B);
        }

        //determinant
        private void button2_Click(object sender, EventArgs e)
        {
            calc_option = "det";
            textBox1.Visible = false;
            comboBox1.Visible = false;
            tableLayoutPanel2.Visible = false;
            button6.Visible = false;
            label2.Visible = false;
            tableLayoutPanel3.Visible = false;
            label4.Visible = false;
            //button7.Location = new Point(450, button7.Location.Y);
            button7.Visible = false;
            A = read_matrix(tableLayoutPanel1);
            label3.Visible = true;
            label3.Text = $"det(A) = {A.det()}";
        }

        private void button2_Leave(object sender, EventArgs e)
        {
            tableLayoutPanel2.Visible = true;
            button6.Visible = true;
            label2.Visible = true;
            tableLayoutPanel3.Visible = true;
            label4.Visible = true;
            label3.Visible = false;
            button7.Visible = true;
        }

        //mult click
        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.Visible = true;
            calc_option = "mult";
        }

        //mult option
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                tableLayoutPanel2.Visible = true;
                button6.Visible = true;
                label2.Visible = true;
                tableLayoutPanel3.Visible = true;
                label4.Visible = true;
                textBox1.Visible = false;

            }
            if (comboBox1.SelectedIndex == 1)
            {
                tableLayoutPanel2.Visible = false;
                button6.Visible = false;
                label2.Visible = false;
                label4.Visible = false;
                textBox1.Visible = true;
                textBox1.Text = "0";
            }
        }

        //plus click
        private void button4_Click(object sender, EventArgs e)
        {
            calc_option = "plus";
            comboBox1.Visible = false;
            tableLayoutPanel2.Visible = true;
            button6.Visible = true;
            label2.Visible = true;
            tableLayoutPanel3.Visible = true;
            label4.Visible = true;
            textBox1.Visible = false;
        }

        //minus click
        private void button5_Click(object sender, EventArgs e)
        {
            calc_option = "minus";
            comboBox1.Visible = false;
            tableLayoutPanel2.Visible = true;
            button6.Visible = true;
            label2.Visible = true;
            tableLayoutPanel3.Visible = true;
            label4.Visible = true;
            textBox1.Visible = false;
        }

        //calc click
        private void button7_Click(object sender, EventArgs e)
        {
            if (calc_option == "plus")
            {
                A = read_matrix(tableLayoutPanel1);
                B = read_matrix(tableLayoutPanel2);
                fill_matrix(tableLayoutPanel3, A + B);
            }
            if (calc_option == "minus")
            {
                A = read_matrix(tableLayoutPanel1);
                B = read_matrix(tableLayoutPanel2);
                fill_matrix(tableLayoutPanel3, A - B);
            }
            if (calc_option == "mult")
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    A = read_matrix(tableLayoutPanel1);
                    B = read_matrix(tableLayoutPanel2);
                    fill_matrix(tableLayoutPanel3, A * B);
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    double scalar;
                    A = read_matrix(tableLayoutPanel1);
                    scalar = Convert.ToDouble(textBox1.Text);
                    fill_matrix(tableLayoutPanel3, A * scalar);
                }
            }
        }
    }
}
