using Microsoft.Office.Interop;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;


namespace OkumaTools
{
    
    public partial class ToolList : Form
    {
        bool ran = false;
        int[,] intToolNumbers = null; //get int array ready
        int[] okuma5XSpecialTools = { 3, 11, 39, 44, 47, 49, 94, 108, 112, 122, 128, 149, 153, 158, 159, 166, 167, 169, 171, 172, 173, 181, 182, 183, 185, 188, 191, 193, 198, 12, 98, 164, 194 };
        List<int> pullMeTools = new List<int>();
        List<int> setMeTools = new List<int>();
        List<int> machineTools = new List<int>();
        List<int> combinedPartTools = new List<int>();   
        
		public ToolList()
        {
            InitializeComponent();
        }

        private void ToolList_Load(object sender, EventArgs e)
        {

        }

        private void buttonOpenFileDialog_Click(object sender, EventArgs e)
        {
            //Locate file, place file in textbox
            openFileDialog1.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please use Browse button and locate TOP file", "Help");

        }

        private void buttonExitProgram_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit?", "Close Program", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }


        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

            this.Activate();
            string[] rawToolData = new string[59];
            string[] toolFile = openFileDialog1.FileNames;
            foreach (string toolData in toolFile)
            {
                FileInfo fileInfo = new FileInfo(toolData);
                FileStream fileStream = fileInfo.OpenRead();
                rawToolData = File.ReadAllLines(toolData);
                Application.DoEvents();
                fileStream.Close();
                textBoxTopFile.Text = toolData.ToString();
                parseToolData(rawToolData);
            }
        }
        private int[] processedToolData = new int[61];
        private void parseToolData(string[] toolDataIn)
        {
            processedToolData = pullRemainingNumbers(toolDataIn).OrderBy(num => num).ToArray();
            processedToolData = processedToolData.Where(val => val != 0).ToArray(); //strip zero

            listBoxCurrentTools.DataSource = processedToolData;

            foreach (int tools in processedToolData)
            {
                machineTools.Add(tools);
            }
            totalToolsTextBox.Text = listBoxCurrentTools.Items.Count.ToString();
        }

        static int[] pullRemainingNumbers(string[] toolDataIn)
        {
            //string txt = "Q,8,R,181M";
            int[] processed = new int[toolDataIn.Length];
            int i = 0;
            foreach (string line in toolDataIn)
            {
                string re1 = ".*?";	// Non-greedy match on filler
                string re2 = "\\d+";	// Uninteresting: int
                string re3 = ".*?";	// Non-greedy match on filler
                string re4 = "(\\d+)";	// Integer Number 1

                Regex r = new Regex(re1 + re2 + re3 + re4, RegexOptions.IgnoreCase | RegexOptions.Singleline);
                Match m = r.Match(line);
                if (m.Success)
                {
                    processed[i] = Convert.ToInt32(m.Groups[1].ToString());
                    i++;
                }
            }
            //re-get first line
            string de1 = ".*?";	// Non-greedy match on filler
            string de2 = "(\\d+)";	// Integer Number 1
            Regex r1 = new Regex(de1 + de2, RegexOptions.IgnoreCase | RegexOptions.Singleline);
            Match m1 = r1.Match(toolDataIn[0]);
            if (m1.Success)
            {
                processed[0] = Convert.ToInt32(m1.Groups[1].ToString());
            }

            return processed;
        }



        private void button2_Click(object sender, EventArgs e)
        {

            richTextBoxEmail.SelectAll();
            Clipboard.SetText(richTextBoxEmail.Text);
        }

