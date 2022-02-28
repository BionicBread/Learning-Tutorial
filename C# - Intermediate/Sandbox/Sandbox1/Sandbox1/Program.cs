namespace Sandbox1
{

    class Program
    {
        static void Main(string[] args)
        {
            BaseRole chris = new BaseRole(21, "M", 175, 80);
            System.Console.WriteLine(chris.Gender);
            BaseRole nicola = new BaseRole();
            nicola.Gender = "f";
            System.Console.WriteLine(nicola.Gender);
            Warrior Alan = new Warrior();
            Alan.Gender = "m";
            Alan.Attack();
            BaseRole Giulia = new BaseRole();
            Giulia.summonMount();
            Alan.summonMount();
        }
    }
}
