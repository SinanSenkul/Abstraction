using System;
namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            IObjective person = new Developer("sinan", "şenkul", "web development", "developer");
            person.Objective();
        }
    }
}