        private void rButtonOkumaABC5X_CheckedChanged(object sender, EventArgs e)
        {
            int totalPots = 61;
            if (listBoxCurrentTools.SelectedIndex == -1)
            {
                MessageBox.Show("Please load TOP file first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                rButtonOkumaABC5X.Checked = false;
            }
            else
            {
                if (radioButton2.Checked == false || rButtonOkumaABC5X.Checked == true)
                {
                    int usedTools = Convert.ToInt32(listBoxCurrentTools.Items.Count);
                    textBoxAvailablePotCount.Text = Convert.ToString(totalPots - usedTools);
                    textBoxMachinePotCount.Text = Convert.ToString(totalPots);
                    textBoxUsedPotCount.Text = Convert.ToString(usedTools);
                    float temp = ((float)usedTools / (float)totalPots) * 100;
                    int bar = Convert.ToInt32(Math.Round(temp));
                    machineProgress.Value = bar;
                    if (machineProgress.Value == 100)
                    {
                        machineProgress.SetState(2);
                    }
                    else
                    {
                        machineProgress.SetState(1);
                    }
                    System.Diagnostics.Debug.WriteLine("OkumaRest");
                    //Application.DoEvents();
                }
            }
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            int totalPots = 61;
            if (radioButton2.Checked == true || rButtonOkumaABC5X.Checked == false )
            {
                if (listBoxCurrentTools.SelectedIndex == -1)
                {
                    MessageBox.Show("Please load TOP file first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    radioButton2.Checked = false;
                }
                else
                {
                    int usedTools = Convert.ToInt32(listBoxCurrentTools.Items.Count);
                    textBoxAvailablePotCount.Text = Convert.ToString(totalPots - usedTools);
                    textBoxMachinePotCount.Text = Convert.ToString(totalPots);
                    textBoxUsedPotCount.Text = Convert.ToString(usedTools);
                    float temp = ((float)usedTools / (float)totalPots) * 100;
                    int bar = Convert.ToInt32(Math.Round(temp));
                    machineProgress.Value = bar;
                    if (machineProgress.Value == 100)
                    {
                        machineProgress.SetState(2);
                    }
                    else
                    {
                        machineProgress.SetState(1);
                    }

                    System.Diagnostics.Debug.WriteLine("OkumaD");
                    //Application.DoEvents();
                }
            }
        }

        private void mailToMe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string command = "mailto:[REDACTED]?subject=Okuma Tool Management Questions";
            System.Diagnostics.Process.Start(command);
        }



        private void button1_Click(object sender, EventArgs e)
        {
            openMachineToolListDlg.ShowDialog();
        }

        private void openMachineToolListDlg_FileOk(object sender, CancelEventArgs e)
        {
            //this.Activate();
            string[] toolsInFile;
            string[] toolFile = openMachineToolListDlg.FileNames;
            foreach (string partData in toolFile)
            {
                FileInfo fileInfo = new FileInfo(partData);
                FileStream fileStream = fileInfo.OpenRead();
                toolsInFile = File.ReadAllLines(partData);
                fileStream.Close();
                textBox4.Text = partData.ToString();
                parsePartData(toolsInFile);

            }
        }


        private void parsePartData(string[] partDataIn)
        {


            int count = 1;
            for (int i = 0; i < partDataIn[0].Length; i++)
            {
                char picked = partDataIn[0][i];
                if (picked == ',') { count++; }
            }

            //System.Diagnostics.Debug.WriteLine("Count: " + count);
            string[] partNumbers = new string[count];
            int arrayPos = 0;
            int index = 0;
            for (int i = 0; i < partDataIn[0].Length; i++)
            {
                char comma = partDataIn[0][i];
                if (comma == ',')
                {
                    partNumbers[arrayPos] = partDataIn[0].Substring(index, i - index);
                    index = i + 1;
                    arrayPos++;
                }
            }
            partNumbers[arrayPos] = partDataIn[0].Substring(index);
            partNumberListBox.DataSource = partNumbers;

            for (int i = 0; i < partNumberListBox.Items.Count; i++) { partNumberListBox.SetItemCheckState(i, CheckState.Unchecked); }


            //Start pulling tool numbers to an array 
            string[,] strToolNumbers = new string[partDataIn.Length, count]; // string array first
            intToolNumbers = new int[partDataIn.Length, count]; //get int array ready
            int row = 1;
            int column = 0;
            string[] tempSpot;

            while (row < partDataIn.Length)
            {
                column = 0;
                while (column < count)
                {
                    tempSpot = partDataIn[row].Split(',');
                    foreach (string temp in tempSpot)
                    {
                        strToolNumbers[row, column] = temp;
                        column++;
                    }
                }
                row++;
            }

            //convert string array to int array (trim all letters and crap)
            row = 1;
            column = 0;
            while (row < partDataIn.Length)
            {
                column = 0;
                while (column < count)
                {
                    if (strToolNumbers[row, column] != "")
                    {

                        intToolNumbers[row, column] = Convert.ToInt32(Regex.Replace(strToolNumbers[row, column], "[^0-9.]", ""));
                    }
                    column++;
                }
                row++;
            }

            System.Diagnostics.Debug.WriteLine("Success");
            ran = true;
        }



        private void partNumberListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            partSpecificToolNumbers.DataSource = null;
            int column = partNumberListBox.SelectedIndex;
            List<int> tools = new List<int>();
            if (ran == true)
            {
                if (partNumberListBox.SelectedIndex != -1)
                {
                    for (int i = 0; i < intToolNumbers.GetLength(0); i++)
                    {
                        if (intToolNumbers[i, column] != 0)
                        {
                            tools.Add(intToolNumbers[i, column]);
                        }
                    }
                    System.Diagnostics.Debug.WriteLine("Data in");
                    partSpecificToolNumbers.DataSource = tools;
                }
            }

            Application.DoEvents();
            this.Activate();

        }

