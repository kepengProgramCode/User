using System;
using Business.Framework.DataAttribute;
using Business.Framework;
namespace JJE_WMS_Entity
{
    [Table("Table_Log")]
    [Columns(new string[] { "Id" }, "Logtime", "LogUser", "Remark", "Type")]
    public class Log : Entity
    {
        private long id;
        private DateTime logtime;
        private string logUser;
        private string remark;
        private string type;
        public long Id
        {
            get { return id; }
            set { id = value; }
        }

        public DateTime Logtime
        {
            get { return logtime; }
            set { logtime = value; }
        }

        public string LogUser
        {
            get { return logUser; }
            set { logUser = value; }
        }

        public string Remark
        {
            get { return remark; }
            set { remark = value; }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

    }
}
