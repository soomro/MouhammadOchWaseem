using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dog
{
    class Program
    {
        static void Main(string[] args)
        {

            int dogs_count = 4;
            Dog[] arrayOfDogs = new Dog[dogs_count];

            Dog dog_sharo = new Dog("Sharo", "Shepherd", "happy");
            Dog dog_Rex = new Dog("Rex", "BMW");
            Dog dog3 = new Dog();

            arrayOfDogs[0] = dog_sharo;
            arrayOfDogs[1] = new Dog();
            arrayOfDogs[2] = new Dog("Rex", "BMW");
            arrayOfDogs[3] = new Dog("Rex", "BMW", "happy");

            for (int i=0; i< arrayOfDogs.Length; i++)
            {
                arrayOfDogs[i].HauHau();
            }

            // 'please key to close' feature
            Console.WriteLine("Press any key to close the window!!");
            Console.ReadKey();
        }
    }

    public class Dog
    {
    private string name;
    private string breed;
    private string mood; 

    public Dog()
    {
        this.Name = "Balkan";
        this.Breed = "Street excellent";
        this.Mood = "happy";
    }
        
    public Dog(string name, string breed)
    {
        this.Name = name;
        this.Breed = breed;
    }

    public Dog(string name, string breed, string mood)
    {
        this.Name = name;
        this.Breed = breed;
        this.Mood = mood;
    }

    public string Mood
        {
            get
            {
                return mood;
            }

            set
            {
                mood = value;
            }
        }

    public string Breed
        {
            get
            {
                return breed;
            }

            set
            {
                breed = value;
            }
        }

    public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

    public void HauHau()
            {
                Console.WriteLine("{0} said: HAUUUUUUUUU" , Name);
             
            }
    }  
 
}
