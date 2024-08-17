using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class StarOfDeath
    {
        double power;
        double charge;
        string name;
        string[] weapons = { "Истребитель", "Рарушитель", "Лазер" };


        public string this[int index]
        {
            get  => weapons[index];  
        }

        public StarOfDeath() {
            power = default(double); 
            charge = default(double);
            name = default(string);
        }


        public StarOfDeath(double power, double size, string name) { 
            this.power = power;
            this.charge = size;
            this.name = name;
        }

        public void Сharge(double amount)
        {
            if (amount <= 0) Console.WriteLine("Нет энергии");
            if ((this.charge += amount) > 5000.0)
            {
                this.charge = 5000;
                Console.WriteLine("Устройство заряжено до полного бака");
            }
            else this.charge -= amount;
            this.charge += amount;
            Console.WriteLine("Устройство заряжено до " + this.charge + " Ампер");

        }

        public void Fire()
        {
            Console.WriteLine("Выстрелел");
            this.charge -= 1000;
        }

        public void CurrCharge()
        {
            Console.WriteLine("Текущий заряд Звезды Смерти равен " + this.charge);
        }

        public string GetName()
        {
            return name;
        }

        public static StarOfDeath operator +(StarOfDeath a,StarOfDeath b) { 
            StarOfDeath ret = new StarOfDeath();
            ret.power = a.power + b.power;
            ret.charge = a.charge + b.charge;
            ret.name = a.name + b.name+"!!!!<3";
            return ret;
        }

        public static StarOfDeath operator +(StarOfDeath a, double b)
        {
            StarOfDeath ret = new StarOfDeath();
           
            ret.charge = a.charge + b;
            return ret;
        }

        
    }
    
}
