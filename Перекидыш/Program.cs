using Newtonsoft.Json;
using System.Security.Cryptography;
using System.IO;
using System.Diagnostics;
using System.Xml.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using Перекидыш;

namespace Перекидыш
{
    internal class Program
    {
        static void Main()
        {   
            Console.WriteLine("Введи путь до файла, который хочешь открыть: ");
            Сериализация.mesto = Console.ReadLine();
            Console.Clear();
            if (Сериализация.mesto.Contains(".txt"))
                Десериализация.ReadTXT();
            else if (Сериализация.mesto.Contains(".xml"))
                Десериализация.ReadXML();
            else if (Сериализация.mesto.Contains(".json"))
                Десериализация.ReadJSON();

            Console.WriteLine("\nЖелаешь внести изменения? да/нет");
            if (Console.ReadLine() == "да")
            {
                Console.WriteLine("Введите порядковый номер тела(от 1 до 3) и номер строки(1 - имя, 2 - пол, 3 - взрст, 4 - прич смерти), \nкоторую хотите изменить, а после данные, на которые хотите изменить: ");
                int tr = Convert.ToInt32(Console.ReadLine());
                int str = Convert.ToInt32(Console.ReadLine());

                if (str == 1)
                    Десериализация.tela[tr - 1].Name = Console.ReadLine();
                else if (str == 2)
                    Десериализация.tela[tr - 1].Sex = Console.ReadLine();
                else if (str == 3)
                    Десериализация.tela[tr - 1].Age = Convert.ToInt32(Console.ReadLine());
                else if (str == 4)
                    Десериализация.tela[tr - 1].Сause_of_death = Console.ReadLine();
            }
            
            Console.Clear();
            Console.WriteLine("Введи путь до файла, в который желаете сохранить данные: ");
            Сериализация.mesto = Console.ReadLine();
            
            if (Сериализация.mesto.Contains(".txt"))
                Сериализация.ConvertTXT();
            else if (Сериализация.mesto.Contains(".xml"))
                Сериализация.ConvertXml();
            else if (Сериализация.mesto.Contains(".json"))
                Сериализация.ConvertJson();
        }

    }
}



/*

                //ЛЕКЦИЯ ПАПКИ
                Directory.CreateDirectory("C:\\Users\\Kotam\\OneDrive\\Рабочий стол\\Морг\\Учет");
            //if (Directory.Exists(*папка*))
            //  Directory.Delete(*папка*);
            //else *создаем папку*

            string[] paths = Directory.GetFiles("C:\\Users\\Kotam\\OneDrive\\Рабочий стол\\Морг\\Учет");
            foreach (string path in paths)
                Directory.Delete(path, true);


            Process.Start(new ProcessStartInfo
            {
                FileName = "C:\\Users\\Kotam\\OneDrive\\Рабочий стол\\Морг\\Учет",
                UseShellExecute = true,
            });

*/
