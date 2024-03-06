using Guess_the_football_player_quiz;

string rightAnswer = "Rasmus Højlund";
string anotherRightAnswer = "Rasmus Hojlund";

int questionsLeft = 10;
int attemptsLeft = 3;
bool gameOver = false;
Console.WriteLine("You have 10 questions left and 3 attempts to guess the footballer");

void ShowQuestionsList()
{
    Console.WriteLine("\nThe list of questions. Enter its number to choose it");
    Console.WriteLine("1. What league does he play in?");
    Console.WriteLine("2. What club does he play for?");
    Console.WriteLine("3. What position does he play?");
    Console.WriteLine("4. What nationality is this player?");
}

void RepeatActionsWrong()
{
    questionsLeft--;
    Console.WriteLine("\nYou're wrong. Try something else\n");
}

ShowMessageYouAreWrong wrong = RepeatActionsWrong;

void AnswerSomething()
{
    Console.WriteLine("\nEnter your answer:");
    string userFirstInput = Console.ReadLine();
    bool correctCombination =
        userFirstInput == rightAnswer.ToLower() ||
        userFirstInput == anotherRightAnswer.ToLower() ||
        userFirstInput == rightAnswer.ToUpper() ||
        userFirstInput == anotherRightAnswer.ToUpper() ||
        userFirstInput == rightAnswer ||
        userFirstInput == anotherRightAnswer;

    if (correctCombination)
    {
        gameOver = true;
        Console.WriteLine("\nCongratulations, you won!");
        Console.Write("This is really Rasmus Højlund!");
    }
    else
    {
        attemptsLeft--;
        if (attemptsLeft == 0 && !correctCombination)
        {
            gameOver = true;
            Console.Write("\nYou lost. This is Rasmus Højlund");
        }
        else
            Console.WriteLine("\nYou're wrong. Try again\n");
    }

}

while (!gameOver && attemptsLeft > 0)
{
    Console.WriteLine($"Attempts left: {attemptsLeft}");
    Console.WriteLine($"Questions left: {questionsLeft}\n");
    if (questionsLeft > 0)
    {
        Console.WriteLine("Do you want to answer or ask some questions?");
        Console.WriteLine("Enter 1 to answer or 2 to watch list of questions");
    }
    else
    {
        Console.WriteLine("You have no questions left");
        for (int i = 3; i > 0; i--)
        {
            Console.WriteLine($"Attempts left: {attemptsLeft}");
            AnswerSomething();
        }
        break;
    }

    string user = Console.ReadLine();
    if (user == "1")
    {
        AnswerSomething();
    }
    else if (user == "2")
    {
        ShowQuestionsList();
        string userInput = Console.ReadLine();
        switch (userInput)
        {
            case "1":
                {
                    League.ShowInfo();
                    string userGuessLeague = Console.ReadLine();

                    switch (userGuessLeague)
                    {
                        case "1":
                            {
                                questionsLeft--;
                                Console.Write("\nYou're right. ");
                                Console.WriteLine("He really plays in the EPL!\n");
                            }
                        break;
                        case "2": wrong(); break;
                        case "3": wrong(); break;
                        case "4": wrong(); break;
                        case "5": wrong(); break;
                        default: break;
                    }
                }
            break;
            case "2":
                {
                    Club.ShowInfo();
                    string userGuessClub = Console.ReadLine();

                    switch (userGuessClub)
                    {
                        case "1": wrong(); break;
                        case "2": wrong(); break;
                        case "3": wrong(); break;
                        case "4": wrong(); break;
                        case "5":
                            {
                                questionsLeft--;
                                Console.Write("\nYou're right. ");
                                Console.WriteLine("He really plays for ManUtd!\n");
                            }
                        break;
                        case "6": wrong(); break;
                        case "7": wrong(); break;
                        case "8": wrong(); break;
                        case "9": wrong(); break;
                        case "10": wrong(); break;
                        case "11": wrong(); break;
                        case "12": wrong(); break;
                        case "13": wrong(); break;
                        case "14": wrong(); break;
                        case "15": wrong(); break;
                        case "16": wrong(); break;
                        case "17": wrong(); break;
                        case "18": wrong(); break;
                        case "19": wrong(); break;
                        case "20": wrong(); break;
                        case "21": wrong(); break;
                        case "22": wrong(); break;
                        case "23": wrong(); break;
                        case "24": wrong(); break;
                        case "25": wrong(); break;
                        case "26": wrong(); break;
                    }
                }
            break;
            case "3":
                {
                    Position.ShowInfo();
                    string userPosition = Console.ReadLine();

                    switch (userPosition)
                    {
                        case "1": wrong(); break;
                        case "2": wrong(); break;
                        case "3": wrong(); break;
                        case "4":
                            {
                                questionsLeft--;
                                Console.Write("\nYou're right. ");
                                Console.WriteLine("He really plays as a forward!\n");
                            }
                        break;
                        default: break;
                    }
                }
            break;
            case "4":
                {
                    Nationality.ShowInfo();
                    string userNationality = Console.ReadLine();

                    switch (userNationality)
                    {
                        case "1": wrong(); break;
                        case "2": wrong(); break;
                        case "3": wrong(); break;
                        case "4": wrong(); break;
                        case "5": wrong(); break;
                        case "6": wrong(); break;
                        case "7": wrong(); break;
                        case "8": wrong(); break;
                        case "9": wrong(); break;
                        case "10": wrong(); break;
                        case "11": wrong(); break;
                        case "12": wrong(); break;
                        case "13": wrong(); break;
                        case "14": wrong(); break;
                        case "15": wrong(); break;
                        case "16": wrong(); break;
                        case "17": wrong(); break;
                        case "18": wrong(); break;
                        case "19": wrong(); break;
                        case "20": wrong(); break;
                        case "21": wrong(); break;
                        case "22": wrong(); break;
                        case "23": wrong(); break;
                        case "24": wrong(); break;
                        case "25": wrong(); break;
                        case "26": wrong(); break;
                        case "27": wrong(); break;
                        case "28": wrong(); break;
                        case "29": wrong(); break;
                        case "30": wrong(); break;
                        case "31": wrong(); break;
                        case "32":
                            {
                                questionsLeft--;
                                Console.Write("\nYou're right. ");
                                Console.WriteLine("He is really from Denmark!\n");
                            }
                        break;
                        case "33": wrong(); break;
                        case "34": wrong(); break;
                        case "35": wrong(); break;
                        case "36": wrong(); break;
                        case "37": wrong(); break;
                        case "38": wrong(); break;
                        case "39": wrong(); break;
                        case "40": wrong(); break;
                        case "41": wrong(); break;
                        case "42": wrong(); break;
                        case "43": wrong(); break;
                        case "44": wrong(); break;
                        case "45": wrong(); break;
                        case "46": wrong(); break;
                        case "47": wrong(); break;
                        case "48": wrong(); break;
                        case "49": wrong(); break;
                        case "50": wrong(); break;
                        case "51": wrong(); break;
                        case "52": wrong(); break;
                        case "53": wrong(); break;
                        case "54": wrong(); break;
                        default: break;
                    }
                }
            break;
            default: break;
        }
    }
    else
        throw new ArgumentException("Please, enter either 1 or 2");
}
Console.ReadKey();

delegate void ShowMessageYouAreWrong();