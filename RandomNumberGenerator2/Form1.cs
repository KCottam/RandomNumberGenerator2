using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomNumberGenerator2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Repeat_Status = false;
            txtLower.Text = "1";
            txtUpper.Text = "10";
            txtCount.Text = "1";
            btnCreateFilter.Text = "Create Filter";
        }

        private void btnRNG_MouseEnter(object sender, EventArgs e)
        {
            //Switch to Tab with randomizing
        }

        String originalText_Upper = "Upper";
        String originalText_Lower = "Lower";
        String originalText_Count = "Count";

        private void txt_Enter(object sender, EventArgs e)
        {
            TextBox these = (sender as TextBox);
            switch (these.Name)
            {
                case "txtUpper":
                    if (these.Text == originalText_Upper)
                        these.Text = "";
                    break;
                case "txtLower":
                    if (these.Text == originalText_Lower)
                        these.Text = "";
                    break;
                case "txtCount":
                    if (these.Text == originalText_Count)
                        these.Text = "";
                    break;
            }
        }
        private void txt_Exit(object sender, EventArgs e)
        {
            TextBox these = (sender as TextBox);
            switch (these.Name)
            {
                case "txtUpper":
                    if (these.Text == "")
                        these.Text = originalText_Upper;
                    break;
                case "txtLower":
                    if (these.Text == "")
                        these.Text = originalText_Lower;
                    break;
                case "txtCount":
                    if (these.Text == "")
                        these.Text = originalText_Count;
                    break;
            }
        }

        private void btnRepeat_Click(object sender, EventArgs e)
        {
            Repeat_Status = !Repeat_Status;
            CheckRange();
        }
        bool repeat_Status;
        bool Repeat_Status
        {
            get
            {
                return repeat_Status;
            }
            set
            {
                repeat_Status = value;
                switch (value)
                {
                    case true:
                        btnRepeat.BackColor = System.Drawing.Color.Maroon;
                        btnRepeat.Text = Repeat_ON;
                        CheckRange();
                        break;
                    case false:
                        btnRepeat.BackColor = System.Drawing.Color.DarkSlateGray;
                        btnRepeat.Text = Repeat_OFF;
                        break;
                }
            }
        }
        string Repeat_ON = "Repeat? No";
        string Repeat_OFF = "Repeat? Yes";

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCreateFilter_Click(object sender, EventArgs e)
        {
            Filter newFilter = new Filter();
            cntrFilters.Controls.Add(newFilter);
        }

        private void btnCreateModification_Click(object sender, EventArgs e)
        {
            Modification newModiication = new Modification();
            cntrModifications.Controls.Add(newModiication);
        }

        private void btnCreateMonitor_Click(object sender, EventArgs e)
        {
            Monitor newMonitor = new Monitor();
            cntrMonitors.Controls.Add(newMonitor);
        }

        int output_Sum;
        int Output_Sum
        {
            get
            {
                return output_Sum;
            }
            set
            {
                output_Sum = value;
                txtOutputSum.Text = String.Format("Sum: {0}", value);
            }
        }

        int Upper;
        int Lower;
        int Count;

        private void btnClearOutput_Click(object sender, EventArgs e)
        {
            ClearOutput();
        }

        private void ClearOutput()
        {
            txtOutput.Text = "";
            Output_Sum = 0;
            txtOutput_NumberOfLines = 1;
            ResetMonitorCount();
        }

        Random RNJesus = new Random();
        int[] Output;
        int[] OutputOriginal;

        private void btnCalc_Click(object sender, EventArgs e)
        {
            Output = new int[Count];
            OutputOriginal = new int[Count];
            switch (Repeat_Status)
            {
                case true:

                    RepeatsTrueCalculation();

                    break;
                case false:

                    RepeatsFalseCalculation();

                    break;
            }

            ModifyCalculation();
            OutputCalculation();
            OutputSumCalculation();

        }

        private void ModifyCalculation()
        {
            for (int i = 0; i < Output.Length; i++)
            {
                foreach (Modification o in cntrModifications.Controls)
                {
                    if (Output[i] <= o.Upper & Output[i] >= o.Lower)
                    {
                        Output[i] = o.Target;
                        break;
                    }
                }
            }
        }

        private void OutputSumCalculation()
        {
            for (int i = 0; i < Output.Length; i++)
            {
                Output_Sum += Output[i];
            }
        }

        int txtOutput_NumberOfLines = 1;
        private void OutputCalculation()
        {
            for (int i = 0; i < Output.Length; i++)
            {

                bool InRange = false;
                foreach (Filter o in cntrFilters.Controls)
                {
                    if (Output[i] <= o.Upper & Output[i] >= o.Lower)
                    {
                        txtOutput.AppendText("[" + txtOutput_NumberOfLines++.ToString() + "]: ");
                        txtOutput.AppendText(Output[i].ToString() + " (" + OutputOriginal[i].ToString() + ")\n", o.Color);
                        InRange = true;
                        break;
                    }
                }

                if (InRange == false)
                {
                    txtOutput.AppendText("[" + txtOutput_NumberOfLines++.ToString() + "]: ");
                    txtOutput.AppendText(Output[i].ToString() + " (" + OutputOriginal[i].ToString() + ")\n", Color.White);
                }

                CheckMonitors(i);
            }
        }

        private void ResetMonitorCount()
        {
            foreach (Monitor o in cntrMonitors.Controls)
            {
                o.Count = 0;
            }
        }

        private void CheckMonitors(int i)
        {
            foreach (Monitor o in cntrMonitors.Controls)
            {
                if (Output[i] <= o.Upper & Output[i] >= o.Lower)
                    o.Count++;

                if (o.Count == o.Target)
                {
                    txtOutput.AppendText("Monitor: " + o.Target + " instances of an output between " + o.Lower + " and " + o.Upper + " have been found!\n", Color.LightGoldenrodYellow);
                    o.Count++;
                }
            }
        }

        private void RepeatsFalseCalculation()
        {
            for (int i = 0; i < Output.Length; i++)
            {
                Output[i] = RNJesus.Next(Lower, (Upper + 1));
                OutputOriginal[i] = Output[i];
            }
        }

        private void RepeatsTrueCalculation()
        {
            List<int> AvailableIntegers = new List<int>();

            for (int i = Lower; i <= Upper; i++)
            {
                AvailableIntegers.Add(i);
            }

            for (int i = 0; i < Output.Length; i++)
            {
                int Answer;
                do
                {
                    Answer = RNJesus.Next(Lower, (Upper + 1));
                } while (!AvailableIntegers.Remove(Answer));
                Output[i] = Answer;
                OutputOriginal[i] = Output[i];
            }
        }

        private void txtLower_TextChanged(object sender, EventArgs e)
        {
            if (Int32.TryParse(txtLower.Text, out Lower))
                txtLower.BackColor = System.Drawing.SystemColors.Window;

            else
                txtLower.BackColor = System.Drawing.Color.Pink;
            CheckText();
            if (Repeat_Status == true)
                CheckRange();
        }
        private void txtUpper_TextChanged(object sender, EventArgs e)
        {
            if (Int32.TryParse(txtUpper.Text, out Upper))
                txtUpper.BackColor = System.Drawing.SystemColors.Window;
            else
                txtUpper.BackColor = System.Drawing.Color.Pink;
            CheckText();
            if (Repeat_Status == true)
                CheckRange();
        }
        private void CheckText()
        {
            if (Lower >= Upper)
                txtLower.BackColor = System.Drawing.Color.Pink;
            else
                txtLower.BackColor = System.Drawing.SystemColors.Window;

            if (Upper <= Lower)
                txtUpper.BackColor = System.Drawing.Color.Pink;
            else
                txtUpper.BackColor = System.Drawing.SystemColors.Window;
        }

        private void CheckRange()
        {
            if (Count > Upper - Lower + 1)
                txtCount.BackColor = System.Drawing.Color.Pink;
            else
                txtCount.BackColor = System.Drawing.SystemColors.Window;
        }

        private void txtCount_TextChanged(object sender, EventArgs e)
        {
            if (Repeat_Status == true)
                CheckRange();
            if (Int32.TryParse(txtCount.Text, out Count))
                txtCount.BackColor = System.Drawing.SystemColors.Window;
            else
                txtCount.BackColor = System.Drawing.Color.Pink;
            if (Count <= 0)
                txtCount.BackColor = System.Drawing.Color.Pink;
        }

        List<Control> FilterDeletion = new List<Control>();

        private void btnClearFilters_Click(object sender, EventArgs e)
        {
            foreach (var i in cntrFilters.Controls)
            {
                FilterDeletion.Add(i as Control);
            }

            foreach (var i in FilterDeletion)
            {
                i.Dispose();
            }

            FilterDeletion = new List<Control>();
        }

        private void txtOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcReset_Click(object sender, EventArgs e)
        {
            btnClearOutput_Click(this, e);
            btnCalc_Click(this, e);
        }

        private void btnClearModiiers_Click(object sender, EventArgs e)
        {
            foreach (var i in cntrModifications.Controls)
            {
                FilterDeletion.Add(i as Control);
            }

            foreach (var i in FilterDeletion)
            {
                i.Dispose();
            }

            FilterDeletion = new List<Control>();
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            switch (e.TabPageIndex)
            {
                case 0:

                    btnCreateFilter.Click -= btnCreateModification_Click;
                    btnCreateFilter.Click -= btnCreateMonitor_Click;
                    btnCreateFilter.Click += btnCreateFilter_Click;
                    btnCreateFilter.Text = "Create Filter";

                    break;
                case 1:

                    btnCreateFilter.Click -= btnCreateFilter_Click;
                    btnCreateFilter.Click -= btnCreateMonitor_Click;
                    btnCreateFilter.Click += btnCreateModification_Click;
                    btnCreateFilter.Text = "Create Mod";

                    break;
                case 2:

                    btnCreateFilter.Click -= btnCreateFilter_Click;
                    btnCreateFilter.Click -= btnCreateModification_Click;
                    btnCreateFilter.Click += btnCreateMonitor_Click;
                    btnCreateFilter.Text = "Create Monitor";

                    break;
            }
        }

        private void btnClearMonitors_Click(object sender, EventArgs e)
        {
            foreach (var i in cntrMonitors.Controls)
            {
                FilterDeletion.Add(i as Control);
            }

            foreach (var i in FilterDeletion)
            {
                i.Dispose();
            }

            FilterDeletion = new List<Control>();
        }
    }

    public static class RichTextBoxExtensions
    {
        public static void AppendText(this RichTextBox box, string text, Color color)
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;

            box.SelectionColor = color;
            box.AppendText(text);
            box.SelectionColor = box.ForeColor;
        }
    }
}
