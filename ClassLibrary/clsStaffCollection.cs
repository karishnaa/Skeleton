using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStaffCollection


    {
        //private data member for the list
        List<clsStaff> mStaffList = new List<clsStaff>();
        //private member data for ThisStaff
        clsStaff mThisStaff = new clsStaff();

        //public property for the Staff List
        public List<clsStaff> StaffList
        {
            get
            {
                //return the private data
                return mStaffList;
            }
            set
            {
                //set the private data
                mStaffList = value;

            }
        }
        //public property for count
        public int Count
        {
            get
            {
                //return the count of the list
                return mStaffList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }
        //public property for ThisStaff
        public clsStaff ThisStaff
        {
            get
            {
                //return the private data
                return mThisStaff;
            }
            set
            {
                //set the private data
                mThisStaff = value;
            }
        }


        //constructor for the class
        public clsStaffCollection()
        {
          
            //object for the data connect
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        public int Add()
        {
            //Adds a record to the database based on the values of mThisStaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedures
            DB.AddParameter("@Name", mThisStaff.Name);
            DB.AddParameter("@Position", mThisStaff.Position);
            DB.AddParameter("@Email", mThisStaff.Email);
            DB.AddParameter("@DOB", mThisStaff.DOB);
            DB.AddParameter("@Salary", mThisStaff.Salary);
            DB.AddParameter("@IsAvailable", mThisStaff.IsAvailable);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblStaff_Insert");

        }

        public void Update()
        {
            //update an existing record based on the values of ThisStaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the new stored procedure
            DB.AddParameter("@StaffId", mThisStaff.StaffId);
            DB.AddParameter("@Name", mThisStaff.Name);
            DB.AddParameter("@Position", mThisStaff.Position);
            DB.AddParameter("@Email", mThisStaff.Email);
            DB.AddParameter("@Salary", mThisStaff.Salary);
            DB.AddParameter("@IsAvailable", mThisStaff.IsAvailable);
            DB.AddParameter("@DOB", mThisStaff.DOB);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_Update");

        }

        public void Delete()
        {
            //deletes the record pointed to by ThisStaff
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@StaffId", mThisStaff.StaffId);
            //execute the stored procedure 
            DB.Execute("sproc_tblStaff_Delete");

        }

        public void ReportByDOB(string DOB)
        {
            //filters the records based on a full or partial DOB
            //connect to the Database
            clsDataConnection DB = new clsDataConnection();
            if (string.IsNullOrEmpty(DOB))
            {
                // If DOB is empty or null, do not filter by DOB
                DB.Execute("sproc_tblStaff_SelectAll");
            }
            else
            {
                // Attempt to convert the input DOB string to a DateTime object
                DateTime parsedDOB;
                try
                {
                    parsedDOB = Convert.ToDateTime(DOB);
                }
                catch (FormatException)
                {
                    // Handle the case where DOB is not in a valid format
                    throw new ArgumentException("Invalid DOB format. Please provide a valid date.", nameof(DOB));
                }

                // Send the DOB parameter to the database
                DB.AddParameter("@DOB", parsedDOB);

                // Execute the stored procedure that filters records by DOB
                DB.Execute("sproc_tblStaff_filterByDOB");
            }

            // Populate the array list with the data table retrieved by the stored procedure
            PopulateArray(DB);
        }
      
        void PopulateArray(clsDataConnection DB)
        {
            //populate the array list based on the data table in the parameter DB
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount = DB.Count;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mStaffList = new List<clsStaff>();
            //while there are records to process
            while(Index < RecordCount)
            {
                //create a blank Staff object
                clsStaff AnStaff = new clsStaff();
                //read in the fields from the current record
                AnStaff.IsAvailable = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsAvailable"]);
                AnStaff.StaffId = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffId"]);
                AnStaff.DOB =    Convert.ToDateTime(DB.DataTable.Rows[Index]["DOB"]);
                AnStaff.Name = Convert.ToString(DB.DataTable.Rows[Index]["Name"]);
                AnStaff.Salary = float.Parse(DB.DataTable.Rows[Index]["Salary"].ToString());
                AnStaff.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                AnStaff.Position = Convert.ToString(DB.DataTable.Rows[Index]["Position"]);
                //add the record to the private data member
                mStaffList.Add(AnStaff);
                //point at the next record
                Index++;
            }
        }






    }
}