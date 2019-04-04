using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber2
{
    class RoomSize
    {
        public int Length { get; set; }
        public int Width { get; set; }

        public int Area
        {
            get { return Length * Width; }
        }

        public int Perimeter
        {
            get { return Length * 2 + Width * 2; }
        }
    }
}
