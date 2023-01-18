namespace SocialMedia___Sociout.User_Controls
{
    partial class PostUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbProfielAfbeelding = new System.Windows.Forms.PictureBox();
            this.lblGebruikersnaam = new System.Windows.Forms.Label();
            this.pnlUser = new System.Windows.Forms.Panel();
            this.pnlFloor = new System.Windows.Forms.Panel();
            this.lblLikes = new System.Windows.Forms.Label();
            this.btnLike = new System.Windows.Forms.Button();
            this.btnReactions = new System.Windows.Forms.Button();
            this.scContent = new System.Windows.Forms.SplitContainer();
            this.pbAfbeelding = new System.Windows.Forms.PictureBox();
            this.rtxtTekst = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfielAfbeelding)).BeginInit();
            this.pnlUser.SuspendLayout();
            this.pnlFloor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scContent)).BeginInit();
            this.scContent.Panel1.SuspendLayout();
            this.scContent.Panel2.SuspendLayout();
            this.scContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAfbeelding)).BeginInit();
            this.SuspendLayout();
            // 
            // pbProfielAfbeelding
            // 
            this.pbProfielAfbeelding.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbProfielAfbeelding.Location = new System.Drawing.Point(0, 0);
            this.pbProfielAfbeelding.Margin = new System.Windows.Forms.Padding(0);
            this.pbProfielAfbeelding.Name = "pbProfielAfbeelding";
            this.pbProfielAfbeelding.Size = new System.Drawing.Size(50, 50);
            this.pbProfielAfbeelding.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProfielAfbeelding.TabIndex = 0;
            this.pbProfielAfbeelding.TabStop = false;
            // 
            // lblGebruikersnaam
            // 
            this.lblGebruikersnaam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGebruikersnaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblGebruikersnaam.Location = new System.Drawing.Point(50, 0);
            this.lblGebruikersnaam.Margin = new System.Windows.Forms.Padding(0);
            this.lblGebruikersnaam.Name = "lblGebruikersnaam";
            this.lblGebruikersnaam.Size = new System.Drawing.Size(498, 50);
            this.lblGebruikersnaam.TabIndex = 1;
            this.lblGebruikersnaam.Text = "Gebruikernaam";
            this.lblGebruikersnaam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlUser
            // 
            this.pnlUser.Controls.Add(this.lblGebruikersnaam);
            this.pnlUser.Controls.Add(this.pbProfielAfbeelding);
            this.pnlUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUser.Location = new System.Drawing.Point(0, 0);
            this.pnlUser.Margin = new System.Windows.Forms.Padding(0);
            this.pnlUser.Name = "pnlUser";
            this.pnlUser.Size = new System.Drawing.Size(548, 50);
            this.pnlUser.TabIndex = 2;
            // 
            // pnlFloor
            // 
            this.pnlFloor.Controls.Add(this.lblLikes);
            this.pnlFloor.Controls.Add(this.btnLike);
            this.pnlFloor.Controls.Add(this.btnReactions);
            this.pnlFloor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFloor.Location = new System.Drawing.Point(0, 283);
            this.pnlFloor.Margin = new System.Windows.Forms.Padding(0);
            this.pnlFloor.Name = "pnlFloor";
            this.pnlFloor.Size = new System.Drawing.Size(548, 25);
            this.pnlFloor.TabIndex = 3;
            // 
            // lblLikes
            // 
            this.lblLikes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLikes.AutoSize = true;
            this.lblLikes.Location = new System.Drawing.Point(425, 7);
            this.lblLikes.Name = "lblLikes";
            this.lblLikes.Size = new System.Drawing.Size(13, 13);
            this.lblLikes.TabIndex = 2;
            this.lblLikes.Text = "0";
            // 
            // btnLike
            // 
            this.btnLike.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLike.Location = new System.Drawing.Point(344, 2);
            this.btnLike.Name = "btnLike";
            this.btnLike.Size = new System.Drawing.Size(75, 23);
            this.btnLike.TabIndex = 1;
            this.btnLike.Text = "like";
            this.btnLike.UseVisualStyleBackColor = true;
            // 
            // btnReactions
            // 
            this.btnReactions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReactions.Location = new System.Drawing.Point(473, 2);
            this.btnReactions.Name = "btnReactions";
            this.btnReactions.Size = new System.Drawing.Size(75, 23);
            this.btnReactions.TabIndex = 0;
            this.btnReactions.Text = "Reacties";
            this.btnReactions.UseVisualStyleBackColor = true;
            // 
            // scContent
            // 
            this.scContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scContent.Location = new System.Drawing.Point(0, 50);
            this.scContent.Margin = new System.Windows.Forms.Padding(0);
            this.scContent.Name = "scContent";
            this.scContent.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scContent.Panel1
            // 
            this.scContent.Panel1.Controls.Add(this.pbAfbeelding);
            // 
            // scContent.Panel2
            // 
            this.scContent.Panel2.Controls.Add(this.rtxtTekst);
            this.scContent.Size = new System.Drawing.Size(548, 233);
            this.scContent.SplitterDistance = 150;
            this.scContent.SplitterWidth = 1;
            this.scContent.TabIndex = 4;
            // 
            // pbAfbeelding
            // 
            this.pbAfbeelding.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbAfbeelding.Location = new System.Drawing.Point(0, 0);
            this.pbAfbeelding.Name = "pbAfbeelding";
            this.pbAfbeelding.Size = new System.Drawing.Size(548, 150);
            this.pbAfbeelding.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAfbeelding.TabIndex = 0;
            this.pbAfbeelding.TabStop = false;
            // 
            // rtxtTekst
            // 
            this.rtxtTekst.DetectUrls = false;
            this.rtxtTekst.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtTekst.Location = new System.Drawing.Point(0, 0);
            this.rtxtTekst.Margin = new System.Windows.Forms.Padding(0);
            this.rtxtTekst.Name = "rtxtTekst";
            this.rtxtTekst.ReadOnly = true;
            this.rtxtTekst.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtxtTekst.Size = new System.Drawing.Size(548, 82);
            this.rtxtTekst.TabIndex = 0;
            this.rtxtTekst.Text = "";
            this.rtxtTekst.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.rtxtTekst_LinkClicked);
            // 
            // PostUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.scContent);
            this.Controls.Add(this.pnlFloor);
            this.Controls.Add(this.pnlUser);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "PostUserControl";
            this.Size = new System.Drawing.Size(548, 308);
            this.Load += new System.EventHandler(this.PostUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbProfielAfbeelding)).EndInit();
            this.pnlUser.ResumeLayout(false);
            this.pnlFloor.ResumeLayout(false);
            this.pnlFloor.PerformLayout();
            this.scContent.Panel1.ResumeLayout(false);
            this.scContent.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scContent)).EndInit();
            this.scContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAfbeelding)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbProfielAfbeelding;
        private System.Windows.Forms.Label lblGebruikersnaam;
        private System.Windows.Forms.Panel pnlUser;
        private System.Windows.Forms.Panel pnlFloor;
        private System.Windows.Forms.Button btnLike;
        private System.Windows.Forms.Button btnReactions;
        private System.Windows.Forms.SplitContainer scContent;
        private System.Windows.Forms.PictureBox pbAfbeelding;
        private System.Windows.Forms.RichTextBox rtxtTekst;
        private System.Windows.Forms.Label lblLikes;
    }
}
