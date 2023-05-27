namespace Q19
{
    public class CoupleNames
    {
        private string name1;
        private string name2;

        public CoupleNames(string name1 = "", string name2 = "")
        {
            this.name1 = name1;
            this.name2 = name2;
        }

        public string Name1
        {
            get { return name1; }
            set { name1 = value; }
        }
        public string Name2
        {
            get { return name2; }
            set { name2 = value; }
        }

        public int KidsInIndex(int index, CoupleNames[,] Class)
        {
            int r = index / 10;
            int c = index % 10;

            if (r >= 0 && r < Class.GetLength(0) && c >= 0 && c < Class.GetLength(1))
            {
                if (Class[r, c].Name1 != "" && Class[r, c].Name2 != "")
                {
                    return 2;
                }
                else if (Class[r, c].Name1 != "" || Class[r, c].Name2 != "")
                {
                    return 1;
                }
            }
            return 0;
        }
        public override string ToString()
        {
            return $"Name 1: {name1}, Name 2: {name2}";
        }
    }
}