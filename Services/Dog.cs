namespace Services
{
    public class Dog : Animal
    {
        public Dog(string name, int age) : base(name, age)
        {
        }
        public override string GetBark()
        {
            return "旺";
        }
    }
}
