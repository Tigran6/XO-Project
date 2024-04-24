using System.Globalization;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

namespace XO_5in5
{
    public partial class Form1 : Form
    {   
        int a = 0;
        int b = 0;
        public  Button[,] button;
       
        int player = 0;
       
        int computer = 0;
        public Form1()
        {
            
            InitializeComponent();
            button = new Button[5, 5];
            int ctn = 0;
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                {
                    button[i, j] = new Button();
                    button[i, j].Parent = panel1;
                    button[i, j].Width = panel1.Width / 8;
                    button[i, j].Height = panel1.Height / 8;
                    button[i, j].Top = i * panel1.Height / 6;
                    button[i, j].Left = j * panel1.Width / 6;
                    button[i, j].Click += new EventHandler(onclick);
                    button[i, j].Tag = ctn;
                    button[i, j].Font = new Font(button[i, j].Font.FontFamily, 16);
                    ctn++;
                }
        }
       
        public void checkVictory(int i, int j)
        {
            if (j < 2 && button[i, j].Text != "" && button[i, j].Text == button[i, j + 1].Text && button[i, j + 1].Text == button[i, j + 2].Text && button[i, j + 2].Text == button[i, j + 3].Text)
            {
                if (button[i, j].Text == "x")
                {
                    button[i, j].BackColor = Color.Lime;
                    button[i, j + 1].BackColor = Color.Lime;
                    button[i, j + 2].BackColor = Color.Lime;
                    button[i, j + 3].BackColor = Color.Lime;
                    MessageBox.Show("X win");
                    player++;
                    label1.Text = "player" + " - " + Convert.ToString(player);

                }
                else if (button[i, j].Text == "0")
                {
                    button[i, j].BackColor = Color.Aqua;
                    button[i, j + 1].BackColor = Color.Aqua;
                    button[i, j + 2].BackColor = Color.Aqua;
                    button[i, j + 3].BackColor = Color.Aqua;
                    MessageBox.Show("O win");
                    computer++;
                    label2.Text = "computer" + " - " + Convert.ToString(computer);

                }
                restart();
                a = -1;
                return;
            }
            else if (i < 2 && button[i, j].Text != "" && button[i, j].Text == button[i + 1, j].Text && button[i + 1, j].Text == button[i + 2, j].Text && button[i + 2, j].Text == button[i + 3, j].Text)
            {
                if (button[i, j].Text == "x")
                {
                    button[i, j].BackColor = Color.Lime;
                    button[i + 1, j].BackColor = Color.Lime;
                    button[i + 2, j].BackColor = Color.Lime;
                    button[i + 3, j].BackColor = Color.Lime;
                    MessageBox.Show("X win");
                    player++;
                    label1.Text = "player" + " - " + Convert.ToString(player);
                }
                else if (button[i, j].Text == "0")
                {
                    button[i, j].BackColor = Color.FromArgb(255, 128, 128);
                    button[i + 1, j].BackColor = Color.FromArgb(255, 128, 128);
                    button[i + 2, j].BackColor = Color.FromArgb(255, 128, 128);
                    button[i + 3, j].BackColor = Color.FromArgb(255, 128, 128);
                    MessageBox.Show("O win");
                    computer++;
                    label2.Text = "computer" + " - " + Convert.ToString(computer);

                }
                restart();
                a = -1;
                return;
            }
            else if (j < 2 && i < 2 && button[i, j].Text != "" && button[i, j].Text == button[i + 1, j + 1].Text && button[i + 1, j + 1].Text == button[i + 2, j + 2].Text && button[i + 2, j + 2].Text == button[i + 3, j + 3].Text)
            {
                if (button[i, j].Text == "x")
                {
                    button[i, j].BackColor = Color.Lime;
                    button[i + 1, j + 1].BackColor = Color.Lime;
                    button[i + 2, j + 2].BackColor = Color.Lime;
                    button[i + 3, j + 3].BackColor = Color.Lime;
                    MessageBox.Show("X win");
                    player++;
                    label1.Text = "player" + " - " + Convert.ToString(player);

                }
                else if (button[i, j].Text == "0")
                {
                    button[i, j].BackColor = Color.FromArgb(255, 128, 128);
                    button[i + 1, j + 1].BackColor = Color.FromArgb(255, 128, 128);
                    button[i + 2, j + 2].BackColor = Color.FromArgb(255, 128, 128);
                    button[i + 3, j + 3].BackColor = Color.FromArgb(255, 128, 128);
                    MessageBox.Show("O win");
                    computer++;
                    label2.Text = "computer" + " - " + Convert.ToString(computer);

                }
                restart();
                a = -1;
                return;
            }
            else if (j < 2 && i > 2 && button[i, j].Text != "" && button[i, j].Text == button[i - 1, j + 1].Text && button[i - 1, j + 1].Text == button[i - 2, j + 2].Text && button[i - 2, j + 2].Text == button[i - 3, j + 3].Text)
            {
                if (button[i, j].Text == "x")
                {
                    button[i, j].BackColor = Color.Lime;
                    button[i - 1, j + 1].BackColor = Color.Lime;
                    button[i - 2, j + 2].BackColor = Color.Lime;
                    button[i - 3, j + 3].BackColor = Color.Lime;
                    MessageBox.Show("X win");
                    player++;
                    label1.Text = "player" + " - " + Convert.ToString(player);
                }
                else if (button[i, j].Text == "0")
                {
                    button[i, j].BackColor = Color.FromArgb(255, 128, 128);
                    button[i - 1, j + 1].BackColor = Color.FromArgb(255, 128, 128);
                    button[i - 2, j + 2].BackColor = Color.FromArgb(255, 128, 128);
                    button[i - 3, j + 3].BackColor = Color.FromArgb(255, 128, 128);
                    MessageBox.Show("O win");
                    computer++;
                    label2.Text = "computer" + " - " + Convert.ToString(computer);
                }
                restart();
                a = -1;
                return;
            }

        }
        public void check1()
        {
            if (a == 0)
            {
                for (int i = 0; i < 5; i++)
                    for (int j = 0; j < 5; j++)
                    {

                        button[i, j].Enabled = true;
                    }
                for (int i = 0; i < 5; i++)
                    for (int j = 0; j < 5; j++)
                    {
                        if (button[i, j].Text == "x" && button[2, 2].Text != "x")
                        {
                            button[2, 2].Text = "0";
                            button[2, 2].Enabled = false;
                            a++;
                            return;
                            
                        }
                        if (button[2, 2].Text == "x")
                        {
                            button[3, 3].Text = "0";
                            button[3, 3].Enabled = false;
                            a++;
                            return;
                            
                        }
                    }
            }
        }
        public void check2()
        {
            if (a == 1)
            {
                if (button[3, 3].Text == "x" && button[2, 2].Text == "x" && button[1, 1].Text == "")
                {
                    button[1, 1].Text = "0";
                    button[1, 1].Enabled = false;
                    return;
                }
                else if (button[1, 3].Text == "x" && button[2, 2].Text == "x" && button[3, 1].Text == "")
                {
                    button[3, 1].Text = "0";
                    button[3, 1].Enabled = false;
                    return;
                }
                else if (button[3, 1].Text == "x" && button[2, 2].Text == "x" && button[1, 3].Text == "")
                {
                    button[1, 3].Text = "0";
                    button[1, 3].Enabled = false;
                    return;
                }
                //-----------------------------------------
                if (button[0, 0].Text == "x" && button[2, 2].Text == "x" && button[1, 1].Text == "")
                {
                    button[1, 1].Text = "0";
                    button[1, 1].Enabled = false;
                    return;
                }
                else if (button[0, 4].Text == "x" && button[2, 2].Text == "x" && button[1, 3].Text == "")
                {
                    button[1, 3].Text = "0";
                    button[1, 3].Enabled = false;
                    return;
                }
                else if (button[4, 4].Text == "x" && button[2, 2].Text == "x" && button[3, 2].Text == "")
                {
                    button[3, 2].Text = "0";
                    button[3, 2].Enabled = false;
                    return;
                }
                else if (button[4, 0].Text == "x" && button[2, 2].Text == "x" && button[3, 1].Text == "")
                {
                    button[3, 1].Text = "0";
                    button[3, 1].Enabled = false;
                    return;
                }
                //------------------------------------------------
                //-------------------------------------------------
                if (button[2, 2].Text == "x" && button[0, 2].Text == "x" && button[1, 2].Text == "")
                {
                    button[1, 2].Text = "0";
                    button[1, 2].Enabled = false;
                    return;
                }
                else if (button[2, 2].Text == "x" && button[2, 4].Text == "x" && button[2, 3].Text == "")
                {
                    button[2, 3].Text = "0";
                    button[2, 3].Enabled = false;
                    return;
                }
                else if (button[2, 2].Text == "x" && button[4, 2].Text == "x" && button[3, 2].Text == "")
                {
                    button[3, 2].Text = "0";
                    button[3, 2].Enabled = false;
                    return;
                }
                else if (button[2, 2].Text == "x" && button[2, 0].Text == "x" && button[2, 1].Text == "")
                {
                    button[2, 1].Text = "0";
                    button[2, 1].Enabled = false;
                    return;
                }
                //----------------------------------------------------
                //----------------------------------------------------
                if (button[2, 2].Text == "x" && button[2, 1].Text == "x" && button[2, 3].Text == "")
                {
                    button[2, 3].Text = "0";
                    button[2, 3].Enabled = false;
                    return;
                }
                if (button[2, 2].Text == "x" && button[1, 1].Text == "x" && button[3, 2].Text == "")
                {
                    button[1, 3].Text = "0";
                    button[1, 3].Enabled = false;
                    return;
                }
                if (button[2, 2].Text == "x" && button[1, 2].Text == "x" && button[3, 2].Text == "")
                {
                    button[3, 2].Text = "0";
                    button[3, 2].Enabled = false;
                    return;
                }
                if (button[2, 2].Text == "x" && button[1, 3].Text == "x" && button[3, 1].Text == "")
                {
                    button[3, 1].Text = "0";
                    button[3, 1].Enabled = false;
                    return;
                }
                if (button[2, 2].Text == "x" && button[2, 3].Text == "x" && button[2, 1].Text == "")
                {
                    button[2, 1].Text = "0";
                    button[2, 1].Enabled = false;
                    return;
                }
                if (button[2, 2].Text == "x" && button[3, 2].Text == "x" && button[1, 2].Text == "")
                {
                    button[1, 2].Text = "0";
                    button[1, 2].Enabled = false;
                    return;
                }
                if (button[2, 2].Text == "x" && button[3, 1].Text == "x" && button[1, 3].Text == "")
                {
                    button[1, 3].Text = "0";
                    button[1, 3].Enabled = false;
                    return;
                }
                //----------------------------------------------
                if ((button[2, 2].Text == "x" && button[1, 0].Text == "x") || (button[2, 2].Text == "x" && button[0, 1].Text == "x" && button[1, 1].Text == ""))
                {
                    button[1, 1].Text = "0";
                    button[1, 1].Enabled = false;
                    return;
                }
                else if ((button[2, 2].Text == "x" && button[0, 3].Text == "x") || (button[2, 2].Text == "x" && button[1, 4].Text == "x" && button[1, 3].Text == ""))
                {
                    button[1, 3].Text = "0";
                    button[1, 3].Enabled = false;
                    return;
                }
                else if ((button[2, 2].Text == "x" && button[3, 4].Text == "x") || (button[2, 2].Text == "x" && button[4, 3].Text == "x" && button[3, 3].Text == ""))
                {
                    button[3, 2].Text = "0";
                    button[3, 2].Enabled = false;
                    return;
                }
                else if ((button[2, 2].Text == "x" && button[3, 0].Text == "x") || (button[2, 2].Text == "x" && button[4, 1].Text == "x" && button[3, 1].Text == ""))
                {
                    button[3, 1].Text = "0";
                    button[3, 1].Enabled = false;
                    return;
                }
                //-------------------------------------------------
                //-------------------------------------------------
                for (int i = 0; i < 5; i++)
                    for (int j = 0; j < 5; j++)
                    {
                        if (i < 2 && button[i, j].Text == "x" && button[i + 1, j].Text == "x" && button[i + 2, j].Text == "")
                        {
                            button[i + 2, j].Text = "0";
                            button[i + 2, j].Enabled = false;
                            return;
                        }
                        if (i > 2 && button[i, j].Text == "x" && button[i - 1, j].Text == "x" && button[i - 2, j].Text == "")
                        {
                            button[i - 2, j].Text = "0";
                            button[i - 2, j].Enabled = false;
                            return;
                        }
                        //-------------------------------------------------
                        if (button[0, 2].Text == "x" && button[1, 2].Text == "x" && button[2, 2].Text == "0" && button[1, 3].Text == "")
                        {
                            button[1, 3].Text = "0";
                            button[1, 3].Enabled = false;
                            return;
                        }
                        if (button[0, 4].Text == "x" && button[1, 4].Text == "x" && button[1, 3].Text == "")
                        {
                            button[1, 3].Text = "0";
                            button[1, 3].Enabled = false;
                            return;
                        }
                        if (button[3, 2].Text == "x" && button[4, 2].Text == "x" && button[2, 2].Text == "0" && button[3, 3].Text == "")
                        {
                            button[3, 3].Text = "0";
                            button[3, 3].Enabled = false;
                            return;
                        }
                        //--------------------------------------------------
                        if (button[2, 3].Text == "x" && button[2, 4].Text == "x" && button[1, 3].Text == "")
                        {
                            button[1, 3].Text = "0";
                            button[1, 3].Enabled = false;
                            return;
                        }
                        if (j == 2 && button[i, j].Text == "x" && button[i, j + 1].Text == "x" && button[i, j - 1].Text == "")
                        {
                            button[i, j - 1].Text = "0";
                            button[i, j - 1].Enabled = false;
                            return;
                        }
                        //----------------------------------------------
                        if (button[0, 0].Text == "x" && button[0, 1].Text == "x" && button[1, 2].Text == "")
                        {
                            button[1, 2].Text = "0";
                            button[1, 2].Enabled = false;
                            return;
                        }
                        if (button[4, 0].Text == "x" && button[4, 1].Text == "x" && button[3, 2].Text == "")
                        {
                            button[3, 2].Text = "0";
                            button[3, 2].Enabled = false;
                            return;
                        }
                        if (j < 2 && button[i, j].Text == "x" && button[i, j + 1].Text == "x" && button[i, j + 2].Text == "")
                        {
                            button[i, j + 2].Text = "0";
                            button[i, j + 2].Enabled = false;
                            return;
                        }
                        else if (j < 2 && button[2, 0].Text == "x" && button[2, 1].Text == "x" && button[1, 1].Text == "")
                        {
                            button[1, 1].Text = "0";
                            button[1, 1].Enabled = false;
                            return;
                        }
                        //------------------------------------------------
                        //---------------------------------------------------
                        if (j < 3 && button[1, 0].Text == "x" && button[2, 1].Text == "x" && button[1, 1].Text == "")
                        {
                            button[1, 1].Text = "0";
                            button[1, 1].Enabled = false;
                            return;
                        }
                        if (j < 3 && button[0, 1].Text == "x" && button[1, 2].Text == "x" && button[2, 3].Text == "")
                        {
                            button[2, 3].Text = "0";
                            button[2, 3].Enabled = false;
                            return;
                        }
                        if (j < 3 && button[2, 0].Text == "x" && button[3, 1].Text == "x" && button[2, 1].Text == "")
                        {
                            button[2, 1].Text = "0";
                            button[2, 1].Enabled = false;
                            return;
                        }
                        if (j < 3 && button[3, 0].Text == "x" && button[4, 1].Text == "x" && button[3, 1].Text == "")
                        {
                            button[3, 1].Text = "0";
                            button[3, 1].Enabled = false;
                            return;
                        }
                        if (button[1, 2].Text == "x" && button[2, 3].Text == "x" && button[1, 3].Text == "")
                        {
                            button[1, 3].Text = "0";
                            button[1, 3].Enabled = false;
                            return;
                        }
                        if (i < 4 && j < 4 && button[i, j].Text == "x" && button[i + 1, j + 1].Text == "x" && button[i + 1, j].Text == "")
                        {
                            button[i + 1, j].Text = "0";
                            button[i + 1, j].Enabled = false;
                            return;
                        }
                        //==================================================
                        if (j < 4 && i < 4 && button[i, j].Text == "x" && button[i + 1, j + 1].Text == "x" && button[i + 1, j].Text == "")
                        {
                            button[i + 1, j].Text = "0";
                            button[i + 1, j].Enabled = false;
                            return;
                        }
                        if (button[4, 0].Text == "x" && button[3, 1].Text == "x" && button[2, 1].Text == "")
                        {
                            button[2, 1].Text = "0";
                            button[2, 1].Enabled = false;
                            return;
                        }
                        if (button[2, 1].Text == "x" && button[1, 2].Text == "x" && button[1, 1].Text == "")
                        {
                            button[1, 1].Text = "0";
                            button[1, 1].Enabled = false;
                            return;
                        }
                        if (button[2, 3].Text == "x" && button[1, 4].Text == "x" && button[1, 3].Text == "")
                        {
                            button[1, 3].Text = "0";
                            button[1, 3].Enabled = false;
                            return;
                        }
                        if (button[3, 3].Text == "x" && button[2, 4].Text == "x" && button[2, 3].Text == "")
                        {
                            button[2, 3].Text = "0";
                            button[2, 3].Enabled = false;
                            return;
                        }
                        if (button[4, 3].Text == "x" && button[3, 4].Text == "x" && button[3, 3].Text == "")
                        {
                            button[3, 3].Text = "0";
                            button[3, 3].Enabled = false;
                            return;
                        }
                        if (button[4, 2].Text == "x" && button[3, 3].Text == "x" && button[3, 2].Text == "")
                        {
                            button[3, 2].Text = "0";
                            button[3, 2].Enabled = false;
                            return;
                        }
                        if (i < 4 && j > 0 && button[i, j].Text == "x" && button[i + 1, j - 1].Text == "x" && button[i + 1, j].Text == "")
                        {
                            button[i + 1, j].Text = "0";
                            button[i + 1, j].Enabled = false;
                            return;
                        }
                        if (button[0, 1].Text == "x" && button[2, 3].Text == "x" && button[1, 2].Text == "")
                        {
                            button[1, 2].Text = "0";
                            button[1, 2].Enabled = false;
                            return;
                        }
                        //--------------------------------------------------
                        //--------------------------------------------------
                        for (int m = 0; m < 5; m++)
                            for (int n = 0; n < 5; n++)
                            {
                                if (button[i, 1].Text == "x" && button[m, 3].Text == "x" && button[i, 2].Text == "")
                                {
                                    button[i, 2].Text = "0";
                                    button[i, 2].Enabled = false;
                                    return;
                                }
                                if (button[1, j].Text == "x" && button[3, m].Text == "x" && button[2, j].Text == "")
                                {
                                    button[2, j].Text = "0";
                                    button[2, j].Enabled = false;
                                    return;
                                }
                                //--------------------------------------------
                                //--------------------------------------------
                                if (button[i, j].Text == "x" && button[m, n] != button[i, j] && i < 2 && (button[i, j] != button[1, 2] ||
                                    button[m, n] != button[1, 2]) && button[m, n].Text == "x" && button[1, 2].Text == "")
                                {
                                    button[1, 2].Text = "0";
                                    button[1, 2].Enabled = false;
                                    return;
                                }
                                else if (button[i, j].Text == "x" && button[m, n] != button[i, j] && i < 2 && (button[i, j] == button[1, 2]) || (button[m, n] == button[1, 2]) && button[m, n].Text == "x" && button[1, 3].Text == "")
                                {
                                    button[1, 3].Text = "0";
                                    button[1, 3].Enabled = false;
                                    return;
                                }
                                if (button[i, j].Text == "x" && button[m, n] != button[i, j] && i >= 2 && (button[i, j] != button[3, 2] || button[m, n] != button[3, 2]) && button[m, n].Text == "x" && button[3, 2].Text == "")
                                {
                                    button[3, 2].Text = "0";
                                    button[3, 2].Enabled = false;
                                    return;
                                }
                                else if (button[i, j].Text == "x" && button[m, n] != button[i, j] && i >= 2 && (button[i, j] == button[3, 2]) || (button[m, n] == button[3, 2]) && button[m, n].Text == "x" && button[3, 3].Text == "")
                                {
                                    button[3, 1].Text = "0";
                                    button[3, 1].Enabled = false;
                                    return;
                                }
                            }
                    }
            }
        }
        public void check3()
        {
            if (a > 1)
            {
                for (int i = 0; i < 5; i++)
                    for (int j = 0; j < 5; j++)
                    {
                        //------------------------------------------------0 0 0
                        if (j < 2 && button[i, j].Text == "0" && button[i, j + 1].Text == "0" && button[i, j + 2].Text == "0" && button[i, j + 3].Text == "")
                        {
                            button[i, j + 3].Text = "0";
                            button[i, j + 3].Enabled = false;
                            checkVictory(i, j);
                            return;
                        }
                        if (j < 2 && button[i, j].Text == "" && button[i, j + 1].Text == "0" && button[i, j + 2].Text == "0" && button[i, j + 3].Text == "0")
                        {
                            button[i, j].Text = "0";
                            button[i, j].Enabled = false;
                            checkVictory(i, j);
                            return;
                        }
                        if (j < 2 && button[i, j].Text == "0" && button[i, j + 1].Text == "" && button[i, j + 2].Text == "0" && button[i, j + 3].Text == "0")
                        {
                            button[i, j + 1].Text = "0";
                            button[i, j + 1].Enabled = false;
                            checkVictory(i, j);
                            return;
                        }
                        if (j < 2 && button[i, j].Text == "0" && button[i, j + 1].Text == "0" && button[i, j + 2].Text == "" && button[i, j + 3].Text == "0")
                        {
                            button[i, j + 2].Text = "0";
                            button[i, j + 2].Enabled = false;
                            checkVictory(i, j);
                            return;
                        }
                        //----------------------------------------
                        if (i < 2 && button[i, j].Text == "" && button[i + 1, j].Text == "0" && button[i + 2, j].Text == "0" && button[i + 3, j].Text == "0")
                        {
                            button[i, j].Text = "0";
                            button[i, j].Enabled = false;
                            checkVictory(i, j);
                            return;
                        }
                        if (i < 2 && button[i, j].Text == "0" && button[i + 1, j].Text == "" && button[i + 2, j].Text == "0" && button[i + 3, j].Text == "0")
                        {
                            button[i + 1, j].Text = "0";
                            button[i + 1, j].Enabled = false;
                            checkVictory(i, j);
                            return;
                        }
                        if (i < 2 && button[i, j].Text == "0" && button[i + 1, j].Text == "0" && button[i + 2, j].Text == "" && button[i + 3, j].Text == "0")
                        {
                            button[i + 2, j].Text = "0";
                            button[i + 2, j].Enabled = false;
                            checkVictory(i, j);
                            return;
                        }
                        if (i < 2 && button[i, j].Text == "0" && button[i + 1, j].Text == "0" && button[i + 2, j].Text == "0" && button[i + 3, j].Text == "")
                        {
                            button[i + 3, j].Text = "0";
                            button[i + 3, j].Enabled = false;
                            checkVictory(i, j);
                            return;
                        }
                        //-----------------------------------------
                        if (i > 2 && j < 2 && button[i, j].Text == "0" && button[i - 1, j + 1].Text == "0" && button[i - 2, j + 2].Text == "0" && button[i - 3, j + 3].Text == "")
                        {
                            button[i - 3, j + 3].Text = "0";
                            button[i - 3, j + 3].Enabled = false;
                            checkVictory(i, j);
                            return;
                        }
                        if (i > 2 && j < 2 && button[i, j].Text == "" && button[i - 1, j + 1].Text == "0" && button[i - 2, j + 2].Text == "0" && button[i - 3, j + 3].Text == "0")
                        {
                            button[i, j].Text = "0";
                            button[i, j].Enabled = false;
                            checkVictory(i, j);
                            return;
                        }
                        if (i > 2 && j < 2 && button[i, j].Text == "0" && button[i - 1, j + 1].Text == "" && button[i - 2, j + 2].Text == "0" && button[i - 3, j + 3].Text == "0")
                        {
                            button[i - 1, j + 1].Text = "0";
                            button[i - 1, j + 1].Enabled = false;
                            checkVictory(i, j);
                            return;
                        }
                        if (i > 2 && j < 2 && button[i, j].Text == "0" && button[i - 1, j + 1].Text == "0" && button[i - 2, j + 2].Text == "" && button[i - 3, j + 3].Text == "0")
                        {
                            button[i - 2, j + 2].Text = "0";
                            button[i - 2, j + 2].Enabled = false;
                            checkVictory(i, j);
                            return;
                        }
                        //---------------------------------------------
                        if (i < 2 && j < 2 && button[i, j].Text == "" && button[i + 1, j + 1].Text == "0" && button[i + 2, j + 2].Text == "0" && button[i + 3, j + 3].Text == "0")
                        {
                            button[i, j].Text = "0";
                            button[i, j].Enabled = false;
                            checkVictory(i, j);
                            return;
                        }
                        if (i < 2 && j < 2 && button[i, j].Text == "0" && button[i + 1, j + 1].Text == "" && button[i + 2, j + 2].Text == "0" && button[i + 3, j + 3].Text == "0")
                        {
                            button[i + 1, j + 1].Text = "0";
                            button[i + 1, j + 1].Enabled = false;
                            checkVictory(i, j);
                            return;
                        }
                        if (i < 2 && j < 2 && button[i, j].Text == "0" && button[i + 1, j + 1].Text == "0" && button[i + 2, j + 2].Text == "" && button[i + 3, j + 3].Text == "0")
                        {
                            button[i + 2, j + 2].Text = "0";
                            button[i + 2, j + 2].Enabled = false;
                            checkVictory(i, j);
                            return;
                        }
                        if (i < 2 && j < 2 && button[i, j].Text == "0" && button[i + 1, j + 1].Text == "0" && button[i + 2, j + 2].Text == "0" && button[i + 3, j + 3].Text == "")
                        {
                            button[i + 3, j + 3].Text = "0";
                            button[i + 3, j + 3].Enabled = false;
                            checkVictory(i, j);
                            return;
                        }
                    }
                for (int i = 0; i < 5; i++)
                    for (int j = 0; j < 5; j++)
                    {
                        //                                 x
                        //----------------------------     x  
                        //----------------------------     x  
                        if (i == 0   && button[i, j].Text == "x" && button[i + 1, j].Text == "x" && button[i + 2, j].Text == "x" && button[i + 3, j].Text == "")
                        {
                            button[i + 3, j].Text = "0";
                            button[i + 3, j].Enabled = false;
                            return;
                        }
                        if (i == 0 && button[i, j].Text == "x" && button[i + 2, j].Text == "x" && button[i + 3, j].Text == "x" && button[i + 1, j].Text == "")
                        {
                            button[i + 1, j].Text = "0";
                            button[i + 1, j].Enabled = false;
                            return;
                        }
                        if (i == 0 && button[i, j].Text == "x" && button[i + 1, j].Text == "x" && button[i + 3, j].Text == "x" && button[i + 2, j].Text == "")
                        {
                            button[i + 2, j].Text = "0";
                            button[i + 2, j].Enabled = false;
                            return;
                        }
                        if (i == 0 && button[i + 2, j].Text == "x" && button[i + 1, j].Text == "x" && button[i + 3, j].Text == "x" && button[i, j].Text == "")
                        {
                            button[i, j].Text = "0";
                            button[i, j].Enabled = false;
                            return;
                        }

                        if (i == 1 && button[i, j].Text == "x" && button[i + 2, j].Text == "x" && button[i + 3, j].Text == "x" && button[i + 1, j].Text == "")
                        {
                            button[i + 1, j].Text = "0";
                            button[i + 1, j].Enabled = false;
                            return;
                        }
                        if (i == 1 && button[i, j].Text == "x" && button[i + 1, j].Text == "x" && button[i + 3, j].Text == "x" && button[i + 2, j].Text == "")
                        {
                            button[i + 2, j].Text = "0";
                            button[i + 2, j].Enabled = false;
                            return;
                        }
                        if (i == 1 && button[i, j].Text == "x" && button[i + 1, j].Text == "x" && button[i + 2, j].Text == "x" && button[i + 3, j].Text == "")
                        {
                            button[i + 3, j].Text = "0";
                            button[i + 3, j].Enabled = false;
                            return;
                        }
                        if (i == 1 && button[i + 1, j].Text == "x" && button[i + 2, j].Text == "x" && button[i + 3, j].Text == "x" && button[i, j].Text == "")
                        {
                            button[i, j].Text = "0";
                            button[i, j].Enabled = false;
                            return;
                        }

                        //-----------------------------      x   x   x
                        //-----------------------------          
                        if (j == 0 && button[i, j].Text == "x" && button[i, j + 1].Text == "x" && button[i, j + 2].Text == "x" && button[i, j + 3].Text == "")
                        {
                            button[i, j + 3].Text = "0";
                            button[i, j + 3].Enabled = false;
                            return;
                        }
                        if (j == 0 && button[i, j].Text == "x" && button[i, j + 2].Text == "x" && button[i, j + 3].Text == "x" && button[i, j + 1].Text == "")
                        {
                            button[i, j + 1].Text = "0";
                            button[i, j + 1].Enabled = false;
                            return;
                        }
                        if (j == 0 && button[i, j].Text == "x" && button[i, j + 1].Text == "x" && button[i, j + 3].Text == "x" && button[i, j + 2].Text == "")
                        {
                            button[i, j + 2].Text = "0";
                            button[i, j + 2].Enabled = false;
                            return;
                        }
                        if (j == 0 && button[i, j + 1].Text == "x" && button[i, j + 3].Text == "x" && button[i, j + 2].Text == "x" && button[i, j].Text == "")
                        {
                            button[i, j].Text = "0";
                            button[i, j].Enabled = false;
                            return;
                        }

                        //------------------------------       x   x   x
                        //                                         
                        if (j == 1 && button[i, j].Text == "x" && button[i, j + 2].Text == "x" && button[i, j + 3].Text == "x" && button[i, j + 1].Text == "")
                        {
                            button[i, j + 1].Text = "0";
                            button[i, j + 1].Enabled = false;
                            return;
                        }
                        if (j == 1 && button[i, j].Text == "x" && button[i, j + 1].Text == "x" && button[i, j + 3].Text == "x" && button[i, j + 2].Text == "")
                        {
                            button[i, j + 2].Text = "0";
                            button[i, j + 2].Enabled = false;
                            return;
                        }
                        if (j == 1 && button[i, j].Text == "x" && button[i, j + 2].Text == "x" && button[i, j + 1].Text == "x" && button[i, j + 3].Text == "")
                        {
                            button[i, j + 3].Text = "0";
                            button[i, j + 3].Enabled = false;
                            return;
                        }
                        if (j == 1 && button[i, j + 2].Text == "x" && button[i, j + 1].Text == "0" && button[i, j + 3].Text == "x" && button[i, j].Text == "")
                        {
                            button[i, j].Text = "0";
                            button[i, j].Enabled = false;
                            return;
                        }

                        //-----------------------------        x
                        //-----------------------------             x
                        //-----------------------------                  x
                        if (button[1, 0].Text == "x" && button[2, 1].Text == "x" && button[3, 2].Text == "x" && button[4, 3].Text == "")
                        {
                            button[4, 3].Text = "0";
                            button[4, 3].Enabled = false;
                            return;
                        }
                        if (button[1, 0].Text == "x" && button[3, 2].Text == "x" && button[4, 3].Text == "x" && button[2, 1].Text == "")
                        {
                            button[2, 1].Text = "0";
                            button[2, 1].Enabled = false;
                            return;
                        }
                        if (button[1, 0].Text == "x" && button[2, 1].Text == "x" && button[4, 3].Text == "x" && button[3, 2].Text == "")
                        {
                            button[3, 2].Text = "0";
                            button[3, 2].Enabled = false;
                            return;
                        }
                        if (button[2, 1].Text == "x" && button[3, 2].Text == "x" && button[4, 3].Text == "x" && button[1, 0].Text == "")
                        {
                            button[1, 0].Text = "0";
                            button[1, 0].Enabled = false;
                            return;
                        }

                        //-----------------------------      x
                        //                                       x
                        //                                           x
                        if (button[0, 1].Text == "x" && button[1, 2].Text == "x" && button[2, 3].Text == "x" && button[3, 4].Text == "")
                        {
                            button[3, 4].Text = "0";
                            button[3, 4].Enabled = false;
                            return;
                        }
                        if (button[0, 1].Text == "x" && button[2, 3].Text == "x" && button[3, 4].Text == "x" && button[1, 2].Text == "")
                        {
                            button[1, 2].Text = "0";
                            button[1, 2].Enabled = false;
                            return;
                        }
                        if (button[0, 1].Text == "x" && button[1, 2].Text == "x" && button[3, 4].Text == "x" && button[2, 3].Text == "")
                        {
                            button[2, 3].Text = "0";
                            button[2, 3].Enabled = false;
                            return;
                        }
                        if (button[1, 2].Text == "x" && button[2, 3].Text == "x" && button[3, 4].Text == "x" && button[0, 1].Text == "")
                        {
                            button[0, 1].Text = "0";
                            button[0, 1].Enabled = false;
                            return;
                        }
                        //                                       x
                        //-----------------------------       x
                        //                                x
                        if (button[3, 0].Text == "x" && button[2, 1].Text == "x" && button[1, 2].Text == "x" && button[0, 3].Text == "")
                        {
                            button[0, 3].Text = "0";
                            button[0, 3].Enabled = false;
                            return;
                        }
                        if (button[3, 0].Text == "x" && button[1, 2].Text == "x" && button[0, 3].Text == "x" && button[2, 1].Text == "")
                        {
                            button[2, 1].Text = "0";
                            button[2, 1].Enabled = false;
                            return;
                        }
                        if (button[3, 0].Text == "x" && button[2, 1].Text == "x" && button[0, 3].Text == "x" && button[1, 2].Text == "")
                        {
                            button[1, 2].Text = "0";
                            button[1, 2].Enabled = false;
                            return;
                        }
                        if (button[2, 1].Text == "x" && button[1, 2].Text == "x" && button[0, 3].Text == "x" && button[3, 0].Text == "")
                        {
                            button[3, 0].Text = "0";
                            button[3, 0].Enabled = false;
                            return;
                        }
                        //-----------------------------      x
                        //                                x
                        //                              x
                        if (button[4, 1].Text == "x" && button[3, 2].Text == "x" && button[2, 3].Text == "x" && button[1, 4].Text == "")
                        {
                            button[1, 4].Text = "0";
                            button[1, 4].Enabled = false;
                            return;
                        }
                        if (button[4, 1].Text == "x" && button[3, 2].Text == "x" && button[1, 4].Text == "x" && button[2, 3].Text == "")
                        {
                            button[2, 3].Text = "0";
                            button[2, 3].Enabled = false;
                            return;
                        }
                        if (button[4, 1].Text == "x" && button[2, 3].Text == "x" && button[1, 4].Text == "x" && button[3, 2].Text == "")
                        {
                            button[3, 2].Text = "0";
                            button[3, 2].Enabled = false;
                            return;
                        }
                        if (button[3, 2].Text == "x" && button[2, 3].Text == "x" && button[1, 4].Text == "x" && button[4, 1].Text == "")
                        {
                            button[4, 1].Text = "0";
                            button[4, 1].Enabled = false;
                            return;
                        }
                        //--------------------------------
                        //--------------------------------
                        if (button[0, 1].Text == "x" && button[2, 3].Text == "x" && button[1, 2].Text == "")
                        {
                            button[1, 2].Text = "0";
                            button[1, 2].Enabled = false;
                            return;
                        }
                        //-------------------------------- 
                        //--------------------------------- 0 0
                        //---------------------------------
                        if (j == 2 && button[i, j].Text == "0" && button[i, j + 1].Text == "0" && button[i, j - 1].Text == "")
                        {
                            button[i, j - 1].Text = "0";
                            button[i, j - 1].Enabled = false;
                            return;
                        }
                        if (j == 2 && button[i, j].Text == "0" && button[i, j - 1].Text == "0" && button[i, j + 1].Text == "")
                        {
                            button[i, j + 1].Text = "0";
                            button[i, j + 1].Enabled = false;
                            return;
                        }
                        if (j == 2 && button[i, j + 1].Text == "0" && button[i, j - 1].Text == "0" && button[i, j].Text == "")
                        {
                            button[i, j].Text = "0";
                            button[i, j].Enabled = false;
                            return;
                        }
                        //----------------------------------- 0
                        //----------------------------------- 0
                        if (i == 2 && button[i, j].Text == "0" && button[i + 1, j].Text == "0" && button[i - 1, j].Text == "")
                        {
                            button[i - 1, j].Text = "0";
                            button[i - 1, j].Enabled = false;
                            return;
                        }
                        if (i == 2 && button[i, j].Text == "0" && button[i - 1, j].Text == "0" && button[i + 1, j].Text == "")
                        {
                            button[i + 1, j].Text = "0";
                            button[i + 1, j].Enabled = false;
                            return;
                        }
                        if (i == 2 && button[i, j].Text == "" && button[i + 1, j].Text == "0" && button[i - 1, j].Text == "0")
                        {
                            button[i, j].Text = "0";
                            button[i, j].Enabled = false;
                            return;
                        }
                        //---------------------------------    0
                        //                                        0 
                        if (button[1, 1].Text == "0" && button[2, 2].Text == "0" && button[3, 3].Text == "")
                        {
                            button[3, 3].Text = "0";
                            button[3, 3].Enabled = false;
                            return;
                        }
                        if (button[1, 1].Text == "0" && button[3, 3].Text == "0" && button[2, 2].Text == "")
                        {
                            button[2, 2].Text = "0";
                            button[2, 2].Enabled = false;
                            return;
                        }
                        if (button[2, 2].Text == "0" && button[3, 3].Text == "0" && button[1, 1].Text == "")
                        {
                            button[1, 1].Text = "0";
                            button[1, 1].Enabled = false;
                            return;
                        }
                        //---------------------------------     0
                        //                                   0
                        if (button[2, 2].Text == "0" && button[3, 1].Text == "0" && button[1, 3].Text == "")
                        {
                            button[1, 3].Text = "0";
                            button[1, 3].Enabled = false;
                            return;
                        }
                        if (button[2, 2].Text == "0" && button[1, 3].Text == "0" && button[3, 1].Text == "")
                        {
                            button[3, 1].Text = "0";
                            button[3, 1].Enabled = false;
                            return;
                        }
                        if (button[3, 1].Text == "0" && button[1, 3].Text == "0" && button[2, 2].Text == "")
                        {
                            button[2, 2].Text = "0";
                            button[2, 2].Enabled = false;
                            return;
                        }
                        //-----------------------------------    
                        //-----------------------------------  0
                        //-----------------------------------0
                        if (i == 4 && j == 4)
                        {
                            if (button[3, 0].Text == "" && button[2, 1].Text == "0" && button[1, 2].Text == "0" && button[0, 3].Text == "")
                            {
                                button[0, 3].Text = "0";
                                button[0, 3].Enabled = false;
                                return;
                            }
                            if (button[1, 0].Text == "" && button[2, 1].Text == "0" && button[3, 2].Text == "0" && button[4, 3].Text == "")
                            {
                                button[4, 3].Text = "0";
                                button[4, 3].Enabled = false;
                                return;
                            }
                            if (button[0, 1].Text == "" && button[1, 2].Text == "0" && button[2, 3].Text == "0" && button[3, 4].Text == "")
                            {
                                button[3, 4].Text = "0";
                                button[3, 4].Enabled = false;
                                return;
                            }
                            if (button[4, 1].Text == "" && button[3, 2].Text == "0" && button[2, 3].Text == "0" && button[1, 4].Text == "")
                            {
                                button[1, 4].Text = "0";
                                button[1, 4].Enabled = false;
                                return;
                            }
                        }
                        //-------------------------------------
                        //-------------------------------------
                        if (i == 4 && j == 4)
                        {
                            for (i = 0; i < 5; i++)
                                for (j = 0; j < 5; j++)
                                {
                                    //------------------------------   x   x
                                    //------------------------------
                                    if (j == 2 && button[i, j].Text == "x" && button[i, j + 1].Text == "x" && button[i, j - 1].Text == "")
                                    {
                                        button[i, j - 1].Text = "0";
                                        button[i, j - 1].Enabled = false;
                                        return;
                                    }
                                    if (j == 2 && button[i, j].Text == "x" && button[i, j - 1].Text == "x" && button[i, j + 1].Text == "")
                                    {
                                        button[i, j + 1].Text = "0";
                                        button[i, j + 1].Enabled = false;
                                        return;
                                    }
                                    if (j == 2 && button[i, j + 1].Text == "x" && button[i, j - 1].Text == "x" && button[i, j].Text == "")
                                    {
                                        button[i, j].Text = "0";
                                        button[i, j].Enabled = false;
                                        return;
                                    }
                                    //-----------------------------------  x
                                    //-----------------------------------  x
                                    if (i == 2 && button[i, j].Text == "x" && button[i + 1, j].Text == "x" && button[i - 1, j].Text == "")
                                    {
                                        button[i - 1, j].Text = "0";
                                        button[i - 1, j].Enabled = false;
                                        return;
                                    }
                                    if (i == 2 && button[i, j].Text == "x" && button[i - 1, j].Text == "x" && button[i + 1, j].Text == "")
                                    {
                                        button[i + 1, j].Text = "0";
                                        button[i + 1, j].Enabled = false;
                                        return;
                                    }
                                    if (i == 2 && button[i, j].Text == "" && button[i + 1, j].Text == "x" && button[i - 1, j].Text == "x")
                                    {
                                        button[i, j].Text = "0";
                                        button[i, j].Enabled = false;
                                        return;
                                    }
                                    //---------------------------------  x
                                    //                                      x
                                    if (button[1, 1].Text == "x" && button[2, 2].Text == "x" && button[3, 3].Text == "")
                                    {
                                        button[3, 3].Text = "0";
                                        button[3, 3].Enabled = false;
                                        return;
                                    }
                                    if (button[1, 1].Text == "x" && button[3, 3].Text == "x" && button[2, 2].Text == "")
                                    {
                                        button[2, 2].Text = "0";
                                        button[2, 2].Enabled = false;
                                        return;
                                    }
                                    if (button[2, 2].Text == "x" && button[3, 3].Text == "x" && button[1, 1].Text == "")
                                    {
                                        button[1, 1].Text = "0";
                                        button[1, 1].Enabled = false;
                                        return;
                                    }
                                    //---------------------------------      x
                                    //                                    x
                                    if (button[2, 2].Text == "x" && button[3, 1].Text == "x" && button[1, 3].Text == "")
                                    {
                                        button[1, 3].Text = "0";
                                        button[1, 3].Enabled = false;
                                        return;
                                    }
                                    if (button[2, 2].Text == "x" && button[1, 3].Text == "x" && button[3, 1].Text == "")
                                    {
                                        button[3, 1].Text = "0";
                                        button[3, 1].Enabled = false;
                                        return;
                                    }
                                    if (button[3, 1].Text == "x" && button[1, 3].Text == "x" && button[2, 2].Text == "")
                                    {
                                        button[2, 2].Text = "0";
                                        button[2, 2].Enabled = false;
                                        return;
                                    }
                                    //--------------------------------
                                    //--------------------------------                                 
                                    if (i == 4 && j == 4)
                                    {
                                        if (button[0, 1].Text == "" && button[1, 2].Text == "x" && button[2, 3].Text == "x" && button[3, 4].Text == "")
                                        {
                                            button[3, 4].Text = "0";
                                            button[3, 4].Enabled = false;
                                            return;
                                        }
                                        if (button[1, 0].Text == "" && button[2, 1].Text == "x" && button[3, 2].Text == "x" && button[4, 3].Text == "")
                                        {
                                            button[4, 3].Text = "0";
                                            button[4, 3].Enabled = false;
                                            return;
                                        }
                                        if (button[3, 0].Text == "" && button[2, 1].Text == "x" && button[1, 2].Text == "x" && button[3, 0].Text == "")
                                        {
                                            button[3, 0].Text = "0";
                                            button[3, 0].Enabled = false;
                                            return;
                                        }
                                        if (button[4, 1].Text == "" && button[3, 2].Text == "x" && button[2, 3].Text == "x" && button[1, 4].Text == "")
                                        {
                                            button[1, 4].Text = "0";
                                            button[1, 4].Enabled = false;
                                            return;
                                        }
                                        //--------------------------------
                                        for (i = 0; i < 5; i++)
                                            for (j = 0; j < 5; j++)
                                            {
                                                if (i > 0 && i < 4 && j > 0 && j < 4 && button[i, j].Text == "")
                                                {
                                                    button[i, j].Text = "0";
                                                    button[i, j].Enabled = false;
                                                    return;
                                                }
                                            }
                                        for (i = 0; i < 5; i++)
                                            for (j = 0; j < 5; j++)
                                            {
                                                if (button[i, j].Text == "")
                                                {
                                                    button[i, j].Text = "0";
                                                    button[i, j].Enabled = false;
                                                    return;
                                                }
                                            }
                                        MessageBox.Show("drow");
                                        restart();
                                        a = 1;
                                    }
                                }
                        }
                    }
            }
        }
        private void onclick(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Text = "x";
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    checkVictory(i, j);
                }
            }
            check1();
            check2();
            check3();
            a++;
            b.Enabled = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            restart();
        }
        private void restart()
        {
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                {
                    button[i, j].Text = "";
                    button[i, j].BackColor = Color.Empty;
                    button[i, j].Enabled = true;
                }
            a = 0;
        }

        private void label1_Click(object sender, EventArgs e) 
        {

        }
        //private void panel1_Paint(object sender, PaintEventArgs e)
        //{
        //}
    }
}