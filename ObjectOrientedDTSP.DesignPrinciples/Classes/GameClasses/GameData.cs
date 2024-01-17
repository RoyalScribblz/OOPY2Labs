using ObjectOrientedDTSP.DesignPrinciples.Classes.Extensions;
using ObjectOrientedDTSP.DesignPrinciples.Classes.QuestionClasses;

namespace ObjectOrientedDTSP.DesignPrinciples.Classes.GameClasses;

public class GameData
{
    private const int Length = 10;
    public IEnumerable<Question> Questions { get; }
    public int CorrectAnswers { get; set; }
    
    public GameData()
    {
        List<Question> questions = [];
        Random random = new();
        
        int lastResult = random.Next(1, Length+1);
        for (int i = 0; i < Length; i++)
        {
            questions.Add(random.NextBool()
                ? new PositiveQuestion(i+1, lastResult)
                : new NegativeQuestion(i+1, lastResult));

            lastResult = questions.Last().Result;
        }

        Questions = questions;
    }
}