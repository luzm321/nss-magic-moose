using System;
using System.Collections.Generic; // namespace that enables use of List
// using System.Linq; // namespace needed since Select (map through list) is an extension method

Main();

void Main()
{
    Console.WriteLine(@"
    Welcome to the Magic Moose Simulator that predicts your fortune!

         
     ___            ___
/   \          /   \
\_   \        /  __/
 _\   \      /  /__
 \___  \____/   __/
     \_       _/
       | @ @  \_
       |
     _/     /\
    /o)  (o/\ \_
    \_____/ /
      \____/   
    ");
    Console.WriteLine("--------------------------------------------");
    Console.WriteLine();

    MagicMooseSays(UserQuestion(), MagicMooseResponse());


    string UserQuestion()
    {
        Console.WriteLine("Please ask the Clairvoyant, Magic Moose your question.");
        string userQuestion = Console.ReadLine();
        return userQuestion;
    }

    // List<string> predictions = new List<string>()
    // {
    //     "As I see it, yes.", "Ask again later.", "Better not tell you now.", "Don’t count on it.", "Most likely.", "My sources say no.", "Signs point to yes."
    // };

    // List<string> predictions = new List<string>()
    // {
    //     "As I see it, yes.", "Ask again later.", "Better not tell you now.", "Don’t count on it.", "Most likely.", "My sources say no.", "Signs point to yes."
    // };
    // foreach (string prediction in predictions)
    // {
    //     Console.WriteLine($"{prediction}.");
    // }

    string MagicMooseResponse()
    {
        // List class represents the list of objects which can be accessed by index. It comes under the System.Collection.Generic namespace. 
        // List class can be used to create a collection of different types like integers, strings etc. 
        // A list can be resized dynamically but arrays cannot.
        // List of responses to a question:
        List<string> predictions = new List<string>();

        predictions.Add("As I see it, yes.");
        predictions.Add("Ask again later.");
        predictions.Add("Most likely.");
        predictions.Add("Better not tell you now.");
        predictions.Add("Don’t count on it.");
        predictions.Add("My sources say no.");
        predictions.Add("Signs point to yes.");
        predictions.Add("Very doubtful.");
        predictions.Add("Without a doubt.");
        predictions.Add("Concentrate and ask again.");
        predictions.Add("Cannot predict now.");
        predictions.Add("You may rely on it.");

        // for (int i = 0; i < predictions.Count; i++)
        // {
        //     Random response = new Random();
        //     int generateRandNum = response.Next(0, i);
        //     string mooseResponse = predictions[generateRandNum];
        //     return mooseResponse;
        //     // Console.WriteLine($"The number is {i}");
        // }

        // List<string> answers = predictions.Select(prediction => prediction).ToList();

        // int predictionsCount = answers.Count;
        // Random response = new Random();
        // int generateRandNum = response.Next(0, predictionsCount);
        // string mooseResponse = predictions[generateRandNum];
        // return mooseResponse;

        int predictionsCount = predictions.Count;
        Random response = new Random(); // instantiating new Random response object
        int generateRandNum = response.Next(0, predictionsCount);
        string mooseResponse = predictions[generateRandNum];
        return mooseResponse;
    }
}

// adding an @ in front of the string allows for a multi-line string:
// adding the $ character to the front of the string enables string interpolation:
void MagicMooseSays(string question, string response)
{
    Console.WriteLine($@"
     ___            ___
/   \          /   \
\_   \        /  __/
 _\   \      /  /__
 \___  \____/   __/
     \_       _/
       | @ @  \_     {question}
       |             {response}
     _/     /\
    /o)  (o/\ \_
    \_____/ /
      \____/
    ");
}

