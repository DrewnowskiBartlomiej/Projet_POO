using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOwithFrame
{
    public class Network
    {
        public List<Node> listNodes;
        public Network()
        {
            this.listNodes = new List<Node>();

        }
        public void AddListNodes(Node newNode)
        {
            listNodes.Add(newNode);
        }

    }
}
