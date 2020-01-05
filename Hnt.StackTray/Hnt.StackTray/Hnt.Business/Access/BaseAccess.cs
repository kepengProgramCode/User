using Snt.Framework.Access;
using Snt.Framework.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hnt.Business.Access
{
    public class BaseAccess : EntityAccess
    {

        private static Database database;
        public BaseAccess()
        {
        }
        public BaseAccess(bool mutiCommand)
            : base(mutiCommand)
        {

        }

        public override Database Database
        {
            get { return database; }
        }

        protected override void SetDatabase(Database database)
        {
            BaseAccess.database = database;
        }
    }
}
