using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_Test
{
    internal class Program
    {
        static int maxHealth = 100;
        static int currentHealth;
        static bool isalive = true;
        static void Main(string[] args)
        {
            UnitTest();

            currentHealth = maxHealth;

            Console.WriteLine("Unit Test");

            ShowHUD();
            Takedamage(220);
            ShowHUD();
            Heal(300);
            ShowHUD();

            Console.WriteLine("press any key to Quit");
            Console.ReadKey(true);
            Console.Clear();
        }
        static void UnitTest()
        {
            currentHealth = 50;
            isalive = true;
            Heal(30);
            Debug.Assert(currentHealth == 80);
            Debug.Assert(isalive == true);

            currentHealth = 0;
            isalive = false;
            Takedamage(50);
            Debug.Assert(currentHealth == 0);
            Debug.Assert(isalive == false);

            currentHealth = 100;
            isalive = true;
            Heal(30);
            Debug.Assert(currentHealth == 100);
            Debug.Assert(isalive == true);
        }
        static void Heal(int heal)
        {
            
            if (currentHealth >= 100)
            {
                currentHealth = 100;
                Console.WriteLine("++++++++++++++");
                Console.WriteLine("already Healthy");
                Console.WriteLine("++++++++++++++");
            }
            else
            {
                currentHealth += heal;
                Console.WriteLine("++++++++++++++");
                Console.WriteLine("Healed - " + heal);
                Console.WriteLine("++++++++++++++");
            }
        }
        static void Takedamage(int damage)
        {
            currentHealth -= damage;
            if (currentHealth < 0)
            {
                currentHealth = 0;
            }
        }
        static void ShowHUD()
        {
            Console.WriteLine("====================");
            Console.WriteLine("Health - " + currentHealth);
            Console.WriteLine("====================");
        }
    }
}
