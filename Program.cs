using System;

namespace GarbageCollection
{
    internal class Program
    {
        //public static void Main()
        //{
        //    Person person = new Person(); // size 2MB
        //     person.Name = "Ashok";
        //    person = new Person(); // size 2MB
        //    person.Name = "Rajesh";
        //    Person person2 = new Person(); // // size 2MB
        //    person2.Name = "anoop";
        //    person = null;//deleting the object 
        //    //Person person3 = new Person();//2mb
        //    //person3.Name = "prateek";
        //    Console.WriteLine(person1.GetName());
        //    Console.WriteLine(person.GetName()); 
        //}
        // Alarm code
        // var Clock = getCurrentTime();
        // if(clock.time!= 9:00PM 3/07/2022)
        //{}
        // else{GC.Collect();

        static void Main(string[] args)
        {
            //Person p = new Person();
            ////p.Dispose();    //p= =3465
            //p = null;// p=nothing
            //GC.Collect();
            Console.WriteLine("Welcome to Garbage Collection..!");
            GC.Collect();
            // before creating array object
            var mem1 = GC.GetTotalMemory(false);
            {
                int[] arr;
                for (int i = 0; i < 20; i++)
                {
                    arr = new int[30000];
                }
                // 3MB
                arr = null;
            }

            //10 MB alerting 6MB
            // after creating array object
            var mem2 = GC.GetTotalMemory(false);
            {
                GC.Collect();
            }
            // after deleting array object
            var mem3 = GC.GetTotalMemory(false);
            {
                Console.WriteLine("Before creating Array memory was: " + mem1);
                Console.WriteLine("After creating Array memory was: " + mem2);
                Console.WriteLine("after Deleting Array memory was: " + mem3);
            }
        }
    }
}
