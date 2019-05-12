using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallsProblem
{
    abstract class ATreeSearch<S, Op>
        where S : IState, new()
        where Op : AOperatorCollection, new()
    {
        protected abstract void AddOpenNode(GraphNode newNode);
        protected abstract void AddClosedNode(GraphNode newNode);
        protected abstract GraphNode getNextOpenNode();
        protected abstract bool isOpen();
        public abstract int numOfVisitedNodes();
        protected abstract bool loopDetected(GraphNode currentNode);

        public List<IState> Search()
        {
            List<IState> solution = new List<IState>();
            GraphNode newNode = new GraphNode(new S(), null, null);
            AddOpenNode(newNode);
            GraphNode currentOpenNode;
            do
            {
                currentOpenNode = getNextOpenNode();
                if (currentOpenNode.Currentstate.isGoal())
                {
                    break;
                }
                Op opCollection = new Op();
                foreach (IOperator currentOperator in opCollection)
                {
                    if (currentOperator.Precondition(currentOpenNode.Currentstate))
                    {
                        IState newState = currentOperator.Apply(currentOpenNode.Currentstate);
                        GraphNode newOpenNode = new GraphNode(newState, currentOpenNode, currentOperator);
                        if (!loopDetected(newOpenNode)) this.AddOpenNode(newOpenNode);
                    }
                }
                this.AddClosedNode(currentOpenNode);

            } while (isOpen());
            if (!currentOpenNode.Currentstate.isGoal())
            {
                return null;
            }
            while (currentOpenNode.Parentnode != null)
            {
                solution.Add(currentOpenNode.Currentstate);
                currentOpenNode = currentOpenNode.Parentnode;
            }
            solution.Add(new S());
            solution.Reverse();
            return solution;
        }
    }
}
