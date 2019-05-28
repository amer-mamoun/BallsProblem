using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallsProblem
{
    class DepthFirstSearch<S, Op> : ATreeSearch<S, Op>
        where S : IState, new()
        where Op : AOperatorCollection, new()
    {
        private Stack<GraphNode> openNodes = new Stack<GraphNode>();
        private List<GraphNode> closedNodes = new List<GraphNode>();

        protected override void AddOpenNode(GraphNode newNode)
        {
            openNodes.Push(newNode);
        }

        protected override void AddClosedNode(GraphNode newNode)
        {
            closedNodes.Add(newNode);
        }

        protected override GraphNode getNextOpenNode()
        {
            return openNodes.Pop();
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

            // return (closedNodes.Contains(currentNode) || openNodes.Contains(currentNode));
        }
    }
}

