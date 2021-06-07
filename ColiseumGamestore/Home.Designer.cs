namespace ColiseumGamestore
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.InputId = new System.Windows.Forms.TextBox();
            this.LabelId = new System.Windows.Forms.Label();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.InputTitle = new System.Windows.Forms.TextBox();
            this.LabelReleased = new System.Windows.Forms.Label();
            this.InputReleased = new System.Windows.Forms.TextBox();
            this.LabelStudio = new System.Windows.Forms.Label();
            this.InputStudioId = new System.Windows.Forms.ComboBox();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.GameGridView = new System.Windows.Forms.DataGridView();
            this.InputPrice = new System.Windows.Forms.TextBox();
            this.LabelPrice = new System.Windows.Forms.Label();
            this.LabelGameDatabase = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.GameGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // InputId
            // 
            this.InputId.Location = new System.Drawing.Point(41, 146);
            this.InputId.Name = "InputId";
            this.InputId.ReadOnly = true;
            this.InputId.Size = new System.Drawing.Size(251, 27);
            this.InputId.TabIndex = 0;
            // 
            // LabelId
            // 
            this.LabelId.AutoSize = true;
            this.LabelId.Location = new System.Drawing.Point(41, 123);
            this.LabelId.Name = "LabelId";
            this.LabelId.Size = new System.Drawing.Size(24, 20);
            this.LabelId.TabIndex = 1;
            this.LabelId.Text = "ID";
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Location = new System.Drawing.Point(41, 186);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(38, 20);
            this.LabelTitle.TabIndex = 3;
            this.LabelTitle.Text = "Title";
            // 
            // InputTitle
            // 
            this.InputTitle.Location = new System.Drawing.Point(41, 209);
            this.InputTitle.Name = "InputTitle";
            this.InputTitle.Size = new System.Drawing.Size(251, 27);
            this.InputTitle.TabIndex = 2;
            // 
            // LabelReleased
            // 
            this.LabelReleased.AutoSize = true;
            this.LabelReleased.Location = new System.Drawing.Point(41, 319);
            this.LabelReleased.Name = "LabelReleased";
            this.LabelReleased.Size = new System.Drawing.Size(69, 20);
            this.LabelReleased.TabIndex = 5;
            this.LabelReleased.Text = "Released";
            // 
            // InputReleased
            // 
            this.InputReleased.Location = new System.Drawing.Point(41, 342);
            this.InputReleased.Name = "InputReleased";
            this.InputReleased.Size = new System.Drawing.Size(251, 27);
            this.InputReleased.TabIndex = 4;
            // 
            // LabelStudio
            // 
            this.LabelStudio.AutoSize = true;
            this.LabelStudio.Location = new System.Drawing.Point(41, 381);
            this.LabelStudio.Name = "LabelStudio";
            this.LabelStudio.Size = new System.Drawing.Size(52, 20);
            this.LabelStudio.TabIndex = 6;
            this.LabelStudio.Text = "Studio";
            // 
            // InputStudioId
            // 
            this.InputStudioId.FormattingEnabled = true;
            this.InputStudioId.Location = new System.Drawing.Point(41, 404);
            this.InputStudioId.Name = "InputStudioId";
            this.InputStudioId.Size = new System.Drawing.Size(251, 28);
            this.InputStudioId.TabIndex = 7;
            // 
            // BtnCreate
            // 
            this.BtnCreate.BackColor = System.Drawing.Color.PaleGreen;
            this.BtnCreate.Location = new System.Drawing.Point(41, 447);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(81, 43);
            this.BtnCreate.TabIndex = 8;
            this.BtnCreate.Text = "Create";
            this.BtnCreate.UseVisualStyleBackColor = false;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BtnUpdate.Location = new System.Drawing.Point(128, 447);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(81, 43);
            this.BtnUpdate.TabIndex = 9;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.IndianRed;
            this.BtnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnDelete.Location = new System.Drawing.Point(215, 447);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(77, 43);
            this.BtnDelete.TabIndex = 10;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // GameGridView
            // 
            this.GameGridView.AllowUserToAddRows = false;
            this.GameGridView.AllowUserToDeleteRows = false;
            this.GameGridView.AllowUserToResizeColumns = false;
            this.GameGridView.AllowUserToResizeRows = false;
            this.GameGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GameGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GameGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GameGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GameGridView.Location = new System.Drawing.Point(335, 60);
            this.GameGridView.Name = "GameGridView";
            this.GameGridView.ReadOnly = true;
            this.GameGridView.RowHeadersWidth = 51;
            this.GameGridView.RowTemplate.Height = 29;
            this.GameGridView.Size = new System.Drawing.Size(634, 430);
            this.GameGridView.TabIndex = 11;
            this.GameGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GameGridView_RowHeaderMouseClick);
            this.GameGridView.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GameGridView_RowHeaderMouseDoubleClick);
            // 
            // InputPrice
            // 
            this.InputPrice.Location = new System.Drawing.Point(41, 274);
            this.InputPrice.Name = "InputPrice";
            this.InputPrice.Size = new System.Drawing.Size(251, 27);
            this.InputPrice.TabIndex = 12;
            // 
            // LabelPrice
            // 
            this.LabelPrice.AutoSize = true;
            this.LabelPrice.Location = new System.Drawing.Point(41, 249);
            this.LabelPrice.Name = "LabelPrice";
            this.LabelPrice.Size = new System.Drawing.Size(41, 20);
            this.LabelPrice.TabIndex = 13;
            this.LabelPrice.Text = "Price";
            // 
            // LabelGameDatabase
            // 
            this.LabelGameDatabase.AutoSize = true;
            this.LabelGameDatabase.Location = new System.Drawing.Point(335, 37);
            this.LabelGameDatabase.Name = "LabelGameDatabase";
            this.LabelGameDatabase.Size = new System.Drawing.Size(72, 20);
            this.LabelGameDatabase.TabIndex = 14;
            this.LabelGameDatabase.Text = "Database";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ColiseumGamestore.Properties.Resources.coliseum_logo_small;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(41, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(251, 83);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 542);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LabelGameDatabase);
            this.Controls.Add(this.LabelPrice);
            this.Controls.Add(this.InputPrice);
            this.Controls.Add(this.GameGridView);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnCreate);
            this.Controls.Add(this.InputStudioId);
            this.Controls.Add(this.LabelStudio);
            this.Controls.Add(this.LabelReleased);
            this.Controls.Add(this.InputReleased);
            this.Controls.Add(this.LabelTitle);
            this.Controls.Add(this.InputTitle);
            this.Controls.Add(this.LabelId);
            this.Controls.Add(this.InputId);
            this.Name = "Home";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.GameGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputId;
        private System.Windows.Forms.Label LabelId;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.TextBox InputTitle;
        private System.Windows.Forms.Label LabelReleased;
        private System.Windows.Forms.TextBox InputReleased;
        private System.Windows.Forms.Label LabelStudio;
        private System.Windows.Forms.ComboBox InputStudioId;
        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.DataGridView GameGridView;
        private System.Windows.Forms.TextBox InputPrice;
        private System.Windows.Forms.Label LabelPrice;
        private System.Windows.Forms.Label LabelGameDatabase;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

