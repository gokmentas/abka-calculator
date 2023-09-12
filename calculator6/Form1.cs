namespace calculator6
{
    public partial class Form1 : Form
    {
        bool optState = false;
        double result = 0;
        string opt = "";
        bool exp_click = false;
        double undoResult = 0;
        bool eq_click = false;
        string undoRichTextbox ="";
        double storedValue = 0;
        public Form1()
        {
            InitializeComponent();
        }

        void colorize()
        {
            btn_n1.BackColor = Color.DarkSeaGreen;
            btn_n2.BackColor = Color.DarkSeaGreen;
            btn_n3.BackColor = Color.DarkSeaGreen;
            btn_n4.BackColor = Color.DarkSeaGreen;
            btn_n5.BackColor = Color.DarkSeaGreen;
            btn_n6.BackColor = Color.DarkSeaGreen;
            btn_n7.BackColor = Color.DarkSeaGreen;
            btn_n8.BackColor = Color.DarkSeaGreen;
            btn_n9.BackColor = Color.DarkSeaGreen;
            btn_n0.BackColor = Color.DarkSeaGreen;
            btn_add.BackColor = Color.LightSeaGreen;
            btn_subs.BackColor = Color.LightSeaGreen;
            btn_multi.BackColor = Color.LightSeaGreen;
            btn_divide.BackColor = Color.LightSeaGreen;
            btn_add.BackColor = Color.LightSeaGreen;
            btn_subs.BackColor = Color.LightSeaGreen;
            btn_multi.BackColor = Color.LightSeaGreen;
            btn_divide.BackColor = Color.LightSeaGreen;
            btn_exp.BackColor = Color.MediumPurple;
            btn_percent.BackColor = Color.MediumPurple;
            btn_fact.BackColor = Color.MediumPurple;
            btn_sqrt.BackColor = Color.MediumPurple;
            btn_clear.BackColor = Color.LightCoral;
            btn_ce.BackColor = Color.LightCoral;
            btn_equals.BackColor = Color.Khaki;
            btn_store.BackColor = Color.LightCoral;
            btn_empty.BackColor = Color.LightCoral;
            btn_call.BackColor = Color.LightCoral;
            btn_strClear.BackColor = Color.LightCoral;
            
        }
        private void numberEvent(object sender, EventArgs e)
        {
            
            exp_click = true;
            if (txt_result.Text == "0" || optState)
                txt_result.Clear();

            exp_click = false;

            optState = false;
            Button btn = (Button)sender;
            txt_result.Text += btn.Text;
            richTextBox1.Text += btn.Text;
            btn.Focus();

        }

        private void optEvent(object sender, EventArgs e)
        {
            optState = true;
            Button btn = (Button)sender;
            btn.Focus();
            string secondOpt = btn.Text;
            

            if (exp_click)
            {
                MessageBox.Show("HATA!");
                txt_result.Text = "1";
            }



            switch (opt)
            {
                case "+": txt_result.Text = (result + Double.Parse(txt_result.Text)).ToString(); break;
                case "-": txt_result.Text = (result - Double.Parse(txt_result.Text)).ToString(); break;
                case "X": txt_result.Text = (result * Double.Parse(txt_result.Text)).ToString(); break;
                case "%": txt_result.Text = ((result / 100) * Double.Parse(txt_result.Text)).ToString(); break;
                case "^":
                    double sum = 1;
                    for (int i = 0; i < Double.Parse(txt_result.Text); i++)
                    {
                        sum *= result;
                        
                    }
                    txt_result.Text = sum.ToString();
                    break;
                case "÷":
                    if (Double.Parse(txt_result.Text) == 0)
                    {
                        txt_result.Text = "HATA!";
                    }
                    else
                    {
                        txt_result.Text = (result / Double.Parse(txt_result.Text)).ToString(); break;
                    }
                    break;
            }
            try
            {
                if (txt_result.Text == "HATA!")
                {
                    MessageBox.Show("HATA!");
                }
                else
                {
                    result = Double.Parse(txt_result.Text);
                    
                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Lütfen bir sayı girin");
            }

            if (eq_click)
            {
                richTextBox1.Text = "Ans" + btn.Text;
            }
            else
            {
                richTextBox1.Text += btn.Text;
            }

            txt_result.Text = result.ToString();
            
            opt = secondOpt;

            

        }

        private void btn_ce_Click(object sender, EventArgs e)
        {
            eq_click = false;
            txt_result.Text = "0";
            Button btn = (Button)sender;
            richTextBox1.Text = "";
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            eq_click = false;
            txt_result.Text = "0";
            opt = "";
            result = 0;
            storedValue = 0;
            
            optState = false;
            Button btn = (Button)sender;
            richTextBox1.Text += btn.Text;
            richTextBox1.Text = "";
            undoResult = 0;
            undoRichTextbox = "";
        }

        private void btn_equals_Click(object sender, EventArgs e)
        {
            optState = true;
            Button btn = (Button)sender;
            eq_click = true;

            switch (opt)
            {
                case "+": txt_result.Text = (result + Double.Parse(txt_result.Text)).ToString(); break;
                case "-": txt_result.Text = (result - Double.Parse(txt_result.Text)).ToString(); break;
                case "X": txt_result.Text = (result * Double.Parse(txt_result.Text)).ToString(); break;
                case "÷":
                    if (Double.Parse(txt_result.Text) == 0)
                    {
                        txt_result.Text = "HATA!";
                    }
                    else
                    {
                        txt_result.Text = (result / Double.Parse(txt_result.Text)).ToString(); break;
                    }
                    break;

                case "%": txt_result.Text = ((result / 100) * Double.Parse(txt_result.Text)).ToString(); break;
                case "^":
                    double sum = 1;
                    for (int i = 0; i < Double.Parse(txt_result.Text); i++)
                    {
                        sum *= result;
                        
                    }
                    txt_result.Text = sum.ToString();
                    break;
                case "!":
                    result = 1;
                    for (int i = 1; i <= Double.Parse(txt_result.Text); i++)
                    {
                        result *= i;
                        
                    }
                    txt_result.Text = result.ToString();
                    break;

            }
            if (txt_result.Text == "HATA!")
            {
                MessageBox.Show("HATA!");
            }
            else
            {
                result = Double.Parse(txt_result.Text);
                
            }
            richTextBox1.Text += btn.Text;
            txt_result.Text = result.ToString();
            undoResult = result;
            richTextBox1.AppendText(result + "\r\n");
            undoRichTextbox = richTextBox1.Text;

            opt = "";
        }

        private void btn_n3_MouseClick(object sender, MouseEventArgs e)
        {
            colorize();
            btn_n3.BackColor = Color.Silver;
        }

        private void btn_n2_MouseClick(object sender, MouseEventArgs e)
        {
            colorize();
            btn_n2.BackColor = Color.Silver;
        }

        private void btn_n1_MouseClick(object sender, MouseEventArgs e)
        {
            colorize();
            btn_n1.BackColor = Color.Silver;
        }

        private void btn_n4_MouseClick(object sender, MouseEventArgs e)
        {
            colorize();
            btn_n4.BackColor = Color.Silver;
        }

        private void btn_n5_MouseClick(object sender, MouseEventArgs e)
        {
            colorize();
            btn_n5.BackColor = Color.Silver;
        }

        private void btn_n6_MouseClick(object sender, MouseEventArgs e)
        {
            colorize();
            btn_n6.BackColor = Color.Silver;
        }

        private void btn_n7_MouseClick(object sender, MouseEventArgs e)
        {
            colorize();
            btn_n7.BackColor = Color.Silver;
        }

        private void btn_n8_MouseClick(object sender, MouseEventArgs e)
        {
            colorize();
            btn_n8.BackColor = Color.Silver;
        }

        private void btn_n9_MouseClick(object sender, MouseEventArgs e)
        {
            colorize();
            btn_n9.BackColor = Color.Silver;
        }

        private void btn_n0_MouseClick(object sender, MouseEventArgs e)
        {
            colorize();
            btn_n0.BackColor = Color.Silver;
        }

        private void btn_clear_MouseClick(object sender, MouseEventArgs e)
        {
            colorize();
            btn_clear.BackColor = Color.Silver;
        }

        private void btn_equals_MouseClick(object sender, MouseEventArgs e)
        {
            colorize();
            btn_equals.BackColor = Color.Silver;
        }

        private void btn_ce_MouseClick(object sender, MouseEventArgs e)
        {
            colorize();
            btn_ce.BackColor = Color.Silver;
        }

        private void btn_add_MouseClick(object sender, MouseEventArgs e)
        {
            colorize();
            btn_add.BackColor = Color.Silver;
        }

        private void btn_subs_MouseClick(object sender, MouseEventArgs e)
        {
            colorize();
            btn_subs.BackColor = Color.Silver;
        }

        private void btn_multi_MouseClick(object sender, MouseEventArgs e)
        {
            colorize();
            btn_multi.BackColor = Color.Silver;
        }

        private void btn_divide_MouseClick(object sender, MouseEventArgs e)
        {
            colorize();
            btn_divide.BackColor = Color.Silver;
        }

        private void btn_exp_MouseClick(object sender, MouseEventArgs e)
        {
            colorize();
            btn_exp.BackColor = Color.Silver;
            exp_click = true;
        }

        private void btn_percent_MouseClick(object sender, MouseEventArgs e)
        {
            colorize();
            btn_percent.BackColor = Color.Silver;
        }

        private void btn_fact_MouseClick(object sender, MouseEventArgs e)
        {
            colorize();
            btn_fact.BackColor = Color.Silver;
            double num1 = Double.Parse(txt_result.Text);
            double result1 = 1;
            
            for (int i = 1; i <= num1; i++)
            {
                result1 *= i;
            }
            txt_result.Text = result1.ToString();

        }

        private void btn_sqrt_MouseClick(object sender, MouseEventArgs e)
        {
            colorize();
            btn_sqrt.BackColor = Color.Silver;
            double num1 = Double.Parse(txt_result.Text);
            txt_result.Text = Math.Sqrt(num1).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorize();
            btn_store.BackColor = Color.Silver;
            storedValue += double.Parse(txt_result.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            colorize();
            btn_empty.BackColor = Color.Silver;
            storedValue -= double.Parse(txt_result.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            colorize();
            btn_call.BackColor = Color.Silver;
            richTextBox1.Text += storedValue.ToString();
            txt_result.Text = storedValue.ToString();
        }

        private void btn_undo_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = undoRichTextbox;
            txt_result.Text = undoResult.ToString();
            result = 0;
            optState = false;
        }

        private void btn_strClear_Click(object sender, EventArgs e)
        {
            colorize();
            btn_strClear.BackColor = Color.Silver;
            storedValue = 0;
        }
    }
}