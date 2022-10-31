
namespace AuthDictioanaryApp.Model
{
    internal class User
    {
        private int _id;
        private string _password;
        private string _firstName;
        private string _lastName;

        public User(int id, string password, string firstName, string lastName)
        {
            _id = id;
            _password = password;
            _firstName = firstName;
            _lastName = lastName;
        }

        public int Id { get { return _id; } }
        public string Password { get { return _password; } }    
        public string FirstName { get { return _firstName; } }
        public string LastName { get { return _lastName; } }

    }
}
