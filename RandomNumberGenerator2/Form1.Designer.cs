namespace RandomNumberGenerator2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnChangeRandomize = new System.Windows.Forms.Button();
            this.pageRandomize = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabFilters = new System.Windows.Forms.TabPage();
            this.cntrFilters = new System.Windows.Forms.FlowLayoutPanel();
            this.btnClearFilters = new System.Windows.Forms.Button();
            this.tabModifiers = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnCalcReset = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnRepeat = new System.Windows.Forms.Button();
            this.btnCreateFilter = new System.Windows.Forms.Button();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.txtLower = new System.Windows.Forms.TextBox();
            this.txtUpper = new System.Windows.Forms.TextBox();
            this.grpOutput = new System.Windows.Forms.GroupBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtOutputSum = new System.Windows.Forms.TextBox();
            this.btnClearOutput = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.RichTextBox();
            this.btnClearModifications = new System.Windows.Forms.Button();
            this.cntrModifications = new System.Windows.Forms.FlowLayoutPanel();
            this.tabMonitors = new System.Windows.Forms.TabPage();
            this.btnClearMonitors = new System.Windows.Forms.Button();
            this.cntrMonitors = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pageRandomize.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabFilters.SuspendLayout();
            this.tabModifiers.SuspendLayout();
            this.panel4.SuspendLayout();
            this.grpOutput.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tabMonitors.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 30);
            this.panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold);
            this.btnExit.Location = new System.Drawing.Point(772, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(25, 25);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Random Number Generator by Kace Cottam\r\n";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CadetBlue;
            this.panel2.Controls.Add(this.btnChangeRandomize);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(150, 570);
            this.panel2.TabIndex = 1;
            // 
            // btnChangeRandomize
            // 
            this.btnChangeRandomize.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnChangeRandomize.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChangeRandomize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChangeRandomize.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeRandomize.ForeColor = System.Drawing.Color.White;
            this.btnChangeRandomize.Location = new System.Drawing.Point(5, 5);
            this.btnChangeRandomize.Name = "btnChangeRandomize";
            this.btnChangeRandomize.Size = new System.Drawing.Size(140, 140);
            this.btnChangeRandomize.TabIndex = 0;
            this.btnChangeRandomize.Text = "Randomize";
            this.btnChangeRandomize.UseVisualStyleBackColor = false;
            // 
            // pageRandomize
            // 
            this.pageRandomize.Controls.Add(this.panel3);
            this.pageRandomize.Controls.Add(this.grpOutput);
            this.pageRandomize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pageRandomize.Location = new System.Drawing.Point(150, 30);
            this.pageRandomize.Name = "pageRandomize";
            this.pageRandomize.Padding = new System.Windows.Forms.Padding(5);
            this.pageRandomize.Size = new System.Drawing.Size(650, 570);
            this.pageRandomize.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tabControl1);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(5, 5);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.panel3.Size = new System.Drawing.Size(440, 560);
            this.panel3.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabFilters);
            this.tabControl1.Controls.Add(this.tabModifiers);
            this.tabControl1.Controls.Add(this.tabMonitors);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(111, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(324, 560);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabFilters
            // 
            this.tabFilters.BackColor = System.Drawing.Color.SteelBlue;
            this.tabFilters.Controls.Add(this.cntrFilters);
            this.tabFilters.Controls.Add(this.btnClearFilters);
            this.tabFilters.ForeColor = System.Drawing.Color.SteelBlue;
            this.tabFilters.Location = new System.Drawing.Point(4, 28);
            this.tabFilters.Name = "tabFilters";
            this.tabFilters.Size = new System.Drawing.Size(316, 528);
            this.tabFilters.TabIndex = 0;
            this.tabFilters.Text = "Filters";
            // 
            // cntrFilters
            // 
            this.cntrFilters.AutoScroll = true;
            this.cntrFilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cntrFilters.Location = new System.Drawing.Point(0, 0);
            this.cntrFilters.Name = "cntrFilters";
            this.cntrFilters.Size = new System.Drawing.Size(316, 476);
            this.cntrFilters.TabIndex = 6;
            // 
            // btnClearFilters
            // 
            this.btnClearFilters.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnClearFilters.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnClearFilters.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClearFilters.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearFilters.ForeColor = System.Drawing.Color.White;
            this.btnClearFilters.Location = new System.Drawing.Point(0, 476);
            this.btnClearFilters.Name = "btnClearFilters";
            this.btnClearFilters.Size = new System.Drawing.Size(316, 52);
            this.btnClearFilters.TabIndex = 6;
            this.btnClearFilters.Text = "Clear Filters";
            this.btnClearFilters.UseVisualStyleBackColor = false;
            this.btnClearFilters.Click += new System.EventHandler(this.btnClearFilters_Click);
            // 
            // tabModifiers
            // 
            this.tabModifiers.BackColor = System.Drawing.Color.SteelBlue;
            this.tabModifiers.Controls.Add(this.cntrModifications);
            this.tabModifiers.Controls.Add(this.btnClearModifications);
            this.tabModifiers.ForeColor = System.Drawing.Color.SteelBlue;
            this.tabModifiers.Location = new System.Drawing.Point(4, 28);
            this.tabModifiers.Name = "tabModifiers";
            this.tabModifiers.Size = new System.Drawing.Size(316, 528);
            this.tabModifiers.TabIndex = 1;
            this.tabModifiers.Text = "Modifiers";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnCalcReset);
            this.panel4.Controls.Add(this.btnCalc);
            this.panel4.Controls.Add(this.btnRepeat);
            this.panel4.Controls.Add(this.btnCreateFilter);
            this.panel4.Controls.Add(this.txtCount);
            this.panel4.Controls.Add(this.txtLower);
            this.panel4.Controls.Add(this.txtUpper);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(5);
            this.panel4.Size = new System.Drawing.Size(111, 560);
            this.panel4.TabIndex = 1;
            // 
            // btnCalcReset
            // 
            this.btnCalcReset.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnCalcReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalcReset.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcReset.ForeColor = System.Drawing.Color.White;
            this.btnCalcReset.Location = new System.Drawing.Point(6, 473);
            this.btnCalcReset.Name = "btnCalcReset";
            this.btnCalcReset.Size = new System.Drawing.Size(99, 84);
            this.btnCalcReset.TabIndex = 6;
            this.btnCalcReset.Text = "Calculate and Reset Output";
            this.btnCalcReset.UseVisualStyleBackColor = false;
            this.btnCalcReset.Click += new System.EventHandler(this.btnCalcReset_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnCalc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.ForeColor = System.Drawing.Color.White;
            this.btnCalc.Location = new System.Drawing.Point(6, 369);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(99, 98);
            this.btnCalc.TabIndex = 5;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = false;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnRepeat
            // 
            this.btnRepeat.BackColor = System.Drawing.Color.Maroon;
            this.btnRepeat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRepeat.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRepeat.ForeColor = System.Drawing.Color.White;
            this.btnRepeat.Location = new System.Drawing.Point(6, 289);
            this.btnRepeat.Name = "btnRepeat";
            this.btnRepeat.Size = new System.Drawing.Size(99, 74);
            this.btnRepeat.TabIndex = 4;
            this.btnRepeat.Text = "Repeat? null";
            this.btnRepeat.UseVisualStyleBackColor = false;
            this.btnRepeat.Click += new System.EventHandler(this.btnRepeat_Click);
            // 
            // btnCreateFilter
            // 
            this.btnCreateFilter.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnCreateFilter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreateFilter.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateFilter.ForeColor = System.Drawing.Color.White;
            this.btnCreateFilter.Location = new System.Drawing.Point(6, 134);
            this.btnCreateFilter.Name = "btnCreateFilter";
            this.btnCreateFilter.Size = new System.Drawing.Size(99, 149);
            this.btnCreateFilter.TabIndex = 3;
            this.btnCreateFilter.Text = "New Filter/Mod/ Monitor";
            this.btnCreateFilter.UseVisualStyleBackColor = false;
            this.btnCreateFilter.Click += new System.EventHandler(this.btnCreateFilter_Click);
            // 
            // txtCount
            // 
            this.txtCount.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCount.Location = new System.Drawing.Point(6, 94);
            this.txtCount.Margin = new System.Windows.Forms.Padding(5);
            this.txtCount.MaximumSize = new System.Drawing.Size(100, 32);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(100, 32);
            this.txtCount.TabIndex = 2;
            this.txtCount.Text = "Count";
            this.txtCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCount.TextChanged += new System.EventHandler(this.txtCount_TextChanged);
            this.txtCount.Enter += new System.EventHandler(this.txt_Enter);
            this.txtCount.Leave += new System.EventHandler(this.txt_Exit);
            // 
            // txtLower
            // 
            this.txtLower.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLower.Location = new System.Drawing.Point(6, 10);
            this.txtLower.Margin = new System.Windows.Forms.Padding(5);
            this.txtLower.MaximumSize = new System.Drawing.Size(100, 32);
            this.txtLower.Name = "txtLower";
            this.txtLower.Size = new System.Drawing.Size(100, 32);
            this.txtLower.TabIndex = 1;
            this.txtLower.Text = "Lower";
            this.txtLower.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLower.TextChanged += new System.EventHandler(this.txtLower_TextChanged);
            this.txtLower.Enter += new System.EventHandler(this.txt_Enter);
            this.txtLower.Leave += new System.EventHandler(this.txt_Exit);
            // 
            // txtUpper
            // 
            this.txtUpper.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpper.Location = new System.Drawing.Point(6, 52);
            this.txtUpper.Margin = new System.Windows.Forms.Padding(5);
            this.txtUpper.MaximumSize = new System.Drawing.Size(100, 32);
            this.txtUpper.Name = "txtUpper";
            this.txtUpper.Size = new System.Drawing.Size(100, 32);
            this.txtUpper.TabIndex = 0;
            this.txtUpper.Text = "Upper";
            this.txtUpper.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUpper.TextChanged += new System.EventHandler(this.txtUpper_TextChanged);
            this.txtUpper.Enter += new System.EventHandler(this.txt_Enter);
            this.txtUpper.Leave += new System.EventHandler(this.txt_Exit);
            // 
            // grpOutput
            // 
            this.grpOutput.BackColor = System.Drawing.Color.SteelBlue;
            this.grpOutput.Controls.Add(this.panel5);
            this.grpOutput.Controls.Add(this.txtOutput);
            this.grpOutput.Dock = System.Windows.Forms.DockStyle.Right;
            this.grpOutput.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOutput.ForeColor = System.Drawing.Color.White;
            this.grpOutput.Location = new System.Drawing.Point(445, 5);
            this.grpOutput.Name = "grpOutput";
            this.grpOutput.Size = new System.Drawing.Size(200, 560);
            this.grpOutput.TabIndex = 0;
            this.grpOutput.TabStop = false;
            this.grpOutput.Text = "Output";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtOutputSum);
            this.panel5.Controls.Add(this.btnClearOutput);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(3, 473);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(194, 84);
            this.panel5.TabIndex = 6;
            // 
            // txtOutputSum
            // 
            this.txtOutputSum.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtOutputSum.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtOutputSum.Location = new System.Drawing.Point(0, 0);
            this.txtOutputSum.Name = "txtOutputSum";
            this.txtOutputSum.Size = new System.Drawing.Size(194, 32);
            this.txtOutputSum.TabIndex = 5;
            this.txtOutputSum.Text = "Sum: 0";
            // 
            // btnClearOutput
            // 
            this.btnClearOutput.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnClearOutput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnClearOutput.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClearOutput.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearOutput.ForeColor = System.Drawing.Color.White;
            this.btnClearOutput.Location = new System.Drawing.Point(0, 32);
            this.btnClearOutput.Name = "btnClearOutput";
            this.btnClearOutput.Size = new System.Drawing.Size(194, 52);
            this.btnClearOutput.TabIndex = 4;
            this.btnClearOutput.Text = "Clear Output";
            this.btnClearOutput.UseVisualStyleBackColor = false;
            this.btnClearOutput.Click += new System.EventHandler(this.btnClearOutput_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.BackColor = System.Drawing.Color.SteelBlue;
            this.txtOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOutput.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtOutput.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.ForeColor = System.Drawing.Color.White;
            this.txtOutput.Location = new System.Drawing.Point(3, 28);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(194, 439);
            this.txtOutput.TabIndex = 0;
            this.txtOutput.Text = "";
            this.txtOutput.TextChanged += new System.EventHandler(this.txtOutput_TextChanged);
            // 
            // btnClearModifications
            // 
            this.btnClearModifications.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnClearModifications.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnClearModifications.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClearModifications.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearModifications.ForeColor = System.Drawing.Color.White;
            this.btnClearModifications.Location = new System.Drawing.Point(0, 476);
            this.btnClearModifications.Name = "btnClearModifications";
            this.btnClearModifications.Size = new System.Drawing.Size(316, 52);
            this.btnClearModifications.TabIndex = 7;
            this.btnClearModifications.Text = "Clear Modifications";
            this.btnClearModifications.UseVisualStyleBackColor = false;
            this.btnClearModifications.Click += new System.EventHandler(this.btnClearModiiers_Click);
            // 
            // cntrModifications
            // 
            this.cntrModifications.AutoScroll = true;
            this.cntrModifications.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cntrModifications.Location = new System.Drawing.Point(0, 0);
            this.cntrModifications.Name = "cntrModifications";
            this.cntrModifications.Size = new System.Drawing.Size(316, 476);
            this.cntrModifications.TabIndex = 8;
            // 
            // tabMonitors
            // 
            this.tabMonitors.BackColor = System.Drawing.Color.SteelBlue;
            this.tabMonitors.Controls.Add(this.cntrMonitors);
            this.tabMonitors.Controls.Add(this.btnClearMonitors);
            this.tabMonitors.Location = new System.Drawing.Point(4, 28);
            this.tabMonitors.Name = "tabMonitors";
            this.tabMonitors.Size = new System.Drawing.Size(316, 528);
            this.tabMonitors.TabIndex = 2;
            this.tabMonitors.Text = "Monitors";
            // 
            // btnClearMonitors
            // 
            this.btnClearMonitors.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnClearMonitors.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnClearMonitors.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClearMonitors.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearMonitors.ForeColor = System.Drawing.Color.White;
            this.btnClearMonitors.Location = new System.Drawing.Point(0, 476);
            this.btnClearMonitors.Name = "btnClearMonitors";
            this.btnClearMonitors.Size = new System.Drawing.Size(316, 52);
            this.btnClearMonitors.TabIndex = 8;
            this.btnClearMonitors.Text = "Clear Monitors";
            this.btnClearMonitors.UseVisualStyleBackColor = false;
            this.btnClearMonitors.Click += new System.EventHandler(this.btnClearMonitors_Click);
            // 
            // cntrMonitors
            // 
            this.cntrMonitors.AutoScroll = true;
            this.cntrMonitors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cntrMonitors.Location = new System.Drawing.Point(0, 0);
            this.cntrMonitors.Name = "cntrMonitors";
            this.cntrMonitors.Size = new System.Drawing.Size(316, 476);
            this.cntrMonitors.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.pageRandomize);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pageRandomize.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabFilters.ResumeLayout(false);
            this.tabModifiers.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.grpOutput.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.tabMonitors.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnChangeRandomize;
        private System.Windows.Forms.Panel pageRandomize;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtUpper;
        private System.Windows.Forms.GroupBox grpOutput;
        private System.Windows.Forms.RichTextBox txtOutput;
        private System.Windows.Forms.Button btnRepeat;
        private System.Windows.Forms.Button btnCreateFilter;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.TextBox txtLower;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnClearOutput;
        private System.Windows.Forms.TextBox txtOutputSum;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnCalcReset;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabFilters;
        private System.Windows.Forms.FlowLayoutPanel cntrFilters;
        private System.Windows.Forms.Button btnClearFilters;
        private System.Windows.Forms.TabPage tabModifiers;
        private System.Windows.Forms.Button btnClearModifications;
        private System.Windows.Forms.FlowLayoutPanel cntrModifications;
        private System.Windows.Forms.TabPage tabMonitors;
        private System.Windows.Forms.FlowLayoutPanel cntrMonitors;
        private System.Windows.Forms.Button btnClearMonitors;
    }
}

