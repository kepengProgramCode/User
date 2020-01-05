using Snt.Framework.Access;
using Snt.Framework.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A19126WMS.BaseBusiness
{
    public class WMSAccess : EntityAccess
    {
        private static Database database;
        public WMSAccess()
        {
        }
        public WMSAccess(bool mutiCommand)
            : base(mutiCommand)
        {

        }

        public override Database Database
        {
            get { return database; }
        }

        protected override void SetDatabase(Database database)
        {
            WMSAccess.database = database;
        }
    }
}
