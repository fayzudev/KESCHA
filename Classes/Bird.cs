namespace KESCHA.Classes
{
    public class Bird : Animal
    {
        public Bird(string name, int UserAge, int AnimalAge)
            :base(name,UserAge,AnimalAge)
        {
            
        }
        public override void greeting2(string UserName)
        {
            Console.WriteLine($"Hello {UserName}");
        }

        public override void greeting3(string UserName)
        {
            Console.WriteLine("Abstracted method implemented");
        }
    }
}