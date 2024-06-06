using System;
using System.Data;
using System.Globalization;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace ClassLibrary
{
    public class clsStaff
    {
        private Int32 mStaffId;


        public Int32 StaffId
        {
            get
            {
                //this line of code sends data out of the property
                return mStaffId;
            }
            set
            {
                //this line of code allows data  into the property
                mStaffId = value;

            }
        }
        //private data member for the DateOfBirth property
        private DateTime mDOB;
        //DateOfBirth public property
        public DateTime DOB
        {
            get
            {
                //this line of code sends data out of the property
                return mDOB;
            }
            set
            {
                //this line of code allows data into the property
                mDOB = value;
            }
        }
        //private data member for the Name property
        private string mName;
        //Name public property
        public string Name
        {
            get
            {
                //this line of code sends data out of the property
                return mName;
            }
            set
            {
                //this line of code allows data into the property
                mName = value;
            }
        }
        //private data member for the Position property
        private string mPosition;
        //Position public property
        public string Position
        {
            get
            {
                //this line of code sends data out of the property
                return mPosition;
            }
            set
            {
                //this line of code allows data into the property
                mPosition = value;
            }
        }
        //private data member for the Email property
        private string mEmail;
        //Email public property
        public string Email
        {
            get
            {
                //this line of code sends data out of the property
                return mEmail;
            }
            set
            {
                //this line of code allows data into the property
                mEmail = value;
            }
        }
        //private data member for the Salary property
        private float mSalary;
        //county no public property
        public float Salary
        {
            get
            {
                //this line of code sends data out of the property
                return mSalary;
            }
            set
            {
                //this line of code allows data into the property
                mSalary = value;
            }
        }
        //private data member for the IsAvailable property
        private Boolean mIsAvailable;


        //IsAvailable public property
        public bool IsAvailable
        {
            get
            {
                //this line of code sends data out of the property
                return mIsAvailable;
            }
            set
            {
                //this line of code allows data into the property
                mIsAvailable = value;
            }
        }
        /****** FIND METHOD ******/
        public bool Find(int StaffId)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the Staff id to search for
            DB.AddParameter("@StaffId", StaffId);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterByStaffId");
            //if one record is found (there should be either one or zer)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mStaffId = Convert.ToInt32(DB.DataTable.Rows[0]["StaffId"]);
                mName = Convert.ToString(DB.DataTable.Rows[0]["Name"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mDOB = Convert.ToDateTime(DB.DataTable.Rows[0]["DOB"]);
                mPosition = Convert.ToString(DB.DataTable.Rows[0]["Position"]);
                mIsAvailable = Convert.ToBoolean(DB.DataTable.Rows[0]["IsAvailable"]);
                mSalary = Convert.ToSingle(DB.DataTable.Rows[0]["Salary"]);
                //return that everything worked ok
                return true;
            }
            //if no record was found 
            else
            {
                //return false indicating there is a problem
                return false;
            }
        }
        
        public string Valid(string Name, string DOB, string position, float salary, string Email)
        {
            //create a string variable to store the error
            String Error = "";

            //create a temporary variable to store the date values
            DateTime DateTemp;

            //if the Name is blank
            if (Name.Length == 0)
            {
                //record the error
                Error = Error + "The Name may not be blank  : ";
            }
            //if the name is greater than 6 characters
            if (Name.Length < 6)
            {
                //record the error
                Error = Error + "The Name must be more than 6 characters :";
            }
            //create an instance of Datetime to compare with DateTemp
            //in the if statements
            DateTime DateComp = DateTime.Now.Date;
            try
            {
                //copy the DOB value to the DateTemp variable
                DateTemp = Convert.ToDateTime(DOB);
                
                //check to see if the date is greater than today's date
                if (DateTemp < DateComp)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {

                // return any error messages
                Error = Error + "The date was not a valid date : ";

            }
            //is the Email blank
            if (Email.Length == 0)
            {
                //record the error
                Error = Error + "The Email may not be blank : ";
            }
            //if the Email is too long
            if (Email.Length < 9)
            {
                //record the error
                Error = Error + "The Email must be more than 9 characters";
            }
            //is the Position blank
            if (position.Length == 0)
            {
                //record the error
                Error = Error + "The Position may not be blank : ";
            }
            //if the Position is too long
            if (position.Length > 50)
            {
                //record the error
                Error = Error + "The Position must be less than 50 characters : ";
            }
            //is the Salary blank
            if (Salary.ToString().Length == 0)
            {
                //record the error
                Error = Error + "The Salary may not be blank : ";
            }
            //if the town is too long
            if (Salary.ToString().Length > 50)
            {
                //record the error
                Error = Error + "The Salary must be less than 50 characters : ";
            }
            //return any error messages
            return Error;
        }
        /***Statistics Grouped by IsAvailable Method ****/
        public DataTable StatisticsGroupByIsAvailable()
        {
         //create an instance of the data connection
         clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure 
            DB.Execute("sproc_tblStaff_Count_GroupByIsAvailable");
            //There should be either zero, one, or more records
            return DB.DataTable;
        }
        /***Statistics Grouped by DOB Method ****/
        public DataTable StatisticsGroupByDOB()
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure 
            DB.Execute("sproc_tblStaff_Count_GroupByDOB");
            //There should be either zero, one, or more records
            return DB.DataTable;
        }



    }

       
    }

       









    





    











    





        
    
