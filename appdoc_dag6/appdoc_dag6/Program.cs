using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appdoc_dag6
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Dog[] arrayOfDogs = new Dog[3];

            Dog dog_sharo = new Dog("Sharo", "Shepherd");
            Dog dog_Rex = new Dog("Rex", "BMW");
            Dog dog3 = new Dog();

            arrayOfDogs[0] = dog_sharo;
            arrayOfDogs[1] = new Dog("Rex", "BMW");
            arrayOfDogs[2] = new Dog();

            for(int i=0; i< arrayOfDogs.Length; i++)
            {
                arrayOfDogs[i].HauHau();
            }

        }

    }

    public class Dog
        {
            private string name;
            private string breed;

            public Dog()
            {
                this.name = "Balkan";
                this.breed = "Street excellent";
                            }

            public Dog(string name, string breed)
            {
                this.name = name;
                this.breed = breed;
            }
            public string Name
            {
                get { return name; }
                set { name = value; }

            }

            public string Breed
            {
                get { return breed; }
                set { breed = value; }

            }

            public void HauHau()
            {
                Console.WriteLine("{0} said: HAUUUUUUUUU" , name);
             
            }
        }  
 
}
