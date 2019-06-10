namespace LibraryMS
{
    partial class panel_book
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.butt_addbookmain = new System.Windows.Forms.Button();
            this.butt_deletebookmain = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.text_addbook = new System.Windows.Forms.TextBox();
            this.panel_addbook = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.butt_addbook = new System.Windows.Forms.Button();
            this.panel_deletebook = new System.Windows.Forms.Panel();
            this.butt_deletebook = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.text_deletebook = new System.Windows.Forms.TextBox();
            this.panel_addbook.SuspendLayout();
            this.panel_deletebook.SuspendLayout();
            this.SuspendLayout();
            // 
            // butt_addbookmain
            // 
            this.butt_addbookmain.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butt_addbookmain.Location = new System.Drawing.Point(48, 74);
            this.butt_addbookmain.Name = "butt_addbookmain";
            this.butt_addbookmain.Size = new System.Drawing.Size(124, 34);
            this.butt_addbookmain.TabIndex = 0;
            this.butt_addbookmain.Text = "Add Book";
            this.butt_addbookmain.UseVisualStyleBackColor = true;
            this.butt_addbookmain.Click += new System.EventHandler(this.butt_addbookmain_Click);
            // 
            // butt_deletebookmain
            // 
            this.butt_deletebookmain.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butt_deletebookmain.Location = new System.Drawing.Point(689, 74);
            this.butt_deletebookmain.Name = "butt_deletebookmain";
            this.butt_deletebookmain.Size = new System.Drawing.Size(125, 34);
            this.butt_deletebookmain.TabIndex = 1;
            this.butt_deletebookmain.Text = "Delete Book";
            this.butt_deletebookmain.UseVisualStyleBackColor = true;
            this.butt_deletebookmain.Click += new System.EventHandler(this.butt_deletebookmain_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(377, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Books";
            // 
            // text_addbook
            // 
            this.text_addbook.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_addbook.Location = new System.Drawing.Point(110, 23);
            this.text_addbook.Name = "text_addbook";
            this.text_addbook.Size = new System.Drawing.Size(168, 26);
            this.text_addbook.TabIndex = 4;
            this.text_addbook.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel_addbook
            // 
            this.panel_addbook.Controls.Add(this.butt_addbook);
            this.panel_addbook.Controls.Add(this.label1);
            this.panel_addbook.Controls.Add(this.text_addbook);
            this.panel_addbook.Location = new System.Drawing.Point(48, 128);
            this.panel_addbook.Name = "panel_addbook";
            this.panel_addbook.Size = new System.Drawing.Size(344, 226);
            this.panel_addbook.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Book Name";
            // 
            // butt_addbook
            // 
            this.butt_addbook.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butt_addbook.Location = new System.Drawing.Point(110, 136);
            this.butt_addbook.Name = "butt_addbook";
            this.butt_addbook.Size = new System.Drawing.Size(168, 34);
            this.butt_addbook.TabIndex = 6;
            this.butt_addbook.Text = "Add Book";
            this.butt_addbook.UseVisualStyleBackColor = true;
            // 
            // panel_deletebook
            // 
            this.panel_deletebook.Controls.Add(this.butt_deletebook);
            this.panel_deletebook.Controls.Add(this.label3);
            this.panel_deletebook.Controls.Add(this.text_deletebook);
            this.panel_deletebook.Location = new System.Drawing.Point(470, 128);
            this.panel_deletebook.Name = "panel_deletebook";
            this.panel_deletebook.Size = new System.Drawing.Size(344, 226);
            this.panel_deletebook.TabIndex = 7;
            // 
            // butt_deletebook
            // 
            this.butt_deletebook.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butt_deletebook.Location = new System.Drawing.Point(110, 136);
            this.butt_deletebook.Name = "butt_deletebook";
            this.butt_deletebook.Size = new System.Drawing.Size(168, 34);
            this.butt_deletebook.TabIndex = 6;
            this.butt_deletebook.Text = "Delete Book";
            this.butt_deletebook.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Book Name";
            // 
            // text_deletebook
            // 
            this.text_deletebook.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_deletebook.Location = new System.Drawing.Point(110, 23);
            this.text_deletebook.Name = "text_deletebook";
            this.text_deletebook.Size = new System.Drawing.Size(168, 26);
            this.text_deletebook.TabIndex = 4;
            // 
            // panel_book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_deletebook);
            this.Controls.Add(this.panel_addbook);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.butt_deletebookmain);
            this.Controls.Add(this.butt_addbookmain);
            this.Name = "panel_book";
            this.Size = new System.Drawing.Size(851, 501);
            this.Load += new System.EventHandler(this.panel_book_Load);
            this.panel_addbook.ResumeLayout(false);
            this.panel_addbook.PerformLayout();
            this.panel_deletebook.ResumeLayout(false);
            this.panel_deletebook.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butt_addbookmain;
        private System.Windows.Forms.Button butt_deletebookmain;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_addbook;
        private System.Windows.Forms.Panel panel_addbook;
        private System.Windows.Forms.Button butt_addbook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_deletebook;
        private System.Windows.Forms.Button butt_deletebook;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_deletebook;
    }
}
