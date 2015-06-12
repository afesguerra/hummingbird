namespace Hummingbird_Nest
{
    partial class Main
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tabContainter = new System.Windows.Forms.TabControl();
            this.tabHum = new System.Windows.Forms.TabPage();
            this.tabListen = new System.Windows.Forms.TabPage();
            this.gbHumInfo = new System.Windows.Forms.GroupBox();
            this.gbHumPic = new System.Windows.Forms.GroupBox();
            this.tbHumInfo = new System.Windows.Forms.TextBox();
            this.tbHumPic = new System.Windows.Forms.TextBox();
            this.btHumInfo = new System.Windows.Forms.Button();
            this.btHumPic = new System.Windows.Forms.Button();
            this.btHum = new System.Windows.Forms.Button();
            this.gbListen = new System.Windows.Forms.GroupBox();
            this.btListenFile = new System.Windows.Forms.Button();
            this.tbListenFile = new System.Windows.Forms.TextBox();
            this.btListen = new System.Windows.Forms.Button();
            this.OFDListen = new System.Windows.Forms.OpenFileDialog();
            this.SFDListen = new System.Windows.Forms.SaveFileDialog();
            this.OFDHumInfo = new System.Windows.Forms.OpenFileDialog();
            this.OFDHumPic = new System.Windows.Forms.OpenFileDialog();
            this.SFDHum = new System.Windows.Forms.SaveFileDialog();
            this.tabContainter.SuspendLayout();
            this.tabHum.SuspendLayout();
            this.tabListen.SuspendLayout();
            this.gbHumInfo.SuspendLayout();
            this.gbHumPic.SuspendLayout();
            this.gbListen.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabContainter
            // 
            this.tabContainter.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabContainter.Controls.Add(this.tabHum);
            this.tabContainter.Controls.Add(this.tabListen);
            this.tabContainter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabContainter.HotTrack = true;
            this.tabContainter.Location = new System.Drawing.Point(0, 0);
            this.tabContainter.Name = "tabContainter";
            this.tabContainter.SelectedIndex = 0;
            this.tabContainter.Size = new System.Drawing.Size(373, 171);
            this.tabContainter.TabIndex = 0;
            // 
            // tabHum
            // 
            this.tabHum.Controls.Add(this.btHum);
            this.tabHum.Controls.Add(this.gbHumPic);
            this.tabHum.Controls.Add(this.gbHumInfo);
            this.tabHum.Location = new System.Drawing.Point(4, 25);
            this.tabHum.Name = "tabHum";
            this.tabHum.Padding = new System.Windows.Forms.Padding(3);
            this.tabHum.Size = new System.Drawing.Size(365, 142);
            this.tabHum.TabIndex = 0;
            this.tabHum.Text = "Hum";
            // 
            // tabListen
            // 
            this.tabListen.Controls.Add(this.btListen);
            this.tabListen.Controls.Add(this.gbListen);
            this.tabListen.Location = new System.Drawing.Point(4, 25);
            this.tabListen.Name = "tabListen";
            this.tabListen.Padding = new System.Windows.Forms.Padding(3);
            this.tabListen.Size = new System.Drawing.Size(365, 142);
            this.tabListen.TabIndex = 1;
            this.tabListen.Text = "Listen";
            // 
            // gbHumInfo
            // 
            this.gbHumInfo.Controls.Add(this.btHumInfo);
            this.gbHumInfo.Controls.Add(this.tbHumInfo);
            this.gbHumInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbHumInfo.Location = new System.Drawing.Point(3, 3);
            this.gbHumInfo.Name = "gbHumInfo";
            this.gbHumInfo.Size = new System.Drawing.Size(359, 50);
            this.gbHumInfo.TabIndex = 0;
            this.gbHumInfo.TabStop = false;
            this.gbHumInfo.Text = "File to hide";
            // 
            // gbHumPic
            // 
            this.gbHumPic.Controls.Add(this.btHumPic);
            this.gbHumPic.Controls.Add(this.tbHumPic);
            this.gbHumPic.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbHumPic.Location = new System.Drawing.Point(3, 53);
            this.gbHumPic.Name = "gbHumPic";
            this.gbHumPic.Size = new System.Drawing.Size(359, 49);
            this.gbHumPic.TabIndex = 1;
            this.gbHumPic.TabStop = false;
            this.gbHumPic.Text = "Picture to hide file in";
            // 
            // tbHumInfo
            // 
            this.tbHumInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbHumInfo.Location = new System.Drawing.Point(6, 19);
            this.tbHumInfo.Name = "tbHumInfo";
            this.tbHumInfo.ReadOnly = true;
            this.tbHumInfo.Size = new System.Drawing.Size(266, 20);
            this.tbHumInfo.TabIndex = 0;
            // 
            // tbHumPic
            // 
            this.tbHumPic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbHumPic.Location = new System.Drawing.Point(6, 19);
            this.tbHumPic.Name = "tbHumPic";
            this.tbHumPic.ReadOnly = true;
            this.tbHumPic.Size = new System.Drawing.Size(266, 20);
            this.tbHumPic.TabIndex = 0;
            // 
            // btHumInfo
            // 
            this.btHumInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btHumInfo.Location = new System.Drawing.Point(278, 17);
            this.btHumInfo.Name = "btHumInfo";
            this.btHumInfo.Size = new System.Drawing.Size(75, 23);
            this.btHumInfo.TabIndex = 1;
            this.btHumInfo.Text = "Browse...";
            this.btHumInfo.UseVisualStyleBackColor = true;
            this.btHumInfo.Click += new System.EventHandler(this.btHumInfo_Click);
            // 
            // btHumPic
            // 
            this.btHumPic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btHumPic.Location = new System.Drawing.Point(278, 17);
            this.btHumPic.Name = "btHumPic";
            this.btHumPic.Size = new System.Drawing.Size(75, 23);
            this.btHumPic.TabIndex = 1;
            this.btHumPic.Text = "Browse...";
            this.btHumPic.UseVisualStyleBackColor = true;
            this.btHumPic.Click += new System.EventHandler(this.btHumPic_Click);
            // 
            // btHum
            // 
            this.btHum.Location = new System.Drawing.Point(147, 108);
            this.btHum.Name = "btHum";
            this.btHum.Size = new System.Drawing.Size(75, 23);
            this.btHum.TabIndex = 2;
            this.btHum.Text = "Hum!!!";
            this.btHum.UseVisualStyleBackColor = true;
            this.btHum.Click += new System.EventHandler(this.btHum_Click);
            // 
            // gbListen
            // 
            this.gbListen.Controls.Add(this.btListenFile);
            this.gbListen.Controls.Add(this.tbListenFile);
            this.gbListen.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbListen.Location = new System.Drawing.Point(3, 3);
            this.gbListen.Name = "gbListen";
            this.gbListen.Size = new System.Drawing.Size(359, 50);
            this.gbListen.TabIndex = 1;
            this.gbListen.TabStop = false;
            this.gbListen.Text = "Select file";
            // 
            // btListenFile
            // 
            this.btListenFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btListenFile.Location = new System.Drawing.Point(278, 17);
            this.btListenFile.Name = "btListenFile";
            this.btListenFile.Size = new System.Drawing.Size(75, 23);
            this.btListenFile.TabIndex = 1;
            this.btListenFile.Text = "Browse...";
            this.btListenFile.UseVisualStyleBackColor = true;
            this.btListenFile.Click += new System.EventHandler(this.btListenFile_Click);
            // 
            // tbListenFile
            // 
            this.tbListenFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbListenFile.Location = new System.Drawing.Point(6, 19);
            this.tbListenFile.Name = "tbListenFile";
            this.tbListenFile.ReadOnly = true;
            this.tbListenFile.Size = new System.Drawing.Size(266, 20);
            this.tbListenFile.TabIndex = 0;
            // 
            // btListen
            // 
            this.btListen.Location = new System.Drawing.Point(145, 59);
            this.btListen.Name = "btListen";
            this.btListen.Size = new System.Drawing.Size(75, 23);
            this.btListen.TabIndex = 2;
            this.btListen.Text = "Listen!!!";
            this.btListen.UseVisualStyleBackColor = true;
            this.btListen.Click += new System.EventHandler(this.btListen_Click);
            // 
            // OFDListen
            // 
            this.OFDListen.Filter = "Bitmap|*.bmp";
            // 
            // SFDListen
            // 
            this.SFDListen.Filter = "All files|*.*";
            // 
            // OFDHumInfo
            // 
            this.OFDHumInfo.Filter = "All files|*.*";
            // 
            // OFDHumPic
            // 
            this.OFDHumPic.Filter = "Bitmap|*.bmp";
            // 
            // SFDHum
            // 
            this.SFDHum.Filter = "Bitmap|*.bmp";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 171);
            this.Controls.Add(this.tabContainter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hummingbird";
            this.tabContainter.ResumeLayout(false);
            this.tabHum.ResumeLayout(false);
            this.tabListen.ResumeLayout(false);
            this.gbHumInfo.ResumeLayout(false);
            this.gbHumInfo.PerformLayout();
            this.gbHumPic.ResumeLayout(false);
            this.gbHumPic.PerformLayout();
            this.gbListen.ResumeLayout(false);
            this.gbListen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabContainter;
        private System.Windows.Forms.TabPage tabHum;
        private System.Windows.Forms.TabPage tabListen;
        private System.Windows.Forms.GroupBox gbHumPic;
        private System.Windows.Forms.Button btHumPic;
        private System.Windows.Forms.TextBox tbHumPic;
        private System.Windows.Forms.GroupBox gbHumInfo;
        private System.Windows.Forms.Button btHumInfo;
        private System.Windows.Forms.TextBox tbHumInfo;
        private System.Windows.Forms.Button btHum;
        private System.Windows.Forms.Button btListen;
        private System.Windows.Forms.GroupBox gbListen;
        private System.Windows.Forms.Button btListenFile;
        private System.Windows.Forms.TextBox tbListenFile;
        private System.Windows.Forms.OpenFileDialog OFDListen;
        private System.Windows.Forms.SaveFileDialog SFDListen;
        private System.Windows.Forms.OpenFileDialog OFDHumInfo;
        private System.Windows.Forms.OpenFileDialog OFDHumPic;
        private System.Windows.Forms.SaveFileDialog SFDHum;
    }
}

