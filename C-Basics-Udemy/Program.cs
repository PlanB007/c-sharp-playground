using System;

namespace C_Basics_Udemy
{
    class Program
    {
        interface Iitem
        {
            string name { get; set; }
            int age { get; set; }

            void Sell();
        }

        //Inherits the interface 
        class Sword : Iitem
        {
            public string name { get; set; }
            public int age { get; set; } 

            public Sword (string _name)
            {
                name = _name;
                age = 5;
            }

            public void Sell()
            {
                Console.WriteLine($"{name} is sold");
            }
        }

        class Player
        {
            private int totalHealth = 100;
    
            public int currentHealth
            {
                get
                {
                    return totalHealth;
                }
            }

            public void Damage(int dmg)
            {
                totalHealth -= dmg;
            }
        }

        //This is called a method, with the name Main. Main is the beginning of the program
        static void Main(string[] args)
        {
            Sword sword = new Sword("The almight sword");
            sword.Sell();

            Player John = new Player();
            Console.WriteLine(John.currentHealth);
            John.Damage(10);
            Console.WriteLine(John.currentHealth);
            
            //Changing the current health isn't posible because it has only a get
            //John.currentHealth = 30

            Dog Bran = new Dog();
            Bran.name = "Brann";
            Bran.age = 4;

            Bran.Print();
            Bran.Bark();

            DateTime currentTime = DateTime.Now;

            //Simple example of for loop and check if it's an even number
            for (int i = 0; i < 10; i++)
            {
                Console.Write(i);

                if(i % 2 == 0)
                {
                    Console.WriteLine("it's even");
                } else
                {
                    Console.WriteLine("it's odd");
                };
            };
             
            //Console is also a class and writeline is a method
            Console.WriteLine("Type your number!");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Type the second number!");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Type the operator");
            char calcOperator = char.Parse(Console.ReadLine());
            switch (calcOperator)
            {
                case '+':
                    int anwserPlus = firstNumber + secondNumber;
                    Console.WriteLine($"Okay, so {firstNumber} + {secondNumber} = {anwserPlus}");
                    break;
                case '-':
                    int anwserMinus = firstNumber - secondNumber;
                    Console.WriteLine($"Okay, so {firstNumber} - {secondNumber} = {anwserMinus}");
                    break;
                case '/':
                    int anwserDived = firstNumber / secondNumber;
                    Console.WriteLine($"Okay, so {firstNumber} / {secondNumber} = {anwserDived}");
                    break;
                case '*':
                    int anwserMulti = firstNumber * secondNumber;
                    Console.WriteLine($"Okay, so {firstNumber} * {secondNumber} = {anwserMulti}");
                    break;
                default:
                    Console.WriteLine("Mhm, I don't reconize that operator sorry!");
                    break;
            };

            Console.WriteLine("What's your name?");
            string name = Console.ReadLine();

            //Call method GreetUser
            GreetUser(name);

            //At this moment the value of the 3 items in the array are empty
            string[] friends = new string[3];

            //Now we set the third item in the friends array to 'Foo'
            friends[2] = "Foo";

            //Easier way to declare an array
            string[] newFriends =
            {
                "Jo",
                "Ben",
                "Bar"
            };

            try
            {
                int _firstNumber = 0;
                int _secondNumber = 15 / _firstNumber; //This will throw an error
            }
            catch (Exception exception)
            {

                Console.WriteLine($"Error {exception.Message}");
            }

                //Variables
                //int firstNumber = 1;
                //double secondNumber = 6.7;
                //int thirdNumber = 988;
                //string firstName = "kevin";
                //char singleLetter = 'k';
                //bool isBool = true;
            }

        //Void means it doesn't return anything
        static void GreetUser(string name)
        {
            Console.WriteLine($"Hello {name}");
            Console.WriteLine($"Did you know that 5 + 10 is {Add(5, 10)} ?");
        } 

        //Now it returns an int
        static int Add(int numberOne, int numberTwo)
        {
            return numberOne + numberTwo;
        }
    }
}
