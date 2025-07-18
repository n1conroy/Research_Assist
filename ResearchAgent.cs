using System;

namespace LibScholarAssist
{
    public class ResearchAgent
    {
        public void RunInteractiveSession()
        {
            Console.WriteLine("Enter your research question:");
            string question = Console.ReadLine();
            Console.WriteLine($"Analyzing question: {question}");
            Console.WriteLine("Fetching relevant literature and evaluating methods...");
            // Simulate evaluation
            ResearchAnalyzer analyzer = new ResearchAnalyzer();
            analyzer.Analyze();
        }
    }
}