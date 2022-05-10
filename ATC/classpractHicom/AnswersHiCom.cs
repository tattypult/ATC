using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATC
{
    internal class AnswersHiCom
    {
        List<string> answersword = new List<string>();
        List<string> answercomparison = new List<string>();
        string ansrand = "";
        List<string> otvetucomparison = new List<string>();
        public AnswersHiCom()
        {
            answersword.Add("siemensоконечной");
            answersword.Add("3232102432");
            answersword.Add("двухпроводнойаналоговых");
            answersword.Add("34");
            answersword.Add("isdns24");
            answersword.Add("slma1650");
            answersword.Add("162b16");

            answercomparison.Add("Система 330E V1.0 Atlantik-HW^Система 330E V2.0/V3.0 Atlantik-HW^Система 350E V1.0/V2.0 Atlantik-HW^Система 350E V3.0 Atlantik-HW");
            answercomparison.Add("Uро^U200^Х.21");
            answercomparison.Add("U2B1Q^So^а/в");
            answercomparison.Add("1 ТR6 (Е-DSS1)^СоrNet, QSIG, DPNSS^СоrNet-T, 1TR6/DKZE, E-DSS1");
            answercomparison.Add("CONF^SIU^DCL");
            answercomparison.Add("HDLC^PCG^PSIO");
            answercomparison.Add("Процесс сигнализации^Процесс управления^Процесс коммутации");
            answercomparison.Add("Модуль STMD^Модуль DIUC^Модуль DIUS2");
            answercomparison.Add("Модуль SLMA^Модуль SLMB^Модуль SLMS");
            answercomparison.Add("Модуль STMD2^Модуль STHC^Модуль SLMO");

            otvetucomparison.Add("2^4^1^3");
            otvetucomparison.Add("3^1^2");
            otvetucomparison.Add("3^1^2");
            otvetucomparison.Add("2^1^3");
            otvetucomparison.Add("1^3^2");
            otvetucomparison.Add("2^3^1");
            otvetucomparison.Add("3^2^1");
            otvetucomparison.Add("1^2^3");
            otvetucomparison.Add("3^1^2");
            otvetucomparison.Add("2^1^3");
        }
        /// <summary>
        /// получить ответ из блока слова
        /// </summary>
        /// <param name="iter"></param>
        /// <returns></returns>
        public string HiComWordANS(int iter)
        {
            ansrand = answersword[iter];
            answersword.Remove(ansrand);
            return ansrand;
        }
        /// <summary>
        /// получить ответ из блока сопоставление
        /// </summary>
        /// <param name="iter"></param>
        /// <returns></returns>
        public string HiComComparisonANS(int iter)
        {
            ansrand = answercomparison[iter];
            answercomparison.Remove(ansrand);
            return ansrand;
        }
        public string HiComotvetu(int iter)
        {
            ansrand = otvetucomparison[iter];
            otvetucomparison.Remove(ansrand);
            return ansrand;
        }
    }
}
