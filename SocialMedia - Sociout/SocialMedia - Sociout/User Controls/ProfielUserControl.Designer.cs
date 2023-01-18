﻿namespace SocialMedia___Sociout.User_Controls
{
    partial class ProfielUserControl
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnVolgen = new System.Windows.Forms.Button();
            this.lblProfielNaam = new System.Windows.Forms.Label();
            this.pbPfp = new System.Windows.Forms.PictureBox();
            this.tc = new System.Windows.Forms.TabControl();
            this.tpLaatste = new System.Windows.Forms.TabPage();
            this.flpLaatste = new System.Windows.Forms.FlowLayoutPanel();
            this.tpLiked = new System.Windows.Forms.TabPage();
            this.flpGeliked = new System.Windows.Forms.FlowLayoutPanel();
            this.tpVolgt = new System.Windows.Forms.TabPage();
            this.flpVolgt = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPfp)).BeginInit();
            this.tc.SuspendLayout();
            this.tpLaatste.SuspendLayout();
            this.tpLiked.SuspendLayout();
            this.tpVolgt.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.btnVolgen);
            this.pnlHeader.Controls.Add(this.lblProfielNaam);
            this.pnlHeader.Controls.Add(this.pbPfp);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1136, 92);
            this.pnlHeader.TabIndex = 0;
            this.pnlHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlHeader_Paint);
            // 
            // btnVolgen
            // 
            this.btnVolgen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVolgen.Location = new System.Drawing.Point(1029, 38);
            this.btnVolgen.Margin = new System.Windows.Forms.Padding(0);
            this.btnVolgen.Name = "btnVolgen";
            this.btnVolgen.Size = new System.Drawing.Size(100, 28);
            this.btnVolgen.TabIndex = 2;
            this.btnVolgen.Text = "Volgen";
            this.btnVolgen.UseVisualStyleBackColor = true;
            this.btnVolgen.Click += new System.EventHandler(this.btnVolgen_Click);
            // 
            // lblProfielNaam
            // 
            this.lblProfielNaam.AutoSize = true;
            this.lblProfielNaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblProfielNaam.Location = new System.Drawing.Point(104, 30);
            this.lblProfielNaam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProfielNaam.Name = "lblProfielNaam";
            this.lblProfielNaam.Size = new System.Drawing.Size(268, 39);
            this.lblProfielNaam.TabIndex = 1;
            this.lblProfielNaam.Text = "Gebruikersnaam";
            // 
            // pbPfp
            // 
            this.pbPfp.Location = new System.Drawing.Point(0, 0);
            this.pbPfp.Margin = new System.Windows.Forms.Padding(0);
            this.pbPfp.Name = "pbPfp";
            this.pbPfp.Size = new System.Drawing.Size(100, 92);
            this.pbPfp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPfp.TabIndex = 0;
            this.pbPfp.TabStop = false;
            // 
            // tc
            // 
            this.tc.Controls.Add(this.tpLaatste);
            this.tc.Controls.Add(this.tpLiked);
            this.tc.Controls.Add(this.tpVolgt);
            this.tc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tc.Location = new System.Drawing.Point(0, 92);
            this.tc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tc.Name = "tc";
            this.tc.SelectedIndex = 0;
            this.tc.Size = new System.Drawing.Size(1136, 489);
            this.tc.TabIndex = 1;
            // 
            // tpLaatste
            // 
            this.tpLaatste.Controls.Add(this.flpLaatste);
            this.tpLaatste.Location = new System.Drawing.Point(4, 25);
            this.tpLaatste.Margin = new System.Windows.Forms.Padding(0);
            this.tpLaatste.Name = "tpLaatste";
            this.tpLaatste.Size = new System.Drawing.Size(1128, 460);
            this.tpLaatste.TabIndex = 0;
            this.tpLaatste.Text = "Laatste";
            this.tpLaatste.UseVisualStyleBackColor = true;
            // 
            // flpLaatste
            // 
            this.flpLaatste.AutoScroll = true;
            this.flpLaatste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpLaatste.Location = new System.Drawing.Point(0, 0);
            this.flpLaatste.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flpLaatste.Name = "flpLaatste";
            this.flpLaatste.Size = new System.Drawing.Size(1128, 460);
            this.flpLaatste.TabIndex = 0;
            // 
            // tpLiked
            // 
            this.tpLiked.Controls.Add(this.flpGeliked);
            this.tpLiked.Location = new System.Drawing.Point(4, 25);
            this.tpLiked.Margin = new System.Windows.Forms.Padding(0);
            this.tpLiked.Name = "tpLiked";
            this.tpLiked.Size = new System.Drawing.Size(1128, 460);
            this.tpLiked.TabIndex = 1;
            this.tpLiked.Text = "Geliked";
            this.tpLiked.UseVisualStyleBackColor = true;
            // 
            // flpGeliked
            // 
            this.flpGeliked.AutoScroll = true;
            this.flpGeliked.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpGeliked.Location = new System.Drawing.Point(0, 0);
            this.flpGeliked.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flpGeliked.Name = "flpGeliked";
            this.flpGeliked.Size = new System.Drawing.Size(1128, 460);
            this.flpGeliked.TabIndex = 1;
            // 
            // tpVolgt
            // 
            this.tpVolgt.Controls.Add(this.flpVolgt);
            this.tpVolgt.Location = new System.Drawing.Point(4, 25);
            this.tpVolgt.Margin = new System.Windows.Forms.Padding(0);
            this.tpVolgt.Name = "tpVolgt";
            this.tpVolgt.Size = new System.Drawing.Size(1128, 460);
            this.tpVolgt.TabIndex = 2;
            this.tpVolgt.Text = "Volgt";
            this.tpVolgt.UseVisualStyleBackColor = true;
            // 
            // flpVolgt
            // 
            this.flpVolgt.AutoScroll = true;
            this.flpVolgt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpVolgt.Location = new System.Drawing.Point(0, 0);
            this.flpVolgt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flpVolgt.Name = "flpVolgt";
            this.flpVolgt.Size = new System.Drawing.Size(1128, 460);
            this.flpVolgt.TabIndex = 1;
            // 
            // ProfielUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tc);
            this.Controls.Add(this.pnlHeader);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ProfielUserControl";
            this.Size = new System.Drawing.Size(1136, 581);
            this.Load += new System.EventHandler(this.ProfielUserControl_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPfp)).EndInit();
            this.tc.ResumeLayout(false);
            this.tpLaatste.ResumeLayout(false);
            this.tpLiked.ResumeLayout(false);
            this.tpVolgt.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblProfielNaam;
        private System.Windows.Forms.PictureBox pbPfp;
        private System.Windows.Forms.TabControl tc;
        private System.Windows.Forms.TabPage tpLaatste;
        private System.Windows.Forms.FlowLayoutPanel flpLaatste;
        private System.Windows.Forms.TabPage tpLiked;
        private System.Windows.Forms.FlowLayoutPanel flpGeliked;
        private System.Windows.Forms.TabPage tpVolgt;
        private System.Windows.Forms.FlowLayoutPanel flpVolgt;
        private System.Windows.Forms.Button btnVolgen;
    }
}
