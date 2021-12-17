namespace Exercise_3
{
    public abstract class Animal
    {
        //ToDo 3.2.14 F lägg attribut som alla djur behöver här i Animal
        public string Name { get; set; }
        public int Weight { get; set; }
        public int Age { get; set; }

        public abstract void DoSound();


        public Animal(string name, int weight, int age)
        {
            Name = name;
            Weight = weight;
            Age = age;
        }

        //3.3.1
        public virtual string Stats()
        {
            return $"Name: {Name} weight: {Weight} age: {Age}";
        }
    }
}
