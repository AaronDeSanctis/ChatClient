using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
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

namespace UltimateChatListener
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            Listener test = new Listener();
            test.Connect();
               
                
            
        }

        private void ChatText_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void SendText_TextChanged(object sender, TextChangedEventArgs e)
        {
            ChatText.Text = SendText.Text;
        }

        private void FriendsList_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void UserName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
