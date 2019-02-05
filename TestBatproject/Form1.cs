using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestBatproject
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        

        private void Showbutton_Click(object sender, EventArgs e)
        {

            Environment environment = new Environment();

            Refresh();
            List<Tuple<int, int>> batnode = new List<Tuple<int, int>>();
            if (batnode.Count > 0)
            {
                batnode.Clear();
            }
            //List<Tuple<int, int>> batnode = environment.GetBatNodePostion();
            string inputbatX = BatPosXTextBox.Text.ToString();
            string inputbatY = BatPosYTextBox.Text.ToString();
            int batX = int.Parse(inputbatX);
            int batY = int.Parse(inputbatY);
            
            batnode.Add(Tuple.Create(batX, batY));
            List<Tuple<int, int>> groundnode = environment.GetGroundNodePostion();
            List<Tuple<int, int>> sinknode = environment.GetSinkNodePostion();
            List<Tuple<int, int>> RecievedSignalNode = new List<Tuple<int, int>>();
            int NodewithRecievedSignal;

            if (ListViewRecievedNodes.Items?.Count != 0)
            {
                ListViewRecievedNodes.Clear();
                
            }
            foreach (var item in batnode)
            {
                
                chart1.Series["BatNode"].Points.AddXY(item.Item1, item.Item2);
            }
            foreach (var item in groundnode)
            {
                chart1.Series["GroundNode"].Points.AddXY(item.Item1, item.Item2);
            }
            foreach (var item in sinknode)
            {
                chart1.Series["SinkNode"].Points.AddXY(item.Item1, item.Item2);
            }
             NodewithRecievedSignal = GetNumberofNodesREcievedSignal(batnode, groundnode, sinknode);
            ListViewRecievedNodes.Items.Add(NodewithRecievedSignal.ToString());
            
        }

        private int GetNumberofNodesREcievedSignal(List<Tuple<int, int>> batnode, List<Tuple<int, int>> groundnode,
                                           List<Tuple<int, int>> sinknode)
        {
            int rangeX = 25;
            int rangeY = 25;
            int count = 0;
            if (ClusterHeadListView.Items?.Count != 0)
            {
                ClusterHeadListView.Clear();

            }
            List<Tuple<int, int>> RecievedNodes = new List<Tuple<int, int>>();
            for (int i = 0; i < groundnode.Count-1; i++)
            {
                if(Math.Abs(batnode[0].Item1-groundnode[i].Item1)<=rangeX && Math.Abs(batnode[0].Item2 - groundnode[i].Item2) <= rangeY)
                {
                    count++;
                    RecievedNodes.Add(Tuple.Create(groundnode[i].Item1, groundnode[i].Item2));
                }
            }
            foreach (var item in RecievedNodes)
            {
                chart1.Series["RecievedNode"].Points.AddXY(item.Item1, item.Item2);
            }
            int clusterHead = GetClusterHead(RecievedNodes, sinknode);
            ClusterHeadListView.Items.Add(clusterHead.ToString());
            return count;
        }
        private int GetClusterHead(List<Tuple<int, int>> recievedSignalNode,
                                           List<Tuple<int, int>> sinknode)
        {
            if (NormalCHlistView.Items?.Count != 0)
            {
                NormalCHlistView.Clear();

            }
            
            double DistanceGroundToSink;
            double DistanceCMtoCH;
            int numberOfClusterHead = 0;

            int dataaggregationtime;

            Tuple<int, int, double> ClusterHead;

            List<Tuple<int, int, double>> NodeswithDistancefromSink = new List<Tuple<int, int, double>>();

            List<Tuple<int, int, double>> clusterHeads = new List<Tuple<int, int, double>>();
            List<Tuple<int, int>> CH = new List<Tuple<int, int>>();
            List<Tuple<int, int, double>> clusterHead1 = new List<Tuple<int, int, double>>();
            List<Tuple<int, int, double>> clusterHead2 = new List<Tuple<int, int, double>>();
            List<Tuple<int, int, double>> clusterHead3 = new List<Tuple<int, int, double>>();

            List<Tuple<int, int>> clusterMember1 = new List<Tuple<int, int>>();
            List<Tuple<int, int>> clusterMember2 = new List<Tuple<int, int>>();

            //distance from ground node to Sink

            for (int i = 0; i < recievedSignalNode.Count; i++)
            {
                DistanceGroundToSink = GetDistance(recievedSignalNode[i], sinknode[0]);
                NodeswithDistancefromSink.Add(Tuple.Create(recievedSignalNode[i].Item1, recievedSignalNode[i].Item2, DistanceGroundToSink));
            }

            //Cluster Head

            ClusterHead = NodeswithDistancefromSink.OrderBy(x => x.Item3).Last();
            
            for (int i = 0; i < NodeswithDistancefromSink.Count; i++)
            {
                if (ClusterHead.Item2 == recievedSignalNode[i].Item2)
                {
                    numberOfClusterHead++;
                    clusterHeads.Add(NodeswithDistancefromSink[i]);
                }
            }
            foreach (var item in clusterHeads)
            {
                chart1.Series["ClusterHead"].Points.AddXY(item.Item1, item.Item2);
            }

            //Cluster Member choosing Cluster head

            if (clusterHeads.Count == 1)
            {
                for (int i = 0; i < recievedSignalNode.Count; i++)
                {
                    if (clusterHeads[0].Item1 != recievedSignalNode[i].Item1 || clusterHeads[0].Item2 != recievedSignalNode[i].Item2)
                    {
                        clusterMember1.Add(recievedSignalNode[i]);
                    }
                }
            }
            if (clusterHeads.Count == 2)
            {
                CH.Add(Tuple.Create(clusterHeads[0].Item1, clusterHeads[0].Item2));
                CH.Add(Tuple.Create(clusterHeads[1].Item1, clusterHeads[1].Item2));
                for (int i = 0; i < recievedSignalNode.Count; i++)
                {
                    if(clusterHeads[0].Item1 != recievedSignalNode[i].Item1 || clusterHeads[0].Item2 != recievedSignalNode[i].Item2)
                    {
                        DistanceCMtoCH = GetDistance(CH[0], recievedSignalNode[i]);
                        clusterHead1.Add(Tuple.Create(recievedSignalNode[i].Item1, recievedSignalNode[i].Item2, DistanceCMtoCH));
                    }
                }
                for (int i = 0; i < recievedSignalNode.Count; i++)
                {
                    if (clusterHeads[1].Item1 != recievedSignalNode[i].Item1 || clusterHeads[1].Item2 != recievedSignalNode[i].Item2)
                    {
                        DistanceCMtoCH = GetDistance(CH[1], recievedSignalNode[i]);
                        clusterHead2.Add(Tuple.Create(recievedSignalNode[i].Item1, recievedSignalNode[i].Item2, DistanceCMtoCH));
                    }
                }
                for (int i = 0; i < clusterHead1.Count; i++)
                {
                    for (int j = 0; j < clusterHead2.Count; j++)
                    {
                        if(clusterHead1[i].Item1 == clusterHead2[j].Item1 && clusterHead1[i].Item2 == clusterHead2[j].Item2)
                        {
                            if (clusterHead1[i].Item3 >clusterHead2[j].Item3)
                            {
                                clusterMember1.Add(Tuple.Create(clusterHead1[i].Item1, clusterHead1[i].Item2));
                            }
                            else
                            {
                                clusterMember2.Add(Tuple.Create(clusterHead2[i].Item1, clusterHead2[i].Item2));
                            }
                        }
                    }
                }
            }

            int oneCHDataaggregationtime = recievedSignalNode.Count -1;
            NormalCHlistView.Items.Add(oneCHDataaggregationtime.ToString());

            if (clusterMember1?.Count != 0)
            {
                if (CDTlistView.Items?.Count != 0)
                {
                    CDTlistView.Clear();

                }
                dataaggregationtime = clusterMember1.Count;
                foreach (var item in clusterMember1)
                {
                    chart1.Series["ClMofCH1"].Points.AddXY(item.Item1, item.Item2);
                }
                CDTlistView.Items.Add(dataaggregationtime.ToString());
            }
            if (clusterMember2?.Count != 0)
            {
                foreach (var item in clusterMember2)
                {
                    chart1.Series["CMofCH2"].Points.AddXY(item.Item1, item.Item2);
                } 
            }

            return numberOfClusterHead;
        }

        private double GetDistance(Tuple<int, int> Node1, Tuple<int, int> Node2)
        {
            double distance = 0;
            double dist = Math.Abs((Node2.Item1 - Node1.Item1) ^ 2) + ((Node2.Item2 - Node1.Item2) ^ 2);
            return distance = Math.Abs(Math.Sqrt(dist));
        }

        private void Refresh()
        {
            

            chart1.Series["BatNode"].Points.Clear();
            chart1.Series["GroundNode"].Points.Clear();
            chart1.Series["SinkNode"].Points.Clear();
            chart1.Series["RecievedNode"].Points.Clear();
            chart1.Series["ClusterHead"].Points.Clear();
            chart1.Series["ClMofCH1"].Points.Clear();
            chart1.Series["CMofCH2"].Points.Clear();
        }
    }
}
