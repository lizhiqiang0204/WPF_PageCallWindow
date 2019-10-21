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
using WpfApp1.Pages;

namespace WpfApp1
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public void CallFromChild(string name)
        {
            MessageBox.Show("Hello," + name + "!");
        }

        private void InitTab1(object sender, EventArgs e)
        {
            Page1 a = new Page1();
            this.frmPage1.Content = a;
            a.ParentWindow = this;
        }

        private void InitTab2(object sender, EventArgs e)
        {
            Page2 a = new Page2();
            this.frmPage2.Content = a;
            a.ParentWindow = this;
        }

        private void InitTab3(object sender, EventArgs e)
        {
            Page3 a = new Page3();
            this.frmPage3.Content = a;
            a.ParentWindow = this;
        }
    }
}
