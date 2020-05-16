using System;
using System.Linq;

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
        string[] bot_words = "Hello. How are you?".Split(' ');
        string[] prev_words = { };
        for (; ; )
        {
            string s = Console.ReadLine();
            if (s == null)
                Console.WriteLine("Why you wrote nothing??");
            else
            {
                Console.WriteLine("[{0}]", string.Join(", ", bot_words));
                
                //Console.WriteLine(prev_words);
                //Console.WriteLine(next[r.Next(next.Length)]);


                if (s.Contains("?") && bot_words.Any(s1 => s.Contains(s1)))
                {
                    string[] next = questions;
                    string ph = next[r.Next(next.Length)];
                    Console.WriteLine(ph);
                    bot_words = ph.Split(' ');
                }
                else
                {
                    if (!s.Contains("?") && bot_words.Any(s1 => s.Contains(s1)))
                    {
                        string[] next = answers;
                        string ph = next[r.Next(next.Length)];
                        Console.WriteLine(ph);
                        bot_words = ph.Split(' ');
                    }
                    else
                    {
                        string[] next = s.Contains("?") ? answers : questions;
                        string ph = next[r.Next(next.Length)];
                        Console.WriteLine(ph);
                        bot_words = ph.Split(' ');
                    }
                }
            }
            prev_words = s.Split(' ');
        }
    }
}