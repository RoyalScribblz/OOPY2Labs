namespace ObjectOrientedDTSP.DesignPrinciples.Classes.QuestionClasses;

public class PositiveQuestion(int questionNumber, int numberOne) : Question(questionNumber, numberOne)
{
    protected override string Symbol => "+";
    public override int Result => NumberOne + NumberTwo;
}