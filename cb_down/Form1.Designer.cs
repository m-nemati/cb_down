namespace cb_down
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtPackgeName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDownLink = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnBrowser = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAppSize = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(532, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 58);
            this.button1.TabIndex = 1;
            this.button1.Text = "Get Link";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPackgeName
            // 
            this.txtPackgeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPackgeName.Location = new System.Drawing.Point(184, 41);
            this.txtPackgeName.Name = "txtPackgeName";
            this.txtPackgeName.Size = new System.Drawing.Size(459, 22);
            this.txtPackgeName.TabIndex = 0;
            this.txtPackgeName.TextChanged += new System.EventHandler(this.txtPackgeName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Package Name Or Link:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtDownLink
            // 
            this.txtDownLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDownLink.Location = new System.Drawing.Point(297, 162);
            this.txtDownLink.Name = "txtDownLink";
            this.txtDownLink.ReadOnly = true;
            this.txtDownLink.Size = new System.Drawing.Size(580, 22);
            this.txtDownLink.TabIndex = 5;
            this.txtDownLink.TextChanged += new System.EventHandler(this.txtDownLink_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(181, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Download Link:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopy.Location = new System.Drawing.Point(532, 201);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(111, 58);
            this.btnCopy.TabIndex = 2;
            this.btnCopy.Text = "Copy!";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnBrowser
            // 
            this.btnBrowser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowser.Location = new System.Drawing.Point(649, 201);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(111, 58);
            this.btnBrowser.TabIndex = 3;
            this.btnBrowser.Text = "Open";
            this.btnBrowser.UseVisualStyleBackColor = true;
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "App Size:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblAppSize
            // 
            this.lblAppSize.AutoSize = true;
            this.lblAppSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppSize.Location = new System.Drawing.Point(93, 165);
            this.lblAppSize.Name = "lblAppSize";
            this.lblAppSize.Size = new System.Drawing.Size(0, 16);
            this.lblAppSize.TabIndex = 8;
            this.lblAppSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAppSize.Click += new System.EventHandler(this.lblAppSize_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(766, 201);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(111, 58);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 316);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblAppSize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBrowser);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDownLink);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPackgeName);
            this.Controls.Add(this.button1);
            this.MaximumSize = new System.Drawing.Size(923, 355);
            this.MinimumSize = new System.Drawing.Size(923, 355);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CB_Downloader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPackgeName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDownLink;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnBrowser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAppSize;
        private System.Windows.Forms.Button btnClear;
    }
}

