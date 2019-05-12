using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallsProblem
{
    class BallState : IState, ICloneable
    {

        const int NUMOFSQUARES = 16;
        private int[] square;
        public int[] Square
        {
            get { return square; }
            set { square = value; }
        }

        public static int _numOfSquares = 16;
        public static int NumOfSquares
        {
            get { return _numOfSquares; }
        }

        static int _numOfDisks = 6;
        public static int NumOfDisks
        {
            get { return _numOfDisks; }
        }



        public BallState(int numOfSquares, int numOfDisks)
        {
            square = new int[numOfSquares];
            _numOfSquares = numOfSquares;
            _numOfDisks = numOfDisks;
        }
        public BallState()
        {
            square = new int[NUMOFSQUARES] { 1, 2, 1, 2, 1, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        }

        public bool isGoal()
        {
            for (int i = 0; i < square.Length; i++)
            {
                if (square[i] != 1 && square[i + 1] != 1 && square[i + 2] != 1 && square[i + 3] != 2 && square[i + 4] != 2 && square[i + 5] != 2)
                { return false; }

            }
            return true;
        }

        public bool isValid()
        {
            for (int i = 0; i < square.Length; i++)
            {
                if ((square[i] == 1 && (square[i + 1] == 2 || square[i - 1] == 2)) || (square[i] == 2 && (square[i + 1] == 1 || square[i - 1] == 1)))
                {
                    return true;
                }
            }
            return false;
        }

        public int Heuristics
        {
            get
            {
                int heur = 0;
                for (int i = 0; i < this.square.Length; i++)
                {
                    heur += (i + 1) * (_numOfSquares - (this.square[i] + 1));
                }
                return heur;
            }
        }

        public object Clone()
        {
            BallState cloneObject = new BallState();
            for (int i = 0; i < cloneObject.square.Length; i++)
            {
                cloneObject.square[i] = this.square[i];
            }
            return cloneObject;
        }
        public override bool Equals(object obj)
        {
            BallState state = (obj as BallState);
            for (int i = 0; i < this.square.Length; i++)
            {
                if (this.square[i] != state.square[i]) return false;
            }
            return true;
        }
    }
}
