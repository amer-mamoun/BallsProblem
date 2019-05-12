using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallsProblem
{
    class Move : IOperator
    {
        private int fromCell;
        public int FromCell
        {
            get { return fromCell; }
        }

        private int toCell;
        public int ToCell
        {
            get { return toCell; }
        }

        public Move(int fromCell, int toCell)
        {
            this.fromCell = fromCell;
            this.toCell = toCell;
        }

        public bool Precondition(IState State)
        {
            if (toCell == fromCell)
            {
                return false;
            }
            if (!(State is BallState))
            {
                return false;
            }
            if (!State.isValid())
            {
                return false;
            }

            BallState currentState = new BallState();
            int i = -1;
            for (; i < currentState.Square.Length; i++)
            {
                if (i >= 0 && currentState.Square[i] == fromCell)
                {
                    break;
                }
            }
            if (i == -1 || i >= currentState.Square.Length)
            {
                return false;
            }
            return true;
        }

        public IState Apply(IState State)
        {
            if (!(State is BallState))
            {
                return null;
            }
            BallState ballState = (State as BallState);
            if (!(ballState.isValid()))
            {
                return null;
            }
            BallState newState = (ballState.Clone() as BallState);
            int ballToMove = Array.IndexOf(newState.Square, FromCell);
            newState.Square[ballToMove] = ToCell;
            return newState;
        }

        public int GetCost(IState State)
        {
            int ballToMove = (Array.IndexOf((State as BallState).Square, FromCell) + 1);

            return (Math.Abs(fromCell - toCell) * ballToMove);
        }
    }
}
