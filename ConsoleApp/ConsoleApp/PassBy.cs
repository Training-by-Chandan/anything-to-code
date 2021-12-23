namespace ConsoleApp
{
    public class PassBy
    {
        public static void Increase(int x, int y)
        {
            x++;
            y++;
        }

        public static void Increase(ref int x, ref int y)
        {
            x++;
            y++;
        }

        public static void Increase(int x, in int y, out int res)
        {
            x++;
            //y++;
            res = x + y;
        }
    }
}
