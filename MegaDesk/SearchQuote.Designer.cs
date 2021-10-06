
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.backbtn1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.searchQuotesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // searchQuotesGrid
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.searchQuotesGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.searchQuotesGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.searchQuotesGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
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
            this.searchQuotesGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.searchQuotesGrid.Location = new System.Drawing.Point(77, 72);
            this.searchQuotesGrid.Name = "searchQuotesGrid";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.searchQuotesGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.searchQuotesGrid.RowHeadersWidth = 30;
            this.searchQuotesGrid.RowTemplate.ReadOnly = true;
            this.searchQuotesGrid.Size = new System.Drawing.Size(833, 233);
            this.searchQuotesGrid.TabIndex = 1;
            // 
            // nameHeader
            // 
            this.nameHeader.HeaderText = "Name";
            this.nameHeader.Name = "nameHeader";
            this.nameHeader.ReadOnly = true;
            // 
            // dateHeader
            // 
            this.dateHeader.HeaderText = "Date";
            this.dateHeader.Name = "dateHeader";
            this.dateHeader.ReadOnly = true;
            // 
            // widthHeader
            // 
            this.widthHeader.HeaderText = "Width";
            this.widthHeader.Name = "widthHeader";
            this.widthHeader.ReadOnly = true;
            // 
            // heightHeader
            // 
            this.heightHeader.HeaderText = "Depth";
            this.heightHeader.Name = "heightHeader";
            this.heightHeader.ReadOnly = true;
            // 
            // drawersHeader
            // 
            this.drawersHeader.HeaderText = "Drawers";
            this.drawersHeader.Name = "drawersHeader";
            this.drawersHeader.ReadOnly = true;
            // 
            // surfaceHeader
            // 
            this.surfaceHeader.HeaderText = "Surface Material";
            this.surfaceHeader.Name = "surfaceHeader";
            this.surfaceHeader.ReadOnly = true;
            // 
            // rushHeader
            // 
            this.rushHeader.HeaderText = "Order Rush";
            this.rushHeader.Name = "rushHeader";
            this.rushHeader.ReadOnly = true;
            // 
            // quoteHeader
            // 
            this.quoteHeader.HeaderText = "Quote Price";
            this.quoteHeader.Name = "quoteHeader";
            this.quoteHeader.ReadOnly = true;
            // 
            // listBoxSurface
            // 
            this.listBoxSurface.FormattingEnabled = true;
            this.listBoxSurface.Location = new System.Drawing.Point(260, 41);
            this.listBoxSurface.Name = "listBoxSurface";
            this.listBoxSurface.Size = new System.Drawing.Size(121, 21);
            this.listBoxSurface.TabIndex = 2;
            this.listBoxSurface.SelectedIndexChanged += new System.EventHandler(this.listBoxSurface_SelectedIndexChanged);
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.BackColor = System.Drawing.Color.Transparent;
            this.labelSearch.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearch.ForeColor = System.Drawing.Color.White;
            this.labelSearch.Location = new System.Drawing.Point(77, 38);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(182, 24);
            this.labelSearch.TabIndex = 3;
            this.labelSearch.Text = "Search By Material:";
            // 
            // backbtn1
            // 
            this.backbtn1.BackColor = System.Drawing.Color.Transparent;
            this.backbtn1.BackgroundImage = global::MegaDesk.Properties.Resources.board_503944_1280;
            this.backbtn1.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn1.ForeColor = System.Drawing.Color.White;
            this.backbtn1.Location = new System.Drawing.Point(785, 376);
            this.backbtn1.Name = "backbtn1";
            this.backbtn1.Size = new System.Drawing.Size(125, 43);
            this.backbtn1.TabIndex = 8;
            this.backbtn1.Text = "Back";
            this.backbtn1.UseVisualStyleBackColor = false;
            this.backbtn1.Click += new System.EventHandler(this.backbtn1_Click);
            // 
            // SearchQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MegaDesk.Properties.Resources.wood_2045380_1280;
            this.ClientSize = new System.Drawing.Size(995, 431);
            this.Controls.Add(this.backbtn1);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.listBoxSurface);
            this.Controls.Add(this.searchQuotesGrid);
            this.Name = "SearchQuote";
            this.Text = "SearchQuote";
            ((System.ComponentModel.ISupportInitialize)(this.searchQuotesGrid)).EndInit();
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
        private System.Windows.Forms.Button backbtn1;
    }
}