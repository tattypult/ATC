﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATC
{
    internal class QuestionsHipass
    {
        string textrand;
        //массивы текстов
        List<string> textsword = new List<string>();
        List<string> textscomparison = new List<string>();
        /// <summary>
        /// конструктор текста вопросов
        /// </summary>
        /// <param name="N"></param>
        public QuestionsHipass()
        {
            textsword.Add("Дополните предложение:" + "УПАТС HiPath 4000 – представляет собой конвергированную коммуникационную IP - платформу для средних и крупных предприятий, объединяющую в себе две" + " технологии связи – традиционную ___ технологию с коммутацией каналов и __ телефонию с коммутацией пакетов.");
            textsword.Add("Дополните предложение:" + "Коммуникационная платформа HiPath 4000 создана на базе коммутационного сервера ______ ____E / H");
            textsword.Add("Дополните предложение:" + "Платформа HiPath 4000 поддерживает до __ полок расширения и до 83 - х выносов, подключенных по IP." + "Платформа HiPath 4000 способна обслуживать до 5760 обычных телефонов или до ___ IP - телефонов.");
            textsword.Add("Дополните предложение:" + "Станции HiPath, полученные путем преобразования из станции HICOM 330H / 350Н, " + "получили название соответственно HiPath ___ и HiPath ___ в зависимости от типа исходной станции HICOM 300H.");
            textsword.Add("Дополните предложение:" + "Модуль HiPath HG 3530 обеспечивает IP - доступ к телефонам, подключенным по __ - сети и работающим в стандарте ___." + "Модуль поддерживает полный спектр функций платформы HiPath." + "Модуль HiPath HG 3530 поддерживает 10/100BT сетевой IP-интерфейс для подключения до  рабочих мест по IP. " + "Интегрированный модуль использует интерфейс G.711 и функционирует без гейткипера. Администрирование осуществля-ется через систему управления HiPath 4000 Management. ");
            textsword.Add("Дополните предложение:" + "Платформа HiPath 4000 предоставляет возможность создания корпоративных сетей в определенной местности, в Европе или в мире, соединяя " + "несколько систем посредством автоматических и некоммутируемых соединений." + "Сеть может быть организована по ___ NQ протоколу через ISDN -, ATM - или IP - сеть." + "____NQ – это стандартный сигнальный протокол компании Siemens для решений корпоративной сети.Он позволяет обеспечить доступ к функциям платформы и основным услугам по всей инфраструктуре." + "Эти функции улучшают внутреннюю связь на местах, повышают эффективность работы с клиентами и удобство в работе.");
            textsword.Add("Дополните предложение:" + "Полка CSPCI может иметь несколько вариантов компоновки:" + "1.SIMPLEX ___ - монопроцессорноя компоновка, где системы CCи ADP конструктивно совмещены и управляются одним процессором, при этомрезервирование работы систем не предусмотрено" + "2.DUPLEX ___ - многопроцессорноя компоновка, где системы и ADP конструктивно разделены и управляются каждая своим процессором, " + "при этом предусмотрено резервирование работы системы CC для чего в полкеустановлено два комплекта оборудования CC - A и CC-B.");

            textscomparison.Add("Сопоставьте:Функциональные модули станции HICOM / HiPath с их описанием:" +
                "|система общего контроля основная" +
                "|коммутационная система, которую функционально образуют СС + полки расширения" +
                "|сервер управления и обслуживания базы данных" +
                "|конструктивно образуют базовую полку, к которой подключаются все остальные периферийные устройства");
            textscomparison.Add("Сопоставьте:Сопоставьте модули полки CSPC с их функциями:" +
                "|служит интерфейсом для подключения периферийных полок LTU к базовой системе СС (common control)." +
                "|Источник питания ….. преобразует входное напряжение 90-264 В переменного тока частотой 47 63 Гц в постоянное вторичное напряжение номиналом +3,3 В, +5 В, +12 В и 12В." +
                "|Является центральным проце с сором станции HiPath 4000. В зависимости от типаархитектуры станции HiPath 4000 модуль может выполнять функции или ADP или SWU при варианте исполнения Duplex, или совмещать обе функции ADP SWU при варианте исполнения Simplex");
            textscomparison.Add("Сопоставьте:Сопоставьте интерфейсы полки CSPC с их функциями:" +
                "|Через этот порт выводятся от модуля DSCXL три сигнала индикации аварийного состояния станции:1.ALUM сигнал о прекращении работы станции;2.UAL сигнал о значительной аварии;3.NAL сигнал о незначительной аварии." +
                "|служит для подключения внешнего генератора Atlantic External Clock Box" +
                "|Через этот порт в базовую полку поступают сигналы об авариях источников питания: 1.WRA отказ конвертора DC AC 2.NGA отказ выпрямителя AC DC 3.NGAR отказ выпрямителя AC DC 4.PFNMI пропадание сетевого питания 5.BAEXF авария устройства управления аккумуляторами 6.GND земля");

        }
        /// <summary>
        /// получить один вопрос из блока слова
        /// </summary>
        /// <param name="iter"></param>
        /// <returns></returns>
        public string HiPassWord(int iter)
        {
            textrand = textsword[iter];
            textsword.Remove(textrand);
            return textrand;
        }
        /// <summary>
        /// получить один вопрос из блока сопоставление
        /// </summary>
        /// <param name="iter"></param>
        /// <returns></returns>
        public string HiPassComparison(int iter)
        {
            textrand = textscomparison[iter];
            textscomparison.Remove(textrand);
            return textrand;
        }
    }
}
