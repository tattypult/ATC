
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ATC
{
    public partial class DX_500 : Form
    {
        Random random;
        Questions Questions;
        Ansewrs Ansewrs;

        int N = 0;
        int questions = 1;
        string answ;
        string[] tmpa;
        string[] tmpq;
        int count = 0;
        List<int> iterw;
        List<int> iterc;
        Label lab;
        ComboBox[] BDP;
        int k30 = 30;
        int step = 0;
        string FIO;
        string N_group;

        int rightanswer = 0;
        int erroranswer = 0;
        public DX_500(string FIO, string N_group)
        {
            this.FIO = FIO;
            this.N_group = N_group;
            InitializeComponent();
            iterw = new List<int>();
            iterc = new List<int>();
            for (int i = 0; i < 16; i++)
            {
                iterw.Add(i);
            }
            for (int i = 0; i < 5; i++)
            {
                iterc.Add(i);
            }
        }

        private void DX_500_Load(object sender, EventArgs e)
        {
            Form1 form= new Form1();
            form.DX_500But.Enabled = false;
            Questions = new Questions();
            Ansewrs = new Ansewrs();
            random = new Random(DateTime.Now.Millisecond);
            step = random.Next(0, iterw.Count);
            iterw.Remove(iterw[step]);
            LabelQuestions.Text = Questions.Getquestionword(TypeATC.DX_500, step);
            answ = Ansewrs.Getanswerword(TypeATC.DX_500, step);
            labelquest.Visible = true;
            textBox1.Visible = true;
            label1.Text = (questions) + "/21";
            questions++;
        }
        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            if (questions == 22)
            {
                Cast();
                Rezultat();
                goto next;
            }
            Cast();
            Next();
            questions++;
        next: { }
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
            rez.fioN_group.Text = "№ учебной группы:"+N_group;
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
            bunifuButton1.Enabled = false;
            N = random.Next(0, 2);
            switch (N)
            {
                case 0:
                    {
                        label1.Text = (questions) + "/21";
                        //так как разные вопросы то следует сделать разные массивы
                        step = random.Next(0, iterw.Count);
                        iterw.Remove(iterw[step]);
                        LabelQuestions.Text = Questions.Getquestionword(TypeATC.DX_500, step);
                        answ = Ansewrs.Getanswerword(TypeATC.DX_500, step);
                        labelquest.Visible = true;
                        textBox1.Visible = true;
                        break;
                    }
                case 1:
                    {
                        count++;
                        if (count > 5)
                            goto case 0;
                        label1.Text = (questions) + "/21";
                        bunifuButton1.Enabled = true;
                        textBox1.Visible = false;
                        labelquest.Visible = false;
                        step = random.Next(0, iterc.Count);
                        iterc.Remove(iterc[step]);
                        answ = Questions.GetquestionComparison(TypeATC.DX_500, step);
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
                            lab.Location = new Point(10, -60 + k30);
                            lab.MaximumSize = new Size(400, 150);
                            lab.AutoSize = true;
                            lab.ForeColor = Color.White;
                            lab.TextAlign = ContentAlignment.MiddleLeft;
                            panelka1.Controls.Add(lab);
                            k30 += 70;
                        }
                    Next:
                        k30 = 70;
                        answ = Ansewrs.GetanswerComparison(TypeATC.DX_500, step);
                        tmpa = new string[answ.Length * 2];
                        tmpa = answ.Split('^');
                        for (int i = 0; i < tmpa.Length; i++)
                        {
                            lab = new Label();
                            lab.Text = tmpa[i];
                            lab.Location = new Point(120, -60 + k30);
                            lab.AutoSize = true;
                            lab.ForeColor = Color.White;
                            lab.TextAlign = ContentAlignment.TopLeft;
                            lab.MaximumSize = new Size(320, 150);
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
                            BDP[i].Width = 100;
                            BDP[i].Location = new System.Drawing.Point(10, -60 + k30);
                            BDP[i].Text = "Выберите";
                            Panelka.Controls.Add(BDP[i]);
                            k30 += 70;
                        }
                        k30 = 70;
                        answ = Ansewrs.GetOtvetu(TypeATC.DX_500, step);
                        tmpa = answ.Split('^');
                        break;
                    }
            }
            if (questions == 21)
            {
                bunifuButton1.Text = "Завершить";
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
                bunifuButton1.Enabled = true;
            if (textBox1.Text.Length == 0)
                bunifuButton1.Enabled = false;
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            Rezultat();
        }
    }
}
