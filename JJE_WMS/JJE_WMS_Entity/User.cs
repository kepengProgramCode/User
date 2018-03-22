using System;
using Business.Framework.DataAttribute;
using Business.Framework;
namespace JJE_WMS_Entity
{
    [Table("Table_User")]
    [Columns(new string[] { "Id" }, "Access", "Name", "Password", "Remark")]
    public class User : Entity
    {
        /// <summary>
        /// 权限1：管理员 2：普通
        /// </summary>
        private int access;
        /// <summary>
        /// 用户工号
        /// </summary>
        private long id;
        /// <summary>
        /// 姓名
        /// </summary>
        private string name;
        /// <summary>
        /// 密码
        /// </summary>
        private byte[] password;
        /// <summary>
        /// 备注
        /// </summary>
        private string remark;


        public int Access
        {
            get { return access; }
            set { access = value; }
        }


        public long Id
        {
            get { return id; }
            set { id = value; }
        }


        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public byte[] Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Remark
        {
            get { return remark; }
            set { remark = value; }
        }
    }
}
