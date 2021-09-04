namespace Library
{
    public class Patient
    {
        public string Id;
        public string Name;
        public string PhoneNumber;
        public int Age;

        public Patient(string id, string name, string phoneNumber, int age)
        {
            this.Id = id;
            this.Name = name;
            this.PhoneNumber = phoneNumber;
            this.Age = age;
        }
    }
}