
namespace ColiseumGamestore
{
    partial class GameDetails
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
            this.LabelGameName = new System.Windows.Forms.Label();
            this.InputGameName = new System.Windows.Forms.TextBox();
            this.LabelGameDetails = new System.Windows.Forms.Label();
            this.ComboDetailId = new System.Windows.Forms.ComboBox();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.GameDetailGrid = new System.Windows.Forms.DataGridView();
            this.LabelDetailsDatabase = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GameDetailGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelGameName
            // 
            this.LabelGameName.AutoSize = true;
            this.LabelGameName.Location = new System.Drawing.Point(45, 35);
            this.LabelGameName.Name = "LabelGameName";
            this.LabelGameName.Size = new System.Drawing.Size(48, 20);
            this.LabelGameName.TabIndex = 0;
            this.LabelGameName.Text = "Game";
            // 
            // InputGameName
            // 
            this.InputGameName.Location = new System.Drawing.Point(45, 58);
            this.InputGameName.Name = "InputGameName";
            this.InputGameName.ReadOnly = true;
            this.InputGameName.Size = new System.Drawing.Size(410, 27);
            this.InputGameName.TabIndex = 1;
            // 
            // LabelGameDetails
            // 
            this.LabelGameDetails.AutoSize = true;
            this.LabelGameDetails.Location = new System.Drawing.Point(45, 103);
            this.LabelGameDetails.Name = "LabelGameDetails";
            this.LabelGameDetails.Size = new System.Drawing.Size(98, 20);
            this.LabelGameDetails.TabIndex = 2;
            this.LabelGameDetails.Text = "Game Details";
            // 
            // ComboDetailId
            // 
            this.ComboDetailId.FormattingEnabled = true;
            this.ComboDetailId.Location = new System.Drawing.Point(45, 126);
            this.ComboDetailId.Name = "ComboDetailId";
            this.ComboDetailId.Size = new System.Drawing.Size(220, 28);
            this.ComboDetailId.TabIndex = 3;
            this.ComboDetailId.SelectedIndexChanged += new System.EventHandler(this.ComboDetailId_SelectedIndexChanged);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BtnExit.Location = new System.Drawing.Point(260, 183);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(195, 40);
            this.BtnExit.TabIndex = 4;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.PaleGreen;
            this.BtnAdd.Location = new System.Drawing.Point(45, 183);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(188, 40);
            this.BtnAdd.TabIndex = 5;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // GameDetailGrid
            // 
            this.GameDetailGrid.AllowUserToAddRows = false;
            this.GameDetailGrid.AllowUserToDeleteRows = false;
            this.GameDetailGrid.AllowUserToResizeColumns = false;
            this.GameDetailGrid.AllowUserToResizeRows = false;
            this.GameDetailGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GameDetailGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GameDetailGrid.Location = new System.Drawing.Point(45, 271);
            this.GameDetailGrid.Name = "GameDetailGrid";
            this.GameDetailGrid.RowHeadersWidth = 51;
            this.GameDetailGrid.RowTemplate.Height = 29;
            this.GameDetailGrid.Size = new System.Drawing.Size(410, 244);
            this.GameDetailGrid.TabIndex = 6;
            // 
            // LabelDetailsDatabase
            // 
            this.LabelDetailsDatabase.AutoSize = true;
            this.LabelDetailsDatabase.Location = new System.Drawing.Point(45, 239);
            this.LabelDetailsDatabase.Name = "LabelDetailsDatabase";
            this.LabelDetailsDatabase.Size = new System.Drawing.Size(72, 20);
            this.LabelDetailsDatabase.TabIndex = 7;
            this.LabelDetailsDatabase.Text = "Database";
            // 
            // GameDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 548);
            this.Controls.Add(this.LabelDetailsDatabase);
            this.Controls.Add(this.GameDetailGrid);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.ComboDetailId);
            this.Controls.Add(this.LabelGameDetails);
            this.Controls.Add(this.InputGameName);
            this.Controls.Add(this.LabelGameName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GameDetails";
            this.Text = "GameDetails";
            ((System.ComponentModel.ISupportInitialize)(this.GameDetailGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelGameName;
        private System.Windows.Forms.TextBox InputGameName;
        private System.Windows.Forms.Label LabelGameDetails;
        private System.Windows.Forms.ComboBox ComboDetailId;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.DataGridView GameDetailGrid;
        private System.Windows.Forms.Label LabelDetailsDatabase;
    }
}