
namespace MegaDesk
{
    partial class SearchQuote
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
            this.searchQuotesGrid = new System.Windows.Forms.DataGridView();
            this.nameHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.widthHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heightHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drawersHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surfaceHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rushHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quoteHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listBoxSurface = new System.Windows.Forms.ComboBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.searchQuotesGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchQuotesGrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.searchQuotesGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.searchQuotesGrid.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.searchQuotesGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchQuotesGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.searchQuotesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchQuotesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameHeader,
            this.dateHeader,
            this.widthHeader,
            this.heightHeader,
            this.drawersHeader,
            this.surfaceHeader,
            this.rushHeader,
            this.quoteHeader});
            this.searchQuotesGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.searchQuotesGrid.Location = new System.Drawing.Point(296, 116);
            this.searchQuotesGrid.Margin = new System.Windows.Forms.Padding(4);
            this.searchQuotesGrid.Name = "searchQuotesGrid";
            this.searchQuotesGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.searchQuotesGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.searchQuotesGrid.RowHeadersWidth = 30;
            this.searchQuotesGrid.RowTemplate.ReadOnly = true;
            this.searchQuotesGrid.Size = new System.Drawing.Size(1027, 287);
            this.searchQuotesGrid.TabIndex = 1;
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
            // listBoxSurface
            // 
            this.listBoxSurface.FormattingEnabled = true;
            this.listBoxSurface.Location = new System.Drawing.Point(564, 77);
            this.listBoxSurface.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxSurface.Name = "listBoxSurface";
            this.listBoxSurface.Size = new System.Drawing.Size(160, 24);
            this.listBoxSurface.TabIndex = 2;
            this.listBoxSurface.SelectedIndexChanged += new System.EventHandler(this.listBoxSurface_SelectedIndexChanged);
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.BackColor = System.Drawing.Color.Transparent;
            this.labelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearch.ForeColor = System.Drawing.Color.White;
            this.labelSearch.Location = new System.Drawing.Point(290, 70);
            this.labelSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(250, 31);
            this.labelSearch.TabIndex = 3;
            this.labelSearch.Text = "Search By Material:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 521);
            this.panel1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Gainsboro;
            this.button1.Location = new System.Drawing.Point(0, 101);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(240, 55);
            this.button1.TabIndex = 1;
            this.button1.Text = "&Back";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panel2.BackgroundImage = global::MegaDesk.Properties.Resources.modern;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 101);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(29, 9);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(30, 10, 0, 0);
            this.label1.Size = new System.Drawing.Size(167, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "MegaDesk";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // SearchQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MegaDesk.Properties.Resources.modern;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1379, 521);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.listBoxSurface);
            this.Controls.Add(this.searchQuotesGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SearchQuote";
            this.Text = "SearchQuote";
            ((System.ComponentModel.ISupportInitialize)(this.searchQuotesGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView searchQuotesGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn widthHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn heightHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn drawersHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn surfaceHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn rushHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn quoteHeader;
        private System.Windows.Forms.ComboBox listBoxSurface;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}