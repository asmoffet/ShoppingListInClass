using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Shopping_List
{
    /// <summary>
    /// Interaction logic for shoppingListDisplay.xaml
    /// </summary>
    public partial class shoppingListDisplay : UserControl
    {
        public shoppingListDisplay()
        {
            InitializeComponent();
        }
        public void DeleteItemButtonClick(object sender, RoutedEventArgs e)
        {
            if(DataContext is ShoppingListData data)
            {
                if (sender is Button button)
                    data.Remove(button.DataContext.ToString());
            }
        }
    }
}
