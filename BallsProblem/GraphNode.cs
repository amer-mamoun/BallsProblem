using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallsProblem
{
    class GraphNode
    {
        private IState currentstate;

        private GraphNode parentnode;

        private IOperator currentOperator;

        private int cost = 0;

        private int totalCost = 0;

        public GraphNode(IState currentstate, GraphNode parentnode, IOperator currentOperator)
        {
            this.currentstate = currentstate;
            this.parentnode = parentnode;
            this.currentOperator = currentOperator;
            cost = currentOperator == null ? 0 : currentOperator.GetCost(parentnode.currentstate) + parentnode.cost;
            totalCost = cost + currentstate.Heuristics;
        }

        public IOperator Operators
        {
            get { return currentOperator; }
        }
        public IState Currentstate
        {
            get { return currentstate; }

        }
        public GraphNode Parentnode
        {
            get { return parentnode; }

        }
        public int Cost
        {
            get { return cost; }
        }
        public int TotlaCost
        {
            get { return totalCost; }
        }

        public override bool Equals(object obj)
        {
            GraphNode node1 = (obj as GraphNode);
            if (this.Cost != node1.Cost) return false;
            if (this.TotlaCost != node1.TotlaCost) return false;
            if (!this.Currentstate.Equals(node1.Currentstate)) return false;
            return true;
        }
    }
}
