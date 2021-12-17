namespace Exercise_3
{
    public class Swan : Bird
    {
        public double NeckLength { get; }

        public Swan(string name, int weight, int age, double wingSpan, double neckLength) : base(name, weight, age, wingSpan)
        {
            NeckLength = neckLength;
        }

        //3.3.2.PR
        public override string Stats()
        {
            return $"{base.Stats()} NeckLength: {NeckLength}";
        }

    }
}
