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
            this.tpBewerken = new System.Windows.Forms.TabPage();
            this.btnSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbWachtwoord = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNaam = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnFoto = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPfp)).BeginInit();
            this.tc.SuspendLayout();
            this.tpLaatste.SuspendLayout();
            this.tpLiked.SuspendLayout();
            this.tpVolgt.SuspendLayout();
            this.tpBewerken.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.pnlHeader.Size = new System.Drawing.Size(875, 94);
            this.pnlHeader.TabIndex = 0;
            // 
            // btnVolgen
            // 
            this.btnVolgen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVolgen.Location = new System.Drawing.Point(1286, 48);
            this.btnVolgen.Margin = new System.Windows.Forms.Padding(0);
            this.btnVolgen.Name = "btnVolgen";
            this.btnVolgen.Size = new System.Drawing.Size(125, 35);
            this.btnVolgen.TabIndex = 2;
            this.btnVolgen.Text = "Volgen";
            this.btnVolgen.UseVisualStyleBackColor = true;
            this.btnVolgen.Click += new System.EventHandler(this.btnVolgen_Click);
            // 
            // lblProfielNaam
            // 
            this.lblProfielNaam.AutoSize = true;
            this.lblProfielNaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblProfielNaam.Location = new System.Drawing.Point(130, 38);
            this.lblProfielNaam.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
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
            this.pbPfp.Size = new System.Drawing.Size(125, 115);
            this.pbPfp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPfp.TabIndex = 0;
            this.pbPfp.TabStop = false;
            // 
            // tc
            // 
            this.tc.Controls.Add(this.tpLaatste);
            this.tc.Controls.Add(this.tpLiked);
            this.tc.Controls.Add(this.tpVolgt);
            this.tc.Controls.Add(this.tpBewerken);
            this.tc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tc.Location = new System.Drawing.Point(0, 94);
            this.tc.Margin = new System.Windows.Forms.Padding(5);
            this.tc.Name = "tc";
            this.tc.SelectedIndex = 0;
            this.tc.Size = new System.Drawing.Size(875, 496);
            this.tc.TabIndex = 1;
            // 
            // tpLaatste
            // 
            this.tpLaatste.Controls.Add(this.flpLaatste);
            this.tpLaatste.Location = new System.Drawing.Point(4, 25);
            this.tpLaatste.Margin = new System.Windows.Forms.Padding(0);
            this.tpLaatste.Name = "tpLaatste";
            this.tpLaatste.Size = new System.Drawing.Size(867, 467);
            this.tpLaatste.TabIndex = 0;
            this.tpLaatste.Text = "Laatste";
            this.tpLaatste.UseVisualStyleBackColor = true;
            // 
            // flpLaatste
            // 
            this.flpLaatste.AutoScroll = true;
            this.flpLaatste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpLaatste.Location = new System.Drawing.Point(0, 0);
            this.flpLaatste.Margin = new System.Windows.Forms.Padding(4);
            this.flpLaatste.Name = "flpLaatste";
            this.flpLaatste.Size = new System.Drawing.Size(867, 467);
            this.flpLaatste.TabIndex = 0;
            // 
            // tpLiked
            // 
            this.tpLiked.Controls.Add(this.flpGeliked);
            this.tpLiked.Location = new System.Drawing.Point(4, 25);
            this.tpLiked.Margin = new System.Windows.Forms.Padding(0);
            this.tpLiked.Name = "tpLiked";
            this.tpLiked.Size = new System.Drawing.Size(867, 467);
            this.tpLiked.TabIndex = 1;
            this.tpLiked.Text = "Geliked";
            this.tpLiked.UseVisualStyleBackColor = true;
            // 
            // flpGeliked
            // 
            this.flpGeliked.AutoScroll = true;
            this.flpGeliked.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpGeliked.Location = new System.Drawing.Point(0, 0);
            this.flpGeliked.Margin = new System.Windows.Forms.Padding(4);
            this.flpGeliked.Name = "flpGeliked";
            this.flpGeliked.Size = new System.Drawing.Size(867, 467);
            this.flpGeliked.TabIndex = 1;
            // 
            // tpVolgt
            // 
            this.tpVolgt.Controls.Add(this.flpVolgt);
            this.tpVolgt.Location = new System.Drawing.Point(4, 25);
            this.tpVolgt.Margin = new System.Windows.Forms.Padding(0);
            this.tpVolgt.Name = "tpVolgt";
            this.tpVolgt.Size = new System.Drawing.Size(867, 467);
            this.tpVolgt.TabIndex = 2;
            this.tpVolgt.Text = "Volgt";
            this.tpVolgt.UseVisualStyleBackColor = true;
            // 
            // flpVolgt
            // 
            this.flpVolgt.AutoScroll = true;
            this.flpVolgt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpVolgt.Location = new System.Drawing.Point(0, 0);
            this.flpVolgt.Margin = new System.Windows.Forms.Padding(5);
            this.flpVolgt.Name = "flpVolgt";
            this.flpVolgt.Size = new System.Drawing.Size(867, 467);
            this.flpVolgt.TabIndex = 1;
            // 
            // tpBewerken
            // 
            this.tpBewerken.Controls.Add(this.btnFoto);
            this.tpBewerken.Controls.Add(this.btnSave);
            this.tpBewerken.Controls.Add(this.label3);
            this.tpBewerken.Controls.Add(this.tbWachtwoord);
            this.tpBewerken.Controls.Add(this.label2);
            this.tpBewerken.Controls.Add(this.tbEmail);
            this.tpBewerken.Controls.Add(this.label1);
            this.tpBewerken.Controls.Add(this.tbNaam);
            this.tpBewerken.Controls.Add(this.pictureBox1);
            this.tpBewerken.Location = new System.Drawing.Point(4, 25);
            this.tpBewerken.Name = "tpBewerken";
            this.tpBewerken.Size = new System.Drawing.Size(867, 467);
            this.tpBewerken.TabIndex = 3;
            this.tpBewerken.Text = "Bewerken";
            this.tpBewerken.UseVisualStyleBackColor = true;
            this.tpBewerken.Click += new System.EventHandler(this.tpBewerken_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(13, 208);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(154, 37);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(173, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "wachtwoord";
            // 
            // tbWachtwoord
            // 
            this.tbWachtwoord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbWachtwoord.Location = new System.Drawing.Point(173, 212);
            this.tbWachtwoord.Name = "tbWachtwoord";
            this.tbWachtwoord.Size = new System.Drawing.Size(305, 30);
            this.tbWachtwoord.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(173, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Email";
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(173, 124);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(305, 30);
            this.tbEmail.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Naam";
            // 
            // tbNaam
            // 
            this.tbNaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNaam.Location = new System.Drawing.Point(173, 42);
            this.tbNaam.Name = "tbNaam";
            this.tbNaam.Size = new System.Drawing.Size(305, 30);
            this.tbNaam.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox1.Location = new System.Drawing.Point(13, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnFoto
            // 
            this.btnFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFoto.Location = new System.Drawing.Point(13, 165);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(154, 37);
            this.btnFoto.TabIndex = 10;
            this.btnFoto.Text = "Kies foto";
            this.btnFoto.UseVisualStyleBackColor = true;
            this.btnFoto.Click += new System.EventHandler(this.btnFoto_Click);
            // 
            // ProfielUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.tc);
            this.Controls.Add(this.pnlHeader);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ProfielUserControl";
            this.Size = new System.Drawing.Size(875, 590);
            this.Load += new System.EventHandler(this.ProfielUserControl_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPfp)).EndInit();
            this.tc.ResumeLayout(false);
            this.tpLaatste.ResumeLayout(false);
            this.tpLiked.ResumeLayout(false);
            this.tpVolgt.ResumeLayout(false);
            this.tpBewerken.ResumeLayout(false);
            this.tpBewerken.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.TabPage tpBewerken;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbWachtwoord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNaam;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnFoto;
    }
}
