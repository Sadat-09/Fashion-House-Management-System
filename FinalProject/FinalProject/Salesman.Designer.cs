namespace FinalProject
{
    partial class Salesman
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Salesman));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogOut = new Guna.UI2.WinForms.Guna2Button();
            this.btnSellClothes = new Guna.UI2.WinForms.Guna2Button();
            this.btnModifyClothes = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddClothes = new Guna.UI2.WinForms.Guna2Button();
            this.btnViewClothes = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.uC_S_SellCloth1 = new FinalProject.SalesmanUC.UC_S_SellCloth();
            this.uC_S_ModifyCloth1 = new FinalProject.SalesmanUC.UC_S_ModifyCloth();
            this.uC_S_ViewClothes1 = new FinalProject.SalesmanUC.UC_S_ViewClothes();
            this.uC_S_AddClothes1 = new FinalProject.SalesmanUC.UC_S_AddClothes();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnSellClothes);
            this.panel1.Controls.Add(this.btnModifyClothes);
            this.panel1.Controls.Add(this.btnAddClothes);
            this.panel1.Controls.Add(this.btnViewClothes);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 769);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 49);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 181);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogOut
            // 
            this.btnLogOut.AutoRoundedCorners = true;
            this.btnLogOut.BackColor = System.Drawing.Color.MistyRose;
            this.btnLogOut.BorderRadius = 21;
            this.btnLogOut.BorderThickness = 1;
            this.btnLogOut.CheckedState.Parent = this.btnLogOut;
            this.btnLogOut.CustomImages.Parent = this.btnLogOut;
            this.btnLogOut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btnLogOut.HoverState.FillColor = System.Drawing.Color.White;
            this.btnLogOut.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnLogOut.HoverState.Parent = this.btnLogOut;
            this.btnLogOut.Location = new System.Drawing.Point(45, 540);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.ShadowDecoration.Parent = this.btnLogOut;
            this.btnLogOut.Size = new System.Drawing.Size(179, 44);
            this.btnLogOut.TabIndex = 7;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnSellClothes
            // 
            this.btnSellClothes.AutoRoundedCorners = true;
            this.btnSellClothes.BackColor = System.Drawing.Color.MistyRose;
            this.btnSellClothes.BorderRadius = 21;
            this.btnSellClothes.BorderThickness = 1;
            this.btnSellClothes.CheckedState.Parent = this.btnSellClothes;
            this.btnSellClothes.CustomImages.Parent = this.btnSellClothes;
            this.btnSellClothes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSellClothes.ForeColor = System.Drawing.Color.White;
            this.btnSellClothes.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btnSellClothes.HoverState.FillColor = System.Drawing.Color.White;
            this.btnSellClothes.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnSellClothes.HoverState.Parent = this.btnSellClothes;
            this.btnSellClothes.Location = new System.Drawing.Point(45, 471);
            this.btnSellClothes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSellClothes.Name = "btnSellClothes";
            this.btnSellClothes.ShadowDecoration.Parent = this.btnSellClothes;
            this.btnSellClothes.Size = new System.Drawing.Size(179, 44);
            this.btnSellClothes.TabIndex = 6;
            this.btnSellClothes.Text = "Sell Clothes ";
            this.btnSellClothes.Click += new System.EventHandler(this.btnSellClothes_Click);
            // 
            // btnModifyClothes
            // 
            this.btnModifyClothes.AutoRoundedCorners = true;
            this.btnModifyClothes.BackColor = System.Drawing.Color.MistyRose;
            this.btnModifyClothes.BorderRadius = 21;
            this.btnModifyClothes.BorderThickness = 1;
            this.btnModifyClothes.CheckedState.Parent = this.btnModifyClothes;
            this.btnModifyClothes.CustomImages.Parent = this.btnModifyClothes;
            this.btnModifyClothes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnModifyClothes.ForeColor = System.Drawing.Color.White;
            this.btnModifyClothes.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btnModifyClothes.HoverState.FillColor = System.Drawing.Color.White;
            this.btnModifyClothes.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnModifyClothes.HoverState.Parent = this.btnModifyClothes;
            this.btnModifyClothes.Location = new System.Drawing.Point(45, 400);
            this.btnModifyClothes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModifyClothes.Name = "btnModifyClothes";
            this.btnModifyClothes.ShadowDecoration.Parent = this.btnModifyClothes;
            this.btnModifyClothes.Size = new System.Drawing.Size(179, 44);
            this.btnModifyClothes.TabIndex = 5;
            this.btnModifyClothes.Text = "Modify Clothes";
            this.btnModifyClothes.Click += new System.EventHandler(this.btnModifyClothes_Click);
            // 
            // btnAddClothes
            // 
            this.btnAddClothes.AutoRoundedCorners = true;
            this.btnAddClothes.BackColor = System.Drawing.Color.MistyRose;
            this.btnAddClothes.BorderRadius = 21;
            this.btnAddClothes.BorderThickness = 1;
            this.btnAddClothes.CheckedState.Parent = this.btnAddClothes;
            this.btnAddClothes.CustomImages.Parent = this.btnAddClothes;
            this.btnAddClothes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddClothes.ForeColor = System.Drawing.Color.White;
            this.btnAddClothes.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btnAddClothes.HoverState.FillColor = System.Drawing.Color.White;
            this.btnAddClothes.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnAddClothes.HoverState.Parent = this.btnAddClothes;
            this.btnAddClothes.Location = new System.Drawing.Point(45, 260);
            this.btnAddClothes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddClothes.Name = "btnAddClothes";
            this.btnAddClothes.ShadowDecoration.Parent = this.btnAddClothes;
            this.btnAddClothes.Size = new System.Drawing.Size(179, 44);
            this.btnAddClothes.TabIndex = 3;
            this.btnAddClothes.Text = "Add Clothes";
            this.btnAddClothes.Click += new System.EventHandler(this.btnAddClothes_Click);
            // 
            // btnViewClothes
            // 
            this.btnViewClothes.AutoRoundedCorners = true;
            this.btnViewClothes.BackColor = System.Drawing.Color.MistyRose;
            this.btnViewClothes.BorderRadius = 21;
            this.btnViewClothes.BorderThickness = 1;
            this.btnViewClothes.CheckedState.Parent = this.btnViewClothes;
            this.btnViewClothes.CustomImages.Parent = this.btnViewClothes;
            this.btnViewClothes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnViewClothes.ForeColor = System.Drawing.Color.White;
            this.btnViewClothes.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btnViewClothes.HoverState.FillColor = System.Drawing.Color.White;
            this.btnViewClothes.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnViewClothes.HoverState.Parent = this.btnViewClothes;
            this.btnViewClothes.Location = new System.Drawing.Point(45, 329);
            this.btnViewClothes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnViewClothes.Name = "btnViewClothes";
            this.btnViewClothes.ShadowDecoration.Parent = this.btnViewClothes;
            this.btnViewClothes.Size = new System.Drawing.Size(179, 44);
            this.btnViewClothes.TabIndex = 1;
            this.btnViewClothes.Text = "View Clothes";
            this.btnViewClothes.Click += new System.EventHandler(this.btnViewClothes_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.uC_S_SellCloth1);
            this.panel2.Controls.Add(this.uC_S_ModifyCloth1);
            this.panel2.Controls.Add(this.uC_S_ViewClothes1);
            this.panel2.Controls.Add(this.uC_S_AddClothes1);
            this.panel2.Location = new System.Drawing.Point(271, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1110, 769);
            this.panel2.TabIndex = 2;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this.panel1;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this.panel2;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.TargetControl = this.panel2;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.TargetControl = this.panel2;
            // 
            // guna2Elipse5
            // 
            this.guna2Elipse5.TargetControl = this.panel2;
            // 
            // uC_S_SellCloth1
            // 
            this.uC_S_SellCloth1.BackColor = System.Drawing.Color.White;
            this.uC_S_SellCloth1.Location = new System.Drawing.Point(0, 0);
            this.uC_S_SellCloth1.Name = "uC_S_SellCloth1";
            this.uC_S_SellCloth1.Size = new System.Drawing.Size(1110, 769);
            this.uC_S_SellCloth1.TabIndex = 3;
            // 
            // uC_S_ModifyCloth1
            // 
            this.uC_S_ModifyCloth1.BackColor = System.Drawing.Color.White;
            this.uC_S_ModifyCloth1.Location = new System.Drawing.Point(0, 0);
            this.uC_S_ModifyCloth1.Name = "uC_S_ModifyCloth1";
            this.uC_S_ModifyCloth1.Size = new System.Drawing.Size(1110, 769);
            this.uC_S_ModifyCloth1.TabIndex = 2;
            // 
            // uC_S_ViewClothes1
            // 
            this.uC_S_ViewClothes1.BackColor = System.Drawing.Color.White;
            this.uC_S_ViewClothes1.Location = new System.Drawing.Point(-3, 0);
            this.uC_S_ViewClothes1.Name = "uC_S_ViewClothes1";
            this.uC_S_ViewClothes1.Size = new System.Drawing.Size(1110, 769);
            this.uC_S_ViewClothes1.TabIndex = 1;
            // 
            // uC_S_AddClothes1
            // 
            this.uC_S_AddClothes1.Location = new System.Drawing.Point(0, 0);
            this.uC_S_AddClothes1.Name = "uC_S_AddClothes1";
            this.uC_S_AddClothes1.Size = new System.Drawing.Size(1110, 769);
            this.uC_S_AddClothes1.TabIndex = 0;
            // 
            // Salesman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 768);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Salesman";
            this.Text = "Salesman";
            this.Load += new System.EventHandler(this.Salesman_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnLogOut;
        private Guna.UI2.WinForms.Guna2Button btnSellClothes;
        private Guna.UI2.WinForms.Guna2Button btnModifyClothes;
        private Guna.UI2.WinForms.Guna2Button btnAddClothes;
        private Guna.UI2.WinForms.Guna2Button btnViewClothes;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private SalesmanUC.UC_S_AddClothes uC_S_AddClothes1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private SalesmanUC.UC_S_ViewClothes uC_S_ViewClothes1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private SalesmanUC.UC_S_ModifyCloth uC_S_ModifyCloth1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private SalesmanUC.UC_S_SellCloth uC_S_SellCloth1;
    }
}