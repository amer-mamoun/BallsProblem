namespace BallsProblem
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.board = new System.Windows.Forms.PictureBox();
            this.prevStepBtn = new System.Windows.Forms.Button();
            this.nextStepBtn = new System.Windows.Forms.Button();
            this.BFSsearchBtn = new System.Windows.Forms.Button();
            this.prevStepLbl = new System.Windows.Forms.Label();
            this.nextStepLbl = new System.Windows.Forms.Label();
            this.numOfVisitedNodesLbl = new System.Windows.Forms.Label();
            this.visitedNodeLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.board)).BeginInit();
            this.SuspendLayout();
            // 
            // board
            // 
            this.board.BackColor = System.Drawing.SystemColors.ControlLight;
            this.board.Location = new System.Drawing.Point(45, 45);
            this.board.Name = "board";
            this.board.Size = new System.Drawing.Size(477, 282);
            this.board.TabIndex = 0;
            this.board.TabStop = false;
            // 
            // prevStepBtn
            // 
            this.prevStepBtn.Location = new System.Drawing.Point(114, 379);
            this.prevStepBtn.Name = "prevStepBtn";
            this.prevStepBtn.Size = new System.Drawing.Size(75, 23);
            this.prevStepBtn.TabIndex = 1;
            this.prevStepBtn.Text = "<<";
            this.prevStepBtn.UseVisualStyleBackColor = true;
            this.prevStepBtn.Click += new System.EventHandler(this.PrevStepBtn_Click);
            // 
            // nextStepBtn
            // 
            this.nextStepBtn.Location = new System.Drawing.Point(368, 378);
            this.nextStepBtn.Name = "nextStepBtn";
            this.nextStepBtn.Size = new System.Drawing.Size(75, 23);
            this.nextStepBtn.TabIndex = 2;
            this.nextStepBtn.Text = ">>";
            this.nextStepBtn.UseVisualStyleBackColor = true;
            this.nextStepBtn.Click += new System.EventHandler(this.NextStepBtn_Click);
            // 
            // BFSsearchBtn
            // 
            this.BFSsearchBtn.Location = new System.Drawing.Point(628, 62);
            this.BFSsearchBtn.Name = "BFSsearchBtn";
            this.BFSsearchBtn.Size = new System.Drawing.Size(75, 23);
            this.BFSsearchBtn.TabIndex = 3;
            this.BFSsearchBtn.Text = "BFS";
            this.BFSsearchBtn.UseVisualStyleBackColor = true;
            this.BFSsearchBtn.Click += new System.EventHandler(this.BFSsearchBtn_Click);
            // 
            // prevStepLbl
            // 
            this.prevStepLbl.AutoSize = true;
            this.prevStepLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prevStepLbl.Location = new System.Drawing.Point(114, 343);
            this.prevStepLbl.Name = "prevStepLbl";
            this.prevStepLbl.Size = new System.Drawing.Size(109, 20);
            this.prevStepLbl.TabIndex = 4;
            this.prevStepLbl.Text = "Prevous Step";
            // 
            // nextStepLbl
            // 
            this.nextStepLbl.AutoSize = true;
            this.nextStepLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextStepLbl.Location = new System.Drawing.Point(368, 343);
            this.nextStepLbl.Name = "nextStepLbl";
            this.nextStepLbl.Size = new System.Drawing.Size(82, 20);
            this.nextStepLbl.TabIndex = 5;
            this.nextStepLbl.Text = "Next Step";
            // 
            // numOfVisitedNodesLbl
            // 
            this.numOfVisitedNodesLbl.AutoSize = true;
            this.numOfVisitedNodesLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOfVisitedNodesLbl.Location = new System.Drawing.Point(640, 193);
            this.numOfVisitedNodesLbl.Name = "numOfVisitedNodesLbl";
            this.numOfVisitedNodesLbl.Size = new System.Drawing.Size(18, 20);
            this.numOfVisitedNodesLbl.TabIndex = 6;
            this.numOfVisitedNodesLbl.Text = "0";
            // 
            // visitedNodeLbl
            // 
            this.visitedNodeLbl.AutoSize = true;
            this.visitedNodeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visitedNodeLbl.Location = new System.Drawing.Point(561, 156);
            this.visitedNodeLbl.Name = "visitedNodeLbl";
            this.visitedNodeLbl.Size = new System.Drawing.Size(190, 20);
            this.visitedNodeLbl.TabIndex = 7;
            this.visitedNodeLbl.Text = "Num. Of Visited Nodes: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.visitedNodeLbl);
            this.Controls.Add(this.numOfVisitedNodesLbl);
            this.Controls.Add(this.nextStepLbl);
            this.Controls.Add(this.prevStepLbl);
            this.Controls.Add(this.BFSsearchBtn);
            this.Controls.Add(this.nextStepBtn);
            this.Controls.Add(this.prevStepBtn);
            this.Controls.Add(this.board);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.board)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox board;
        private System.Windows.Forms.Button prevStepBtn;
        private System.Windows.Forms.Button nextStepBtn;
        private System.Windows.Forms.Button BFSsearchBtn;
        private System.Windows.Forms.Label prevStepLbl;
        private System.Windows.Forms.Label nextStepLbl;
        private System.Windows.Forms.Label numOfVisitedNodesLbl;
        private System.Windows.Forms.Label visitedNodeLbl;
    }
}

