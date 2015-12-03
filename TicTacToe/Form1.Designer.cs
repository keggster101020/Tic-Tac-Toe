namespace TicTacToe
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
            this.topLeft = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.topCenter = new System.Windows.Forms.Label();
            this.topRight = new System.Windows.Forms.Label();
            this.middleLeft = new System.Windows.Forms.Label();
            this.middleCenter = new System.Windows.Forms.Label();
            this.middleRight = new System.Windows.Forms.Label();
            this.bottomLeft = new System.Windows.Forms.Label();
            this.bottomCenter = new System.Windows.Forms.Label();
            this.bottomRight = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblWinner = new System.Windows.Forms.Label();
            this.NewGame = new System.Windows.Forms.Button();
            this.lblTurn = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblXWins = new System.Windows.Forms.Label();
            this.lblOWins = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // topLeft
            // 
            this.topLeft.AutoSize = true;
            this.topLeft.Font = new System.Drawing.Font("Calibri", 32F);
            this.topLeft.ForeColor = System.Drawing.Color.Black;
            this.topLeft.Location = new System.Drawing.Point(289, 169);
            this.topLeft.Name = "topLeft";
            this.topLeft.Size = new System.Drawing.Size(53, 78);
            this.topLeft.TabIndex = 0;
            this.topLeft.Text = "-";
            this.topLeft.Click += new System.EventHandler(this.onLabelClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(263, 246);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 5);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(374, 159);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(3, 300);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(548, 159);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(3, 300);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(263, 381);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(400, 5);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // topCenter
            // 
            this.topCenter.AutoSize = true;
            this.topCenter.Font = new System.Drawing.Font("Calibri", 32F);
            this.topCenter.ForeColor = System.Drawing.Color.Black;
            this.topCenter.Location = new System.Drawing.Point(442, 169);
            this.topCenter.Name = "topCenter";
            this.topCenter.Size = new System.Drawing.Size(53, 78);
            this.topCenter.TabIndex = 0;
            this.topCenter.Text = "-";
            this.topCenter.Click += new System.EventHandler(this.onLabelClick);
            // 
            // topRight
            // 
            this.topRight.AutoSize = true;
            this.topRight.Font = new System.Drawing.Font("Calibri", 32F);
            this.topRight.ForeColor = System.Drawing.Color.Black;
            this.topRight.Location = new System.Drawing.Point(604, 169);
            this.topRight.Name = "topRight";
            this.topRight.Size = new System.Drawing.Size(53, 78);
            this.topRight.TabIndex = 0;
            this.topRight.Text = "-";
            this.topRight.Click += new System.EventHandler(this.onLabelClick);
            // 
            // middleLeft
            // 
            this.middleLeft.AutoSize = true;
            this.middleLeft.Font = new System.Drawing.Font("Calibri", 32F);
            this.middleLeft.ForeColor = System.Drawing.Color.Black;
            this.middleLeft.Location = new System.Drawing.Point(289, 284);
            this.middleLeft.Name = "middleLeft";
            this.middleLeft.Size = new System.Drawing.Size(53, 78);
            this.middleLeft.TabIndex = 0;
            this.middleLeft.Text = "-";
            this.middleLeft.Click += new System.EventHandler(this.onLabelClick);
            // 
            // middleCenter
            // 
            this.middleCenter.AutoSize = true;
            this.middleCenter.Font = new System.Drawing.Font("Calibri", 32F);
            this.middleCenter.ForeColor = System.Drawing.Color.Black;
            this.middleCenter.Location = new System.Drawing.Point(442, 284);
            this.middleCenter.Name = "middleCenter";
            this.middleCenter.Size = new System.Drawing.Size(53, 78);
            this.middleCenter.TabIndex = 0;
            this.middleCenter.Text = "-";
            this.middleCenter.Click += new System.EventHandler(this.onLabelClick);
            // 
            // middleRight
            // 
            this.middleRight.AutoSize = true;
            this.middleRight.Font = new System.Drawing.Font("Calibri", 32F);
            this.middleRight.ForeColor = System.Drawing.Color.Black;
            this.middleRight.Location = new System.Drawing.Point(604, 284);
            this.middleRight.Name = "middleRight";
            this.middleRight.Size = new System.Drawing.Size(53, 78);
            this.middleRight.TabIndex = 0;
            this.middleRight.Text = "-";
            this.middleRight.Click += new System.EventHandler(this.onLabelClick);
            // 
            // bottomLeft
            // 
            this.bottomLeft.AutoSize = true;
            this.bottomLeft.Font = new System.Drawing.Font("Calibri", 32F);
            this.bottomLeft.ForeColor = System.Drawing.Color.Black;
            this.bottomLeft.Location = new System.Drawing.Point(289, 391);
            this.bottomLeft.Name = "bottomLeft";
            this.bottomLeft.Size = new System.Drawing.Size(53, 78);
            this.bottomLeft.TabIndex = 0;
            this.bottomLeft.Text = "-";
            this.bottomLeft.Click += new System.EventHandler(this.onLabelClick);
            // 
            // bottomCenter
            // 
            this.bottomCenter.AutoSize = true;
            this.bottomCenter.Font = new System.Drawing.Font("Calibri", 32F);
            this.bottomCenter.ForeColor = System.Drawing.Color.Black;
            this.bottomCenter.Location = new System.Drawing.Point(442, 391);
            this.bottomCenter.Name = "bottomCenter";
            this.bottomCenter.Size = new System.Drawing.Size(53, 78);
            this.bottomCenter.TabIndex = 0;
            this.bottomCenter.Text = "-";
            this.bottomCenter.Click += new System.EventHandler(this.onLabelClick);
            // 
            // bottomRight
            // 
            this.bottomRight.AutoSize = true;
            this.bottomRight.Font = new System.Drawing.Font("Calibri", 32F);
            this.bottomRight.ForeColor = System.Drawing.Color.Black;
            this.bottomRight.Location = new System.Drawing.Point(604, 391);
            this.bottomRight.Name = "bottomRight";
            this.bottomRight.Size = new System.Drawing.Size(53, 78);
            this.bottomRight.TabIndex = 0;
            this.bottomRight.Text = "-";
            this.bottomRight.Click += new System.EventHandler(this.onLabelClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20F);
            this.label1.Location = new System.Drawing.Point(14, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 49);
            this.label1.TabIndex = 2;
            this.label1.Text = "Turn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(21, 537);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 68);
            this.label2.TabIndex = 3;
            this.label2.Text = "Winner:";
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.Font = new System.Drawing.Font("Calibri", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.ForeColor = System.Drawing.Color.Black;
            this.lblWinner.Location = new System.Drawing.Point(225, 537);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(152, 68);
            this.lblWinner.TabIndex = 4;
            this.lblWinner.Text = "None";
            // 
            // NewGame
            // 
            this.NewGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.NewGame.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.NewGame.FlatAppearance.BorderSize = 0;
            this.NewGame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(244)))));
            this.NewGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.NewGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewGame.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewGame.ForeColor = System.Drawing.Color.White;
            this.NewGame.Location = new System.Drawing.Point(582, 534);
            this.NewGame.Name = "NewGame";
            this.NewGame.Size = new System.Drawing.Size(265, 68);
            this.NewGame.TabIndex = 6;
            this.NewGame.Text = "New Game";
            this.NewGame.UseVisualStyleBackColor = false;
            this.NewGame.Click += new System.EventHandler(this.NewGame_Click);
            // 
            // lblTurn
            // 
            this.lblTurn.AutoSize = true;
            this.lblTurn.Font = new System.Drawing.Font("Calibri", 20F);
            this.lblTurn.Location = new System.Drawing.Point(127, 169);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(0, 49);
            this.lblTurn.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 20F);
            this.label3.Location = new System.Drawing.Point(254, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 49);
            this.label3.TabIndex = 2;
            this.label3.Text = "X Wins:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 20F);
            this.label4.Location = new System.Drawing.Point(539, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 49);
            this.label4.TabIndex = 2;
            this.label4.Text = "O Wins: ";
            // 
            // lblXWins
            // 
            this.lblXWins.AutoSize = true;
            this.lblXWins.Font = new System.Drawing.Font("Calibri", 20F);
            this.lblXWins.Location = new System.Drawing.Point(405, 44);
            this.lblXWins.Name = "lblXWins";
            this.lblXWins.Size = new System.Drawing.Size(82, 49);
            this.lblXWins.TabIndex = 2;
            this.lblXWins.Text = "100";
            this.lblXWins.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOWins
            // 
            this.lblOWins.AutoSize = true;
            this.lblOWins.Font = new System.Drawing.Font("Calibri", 20F);
            this.lblOWins.Location = new System.Drawing.Point(684, 44);
            this.lblOWins.Name = "lblOWins";
            this.lblOWins.Size = new System.Drawing.Size(82, 49);
            this.lblOWins.TabIndex = 2;
            this.lblOWins.Text = "100";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 624);
            this.Controls.Add(this.NewGame);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTurn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblOWins);
            this.Controls.Add(this.lblXWins);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bottomRight);
            this.Controls.Add(this.middleRight);
            this.Controls.Add(this.topRight);
            this.Controls.Add(this.bottomCenter);
            this.Controls.Add(this.middleCenter);
            this.Controls.Add(this.topCenter);
            this.Controls.Add(this.bottomLeft);
            this.Controls.Add(this.middleLeft);
            this.Controls.Add(this.topLeft);
            this.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(18, 60, 18, 19);
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label topLeft;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label topCenter;
        private System.Windows.Forms.Label topRight;
        private System.Windows.Forms.Label middleLeft;
        private System.Windows.Forms.Label middleCenter;
        private System.Windows.Forms.Label middleRight;
        private System.Windows.Forms.Label bottomLeft;
        private System.Windows.Forms.Label bottomCenter;
        private System.Windows.Forms.Label bottomRight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.Button NewGame;
        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblXWins;
        private System.Windows.Forms.Label lblOWins;
    }
}

