using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBatproject
{
    class GroundNode
    {
        int _Xposition;
        int _Yposition;
        string _GroundNMessage;

        public int XPosition { get => _Xposition; set => _Xposition = value; }
        public int YPosition { get => _Yposition; set => _Yposition = value; }
        public string GroundMessage { get => _GroundNMessage; set => _GroundNMessage = value; }
    }
}
