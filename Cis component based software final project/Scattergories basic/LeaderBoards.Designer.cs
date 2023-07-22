
namespace Scattergories_basic
{
    partial class LeaderBoards
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
            this.dataGridLeaderBoards = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLeaderBoards)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridLeaderBoards
            // 
            this.dataGridLeaderBoards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridLeaderBoards.Location = new System.Drawing.Point(0, 150);
            this.dataGridLeaderBoards.Name = "dataGridLeaderBoards";
            this.dataGridLeaderBoards.Size = new System.Drawing.Size(799, 251);
            this.dataGridLeaderBoards.TabIndex = 0;
            this.dataGridLeaderBoards.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridLeaderBoards_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Copperplate Gothic Light", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(174, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "LeaderBoards";
            // 
            // LeaderBoards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridLeaderBoards);
            this.Name = "LeaderBoards";
            this.Text = "LeaderBoards";
            this.Load += new System.EventHandler(this.LeaderBoards_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLeaderBoards)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridLeaderBoards;
        private System.Windows.Forms.Label label1;
    }
}