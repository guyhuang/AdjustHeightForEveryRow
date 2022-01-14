using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace RecForYou.Mvvm
{
    public class StringItem
    {
        public string Value { get; set; } = string.Empty;
        public string HiddenValue { get; set; } = string.Empty;
        public int Col { get; set; } = 1;
        public StringItem() { }
        public StringItem(string s, int col, string hiddenValue) { Value = s; Col = col; HiddenValue = hiddenValue; }
    }
    public class OneRowResult : INotifyPropertyChanged
    {
        private ObservableCollection<StringItem> items;
        public ObservableCollection<StringItem> Items
        {
            get => items;
            set
            {
                items = value;
                OnPropertyChanged();
            }
        }

        public OneRowResult()
        {
            Items = new();
        }

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
    public class GridInGridViewModel: INotifyPropertyChanged
    {
        private ObservableCollection<OneRowResult> gridResult;
        public ObservableCollection<OneRowResult> GridResult
        {
            get => gridResult;
            set
            {
                gridResult = value;
                OnPropertyChanged();
            }
        }

        public GridInGridViewModel()
        {
            GridResult = new() { new() };

            var row = new OneRowResult() { };
            row.Items.Add(new StringItem("One Row.", 0, "One Row."));
            row.Items.Add(new StringItem("OneRow.", 1, "One Row."));
            row.Items.Add(new StringItem("OneRow.", 2, "One Row."));
            GridResult.Add(row);

            row = new OneRowResult() { };
            row.Items.Add(new StringItem("Two Row Sentences.", 0, "Two Row Sentences."));
            row.Items.Add(new StringItem("Two Row Sentences.", 1, "Two Row Sentences."));
            row.Items.Add(new StringItem("Two Row Sentences.", 2, "Two Row Sentences."));
            GridResult.Add(row);

            row = new OneRowResult() { };
            row.Items.Add(new StringItem("This Will Have Three Row Sentences.", 0, "This Will Have Three Row Sentences."));
            row.Items.Add(new StringItem("This Will Have Three Row Sentences.", 1, "This Will Have Three Row Sentences."));
            row.Items.Add(new StringItem("This Will Have Three Row Sentences.", 2, "This Will Have Three Row Sentences."));
            GridResult.Add(row);

            row = new OneRowResult() { };
            row.Items.Add(new StringItem("One Row.", 0, "This Will Have Three Row Sentences."));
            row.Items.Add(new StringItem("Two Row Sentences.", 1, "This Will Have Three Row Sentences."));
            row.Items.Add(new StringItem("This Will Have Three Row Sentences.", 2, "This Will Have Three Row Sentences."));
            GridResult.Add(row);
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
