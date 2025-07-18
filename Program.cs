using System;

namespace LibScholarAssist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to LibScholarAssist – your academic research assistant for Library and Information Science!");
            ResearchAgent agent = new ResearchAgent();
            agent.RunInteractiveSession();
        }
    }
}