namespace Implementation1
{
    public class ArrayUtils
    {
        public static int GetStringCount(int[,] array)
        {
            if (array.GetLength(1) <= 2)
                return array.GetLength(0);

            int count = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                int difference = array[i, 1] - array[i, 0];
                bool isProgression = false;
                for (int j = 2; j < array.GetLength(1); j++)
                {
                    isProgression = array[i, j] - array[i, j - 1] == difference;
                    if (!isProgression)
                        break;
                }
                count += isProgression ? 1 : 0;
            }
            return count;
        }
    }
}
