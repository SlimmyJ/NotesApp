namespace NotesApp.Models
    {
    internal class Snippit
        {
        public Snippit()
            {
            }

        public Snippit(string name, string summary, string content)
            {
            Name = name;
            Summary = summary;
            Content = content;
            Author = "Empty author";
            }

        public string Id { get; set; }

        public string Name { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public string Summary { get; set; }

        public override string ToString()
            {
            return $"{Name} | {Summary}";
            }
        }
    }