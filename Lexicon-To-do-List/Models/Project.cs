namespace Lexicon_To_do_List.Models
{
    public class Project(string name) : Model(name)
    {
        public List<Models.Task> Tasks { get; set; }
        public List<Tag> Tags { get; set; }

        public bool ProjectActive { get; set; }
    }
}
