using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1___The_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = " John ";
            string passPhrase = "****";
            string schoolCheer = "programmers are the best!";
            string songLyrics = "You say goodbye, and I say hello";
            Console.WriteLine("Hello, " + name);
            Console.WriteLine($"Hello, {name}" );
            Console.WriteLine($"{ passPhrase.Length}");
            Console.WriteLine(name.Trim());
            schoolCheer = schoolCheer.ToUpper();
            Console.WriteLine(schoolCheer);
            Console.WriteLine(songLyrics.StartsWith("goodbye"));
            Console.WriteLine(songLyrics.EndsWith("hello"));
            Console.Write("Just Write doesn't make a new line afterwards");
            Console.WriteLine("See?");
            string top = " OOO   L";
            string middle = "O   O  L";
            string bottom = " OOO   LLLLL";
            Console.WriteLine(top);
            Console.WriteLine(middle);
            Console.WriteLine(middle);
            Console.WriteLine(middle);
            Console.WriteLine(bottom);
            string Firstname = "Owen";
            string favMovie = "The Matrix";
            Console.WriteLine("hello, " + Firstname.ToLower() + " why do you like " + favMovie.ToLower() + "?");
            favMovie = favMovie.ToUpper();
            Console.WriteLine(favMovie);
            Console.WriteLine(favMovie.Contains("THE"));
            favMovie = favMovie
        }
    }
}