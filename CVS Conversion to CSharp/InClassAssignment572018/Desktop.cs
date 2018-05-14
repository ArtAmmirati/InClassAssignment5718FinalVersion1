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

namespace InClassAssignment572018
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string filePath;
        private void selectBTN_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            string path = @"C:\Users\Cyberadmin\Documents\InClassAssignment05072018-master\InClassAssignment05072018-master";



            open.Filter = "CSV Files| *.csv| Text Files (*.txt) | *.txt| All Files (*.*)|*.*";
            open.Title = "SELECT A CSV FILE OF YOUR CHOICE";
            open.InitialDirectory = path;
            open.CheckFileExists = true;
            open.CheckPathExists = true;


            if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                label1.Text = open.FileName;
                filePath = label1.Text.ToString();
                selectBTN.Visible = false;
                selectBTN.Visible = false;
            }

        }

        private void loadCorrectBTN_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                dataGridView1.ColumnCount = 6;
                dataGridView1.Columns[0].Name = "First Name";
                dataGridView1.Columns[1].Name = "Last Name";
                dataGridView1.Columns[2].Name = "DOB";
                dataGridView1.Columns[3].Name = "City";
                dataGridView1.Columns[4].Name = "State";
                dataGridView1.Columns[5].Name = "Date Joined";
                

                StreamReader inputFile; 
                string line; 
                int count = 0; 


                //delimiter array
                char[] delim = { ',' };


                
                
                inputFile = File.OpenText(filePath);

                while (!inputFile.EndOfStream)
                {
                    //file read
                    line = inputFile.ReadLine();


                    //array declared and line split into tokens
                    string[] tokens = line.Split(delim);


                    //Member Data displayed in broken up tokens


                    dataGridView1.Rows.Add(tokens[0], tokens[1], tokens[2], tokens[3], tokens[4], tokens[5]);




                    //incrementer
                    count++;
                }
                //Close input file
                inputFile.Close();
                label1.Text = count + " lines were processed.";
            }
            catch (Exception ex)
            {
                //Error Message
                MessageBox.Show(ex.Message);
            }
            try
            {
                dataGridView1.Rows.Clear();

                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                dataGridView1.ColumnCount = 6;
                dataGridView1.Columns[0].Name = "First Name";
                dataGridView1.Columns[1].Name = "Last Name";
                dataGridView1.Columns[2].Name = "DOB";
                dataGridView1.Columns[3].Name = "City";
                dataGridView1.Columns[4].Name = "State";
                dataGridView1.Columns[5].Name = "Date Joined";


                StreamReader inputFile; 
                string line; 
                int count = 0; 

                //delimiter array
                char[] delim = { ',' };


                //CSV File

                inputFile = File.OpenText(filePath);
                StreamWriter OutputFile = new StreamWriter("ProcessedData.CSV");



                while (!inputFile.EndOfStream)
                {
                    //read line from file.
                    line = inputFile.ReadLine();
                    line = line.Replace(".", "/");
                    line = line.Replace("-", "/");

                   
                    string[] tokens = line.Split(delim);


                    //DOB month name replaced with a numeric
                    string dateOne = tokens[2];

                    dateOne = dateOne.Replace("Jan", "1");
                    dateOne = dateOne.Replace("Feb", "2");
                    dateOne = dateOne.Replace("Mar", "3");
                    dateOne = dateOne.Replace("Apr", "4");
                    dateOne = dateOne.Replace("May", "5");
                    dateOne = dateOne.Replace("Jun", "6");
                    dateOne = dateOne.Replace("Jul", "7");
                    dateOne = dateOne.Replace("Aug", "8");
                    dateOne = dateOne.Replace("Sep", "9");
                    dateOne = dateOne.Replace("Oct", "10");
                    dateOne = dateOne.Replace("Nov", "11");
                    dateOne = dateOne.Replace("Dec", "12");


                    string tempOne = "";
                    string[] dateparts = dateOne.Split('/');

                    



                    if (int.Parse(dateparts[0]) > 12)
                    {
                        //switch the dates around
                        tempOne = dateparts[1];
                        dateparts[1] = dateparts[0];
                        dateparts[0] = tempOne;
                    }

                    if (int.Parse(dateparts[2]) < 1000)
                    {

                        dateparts[2] = "19" + dateparts[2];
                    }

                    if (dateparts[0].Contains("0"))
                    {
                        if (int.Parse(dateparts[0]) < 10)
                        {
                            dateparts[0].Replace("0", "");
                        }
                    }



                    tokens[2] = dateparts[0] + "/" + dateparts[1] + "/" + dateparts[2];

                   

                    //Same thing for the  joined date
                    //Name to numeric
                    string dateTwo = tokens[5];

                    dateTwo = dateTwo.Replace("Jan", "1");
                    dateTwo = dateTwo.Replace("Feb", "2");
                    dateTwo = dateTwo.Replace("Mar", "3");
                    dateTwo = dateTwo.Replace("Apr", "4");
                    dateTwo = dateTwo.Replace("May", "5");
                    dateTwo = dateTwo.Replace("Jun", "6");
                    dateTwo = dateTwo.Replace("Jul", "7");
                    dateTwo = dateTwo.Replace("Aug", "8");
                    dateTwo = dateTwo.Replace("Sep", "9");
                    dateTwo = dateTwo.Replace("Oct", "10");
                    dateTwo = dateTwo.Replace("Nov", "11");
                    dateTwo = dateTwo.Replace("Dec", "12");


                    string temp2 = "";
                    string[] dateparts2 = dateTwo.Split('/');


                    if (int.Parse(dateparts2[0]) > 12)
                    {
                        //switch the dates around
                        temp2 = dateparts2[1];
                        dateparts2[1] = dateparts2[0];
                        dateparts2[0] = temp2;
                    }

                    if (int.Parse(dateparts2[2]) < 1000)
                    {

                        dateparts2[2] = "19" + dateparts2[2];
                    }


                    if (dateparts2[0].Contains("0"))
                    {
                        if (int.Parse(dateparts2[0]) < 10)
                        {
                            dateparts2[0] = dateparts2[0].Replace(@"0", "");
                        }
                    }

                    if (dateparts2[1].Contains("0"))
                    {
                        if (int.Parse(dateparts2[1]) < 10)
                        {
                            dateparts2[1] = dateparts2[1].Replace(@"0", "");

                        }
                    }


                    tokens[5] = dateparts2[0] + "/" + dateparts2[1] + "/" + dateparts2[2];



                    dataGridView1.Rows.Add(tokens[0], tokens[1], tokens[2], tokens[3], tokens[4], tokens[5]);

                    OutputFile.WriteLine(tokens[0] + "," + tokens[1] + "," + tokens[2] + "," + tokens[3] + "," + tokens[4] + "," + tokens[5]);



                    //increment line
                    count++;
                }
                //closed file
                inputFile.Close();



                label1.Text = "All Dates Standardized to MM/DD/YYYY";

            }
            catch (Exception ex)
            {

                //display an error message
                MessageBox.Show(ex.Message);

            }


        }
    }
}
