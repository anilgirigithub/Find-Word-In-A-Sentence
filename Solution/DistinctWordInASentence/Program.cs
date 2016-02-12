using System;
using ApplicationBusinessLayer;

namespace DistinctWordInASentence
{
    class Program
    {
        static void Main(string[] args)
        {
            string Sentence = string.Empty;
            Console.Write("Please enter sentence: ");
            Sentence = Console.ReadLine();
            BusinessLogic objBusinessLogic = new BusinessLogic();
            Console.WriteLine(objBusinessLogic.GetDistinctWordInASentence(Sentence));
            Console.ReadLine();
        }
    }
}
