using System;

namespace task3-3
{
    abstract class Parent: IParent, IPrinter
    {
        protected static Random rnd = new Random();

        protected bool entry = false;

        private abstract void RndFill();

        private abstract void UserFill();

        public abstract void Print();

        public abstract double Average();
    } 
}