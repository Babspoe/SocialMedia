namespace SocialMedia___Sociout
{
    partial class Sociout
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pbProfiel = new System.Windows.Forms.PictureBox();
            this.tcPaginas = new System.Windows.Forms.TabControl();
            this.tpHome = new System.Windows.Forms.TabPage();
            this.flpHomePage = new System.Windows.Forms.FlowLayoutPanel();
            this.tpPersoonlijk = new System.Windows.Forms.TabPage();
            this.tpVolgend = new System.Windows.Forms.TabPage();
            this.flpVolgend = new System.Windows.Forms.FlowLayoutPanel();
            this.tpZoeken = new System.Windows.Forms.TabPage();
            this.flpGebruikersZoeken = new System.Windows.Forms.FlowLayoutPanel();
            this.tpBerichtAanmaken = new System.Windows.Forms.TabPage();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfiel)).BeginInit();
            this.tcPaginas.SuspendLayout();
            this.tpHome.SuspendLayout();
            this.tpVolgend.SuspendLayout();
            this.tpZoeken.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.txtSearch);
            this.pnlHeader.Controls.Add(this.pbProfiel);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(859, 65);
            this.pnlHeader.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtSearch.Location = new System.Drawing.Point(614, 22);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(0);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(166, 23);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // pbProfiel
            // 
            this.pbProfiel.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbProfiel.Location = new System.Drawing.Point(794, 0);
            this.pbProfiel.Margin = new System.Windows.Forms.Padding(0);
            this.pbProfiel.Name = "pbProfiel";
            this.pbProfiel.Size = new System.Drawing.Size(65, 65);
            this.pbProfiel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProfiel.TabIndex = 0;
            this.pbProfiel.TabStop = false;
            // 
            // tcPaginas
            // 
            this.tcPaginas.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tcPaginas.Controls.Add(this.tpHome);
            this.tcPaginas.Controls.Add(this.tpPersoonlijk);
            this.tcPaginas.Controls.Add(this.tpVolgend);
            this.tcPaginas.Controls.Add(this.tpZoeken);
            this.tcPaginas.Controls.Add(this.tpBerichtAanmaken);
            this.tcPaginas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcPaginas.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tcPaginas.ItemSize = new System.Drawing.Size(30, 120);
            this.tcPaginas.Location = new System.Drawing.Point(0, 65);
            this.tcPaginas.Multiline = true;
            this.tcPaginas.Name = "tcPaginas";
            this.tcPaginas.SelectedIndex = 0;
            this.tcPaginas.Size = new System.Drawing.Size(859, 462);
            this.tcPaginas.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcPaginas.TabIndex = 1;
            this.tcPaginas.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tcPaginas_DrawItem);
            this.tcPaginas.SelectedIndexChanged += new System.EventHandler(this.tabopenen);
            // 
            // tpHome
            // 
            this.tpHome.Controls.Add(this.flpHomePage);
            this.tpHome.Location = new System.Drawing.Point(124, 4);
            this.tpHome.Margin = new System.Windows.Forms.Padding(0);
            this.tpHome.Name = "tpHome";
            this.tpHome.Padding = new System.Windows.Forms.Padding(2);
            this.tpHome.Size = new System.Drawing.Size(731, 454);
            this.tpHome.TabIndex = 0;
            this.tpHome.Text = "Home";
            this.tpHome.UseVisualStyleBackColor = true;
            // 
            // flpHomePage
            // 
            this.flpHomePage.AutoScroll = true;
            this.flpHomePage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpHomePage.Location = new System.Drawing.Point(2, 2);
            this.flpHomePage.Margin = new System.Windows.Forms.Padding(0);
            this.flpHomePage.Name = "flpHomePage";
            this.flpHomePage.Size = new System.Drawing.Size(727, 450);
            this.flpHomePage.TabIndex = 0;
            // 
            // tpPersoonlijk
            // 
            this.tpPersoonlijk.Location = new System.Drawing.Point(124, 4);
            this.tpPersoonlijk.Margin = new System.Windows.Forms.Padding(0);
            this.tpPersoonlijk.Name = "tpPersoonlijk";
            this.tpPersoonlijk.Size = new System.Drawing.Size(731, 454);
            this.tpPersoonlijk.TabIndex = 1;
            this.tpPersoonlijk.Text = "Mijn Pagina";
            this.tpPersoonlijk.UseVisualStyleBackColor = true;
            // 
            // tpVolgend
            // 
            this.tpVolgend.Controls.Add(this.flpVolgend);
            this.tpVolgend.Location = new System.Drawing.Point(124, 4);
            this.tpVolgend.Margin = new System.Windows.Forms.Padding(0);
            this.tpVolgend.Name = "tpVolgend";
            this.tpVolgend.Size = new System.Drawing.Size(731, 454);
            this.tpVolgend.TabIndex = 2;
            this.tpVolgend.Text = "Volgend";
            this.tpVolgend.UseVisualStyleBackColor = true;
            // 
            // flpVolgend
            // 
            this.flpVolgend.AutoScroll = true;
            this.flpVolgend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpVolgend.Location = new System.Drawing.Point(0, 0);
            this.flpVolgend.Name = "flpVolgend";
            this.flpVolgend.Size = new System.Drawing.Size(731, 454);
            this.flpVolgend.TabIndex = 0;
            // 
            // tpZoeken
            // 
            this.tpZoeken.Controls.Add(this.flpGebruikersZoeken);
            this.tpZoeken.Location = new System.Drawing.Point(124, 4);
            this.tpZoeken.Margin = new System.Windows.Forms.Padding(2);
            this.tpZoeken.Name = "tpZoeken";
            this.tpZoeken.Size = new System.Drawing.Size(731, 454);
            this.tpZoeken.TabIndex = 4;
            this.tpZoeken.Text = "Zoeken";
            this.tpZoeken.UseVisualStyleBackColor = true;
            // 
            // flpGebruikersZoeken
            // 
            this.flpGebruikersZoeken.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpGebruikersZoeken.Location = new System.Drawing.Point(0, 0);
            this.flpGebruikersZoeken.Margin = new System.Windows.Forms.Padding(2);
            this.flpGebruikersZoeken.Name = "flpGebruikersZoeken";
            this.flpGebruikersZoeken.Size = new System.Drawing.Size(731, 454);
            this.flpGebruikersZoeken.TabIndex = 0;
            // 
            // tpBerichtAanmaken
            // 
            this.tpBerichtAanmaken.Location = new System.Drawing.Point(124, 4);
            this.tpBerichtAanmaken.Name = "tpBerichtAanmaken";
            this.tpBerichtAanmaken.Padding = new System.Windows.Forms.Padding(3);
            this.tpBerichtAanmaken.Size = new System.Drawing.Size(731, 454);
            this.tpBerichtAanmaken.TabIndex = 5;
            this.tpBerichtAanmaken.Text = "Nieuw Bericht";
            this.tpBerichtAanmaken.UseVisualStyleBackColor = true;
            // 
            // Sociout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 527);
            this.Controls.Add(this.tcPaginas);
            this.Controls.Add(this.pnlHeader);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Sociout";
            this.Text = "Sociout";
            this.Load += new System.EventHandler(this.Sociout_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfiel)).EndInit();
            this.tcPaginas.ResumeLayout(false);
            this.tpHome.ResumeLayout(false);
            this.tpVolgend.ResumeLayout(false);
            this.tpZoeken.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.PictureBox pbProfiel;
        private System.Windows.Forms.TabControl tcPaginas;
        private System.Windows.Forms.TabPage tpHome;
        private System.Windows.Forms.TabPage tpPersoonlijk;
        private System.Windows.Forms.TabPage tpVolgend;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.FlowLayoutPanel flpHomePage;
        private System.Windows.Forms.TabPage tpZoeken;
        private System.Windows.Forms.FlowLayoutPanel flpGebruikersZoeken;
        private System.Windows.Forms.TabPage tpBerichtAanmaken;
        private System.Windows.Forms.FlowLayoutPanel flpVolgend;
    }
}