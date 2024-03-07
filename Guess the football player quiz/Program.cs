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

    int user = int.Parse(Console.ReadLine());
    if (user == 1)
    {
        AnswerSomething();
    }
    else if (user == 2)
    {
        ShowQuestionsList();
        int userInput = int.Parse(Console.ReadLine());
        switch (userInput)
        {
            case 1:
                {
                    League.ShowInfo();
                    int userGuessLeague = int.Parse(Console.ReadLine());

                    if (userGuessLeague == 1)
                    {
                        questionsLeft--;
                        Console.Write("\nYou're right. ");
                        Console.WriteLine("He really plays in the EPL!\n");
                    }
                    else if (userGuessLeague > 0 && userGuessLeague <= 5)
                        wrong();
                    else
                        throw new ArgumentException("Please, enter the number from 1 to 5");
                }
            break;
            case 2:
                {
                    Club.ShowInfo();
                    int userGuessClub = int.Parse(Console.ReadLine());

                    if (userGuessClub == 5)
                    {
                        questionsLeft--;
                        Console.Write("\nYou're right. ");
                        Console.WriteLine("He really plays for ManUtd!\n");
                    }
                    else if (userGuessClub > 0 && userGuessClub <= 26)
                        wrong();
                    else
                        throw new ArgumentException("Please, enter the number from 1 to 26");
                }
            break;
            case 3:
                {
                    Position.ShowInfo();
                    int userPosition = int.Parse(Console.ReadLine());

                    if (userPosition == 4)
                    {
                        questionsLeft--;
                        Console.Write("\nYou're right. ");
                        Console.WriteLine("He really plays as a forward!\n");
                    }
                    else if (userPosition > 0 && userPosition < 4)
                        wrong();
                    else
                        throw new ArgumentException ("Please, enter the number from 1 to 4");
                }
            break;
            case 4:
                {
                    Nationality.ShowInfo();
                    int userNationality = int.Parse(Console.ReadLine());

                    if (userNationality == 32)
                    {
                        questionsLeft--;
                        Console.Write("\nYou're right. ");
                        Console.WriteLine("He is really from Denmark!\n");
                    }
                    else if (userNationality > 0 && userNationality <= 54)
                        wrong();
                    else
                        throw new ArgumentException("Please, enter the number from 1 to 54");
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