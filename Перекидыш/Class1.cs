using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Перекидыш;
using System.IO;
using System.Diagnostics;
using System.Xml.Linq;
using System.Runtime.Serialization;

namespace Перекидыш
{
    internal class Сериализация
    {
        public static List<Tulovishe> tela = new List<Tulovishe> {};
        public static string mesto;

        public static void ConvertTXT()
        {
            foreach (Tulovishe telo in Десериализация.tela)
            {
                File.AppendAllText(mesto, telo.Name + "\n" + telo.Sex + "\n" + telo.Age + "\n" + telo.Сause_of_death + "\n_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _\n\n");
            }
        }
        public static void ConvertJson()
        {
            string json = JsonConvert.SerializeObject(Десериализация.tela);
            File.WriteAllText(mesto, json);
        }
        
        public static void ConvertXml()
        {
            XmlSerializer xml = new(typeof(List<Tulovishe>));
            using (FileStream fs = new FileStream(mesto, FileMode.Create))
            {
                xml.Serialize(fs, Десериализация.tela);
            }
        }


        public static void ConvertTXTLast()
        {
            //Directory.CreateDirectory("C:\\Users\\Kotam\\OneDrive\\Рабочий стол\\Морг");
            //C:\\Users\\Kotam\\OneDrive\\Рабочий стол\\Морг\\Учет.txt

            if (File.Exists(mesto))
            {
                Tulovishe adult1 = new Tulovishe("Сергей Вадимович", "М", 46, "Обследование не проведено");

                Tulovishe adult2 = new Tulovishe("Лена Головач", "Ж", 31, "Обследование не проведено");

                Tulovishe kid = new Tulovishe("Кирилл Голеусов", "М", 6, "Обследование не проведено");

                List<Tulovishe> tela = new List<Tulovishe> { adult1, adult2, kid };

                foreach (Tulovishe telo in tela)
                {
                    File.AppendAllText(mesto, telo.Name + "\n" + telo.Sex + "\n" + telo.Age + "\n" + telo.Сause_of_death + "\n_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _\n\n");
                }
            }
            else File.Create(mesto);
        }

        
    }
}
