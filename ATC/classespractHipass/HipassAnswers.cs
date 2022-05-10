using System.Collections.Generic;

namespace ATC
{
    internal class HipassAnswers
    {
        List<string> answersword = new List<string>();
        List<string> answercomparison = new List<string>();
        string ansrand = "";
        List<string> otvetucomparison = new List<string>();
        public HipassAnswers()
        {
            answersword.Add("tdmip");
            answersword.Add("hicom300");
            answersword.Add("1512000");
            answersword.Add("43004500");
            answersword.Add("iphfa60");
            answersword.Add("cornetcornet");
            answersword.Add("monodual");

            answercomparison.Add("ADS^CC-A^СС+ADP^SWU");
            answercomparison.Add("DSCXL^RTM^ACPCI");
            answercomparison.Add("Порт ALUM^Порт ALIN^Порт Reference clock");

            otvetucomparison.Add("3^1^4^2");
            otvetucomparison.Add("3^1^2");
            otvetucomparison.Add("1^3^2");
        }
        /// <summary>
        /// получить ответ из блока слова
        /// </summary>
        /// <param name="iter"></param>
        /// <returns></returns>
        public string HiPassWordANS(int iter)
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
        public string HiPassComparisonANS(int iter)
        {
            ansrand = answercomparison[iter];
            answercomparison.Remove(ansrand);
            return ansrand;
        }
        public string HiPassotvetu(int iter)
        {
            ansrand = otvetucomparison[iter];
            otvetucomparison.Remove(ansrand);
            return ansrand;
        }
    }
}
