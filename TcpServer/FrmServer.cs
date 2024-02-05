using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;


namespace TcpServer
{
    public partial class FrmServer : Form
    {
        public FrmServer()
        {
            InitializeComponent();
            textBox1.Text = "";
            IPAddress ipAd = IPAddress.Parse("127.0.0.1");
            TcpListener serverSocket = new TcpListener(ipAd, 8888);
            TcpClient clientSocket = default(TcpClient);
            serverSocket.Start();
            textBox1.Text = "-----Server Started--------";
            clientSocket = serverSocket.AcceptTcpClient();
        }

        private void FrmServer_Load(object sender, EventArgs e)
        {

        }

        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;
            Data Source=C:\Users\DELL\Desktop\Necama's test\ETHERNETServer\ETHERNETServer\Database.accdb");
    }
}
