using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Shopping_List
{
    public class ShoppingListData: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        List<string> items = new List<string>();
        public IEnumerable<string> Items => items.ToArray();

        public void Add(string Item)
        {
            items.Add(Item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
        }
        public void Remove(string Item)
        {
            items.Remove(Item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
        }
    }
}
