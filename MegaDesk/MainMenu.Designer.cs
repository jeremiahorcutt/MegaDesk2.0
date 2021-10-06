
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
            this.addQuoteBtn = new System.Windows.Forms.Button();
            this.searchQuoteBtn = new System.Windows.Forms.Button();
            this.viewQuoteBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.megaLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addQuoteBtn
            // 
            this.addQuoteBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.addQuoteBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.addQuoteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.addQuoteBtn.Font = new System.Drawing.Font("Modern No. 20", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addQuoteBtn.Location = new System.Drawing.Point(36, 31);
            this.addQuoteBtn.Name = "addQuoteBtn";
            this.addQuoteBtn.Size = new System.Drawing.Size(160, 70);
            this.addQuoteBtn.TabIndex = 2;
            this.addQuoteBtn.Text = "Add New Quote";
            this.addQuoteBtn.UseVisualStyleBackColor = false;
            this.addQuoteBtn.Click += new System.EventHandler(this.addQuoteBtn_Click);
            // 
            // searchQuoteBtn
            // 
            this.searchQuoteBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.searchQuoteBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.searchQuoteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.searchQuoteBtn.Font = new System.Drawing.Font("Modern No. 20", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchQuoteBtn.Location = new System.Drawing.Point(36, 183);
            this.searchQuoteBtn.Name = "searchQuoteBtn";
            this.searchQuoteBtn.Size = new System.Drawing.Size(160, 70);
            this.searchQuoteBtn.TabIndex = 3;
            this.searchQuoteBtn.Text = "Search Quotes";
            this.searchQuoteBtn.UseVisualStyleBackColor = false;
            this.searchQuoteBtn.Click += new System.EventHandler(this.searchQuoteBtn_Click);
            // 
            // viewQuoteBtn
            // 
            this.viewQuoteBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.viewQuoteBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.viewQuoteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.viewQuoteBtn.Font = new System.Drawing.Font("Modern No. 20", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewQuoteBtn.Location = new System.Drawing.Point(36, 107);
            this.viewQuoteBtn.Name = "viewQuoteBtn";
            this.viewQuoteBtn.Size = new System.Drawing.Size(160, 70);
            this.viewQuoteBtn.TabIndex = 4;
            this.viewQuoteBtn.Text = "View Quotes";
            this.viewQuoteBtn.UseVisualStyleBackColor = false;
            this.viewQuoteBtn.Click += new System.EventHandler(this.viewQuoteBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.exitBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.exitBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.exitBtn.Font = new System.Drawing.Font("Modern No. 20", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(36, 259);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(160, 70);
            this.exitBtn.TabIndex = 5;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // megaLabel
            // 
            this.megaLabel.AutoSize = true;
            this.megaLabel.BackColor = System.Drawing.Color.Transparent;
            this.megaLabel.Font = new System.Drawing.Font("Modern No. 20", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.megaLabel.ForeColor = System.Drawing.Color.White;
            this.megaLabel.Location = new System.Drawing.Point(277, 127);
            this.megaLabel.Name = "megaLabel";
            this.megaLabel.Size = new System.Drawing.Size(229, 50);
            this.megaLabel.TabIndex = 6;
            this.megaLabel.Text = "MegaDesk";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::MegaDesk.Properties.Resources.board_503944_1280;
            this.ClientSize = new System.Drawing.Size(555, 372);
            this.Controls.Add(this.megaLabel);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.viewQuoteBtn);
            this.Controls.Add(this.searchQuoteBtn);
            this.Controls.Add(this.addQuoteBtn);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainMenu";
            this.Text = "MegaDesk";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addQuoteBtn;
        private System.Windows.Forms.Button searchQuoteBtn;
        private System.Windows.Forms.Button viewQuoteBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label megaLabel;
    }
}

