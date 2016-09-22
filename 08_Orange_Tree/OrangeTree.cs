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

        public int Age { get; internal set; }
        public int Height { get; internal set; }

        internal void OneYearPasses()
        {
            Age = 1;
            Height = 8;
        }
    }
}