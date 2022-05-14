using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATC
{
    public partial class Alltests : Form
    {
        Random random;
        Questions Questions;
        Ansewrs Ansewrs;

        int N = 0;
        int questions = 1;
        string answ;
        string[] tmpa;
        string[] tmpq;

        List<int> iterw0;
        List<int> iterw1;
        List<int> iterw2;
        List<int> iterw3;

        List<int> iterc0;
        List<int> iterc1;
        List<int> iterc2;
        List<int> iterc3;

        Label lab;
        ComboBox[] BDP;
        int k30 = 30;
        int step = 0;
        string FIO;
        string N_group;

        int rightanswer = 0;
        int erroranswer = 0;
        public Alltests(string FIO, string N_group)
        {
            random = new Random();
            Questions = new Questions();
            Ansewrs = new Ansewrs();
            this.FIO = FIO;
            this.N_group = N_group;
            InitializeComponent();
            iterw0 = new List<int>();
            iterw1 = new List<int>();
            iterw2 = new List<int>();
            iterw3 = new List<int>();

            iterc0 = new List<int>();
            iterc1 = new List<int>();
            iterc2 = new List<int>();
            iterc3 = new List<int>();
            Parallel.Invoke(
                () =>
            {
                for (int i = 0; i < 16; i++)
                {
                    iterw0.Add(i);
                }
                for (int i = 0; i < 5; i++)
                {
                    iterc0.Add(i);
                }
            },
                () =>
            {
                for (int i = 0; i < 7; i++)
                {
                    iterw1.Add(i);
                }
                for (int i = 0; i < 10; i++)
                {
                    iterc1.Add(i);
                }
            },
                () =>
           {
               for (int i = 0; i < 7; i++)
               {
                   iterw2.Add(i);
               }
               for (int i = 0; i < 3; i++)
               {
                   iterc2.Add(i);
               }
           },
                () =>
           {
               for (int i = 0; i < 14; i++)
               {
                   iterw3.Add(i);
               }
               for (int i = 0; i < 5; i++)
               {
                   iterc3.Add(i);
               }
           });
        }
        private void Cast()
        {
            int count = 0;
            if (N == 0)
            {
                if (textBox1.Text.ToLower().Replace(" ", "").Replace(",", "").Replace("-", "") == answ)
                    rightanswer++;
                else
                    erroranswer++;
            }
            else
            {
                for (int i = 0; i < BDP.Length; i++)
                {
                    if (Convert.ToString(BDP[i].SelectedItem) == tmpa[i])
                        count++;
                }
                if (count == answ.Length)
                    rightanswer++;
                else
                    erroranswer++;
            }
        }

        private void Rezultat()
        {
            this.Close();
            Rezult rez = new Rezult();
            rez.Show();
            rez.fioLAbel.Text = "Курсант:" + FIO;
            rez.fioN_group.Text = "№ учебной группы:" + N_group;
            rez.rightanswer.Text = rightanswer.ToString();
            if ((rightanswer / questions) * 100 >= 90)
                rez.mark.Text = 5.ToString();
            if ((rightanswer / questions) * 100 >= 80 && (rightanswer / 21) * 100 <= 90)
                rez.mark.Text = 4.ToString();
            if ((rightanswer / questions) * 100 >= 70 && (rightanswer / 21) * 100 <= 80)
                rez.mark.Text = 3.ToString();
            else
                rez.mark.Text = 2.ToString();
        }

        public void Next()
        {
            Panelka.Controls.Clear();
            panelka1.Controls.Clear();
            textBox1.Clear();
            //bunifuButton1.Enabled = false;
            N = random.Next(0, 4);
            switch (N)
            {
                case 0:
                    {
                        if (iterw0.Count == 0 && iterc0.Count == 0)
                            goto case 1;
                        Choose(TypeATC.DX_500, iterw0, iterc0);
                        break;
                    }
                case 1:
                    {
                        if (iterw1.Count == 0 && iterc1.Count == 0)
                            goto case 2;
                        Choose(TypeATC.HiCom, iterw1, iterc1);
                        break;
                    }
                case 2:
                    {
                        if (iterw2.Count == 0 && iterc2.Count == 0)
                            goto case 3;
                        Choose(TypeATC.Hipass, iterw2, iterc2);
                        break;
                    }
                case 3:
                    {
                        if (iterw3.Count == 0 && iterc3.Count == 0)
                            goto case 1;
                        Choose(TypeATC.T_76, iterw3, iterc3);
                        break;
                    }
            }

            if (questions == 50)
            {
                bunifuButton1.Text = "Завершить";
            }
        }

        private void Choose(TypeATC type, List<int> iterw, List<int> iterc)
        {
            N = random.Next(0, 2);
            switch (N)
            {
                case 0:
                    {
                        if (iterw.Count==0)
                            goto case 1;
                        label1.Text = (questions) + "/50";
                        step = random.Next(0, iterw.Count);
                        iterw.Remove(iterw[step]);
                        LabelQuestions.Text = Questions.Getquestionword(type, step);
                        answ = Ansewrs.Getanswerword(type, step);
                        labelquest.Visible = true;
                        textBox1.Visible = true;
                        break;
                    }
                case 1:
                    {
                        if (iterc.Count==0)
                            goto case 0;
                        label1.Text = (questions) + "/50";
                        bunifuButton1.Enabled = true;
                        textBox1.Visible = false;
                        labelquest.Visible = false;
                        step = random.Next(0, iterc.Count);
                        iterc.Remove(iterc[step]);
                        answ = Questions.GetquestionComparison(type, step);
                        tmpq = new string[answ.Length * 2];
                        tmpq = answ.Split('|');
                        LabelQuestions.Text = tmpq[0];
                        if (tmpq.Length == 1)
                        {
                            goto Next;
                        }
                        k30 = 70;
                        for (int i = 1; i < tmpq.Length; i++)
                        {
                            lab = new Label();
                            lab.Text = i + ". " + tmpq[i];
                            lab.Location = new Point(10, -65 + k30);
                            lab.MaximumSize = new Size(570, 150);
                            lab.AutoSize = true;
                            lab.ForeColor = Color.White;
                            lab.TextAlign = ContentAlignment.TopLeft;
                            panelka1.Controls.Add(lab);
                            k30 += 70;
                        }
                    Next:
                        k30 = 70;
                        answ = Ansewrs.GetanswerComparison(type, step);
                        tmpa = new string[answ.Length * 2];
                        tmpa = answ.Split('^');
                        for (int i = 0; i < tmpa.Length; i++)
                        {
                            lab = new Label();
                            lab.Text = tmpa[i];
                            lab.Location = new Point(90, -65 + k30);
                            lab.AutoSize = true;
                            lab.ForeColor = Color.White;
                            lab.TextAlign = ContentAlignment.TopLeft;
                            lab.MaximumSize = new Size(450, 150);
                            Panelka.Controls.Add(lab);
                            k30 += 70;
                        }
                        k30 = 70;
                        BDP = new ComboBox[tmpa.Length];
                        for (int i = 0; i < tmpa.Length; i++)
                        {
                            BDP[i] = new ComboBox();
                            for (int j = 1; j <= tmpa.Length; j++)
                            {
                                BDP[i].Items.Add(j);
                            }
                            BDP[i].Width = 75;
                            BDP[i].Location = new Point(10, -65 + k30);
                            BDP[i].Text = "Выберите";
                            Panelka.Controls.Add(BDP[i]);
                            k30 += 70;
                        }
                        k30 = 70;
                        answ = Ansewrs.GetOtvetu(type, step);
                        tmpa = answ.Split('^');
                        break;
                    }
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //if (textBox1.Text.Length != 0)
            //    bunifuButton1.Enabled = true;
            //if (textBox1.Text.Length == 0)
            //    bunifuButton1.Enabled = false;
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            questions++;
            if (questions == 51)
            {
                Cast();
                Rezultat();
                goto next;
            }
            Cast();
            Next();
        next: { }
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            Rezultat();
        }

        private void Alltests_Load(object sender, EventArgs e)
        {
            step = random.Next(0, iterw0.Count);
            iterw0.Remove(iterw0[step]);
            LabelQuestions.Text = Questions.Getquestionword(TypeATC.DX_500, step);
            answ = Ansewrs.Getanswerword(TypeATC.DX_500, step);
            labelquest.Visible = true;
            textBox1.Visible = true;
            label1.Text = (questions) + "/50";
        }
    }
}
