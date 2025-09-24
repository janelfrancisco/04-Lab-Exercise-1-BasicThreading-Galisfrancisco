namespace BasicThreading
{
    partial class FrmBasicThread
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
            this.ThreadState = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ThreadState
            // 
            this.ThreadState.AutoSize = true;
            this.ThreadState.Font = new System.Drawing.Font("Ebrima", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThreadState.Location = new System.Drawing.Point(65, 84);
            this.ThreadState.Name = "ThreadState";
            this.ThreadState.Size = new System.Drawing.Size(470, 50);
            this.ThreadState.TabIndex = 0;
            this.ThreadState.Text = "- Before Starting Thread -";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(230, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "Run";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmBasicThread
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 356);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ThreadState);
            this.Name = "FrmBasicThread";
            this.Text = "FrmBasicThread";
            this.Load += new System.EventHandler(this.FrmBasicThread_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ThreadState;
        private System.Windows.Forms.Button button1;
    }
}

