namespace RandomNumberGenerator2
{
    partial class Monitor
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtLower = new System.Windows.Forms.TextBox();
            this.txtUpper = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnRemove = new System.Windows.Forms.Button();
            this.txtTarget = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Notify when ... instances of ... to ...";
            // 
            // txtLower
            // 
            this.txtLower.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLower.Location = new System.Drawing.Point(101, 27);
            this.txtLower.Name = "txtLower";
            this.txtLower.Size = new System.Drawing.Size(90, 26);
            this.txtLower.TabIndex = 1;
            this.txtLower.Text = "Lower";
            this.txtLower.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLower.TextChanged += new System.EventHandler(this.txtLower_TextChanged);
            this.txtLower.Enter += new System.EventHandler(this.txt_Enter);
            this.txtLower.Leave += new System.EventHandler(this.txt_Exit);
            // 
            // txtUpper
            // 
            this.txtUpper.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpper.Location = new System.Drawing.Point(197, 27);
            this.txtUpper.Name = "txtUpper";
            this.txtUpper.Size = new System.Drawing.Size(90, 26);
            this.txtUpper.TabIndex = 2;
            this.txtUpper.Text = "Upper";
            this.txtUpper.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUpper.TextChanged += new System.EventHandler(this.txtUpper_TextChanged);
            this.txtUpper.Enter += new System.EventHandler(this.txt_Enter);
            this.txtUpper.Leave += new System.EventHandler(this.txt_Exit);
            // 
            // colorDialog1
            // 
            this.colorDialog1.AllowFullOpen = false;
            this.colorDialog1.AnyColor = true;
            this.colorDialog1.SolidColorOnly = true;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Red;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemove.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(267, 5);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(20, 20);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "X";
            this.btnRemove.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // txtTarget
            // 
            this.txtTarget.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTarget.Location = new System.Drawing.Point(5, 27);
            this.txtTarget.Name = "txtTarget";
            this.txtTarget.Size = new System.Drawing.Size(90, 26);
            this.txtTarget.TabIndex = 5;
            this.txtTarget.Text = "Target";
            this.txtTarget.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTarget.TextChanged += new System.EventHandler(this.txtTarget_TextChanged);
            this.txtTarget.Enter += new System.EventHandler(this.txt_Enter);
            this.txtTarget.Leave += new System.EventHandler(this.txt_Exit);
            // 
            // Monitor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.txtTarget);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.txtUpper);
            this.Controls.Add(this.txtLower);
            this.Controls.Add(this.label1);
            this.Name = "Monitor";
            this.Size = new System.Drawing.Size(293, 61);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLower;
        private System.Windows.Forms.TextBox txtUpper;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox txtTarget;
    }
}
