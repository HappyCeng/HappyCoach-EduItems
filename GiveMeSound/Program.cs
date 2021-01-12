using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiveMeSound
{
    class Program
    {
        static void Main(string[] args)
        {
            //OOP
            Animal animal = new Animal();

            animal.soundAnimal();
            Console.WriteLine(animal.animal_name);

            Animal animal1 = new Cat();//ama burda sadece catin animal üzerine override ettiği metodlar çalıştı
            Cat cat = new Cat();//cat oluşturduğum anca constructure çalıştı

            Console.WriteLine("Cattan sonra : " + cat.animal_name);
            Console.WriteLine("Cattan sonra : " + animal.price.ToString());
            animal1.soundAnimal();

            Animal animal2 = new Dog();
            Dog dog = new Dog();
            //dog.setAnimal();
            Console.WriteLine("ogtan sonra : " + dog.animal_name);//
            animal2.setAnimal();

            Console.WriteLine("Dogdan sorna : " + animal2.animal_name);

            animal2.soundAnimal();
            Console.WriteLine(animal2.animal_name);

            Dock dock = new Dock();

            dock.soundAnimal();
            Console.WriteLine(dock.animal_name);
            Console.WriteLine(dock.buy_Duck(4).ToString());

            Donkey donkey = new Donkey();

            donkey.soundAnimal();
            donkey.setAnimal();

            Console.WriteLine(donkey.getAnimalName());
            donkey.setAnimalName("Eşşek");
            Console.WriteLine(donkey.getAnimalName());

            Console.WriteLine(donkey.getPrice());
            donkey.setPrice(501);
            Console.WriteLine(donkey.getPrice());

        }
    }
}
