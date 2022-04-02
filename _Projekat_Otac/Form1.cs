namespace _Projekat_Otac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            BackColor = Color.Blue;

            label1.Hide();
                label1.Text = "0";
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            textBox1.Hide();
            panel1.Hide();
            button2.Hide();
            label6.Hide();
            label7.Hide();
            label8.Hide();
            button1.Hide();
            label9.Hide();
            label10.Hide();
            panel2.Hide();
            textBox2.Hide();
            pictureBox3.Hide();
            button8.Hide();
            button9.Hide();
            label11.Hide();
            button10.Hide();
            button11.Hide();
            button12.Hide();

            button3.Show();
            button3.Location = new Point(250, 250);
            button3.Size = new Size(210, 75);
            button4.Show();
            button4.Location = new Point(500, 250);
            button4.Size = new Size(210, 75);
            button6.Show();
            button6.Location = new Point(250, 350);
            button6.Size = new Size(210, 75);
            button7.Show();
            button7.Location = new Point(500, 350);
            button7.Size = new Size(210, 75);
            button5.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        char KVIZ(char[] redosled, int i)
        {
            if (redosled[i] == 'a')
                pictureBox1.Image = Properties.Resources.A;
            else if (redosled[i] == 'b')
                pictureBox1.Image = Properties.Resources.B;
            else if (redosled[i] == 'c')
                pictureBox1.Image = Properties.Resources.C;
            else if (redosled[i] == 'd')
                pictureBox1.Image = Properties.Resources.D;
            else if (redosled[i] == 'e')
                pictureBox1.Image = Properties.Resources.E;
            else if (redosled[i] == 'f')
                pictureBox1.Image = Properties.Resources.F;
            else if (redosled[i] == 'g')
                pictureBox1.Image = Properties.Resources.G;
            else if (redosled[i] == 'h')
                pictureBox1.Image = Properties.Resources.H;
            else if (redosled[i] == 'i')
                pictureBox1.Image = Properties.Resources.I;
            else if (redosled[i] == 'j')
                pictureBox1.Image = Properties.Resources.J;
            else if (redosled[i] == 'k')
                pictureBox1.Image = Properties.Resources.K;
            else if (redosled[i] == 'l')
                pictureBox1.Image = Properties.Resources.L;
            else if (redosled[i] == 'm')
                pictureBox1.Image = Properties.Resources.M;
            else if (redosled[i] == 'n')
                pictureBox1.Image = Properties.Resources.N;
            else if (redosled[i] == 'o')
                pictureBox1.Image = Properties.Resources.O;
            else if (redosled[i] == 'p')
                pictureBox1.Image = Properties.Resources.P;
            else if (redosled[i] == 'q')
                pictureBox1.Image = Properties.Resources.Q;
            else if (redosled[i] == 'r')
                pictureBox1.Image = Properties.Resources.R;
            else if (redosled[i] == 's')
                pictureBox1.Image = Properties.Resources.S;
            else if (redosled[i] == 't')
                pictureBox1.Image = Properties.Resources.T;
            else if (redosled[i] == 'u')
                pictureBox1.Image = Properties.Resources.U;
            else if (redosled[i] == 'v')
                pictureBox1.Image = Properties.Resources.V;
            else if (redosled[i] == 'w')
                pictureBox1.Image = Properties.Resources.W;
            else if (redosled[i] == 'x')
                pictureBox1.Image = Properties.Resources.X;
            else if (redosled[i] == 'y')
                pictureBox1.Image = Properties.Resources.Y;
            else if (redosled[i] == 'z')
                pictureBox1.Image = Properties.Resources.Z;

            pictureBox1.BringToFront();

            return redosled[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (int.Parse(label1.Text) < int.Parse(label5.Text))
            {
                char[] redosled = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

                Random random = new Random();
                var random_i = random.Next(0, 26);
                char most = redosled[0];
                redosled[0] = redosled[random_i];
                redosled[random_i] = most;

                char unos;
                if (textBox1.Text.Length == 1)
                    unos = char.Parse(textBox1.Text.ToLower());
                else
                    unos = '?';

                if (button3.Location != new Point(385, 375))
                {
                    button4.Hide();
                    button5.Hide();
                    button6.Hide();
                    button7.Hide();

                    label1.Show();
                    label4.Show();
                    label5.Show();
                    textBox1.Show();
                    panel1.Show();
                    pictureBox1.Show();
                    button2.Location = new Point(10, 10);
                    button2.Size = new Size(75, 75);
                    button2.Show();

                    button3.Location = new Point(385, 375);
                    button3.Size = new Size(210, 75);
                    if (label11.Text == "Srpski")
                        button4.Text = "Potvrdite broj";
                    else
                        button4.Text = "Acknowledge the number";

                }
                else
                {
                    if (char.Parse(label3.Text) == unos)
                    {
                        if (label11.Text == "Srpski")
                            label2.Text = "TACNO";
                        else
                            label2.Text = "CORRECT";
                        label2.ForeColor = Color.Green;
                        label2.Show();
                        textBox1.Text = "";
                        label7.Text = (int.Parse(label7.Text) + 1).ToString();
                    }
                    else
                    {
                        if (label11.Text == "Srpski")
                            label2.Text = "GRESKA";
                        else
                            label2.Text = "WRONG";
                        label2.ForeColor = Color.Red;
                        label2.Show();
                        textBox1.Text = "";
                    }
                    label1.Text = (int.Parse(label1.Text) + 1).ToString();
                }

                label3.Text = KVIZ(redosled, 0).ToString();
            }
            else
            {
                button3.Hide();
                label1.Hide();
                label2.Hide();
                label4.Hide();
                label5.Hide();
                textBox1.Hide();
                panel1.Hide();

                label6.Show();
                if (label11.Text == "Srpski")
                    label6.Text = "Vas rezultat je";
                else
                    label6.Text = "Your score is";
                label7.Show();
                label8.Show();
                if (label11.Text == "Srpski")
                    label8.Text = "od 26";
                else
                    label8.Text = "out of 26";
                button2.Location = new Point(530, 175);
                button2.Size = new Size(280, 180);
                button2.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (int.Parse(label9.Text) >= 1)
            {
                if (int.Parse(label9.Text) == 1)
                {
                    if (label11.Text == "Srpski")
                        button4.Text = "Zavrsi";
                    else
                        button4.Text = "End";
                }
                   
                char[] redosled = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

                Random random = new Random();
                var random_i = random.Next(0, 26);
                char most = redosled[0];
                redosled[0] = redosled[random_i];
                redosled[random_i] = most;

                char unos;
                if (textBox1.Text.Length == 1)
                    unos = char.Parse(textBox1.Text.ToLower());
                else
                    unos = '?';

                if (button4.Location != new Point(385, 375))
                {
                    button3.Hide();
                    button5.Hide();
                    button6.Hide();
                    button7.Hide();

                    textBox1.Show();
                    panel1.Show();
                    label7.Show();
                    label9.Show();
                    label10.Show();
                    label6.Show();
                    pictureBox1.Show();
                    button2.Location = new Point(10, 10);
                    button2.Size = new Size(75, 75);
                    button2.Show();

                    button4.Location = new Point(385, 375);
                    button4.Size = new Size(210, 75);
                    if (label11.Text == "Srpski")
                        button3.Text = "Potvrdite broj";
                    else
                        button3.Text = "Acknowledge the number";

                    label9.Text = "3";
                }
                else
                {
                    if (char.Parse(label3.Text) == unos)
                    {
                        if (label11.Text == "Srpski")
                            label2.Text = "TACNO";
                        else
                            label2.Text = "CORRECT";
                        label2.ForeColor = Color.Green;
                        label2.Show();
                        textBox1.Text = "";
                        label7.Text = (int.Parse(label7.Text) + 1).ToString();
                    }
                    else
                    {
                        if (label11.Text == "Srpski")
                            label2.Text = "GRESKA";
                        else
                            label2.Text = "WRONG";
                        label2.ForeColor = Color.Red;
                        label2.Show();
                        textBox1.Text = "";
                        label9.Text = (int.Parse(label9.Text) - 1).ToString();
                    }
                }

                label3.Text = KVIZ(redosled, 0).ToString();
            }
            else
            {
                button4.Hide();
                label2.Hide();
                textBox1.Hide();
                panel1.Hide();
                label9.Hide();
                label10.Hide();

                label6.Show();
                button2.Location = new Point(530, 175);
                button2.Size = new Size(280, 180);
                button2.Show();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {   
            panel1.Hide();
            pictureBox1.Hide();
            textBox1.Hide();
            label1.Hide();
            label1.Text = "0";
            label2.Hide();
            label3.Hide();
            label3.Text = "?";
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();
            label7.Text = "0";
            label8.Hide();
            button2.Hide();
            label9.Hide();
                label9.Text = "3";
            label10.Hide();
            panel2.Hide();
            pictureBox3.Hide();
            textBox2.Hide();
            button8.Hide();
            button9.Hide();
            button10.Hide();
            button11.Hide();
            button12.Hide();

            if (label11.Text == "Srpski")
            {
                button3.Text = "Munjevita runda";
                button4.Text = "Prezivljavanje";
                button5.Text = "Izadji";
                button6.Text = "Galerija";
                button7.Text = "Opcije";
            }
            else
            {
                button3.Text = "Blitz";
                button4.Text = "Survival";
                button5.Text = "Exit";
                button6.Text = "Galery";
                button7.Text = "Options";
            }
            button3.Show();
                button3.Location = new Point(250, 250);
                button3.Size = new Size(210, 75);
            button4.Show();
                button4.Location = new Point(500, 250);
                button4.Size = new Size(210, 75);
            button6.Show();
                button6.Location = new Point(250, 350);
                button6.Size = new Size(210, 75);
            button7.Show();
                button7.Location = new Point(500, 350);
                button7.Size = new Size(210, 75);
            button5.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (label11.Text == "Srpski")
                button6.Text = "Vizualizuj slovo";
            else
                button6.Text = "Visualise the letter";

            button3.Hide();
            button4.Hide();
            button5.Hide();
            button7.Hide();

            textBox2.Show();
            pictureBox3.Show();
            panel2.Show();
            button2.Location = new Point(10, 10);
            button2.Size = new Size(75, 75);
            button2.Show();

            char unos;
            if (textBox2.Text.Length == 1)
                unos = char.Parse(textBox2.Text.ToLower());
            else
                unos = 'a';

            if (unos == 'a')
                pictureBox3.Image = Properties.Resources.Au;
            else if (unos == 'b')
                pictureBox3.Image = Properties.Resources.Bu;
            else if (unos == 'c')
                pictureBox3.Image = Properties.Resources.Cu;
            else if (unos == 'd')
                pictureBox3.Image = Properties.Resources.Du;
            else if (unos == 'e')
                pictureBox3.Image = Properties.Resources.Eu;
            else if (unos == 'f')
                pictureBox3.Image = Properties.Resources.Fu;
            else if (unos == 'g')
                pictureBox3.Image = Properties.Resources.Gu;
            else if (unos == 'h')
                pictureBox3.Image = Properties.Resources.Hu;
            else if (unos == 'i')
                pictureBox3.Image = Properties.Resources.Iu;
            else if (unos == 'j')
                pictureBox3.Image = Properties.Resources.Ju;
            else if (unos == 'k')
                pictureBox3.Image = Properties.Resources.Ku;
            else if (unos == 'l')
                pictureBox3.Image = Properties.Resources.Lu;
            else if (unos == 'm')
                pictureBox3.Image = Properties.Resources.Mu;
            else if (unos == 'n')
                pictureBox3.Image = Properties.Resources.Nu;
            else if (unos == 'o')
                pictureBox3.Image = Properties.Resources.Ou;
            else if (unos == 'p')
                pictureBox3.Image = Properties.Resources.Pu;
            else if (unos == 'q')
                pictureBox3.Image = Properties.Resources.Qu;
            else if (unos == 'r')
                pictureBox3.Image = Properties.Resources.Ru;
            else if (unos == 's')
                pictureBox3.Image = Properties.Resources.Su;
            else if (unos == 't')
                pictureBox3.Image = Properties.Resources.Tu;
            else if (unos == 'u')
                pictureBox3.Image = Properties.Resources.Uu;
            else if (unos == 'v')
                pictureBox3.Image = Properties.Resources.Vu;
            else if (unos == 'w')
                pictureBox3.Image = Properties.Resources.Wu;
            else if (unos == 'x')
                pictureBox3.Image = Properties.Resources.Xu;
            else if (unos == 'y')
                pictureBox3.Image = Properties.Resources.Yu;
            else if (unos == 'z')
                pictureBox3.Image = Properties.Resources.Zu;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            button3.Hide();
            button4.Hide();
            button5.Hide();
            button6.Hide();
            button7.Hide();

            button8.Show();
            button9.Show();
            button10.Show();
            button11.Show();
            button12.Show();
            button2.Location = new Point(10, 10);
            button2.Size = new Size(75, 75);
            button2.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label11.Text = "Srpski";

            button2.Text = "Meni";
            button10.Text = "Plava";
            button11.Text = "Bela";
            button12.Text = "Boja mog podruma";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label11.Text = "Engleski";

            button2.Text = "Menu";
            button10.Text = "Blue";
            button11.Text = "White";
            button12.Text = "The color of blood";
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            BackColor = Color.Blue;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            BackColor = Color.White;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            BackColor = Color.Red;
        }
    }
}