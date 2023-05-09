﻿using SimpleTCP;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CaroDACS
{
    class TCPManager
    {
        #region Server
        Socket Server;
        public void CreateServer()
        {
            IPEndPoint ipe = new IPEndPoint(IPAddress.Parse(IP), PORT);
            Server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            Server.Bind(ipe);
            Server.Listen(5); // Đợi kết nối của Client

            Thread acceptClient = new Thread(() =>
            {
                Client = Server.Accept();
            });
            acceptClient.IsBackground = true;
            acceptClient.Start();
        }
        #endregion

        #region Client
        Socket Client;
        public bool ConnectServer()
        {
            IPEndPoint ipe = new IPEndPoint(IPAddress.Parse(IP), PORT);
            Client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                Client.Connect(ipe);
                return true;
            }
            catch
            {
                return false;
            }
        }

        #endregion

        public void StopServer()
        {
            Server.Shutdown(SocketShutdown.Both);
            Server.Close();
        }
        #region Both
        public string IP = "127.0.0.1";
        public int PORT = 9900;
        public const int buffer = 1024;
        public bool server = true;

        public bool Send(object data)
        {
            byte[] sendData = SerializeData(data);
                return SendData(Client, sendData);      
        }

        public object Receive()
        {
            byte[] receiveData = new byte[buffer];
            bool OK = ReceiveData(Client, receiveData);
            return DeserializeData(receiveData);
        }

        private bool SendData(Socket target, byte[] data)
        {
            return target.Send(data) == 1 ? true : false;
        }

        private bool ReceiveData(Socket target, byte[] data)
        {
            return target.Receive(data) == 1 ? true : false;
        }

        //Nén đối tượng thành mảng Byte[]
        public byte[] SerializeData(Object o)
        {
            MemoryStream ms = new MemoryStream();
            BinaryFormatter bf1 = new BinaryFormatter();
            bf1.Serialize(ms, o);
            return ms.ToArray();
        }
        //Giải nén mảng byte[] thành đối tượng object
        public object DeserializeData(byte[] theByteArray)
        {
            MemoryStream ms = new MemoryStream(theByteArray);
            BinaryFormatter bf1 = new BinaryFormatter();
            ms.Position = 0;
            return bf1.Deserialize(ms);
        }
        #endregion
        
    }
}
