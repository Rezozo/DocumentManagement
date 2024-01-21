using System;

namespace documentManagement.models
{
    public class PFace
    {
        public int Id { get; set; }
        public string lastName { get; set; }
        public string firstName { get; set; }
        public string middleName { get; set; }
        public DateTime dateOfBirth { get; set; }
        public string passportData { get; set; }
        public string address { get; set; }
        public string email { get; set; }
        public string phoneNumber { get; set; }
        public string position { get; set; }
        public string workPlace { get; set; }

        public PFace() { }

        public PFace(int id,string lastName, string firstName, string middleName, DateTime dateOfBirth, string passportData, string address, string email, string phoneNumber, string position, string workPlace)
        {
            this.Id = id; 
            this.lastName = lastName;
            this.firstName = firstName;
            this.middleName = middleName;
            this.dateOfBirth = dateOfBirth;
            this.passportData = passportData;
            this.address = address;
            this.email = email;
            this.phoneNumber = phoneNumber;
            this.position = position;
            this.workPlace = workPlace;
        }
    }
}
