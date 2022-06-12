internal class Program
    {
        public static bool IsDouble(string str)
        {
            int length = str.Length;
            if (length % 2 == 0)
            {
                char[] chars = str.ToCharArray();

                for (int i = 0; i < chars.Length / 2; i++)
                {
                    if (chars[i] != chars[i + length / 2])
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }

        public static int howManyInString(string str, char chr)
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if(str[i] == chr)
                    count++;
            }
            return count;

        }

        public static int howManyInString(string str)
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'a')
                    count++;
            }
            return count;

        }
        static void Main(string[] args)
        {
            
        }
    }
}
