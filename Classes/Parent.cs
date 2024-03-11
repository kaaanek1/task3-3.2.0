using System;

namespace task3_3
{
    abstract class Parent: IParent, IPrinter
    {
        protected static Random rnd = new Random();

        protected bool entry = false;

        protected abstract void RndFill();

        protected abstract void UserFill();

        public abstract void Print();

        public abstract double Average();
    } 
}