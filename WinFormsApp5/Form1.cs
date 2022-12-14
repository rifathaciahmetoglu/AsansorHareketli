namespace WinFormsApp5
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        int secim = 0;


        private void Button6_Click(object sender, EventArgs e)
        {
            secim = 6;
            timer1.Enabled = true;
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            secim = 1;
            timer1.Enabled = true;

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            secim = 2;
            timer1.Enabled = true;
            
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            secim = 3;
            timer1.Enabled = true;
            
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            secim = 4;
            timer1.Enabled = true;
            
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            secim = 5;
            timer1.Enabled = true;
            
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            secim = 7;
            timer1.Enabled = true;
            


        }

        private void Timer1_Tick(object sender, EventArgs e)
        {



            button2.BackColor = Color.White;
            button1.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;



            Random rastgele = new();
            int kisi = rastgele.Next(-1, 6);

            

            if (secim == 8)
            {
                button8.BackColor = Color.White;
                if (kisi==1)
                {
                    Button1_Click(sender, e);
                    button1.BackColor = Color.Red;
                    
                    
                }
                if (kisi == 2)
                {
                    Button2_Click(sender, e);
                    button2.BackColor = Color.Red;
                    

                }
                if (kisi == 3)
                {
                    Button3_Click(sender, e);
                    button3.BackColor = Color.Red;
                    

                }
                if (kisi == 4)
                {
                    Button4_Click(sender, e);
                    button4.BackColor = Color.Red;
                    

                }
                if (kisi == 5)
                {
                    Button5_Click(sender, e);
                    button5.BackColor = Color.Red;
                    

                }
                if (kisi == 6)
                {
                    Button6_Click(sender, e);
                    button6.BackColor = Color.Red;
                    ;
                    
                }

               // label1.Text = kisi.ToString();

            }
            


            Random rast = new();
            int asansor = rast.Next(-1, 6);
            button2.BackColor = Color.White;
            button1.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            
            if (secim == 9)
            {
                button9.BackColor = Color.White;

                if (asansor == 1)
                {
                    Button1_Click(sender, e);
                    

                }
                if (asansor == 2)
                {
                    Button2_Click(sender, e);
                    

                }
                if (asansor == 3)
                {
                    Button3_Click(sender, e);
                    

                }
                if (asansor == 4)
                {
                    Button4_Click(sender, e);
                    

                }
                if (asansor == 5)
                {
                    Button5_Click(sender, e);
                    

                }
                if (asansor == 6)
                {
                    Button6_Click(sender, e);
                    
                }

             


            }



            if (secim == 1)
            {

                button1.BackColor = Color.Red;
                if (button7.Top > button1.Top)
                {
                    button7.Top--;
                }

                if (button7.Top < button1.Top)
                {
                    button7.Top++;
                }
                textBox1.Text = "Kat 1";
                textBox1.ForeColor = Color.Red;
                textBox1.TextAlign = HorizontalAlignment.Center;

            }

            if (secim == 2)
            {
                button2.BackColor = Color.Red;
                if (button7.Top > button2.Top)
                {
                    button7.Top--;
                }

                if (button7.Top < button2.Top)
                {
                    button7.Top++;
                }
                textBox1.Text = "Kat 2";
                textBox1.ForeColor = Color.Red;
                textBox1.TextAlign = HorizontalAlignment.Center;

            }

            if (secim == 3)
            {
                button3.BackColor = Color.Red;
                if (button7.Top > button3.Top)
                {
                    button7.Top--;
                }

                if (button7.Top < button3.Top)
                {
                    button7.Top++;
                }
                textBox1.Text = "Kat 3";
                textBox1.ForeColor = Color.Red;
                textBox1.TextAlign = HorizontalAlignment.Center;
            }
            if (secim == 4)
            {
                button4.BackColor = Color.Red;
                if (button7.Top > button4.Top)
                {
                    button7.Top--;
                }

                if (button7.Top < button4.Top)
                {
                    int v = button7.Top
                                            + 1;
                    button7.Top = v;

                }
                textBox1.Text = "Kat 4";
                textBox1.ForeColor = Color.Red;
                textBox1.TextAlign = HorizontalAlignment.Center;

            }
            if (secim == 5)
            {
                button5.BackColor = Color.Red;
                if (button7.Top > button5.Top)
                {
                    button7.Top--;
                }

                if (button7.Top < button5.Top)
                {
                    button7.Top++;
                }
                textBox1.Text = "Kat 5";
                textBox1.ForeColor = Color.Red;
                textBox1.TextAlign = HorizontalAlignment.Center;
            }
            if (secim == 6)
            {
                button6.BackColor = Color.Red;
                if (button7.Top > button6.Top)
                {
                    button7.Top--;
                }

                if (button7.Top < button6.Top)
                {
                    button7.Top++;
                }
                textBox1.Text = "Zemin kat";
                textBox1.ForeColor = Color.Red;
                textBox1.TextAlign = HorizontalAlignment.Center;
            }



        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = true;
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            secim = 8;
            timer1.Enabled = true;

            
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            secim = 9;
            timer1.Enabled = true;
            timer1.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = false;
            
        }
    }
}