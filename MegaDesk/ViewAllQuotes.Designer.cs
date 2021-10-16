
namespace MegaDesk
{
    partial class ViewAllQuotes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.allQuotes = new System.Windows.Forms.DataGridView();
            this.nameHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.widthHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heightHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drawersHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surfaceHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rushHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quoteHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.backbtn1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.allQuotes)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // allQuotes
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.allQuotes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.allQuotes.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.allQuotes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.allQuotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allQuotes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameHeader,
            this.dateHeader,
            this.widthHeader,
            this.heightHeader,
            this.drawersHeader,
            this.surfaceHeader,
            this.rushHeader,
            this.quoteHeader});
            this.allQuotes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.allQuotes.Location = new System.Drawing.Point(289, 50);
            this.allQuotes.Name = "allQuotes";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.allQuotes.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.allQuotes.RowHeadersWidth = 30;
            this.allQuotes.RowTemplate.ReadOnly = true;
            this.allQuotes.Size = new System.Drawing.Size(1034, 333);
            this.allQuotes.TabIndex = 0;
            // 
            // nameHeader
            // 
            this.nameHeader.HeaderText = "Name";
            this.nameHeader.MinimumWidth = 6;
            this.nameHeader.Name = "nameHeader";
            this.nameHeader.ReadOnly = true;
            this.nameHeader.Width = 125;
            // 
            // dateHeader
            // 
            this.dateHeader.HeaderText = "Date";
            this.dateHeader.MinimumWidth = 6;
            this.dateHeader.Name = "dateHeader";
            this.dateHeader.ReadOnly = true;
            this.dateHeader.Width = 125;
            // 
            // widthHeader
            // 
            this.widthHeader.HeaderText = "Width";
            this.widthHeader.MinimumWidth = 6;
            this.widthHeader.Name = "widthHeader";
            this.widthHeader.ReadOnly = true;
            this.widthHeader.Width = 125;
            // 
            // heightHeader
            // 
            this.heightHeader.HeaderText = "Depth";
            this.heightHeader.MinimumWidth = 6;
            this.heightHeader.Name = "heightHeader";
            this.heightHeader.ReadOnly = true;
            this.heightHeader.Width = 125;
            // 
            // drawersHeader
            // 
            this.drawersHeader.HeaderText = "Drawers";
            this.drawersHeader.MinimumWidth = 6;
            this.drawersHeader.Name = "drawersHeader";
            this.drawersHeader.ReadOnly = true;
            this.drawersHeader.Width = 125;
            // 
            // surfaceHeader
            // 
            this.surfaceHeader.HeaderText = "Surface Material";
            this.surfaceHeader.MinimumWidth = 6;
            this.surfaceHeader.Name = "surfaceHeader";
            this.surfaceHeader.ReadOnly = true;
            this.surfaceHeader.Width = 125;
            // 
            // rushHeader
            // 
            this.rushHeader.HeaderText = "Order Rush";
            this.rushHeader.MinimumWidth = 6;
            this.rushHeader.Name = "rushHeader";
            this.rushHeader.ReadOnly = true;
            this.rushHeader.Width = 125;
            // 
            // quoteHeader
            // 
            this.quoteHeader.HeaderText = "Quote Price";
            this.quoteHeader.MinimumWidth = 6;
            this.quoteHeader.Name = "quoteHeader";
            this.quoteHeader.ReadOnly = true;
            this.quoteHeader.Width = 125;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panel1.Controls.Add(this.backbtn1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 470);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::MegaDesk.Properties.Resources.modern;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 125);
            this.panel2.TabIndex = 0;
            // 
            // backbtn1
            // 
            this.backbtn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.backbtn1.Dock = System.Windows.Forms.DockStyle.Top;
            this.backbtn1.FlatAppearance.BorderSize = 0;
            this.backbtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backbtn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn1.Location = new System.Drawing.Point(0, 125);
            this.backbtn1.Name = "backbtn1";
            this.backbtn1.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.backbtn1.Size = new System.Drawing.Size(250, 51);
            this.backbtn1.TabIndex = 1;
            this.backbtn1.Text = "&Back";
            this.backbtn1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backbtn1.UseVisualStyleBackColor = false;
            this.backbtn1.Click += new System.EventHandler(this.backbtn1_Click_1);
            // 
            // ViewAllQuotes
            // 
            this.BackgroundImage = global::MegaDesk.Properties.Resources.modern;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1368, 470);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.allQuotes);
            this.Name = "ViewAllQuotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "All Quotes";
            ((System.ComponentModel.ISupportInitialize)(this.allQuotes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView allQuotes;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn widthHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn heightHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn drawersHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn surfaceHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn rushHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn quoteHeader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button backbtn1;
    }
}