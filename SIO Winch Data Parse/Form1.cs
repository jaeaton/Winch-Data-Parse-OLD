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

namespace SIO_Winch_Data_Parse
{
    public partial class Form1 : Form
    {
        string combinedFileName;
        string processedFileName;
        string filePath;
        string line;
        string fileRead;
        string stringData;
        string input;
        float minTension;
        float minPayout;
        bool flag;
        string maxTensionString;
        string maxPayoutString;
        int cast = 1;

        List<string> fileList = new List<string>();



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxPayoutMin.Items.Add((float)10.0); //set up values for combo boxes
            comboBoxPayoutMin.Items.Add((float)0.0);
            comboBoxPayoutMin.Items.Add((float)-10.0);
            comboBoxPayoutMin.Items.Add((float)-20.0);
            comboBoxPayoutMin.Items.Add((float)-30.0);
            comboBoxPayoutMin.Items.Add((float)-50.0);
            comboBoxPayoutMin.Items.Add((float)-100.0);
            comboBoxPayoutMin.SelectedIndex = 1;

            comboBoxTensionMin.Items.Add((float)-100.0);
            comboBoxTensionMin.Items.Add((float)0.0);
            comboBoxTensionMin.Items.Add((float)100.0);
            comboBoxTensionMin.Items.Add((float)200.0);
            comboBoxTensionMin.Items.Add((float)1000.0);
            comboBoxTensionMin.SelectedIndex = 1;

            comboBoxSelectWinch.Items.Add((string) "SIO Traction Winch");
            comboBoxSelectWinch.Items.Add((string) "MASH Winch");
            comboBoxSelectWinch.SelectedIndex = 1;
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void folderSelect_Click(object sender, EventArgs e) //Folder select button click
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK) //Opens folder selection dialog
            {
                filePath = folderBrowserDialog1.SelectedPath;   //Sets filePath variable to the selected path in dialog
                DirectoryInfo di = new DirectoryInfo(filePath);
                //var i = 0;
                foreach (var fi in di.GetFiles("*.Raw"))
                {
                    fileList.Add(fi.Name);
                }
                fileList.Sort();                                //Sorts the List by element name
                InitializeTreeView();                           //Calls InitializeTreeView Method
            }
            //labelCombinedFileName.Text = filePath;
            //labelProcessedFileNameDisplay.Text = fileList[5];
        }

        public void InitializeTreeView()                    //Sets up treeView
        {
            //var i = 0;
            logFileView.Nodes.Clear();                      //Should remove all nodes from treeview
            //logFileView.Nodes[0].Nodes.Clear();
            logFileView.BeginUpdate();
            logFileView.Nodes.Add(filePath);
            foreach (var fn in fileList)
            {
                logFileView.Nodes[0].Nodes.Add(fn);
            }
            logFileView.EndUpdate();
            logFileView.ExpandAll();
        }

        private void applyNameButton_Click(object sender, EventArgs e)
        {
            if (cruiseNameInput.Text == "Enter Name")
            {
                labelCombinedFileName.Text = "File Name not Valid";
                labelProcessedFileNameDisplay.Text = "File Name not Valid";
            }
            else if (cruiseNameInput.Text == "")
            {
                labelCombinedFileName.Text = "File Name not Valid";
                labelProcessedFileNameDisplay.Text = "File Name not Valid";
            }
            else
            {
                processedFileName = cruiseNameInput.Text + "_processed.txt";
                combinedFileName = cruiseNameInput.Text + "_combined.csv";
                labelCombinedFileName.Text = combinedFileName;
                labelProcessedFileNameDisplay.Text = processedFileName;
            }
        }

        private void runProcess_Click(object sender, EventArgs e)
        {
            foreach (var fin in fileList)
            {
                fileRead = filePath + "\\" + fin;
                labelOpenFile.Text = fileRead;
                labelOpenFile.Update();
                System.IO.StreamReader file = new System.IO.StreamReader(fileRead);
                while ((line = file.ReadLine()) != null)
                {
                    line = line.Replace("\n", String.Empty); //remove EOL Characters
                    line = line.Replace("\r", String.Empty);
                    string[] data = line.Split(',');
                    if (data[0] == "RD")
                    {
                        foreach (var dat in data)
                        {
                            stringData += dat + ',';
                        }
                        flag = true;
                    }
                    else if (flag == true && data[0].Contains('/'))
                    {
                        data = data.Take(data.Count() - 1).ToArray();
                        foreach (var dat in data)
                        {
                            stringData += dat + ',';
                        }
                        //stringData = stringData ;
                        //labelStringData.Text = stringData;
                        //labelStringData.Update();
                        writeCombined();
                        flag = false;
                        stringData = null;
                    }
                    else
                    {
                        stringData = null;
                    }
                }

                file.Close();
            }
        }

        public void writeCombined()  //function to write log
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(filePath + '\\' + combinedFileName, true))    //Write triplet file
            {

                file.WriteLine(stringData);
                
            }
        }

        public void writeProcessed()  //function to write log
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(filePath + '\\' + processedFileName, true))    //Write triplet file
            {

                file.WriteLine("Cast Number " + cast);
                file.WriteLine("RD, Tension, Speed, Payout, Checksum, Date, Time");
                file.WriteLine(maxTensionString);
                file.WriteLine(maxPayoutString);
                file.WriteLine("\n");
            }
        }

        private void buttonProcessCasts_Click(object sender, EventArgs e)
        {
            //Read threshold values
            minPayout = (float)comboBoxPayoutMin.SelectedItem;
            minTension = (float)comboBoxTensionMin.SelectedItem;

            //Read in collected file and determine maximum values of casts
            using (System.IO.StreamReader sr = new System.IO.StreamReader(filePath + '\\' + combinedFileName, true))    //Write triplet file
            {
                float maxTensionCurrent = 0;
                float maxPayoutCurrent = 0 ;
                cast = 1;
                bool castActive = false;
                float temp;

                while ((input = sr.ReadLine()) != null)
                {   
                    input = input.Replace("\n", String.Empty); //remove EOL Characters
                    input = input.Replace("\r", String.Empty);
                    //labelStringData.Text = input;
                    //labelStringData.Update();
                    string[] values = input.Split(',');
                    object[] valueObject = new object[values.Length];
                    int i = 0;
;
                    
                    foreach (var ob in values)
                    {
                        var test = float.TryParse(ob, out temp);
                        if (test == true) { valueObject[i] = temp; }
                        else { valueObject[i] = ob; }
                        i++;
                    }
                    //detect start of cast (values above threshold with positive slope)
                    if ((float)valueObject[1] > minTension && (float)valueObject[3] < minPayout)
                    {
                        castActive = true;
                        //check for new maximum values (tension and payout) and store
                        if ((float)valueObject[1] > maxTensionCurrent)
                        {
                            maxTensionCurrent = (float)valueObject[1];
                            maxTensionString = input;
                        }
                        if ((float)valueObject[3] < maxPayoutCurrent)
                        {
                            maxPayoutCurrent = (float)valueObject[3];
                            maxPayoutString = input;
                        }
                    
                    }
                    //detect end of cast (values below threshold with negative slope)
                    if ((float)valueObject[1] < minTension && (float)valueObject[3] > minPayout && castActive == true)
                    {
                        writeProcessed(); //end cast, increment cast number, write processed data
                        cast++;
                        castActive = false;
                        maxPayoutCurrent = 0;
                        maxTensionCurrent = 0;

                    }
                
                }
            }
        }
    }
}
