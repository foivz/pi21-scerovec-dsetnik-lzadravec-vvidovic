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

namespace bitBooks_Project.Forme
{
    public partial class LiveChatForm : Form
    {
        Socket sck;
        EndPoint epLocal, epRemote;
        byte[] buffer;


        public LiveChatForm()
        {
            InitializeComponent();
        }

        private void LiveChatForm_Load(object sender, EventArgs e)
        {
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            txtIPJa.Text = GetLocalIP();

            txtIPPrijatelj.Text = GetLocalIP();

           
        }

        private void btnSpoji_Click(object sender, EventArgs e)
        {
            epLocal = new IPEndPoint(IPAddress.Parse(txtIPJa.Text), Convert.ToInt32(txtPortJa.Text));
            sck.Bind(epLocal);

            epRemote = new IPEndPoint(IPAddress.Parse(txtIPPrijatelj.Text), Convert.ToInt32(txtPortPrijatelj.Text));
            sck.Connect(epRemote);

            buffer = new byte[1500];
            sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
        }

        private void MessageCallBack(IAsyncResult aResult)
        {
            try
            {
                byte[] receivedData = new byte[1500];
                receivedData = (byte[])aResult.AsyncState;

                ASCIIEncoding aEncoding = new ASCIIEncoding();
                string receivedMessage = aEncoding.GetString(receivedData);

                listPoruka.Items.Add("Friend: " + receivedMessage);

                buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnPošalji_Click(object sender, EventArgs e)
        {
            ASCIIEncoding aEncoding = new ASCIIEncoding();
            byte[] sendingMessage = new byte[1500];
            sendingMessage = aEncoding.GetBytes(txtPoruka.Text);

            sck.Send(sendingMessage);

            listPoruka.Items.Add("Me: " + txtPoruka.Text);
            txtPoruka.Text = "";
        }

        private string GetLocalIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                    return ip.ToString();

            }


            return "127.0.0.1";
        }

    }
}
