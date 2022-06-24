
namespace PresentationLayer
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
            this.button1 = new System.Windows.Forms.Button();
            this.post_btn = new System.Windows.Forms.Button();
            this.cmnt_btn = new System.Windows.Forms.Button();
            this.tweeter_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(87, 51);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 22);
            this.button1.TabIndex = 0;
            this.button1.Text = "User CRUD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // post_btn
            // 
            this.post_btn.Location = new System.Drawing.Point(87, 98);
            this.post_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.post_btn.Name = "post_btn";
            this.post_btn.Size = new System.Drawing.Size(82, 22);
            this.post_btn.TabIndex = 1;
            this.post_btn.Text = "Post CRUD";
            this.post_btn.UseVisualStyleBackColor = true;
            this.post_btn.Click += new System.EventHandler(this.post_btn_Click);
            // 
            // cmnt_btn
            // 
            this.cmnt_btn.Location = new System.Drawing.Point(72, 146);
            this.cmnt_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmnt_btn.Name = "cmnt_btn";
            this.cmnt_btn.Size = new System.Drawing.Size(113, 22);
            this.cmnt_btn.TabIndex = 2;
            this.cmnt_btn.Text = "Comment CRUD";
            this.cmnt_btn.UseVisualStyleBackColor = true;
            this.cmnt_btn.Click += new System.EventHandler(this.cmnt_btn_Click);
            // 
            // tweeter_btn
            // 
            this.tweeter_btn.Location = new System.Drawing.Point(72, 191);
            this.tweeter_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tweeter_btn.Name = "tweeter_btn";
            this.tweeter_btn.Size = new System.Drawing.Size(113, 22);
            this.tweeter_btn.TabIndex = 3;
            this.tweeter_btn.Text = "Enter Tweeter";
            this.tweeter_btn.UseVisualStyleBackColor = true;
            this.tweeter_btn.Click += new System.EventHandler(this.tweeter_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.Location = new System.Drawing.Point(87, 239);
            this.exit_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(82, 22);
            this.exit_btn.TabIndex = 4;
            this.exit_btn.Text = "Exit";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 338);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.tweeter_btn);
            this.Controls.Add(this.cmnt_btn);
            this.Controls.Add(this.post_btn);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button post_btn;
        private System.Windows.Forms.Button cmnt_btn;
        private System.Windows.Forms.Button tweeter_btn;
        private System.Windows.Forms.Button exit_btn;
    }
}