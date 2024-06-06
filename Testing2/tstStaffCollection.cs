using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;


namespace Testing2
{
    [TestClass]
    public class tstStaffCollection
    {
        public List<clsStaff> TestList { get; private set; }

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //test to see that is exists
            Assert.IsNotNull(AllStaff);
        }

        [TestMethod]
        public void StaffListOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaffs = new clsStaffCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //Add an item to the list
            //create the item of test data 
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.IsAvailable = true;
            TestItem.StaffId = 2;
            TestItem.Name = "zainab";
            TestItem.DOB = DateTime.Now;
            TestItem.Position = "Designer";
            TestItem.Email = "Some Email";
            TestItem.Salary = 5000f;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaffs.StaffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaffs.StaffList, TestList);
        }

       
        [TestMethod]
        public void ThisStaffPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaffs = new clsStaffCollection();
            //create some test data to assign to the property
            clsStaff TestStaff = new clsStaff();
            //set the properties of the test object
            TestStaff.IsAvailable = true;
            TestStaff.StaffId = 2;
            TestStaff.Name = "zainab";
            TestStaff.DOB = DateTime.Now;
            TestStaff.Position = "Designer";
            TestStaff.Email = "Some Email";
            TestStaff.Salary = 5000f;
            //assign the data to the property
            AllStaffs.ThisStaff = TestStaff;
            //assign the data to the property
            AllStaffs.StaffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaffs.ThisStaff, TestStaff);
        }

        

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create 
            clsStaffCollection AllStaffs = new clsStaffCollection();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.IsAvailable = true;
            TestItem.StaffId = 2;
            TestItem.Name = "zainab";
            TestItem.Position = "Designer";
            TestItem.Email = "zainab@gmail.com";
            TestItem.DOB = DateTime.Now;
            TestItem.Salary = 5000f;
            //set ThisStaff to the test data
            AllStaffs.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaffs.Add();
            //set the primary key of the test data
            TestItem.StaffId = PrimaryKey;
            //find the record
            AllStaffs.ThisStaff.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllStaffs.ThisStaff, TestItem);
        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaffs = new clsStaffCollection();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.IsAvailable = true;
            TestItem.Name = "zainab";
            TestItem.Email = "zainab@gmail.com";
            TestItem.Position = "Designer";
            TestItem.Salary = 5000f;
            TestItem.DOB = DateTime.Now;
            //set ThisStaff to the test data
            AllStaffs.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaffs.Add();
            //set the primary key of the test data
            TestItem.StaffId = PrimaryKey;
            //modify the test record
            TestItem.IsAvailable = false;
            TestItem.DOB = DateTime.Now;
            TestItem.Position = "Another Position";
            TestItem.Email = "Another Email";
            TestItem.Name = "Another Name";
            TestItem.Salary = 1000f;
            //set the record based on the new test data
            AllStaffs.ThisStaff = TestItem;
            //update the record
            AllStaffs.Update();
            //find the record
            AllStaffs.ThisStaff.Find(PrimaryKey);
            //test to see if ThisStaff matches the test data
            Assert.AreEqual(AllStaffs.ThisStaff, TestItem);

        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create 
            clsStaffCollection AllStaffs = new clsStaffCollection();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.IsAvailable = true;
            TestItem.Name = "zainab";
            TestItem.DOB = DateTime.Now;
            TestItem.Email = "zainab@gmail.com";
            TestItem.Salary = 5000f;
            TestItem.StaffId = 2;
            TestItem.Position = "Designer";
            //set thisStaff to the test data
            AllStaffs.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaffs.Add();
            //set the primary key of the test data
            TestItem.StaffId = PrimaryKey;
            //find the record
            AllStaffs.ThisStaff.Find(PrimaryKey);
            //delete the record
            AllStaffs.Delete();
            //now find the record 
            Boolean Found = AllStaffs.ThisStaff.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByDOBMethodOK()
        {
            //create an instance of the class containing unfiltered results
            clsStaffCollection AllStaffs = new clsStaffCollection();
            //create an instance of the filtered data
            clsStaffCollection FilteredStaffs = new clsStaffCollection();
            //apply a blank string (shoiuld return all records);
            FilteredStaffs.ReportByDOB("");
            //test to see that the two values are the same
            Assert.AreEqual(AllStaffs.Count, FilteredStaffs.Count);
        }

        [TestMethod]
        public void ReportByDOBNoneFound()
        {
            //create an instance of the class we want to create
            clsStaffCollection FilteredStaffs = new clsStaffCollection();
            //apply a DOB that doesn't exist
            FilteredStaffs.ReportByDOB("03/03/2003");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredStaffs.Count);
        }

        [TestMethod]
        public void ReportByDOBTestDataFound()
        {
            //create an instance of the filtered data
            clsStaffCollection FilteredStaffs = new clsStaffCollection();
            //variable to store the outcome
            Boolean OK = true;
            //apply a DOB that doesn't exist
            FilteredStaffs.ReportByDOB("03/03/2021");
            //check that the correct number of records are found
            if (FilteredStaffs.Count == 2)
            {
                //check to see that the first record is 1053
                if (FilteredStaffs.StaffList[0].StaffId != 1053)
                {
                    OK = false;
                }
                //check to see that the first record is 1053
                if (FilteredStaffs.StaffList[1].StaffId != 1054)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are no records
            Assert.IsTrue(OK);
        }

    }
}
