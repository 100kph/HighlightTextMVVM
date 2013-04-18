namespace HighlightTextMVVM.ViewModel
{
    using System.ComponentModel;
    using System.Windows.Documents;
    using HighlightTextMVVM.Model;

    public class ViewModel : INotifyPropertyChanged
    {
        private SearchResults searchResults = new SearchResults();
        public string SearchResult
        {
            get
            {
                return searchResults.SearchResult;
            }
            set
            {
                searchResults.SearchResult = value;
                RaisePropertyChanged("SearchResult");
            }
        }

        private string searchText;
        public string SearchText
        {
            get
            {
                return searchText;
            }
            set
            {
                searchText = value;
                RaisePropertyChanged("SearchText");
            }
        }

        private Run[] runs = new Run[] { 
            new Run("Hello World"),
            new Run("Brave new World")
        };

        public Run[] SearchResultRuns
        {
            get { return runs; }
        }


        private void RaisePropertyChanged(string name)
        {
            var func = PropertyChanged;

            if (func != null)
            {
                func(this, new PropertyChangedEventArgs(name));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}