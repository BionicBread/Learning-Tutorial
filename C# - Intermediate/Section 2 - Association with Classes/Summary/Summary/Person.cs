namespace Summary
{
    class Person
    {
        private readonly Animal animal;
        private readonly Walkable walk;

        public Person(Animal animal, Walkable walk)
        {
            this.animal = animal;
            this.walk = walk;
        }

        public void Eat()
        {
            animal.Eat();
        }

        public void Sleep()
        {
            animal.Sleep();
        }

        public void Walk()
        {
            walk.Walk();
        }
    }
}
