using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaroDACS
{
    public class Player
    {
        private string name; // to hop phim ctrl + R + E
        private Image mark;

        public Player(string name, Image mark)
        {
            this.Name = name;
            this.Mark = mark;
        }

        public Image Mark { get => mark; set => mark = value; }
        public string Name { get => name; set => name = value; }
    }
}
