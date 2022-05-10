using System;
using System.Collections.Generic;
using System.Linq;

namespace ATC
{
    public class AnswersDX_500
    {
        List<string> answersword = new List<string>();
        List<string> answercomparison = new List<string>();
        string ansrand = "";
        List<string> otvetucomparison = new List<string>();
        public AnswersDX_500()
        {
            answersword.Add("оконечнойстанции");
            answersword.Add("dx-nete1");
            answersword.Add("64000");
            answersword.Add("mnl");
            answersword.Add("шифртехникой");
            answersword.Add("коммутационноеоборудованиепринимаетсигнализациюотоборудованияпередачиданныхкоммутационноеоборудованиепередаетсигнализациюоборудованиюпередачиданных");
            answersword.Add("1284");
            answersword.Add("pcm2");
            answersword.Add("cpu8adk21284");
            answersword.Add("wpport103+");
            answersword.Add("lwlport031T++");
            answersword.Add("dps032");
            answersword.Add("dpnиванов");
            answersword.Add("tport031");
            answersword.Add("wlmap01c1wlmap11c2wlmap2200104");
            answersword.Add("010310132630164950196127");
            answercomparison.Add("«МиниКом DX-500C»^«МиниКом DX-500C-M»^«МиниКом DX-500C-S»^«МиниКом DX-500C-К»");
            answercomparison.Add("Модули аналоговых и цифровых АЛ^Модули аналоговых и цифровых СЛ^Модуль цифрового коммутационного поля^Рабочее место оператора^Модуль технического обслуживания^" +
                "Модуль центрального УУ предназначен для управления обо-ру-дованием станции и выполнения функций по его техническому обслуживанию совместно с модулем технического обеспечения, управления цифровой коммутацией каналов и т.д." +
                "^управляющее устройство цифрового коммутационного поля (УУ ЦКП).");
            answercomparison.Add("DX-500L-CPU-Pr, DX-500N-CPU-Pr или DX-500Pr-CPU"+
                "^DX-500L-PCM-4-Pr, DX-500N-PCM-4-Pr или DX-500Pr-PCM-4^DX-500L-ADK-Pr, DX-500L-ADK DUAL-Pr, DX-500N-ADK-Pr или DX-500Pr-ADK" +
    "^DX-500Pr-PCM2^DX-500N-16DPI^DX-500N-6DP^какая-то еще штука");
            answercomparison.Add("" +
                "Уточнить на каком платоместе в станции находится требуемый модуль ААЛ (определить порты для конфигурации)" +
                "^ Осуществить конфигурацию глобальной таблицы MAP(присвоение списочного номера ААЛ)" +
                "^Осуществить конфигурацию требуемых портов в локальной таблице Port (основные параметры 1,2,8)" +
                "^Осуществить подключение ААЛ" +
                "^Осуществить конфигурацию локальной таблицы Pn (присвоение абонентскому порту имени)" +
                "^ Осуществить конфигурацию требуемых портов в локальной  таблице Portp(основные параметры 12, 15)");
            answercomparison.Add("ca^t^ff^fa^cr");

            otvetucomparison.Add("3^2^4^1");
            otvetucomparison.Add("5^2^3^6^4^1^7");
            otvetucomparison.Add("5^2^3^4^6^1^7");
            otvetucomparison.Add("4^1^3^6^5^2");
            otvetucomparison.Add("4^2^5^1^3");

        }
        /// <summary>
        /// получить ответ из блока слова
        /// </summary>
        /// <param name="iter"></param>
        /// <returns></returns>
        public string DX_500WordANS(int iter)
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
        public string DX_500ComparisonANS(int iter)
        {
            ansrand = answercomparison[iter];
            answercomparison.Remove(ansrand);
            return ansrand;
        }
        public string DX_500otvetu(int iter)
        {
            ansrand = otvetucomparison[iter];
            otvetucomparison.Remove(ansrand);
            return ansrand;
        }
        //добавить ответы
    }
}
