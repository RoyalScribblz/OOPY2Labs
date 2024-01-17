using ObjectOrientedDTSP.DesignPrinciples.Extensions;
using ObjectOrientedDTSP.DesignPrinciples.Question;

namespace ObjectOrientedDTSP.DesignPrinciples.Game;

public class GameData
{
    private const int Length = 10;
    public IEnumerable<QuestionBase> Questions { get; }
    public int CorrectAnswers { get; set; }
    
    public GameData()
    {
        List<QuestionBase> questions = [];
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