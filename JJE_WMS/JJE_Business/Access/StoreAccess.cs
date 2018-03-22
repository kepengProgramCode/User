using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business.Framework.Access;
using Business.Framework.Data;
using JJE_WMS_Entity;
using Business.Framework.MD5Business;

namespace JJE_Business.Access
{
    public class StoreAccess : EntityAccess
    {
        public StoreAccess(bool flage)
            : base(flage)
        {

        }

        public StoreAccess()
        {

        }

        private static DataBase database;

        public override DataBase DataBase
        {
            get { return StoreAccess.database; }
        }

        protected override void SetDataBase(DataBase database)
        {
            StoreAccess.database = database;
        }

        public User Login(string userName, string userPassword)
        {
            string strSQL = CommandFormate("SELECT * FROM [Table_User] WHERE Id = {0}id AND Password = {0}password");
            List<User> userInfo = ExcuteSelect<User>(strSQL, parmater =>
            {
                parmater.Add(parmater.CreateParameter("id", userName));
                parmater.Add(parmater.CreateParameter("password", MD5Unit.ToByte(userPassword)));
            });
            if (userInfo.Count > 0)
            {
                return userInfo[0];
            }
            return null;
        }
    }
}
