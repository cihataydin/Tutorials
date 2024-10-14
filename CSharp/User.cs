namespace CSharp
{
    public class User
    {
        // Field (Alan)
        private string _email;

        // Property (Özellik)
        private string _name;
        public string Name 
        { 
            get 
            { 
                if(_name == null || _name == "") 
                {                   
                    return "No name";
                }

                return _name; 
            } 
            set 
            { 
                if(value == null || value == "") 
                {
                    throw new ArgumentException("Name cannot be empty");
                }

                _name = value; 
            } 
        }

        public string Surname { get; set; }

        private int _age;
        public int Age { get { return _age; } set { _age = value; } }

        public int Age2 { get; set; }
        public string Email
        {
            get { return _email; }
            set
            {
                // Basit bir email doğrulaması
                if (value.Contains("@"))
                {
                    _email = value;
                }
                else
                {
                    throw new ArgumentException("Invalid email format.");
                }
            }
        }

        // Method
        public void ConsolaBas()
        {
            Console.WriteLine($"Name: {Name} {Surname}, Age: {Age}, Email: {Email}");
        }
    }
}