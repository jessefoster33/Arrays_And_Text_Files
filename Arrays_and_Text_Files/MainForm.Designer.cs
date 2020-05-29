namespace Arrays_and_Text_Files
{
    partial class MainForm
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
            this.style_dropdown_box = new System.Windows.Forms.ComboBox();
            this.style_dropdown_label = new System.Windows.Forms.Label();
            this.size_dropdown_box = new System.Windows.Forms.ComboBox();
            this.size_dropdown_label = new System.Windows.Forms.Label();
            this.quantity_textbox = new System.Windows.Forms.TextBox();
            this.qty_label = new System.Windows.Forms.Label();
            this.price_textbox = new System.Windows.Forms.TextBox();
            this.price_label = new System.Windows.Forms.Label();
            this.checkout_btn = new System.Windows.Forms.Button();
            this.subtotal_textbox = new System.Windows.Forms.TextBox();
            this.subtotal_label = new System.Windows.Forms.Label();
            this.tax_textbox = new System.Windows.Forms.TextBox();
            this.tax_label = new System.Windows.Forms.Label();
            this.total_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.clear_btn = new System.Windows.Forms.Button();
            this.quit_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // style_dropdown_box
            // 
            this.style_dropdown_box.FormattingEnabled = true;
            this.style_dropdown_box.Location = new System.Drawing.Point(45, 61);
            this.style_dropdown_box.Name = "style_dropdown_box";
            this.style_dropdown_box.Size = new System.Drawing.Size(121, 28);
            this.style_dropdown_box.TabIndex = 0;
            // 
            // style_dropdown_label
            // 
            this.style_dropdown_label.AutoSize = true;
            this.style_dropdown_label.Location = new System.Drawing.Point(45, 28);
            this.style_dropdown_label.Name = "style_dropdown_label";
            this.style_dropdown_label.Size = new System.Drawing.Size(44, 20);
            this.style_dropdown_label.TabIndex = 1;
            this.style_dropdown_label.Text = "Style";
            // 
            // size_dropdown_box
            // 
            this.size_dropdown_box.FormattingEnabled = true;
            this.size_dropdown_box.Location = new System.Drawing.Point(196, 61);
            this.size_dropdown_box.Name = "size_dropdown_box";
            this.size_dropdown_box.Size = new System.Drawing.Size(121, 28);
            this.size_dropdown_box.TabIndex = 2;
            // 
            // size_dropdown_label
            // 
            this.size_dropdown_label.AutoSize = true;
            this.size_dropdown_label.Location = new System.Drawing.Point(192, 28);
            this.size_dropdown_label.Name = "size_dropdown_label";
            this.size_dropdown_label.Size = new System.Drawing.Size(40, 20);
            this.size_dropdown_label.TabIndex = 3;
            this.size_dropdown_label.Text = "Size";
            // 
            // quantity_textbox
            // 
            this.quantity_textbox.Location = new System.Drawing.Point(49, 147);
            this.quantity_textbox.Name = "quantity_textbox";
            this.quantity_textbox.Size = new System.Drawing.Size(68, 26);
            this.quantity_textbox.TabIndex = 4;
            // 
            // qty_label
            // 
            this.qty_label.AutoSize = true;
            this.qty_label.Location = new System.Drawing.Point(49, 109);
            this.qty_label.Name = "qty_label";
            this.qty_label.Size = new System.Drawing.Size(33, 20);
            this.qty_label.TabIndex = 5;
            this.qty_label.Text = "Qty";
            // 
            // price_textbox
            // 
            this.price_textbox.Location = new System.Drawing.Point(196, 147);
            this.price_textbox.Name = "price_textbox";
            this.price_textbox.Size = new System.Drawing.Size(121, 26);
            this.price_textbox.TabIndex = 6;
            this.price_textbox.Visible = false;
            // 
            // price_label
            // 
            this.price_label.AutoSize = true;
            this.price_label.Location = new System.Drawing.Point(196, 115);
            this.price_label.Name = "price_label";
            this.price_label.Size = new System.Drawing.Size(44, 20);
            this.price_label.TabIndex = 7;
            this.price_label.Text = "Price";
            // 
            // checkout_btn
            // 
            this.checkout_btn.Location = new System.Drawing.Point(45, 249);
            this.checkout_btn.Name = "checkout_btn";
            this.checkout_btn.Size = new System.Drawing.Size(251, 58);
            this.checkout_btn.TabIndex = 8;
            this.checkout_btn.Text = "Checkout";
            this.checkout_btn.UseVisualStyleBackColor = true;
            // 
            // subtotal_textbox
            // 
            this.subtotal_textbox.Location = new System.Drawing.Point(395, 249);
            this.subtotal_textbox.Name = "subtotal_textbox";
            this.subtotal_textbox.Size = new System.Drawing.Size(100, 26);
            this.subtotal_textbox.TabIndex = 9;
            // 
            // subtotal_label
            // 
            this.subtotal_label.AutoSize = true;
            this.subtotal_label.Location = new System.Drawing.Point(391, 216);
            this.subtotal_label.Name = "subtotal_label";
            this.subtotal_label.Size = new System.Drawing.Size(69, 20);
            this.subtotal_label.TabIndex = 10;
            this.subtotal_label.Text = "Subtotal";
            // 
            // tax_textbox
            // 
            this.tax_textbox.Location = new System.Drawing.Point(530, 249);
            this.tax_textbox.Name = "tax_textbox";
            this.tax_textbox.Size = new System.Drawing.Size(83, 26);
            this.tax_textbox.TabIndex = 11;
            // 
            // tax_label
            // 
            this.tax_label.AutoSize = true;
            this.tax_label.Location = new System.Drawing.Point(526, 216);
            this.tax_label.Name = "tax_label";
            this.tax_label.Size = new System.Drawing.Size(73, 20);
            this.tax_label.TabIndex = 12;
            this.tax_label.Text = "Total Tax";
            // 
            // total_textbox
            // 
            this.total_textbox.Location = new System.Drawing.Point(395, 343);
            this.total_textbox.Name = "total_textbox";
            this.total_textbox.Size = new System.Drawing.Size(218, 26);
            this.total_textbox.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(391, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Total";
            // 
            // clear_btn
            // 
            this.clear_btn.Location = new System.Drawing.Point(45, 331);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(112, 38);
            this.clear_btn.TabIndex = 15;
            this.clear_btn.Text = "Clear";
            this.clear_btn.UseVisualStyleBackColor = true;
            // 
            // quit_btn
            // 
            this.quit_btn.Location = new System.Drawing.Point(184, 331);
            this.quit_btn.Name = "quit_btn";
            this.quit_btn.Size = new System.Drawing.Size(112, 38);
            this.quit_btn.TabIndex = 16;
            this.quit_btn.Text = "Quit";
            this.quit_btn.UseVisualStyleBackColor = true;
            this.quit_btn.Click += new System.EventHandler(this.quit_btn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 414);
            this.Controls.Add(this.quit_btn);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.total_textbox);
            this.Controls.Add(this.tax_label);
            this.Controls.Add(this.tax_textbox);
            this.Controls.Add(this.subtotal_label);
            this.Controls.Add(this.subtotal_textbox);
            this.Controls.Add(this.checkout_btn);
            this.Controls.Add(this.price_label);
            this.Controls.Add(this.price_textbox);
            this.Controls.Add(this.qty_label);
            this.Controls.Add(this.quantity_textbox);
            this.Controls.Add(this.size_dropdown_label);
            this.Controls.Add(this.size_dropdown_box);
            this.Controls.Add(this.style_dropdown_label);
            this.Controls.Add(this.style_dropdown_box);
            this.Name = "MainForm";
            this.Text = "Arrays & Text Files";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox style_dropdown_box;
        private System.Windows.Forms.Label style_dropdown_label;
        private System.Windows.Forms.ComboBox size_dropdown_box;
        private System.Windows.Forms.Label size_dropdown_label;
        private System.Windows.Forms.TextBox quantity_textbox;
        private System.Windows.Forms.Label qty_label;
        private System.Windows.Forms.TextBox price_textbox;
        private System.Windows.Forms.Label price_label;
        private System.Windows.Forms.Button checkout_btn;
        private System.Windows.Forms.TextBox subtotal_textbox;
        private System.Windows.Forms.Label subtotal_label;
        private System.Windows.Forms.TextBox tax_textbox;
        private System.Windows.Forms.Label tax_label;
        private System.Windows.Forms.TextBox total_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Button quit_btn;
    }
}

