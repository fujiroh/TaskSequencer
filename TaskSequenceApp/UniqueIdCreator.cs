namespace TaskSequence
{
    public static class UniqueIdCreator
    {
        private static int _count = 0;

        public static int GetCount()
        {
            return _count;
        }
        
        public static int Create()
        {
            return _count++;
        }
    }
}