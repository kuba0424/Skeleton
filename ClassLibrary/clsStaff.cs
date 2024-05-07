using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        public bool IsAdmin { get; set; }
        public DateTime DateCreated { get; set; }
        public int StaffId { get; set; }
        public string StaffNickName { get; set; }
        public string StaffUser { get; set; }
        public string StaffPass { get; set; }
    }
}