using System;

using System.Collections.Generic;





void MooseSays(string message)
{
    Console.WriteLine($@"
                                       _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
    ");
}

void randomQuestion()
{
    string userInput;
    Console.Write("Ask a question for the Moose.");
    userInput = Console.ReadLine();
    if (userInput == "")
    {
        System.Environment.Exit(0);
    }
    Random ShowRandom = new Random();
    int RandomNumber = ShowRandom.Next(1, 19);
    List<string> response = new List<string>();
    response.Add("As I see it, yes.");
    response.Add("Ask again later.");
    response.Add("Better not tell you now.");
    response.Add("Cannot predict now.");
    response.Add("Concentrate and ask again.");
    response.Add("Don’t count on it.");
    response.Add("It is certain");
    response.Add("It is decidedly so.");
    response.Add("Most likely.");
    response.Add("My reply is no.");
    response.Add("My sources say no.");
    response.Add("Outlook not so good.");
    response.Add("Outlook good.");
    response.Add("Reply hazy, try again.");
    response.Add("Signs point to yes.");
    response.Add("Very doubtful.");
    response.Add("Without a doubt.");
    response.Add("Yes");
    response.Add("Yes – definitely.");
    response.Add("You may rely on it.");


    Console.WriteLine(response[RandomNumber]);
}

bool MooseAsks(string question)
{
    Console.Write($"{question} (Y/N): ");
    string answer = Console.ReadLine().ToLower();

    while (answer != "y" && answer != "n")
    {
        Console.Write($"{question} (Y/N): ");
        answer = Console.ReadLine().ToLower();
    }


    if (answer == "y")
    {
        return true;
    }
    else
    {
        return false;
    }
}



void CanadaQuestion()
{
    bool isTrue = MooseAsks("Is Canada real?");
    if (isTrue)
    {
        MooseSays("Really? It seems very unlikely.");
    }
    else
    {
        MooseSays("I  K N E W  I T !!!");
    }
}
void EnthusiasticQuestion()
{
    bool isEnthusiastic = MooseAsks("Are you enthusiastic?");
    if (isEnthusiastic)
    {
        MooseSays("Yay!");
    }
    else
    {
        MooseSays("You should try it!");
    }
}

void LoveCSharpQuestion()
{
    bool doesLoveCSharp = MooseAsks("Do you love C# yet?");
    if (doesLoveCSharp)
    {
        MooseSays("Good job sucking up to your instructor!");
    }
    else
    {
        MooseSays("You will...oh, yes, you will...");
    }
}

void SecretQuestion()
{
    bool wantsSecret = MooseAsks("Do you want to know a secret?");
    if (wantsSecret)
    {
        MooseSays("ME TOO!!!! I love secrets...tell me one!");
    }
    else
    {
        MooseSays("Oh, no...secrets are the best, I love to share them!");
    }
}


void Main()
{
    Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
    Console.WriteLine("--------------------------------------------");
    Console.WriteLine();

    // Let the moose speak!
    MooseSays("H I, I'M  E N T H U S I A S T I C !");
    MooseSays("I really am enthusiastic");

    // As a question
    randomQuestion();
    CanadaQuestion();
    EnthusiasticQuestion();
    LoveCSharpQuestion();
    SecretQuestion();
}


Main();