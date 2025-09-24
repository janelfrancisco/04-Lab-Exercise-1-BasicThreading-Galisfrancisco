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
            this.lbl_ThreadState = new System.Windows.Forms.Label();
            this.btn_Run = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_ThreadState
            // 
            this.lbl_ThreadState.AutoSize = true;
            this.lbl_ThreadState.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ThreadState.Font = new System.Drawing.Font("Ebrima", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ThreadState.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbl_ThreadState.Location = new System.Drawing.Point(65, 92);
            this.lbl_ThreadState.Name = "lbl_ThreadState";
            this.lbl_ThreadState.Size = new System.Drawing.Size(470, 50);
            this.lbl_ThreadState.TabIndex = 0;
            this.lbl_ThreadState.Text = "- Before Starting Thread -";
            this.lbl_ThreadState.Click += new System.EventHandler(this.ThreadState_Click);
            // 
            // btn_Run
            // 
            this.btn_Run.BackColor = System.Drawing.Color.DimGray;
            this.btn_Run.BackgroundImage = global::BasicThreading.Properties.Resources.Dark_Green_Modern_Gradient_Wave_Linktree_Background;
            this.btn_Run.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Run.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Run.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Run.Location = new System.Drawing.Point(224, 224);
            this.btn_Run.Name = "btn_Run";
            this.btn_Run.Size = new System.Drawing.Size(143, 45);
            this.btn_Run.TabIndex = 1;
            this.btn_Run.Text = "Run";
            this.btn_Run.UseVisualStyleBackColor = false;
            this.btn_Run.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmBasicThread
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BasicThreading.Properties.Resources.Dark_Green_Modern_Gradient_Wave_Linktree_Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(590, 356);
            this.Controls.Add(this.btn_Run);
            this.Controls.Add(this.lbl_ThreadState);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "FrmBasicThread";
            this.Text = "FrmBasicThread";
            this.Load += new System.EventHandler(this.FrmBasicThread_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ThreadState;
        private System.Windows.Forms.Button btn_Run;
    }
}

