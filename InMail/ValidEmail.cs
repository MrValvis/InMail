namespace InMail{
    class EmailValidation{
        public bool IsValidEmail(string email){
            try{
                var EmailAddress = new System.Net.Mail.MailAddress(email);
                return EmailAddress.Address == email;
            }
            catch{
                return false;
            }
        }
    }
}
