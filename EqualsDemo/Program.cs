using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualsDemo
{
    public class Student
    { 
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override bool Equals(object obj)
        {
            if (obj== null)
            {
                return false;
            }
            if (!(obj is Student))
            {
                return false;
            }

            return this.FirstName == ((Student)obj).FirstName &&
                this.LastName == ((Student)obj).LastName;
        }
    }



    public enum Lights
    {
        green = 1,
        yellow,
        red

    }

    class Program
    {
        static void Main(string[] args)
        {

            #region primitive Data Type


            //int x = 15;
            //int y = 11;

            //Console.WriteLine(x==y);
            //Console.WriteLine(x.Equals(y));

            #endregion


            #region Enums

            //Lights light1 = Lights.yellow;
            //Lights light2 = Lights.green;

            //Console.WriteLine(light1 == light2);
            //Console.WriteLine(light1.Equals(light2));

            #endregion

            #region Same memory OBJECT 

            //Student student1 = new Student() { FirstName= "Toon", LastName = "Tsecond" };
            //Student student2 = student1;

            //Console.WriteLine(student1 == student2);
            //Console.WriteLine(student1.Equals(student2));

            #endregion


            Student student1 = new Student() { FirstName= "Toon", LastName = "Tsecond" };
            Student student2 = new Student() { FirstName = "Toon", LastName = "Tsecond" };

            Console.WriteLine(student1 == student2); // MEMORY ADDRESS 
            Console.WriteLine(student1.Equals(student2)); // INHOUD 


        }
    }
}
