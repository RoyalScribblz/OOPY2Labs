using ObjectOrientedDTSP.DesignPrinciples.Classes.GameClasses;
using ObjectOrientedDTSP.DesignPrinciples.Classes.QuestionClasses;

GameData gameData = new();
foreach (Question question in gameData.Questions)
{
    Console.WriteLine($"Question {question.QuestionNumber}: {question} = ");

    string answer = Console.ReadLine() ?? string.Empty;

    if (question.AnswerCorrect(answer))
    {
        Console.WriteLine("Correct");
        gameData.CorrectAnswers++;
        continue;
    }
    
    Console.WriteLine($"Incorrect! The answer was {question.Result}.");
}

Console.WriteLine($"You finished with a score of {gameData.CorrectAnswers}/10.");