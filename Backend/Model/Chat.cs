namespace Backend.Model
{
    public class Chat
    {
        public string Name { get; set; }
        public string message  { get; set; }
        public string Date { get; set; }

        public Chat(string name, string message, string date)
        {
            Name = name;
            this.message = message;
            Date = date;
        }

    }
}
