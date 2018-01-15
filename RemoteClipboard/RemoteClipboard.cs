using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;

using System.ComponentModel;

namespace RemoteClipboard_example
{
    public class MessageEventArgs : EventArgs
    {
        public Message Message { get; set; }
    }

    class RemoteClipboard
    {
        //public delegate void AddMessageEventHandler(object sourse, MessageEventArgs args);

        public event EventHandler<MessageEventArgs> AddedMessage;

        protected virtual void OnAddedMessage(Message message)
        {
            if (AddedMessage != null)
            {
                AddedMessage(this, new MessageEventArgs() { Message = message});
            }
        }

        private string yourUsername; 
        //private List<string> users = new List<string>();
        private const int port = 54545;
        private const string broadcastAddr = "255.255.255.255";
        private UdpClient recevingClient;
        private UdpClient sendingClient;

        Thread recevingThread;

        public RemoteClipboard(string username)
        {
            InitializeSender();
            InitializeReceiver();
            yourUsername = username;
        }

        #region Initializer
        private void InitializeSender()
        {
            sendingClient = new UdpClient(broadcastAddr, port);
            sendingClient.EnableBroadcast = true;
        }

        private void InitializeReceiver()
        {
            recevingClient = new UdpClient(port);

            ThreadStart start = new ThreadStart(Receiver);
            recevingThread = new Thread(start);
            recevingThread.IsBackground = true;
            recevingThread.Start();
        }
        #endregion

        #region methods
        private void Receiver()
        {
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, port);

            while (true)
            {
                byte[] data = recevingClient.Receive(ref endPoint);
                string message = Encoding.ASCII.GetString(data);
                string[] tempmsg = message.Split(':');
                //if (tempmsg[0] != yourUsername) //For testing porpuse, comment the if state
                //{
                    OnAddedMessage(new Message() { username = tempmsg[0], message = tempmsg[1] });
                //}
            }
        }

        public void Sender(string message)
        {
            if (!string.IsNullOrEmpty(message))
            {
                string toSend = yourUsername+":"+message;
                byte[] data = Encoding.ASCII.GetBytes(toSend);
                sendingClient.Send(data, data.Length);
            }
        }
        #endregion


    }
}
