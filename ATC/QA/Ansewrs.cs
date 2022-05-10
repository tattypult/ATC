using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATC
{
    public partial class Ansewrs
    {
        AnswersDX_500 answersDX;
        AnswersHiCom AnswersHiCom;
        HipassAnswers HipassAnswers;
        T_76Answers T_76Answers;
        string answer;
        public string Answer { get { return answer; } set { answer = value; } }
        public Ansewrs()
        {
            answersDX = new AnswersDX_500();
            AnswersHiCom= new AnswersHiCom();
            HipassAnswers = new HipassAnswers();
            T_76Answers = new T_76Answers();
        }
        public string Getanswerword(TypeATC tatc, int iter)
        {
            switch (tatc)
            {
                case TypeATC.DX_500:
                    {
                        Answer = answersDX.DX_500WordANS(iter);
                        return Answer;
                    }
                case TypeATC.HiCom:
                    {
                        Answer = AnswersHiCom.HiComWordANS(iter);
                        return Answer;
                    }
                case TypeATC.Hipass:
                    {
                        Answer = HipassAnswers.HiPassWordANS(iter);
                        return Answer;
                    }
                case TypeATC.T_76:
                    {
                        Answer = T_76Answers.T_76WordANS(iter);
                        return Answer;
                    }
            }
            return null;
        }
        public string GetanswerComparison(TypeATC tatc, int iter)
        {
            switch (tatc)
            {
                case TypeATC.DX_500:
                    {
                        Answer = answersDX.DX_500ComparisonANS(iter);
                        return Answer;
                    }
                case TypeATC.HiCom:
                    {
                        Answer = AnswersHiCom.HiComComparisonANS(iter);
                        return Answer;
                    }
                case TypeATC.Hipass:
                    {
                        Answer = HipassAnswers.HiPassComparisonANS(iter);
                        return Answer;
                    }
                case TypeATC.T_76:
                    {
                        Answer = T_76Answers.T_76ComparisonANS(iter);
                        return Answer;
                    }
            }
            return null;
        }
        public string GetOtvetu(TypeATC tatc, int iter)
        {
            switch (tatc)
            {
                case TypeATC.DX_500:
                    {
                        Answer = answersDX.DX_500otvetu(iter);
                        return Answer;
                    }
                case TypeATC.HiCom:
                    {
                        Answer = AnswersHiCom.HiComotvetu(iter);
                        return Answer;
                    }
                case TypeATC.Hipass:
                    {
                        Answer = HipassAnswers.HiPassotvetu(iter);
                        return Answer;
                    }
                case TypeATC.T_76:
                    {
                        Answer = T_76Answers.T_76otvetu(iter);
                        return Answer;
                    }
            }
            return null;
        }
        //такие же методы для чекбокса и радиобатон
    }
}
