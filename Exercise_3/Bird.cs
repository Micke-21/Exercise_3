using System;

namespace Exercise_3
{
    public class Bird : Animal
    {
        //ToDo 3.2.13 Lägg attribut som alla fåglar ska ha, här! 
        public double WingSpan { get; }

        public Bird(string name, int weight, int age, double wingSpan) : base(name, weight, age)
        {
            WingSpan = wingSpan;
        }


        public override void DoSound()
        {
            Console.WriteLine("Pip pib piip pip");
        }

        //3.3.2
        public override string Stats()
        {
            return $"{base.Stats()} Wingspan: {WingSpan}";
        }
    }
}
