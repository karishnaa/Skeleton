using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        public bool Active { get; set; }
        public DateTime DateAdded { get; set; }
        public string Name { get; set; }
        public int StaffId { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Position { get; set; }
        public bool IsAvailable { get; set; }
        public string Email { get; set; }
        public float Salary { get; set; }
    }
}