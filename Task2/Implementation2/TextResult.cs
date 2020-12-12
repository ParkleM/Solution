namespace Implementation2
{
    public class TextResult
    {
        public int IntegerCount { get; set; }

        public int RealCount { get; set; }

        public int IntegerSum { get; set; }

        public double RealSum { get; set; }

        public TextResult(int iCount, int rCount, int iSum, double rSum)
        {
            IntegerCount = iCount;
            RealCount = rCount;
            IntegerSum = iSum;
            RealSum = rSum;
        }
    }
}
