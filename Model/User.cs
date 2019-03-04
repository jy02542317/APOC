using System;


namespace Model
{
    public class User
    {
        private int pkid;

        private string position;

        private string password;

        private string loginName;

        private string email;

        private string phone;

        private string iDNumber;

        private bool isValid;

        private string name;

        private string memo;

        private DateTime lastModifyPasswordTime;

        private string inChargeOfCity;

        private int state;

        private bool iseffective;

        private string userLogin;

        private bool isReceiveMail;

        public int PKID { get => pkid; set => pkid = value; }

        public string Position { get => position; set => position = value; }

        public string Password { get => password; set => password = value; }

        public string LoginName { get => loginName; set => loginName = value; }

        public string Email { get => email; set => email = value; }

        public string Phone { get => phone; set => phone = value; }

        public string IDNumber { get => iDNumber; set => iDNumber = value; }

        public bool IsValid { get => isValid; set => isValid = value; }

        public string Name { get => name; set => name = value; }

        public string Memo { get => memo; set => memo = value; }

        public DateTime LastModifyPasswordTime { get => lastModifyPasswordTime; set => lastModifyPasswordTime = value; }

        public string InChargeOfCity { get => inChargeOfCity; set => inChargeOfCity = value; }

        public int State { get => state; set => state = value; }

        public bool Iseffective { get => iseffective; set => iseffective = value; }

        public string UserLogin { get => userLogin; set => userLogin = value; }

        public bool IsReceiveMail { get => isReceiveMail; set => isReceiveMail = value; }
    }
}
