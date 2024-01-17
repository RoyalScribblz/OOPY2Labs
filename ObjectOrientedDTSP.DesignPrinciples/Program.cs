using ObjectOrientedDTSP.DesignPrinciples.Game;
using ObjectOrientedDTSP.DesignPrinciples.Question;

GameData gameData = new();
foreach (QuestionBase question in gameData.Questions)
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