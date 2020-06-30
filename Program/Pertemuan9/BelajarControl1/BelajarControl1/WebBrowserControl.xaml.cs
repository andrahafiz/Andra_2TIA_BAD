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

namespace BelajarControl1
{
    /// <summary>
    /// Interaction logic for WebBrowserControl.xaml
    /// </summary>
    public partial class WebBrowserControl : Window
    {
        public WebBrowserControl()
        {
            InitializeComponent();
            (wfhSample.Child as System.Windows.Forms.WebBrowser).Navigate("http://www.google.com");
        }

        private void wbWinForms_DocumentTitleChanged(object sender, EventArgs e)
        {
            this.Title = (sender as System.Windows.Forms.WebBrowser).DocumentTitle;
        }
    }
}
