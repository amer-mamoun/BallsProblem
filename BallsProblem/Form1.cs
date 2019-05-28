using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallsProblem
{
    public partial class Form1 : Form
    {
        Graphics graphics;
        List<IState> solution = new List<IState>();
        int solutionIndex = 0;
        public Form1()
        {
            InitializeComponent();
            graphics = board.CreateGraphics();
        }

        private void Drawstate(IState CurrentState)
        {
            board.Refresh();
            nextStepLbl.Text = (solutionIndex + 1).ToString();



        }

        private void PrevStepBtn_Click(object sender, EventArgs e)
        {
            if (solutionIndex > 0)
            {
                solutionIndex -= 1;
                Drawstate(solution[solutionIndex]);
            }
        }

        private void NextStepBtn_Click(object sender, EventArgs e)
        {
            if (solutionIndex < solution.Count - 1)
            {
                solutionIndex += 1;
                Drawstate(solution[solutionIndex]);
            }
        }

        private void BFSBtn_Click(object sender, EventArgs e)
        {
            BreadthFirstSearch<BallState, BallOpperatorCollection> bfSearch = new BreadthFirstSearch<BallState, BallOpperatorCollection>();
            solution = bfSearch.Search();
            prevStepLbl.Text = solution != null ? solution.Count.ToString() : "";
            //Drawstate(solution[0]);
            numOfVisitedNodesLbl.Text = bfSearch.numOfVisitedNodes().ToString();

        }

        private void AAlgBtn_Click(object sender, EventArgs e)
        {
            AAlgorithem<BallState, BallOpperatorCollection> aAlgorithem = new AAlgorithem<BallState, BallOpperatorCollection>();
            solution = aAlgorithem.Search();
            prevStepLbl.Text = solution != null ? solution.Count.ToString() : "";
            //Drawstate(solution[0]);
            numOfVisitedNodesLbl.Text = aAlgorithem.numOfVisitedNodes().ToString();

        }

        private void DFSBtn_Click(object sender, EventArgs e)
        {
            DepthFirstSearch<BallState, BallOpperatorCollection> dfSearch = new DepthFirstSearch<BallState, BallOpperatorCollection>();
            solution = dfSearch.Search();
            prevStepLbl.Text = solution != null ? solution.Count.ToString() : "";

            numOfVisitedNodesLbl.Text = dfSearch.numOfVisitedNodes().ToString();

        }
    }
}
