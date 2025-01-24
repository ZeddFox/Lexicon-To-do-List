namespace Lexicon_To_do_List.Models
{
    public class Tag(string name) : Model(name)
    {
        public int TaskId { get; set; }
        public Models.Task Task { get; set; }
    }
}
