using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace TcpSocketDemo
{
    public class ClientController
    {
        public static List<Client> Clients = new List<Client>();

        public static void AddClient(Socket socket)
        {
            Clients.Add(new Client(socket, Clients.Count));
        }

        public static void RemoveClient(int id)
        {
            Clients.RemoveAt(Clients.FindIndex(x => x.Id == id));
        }
    }

    public class TcpSocketServer
    {
        public string IpAddress { get; set; } = "127.0.0.1";
        public string Port { get; set; }
        private IPEndPoint _IpEndPoint { get; set; }
        private Socket _ISocket { get; set; }

        public event Action<string> EventThrowException;

        public TcpSocketServer(string _ipaddress, string _port)
        {
            this.IpAddress = _ipaddress;
            this.Port = _port;
        }

        #region ~TcpSocketServer
        ~TcpSocketServer()
        {
            if (this._ISocket != null)
            {
                if (this._ISocket.Connected)
                    this._ISocket.Disconnect(true);
                this._ISocket.Close();
                this._ISocket = null;
            }
        }
        #endregion

        #region StartListen
        public void StartListen()
        {
            try
            {
                this._IpEndPoint = new IPEndPoint(IPAddress.Parse(this.IpAddress), int.Parse(Port));
                this._ISocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                this._ISocket.Bind(this._IpEndPoint);
                this._ISocket.Listen(10);
                this._ISocket.BeginAccept(AcceptCallback, this._ISocket);
            }
            catch (Exception ex)
            {
                this.EventThrowException?.Invoke(string.Format("StartListen Error. Exception:{0}", ex.Message));
                if (this._ISocket != null)
                {
                    this._ISocket.Close();
                    this._ISocket = null;
                }
            }
        }
        #endregion

        #region AcceptCallback
        private void AcceptCallback(IAsyncResult iar)
        {
            try
            {
                Console.WriteLine($"Accept CallBack port:{Port} protocol type: {ProtocolType.Tcp}");
                Socket acceptedSocket = this._ISocket.EndAccept(iar);
                ClientController.AddClient(acceptedSocket);               
            }
            catch (Exception ex)
            {
                this.EventThrowException?.Invoke(string.Format("StartListen - AcceptCallback Error. Exception:{0}", ex.Message));
                //throw new Exception("Base Accept error" + ex);
            }
            finally
            {
                this._ISocket.BeginAccept(AcceptCallback, this._ISocket);
            }
        }
        #endregion

        #region MyRegion

        #endregion

        #region MyRegion
        public class ReceivePacket
        {
            private byte[] _buffer;
            private Socket _receiveSocket;

            public ReceivePacket(Socket receiveSocket)
            {
                _receiveSocket = receiveSocket;
            }
            public void StartReceiving()
            {
                try
                {
                    _buffer = new byte[4];
                    _receiveSocket.BeginReceive(_buffer, 0, _buffer.Length, SocketFlags.None, ReceiveCallback, null);
                }
                catch { }
            }
            private void ReceiveCallback(IAsyncResult AR)
            {
                try
                {
                    // if bytes are less than 1 takes place when a client disconnect from the server.
                    // So we run the Disconnect function on the current client
                    if (_receiveSocket.EndReceive(AR) > 1)
                    {
                        // Convert the first 4 bytes (int 32) that we received and convert it to an Int32 (this is the size for the coming data).
                        _buffer = new byte[BitConverter.ToInt32(_buffer, 0)];
                        // Next receive this data into the buffer with size that we did receive before
                        _receiveSocket.Receive(_buffer, _buffer.Length, SocketFlags.None);
                        // When we received everything its onto you to convert it into the data that you've send.
                        // For example string, int etc... in this example I only use the implementation for sending and receiving a string.

                        // Convert the bytes to string and output it in a message box
                        string data = Encoding.Default.GetString(_buffer);
                        //MessageBox.Show(data);
                        // Now we have to start all over again with waiting for a data to come from the socket.
                        StartReceiving();
                    }
                    else
                    {
                        Disconnect();
                    }
                }
                catch
                {
                    // if exeption is throw check if socket is connected because than you can startreive again else Dissconect
                    if (!_receiveSocket.Connected)
                    {
                        Disconnect();
                    }
                    else
                    {
                        StartReceiving();
                    }
                }
            }

            private void Disconnect()
            {
                // Close connection
                _receiveSocket.Disconnect(true);
                // Next line only apply for the server side receive
                //ClientController.RemoveClient(_clientId);
                // Next line only apply on the Client Side receive
                // Here you want to run the method TryToConnect()
            }
        }
        #endregion        

        class Client
        {
            public Socket _socket { get; set; }
            public ReceivePacket Receive { get; set; }
            public int Id { get; set; }

            public Client(Socket socket, int id)
            {
                Receive = new ReceivePacket(socket);
                Receive.StartReceiving();
                _socket = socket;
                Id = id;
            }
        }
        static class ClientController
        {
            public static List<Client> Clients = new List<Client>();

            public static void AddClient(Socket socket)
            {
                Clients.Add(new Client(socket, Clients.Count));
            }

            public static void RemoveClient(int id)
            {
                Clients.RemoveAt(Clients.FindIndex(x => x.Id == id));
            }
        }
    }
}
