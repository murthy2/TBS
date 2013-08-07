using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBS.Model
{
    public class Award
    {
        public int Id { get; set; }
        public int TitleId { get; set; }
        public bool AwardWon { get; set; }
        public int AwardYear { get; set; }
        public string AwardName { get; set; }
        public string AwardCompany { get; set; }
    }
}
