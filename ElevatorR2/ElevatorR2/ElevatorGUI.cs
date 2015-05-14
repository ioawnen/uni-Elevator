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
 * ElevatorGUI.cs is the main Form that is used. It handles pretty much all of the functionality of the program.
 */

namespace ElevatorR2
{
    public partial class ElevatorGUI : Form
    {

        public bool doorsOpen1 = false; //doorsOpen1/2 are bools that state whether the doors are currently open or closed
        public bool doorsOpen0 = false; 
        public int liftPosition = 0; //liftPosition states the current position of the lift
        public bool inProgress = false; //inProgress is a bool that is used to state whether the lift is doing something


        public ElevatorGUI()
        {
            InitializeComponent();
        }
        public debug debugWindow = new debug(); //When the ElevatorGUI starts it creates a debug window that it can dump messages about what it is doing on

        private void Form1_Load(object sender, EventArgs e)
        {
            //Just for testing when i'm too lazy to open the debug every time. Comment out for release.
            //debugWindow.Show();

            //Sets the displays to the starting position.
            if (liftPosition == 0) { setDisplay("f0stop"); }
            else if (liftPosition == 1) { setDisplay("f1stop"); }         
        }

        //These are called whenever an exterior button is pressed
        private void f1DoorButton_Click(object sender, EventArgs e)
        {
            DBAddLog("BUTTON 1 EXT PRESS"); //The request is written to the database
            debugWindow.WriteLine("INPUT: Exterior Button 1 Pressed"); //The request is also written to the debug window
            extDoor1Button.Image = ElevatorR2.Properties.Resources.button1_on; //Changes the button to be lit

            moveLift(1); //moveLift is called with the floor number to process the action
        }
        private void f0DoorButton_Click(object sender, EventArgs e)
        {
            DBAddLog("BUTTON 0 EXT PRESS");
            debugWindow.WriteLine("INPUT: Exterior Button 0 Pressed");
            extDoor0Button.Image = ElevatorR2.Properties.Resources.button0_on; //Changes the button to be lit

            moveLift(0);
        }

        //these are called whenever an interior button is pressed
        public void liftInteriorButton1(object sender, EventArgs e)
        {
            //The Images for the buttons are set to be illuminated.
            int0Button1.Image = ElevatorR2.Properties.Resources.button1_on;
            int1Button1.Image = ElevatorR2.Properties.Resources.button1_on;

            DBAddLog("BUTTON 1 INT PRESS"); //The request is written to the database
            debugWindow.WriteLine("INPUT: Interior Button 1 Pressed"); //The request is also written to the debug window
            moveLift(1); //moveLift is called with the floor number to process the action
        }
        public void liftInteriorButton0(object sender, EventArgs e)
        {
            int0Button0.Image = ElevatorR2.Properties.Resources.button0_on;
            int1Button0.Image = ElevatorR2.Properties.Resources.button0_on;

            DBAddLog("BUTTON 0 INT PRESS");
            debugWindow.WriteLine("INPUT: Interior Button 0 Pressed");
            moveLift(0);
        }

