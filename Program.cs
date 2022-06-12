using System;
namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Adeleke", 28);
            var personB = new PersonDemo("Jare", 23, 890.35);

            person.greetPerson();

            personB.greetPerson();

            Person.sayAnything("What happens? ");

            Person.printSkills("Cooking", "Swimming", "Sleeping");

            Strings.stringOperation("Chief");

            var school = new School("Kaa", 100);

            Console.WriteLine("Hello, World. My favorite color:  " + Colors.Red);
            int a = 3;
            Console.WriteLine("The value of a is  " + a);
            int b = a++;
            Console.WriteLine("b is " + b + " a is " + a);
            int c = ++a;
            Console.WriteLine("c is " + c + " a is " + a);

            int d = a--;
            Console.WriteLine("d is " + d + " a is " + a);

            int e = --a;
            Console.WriteLine("e is " + e + " a is " + a);

            int fiveModuloTwo = 5 % 2;
            Console.WriteLine("5 mod 2 is " + fiveModuloTwo);


            /**
            Comparison Operator
            int a1 = 2 ; 
            int a3 = 3 ; 
            bool compareA1WithA3 = a1 <=  a3 //true
            == Equality 
            != 
            */

            /*
            && - AND 
            || - OR 
            ! Negation 

            Logical Operators 
            int simpleA = 4;
            int simpleB = 3 ; 
            int simpleD = 5 ; 


            bool compoundA = (simpleA > simpleB || simpleA > simpleD)! ;
            S1 : true && false 
            Final Value : true; false ; true

            */
            int num = 20;
            num = 30;
            Console.WriteLine("What is in num " + num);
            num += 10;
            Console.WriteLine("What is in num " + num);
            num -= 20;
            Console.WriteLine("After subtracting and assign " + num);

            (double sum, int count) = (45.3, 22);
            Console.WriteLine($"The Sum is {sum}  and count:  {count} ");

            Console.WriteLine($"Min Val {int.MinValue}  , Max:  {int.MaxValue} ");

            //Console.WriteLine($"An underflow Min Val {int.MinValue - 3}  ,  ");
            ArrayDemo.playWithFruits();
            ArrayDemo.fibonnaci();
        }
    }
}
// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
