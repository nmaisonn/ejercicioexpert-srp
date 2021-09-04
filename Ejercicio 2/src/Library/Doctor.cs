namespace Library
{
    public class Doctor
    {
        public string Id;
        public string Name;
        public string Specialty;

        public Doctor(string id, string name, string specialty)
        {
            this.Id = id;
            this.Name = name;
            this.Specialty = specialty;
        }
    }
}