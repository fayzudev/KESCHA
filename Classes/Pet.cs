namespace KESCHA.Classes
{
    public class Pet : Animal
    {
        public Pet(string name, int UserAge, int AnimalAge)
            :base(name, UserAge, AnimalAge)
            {

            }

        public override void greeting2()
        {
            System.Console.WriteLine();
        }
    }
}