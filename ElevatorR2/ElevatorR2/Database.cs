using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Database.cs is used whenever something wants to add a log to the database. This is done using Database.addLog();.
 * That's pretty much its only purpose. It just creates an instance of the table adapter and inserts a new value.
 */

namespace ElevatorR2
{
    class Database
    {
        public static void addLog(int liftPos, string eventDesc)
        {
            try
            {
                //getting the table adapter that it's going to use.
                ElevatorDBDataSetTableAdapters.OperationsLogTableAdapter operationsLogTableAdapter = new ElevatorDBDataSetTableAdapters.OperationsLogTableAdapter();

                //Finally, inserting the new record
                operationsLogTableAdapter.Insert(DateTime.Now.ToString("hh:mm:ss"), DateTime.Now.ToString("dd:MM:yyyy"), liftPos, eventDesc);
            }
            catch (System.Data.OleDb.OleDbException e) { Console.WriteLine(e); } //This catches the database errors this class throws to stop it crashing and bringing the whole program down. debug.cs already complains about the same errors so it seems pointless to have this class throw up errors about the same thing.
        }
    }
}