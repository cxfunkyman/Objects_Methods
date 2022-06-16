namespace Objects_Methods
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
            this.btnSetData = new System.Windows.Forms.Button();
            this.btnGetData = new System.Windows.Forms.Button();
            this.labelInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSetData
            // 
            this.btnSetData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetData.Location = new System.Drawing.Point(295, 12);
            this.btnSetData.Name = "btnSetData";
            this.btnSetData.Size = new System.Drawing.Size(226, 108);
            this.btnSetData.TabIndex = 0;
            this.btnSetData.Text = "Set Data";
            this.btnSetData.UseVisualStyleBackColor = true;
            this.btnSetData.Click += new System.EventHandler(this.btnSetData_Click);
            // 
            // btnGetData
            // 
            this.btnGetData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetData.Location = new System.Drawing.Point(295, 144);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(226, 108);
            this.btnGetData.TabIndex = 1;
            this.btnGetData.Text = "Get Data";
            this.btnGetData.UseVisualStyleBackColor = true;
            this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo.Location = new System.Drawing.Point(57, 12);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(0, 24);
            this.labelInfo.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 265);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.btnGetData);
            this.Controls.Add(this.btnSetData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSetData;
        private System.Windows.Forms.Button btnGetData;
        private System.Windows.Forms.Label labelInfo;
    }
}

