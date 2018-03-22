using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JJE_WMS_Entity;
using JJE_Business.Access;
using System.Data.Common;
using System.Windows.Forms;

namespace JJE_Business.Business
{
    public class InstorgeBusiness
    {
        public int SaveMessage(Semi_finishedProducts product)
        {
            int num = 0;
            using (StoreAccess access = new StoreAccess(true))
            {
                try
                {
                    access.Open();
                    access.BeginTransaction();
                    num = access.Insert(product);
                    access.Commit();
                }
                catch (DbException ex)
                {
                    access.Close();
                    access.RollBack();
                    MessageBox.Show(ex.Message, "错误");
                }
            }
            return num;
        }
    }
}
