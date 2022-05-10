using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATC
{
    internal class T_76Answers
    {
        List<string> answersword = new List<string>();
        List<string> answercomparison = new List<string>();
        string ansrand = "";
        List<string> otvetucomparison = new List<string>();
        public T_76Answers()
        {
            answersword.Add("sipiax2");
            answersword.Add("телефоннойпакетной");
            answersword.Add("g711g726gsm");
            answersword.Add("zaptegosfilelantablesportscrypto");
            answersword.Add("нсд");
            answersword.Add("24242");
            answersword.Add("суимт76спользователямидиагностики");
            answersword.Add("разграничениецелостности");
            answersword.Add("fxs22100");
            answersword.Add("hostname");
            answersword.Add("мартшрутизации");
            answersword.Add("ipmac");
            answersword.Add("1313262638687110");
            answersword.Add("generaliaxroute");

            answercomparison.Add("IFACE_NAME^NET^NETMASK^GATEWAY^DEFAULT_GW^METRIC");
            answercomparison.Add("IPTABLES^ZAPTEL^SPAN^ZAPATA^EXTENSIONS");
            answercomparison.Add("ZAPATA {^CONTEXT=main^SWITCHTYPE=national^ECHOCANCEL=true" +
                "^ECHOCANCELWHENBRIDGED=true^CHAN {^GROUP=1^SIGNALLING=pri_net^CHANNEL=1 - 15, 17 - 31");
            answercomparison.Add("NUMBER^TYPE^USERNAME^SECRET^HOST^CONTEXT^DISALLOW^ALLOW^CANREINVITE");
            answercomparison.Add("Answer()^Busy()^ChanIsAvail()^Dial()^GotoIf()^Hangup()^Playback()	^Wait()^WaitExten()");


            otvetucomparison.Add("3^4^1^2^5^6");
            otvetucomparison.Add("3^4^5^1^2");
            otvetucomparison.Add("1^6^7^8^2^4^5^3^8");
            otvetucomparison.Add("4^3^1^2^7^8^9^6^5");
            otvetucomparison.Add("7^1^9^3^2^8^6^5^4");
        }
        /// <summary>
        /// получить ответ из блока слова
        /// </summary>
        /// <param name="iter"></param>
        /// <returns></returns>
        public string T_76WordANS(int iter)
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
        public string T_76ComparisonANS(int iter)
        {
            ansrand = answercomparison[iter];
            answercomparison.Remove(ansrand);
            return ansrand;
        }
        public string T_76otvetu(int iter)
        {
            ansrand = otvetucomparison[iter];
            otvetucomparison.Remove(ansrand);
            return ansrand;
        }
    }
}
