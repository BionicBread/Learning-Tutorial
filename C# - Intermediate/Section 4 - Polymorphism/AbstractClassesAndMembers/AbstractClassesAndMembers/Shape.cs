﻿namespace AbstractClassesAndMembers
{
    public abstract class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public abstract void Draw();
        
        public void Copy()
        {
            System.Console.WriteLine("Copy the shape");
        }

        public void Select()
        {
            System.Console.WriteLine("Select the shape");
        }

        
    }
}
