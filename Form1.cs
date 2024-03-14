namespace Calculator_22521698
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string Caltotal;
        double num1;
        double num2;
        string option;
        double result;


        private void txtBoard_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt1_Click(object sender, EventArgs e)
        {
            txtBoard.Text = txtBoard.Text + bt1.Text;
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            txtBoard.Text = txtBoard.Text + bt2.Text;
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            txtBoard.Text = txtBoard.Text + bt3.Text;
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            txtBoard.Text = txtBoard.Text + bt4.Text;
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            txtBoard.Text = txtBoard.Text + bt5.Text;
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            txtBoard.Text = txtBoard.Text + bt6.Text;
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            txtBoard.Text = txtBoard.Text + bt7.Text;
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            txtBoard.Text = txtBoard.Text + bt8.Text;
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            txtBoard.Text = txtBoard.Text + bt9.Text;
        }

        private void bt0_Click(object sender, EventArgs e)
        {
            txtBoard.Text = txtBoard.Text + bt0.Text;
        }
        private void btcham_Click(object sender, EventArgs e)
        {
            txtBoard.Text = txtBoard.Text + btcham.Text;
        }
        private void btp_Click(object sender, EventArgs e)
        {
            option = "+";
            num1 = double.Parse(txtBoard.Text);

            txtBoard.Clear();
        }

        private void btt_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = double.Parse(txtBoard.Text);

            txtBoard.Clear();
        }

        private void btm_Click(object sender, EventArgs e)
        {
            option = "*";
            num1 = double.Parse(txtBoard.Text);

            txtBoard.Clear();
        }

        private void btc_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = double.Parse(txtBoard.Text);

            txtBoard.Clear();
        }

        private void btb_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(txtBoard.Text);
            if (option == ("+"))
            {
                result = num1 + num2;
                txtBoard.Text = result + "";
            }
            if (option == ("-"))
            {
                result = num1 - num2;
                txtBoard.Text = result + "";
            }
            if (option == ("*"))
            {
                result = num1 * num2;
                txtBoard.Text = result + "";
            }
            if (option == ("/"))
            {
                if (num2 == '0')
                {
                    txtBoard.Text = "Error";
                }
                else
                {
                    result = num1 / num2;
                    txtBoard.Text = result + "";
                }
}

        }

        private void bta_Click(object sender, EventArgs e)
        {
            txtBoard.Clear();
            result = (0);
            num1 = (0);
            num2 = (0);

        }

        private void btd_Click(object sender, EventArgs e)
        {
            string curText = txtBoard.Text;
            if (curText.Length <= 1)
            {
                txtBoard.Text = " ";
            }
            else
            {
                txtBoard.Text = curText.Substring(0,curText.Length - 1);
            }
        }
    }
}