        private void generateTextButton_Click(object sender, EventArgs e)
        {
            if (machineTools == null || intToolNumbers == null || radioButton2.Checked == false && rButtonOkumaABC5X.Checked == false)
            {
                MessageBox.Show("Please load .TOP file in Machine tab and/or select the machine in Machine tab and/or load part tools data in Parts tab", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {

                List<int> allNeededTools = new List<int>();
                List<int> dupedPartTools = new List<int>();
                foreach (int selectedJob in partNumberListBox.CheckedIndices)
                {
                    for (int i = 0; i < intToolNumbers.GetLength(0); i++)
                    {
                        if (intToolNumbers[i, selectedJob] != 0)
                        {
                            dupedPartTools.Add(intToolNumbers[i, selectedJob]);
                        }
                    }
                    System.Diagnostics.Debug.WriteLine("STOP");
                }
                dupedPartTools.Sort();
                combinedPartTools = dupedPartTools.Distinct().ToList();
                foreach (int tool in combinedPartTools)
                {
                    allNeededTools.Add(tool);
                }
                System.Diagnostics.Debug.WriteLine("List Made");

                if (radioButton2.Checked == false || rButtonOkumaABC5X.Checked == true) { richTextBoxEmail.Text = "OKUMA 5X TOOLING\n\nFor jobs: \n"; }
                else { richTextBoxEmail.Text = "OKUMAHB -A / -B / -C (Select one) TOOLING\n\nFor jobs: \n"; }

                // Print out selected part numbers
                foreach (object selectedJob in partNumberListBox.CheckedItems)
                {
                    richTextBoxEmail.AppendText(selectedJob.ToString() + "\n");
                }

                richTextBoxEmail.AppendText("\nThe jobs you picked use the following tools: (" + Convert.ToString(combinedPartTools.Count) + " tools total) \n");
                int toolsUsed = combinedPartTools.Count();

                // Print out the combined used tools from selected part numbers
                foreach (int tool in combinedPartTools)
                {
                    richTextBoxEmail.AppendText(tool.ToString() + "\n");
                }

                // Find tools that don't match up to machine list and add to list
                IEnumerable<int> setTools = combinedPartTools.Except(machineTools);
                
                richTextBoxEmail.AppendText("\nThe following tools numbers are missing and must be set: (" + Convert.ToString(setTools.Count()) + " tools required)\n");
                int buildTools = setTools.Count();

                // Print above list
                foreach (int setTool in setTools)
                {
                    richTextBoxEmail.AppendText(setTool.ToString() + "\n");
                }

                richTextBoxEmail.AppendText("\nThe following tools may be pulled from the machine: ");
                int pullTools = new int();
                // Check to see which machine is selected
                if (radioButton2.Checked == false || rButtonOkumaABC5X.Checked == true) //okuma 5x
                {
                    //List<int> okuma5XSpecialList = new List<int>();
                    foreach (int tool in okuma5XSpecialTools) { allNeededTools.Add(tool); }
                    dupedPartTools.Clear();
                    foreach (int tool in allNeededTools) { dupedPartTools.Add(tool); }
                    allNeededTools.Clear();
                    allNeededTools = dupedPartTools.Distinct().ToList();
                    allNeededTools.Sort();
                    IEnumerable<int> unusedTools = machineTools.Except(allNeededTools);

                    richTextBoxEmail.AppendText("(" + Convert.ToString(unusedTools.Count()) + " tools to be pulled. Does not include AHs, BBs and Probe.)\n");
                    pullTools = unusedTools.Count();
                    foreach (int unused in unusedTools)
                    {
                        richTextBoxEmail.AppendText(unused.ToString() + "\n");
                    }
                    MessageBox.Show("In summary: \n" + Convert.ToString(toolsUsed) + " total tools used in selected parts.\n" + Convert.ToString(buildTools) + " total tools need to be set.\n" + Convert.ToString(pullTools) + " total tools may be pulled from machine.\n\nYou have " + Convert.ToString(machineTools.Count) + " tools in the machine carousel currently.\n\nAngle Heads, Boring Bars and Probe are NOT included in pull lists.", "Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    System.Diagnostics.Debug.WriteLine("Okuma5x printed");
                }
                else //all other okumas
                {
                    IEnumerable<int> unusedTools = machineTools.Except(combinedPartTools);
                    pullTools = unusedTools.Count();
                    richTextBoxEmail.AppendText("(" + Convert.ToString(unusedTools.Count()) + " tools to be pulled)\n");
                    foreach (int unused in unusedTools)
                    {
                        richTextBoxEmail.AppendText(unused.ToString() + "\n");
                    }

                    MessageBox.Show("In summary: \n" + Convert.ToString(toolsUsed) + " total tools used in selected parts.\n" + Convert.ToString(buildTools) + " total tools need to be set.\n" + Convert.ToString(pullTools) + " total tools may be pulled from machine.\n\nYou have " + Convert.ToString(machineTools.Count) + " tools in the machine carousel currently." , "Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    System.Diagnostics.Debug.WriteLine("Other okumas printed");

                }
            }
        }


    }
    public static class ModifyProgressBarColor
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr w, IntPtr l);
        public static void SetState(this ProgressBar pBar, int state)
        {
            SendMessage(pBar.Handle, 1040, (IntPtr)state, IntPtr.Zero);
        }
    }
	
	
}
