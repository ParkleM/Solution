using System;
using System.IO;

namespace Implementation2
{
    public class StringUtils
    {
        public string Path { get; set; }

        public StringUtils(string path)
        {
            try
            {
                FileInfo fileInfo = new FileInfo(path);
            }
            catch
            {
                throw new Exception();
            }
            Path = path;
        }

        public string ReadFile()
        {
            using (StreamReader streamReader = new StreamReader(Path))
                return streamReader.ReadToEnd();
        }

        public TextResult GetTextResult(string text)
        {
            int integerCount = 0;
            int integerSum = 0;
            int realCount = 0;
            double realSum = 0;

            foreach (string value in text.Split('\r', '\n'))
            {
                if (value == "") continue;

                if (int.TryParse(value.Trim(), out int number))
                {
                    integerCount++;
                    integerSum += number;
                }
                else
                {
                    realCount++;
                    realSum += Convert.ToDouble(value);
                }
            }
            return new TextResult(integerCount, realCount, integerSum, realSum);
        }
    }
}
