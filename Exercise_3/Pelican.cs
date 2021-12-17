namespace Exercise_3
{
    public class Pelican : Bird
    {
        public double BeakSize { get; }

        public Pelican(string name, int weight, int age, double wingSpan, double beakSize) : base(name, weight, age, wingSpan)
        {
            BeakSize = beakSize;
        }

        //3.3.2.PR
        public override string Stats()
        {
            return $"{base.Stats()} BeakSize: {BeakSize}";
        }

    }
}
