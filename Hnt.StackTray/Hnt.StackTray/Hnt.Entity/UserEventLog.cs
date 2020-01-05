// 生成时间：2017/5/20 11:57:45
using Snt.Framework.DataAttribute;
using Snt.Framework.Entities;
using System;
namespace Hnt.Entity
{
    [Table("UserEventLog")]
    [Column(new string[] { "Id" }, "Account", "HandleEvent", "EventTime")]
    public class UserEventLog : EntityBase
    {
        public const string ID = "Id";
        public const string ACCOUNT = "Account";
        public const string HANDLE_EVENT = "HandleEvent";
        public const string EVENT_TIME = "EventTime";
        private Int64 id;
        public Int64 Id
        {
            get { return id; }
            set { id = value; }
        }

        private string account;
        public string Account
        {
            get { return account; }
            set { account = value; }
        }

        private string handleEvent;
        public string HandleEvent
        {
            get { return handleEvent; }
            set { handleEvent = value; }
        }

        private DateTime eventTime;
        public DateTime EventTime
        {
            get { return eventTime; }
            set { eventTime = value; }
        }

    }
}
