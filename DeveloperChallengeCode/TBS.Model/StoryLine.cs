using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBS.Model
{
    public class StoryLine
    {
        public int Id { get; set; }
        public int TitleId { get; set; }
        public string Type { get; set; }
        public string Language { get; set; }
        public string Description { get; set; }
    }

}
