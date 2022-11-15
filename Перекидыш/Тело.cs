using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Перекидыш
{
    public class Tulovishe
    {
        public string Name;
        public string Sex;
        public int Age;
        public string Сause_of_death = "Обследование не проведено";

        public Tulovishe() { }
        public Tulovishe(string name, string sex, int age, string cause_of_death)
        {
            Name = name;
            Sex = sex;
            Age = age;
            Сause_of_death = "Обследование не проведено";
        }
        public List<Tulovishe> tela;
    }
}
