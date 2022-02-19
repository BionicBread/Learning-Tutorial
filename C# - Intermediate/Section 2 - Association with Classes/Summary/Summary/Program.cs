namespace Summary
{
    class Program
    {
        static void Main(string[] args)
        {
            // Class coupling 
            // Tight coupling is a lot of dependancies between classes aka a change in a base (parent) class or a super (child) class will affect other sub (child) classes
            // Loose coupling is preferred 
            // Inheritance hierarchies can lead to tight coupling, large hierarchies, fragility.
            // Class Dog : Animal    <<< dog is a child (sub) of Animal (base)
            // Composition is the better alternative
            // Class is initialised in the constructor of another class

            // Composition option 1
            Person Chris = new Person(new Animal(), new Walkable());

            Chris.Eat();
            Chris.Walk();

            // Compsition option 2
            Animal animal = new Animal();
            Walkable walk = new Walkable();
            Person Nicola = new Person(animal, walk);
            Nicola.Eat();
            Nicola.Walk();

            // Goldfish with separate compsitions

            GoldFish goldFish = new GoldFish(animal, new Swimmable());
            goldFish.Swim();
            
        }
    }
}