        //This is called whenever the doors need to be closed
        public async void closeDoors(int liftNo)
        {
            if (liftNo == 1) //Which doors are controlled is decided based on the variable liftNo that is set when the method is called
            {
                if (doorsOpen1 == true)
                {
                    DBAddLog("CLOSE DOORS " + liftNo); //The requested action is written to the database
                    //The doors are a 200x100 Image, so to open them they are moved 100 pixels. This is handled using a simple loop that runs 100 times. This method is used whenever the doors need to be moved. For closing the same method is used just in reverse.
                    doorsOpen1 = false; //As the doors are to close the corresponding variable is set to show this.
                    debugWindow.WriteLine("ACTION: Closing Doors 1"); //Info on the action is sent to the debug window
                    int i = 0; //The integer i is created for use in the loop
                    while(i<100) //The loop is set to run as long as i is less than 100
                    {
                        i++; //i is incremented as the loop progresses
                        await Task.Delay(10); // There is a 10ms delay every time the doors move to slow down the action
                        liftDoor1Left.Location = new Point(liftDoor1Left.Location.X + 1, liftDoor1Left.Location.Y); //Both doors are moved by one pixel every time it loops
                        liftDoor1Right.Location = new Point(liftDoor1Right.Location.X - 1, liftDoor1Right.Location.Y);
                    }
                    debugWindow.WriteLine("ACTION: Doors 1 Closed"); //Once the action is completed the result is written to the debug window
                }
            }
            else if (liftNo == 0) //The same as above occurs here except with another pair of doors
            {
                if (doorsOpen0 == true)
                {
                    DBAddLog("CLOSE DOORS " + liftNo); //The requested action is written to the database
                    doorsOpen0 = false;
                    debugWindow.WriteLine("ACTION: Closing Doors 0");
                    int i = 0;
                    while(i<100)
                    {
                        i++;
                        await Task.Delay(10);
                        liftDoor0Left.Location = new Point(liftDoor0Left.Location.X + 1, liftDoor0Left.Location.Y);
                        liftDoor0Right.Location = new Point(liftDoor0Right.Location.X - 1, liftDoor0Right.Location.Y);
                    }
                    debugWindow.WriteLine("ACTION: Doors 0 Closed");                
                }
            }
        }
        //This is called whenever the doors need to be opened
        public async void openDoors(int liftNo)
        {
            if(liftNo==1)
            {
                if (doorsOpen1 == false)
                {
                    DBAddLog("OPEN DOORS " + liftNo);
                    doorsOpen1 = true;
                    debugWindow.WriteLine("ACTION: Opening Doors 1");
                    int i = 0;
                    while(i<100)
                    {
                        i++;
                        await Task.Delay(10);
                        liftDoor1Left.Location = new Point(liftDoor1Left.Location.X - 1, liftDoor1Left.Location.Y);
                        liftDoor1Right.Location = new Point(liftDoor1Right.Location.X + 1, liftDoor1Right.Location.Y);
                    }
                    debugWindow.WriteLine("ACTION: Doors 1 Open");
                }
                else
                {
                    debugWindow.WriteLine("ERROR: Cannot Open Doors 1. Doors Already Open");
                }
            }
            else if(liftNo==0)
            {
                if (doorsOpen0 == false)
                {
                    DBAddLog("OPEN DOORS " + liftNo);
                    doorsOpen0 = true;
                    debugWindow.WriteLine("ACTION: Opening Doors 0");
                    int i = 0;
                    while(i<100)
                    {
                        i++;
                        await Task.Delay(10);
                        liftDoor0Left.Location = new Point(liftDoor0Left.Location.X - 1, liftDoor0Left.Location.Y);
                        liftDoor0Right.Location = new Point(liftDoor0Right.Location.X + 1, liftDoor0Right.Location.Y);
                    }
                    debugWindow.WriteLine("ACTION: Doors 0 Open");
                }
                else
                {
                    debugWindow.WriteLine("WARNING: Cannot Open Doors 0. Doors Already Open");
                }
            }
        }
        //This is called whenever the lift needs to be moved
        public async void moveLift(int targetFloor)
        {
            //Opens the door if the lift is on the same floor as the button that is pressed
            if(liftPosition == targetFloor && inProgress == false)
            {
                openDoors(liftPosition);
            }
            //This is what usually gets called. This moves the lift to the floor that the button was pressed on (if the lift is not currently doing something)
            else if (inProgress == false)
            {
                inProgress = true; //The lift is set to inProgress, meaning the lift is currently doing something and won't accept another action.
                //Make sure every door is closed before moving.
                //Set the displays to show what the lift is doing
                if (targetFloor == 0) { setDisplay("f0down"); }
                else if (targetFloor == 1) { setDisplay("f1up"); }
                await Task.Delay(1000); //Delay between button press and doors starting to close
                closeDoors(0);
                closeDoors(1);

                await Task.Delay(2000); // Time between doors begin closing and the lift moves

                //This is where the lift gets moved
                DBAddLog("MOVE LIFT FLOOR " + targetFloor);
                debugWindow.WriteLine("ACTION: Lift moving to floor " + targetFloor);
                await Task.Delay(5000); //This is a simulated time or the lift to move to the new position
                liftPosition = targetFloor; //The liftPosition variable is set to the target floor
                DBAddLog("LIFT ARRIVED FLOOR " + liftPosition);
                debugWindow.WriteLine("ACTION: Lift arrived at floor " + liftPosition);

                if (liftPosition == 0) { setDisplay("f0stop"); }
                else if (liftPosition == 1) { setDisplay("f1stop"); }

                await Task.Delay(500); //Delay between reaching floor and doors opening
                openDoors(targetFloor); //The doors are opened for the floor that the lift is at.

                inProgress = false; //The action is completed, so inProgress is set to false so another action can take place
            }
            else //If there is an action already in progress, this is what happens
            {
                debugWindow.WriteLine("WARNING: Cannot move to floor "+targetFloor+". Action already in progress."); //A warning is written to the debug window
                await Task.Delay(100); //A short delay between the button being turned on and off
                //Switching off the button corresponding to the floor
                if(targetFloor==1) { extDoor1Button.Image = ElevatorR2.Properties.Resources.button1_off; }
                else { extDoor0Button.Image = ElevatorR2.Properties.Resources.button0_off; }               
                
                return; //breaks out of the method so it doesn't reset all the buttons
            }
            //Setting all the buttons to the off images
            await Task.Delay(500);
            extDoor1Button.Image = ElevatorR2.Properties.Resources.button1_off;
            extDoor0Button.Image = ElevatorR2.Properties.Resources.button0_off;

            int0Button1.Image = ElevatorR2.Properties.Resources.button1_off;
            int0Button0.Image = ElevatorR2.Properties.Resources.button0_off;
            int1Button1.Image = ElevatorR2.Properties.Resources.button1_off;
            int1Button0.Image = ElevatorR2.Properties.Resources.button0_off;

            //After a set time if there is no action in progress the doors are automatically closed.
            await Task.Delay(10000);
            if (inProgress == false) { closeDoors(liftPosition); }
        }

