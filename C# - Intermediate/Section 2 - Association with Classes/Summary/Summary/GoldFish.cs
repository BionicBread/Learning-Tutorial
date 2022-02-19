namespace Summary
{
    class GoldFish
    {
        private readonly Animal animal;
        private readonly Swimmable swim;

        public GoldFish(Animal animal, Swimmable swim)
        {
            this.animal = animal;
            this.swim = swim;
        }

        public void Swim()
        {
            swim.Swim();
        }
    }
}
