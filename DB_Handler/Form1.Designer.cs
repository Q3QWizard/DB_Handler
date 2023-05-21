namespace DB_Handler
{
    partial class Form1
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
            this.Btn_Select_Query = new System.Windows.Forms.Button();
            this.Btn_Select_Query_Where = new System.Windows.Forms.Button();
            this.Btn_Insert_Query = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Select_Query
            // 
            this.Btn_Select_Query.Location = new System.Drawing.Point(12, 12);
            this.Btn_Select_Query.Name = "Btn_Select_Query";
            this.Btn_Select_Query.Size = new System.Drawing.Size(308, 47);
            this.Btn_Select_Query.TabIndex = 0;
            this.Btn_Select_Query.Text = "Select Query";
            this.Btn_Select_Query.UseVisualStyleBackColor = true;
            this.Btn_Select_Query.Click += new System.EventHandler(this.Btn_Select_Query_Click);
            // 
            // Btn_Select_Query_Where
            // 
            this.Btn_Select_Query_Where.Location = new System.Drawing.Point(12, 65);
            this.Btn_Select_Query_Where.Name = "Btn_Select_Query_Where";
            this.Btn_Select_Query_Where.Size = new System.Drawing.Size(308, 47);
            this.Btn_Select_Query_Where.TabIndex = 0;
            this.Btn_Select_Query_Where.Text = "Select Query With Where";
            this.Btn_Select_Query_Where.UseVisualStyleBackColor = true;
            this.Btn_Select_Query_Where.Click += new System.EventHandler(this.Btn_Select_Query_Where_Click);
            // 
            // Btn_Insert_Query
            // 
            this.Btn_Insert_Query.Location = new System.Drawing.Point(12, 118);
            this.Btn_Insert_Query.Name = "Btn_Insert_Query";
            this.Btn_Insert_Query.Size = new System.Drawing.Size(308, 47);
            this.Btn_Insert_Query.TabIndex = 0;
            this.Btn_Insert_Query.Text = "Insert Query";
            this.Btn_Insert_Query.UseVisualStyleBackColor = true;
            this.Btn_Insert_Query.Click += new System.EventHandler(this.Btn_Insert_Query_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 450);
            this.Controls.Add(this.Btn_Insert_Query);
            this.Controls.Add(this.Btn_Select_Query_Where);
            this.Controls.Add(this.Btn_Select_Query);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Select_Query;
        private System.Windows.Forms.Button Btn_Select_Query_Where;
        private System.Windows.Forms.Button Btn_Insert_Query;
    }
}

