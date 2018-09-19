using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace PowerHouse.Models
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [NotMapped]
        public List<string> Objectives { get; set; }
    }
}