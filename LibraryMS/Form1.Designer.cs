namespace LibraryMS
{
    partial class Form_Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Home));
            this.panel1 = new System.Windows.Forms.Panel();
            this.logoname = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.butt_close = new System.Windows.Forms.Button();
            this.butt_return = new System.Windows.Forms.Button();
            this.butt_issue = new System.Windows.Forms.Button();
            this.butt_user = new System.Windows.Forms.Button();
            this.butt_books = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel_user = new LibraryMS.User();
            this.panel_return = new LibraryMS.Return();
            this.panel_issue = new LibraryMS.Issue();
            this.panel_book = new LibraryMS.panel_book();
            this.panel1.SuspendLayout();
            this.logoname.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.logoname);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(155, 501);
            this.panel1.TabIndex = 0;
            // 
            // logoname
            // 
            this.logoname.Controls.Add(this.label1);
            this.logoname.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoname.Location = new System.Drawing.Point(0, 0);
            this.logoname.Name = "logoname";
            this.logoname.Size = new System.Drawing.Size(155, 37);
            this.logoname.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "BrickSquad";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.butt_close);
            this.panel2.Controls.Add(this.butt_return);
            this.panel2.Controls.Add(this.butt_issue);
            this.panel2.Controls.Add(this.butt_user);
            this.panel2.Controls.Add(this.butt_books);
            this.panel2.Location = new System.Drawing.Point(0, 214);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(155, 249);
            this.panel2.TabIndex = 5;
            // 
            // butt_close
            // 
            this.butt_close.Dock = System.Windows.Forms.DockStyle.Top;
            this.butt_close.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butt_close.Location = new System.Drawing.Point(0, 188);
            this.butt_close.Name = "butt_close";
            this.butt_close.Size = new System.Drawing.Size(155, 47);
            this.butt_close.TabIndex = 4;
            this.butt_close.Text = "Exit";
            this.butt_close.UseVisualStyleBackColor = true;
            this.butt_close.Click += new System.EventHandler(this.butt_close_Click);
            // 
            // butt_return
            // 
            this.butt_return.Dock = System.Windows.Forms.DockStyle.Top;
            this.butt_return.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butt_return.Location = new System.Drawing.Point(0, 141);
            this.butt_return.Name = "butt_return";
            this.butt_return.Size = new System.Drawing.Size(155, 47);
            this.butt_return.TabIndex = 3;
            this.butt_return.Text = "Return";
            this.butt_return.UseVisualStyleBackColor = true;
            this.butt_return.Click += new System.EventHandler(this.butt_return_Click);
            // 
            // butt_issue
            // 
            this.butt_issue.Dock = System.Windows.Forms.DockStyle.Top;
            this.butt_issue.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butt_issue.Location = new System.Drawing.Point(0, 94);
            this.butt_issue.Name = "butt_issue";
            this.butt_issue.Size = new System.Drawing.Size(155, 47);
            this.butt_issue.TabIndex = 2;
            this.butt_issue.Text = "Issue";
            this.butt_issue.UseVisualStyleBackColor = true;
            this.butt_issue.Click += new System.EventHandler(this.butt_issue_Click);
            // 
            // butt_user
            // 
            this.butt_user.Dock = System.Windows.Forms.DockStyle.Top;
            this.butt_user.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butt_user.Location = new System.Drawing.Point(0, 47);
            this.butt_user.Name = "butt_user";
            this.butt_user.Size = new System.Drawing.Size(155, 47);
            this.butt_user.TabIndex = 1;
            this.butt_user.Text = "User";
            this.butt_user.UseVisualStyleBackColor = true;
            this.butt_user.Click += new System.EventHandler(this.butt_user_Click);
            // 
            // butt_books
            // 
            this.butt_books.Dock = System.Windows.Forms.DockStyle.Top;
            this.butt_books.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butt_books.Location = new System.Drawing.Point(0, 0);
            this.butt_books.Name = "butt_books";
            this.butt_books.Size = new System.Drawing.Size(155, 47);
            this.butt_books.TabIndex = 0;
            this.butt_books.Text = "Book";
            this.butt_books.UseVisualStyleBackColor = true;
            this.butt_books.Click += new System.EventHandler(this.butt_books_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 178);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel_user);
            this.panel3.Controls.Add(this.panel_return);
            this.panel3.Controls.Add(this.panel_issue);
            this.panel3.Controls.Add(this.panel_book);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(161, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(851, 501);
            this.panel3.TabIndex = 1;
            // 
            // panel_user
            // 
            this.panel_user.Location = new System.Drawing.Point(0, 0);
            this.panel_user.Name = "panel_user";
            this.panel_user.Size = new System.Drawing.Size(851, 501);
            this.panel_user.TabIndex = 3;
            // 
            // panel_return
            // 
            this.panel_return.Location = new System.Drawing.Point(0, 0);
            this.panel_return.Name = "panel_return";
            this.panel_return.Size = new System.Drawing.Size(851, 501);
            this.panel_return.TabIndex = 2;
            // 
            // panel_issue
            // 
            this.panel_issue.Location = new System.Drawing.Point(0, 0);
            this.panel_issue.Name = "panel_issue";
            this.panel_issue.Size = new System.Drawing.Size(851, 501);
            this.panel_issue.TabIndex = 1;
            // 
            // panel_book
            // 
            this.panel_book.Location = new System.Drawing.Point(0, 0);
            this.panel_book.Name = "panel_book";
            this.panel_book.Size = new System.Drawing.Size(851, 501);
            this.panel_book.TabIndex = 0;
            // 
            // Form_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 501);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Home";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form_Home_Load);
            this.panel1.ResumeLayout(false);
            this.logoname.ResumeLayout(false);
            this.logoname.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel logoname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butt_return;
        private System.Windows.Forms.Button butt_issue;
        private System.Windows.Forms.Button butt_user;
        private System.Windows.Forms.Button butt_books;
        private System.Windows.Forms.Button butt_close;
        private User panel_user;
        private Return panel_return;
        private Issue panel_issue;
        private panel_book panel_book;
    }
}

