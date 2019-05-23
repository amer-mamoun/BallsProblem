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
            if (toCell + 1 >= BallState._numOfSquares) return false;
            if (Math.Abs(ToCell - FromCell) < 2) return false;
            if (currentState.Square[FromCell] == 0 || currentState.Square[FromCell + 1] == 0) return false;
            if (currentState.Square[ToCell] != 0 || currentState.Square[ToCell + 1] != 0) return false;

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
            int indexToMove = FromCell;
            int toBeMoved1 = newState.Square[indexToMove];
            newState.Square[FromCell] = 0;
            newState.Square[toCell] = toBeMoved1;
            int toBeMoved2 = newState.Square[indexToMove + 1];
            newState.Square[FromCell + 1] = 0;
            newState.Square[toCell + 1] = toBeMoved2;

            return newState;
        }

        public int GetCost(IState State)
        {
            int ballToMove = (Array.IndexOf((State as BallState).Square, FromCell) + 1);

            return (Math.Abs(fromCell - toCell) * ballToMove);
        }
    }
}
