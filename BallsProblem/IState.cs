﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallsProblem
{
    interface IState
    {
        /// <summary>
        /// Checking if the current state is a goal state or not.
        /// </summary>
        /// <returns>Bool value that indicates if it is a goal state or not.</returns>
        bool isGoal();

        /// <summary>
        /// Checking if the current state is valid
        /// </summary>
        /// <returns>Bool value that indicate that the state is valid or not.</returns>
        bool isValid();

        /// <summary>
        /// Getting Heuristics values
        /// </summary>
        int Heuristics
        {
            get;
        }
    }
}
