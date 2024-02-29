namespace OOP.Models
{
    internal class Cat : Animal
    {

        public override void Move()
        {
            Console.WriteLine("Cat is going");
        }
        public int Move(int paws) { return 0; }
    }
}
