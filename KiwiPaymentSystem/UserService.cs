using KiwiPaymentSystem.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiwiPaymentSystem
{
    public class UserService
    {
        EntityModal db = new EntityModal(); 

        public bool CheckUser(string login, string password)
        {
            return db.Users.Any(w => w.Login == login && w.Password == password);
        }
    }
}
