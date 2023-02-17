using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prison
{
    public enum Floor
    {
        Первый,
        Второй,
        Третий,
    }

    public class Cell
    {
        public Cell(Floor floor, int cell)
        {
            this.Floor = floor;
            this.Room = cell;
        }

        private Floor Floor { get; set; }

        private int Room { get; set; }
    }
}
