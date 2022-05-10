
using System;

namespace ATC
{

    public enum Quest : int
    {
        word,
        checkbox,
        radiobutton,
        comparison
    }
    public enum TypeATC : int
    {
        DX_500,
        HiCom,
        Hipass,
        T_76
    }
    public partial class Questions
    {
        public string fio;
        public string n_group;
        string text;
        public string Text { get { return text; } set { text = value; } }


        QuestionsDX questionsDX;
        QuestionsHiCom questionsHiCom;
        QuestionsHipass questionsHipass;
        T_76Questions T_76Questions;
        public Questions()
        {
            questionsDX = new QuestionsDX();
            questionsHiCom = new QuestionsHiCom();
            questionsHipass = new QuestionsHipass();
            T_76Questions = new T_76Questions();
        }
        public string Getquestionword(TypeATC tatc, int iter)
        {
            switch (tatc)
            {
                case TypeATC.DX_500:
                    {
                        Text = questionsDX.DX_500Word(iter);
                        return Text;
                    }
                case TypeATC.HiCom:
                    {
                        Text = questionsHiCom.HiComWord(iter);
                        return Text;
                    }
                case TypeATC.Hipass:
                    {
                        Text = questionsHipass.HiPassWord(iter);
                        return Text;
                    }
                case TypeATC.T_76:
                    {
                        Text = T_76Questions.T_76Word(iter);
                        return Text;
                    }
            }
            return null;
        }
        public string GetquestionComparison(TypeATC tatc, int iter)
        {
            switch (tatc)
            {
                case TypeATC.DX_500:
                    {
                        Text = questionsDX.DX_500Comparison(iter);
                        return Text;
                    }
                case TypeATC.HiCom:
                    {
                        Text = questionsHiCom.HiComComparison(iter);
                        return Text;
                    }
                case TypeATC.Hipass:
                    {
                        Text = questionsHipass.HiPassComparison(iter);
                        return Text;
                    }
                case TypeATC.T_76:
                    {
                        Text = T_76Questions.T_76Comparison(iter);
                        return Text;
                    }
            }
            return null;
        }
        //такие же методы для чекбокса и радиобатон

    }
}
