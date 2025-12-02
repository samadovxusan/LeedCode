using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodee.OppExample
{
    public class Odam
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public virtual void Tanishish()
        {
            Console.WriteLine($"Salom Mening Ismin :{Name} Yoshim : {Age}");
        }
        public virtual void Yurish()
        {
            Console.WriteLine($"{Name} Yuribdi");
        }

    }

    public class Student : Odam
    {
        public string Universitet { get; set; }
        public double Stipendiya { get; set; }

        public override void Tanishish()
        {
            Console.WriteLine($" Salom {Name}  {Universitet} da Oqishman ");
        }

        public override void Yurish()
        {
            Console.WriteLine($" Men {Name} bugun {Stipendiya} Oldim va juda xursandman ");
        }

    }

    public class Dasturchi : Odam
    {
        public string Til { get; set; }
        private string Moash { get; set; }
        public void UpdateMoash(double depasit)
        {
            if (depasit <= 0)
                Console.WriteLine("Depasit xato");

            Moash += depasit;
        }
        public string GetMoash()
        {
            return Moash;
        }

        public override void Tanishish()
        {
            Console.WriteLine($"Salom Men {Name}  Click kampaniyasida {Til} boyicha ishlayman ");
        }
    }
}
