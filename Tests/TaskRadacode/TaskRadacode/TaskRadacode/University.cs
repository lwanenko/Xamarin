namespace TaskRadacode
{
    class University
    {
        public int id { get; set; }
        public string Title { get; set; }

        public new string ToString()
        {
            return Title;
        }
    }
}
