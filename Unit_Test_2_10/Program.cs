/* Rose Silletto
 * IGME 202
 * Unit Test 2 #10
 * Oct. 23 2022
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_Test_2_10
{
    internal class Program
    {
        public abstract class Creature
        {
            private int hitpoints;
            public int HitPoints
            {
                get { return hitpoints; }
            }
            public void Move(object obj) { }
            public void Attack(object obj)
            {
                Console.WriteLine("You have attacked!");
            }
        }
        public interface MonsterInterface
        {
            void Move();
            void Attack();
        }
        public interface PersonInterface
        {
            void Move();
            void Attack();
            void Talk();
        }
        public class Monster
        {
            private int hitpoints;
            public int HitPoints
            {
                get { return hitpoints; }
            }
            public void Move(object obj) { }
            public void Attack(object obj)
            {
                Console.WriteLine("You have attacked!");
            }
        }
        public class Person
        {
            private int hitpoints;
            public int HitPoints
            {
                get { return hitpoints; }
            }
            public void Move(object obj) { }
            public void Attack(object obj)
            {
                Console.WriteLine("You have attacked!");
            }
            public void Talk()
            {
                Console.WriteLine("'Hello!'");
            }
        }

        static void Main(string[] args)
        {
            Monster dragon = new Monster();
            dragon.Attack(dragon);

            Person hero = new Person();
            hero.Attack(hero);
            hero.Talk();
        }
    }

}
