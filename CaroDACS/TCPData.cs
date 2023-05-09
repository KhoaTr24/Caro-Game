using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaroDACS
{
    [Serializable]
   public class TCPData
    {
        private int command;
        private Point point;
        private string Message;

        public int Command { get => command; set => command = value; }
        public Point Point { get => point; set => point = value; }
        public string Message1 { get => Message; set => Message = value; }

        public TCPData(int command, string message, Point point)
        {
            this.Command = command;
            this.Point = point;
            this.Message = message;
            
        }
    }  

    public enum TCPDataCommand
    {
        SEND_POINT,
        THONGBAO,
        NEW_GAME,
        UNDO,
        END_GAMEP1,
        END_GAMEP2,
        EXIT
    }
}
