using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace TestBatproject
{
    class Environment
    {
        BatNode batNode = new BatNode();
        List<GroundNode> groundNodes = new List<GroundNode>(30);
        SinkNode sinkNode = new SinkNode();
        public List<Tuple<int,int>> GetBatNodePostion()
        {

            List<Tuple<int, int>> BatPosition = new List<Tuple<int, int>>();
            batNode.XPosition = int.Parse(ConfigurationSettings.AppSettings["BatXpostion"]);
            batNode.YPosition = int.Parse(ConfigurationSettings.AppSettings["BatYpostion"]); ;
            BatPosition.Add(Tuple.Create(batNode.XPosition, batNode.YPosition));
            return BatPosition;
            

            


        }
        public List<Tuple<int, int>> GetGroundNodePostion()
        {
            List<Tuple<int, int>> GroundNodesPosition = new List<Tuple<int, int>>();

            groundNodes.Add(new GroundNode() { XPosition = 30, YPosition = 180});
            groundNodes.Add(new GroundNode() { XPosition = 60, YPosition = 180 });
            groundNodes.Add(new GroundNode() { XPosition = 90, YPosition = 180 });
            groundNodes.Add(new GroundNode() { XPosition = 120, YPosition = 180 });
            groundNodes.Add(new GroundNode() { XPosition = 150, YPosition = 180 });

            groundNodes.Add(new GroundNode() { XPosition = 30, YPosition = 150 });
            groundNodes.Add(new GroundNode() { XPosition = 60, YPosition = 150 });
            groundNodes.Add(new GroundNode() { XPosition = 90, YPosition = 150 });
            groundNodes.Add(new GroundNode() { XPosition = 120, YPosition = 150 });
            groundNodes.Add(new GroundNode() { XPosition = 150, YPosition = 150 });

            groundNodes.Add(new GroundNode() { XPosition = 30, YPosition = 120 });
            groundNodes.Add(new GroundNode() { XPosition = 60, YPosition = 120 });
            groundNodes.Add(new GroundNode() { XPosition = 90, YPosition = 120 });
            groundNodes.Add(new GroundNode() { XPosition = 120, YPosition = 120 });
            groundNodes.Add(new GroundNode() { XPosition = 150, YPosition = 120 });

            groundNodes.Add(new GroundNode() { XPosition = 30, YPosition = 90 });
            groundNodes.Add(new GroundNode() { XPosition = 60, YPosition = 90 });
            groundNodes.Add(new GroundNode() { XPosition = 90, YPosition = 90 });
            groundNodes.Add(new GroundNode() { XPosition = 120, YPosition = 90 });
            groundNodes.Add(new GroundNode() { XPosition = 150, YPosition = 90 });

            groundNodes.Add(new GroundNode() { XPosition = 30, YPosition = 60 });
            groundNodes.Add(new GroundNode() { XPosition = 60, YPosition = 60 });
            groundNodes.Add(new GroundNode() { XPosition = 90, YPosition = 60 });
            groundNodes.Add(new GroundNode() { XPosition = 120, YPosition = 60 });
            groundNodes.Add(new GroundNode() { XPosition = 150, YPosition = 60 });
            foreach (var item in groundNodes)
            {
                GroundNodesPosition.Add(Tuple.Create(item.XPosition, item.YPosition));
            }
            return GroundNodesPosition;
        }

        public List<Tuple<int, int>> GetSinkNodePostion()
        {
            List<Tuple<int, int>> SinkPosition = new List<Tuple<int, int>>();
            sinkNode.XPosition = 180;
            sinkNode.YPosition = 30;
            SinkPosition.Add(Tuple.Create(sinkNode.XPosition, sinkNode.YPosition));
            return SinkPosition;

        }


    }
}
