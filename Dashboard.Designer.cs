namespace brew_s_ko
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel3 = new System.Windows.Forms.Panel();
            this.HomeBtn = new System.Windows.Forms.PictureBox();
            this.OrderBtn = new System.Windows.Forms.PictureBox();
            this.InventoryBtn = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.HomeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.PeachPuff;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(132, 48);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1914, 1014);
            this.panel3.TabIndex = 0;
            // 
            // HomeBtn
            // 
            this.HomeBtn.Image = ((System.Drawing.Image)(resources.GetObject("HomeBtn.Image")));
            this.HomeBtn.Location = new System.Drawing.Point(-1, 167);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(134, 119);
            this.HomeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HomeBtn.TabIndex = 1;
            this.HomeBtn.TabStop = false;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // OrderBtn
            // 
            this.OrderBtn.Image = ((System.Drawing.Image)(resources.GetObject("OrderBtn.Image")));
            this.OrderBtn.Location = new System.Drawing.Point(-1, 367);
            this.OrderBtn.Name = "OrderBtn";
            this.OrderBtn.Size = new System.Drawing.Size(134, 119);
            this.OrderBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.OrderBtn.TabIndex = 2;
            this.OrderBtn.TabStop = false;
            this.OrderBtn.Click += new System.EventHandler(this.OrderBtn_Click);
            // 
            // InventoryBtn
            // 
            this.InventoryBtn.Image = ((System.Drawing.Image)(resources.GetObject("InventoryBtn.Image")));
            this.InventoryBtn.Location = new System.Drawing.Point(-1, 563);
            this.InventoryBtn.Name = "InventoryBtn";
            this.InventoryBtn.Size = new System.Drawing.Size(134, 119);
            this.InventoryBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.InventoryBtn.TabIndex = 0;
            this.InventoryBtn.TabStop = false;
            this.InventoryBtn.Click += new System.EventHandler(this.InventoryBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "HOME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Perpetua", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(25, 489);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "ORDER";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Perpetua", 11F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 685);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "INVENTORY";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1942, 1102);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InventoryBtn);
            this.Controls.Add(this.OrderBtn);
            this.Controls.Add(this.HomeBtn);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HomeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox HomeBtn;
        private System.Windows.Forms.PictureBox OrderBtn;
        private System.Windows.Forms.PictureBox InventoryBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

