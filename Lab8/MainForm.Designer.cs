namespace Lab8
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
            this.btnAddLake = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lbLakeInfo = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnAddLake
            // 
            this.btnAddLake.Location = new System.Drawing.Point(478, 10);
            this.btnAddLake.Name = "btnAddLake";
            this.btnAddLake.Size = new System.Drawing.Size(77, 35);
            this.btnAddLake.TabIndex = 1;
            this.btnAddLake.Text = "Добавить озеро";
            this.btnAddLake.UseVisualStyleBackColor = true;
            this.btnAddLake.Click += new System.EventHandler(this.btnAddLake_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(478, 223);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(77, 26);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lbLakeInfo
            // 
            this.lbLakeInfo.FormattingEnabled = true;
            this.lbLakeInfo.Location = new System.Drawing.Point(14, 10);
            this.lbLakeInfo.Name = "lbLakeInfo";
            this.lbLakeInfo.Size = new System.Drawing.Size(458, 238);
            this.lbLakeInfo.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 261);
            this.Controls.Add(this.lbLakeInfo);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddLake);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторна робота №8";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAddLake;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListBox lbLakeInfo;
    }
}

