using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallsProblem
{
    interface IOperator
    {
        /// <summary>
        /// Check if the step that we want to do is valid for the state.
        /// </summary>
        /// <param name="State">The state for which we check the operator</param>
        /// <returns>Bool value, indicating if we met the precondition or not.</returns>
        bool Precondition(IState State);

        /// <summary>
        /// Applying the current operator on the state that we get as a parameter.
        /// </summary>
        /// <param name="State"></param>
        /// <returns>The new state after the application of the operator.</returns>
        IState Apply(IState State);

        /// <summary>
        /// getting the cost
        /// </summary>
        /// <param name="State"></param>
        /// <returns></returns>
        int GetCost(IState State);

    }
}
