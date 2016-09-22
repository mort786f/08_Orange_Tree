using System;

namespace _08_Orange_Tree
{
    internal class OrangeTree
    {
        private int v1;
        private int v2;

        public OrangeTree(int v1, int v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }
        private int age = 0;
        private int height = 6;
        private int numOranges = 0;
        private int orangesEaten = 0;
        public int Age { get { return age; }  internal set { age = value; } }
        public int Height { get { return height; } internal set { height = value; } }
        public int NumOranges { get { return numOranges; } internal set { numOranges = value; } }
        public bool TreeAlive { get; internal set; }
        public int OrangesEaten { get { return orangesEaten; } internal set { orangesEaten = value; } }

        internal void OneYearPasses()
        {
            age++;
            Height = height + 2;
            TreeAlive = false;
            if (age > 1)
            {
                numOranges = numOranges + 5;
            }
        }

        internal void EatOrange(int v)
        {
            orangesEaten = orangesEaten + v;
        }
    }
}