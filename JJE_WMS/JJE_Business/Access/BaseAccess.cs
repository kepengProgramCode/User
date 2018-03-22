using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business.Framework.Access;
using Business.Framework.Data;

namespace JJE_Business.Access
{
    public class BaseAccess : EntityAccess
    {
        public BaseAccess(bool flage)
            : base(flage)
        {

        }

        public BaseAccess()
        {

        }

        private static DataBase database;

        public override DataBase DataBase
        {
            get { return BaseAccess.database; }
        }

        protected override void SetDataBase(DataBase database)
        {
            BaseAccess.database = database;
        }
    }
}
