using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bmi_hw
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("輸入你的身高");
            float height = float.Parse(Console.ReadLine());
            Console.Write("輸入你的體重");
            float weight = float.Parse(Console.ReadLine());
            float BMI = (weight /( height * height));
            Console.WriteLine("你的BMI值為:" + BMI);
            if (BMI > 31.5)
            {
                Console.WriteLine("過重,免兵役");
            }
            else if (BMI < 16.5)
            {
                Console.WriteLine("過輕,免兵役");
            }
            else
            {
                Console.WriteLine("BMI正常,必須當兵");
            }

            Console.Read();
        }

    }
  }
    

