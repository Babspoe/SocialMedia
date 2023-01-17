namespace SocialMedia___Sociout.User_Controls
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
            this.tc = new System.Windows.Forms.TabControl();
            this.tpLaatste = new System.Windows.Forms.TabPage();
            this.tpLiked = new System.Windows.Forms.TabPage();
            this.tpVolgt = new System.Windows.Forms.TabPage();
            this.pbPfp = new System.Windows.Forms.PictureBox();
            this.lblProfielNaam = new System.Windows.Forms.Label();
            this.flpLaatste = new System.Windows.Forms.FlowLayoutPanel();
            this.flpGeliked = new System.Windows.Forms.FlowLayoutPanel();
            this.flpVolgt = new System.Windows.Forms.FlowLayoutPanel();
            this.btnVolgen = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.tc.SuspendLayout();
            this.tpLaatste.SuspendLayout();
            this.tpLiked.SuspendLayout();
            this.tpVolgt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPfp)).BeginInit();
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
            this.pnlHeader.Size = new System.Drawing.Size(852, 75);
            this.pnlHeader.TabIndex = 0;
            // 
            // tc
            // 
            this.tc.Controls.Add(this.tpLaatste);
            this.tc.Controls.Add(this.tpLiked);
            this.tc.Controls.Add(this.tpVolgt);
            this.tc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tc.Location = new System.Drawing.Point(0, 75);
            this.tc.Name = "tc";
            this.tc.SelectedIndex = 0;
            this.tc.Size = new System.Drawing.Size(852, 397);
            this.tc.TabIndex = 1;
            // 
            // tpLaatste
            // 
            this.tpLaatste.Controls.Add(this.flpLaatste);
            this.tpLaatste.Location = new System.Drawing.Point(4, 22);
            this.tpLaatste.Margin = new System.Windows.Forms.Padding(0);
            this.tpLaatste.Name = "tpLaatste";
            this.tpLaatste.Size = new System.Drawing.Size(844, 371);
            this.tpLaatste.TabIndex = 0;
            this.tpLaatste.Text = "Laatste";
            this.tpLaatste.UseVisualStyleBackColor = true;
            // 
            // tpLiked
            // 
            this.tpLiked.Controls.Add(this.flpGeliked);
            this.tpLiked.Location = new System.Drawing.Point(4, 22);
            this.tpLiked.Margin = new System.Windows.Forms.Padding(0);
            this.tpLiked.Name = "tpLiked";
            this.tpLiked.Size = new System.Drawing.Size(844, 371);
            this.tpLiked.TabIndex = 1;
            this.tpLiked.Text = "Geliked";
            this.tpLiked.UseVisualStyleBackColor = true;
            // 
            // tpVolgt
            // 
            this.tpVolgt.Controls.Add(this.flpVolgt);
            this.tpVolgt.Location = new System.Drawing.Point(4, 22);
            this.tpVolgt.Margin = new System.Windows.Forms.Padding(0);
            this.tpVolgt.Name = "tpVolgt";
            this.tpVolgt.Size = new System.Drawing.Size(844, 371);
            this.tpVolgt.TabIndex = 2;
            this.tpVolgt.Text = "Volgt";
            this.tpVolgt.UseVisualStyleBackColor = true;
            // 
            // pbPfp
            // 
            this.pbPfp.Location = new System.Drawing.Point(0, 0);
            this.pbPfp.Margin = new System.Windows.Forms.Padding(0);
            this.pbPfp.Name = "pbPfp";
            this.pbPfp.Size = new System.Drawing.Size(75, 75);
            this.pbPfp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPfp.TabIndex = 0;
            this.pbPfp.TabStop = false;
            // 
            // lblProfielNaam
            // 
            this.lblProfielNaam.AutoSize = true;
            this.lblProfielNaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblProfielNaam.Location = new System.Drawing.Point(78, 24);
            this.lblProfielNaam.Name = "lblProfielNaam";
            this.lblProfielNaam.Size = new System.Drawing.Size(214, 31);
            this.lblProfielNaam.TabIndex = 1;
            this.lblProfielNaam.Text = "Gebruikersnaam";
            // 
            // flpLaatste
            // 
            this.flpLaatste.AutoScroll = true;
            this.flpLaatste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpLaatste.Location = new System.Drawing.Point(0, 0);
            this.flpLaatste.Name = "flpLaatste";
            this.flpLaatste.Size = new System.Drawing.Size(844, 371);
            this.flpLaatste.TabIndex = 0;
            // 
            // flpGeliked
            // 
            this.flpGeliked.AutoScroll = true;
            this.flpGeliked.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpGeliked.Location = new System.Drawing.Point(0, 0);
            this.flpGeliked.Name = "flpGeliked";
            this.flpGeliked.Size = new System.Drawing.Size(844, 371);
            this.flpGeliked.TabIndex = 1;
            // 
            // flpVolgt
            // 
            this.flpVolgt.AutoScroll = true;
            this.flpVolgt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpVolgt.Location = new System.Drawing.Point(0, 0);
            this.flpVolgt.Name = "flpVolgt";
            this.flpVolgt.Size = new System.Drawing.Size(844, 371);
            this.flpVolgt.TabIndex = 1;
            // 
            // btnVolgen
            // 
            this.btnVolgen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVolgen.Location = new System.Drawing.Point(772, 31);
            this.btnVolgen.Margin = new System.Windows.Forms.Padding(0);
            this.btnVolgen.Name = "btnVolgen";
            this.btnVolgen.Size = new System.Drawing.Size(75, 23);
            this.btnVolgen.TabIndex = 2;
            this.btnVolgen.Text = "Volgen";
            this.btnVolgen.UseVisualStyleBackColor = true;
            this.btnVolgen.Click += new System.EventHandler(this.btnVolgen_Click);
            // 
            // ProfielUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tc);
            this.Controls.Add(this.pnlHeader);
            this.Name = "ProfielUserControl";
            this.Size = new System.Drawing.Size(852, 472);
            this.Load += new System.EventHandler(this.ProfielUserControl_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.tc.ResumeLayout(false);
            this.tpLaatste.ResumeLayout(false);
            this.tpLiked.ResumeLayout(false);
            this.tpVolgt.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPfp)).EndInit();
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
