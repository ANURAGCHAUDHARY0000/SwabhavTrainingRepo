using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AuthDictioanaryApp.Model;

namespace AuthDictioanaryApp.Service
{
  
    internal class AuthenticationService
    {
        private Dictionary<int, User> _userDB;

        public AuthenticationService() {
            _userDB = new Dictionary<int, User>();
            User user1 = new User(1, "1abc", "Anu", "patel");
            User user2 = new User(2, "2cde", "anup", "patel");
            User user3 = new User(3, "3abc", "Anurag", "patil");
            User user4 = new User(4, "4rfg", "Anupriya", "pal");
            User user5 = new User(5, "5cde", "Anushka", "lamba");

            _userDB.Add(user1.Id, user1);
            _userDB.Add(user2.Id, user2);
            _userDB.Add(user3.Id, user3);
            _userDB.Add(user4.Id, user4);
            _userDB.Add(user5.Id, user5);

        }

        public  bool CheckValidUser(int id, string password)
        {
            if(_userDB.ContainsKey(id))
            {
                if (_userDB[id].Password == password)
                    return true;
            }
            return false;
        }
    }

    
}
