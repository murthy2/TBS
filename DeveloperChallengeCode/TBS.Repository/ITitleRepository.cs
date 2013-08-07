using System.Collections.Generic;
using TBS.Model;

namespace TBS.Repository
{
    public interface ITitleRepository
    {
        IEnumerable<Title> GetTitles();
        
        Title GetTitle(int id);

        List<Title> SearchIndexSearchIndex(string titleGenre, string searchString);
    }
}
