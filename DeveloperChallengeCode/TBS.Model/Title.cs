using System;

namespace TBS.Model
{
    public class Title
    {
        public int TitleId { get; set; }
        public string TitleName { get; set; }
        public string TitleNameSortable { get; set; }
        public int? TitleTypeId { get; set; }
        public int ReleaseYear { get; set; }
        public DateTime ProcessedDateTimeUTC { get; set; }

    }
}
