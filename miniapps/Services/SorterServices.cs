using miniapps.Models;

namespace miniapps.Services
{
    public class SorterServices : ISorterServices
    {
        public void AddNewlineAfter(SorterModel sorter, string target, int orderOf = 0)
        {
            sorter.textOutput = "basjhdkashdkasnd";
        }

        public string SortColumn(SorterModel sorter)
        {
            return "sortColumn";
        }

        public string SortRow(SorterModel sorter)
        {
            return "sortRow";
        }
    }
}
