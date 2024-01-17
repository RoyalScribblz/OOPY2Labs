namespace ObjectOrientedDTSP.DesignPrinciples.Question;

public class NegativeQuestionBase(int questionNumber, int numberOne) : QuestionBase(questionNumber, numberOne)
{
    protected override string Symbol => "-";
    public override int Result => NumberOne - NumberTwo;
}