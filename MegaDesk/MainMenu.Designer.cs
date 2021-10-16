
namespace MegaDesk
{
    partial class MainMenu
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
            this.megaLabel = new System.Windows.Forms.Label();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.exitBtn = new System.Windows.Forms.Button();
            this.panelMediaSubmenu = new System.Windows.Forms.Panel();
            this.searchQuoteBtn = new System.Windows.Forms.Button();
            this.viewQuoteBtn = new System.Windows.Forms.Button();
            this.addQuoteBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelSideMenu.SuspendLayout();
            this.panelMediaSubmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // megaLabel
            // 
            this.megaLabel.AutoSize = true;
            this.megaLabel.BackColor = System.Drawing.Color.Transparent;
            this.megaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 55.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.megaLabel.ForeColor = System.Drawing.Color.White;
            this.megaLabel.Location = new System.Drawing.Point(403, 96);
            this.megaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.megaLabel.Name = "megaLabel";
            this.megaLabel.Size = new System.Drawing.Size(501, 107);
            this.megaLabel.TabIndex = 6;
            this.megaLabel.Text = "MegaDesk";
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelSideMenu.Controls.Add(this.exitBtn);
            this.panelSideMenu.Controls.Add(this.panelMediaSubmenu);
            this.panelSideMenu.Controls.Add(this.button1);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(251, 525);
            this.panelSideMenu.TabIndex = 7;
            // 
            // exitBtn
            // 
            this.exitBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.exitBtn.Location = new System.Drawing.Point(0, 359);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.exitBtn.Size = new System.Drawing.Size(251, 46);
            this.exitBtn.TabIndex = 3;
            this.exitBtn.Text = "&Exit";
            this.exitBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click_1);
            // 
            // panelMediaSubmenu
            // 
            this.panelMediaSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelMediaSubmenu.Controls.Add(this.searchQuoteBtn);
            this.panelMediaSubmenu.Controls.Add(this.viewQuoteBtn);
            this.panelMediaSubmenu.Controls.Add(this.addQuoteBtn);
            this.panelMediaSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMediaSubmenu.Location = new System.Drawing.Point(0, 176);
            this.panelMediaSubmenu.Name = "panelMediaSubmenu";
            this.panelMediaSubmenu.Size = new System.Drawing.Size(251, 183);
            this.panelMediaSubmenu.TabIndex = 2;
            // 
            // searchQuoteBtn
            // 
            this.searchQuoteBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchQuoteBtn.FlatAppearance.BorderSize = 0;
            this.searchQuoteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(142)))), ((int)(((byte)(56)))));
            this.searchQuoteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchQuoteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchQuoteBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.searchQuoteBtn.Location = new System.Drawing.Point(0, 100);
            this.searchQuoteBtn.Name = "searchQuoteBtn";
            this.searchQuoteBtn.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.searchQuoteBtn.Size = new System.Drawing.Size(251, 50);
            this.searchQuoteBtn.TabIndex = 2;
            this.searchQuoteBtn.Text = "&Search Quote";
            this.searchQuoteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchQuoteBtn.UseVisualStyleBackColor = true;
            this.searchQuoteBtn.Click += new System.EventHandler(this.searchQuoteBtn_Click_1);
            // 
            // viewQuoteBtn
            // 
            this.viewQuoteBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.viewQuoteBtn.FlatAppearance.BorderSize = 0;
            this.viewQuoteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(142)))), ((int)(((byte)(56)))));
            this.viewQuoteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewQuoteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewQuoteBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.viewQuoteBtn.Location = new System.Drawing.Point(0, 50);
            this.viewQuoteBtn.Name = "viewQuoteBtn";
            this.viewQuoteBtn.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.viewQuoteBtn.Size = new System.Drawing.Size(251, 50);
            this.viewQuoteBtn.TabIndex = 1;
            this.viewQuoteBtn.Text = "&View Quotes";
            this.viewQuoteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.viewQuoteBtn.UseVisualStyleBackColor = true;
            this.viewQuoteBtn.Click += new System.EventHandler(this.viewQuoteBtn_Click_1);
            // 
            // addQuoteBtn
            // 
            this.addQuoteBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.addQuoteBtn.FlatAppearance.BorderSize = 0;
            this.addQuoteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(142)))), ((int)(((byte)(56)))));
            this.addQuoteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addQuoteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addQuoteBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.addQuoteBtn.Location = new System.Drawing.Point(0, 0);
            this.addQuoteBtn.Name = "addQuoteBtn";
            this.addQuoteBtn.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.addQuoteBtn.Size = new System.Drawing.Size(251, 50);
            this.addQuoteBtn.TabIndex = 0;
            this.addQuoteBtn.Text = "&Add New Quote";
            this.addQuoteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addQuoteBtn.UseVisualStyleBackColor = true;
            this.addQuoteBtn.Click += new System.EventHandler(this.addQuoteBtn_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Gainsboro;
            this.button1.Location = new System.Drawing.Point(0, 125);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(251, 51);
            this.button1.TabIndex = 1;
            this.button1.Text = "&Start Quote";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackgroundImage = global::MegaDesk.Properties.Resources.modern;
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(251, 125);
            this.panelLogo.TabIndex = 0;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::MegaDesk.Properties.Resources.modern;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1085, 525);
            this.Controls.Add(this.panelSideMenu);
            this.Controls.Add(this.megaLabel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainMenu";
            this.Text = "MegaDesk";
            this.panelSideMenu.ResumeLayout(false);
            this.panelMediaSubmenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label megaLabel;
        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Panel panelMediaSubmenu;
        private System.Windows.Forms.Button searchQuoteBtn;
        private System.Windows.Forms.Button viewQuoteBtn;
        private System.Windows.Forms.Button addQuoteBtn;
        private System.Windows.Forms.Button button1;
    }
}

