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
            this.tpPersoonlijk = new System.Windows.Forms.TabPage();
            this.tpVolgend = new System.Windows.Forms.TabPage();
            this.tpLiked = new System.Windows.Forms.TabPage();
            this.flpHomePage = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfiel)).BeginInit();
            this.tcPaginas.SuspendLayout();
            this.tpHome.SuspendLayout();
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
            this.pnlHeader.Size = new System.Drawing.Size(1145, 80);
            this.pnlHeader.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtSearch.Location = new System.Drawing.Point(648, 22);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(0);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(130, 23);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // pbProfiel
            // 
            this.pbProfiel.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbProfiel.Location = new System.Drawing.Point(1080, 0);
            this.pbProfiel.Margin = new System.Windows.Forms.Padding(0);
            this.pbProfiel.Name = "pbProfiel";
            this.pbProfiel.Size = new System.Drawing.Size(65, 80);
            this.pbProfiel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbProfiel.TabIndex = 0;
            this.pbProfiel.TabStop = false;
            // 
            // tcPaginas
            // 
            this.tcPaginas.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tcPaginas.Controls.Add(this.tpHome);
            this.tcPaginas.Controls.Add(this.tpPersoonlijk);
            this.tcPaginas.Controls.Add(this.tpVolgend);
            this.tcPaginas.Controls.Add(this.tpLiked);
            this.tcPaginas.Controls.Add(this.tabPage1);
            this.tcPaginas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcPaginas.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tcPaginas.ItemSize = new System.Drawing.Size(30, 120);
            this.tcPaginas.Location = new System.Drawing.Point(0, 80);
            this.tcPaginas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tcPaginas.Multiline = true;
            this.tcPaginas.Name = "tcPaginas";
            this.tcPaginas.SelectedIndex = 0;
            this.tcPaginas.Size = new System.Drawing.Size(1145, 569);
            this.tcPaginas.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcPaginas.TabIndex = 1;
            this.tcPaginas.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tcPaginas_DrawItem);
            // 
            // tpHome
            // 
            this.tpHome.Controls.Add(this.flpHomePage);
            this.tpHome.Location = new System.Drawing.Point(124, 4);
            this.tpHome.Margin = new System.Windows.Forms.Padding(0);
            this.tpHome.Name = "tpHome";
            this.tpHome.Padding = new System.Windows.Forms.Padding(3);
            this.tpHome.Size = new System.Drawing.Size(731, 454);
            this.tpHome.TabIndex = 0;
            this.tpHome.Text = "Home";
            this.tpHome.UseVisualStyleBackColor = true;
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
            this.tpVolgend.Location = new System.Drawing.Point(124, 4);
            this.tpVolgend.Margin = new System.Windows.Forms.Padding(0);
            this.tpVolgend.Name = "tpVolgend";
            this.tpVolgend.Size = new System.Drawing.Size(731, 454);
            this.tpVolgend.TabIndex = 2;
            this.tpVolgend.Text = "Volgend";
            this.tpVolgend.UseVisualStyleBackColor = true;
            // 
            // tpLiked
            // 
            this.tpLiked.Location = new System.Drawing.Point(124, 4);
            this.tpLiked.Margin = new System.Windows.Forms.Padding(0);
            this.tpLiked.Name = "tpLiked";
            this.tpLiked.Size = new System.Drawing.Size(731, 454);
            this.tpLiked.TabIndex = 3;
            this.tpLiked.Text = "Liked";
            this.tpLiked.UseVisualStyleBackColor = true;
            // 
            // flpHomePage
            // 
            this.flpHomePage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpHomePage.Location = new System.Drawing.Point(0, 0);
            this.flpHomePage.Margin = new System.Windows.Forms.Padding(0);
            this.flpHomePage.Name = "flpHomePage";
            this.flpHomePage.Size = new System.Drawing.Size(731, 454);
            this.flpHomePage.TabIndex = 0;
            // 
            // Sociout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 649);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.PictureBox pbProfiel;
        private System.Windows.Forms.TabControl tcPaginas;
        private System.Windows.Forms.TabPage tpHome;
        private System.Windows.Forms.TabPage tpPersoonlijk;
        private System.Windows.Forms.TabPage tpVolgend;
        private System.Windows.Forms.TabPage tpLiked;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.FlowLayoutPanel flpHomePage;
    }
}