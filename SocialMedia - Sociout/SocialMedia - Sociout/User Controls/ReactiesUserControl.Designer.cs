namespace SocialMedia___Sociout.User_Controls
{
    partial class ReactiesUserControl
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpReacties = new System.Windows.Forms.TabPage();
            this.tpAddReactie = new System.Windows.Forms.TabPage();
            this.flpReacties = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpReacties.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(549, 435);
            this.splitContainer1.SplitterDistance = 182;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpReacties);
            this.tabControl1.Controls.Add(this.tpAddReactie);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(549, 252);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tpReacties
            // 
            this.tpReacties.Controls.Add(this.flpReacties);
            this.tpReacties.Location = new System.Drawing.Point(4, 22);
            this.tpReacties.Margin = new System.Windows.Forms.Padding(0);
            this.tpReacties.Name = "tpReacties";
            this.tpReacties.Size = new System.Drawing.Size(541, 226);
            this.tpReacties.TabIndex = 0;
            this.tpReacties.Text = "Reacties";
            this.tpReacties.UseVisualStyleBackColor = true;
            // 
            // tpAddReactie
            // 
            this.tpAddReactie.Location = new System.Drawing.Point(4, 22);
            this.tpAddReactie.Margin = new System.Windows.Forms.Padding(0);
            this.tpAddReactie.Name = "tpAddReactie";
            this.tpAddReactie.Size = new System.Drawing.Size(541, 226);
            this.tpAddReactie.TabIndex = 1;
            this.tpAddReactie.Text = "Aanmaken";
            this.tpAddReactie.UseVisualStyleBackColor = true;
            // 
            // flpReacties
            // 
            this.flpReacties.AutoScroll = true;
            this.flpReacties.AutoSize = true;
            this.flpReacties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpReacties.Location = new System.Drawing.Point(0, 0);
            this.flpReacties.Margin = new System.Windows.Forms.Padding(0);
            this.flpReacties.Name = "flpReacties";
            this.flpReacties.Size = new System.Drawing.Size(541, 226);
            this.flpReacties.TabIndex = 0;
            // 
            // ReactiesUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ReactiesUserControl";
            this.Size = new System.Drawing.Size(549, 435);
            this.Load += new System.EventHandler(this.ReactiesUserControl_Load);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tpReacties.ResumeLayout(false);
            this.tpReacties.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpReacties;
        private System.Windows.Forms.FlowLayoutPanel flpReacties;
        private System.Windows.Forms.TabPage tpAddReactie;
    }
}
