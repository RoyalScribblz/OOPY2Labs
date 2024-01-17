namespace ObjectOrientedDTSP.DesignPrinciples.Classes.QuestionClasses;

public abstract class Question(int questionNumber, int numberOne)
{
    public int QuestionNumber { get; } = questionNumber;
    protected abstract string Symbol { get; }
    public abstract int Result { get; }
    protected int NumberOne { get; } = numberOne;
    protected int NumberTwo { get; } = new Random().Next(1, 11);
    public override string ToString() => $"{NumberOne} {Symbol} {NumberTwo}";
    public bool AnswerCorrect(string answer) => answer.Equals(Result.ToString());
}