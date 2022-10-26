/* Rose Silletto
 * IGME 202
 * PE 13 More Classes
 * Oct. 21 2022
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Media;
using System.Net;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PE13
{
    internal class Program
    {
        public int license;
        public string name;
        public int age;

        public class Pets
        {
            List<Pet> petList = new List<Pet>();

            public int Count
            {
                get { return petList.Count; }
            }

            // Methods:

            public void Add(Pet pet)
            {
                petList.Add(pet);
            }

            public void Remove(Pet pet)
            {
                petList.Remove(pet);
            }

            public void RemoveAt(int petEl)
            {
                petList.RemoveAt(petEl);
            }

            public Pet this[int nPetEl]
            {
                get
                {
                    Pet returnVal;
                    try
                    {
                        returnVal = (Pet)petList[nPetEl];
                    }
                    catch
                    {
                        returnVal = null;
                    }

                    return (returnVal);
                }

                set
                {
                    // if the index is less than the number of list elements
                    if (nPetEl < petList.Count)
                    {
                        // update the existing value at that index
                        petList[nPetEl] = value;
                    }
                    else
                    {
                        // add the value to the list
                        petList.Add(value);
                    }
                }
            }

        }

        public interface ICat
        {
            void Eat();
            void Play();
            void Scratch();
            void Purr();
        }

        public abstract class Pet
        {
            private string name;
            public int age;

            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            // constructors:

            public Pet()
            {

            }

            public Pet(string name, int age)
            {
                this.name = name;
                this.age = age;
            }


            // methods:

            public abstract void Eat();

            public abstract void Play();

            public abstract void GotoVet();

        }

        public class Cat : Pet, ICat {

            // methods:

            public override void Eat()
            {
                Console.WriteLine(Name + " eats their food.");
            }

            public override void Play()
            {
                Console.WriteLine(Name + " plays with their toys.");
            }

            public override void GotoVet()
            {
                Console.WriteLine(Name + " goes to the vet.");
            }

            public void Scratch()
            {
                Console.WriteLine(Name + " scratches the furniture.");
            }

            public void Purr()
            {
                Console.WriteLine(Name + " purrs contentedly.");
            }
        }

        public interface IDog
        {
            void Eat();
            void Play();
            void Bark();
            void NeedWalk();
            void GotoVet();

        }

        public class Dog : Pet, IDog
        {
            public string license;
            public string name;
            public int age;

            public Dog(string name, int age, string license) : base(name, age)
            {
                this.license = license;
            }

            // methods:

            public override void Eat()
            {
                Console.WriteLine(Name + " eats their food.");
            }

            public override void Play()
            {
                Console.WriteLine(Name + " plays with their toys.");
            }

            public override void GotoVet()
            {
                Console.WriteLine(Name + " goes to the vet.");
            }

            public void Bark()
            {
                Console.WriteLine(Name + " barks incessantly.");
            }

            public void NeedWalk()
            {
                Console.WriteLine(Name + " needs a walk.");
            }
        }


        static void Main(string[] args)
        {
            // reference variables for the pets and interfaces:
            
            Dog dog = new Dog("Spot", 4, "201");
            Cat cat = new Cat();
            
            // Create a list of pets:
            Pets pets = new Pets();

            // Create a random number generator:
            Random rand = new Random();

            for (int i = 0; i < 50; i++)
            {
                // the Dog() object must be passed the 3 fields (license, name and age) in the constructor.

                // 1 in 10 chance of adding an animal
                if (rand.Next(1, 11) == 1)
                {
                    if (rand.Next(0, 2) == 0)
                    {
                        // add a dog

                        pets.Add(dog);

                    }
                    else
                    {
                        // else add a cat
                        pets.Add(cat);

                    }
                }
                else
                {
                    // choose a random pet from pets and choose a random activity for the pet to do

                    Pet randomPet = pets[rand.Next(0, pets.Count)];
                    if (randomPet == null)
                    { continue; }
                    if (randomPet is Cat)
                    {
                        ICat ic = (Cat)randomPet;
                        switch (rand.Next(0, 4))
                        {
                            case 0: ic.Eat(); break;
                            case 1: ic.Play(); break;
                            case 2: ic.Scratch(); break;
                            case 3: ic.Purr(); break;
                        }
                    }
                    else
                    {
                        IDog id = (Dog)randomPet;
                    }
                }

                // Else if it did not generate a 1, then set thisPet to a random pet from the pets List<>
                // based on a random number between 0 and pets.Count. Note that if there were no pets added yet,
                // this will return null. If null was returned, then continue to the top of the for () loop.

                // If a valid pet was returned, set your interface variable (iDog or iCat) to thisPet
                // (based on thisPet.GetType()) and randomly call one of the member methods of the interface.
            }
        }
    }

}
