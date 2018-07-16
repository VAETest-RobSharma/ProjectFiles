namespace Test
{
    public class T2
    {
        public static implicit operator string(T2 v)
        {
            return v.ToString();
        }
    }
}