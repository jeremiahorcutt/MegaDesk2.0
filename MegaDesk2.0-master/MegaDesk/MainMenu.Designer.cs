
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
            this.exitBtn1 = new System.Windows.Forms.Button();
            this.panelMediaSubMenu = new System.Windows.Forms.Panel();
            this.searchQuoteBtn1 = new System.Windows.Forms.Button();
            this.viewQuoteBtn1 = new System.Windows.Forms.Button();
            this.addQuoteBtn1 = new System.Windows.Forms.Button();
            this.btnMedia = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelSideMenu.SuspendLayout();
            this.panelMediaSubMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // megaLabel
            // 
            this.megaLabel.AutoSize = true;
            this.megaLabel.BackColor = System.Drawing.Color.Transparent;
            this.megaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.megaLabel.ForeColor = System.Drawing.Color.Azure;
            this.megaLabel.Location = new System.Drawing.Point(613, 105);
            this.megaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.megaLabel.Name = "megaLabel";
            this.megaLabel.Size = new System.Drawing.Size(428, 91);
            this.megaLabel.TabIndex = 6;
            this.megaLabel.Text = "MegaDesk";
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelSideMenu.Controls.Add(this.exitBtn1);
            this.panelSideMenu.Controls.Add(this.panelMediaSubMenu);
            this.panelSideMenu.Controls.Add(this.btnMedia);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(251, 547);
            this.panelSideMenu.TabIndex = 7;
            // 
            // exitBtn1
            // 
            this.exitBtn1.Dock = System.Windows.Forms.DockStyle.Top;
            this.exitBtn1.FlatAppearance.BorderSize = 0;
            this.exitBtn1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.exitBtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn1.ForeColor = System.Drawing.Color.Gainsboro;
            this.exitBtn1.Location = new System.Drawing.Point(0, 345);
            this.exitBtn1.Name = "exitBtn1";
            this.exitBtn1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.exitBtn1.Size = new System.Drawing.Size(251, 57);
            this.exitBtn1.TabIndex = 4;
            this.exitBtn1.Text = "&Exit";
            this.exitBtn1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitBtn1.UseVisualStyleBackColor = true;
            this.exitBtn1.Click += new System.EventHandler(this.exitBtn1_Click);
            // 
            // panelMediaSubMenu
            // 
            this.panelMediaSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelMediaSubMenu.Controls.Add(this.searchQuoteBtn1);
            this.panelMediaSubMenu.Controls.Add(this.viewQuoteBtn1);
            this.panelMediaSubMenu.Controls.Add(this.addQuoteBtn1);
            this.panelMediaSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMediaSubMenu.Location = new System.Drawing.Point(0, 158);
            this.panelMediaSubMenu.Name = "panelMediaSubMenu";
            this.panelMediaSubMenu.Size = new System.Drawing.Size(251, 187);
            this.panelMediaSubMenu.TabIndex = 1;
            // 
            // searchQuoteBtn1
            // 
            this.searchQuoteBtn1.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchQuoteBtn1.FlatAppearance.BorderSize = 0;
            this.searchQuoteBtn1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod;
            this.searchQuoteBtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchQuoteBtn1.ForeColor = System.Drawing.Color.Gainsboro;
            this.searchQuoteBtn1.Location = new System.Drawing.Point(0, 106);
            this.searchQuoteBtn1.Name = "searchQuoteBtn1";
            this.searchQuoteBtn1.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.searchQuoteBtn1.Size = new System.Drawing.Size(251, 61);
            this.searchQuoteBtn1.TabIndex = 3;
            this.searchQuoteBtn1.Text = "S&earch Quotes";
            this.searchQuoteBtn1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchQuoteBtn1.UseVisualStyleBackColor = true;
            this.searchQuoteBtn1.Click += new System.EventHandler(this.searchQuoteBtn1_Click);
            // 
            // viewQuoteBtn1
            // 
            this.viewQuoteBtn1.Dock = System.Windows.Forms.DockStyle.Top;
            this.viewQuoteBtn1.FlatAppearance.BorderSize = 0;
            this.viewQuoteBtn1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod;
            this.viewQuoteBtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewQuoteBtn1.ForeColor = System.Drawing.Color.Gainsboro;
            this.viewQuoteBtn1.Location = new System.Drawing.Point(0, 54);
            this.viewQuoteBtn1.Name = "viewQuoteBtn1";
            this.viewQuoteBtn1.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.viewQuoteBtn1.Size = new System.Drawing.Size(251, 52);
            this.viewQuoteBtn1.TabIndex = 2;
            this.viewQuoteBtn1.Text = "&View Quotes";
            this.viewQuoteBtn1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.viewQuoteBtn1.UseVisualStyleBackColor = true;
            this.viewQuoteBtn1.Click += new System.EventHandler(this.viewQuoteBtn1_Click);
            // 
            // addQuoteBtn1
            // 
            this.addQuoteBtn1.Dock = System.Windows.Forms.DockStyle.Top;
            this.addQuoteBtn1.FlatAppearance.BorderSize = 0;
            this.addQuoteBtn1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod;
            this.addQuoteBtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addQuoteBtn1.ForeColor = System.Drawing.Color.Gainsboro;
            this.addQuoteBtn1.Location = new System.Drawing.Point(0, 0);
            this.addQuoteBtn1.Name = "addQuoteBtn1";
            this.addQuoteBtn1.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.addQuoteBtn1.Size = new System.Drawing.Size(251, 54);
            this.addQuoteBtn1.TabIndex = 1;
            this.addQuoteBtn1.Text = "&Add New Quote";
            this.addQuoteBtn1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addQuoteBtn1.UseVisualStyleBackColor = true;
            this.addQuoteBtn1.Click += new System.EventHandler(this.addQuoteBtn1_Click);
            // 
            // btnMedia
            // 
            this.btnMedia.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMedia.FlatAppearance.BorderSize = 0;
            this.btnMedia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btnMedia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedia.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMedia.Location = new System.Drawing.Point(0, 105);
            this.btnMedia.Name = "btnMedia";
            this.btnMedia.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMedia.Size = new System.Drawing.Size(251, 53);
            this.btnMedia.TabIndex = 0;
            this.btnMedia.Text = "&Start Desk Order";
            this.btnMedia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMedia.UseVisualStyleBackColor = true;
            this.btnMedia.Click += new System.EventHandler(this.btnMedia_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackgroundImage = global::MegaDesk.Properties.Resources.modern;
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(251, 105);
            this.panelLogo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(48, 9);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(15, 10, 0, 0);
            this.label1.Size = new System.Drawing.Size(152, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "MegaDesk";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::MegaDesk.Properties.Resources.modern;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1217, 547);
            this.ControlBox = false;
            this.Controls.Add(this.panelSideMenu);
            this.Controls.Add(this.megaLabel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainMenu";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "MegaDesk";
            this.panelSideMenu.ResumeLayout(false);
            this.panelMediaSubMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label megaLabel;
        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Button btnMedia;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelMediaSubMenu;
        private System.Windows.Forms.Button exitBtn1;
        private System.Windows.Forms.Button searchQuoteBtn1;
        private System.Windows.Forms.Button viewQuoteBtn1;
        private System.Windows.Forms.Button addQuoteBtn1;
        private System.Windows.Forms.Label label1;
    }
}

