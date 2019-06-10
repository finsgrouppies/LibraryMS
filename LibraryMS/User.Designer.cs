namespace LibraryMS
{
    partial class User
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
            this.label2 = new System.Windows.Forms.Label();
            this.panel_addbook = new System.Windows.Forms.Panel();
            this.butt_addbook = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.text_addbook = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel_addbook.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(337, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Users";
            // 
            // panel_addbook
            // 
            this.panel_addbook.Controls.Add(this.butt_addbook);
            this.panel_addbook.Controls.Add(this.label1);
            this.panel_addbook.Controls.Add(this.text_addbook);
            this.panel_addbook.Location = new System.Drawing.Point(43, 123);
            this.panel_addbook.Name = "panel_addbook";
            this.panel_addbook.Size = new System.Drawing.Size(344, 303);
            this.panel_addbook.TabIndex = 6;
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
            // text_addbook
            // 
            this.text_addbook.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_addbook.Location = new System.Drawing.Point(110, 23);
            this.text_addbook.Name = "text_addbook";
            this.text_addbook.Size = new System.Drawing.Size(168, 26);
            this.text_addbook.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(67, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 34);
            this.button1.TabIndex = 7;
            this.button1.Text = "Add Book";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel_addbook);
            this.Controls.Add(this.label2);
            this.Name = "User";
            this.Size = new System.Drawing.Size(851, 501);
            this.panel_addbook.ResumeLayout(false);
            this.panel_addbook.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel_addbook;
        private System.Windows.Forms.Button butt_addbook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_addbook;
        private System.Windows.Forms.Button button1;
    }
}
