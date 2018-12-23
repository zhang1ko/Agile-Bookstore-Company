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
using System.Windows.Shapes;
using System.Data;
using BookStoreLIB;

namespace BookStoreGUI
{
    /// <summary>
    /// Interaction logic for Recommendations.xaml
    /// </summary>
    public partial class Recommendations : Window
    {

        int UserId;

        public Recommendations(int Uid)
        {
            InitializeComponent();
            UserId = Uid;
            BookCatalog bookCat = new BookCatalog();
            DataSet dsBookCat = bookCat.GetBookInfo();
            this.DataContext = dsBookCat.Tables["Category"];

            //RecomendationDataGrid.Items.Refresh();
        }
        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
    }
}
