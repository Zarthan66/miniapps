using miniapps.Models;

namespace miniapps.Services
{
    public interface ISorterServices
    {
        string SortRow(SorterModel sorter);
        string SortColumn(SorterModel sorter);
        void AddNewlineAfter(SorterModel sorter, string target, int orderOf = 0);
    }
}
