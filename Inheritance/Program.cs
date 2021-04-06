using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            Bird stork = new Bird();
            stork.Name = "stork";
            stork.Age = 30;
            stork.Food = "small reptiles";
            stork.Habitat = "near rivers and lakes";
            stork.Feathers = true;
            stork.Eggs = true;
            stork.Wingspan = 2;
            stork.Migrating = true;
            Console.WriteLine($"The {stork.Name} is a famous bird that lives around {stork.Age} years and is feeding on mostly {stork.Food}. " +
                $"It prefers to nest {stork.Habitat} so food is easily accessible. It is a {stork.Feathers} fact that their body is covered in feathers" +
                $"and it also is {stork.Eggs} that they lay eggs in order to have chicks. The {stork.Name} is a large bird, as their wingspan reaches {stork.Wingspan} " +
                $"meters and it is also a {stork.Migrating} fact that they are a migrating species.");



            /*Create an object of your Reptile class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            Reptile crocodile = new Reptile();
            crocodile.Name = "crocodile";
            crocodile.Age = 70;
            crocodile.Food = "small and medium size animals";
            crocodile.Habitat = "semiaquatic";
            crocodile.Carnivorous = true;
            crocodile.Skin = "bony scales";
            crocodile.Claws = true;
            crocodile.Teeth = "sharp";

            Console.WriteLine("");

            Console.WriteLine($"The {crocodile.Name} is a large reptile that lives around {crocodile.Age} years. It mostly feeds on " +
                $"{crocodile.Food} and it prefers a {crocodile.Habitat} habitat. It is a {crocodile.Carnivorous} fact that the {crocodile.Name} " +
                $"is a carnivorous reptile. Its skin is covered in {crocodile.Skin} and it is a {crocodile.Claws} and well known fact that their claws" +
                $"are deadly, same as their {crocodile.Teeth} teeth.");

        }
    }
}
