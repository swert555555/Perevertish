using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Перекидыш
{

    internal class Десериализация
    {
        public static List<Tulovishe> tela = new();
        public static void ReadTXT()
        {
            string[] Lines = File.ReadAllLines(Сериализация.mesto);
            for (int i = 0; i < Lines.Length; i += 5)
            {
                tela.Add(new Tulovishe(Lines[i], Lines[i + 1], Convert.ToInt32(Lines[i + 2]), Lines[i + 3]));
            }
            foreach (Tulovishe telo in tela)
            {
                Console.WriteLine(telo.Name + "\n" + telo.Sex + "\n" + telo.Age + "\n" + telo.Сause_of_death);
            }

        }
        public static void ReadJSON()
        {
            string text = File.ReadAllText(Сериализация.mesto);
            List<Tulovishe> tel = JsonConvert.DeserializeObject<List<Tulovishe>>(text);

            foreach (Tulovishe telo in tel)
            {
                Console.WriteLine(telo.Name + "\n" + telo.Sex + "\n" + telo.Age + "\n" + telo.Сause_of_death);
            }
        }
        public static void ReadXML()
        {
            XmlSerializer xml = new(typeof(List<Tulovishe>));
            using (FileStream fs = new FileStream(Сериализация.mesto, FileMode.Open))
            {
                tela = xml.Deserialize(fs) as List<Tulovishe>;
            }
            foreach (Tulovishe telo in tela)
            {
                Console.WriteLine(telo.Name + "\n" + telo.Sex.ToString() + "\n" + telo.Age + "\n" + telo.Сause_of_death);
            }
        }
    }
}
