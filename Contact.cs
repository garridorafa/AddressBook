namespace AddressBookCs
{
    public class Contact
    {
        private string id;
        private string name;
        private string cellphone;
        private string email;

        public Contact(string id, string name, string cellphone, string email)
        {
            this.Id = id;
            this.Name = name;
            this.Cellphone = cellphone;
            this.Email = email;
        }
        

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Cellphone { get => cellphone; set => cellphone = value; }
        public string Email { get => email; set => email = value; }
    }
}