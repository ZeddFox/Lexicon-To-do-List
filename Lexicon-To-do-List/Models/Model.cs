using System.ComponentModel.DataAnnotations;

namespace Lexicon_To_do_List.Models
{
    public class Model
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public Model(string name)
        {
            Name = name;
        }
    }
}
