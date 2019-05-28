using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallsProblem
{
    class AAlgorithem<S, Op> : ATreeSearch<S, Op>
         where S : IState, new()
         where Op : AOperatorCollection, new()
    {
        private List<GraphNode> openNodes = new List<GraphNode>();
        private List<GraphNode> closedNodes = new List<GraphNode>();

        protected override void AddClosedNode(GraphNode newNode)
        {
            closedNodes.Add(newNode);
        }

        protected override void AddOpenNode(GraphNode newNode)
        {
            openNodes.Add(newNode);
            //openNodes.OrderBy(node => node.Cost).ToList();
            openNodes.Sort((node1, node2) => (node1.Cost.CompareTo(node2.Cost)));

        }

        protected override GraphNode getNextOpenNode()
        {
            GraphNode next = openNodes[0];
            openNodes.RemoveAt(0);
            return next;
        }

        protected override bool isOpen()
        {
            return openNodes.Count > 0;
        }

        public override int numOfVisitedNodes()
        {
            return closedNodes.Count;
        }
        protected override bool loopDetected(GraphNode currentNode)
        {
            //foreach (GraphNode item in closedNodes)
            //{
            //    if (item.Equals(currentNode))
            //        return false;
            //}
            //foreach (GraphNode item in openNodes)
            //{
            //    if (item.Equals(currentNode))
            //        return false;
            //}
            return false;
             //return (closedNodes.Contains(currentNode) || openNodes.Contains(currentNode));
        }
    }
}
