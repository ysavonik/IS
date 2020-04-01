using System;

public class Program
{
    public static void Main()
    {
        string[] answers =
        {
            "I have to think",
            "Well...it's hard to say",
            "Why are you asking this question?",
            "Who knows...",
            "I'm not sure",
            "Let's change topic. I don't want to answer this question"
        };
        string[] questions =
        {
            "it's interesting, isn't it",
            "I see your point of view",
            "do you really think so?",
            "are you sure?",
            "I disagree with you",
            "I know a lot of people like you"
        };

        Random r = new Random();
        Console.WriteLine("Hello. How are you?");
        for (; ; )
        {
            string s = Console.ReadLine();
            if (s == null)
                Console.WriteLine("Why you wrote nothing??");
            else
            {
                string[] next = s.Contains("?") ? answers : questions;
                Console.WriteLine(next[r.Next(next.Length)]);
            }

        }
    }
}