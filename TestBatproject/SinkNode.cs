using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBatproject
{
    public class SinkNode
    {
        int _Xposition=0;
        int _Yposition=0;
        string _SinkNMessage = "sink";

        public int XPosition { get => _Xposition; set => _Xposition = value; }
        public int YPosition { get => _Yposition; set => _Yposition = value; }
        public string SinkMessage { get => _SinkNMessage; set => _SinkNMessage = value; }
    }
}

