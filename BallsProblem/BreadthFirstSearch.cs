using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallsProblem
{
    class BreadthFirstSearch<S, Op> : ATreeSearch<S, Op>
        where S : IState, new()
        where Op : AOperatorCollection, new()
    {
        private Queue<GraphNode> openNodes = new Queue<GraphNode>();
        private List<GraphNode> closedNodes = new List<GraphNode>();

        protected override void AddOpenNode(GraphNode newNode)
        {
            openNodes.Enqueue(newNode);
        }

        protected override void AddClosedNode(GraphNode newNode)
        {
            closedNodes.Add(newNode);
        }

        protected override GraphNode getNextOpenNode()
        {
            return openNodes.Dequeue();
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
            foreach (GraphNode item in closedNodes)
            {
                if (item.Equals(currentNode))
                    return true;
            }
            foreach (GraphNode item in openNodes)
            {
                if (item.Equals(currentNode))
                    return true;
            }
            return false;

            //return false;// (closedNodes.Contains(currentNode) && openNodes.Contains(currentNode));
        }
    }
}
