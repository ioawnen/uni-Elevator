using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * debug.cs is a Form that is used to display output from ElevatorGUI.cs and the database.
 */

namespace ElevatorR2
{
    public partial class debug : Form
    {
        public debug()
        {
            InitializeComponent();
            WriteLine("MESSAGE: Debug Console Initialised\n");
        }

        private bool errorShown = false;

        private void debug_Load(object sender, EventArgs e)
        {
            // This sets off the auto refresh on the first run of the debug window since the checkbox doesn't call the auto refresh method when it starts even if it's set to true at the start.

        }
        //When the exit button is pressed the window is hidden so the program can continue to write to it in the background. It also means I don't have to make a new window every time you try to open one and don't have to write all the messages to somewhere else just so I can get them back again when you open it.

        private void debug_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        //These are called from ElevatorGUI so it can write messages to the text box.
        public void Write(string text)
        {
            textBox1.AppendText(text);
        }
        public void WriteLine(string text)
        {
            textBox1.AppendText(text + "\n");
        }

        private void clearButton_Click(object sender, EventArgs e) //Controls what the clear button does
        {
            textBox1.Clear(); //What a suprise, it clears it!
        }
        private void refreshButton_Click(object sender, EventArgs e) //Controls what the refresh button does
        {
            refreshDatabase();
        }
        
        
        public void refreshDatabase() //Called whenever I want the datagridview to update it's values
        {
            try
            {
                //This loads data into the 'elevatorDBDataSet.OperationsLog' table.
                this.operationsLogTableAdapter.Fill(this.elevatorDBDataSet.OperationsLog);

                //This automatically scrolls to the bottom of the list when it updates
                try
                {
                    dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;
                }
                catch (ArgumentOutOfRangeException) { } //It throws an exception when there are no values to be scrolled through. This catches and ignores it.

            }
            //If the database is missing or there is a similar problem it throws this exception.
            catch (System.Data.OleDb.OleDbException e)
            {
                if(errorShown == false) //When the debug window tries to refresh the database for the first time it displays the following errors.
                { 
                    //An error is written to the dedug window
                    WriteLine("CRITICAL ERROR! COULD NOT ACCESS DATABASE!");
                    WriteLine("NO DATA WILL BE WRITTEN TO DATABASE!");
                    // Display message box explaining the error
                    MessageBox.Show("The database could not be found.\n\nError: System.Data.OleDb.OleDbException", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    errorShown = true; //Sets errorShown to true once the error has been displayed. This is so you don't get bugged about a reoccuring problem if you want to coninue using it.
                }
            }
        }
    }
}
