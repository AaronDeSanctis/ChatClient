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

namespace UltimateChatClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    { 
        string toSend;
        String UserName;
        List<string> names;
        Client client;
        //TextBox tb;
        //KeyEventArgs KeyCode;
        //KeyEventArgs Keys;
        public MainWindow()
        {
            
            InitializeComponent();
            toSend = "";
            Start();
            
            
            UserName = "Guest";
            names = new List<string>();
            
        }

        private void SendText_TextChanged(object sender, TextChangedEventArgs e)
        {
               
        }

        private void ChatText_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void SendButton_Click(object sender, RoutedEventArgs e)
        {
            ChatText.Text += UserName + ": " + SendText.Text + "\n";
            toSend = SendText.Text;
            client.message = toSend;
            SendText.Text = "";
            
        }
        private void UserNameSelection_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
        

        private void ChangeNameButton_Click(object sender, RoutedEventArgs e)
        {
            names.Remove(UserName);
            UserName = UserNameSelection.Text;
            names.Add(UserName);
            NamesList.Text = "";
            foreach(string name in names)
            {
                
                NamesList.Text += name + "\n";
            }
            //NamesList.Text = names;
            
            UserNameSelection.Text = "";
        }

        private void NamesList_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
        private void Start()
        {
            client = new Client();
            client.Connect("10.2.20.40");
            //Parallel.Invoke(client.SendMessage(message,stream), client.ReceiveMessage(stream));
            
            //tb = new TextBox();
            //tb.KeyDown += new KeyEventHandler(tb_KeyDown);
        }

        
        //static void tb_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter)
        //    {
        //        //enter key is down
        //    }
        //}
        //create a dictionary thats of type string string that is a member variable. that will store the key aka ip adress and value being the name.key value pairs
    }
}
