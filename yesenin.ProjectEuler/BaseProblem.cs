namespace yesenin.ProjectEuler
{
    public abstract class BaseProblem : IProblem
    {
        public abstract string GetAnswer();

        public abstract void AssertTest();
    }
}