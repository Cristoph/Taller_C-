namespace T_Lovendo
{
    partial class FormMain
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.pictureBox_logo = new System.Windows.Forms.PictureBox();
            this.tabControl_Main = new System.Windows.Forms.TabControl();
            this.tabPage_Products = new System.Windows.Forms.TabPage();
            this.tabPage_Providers = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage_Ranking = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.StatusLabel_DateTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusLabel_DBConnect = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataGridView_Product = new System.Windows.Forms.DataGridView();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusLabel_status = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            this.tabControl_Main.SuspendLayout();
            this.tabPage_Products.SuspendLayout();
            this.tabPage_Providers.SuspendLayout();
            this.tabPage_Ranking.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Product)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_logo
            // 
            this.pictureBox_logo.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_logo.ErrorImage")));
            this.pictureBox_logo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_logo.Image")));
            this.pictureBox_logo.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_logo.InitialImage")));
            this.pictureBox_logo.Location = new System.Drawing.Point(2, 2);
            this.pictureBox_logo.Name = "pictureBox_logo";
            this.pictureBox_logo.Size = new System.Drawing.Size(230, 57);
            this.pictureBox_logo.TabIndex = 1;
            this.pictureBox_logo.TabStop = false;
            // 
            // tabControl_Main
            // 
            this.tabControl_Main.Controls.Add(this.tabPage_Products);
            this.tabControl_Main.Controls.Add(this.tabPage_Providers);
            this.tabControl_Main.Controls.Add(this.tabPage_Ranking);
            this.tabControl_Main.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl_Main.Location = new System.Drawing.Point(2, 33);
            this.tabControl_Main.Name = "tabControl_Main";
            this.tabControl_Main.Padding = new System.Drawing.Point(20, 4);
            this.tabControl_Main.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl_Main.RightToLeftLayout = true;
            this.tabControl_Main.SelectedIndex = 0;
            this.tabControl_Main.Size = new System.Drawing.Size(1180, 704);
            this.tabControl_Main.TabIndex = 1;
            // 
            // tabPage_Products
            // 
            this.tabPage_Products.Controls.Add(this.dataGridView_Product);
            this.tabPage_Products.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage_Products.Location = new System.Drawing.Point(4, 32);
            this.tabPage_Products.Name = "tabPage_Products";
            this.tabPage_Products.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Products.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabPage_Products.Size = new System.Drawing.Size(1172, 668);
            this.tabPage_Products.TabIndex = 1;
            this.tabPage_Products.Text = "Productos";
            this.tabPage_Products.UseVisualStyleBackColor = true;
            // 
            // tabPage_Providers
            // 
            this.tabPage_Providers.Controls.Add(this.label1);
            this.tabPage_Providers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage_Providers.Location = new System.Drawing.Point(4, 32);
            this.tabPage_Providers.Name = "tabPage_Providers";
            this.tabPage_Providers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Providers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabPage_Providers.Size = new System.Drawing.Size(1172, 668);
            this.tabPage_Providers.TabIndex = 2;
            this.tabPage_Providers.Text = "Proveedores";
            this.tabPage_Providers.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // tabPage_Ranking
            // 
            this.tabPage_Ranking.Controls.Add(this.groupBox1);
            this.tabPage_Ranking.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage_Ranking.Location = new System.Drawing.Point(4, 32);
            this.tabPage_Ranking.Name = "tabPage_Ranking";
            this.tabPage_Ranking.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Ranking.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabPage_Ranking.Size = new System.Drawing.Size(1172, 668);
            this.tabPage_Ranking.TabIndex = 0;
            this.tabPage_Ranking.Text = "Ranking";
            this.tabPage_Ranking.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(5, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(619, 588);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(601, 480);
            this.dataGridView1.TabIndex = 0;
            // 
            // StatusLabel_DateTime
            // 
            this.StatusLabel_DateTime.Name = "StatusLabel_DateTime";
            this.StatusLabel_DateTime.Size = new System.Drawing.Size(123, 17);
            this.StatusLabel_DateTime.Text = "StatusLabel_DateTime";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel_DateTime,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.StatusLabel_DBConnect,
            this.toolStripStatusLabel3,
            this.StatusLabel_status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 739);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusStrip1.Size = new System.Drawing.Size(1184, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(13, 17);
            this.toolStripStatusLabel1.Text = "  ";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(802, 17);
            this.toolStripStatusLabel2.Text = resources.GetString("toolStripStatusLabel2.Text");
            // 
            // StatusLabel_DBConnect
            // 
            this.StatusLabel_DBConnect.Name = "StatusLabel_DBConnect";
            this.StatusLabel_DBConnect.Size = new System.Drawing.Size(70, 17);
            this.StatusLabel_DBConnect.Text = "DBConnect:";
            // 
            // dataGridView_Product
            // 
            this.dataGridView_Product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Product.Location = new System.Drawing.Point(7, 24);
            this.dataGridView_Product.Name = "dataGridView_Product";
            this.dataGridView_Product.Size = new System.Drawing.Size(821, 638);
            this.dataGridView_Product.TabIndex = 0;
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(0, 17);
            // 
            // StatusLabel_status
            // 
            this.StatusLabel_status.Name = "StatusLabel_status";
            this.StatusLabel_status.Size = new System.Drawing.Size(22, 17);
            this.StatusLabel_status.Text = "???";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.pictureBox_logo);
            this.Controls.Add(this.tabControl_Main);
            this.Controls.Add(this.statusStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock Control";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).EndInit();
            this.tabControl_Main.ResumeLayout(false);
            this.tabPage_Products.ResumeLayout(false);
            this.tabPage_Providers.ResumeLayout(false);
            this.tabPage_Providers.PerformLayout();
            this.tabPage_Ranking.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Product)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_logo;
        private System.Windows.Forms.TabControl tabControl_Main;
        private System.Windows.Forms.TabPage tabPage_Ranking;
        private System.Windows.Forms.TabPage tabPage_Products;
        private System.Windows.Forms.TabPage tabPage_Providers;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel_DateTime;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel_DBConnect;
        private System.Windows.Forms.DataGridView dataGridView_Product;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel_status;
    }
}

