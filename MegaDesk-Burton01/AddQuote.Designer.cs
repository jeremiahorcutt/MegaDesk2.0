
namespace MegaDesk_Burton01
{
    partial class AddQuote
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.viewQuoteButton = new System.Windows.Forms.Button();
            this.returnToMainMenu = new System.Windows.Forms.Button();
            this.customerNameBox = new System.Windows.Forms.TextBox();
            this.widthBox = new System.Windows.Forms.TextBox();
            this.depthBox = new System.Windows.Forms.TextBox();
            this.shippingBox = new System.Windows.Forms.ListBox();
            this.drawerBox = new System.Windows.Forms.ComboBox();
            this.materialBox = new System.Windows.Forms.ComboBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.currentDate = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Costomer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Desk Width (in)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Desk Depth (in)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Number of Drawers";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Desktop Material";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Shipping Method";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 414);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Date";
            // 
            // viewQuoteButton
            // 
            this.viewQuoteButton.Location = new System.Drawing.Point(564, 312);
            this.viewQuoteButton.Name = "viewQuoteButton";
            this.viewQuoteButton.Size = new System.Drawing.Size(138, 23);
            this.viewQuoteButton.TabIndex = 6;
            this.viewQuoteButton.Text = "Submit Quote";
            this.viewQuoteButton.UseVisualStyleBackColor = true;
            this.viewQuoteButton.Click += new System.EventHandler(this.viewQuoteButton_Click);
            // 
            // returnToMainMenu
            // 
            this.returnToMainMenu.Location = new System.Drawing.Point(564, 384);
            this.returnToMainMenu.Name = "returnToMainMenu";
            this.returnToMainMenu.Size = new System.Drawing.Size(138, 23);
            this.returnToMainMenu.TabIndex = 7;
            this.returnToMainMenu.Text = "Back To Main";
            this.returnToMainMenu.UseVisualStyleBackColor = true;
            this.returnToMainMenu.Click += new System.EventHandler(this.returnToMainMenu_Click);
            // 
            // customerNameBox
            // 
            this.customerNameBox.Location = new System.Drawing.Point(180, 84);
            this.customerNameBox.Name = "customerNameBox";
            this.customerNameBox.Size = new System.Drawing.Size(206, 22);
            this.customerNameBox.TabIndex = 0;
            this.customerNameBox.Validating += new System.ComponentModel.CancelEventHandler(this.customerNameBox_Validating);
            // 
            // widthBox
            // 
            this.widthBox.Location = new System.Drawing.Point(180, 140);
            this.widthBox.Name = "widthBox";
            this.widthBox.Size = new System.Drawing.Size(206, 22);
            this.widthBox.TabIndex = 1;
            // 
            // depthBox
            // 
            this.depthBox.Location = new System.Drawing.Point(180, 192);
            this.depthBox.Name = "depthBox";
            this.depthBox.Size = new System.Drawing.Size(100, 22);
            this.depthBox.TabIndex = 2;
            // 
            // shippingBox
            // 
            this.shippingBox.FormattingEnabled = true;
            this.shippingBox.ItemHeight = 16;
            this.shippingBox.Items.AddRange(new object[] {
            "Normal - 14 days",
            "3 Day",
            "5 Day",
            "7 Day"});
            this.shippingBox.Location = new System.Drawing.Point(180, 317);
            this.shippingBox.Name = "shippingBox";
            this.shippingBox.Size = new System.Drawing.Size(120, 84);
            this.shippingBox.TabIndex = 5;
            // 
            // drawerBox
            // 
            this.drawerBox.FormattingEnabled = true;
            this.drawerBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.drawerBox.Location = new System.Drawing.Point(180, 234);
            this.drawerBox.Name = "drawerBox";
            this.drawerBox.Size = new System.Drawing.Size(100, 24);
            this.drawerBox.TabIndex = 3;
            // 
            // materialBox
            // 
            this.materialBox.FormattingEnabled = true;
            this.materialBox.Items.AddRange(new object[] {
            "Select one item below",
            "Oak",
            "Laminate",
            "Pine",
            "Rosewood",
            "Veneer"});
            this.materialBox.Location = new System.Drawing.Point(180, 283);
            this.materialBox.Name = "materialBox";
            this.materialBox.Size = new System.Drawing.Size(121, 24);
            this.materialBox.TabIndex = 4;
            // 
            // currentDate
            // 
            this.currentDate.AutoSize = true;
            this.currentDate.Location = new System.Drawing.Point(177, 414);
            this.currentDate.Name = "currentDate";
            this.currentDate.Size = new System.Drawing.Size(84, 17);
            this.currentDate.TabIndex = 19;
            this.currentDate.Text = "dd-mm-yyyy";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(204, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(360, 29);
            this.label9.TabIndex = 20;
            this.label9.Text = "MegaDesk Add Quote System";
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.currentDate);
            this.Controls.Add(this.materialBox);
            this.Controls.Add(this.drawerBox);
            this.Controls.Add(this.shippingBox);
            this.Controls.Add(this.depthBox);
            this.Controls.Add(this.widthBox);
            this.Controls.Add(this.customerNameBox);
            this.Controls.Add(this.returnToMainMenu);
            this.Controls.Add(this.viewQuoteButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddQuote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddQuote";
            this.Load += new System.EventHandler(this.AddQuote_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button viewQuoteButton;
        private System.Windows.Forms.Button returnToMainMenu;
        private System.Windows.Forms.TextBox customerNameBox;
        private System.Windows.Forms.TextBox widthBox;
        private System.Windows.Forms.TextBox depthBox;
        private System.Windows.Forms.ListBox shippingBox;
        private System.Windows.Forms.ComboBox drawerBox;
        private System.Windows.Forms.ComboBox materialBox;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Label currentDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label errorLabel;

    }
}