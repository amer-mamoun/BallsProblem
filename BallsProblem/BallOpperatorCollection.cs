using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallsProblem
{
    class BallOpperatorCollection : AOperatorCollection
    {
        protected override void init()
        {
            for (int i = 0; i < BallState.NumOfSquares; i++)
            {
                for (int j = 0; j < BallState.NumOfSquares; j++)
                {
                    if (i != j) operatorList.Add(new Move(i, j));
                }
            }
        }
    }
}
