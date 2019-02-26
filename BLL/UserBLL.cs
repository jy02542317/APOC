using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDAL;
using Model;

namespace BLL
{
    public class UserBLL
    {
        private static IUserDAL user = new DALFactory<User>().CreateDAL();

        public bool ExistName(string username)
        {
            return user.ExistName(username);
        }

        public string AddUser(User t)
        {
            if (ExistName(t.LoginName))
                return "用户名已经存在！";
            else
            {
                try
                {
                    int r = user.AddUser(t);
                    return "用户新增成功！";
                }
                catch (Exception ex)
                {
                    return ex.ToString();
                }
            }
        }

        public bool Login(User t)
        {
            return user.Login(t);
        }
    }
}
