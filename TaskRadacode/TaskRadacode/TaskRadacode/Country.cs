namespace TaskRadacode
{
    public class Country
    {
        public int id { get; set; }
        public string Title { get; set; }

        public new string ToString()
        {
            return Title;
        }
    }
}
