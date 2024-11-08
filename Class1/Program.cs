using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] nums=new Person[]
            {
				new Person() {  Id= 1, Name= "Alice", score= 3 },
                           new Person()  {Id= 2,Name= "Bob", score= 7.87 },
                           new Person()  {Id= 3,Name= "Charlie", score= 9.001 },
                           new Person()  {Id= 4,Name= "David", score= 11 },
                           new Person()  {Id= 5,Name= "Eve", score= 13 },
                           new Person()  {Id= 6,Name= "Frank", score= 8 },
                           new Person()  {Id= 7,Name= "Grace", score= 9 },
                           new Person()  {Id= 8,Name= "Hannah", score= 9.2 },
                           new Person() { Id=9, Name="Isaac", score= 8.86 }
            };

         


            foreach (Person i in nums)
            {
                int Score = ((int)(i.score)) < i.score ?(int)( i.score + 1) :(int) i.score;
                Console.WriteLine($"Id : {i.Id} Name: {i.Name} Score : {i.score}  Status: "+ (Score>= 10 ? "Passed" : "Faled"));
            }

            Console.ReadKey();

        }
    }
}
