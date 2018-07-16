namespace Test
{
    class T3
    {
        public static implicit operator int(T3 v)
        {
            return int.Parse(v.ToString());
        }
    }
}