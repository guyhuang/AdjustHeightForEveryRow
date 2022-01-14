using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace RecForYou.Mvvm
{
    public class StringItem2
    {
        public string Value { get; set; } = string.Empty;
        public int Col { get; set; } = 0;
        public int Row { get; set; } = 0;
        public StringItem2() { }
        public StringItem2(string s, int row, int col) { Value = s; Row = row; Col = col; }
    }

    public class GridViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<StringItem2> gridResult;
        public ObservableCollection<StringItem2> GridResult
        {
            get => gridResult;
            set
            {
                gridResult = value;
                OnPropertyChanged();
            }
        }

        public GridViewModel()
        {
            GridResult = new() { };
            GridResult.Add(new StringItem2("One Row.", 0, 0));
            GridResult.Add(new StringItem2("One Row.", 0, 1));
            GridResult.Add(new StringItem2("One Row.", 0, 2));

            GridResult.Add(new StringItem2("Two Row Sentences.", 1, 0));
            GridResult.Add(new StringItem2("Two Row Sentences.", 1, 1));
            GridResult.Add(new StringItem2("Two Row Sentences.", 1, 2));

            GridResult.Add(new StringItem2("This Will Have Three Row Sentences.", 3, 0));
            GridResult.Add(new StringItem2("This Will Have Three Row Sentences.", 3, 1));
            GridResult.Add(new StringItem2("This Will Have Three Row Sentences.", 3, 2));

            GridResult.Add(new StringItem2("One Row.", 4, 0));
            GridResult.Add(new StringItem2("Two Row Sentences.", 4, 1));
            GridResult.Add(new StringItem2("This Will Have Three Row Sentences.", 4, 2));
            OnPropertyChanged(nameof(GridResult));
        }
        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }

}
