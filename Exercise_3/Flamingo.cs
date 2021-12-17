namespace Exercise_3
{
    public class Flamingo : Bird
    {
        public double LegLenght { get; }

        public Flamingo(string name, int weight, int age, double wingSpan, double legLenght) : base(name, weight, age, wingSpan)
        {
            LegLenght = legLenght;
        }

        //3.3.2.PR
        public override string Stats()
        {
            return $"{base.Stats()} LegLenght: {LegLenght}";
        }

    }
}