        //This is used to change the images on the displays
        public void setDisplay(string displayVal)
        {
            if(displayVal == "f0down")
            {
                //Set to f0 with arrow animated down

                //The display numbers are changed
                ext0DisplayLabel.Text = "0";
                ext1DisplayLabel.Text = "0";
                int0DisplayLabel.Text = "0";
                int1DisplayLabel.Text = "0";            
                //The images used for the arrows are changed
                ext0DisplayArrow1.Image = ElevatorR2.Properties.Resources.downArrowAnimated;
                ext0DisplayArrow2.Image = ElevatorR2.Properties.Resources.downArrowAnimated;
                ext1DisplayArrow1.Image = ElevatorR2.Properties.Resources.downArrowAnimated;
                ext1DisplayArrow2.Image = ElevatorR2.Properties.Resources.downArrowAnimated;
                int0DisplayArrow1.Image = ElevatorR2.Properties.Resources.downArrowAnimated;
                int1DisplayArrow1.Image = ElevatorR2.Properties.Resources.downArrowAnimated;
                debugWindow.WriteLine("ACTION: Displays set to floor 0, down");
            }
            else if (displayVal == "f1stop")
            {
                //Set to f1 with no arrow

                ext0DisplayLabel.Text = "1";
                ext1DisplayLabel.Text = "1";
                int0DisplayLabel.Text = "1";
                int1DisplayLabel.Text = "1";
                ext0DisplayArrow1.Image = null;
                ext0DisplayArrow2.Image = null;
                ext1DisplayArrow1.Image = null;
                ext1DisplayArrow2.Image = null;
                int0DisplayArrow1.Image = null;
                int1DisplayArrow1.Image = null;
                debugWindow.WriteLine("ACTION: Displays set to floor 1, stop");
            }
            else if (displayVal == "f1up")
            {
                //Set to f1 with arrow animated up
                ext0DisplayLabel.Text = "1";
                ext1DisplayLabel.Text = "1";
                int0DisplayLabel.Text = "1";
                int1DisplayLabel.Text = "1";
                ext0DisplayArrow1.Image = ElevatorR2.Properties.Resources.upArrowAnimated;
                ext0DisplayArrow2.Image = ElevatorR2.Properties.Resources.upArrowAnimated;
                ext1DisplayArrow1.Image = ElevatorR2.Properties.Resources.upArrowAnimated;
                ext1DisplayArrow2.Image = ElevatorR2.Properties.Resources.upArrowAnimated;
                int0DisplayArrow1.Image = ElevatorR2.Properties.Resources.upArrowAnimated;
                int1DisplayArrow1.Image = ElevatorR2.Properties.Resources.upArrowAnimated;
                debugWindow.WriteLine("ACTION: Displays set to floor 1, up");
            }
            else if (displayVal == "f0stop")
            {
                //Set to f0 with no arrow
                ext0DisplayLabel.Text = "0";
                ext1DisplayLabel.Text = "0";
                int0DisplayLabel.Text = "0";
                int1DisplayLabel.Text = "0";
                ext0DisplayArrow1.Image = null;
                ext0DisplayArrow2.Image = null;
                ext1DisplayArrow1.Image = null;
                ext1DisplayArrow2.Image = null;
                int0DisplayArrow1.Image = null;
                int1DisplayArrow1.Image = null;
                debugWindow.WriteLine("ACTION: Displays set to floor 0, stop");
            }
            else
            {
                //Tells me if I messed up a value somewhere. Shouldn't be displayed otherwise.
                debugWindow.WriteLine("ERROR: Display cannot be set to value: " + displayVal);
            }
        }

        //Stuff in the Options Menu
        private void debugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            debugWindow.refreshDatabase(); //The debug window grabs from the database if you open it

            //This stuff handles showing the debug window and stuff
            if(debugWindow.Visible==false)
            {
                debugWindow.Show();
            }
            else
            {
                debugWindow.Focus();
            }
        }
        //This is called whenever something wants to add to the database. It also refreshes the table on the debug window so it shows the new value.
        private void DBAddLog(string desc)
        {
            Database.addLog(liftPosition, desc); 
            debugWindow.refreshDatabase();
        }
    }
}
