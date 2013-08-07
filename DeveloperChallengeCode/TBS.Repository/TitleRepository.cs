using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBS.Model;

namespace TBS.Repository
{
    public class TitleRepository : ITitleRepository
    {
        private TitleDBContext db = new TitleDBContext();

        public IEnumerable<Title> GetTitles()
        {
            return db.Titles.ToList();
         
        }

        public Title  GetTitle(int id)
        {
            return db.Titles.Find(id);
        }

        public List<Title> SearchIndexSearchIndex(string titleGenre, string searchString)
        {
            var titles = (from t in db.Titles
                          join tg in db.TitleGenres on t.TitleId equals tg.TitleId
                          join g in db.Genres on tg.GenreId equals g.Id
                          select new { t.TitleName, t.TitleNameSortable, t.ReleaseYear, t.ProcessedDateTimeUTC, g.Name });

            var viewModelList = new List<Title>();

            if (!String.IsNullOrEmpty(searchString))
            {
                titles = titles.Where(s => s.TitleName.Contains(searchString));
            }


            if (string.IsNullOrEmpty(titleGenre))
            {

                foreach (var item in titles)
                {
                    Title t = new Title();
                    t.TitleName = item.TitleName;
                    t.TitleNameSortable = item.TitleNameSortable;
                    t.ReleaseYear = item.ReleaseYear;
                    t.ProcessedDateTimeUTC = item.ProcessedDateTimeUTC;
                    viewModelList.Add(t);
                }

            }
            else
            {
                titles = titles.Where(x => x.Name == titleGenre);

                foreach (var item in titles)
                {
                    Title t = new Title();
                    t.TitleName = item.TitleName;
                    t.TitleNameSortable = item.TitleNameSortable;
                    t.ReleaseYear = item.ReleaseYear;
                    t.ProcessedDateTimeUTC = item.ProcessedDateTimeUTC;
                    viewModelList.Add(t);
                }
            }

            return viewModelList;
        }
    }
}
