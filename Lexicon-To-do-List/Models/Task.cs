namespace Lexicon_To_do_List.Models
{
    public class Task(string name) : Model(name)
    {
        public List<Tag> Tags { get; set; }

        public DateTime Deadline { get; set; }
    }
}
