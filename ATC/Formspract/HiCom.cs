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
    public partial class HiCom : Form
    {
        Random random;
        Questions Questions;
        Ansewrs Ansewrs;

        int N = 0;
        int questions = 1;
        string answ;
        string[] tmpa;
        string[] tmpq;
        int countw = 0;
        int countc = 0;
        List<int> iterw;
        List<int> iterc;
        Label lab;
        ComboBox[] BDP;
        int k30 = 30;
        int step = 0;
        string fio;
        string N_group;

        int rightanswer = 0;
        int erroranswer = 0;

        public HiCom(string fio, string N_group)
        {
            InitializeComponent();
            this.fio = fio;
            this.N_group = N_group;
            iterw = new List<int>();
            iterc = new List<int>();
            for (int i = 0; i < 7; i++)
            {
                iterw.Add(i);
            }
            for (int i = 0; i < 10; i++)
            {
                iterc.Add(i);
            }
            Questions = new Questions();
            Ansewrs = new Ansewrs();
            random = new Random(DateTime.Now.Millisecond);
        }
        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            if (questions == 19)
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
        /// <summary>
        /// Оценка ответа
        /// </summary>
        private void Cast()
        {
            int count = 0;
            if (textBox2.Text == 240.ToString() && textBox4.Text == 256.ToString() && textBox3.Text == 4.ToString() && questions == 0)
            {
                rightanswer++;
                goto next;
            }
            if (N == 0)
            {
                if (textBox2.Text.ToLower().Replace(" ", "").Replace(",", "").Replace("-", "") == answ)
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
        next: { }
        }
        /// <summary>
        /// Выдает результат
        /// </summary>
        private void Rezultat()
        {
            Rezult rez = new Rezult();
            rez.fioLAbel.Text = "Курсант:" + fio;
            rez.fioN_group.Text = "№ учебной группы:" + N_group;
            rez.Show();
            rez.rightanswer.Text = rightanswer.ToString();
            if ((rightanswer / questions) * 100 >= 90)
                rez.mark.Text = 5.ToString();
            if ((rightanswer / questions) * 100 >= 80 && (rightanswer / 21) * 100 <= 90)
                rez.mark.Text = 4.ToString();
            if ((rightanswer / questions) * 100 >= 70 && (rightanswer / 21) * 100 <= 80)
                rez.mark.Text = 3.ToString();
            else
                rez.mark.Text = 2.ToString();
            this.Close();
        }
        /// <summary>
        /// формирование формы
        /// </summary>
        public void Next()
        {
            bunifuImageButton1.Visible = false;
            textBox2.Visible = false;
            textBox4.Visible = false;
            textBox3.Visible = false;
            textBox2.Visible = true;
            label3.Visible = true;
            Panelka.Visible = true;
            panelka1.Visible = true;
            Panelka.Controls.Clear();
            panelka1.Controls.Clear();
            textBox2.Clear();
            bunifuButton4.Enabled = false;
            N = random.Next(0, 2);
            switch (N)
            {
                case 0:
                    {
                        countw++;
                        if (countw > 7)
                            goto case 1;
                        label2.Text = (questions) + "/18";
                        step = random.Next(0, iterw.Count);
                        iterw.Remove(iterw[step]);
                        LabelQuestions.Text = Questions.Getquestionword(TypeATC.HiCom, step);
                        answ = Ansewrs.Getanswerword(TypeATC.HiCom, step);
                        label3.Visible = true;
                        textBox2.Visible = true;
                        break;
                    }
                case 1:
                    {
                        countc++;
                        if (countc > 10)
                            goto case 0;
                        label2.Text = (questions) + "/18";
                        bunifuButton4.Enabled = true;
                        textBox2.Visible = false;
                        label3.Visible = false;
                        step = random.Next(0, iterc.Count);
                        iterc.Remove(iterc[step]);
                        answ = Questions.GetquestionComparison(TypeATC.HiCom, step);
                        tmpq = new string[answ.Length * 2];
                        tmpq = answ.Split('|');
                        LabelQuestions.Text = tmpq[0];
                        if (tmpq.Length == 1)
                        {
                            goto Next;
                        }
                        k30 = 100;
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
                            k30 += 100;
                        }
                    Next:
                        k30 = 100;
                        answ = Ansewrs.GetanswerComparison(TypeATC.HiCom, step);
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
                            k30 += 100;
                        }
                        k30 = 100;
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
                            k30 += 100;
                        }
                        k30 = 100;
                        answ = Ansewrs.GetOtvetu(TypeATC.HiCom, step);
                        tmpa = answ.Split('^');
                        break;
                    }
            }
            if (questions == 18)
            {
                bunifuButton4.Text = "Завершить";
            }
        }
        private void HiCom_Load_1(object sender, EventArgs e)
        {
            bunifuButton4.Enabled = true;
            Panelka.Visible = false;
            panelka1.Visible = false;
            textBox2.Visible = false;
            label3.Visible = false;
            LabelQuestions.Text = "Вставьте необходимые значения:Характеристики некоторых моделей станций HICOM (Заполните пустые ячейки)";
            label2.Text = (questions) + "/18";
            questions++;
        }

        private void bunifuButton3_Click_1(object sender, EventArgs e)
        {
            Rezultat();
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            if (textBox2.Text.Length != 0)
                bunifuButton4.Enabled = true;
            if (textBox2.Text.Length == 0)
                bunifuButton4.Enabled = false;
        }
    }
}
