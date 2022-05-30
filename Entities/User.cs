

namespace VisualInterface.Entities
{
    class User {

        public string Name { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public string Password { get; set; }


        public User(string name, string email, string cpf, string password)
        {
            Name = name;
            Email = email;
            Cpf = cpf;
            Password = password;
        }

        public User(string email, string password)
        {
            Email = email;
            Password = password;
        }
    }
}
