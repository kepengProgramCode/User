using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using JJECN_WMS.BaseFoundation;
using JJE_Business.Business;

namespace JJECN_WMS.DataBaseManager
{
    public partial class CreatStore : BaseForm
    {
        private StoreUnit sortUnit;
        public event HandlerRecord Recordevent;
        public CreatStore()
        {
            InitializeComponent();
            sortUnit = new StoreUnit();
            cmbStoretype.Items.Add("原材料");
            cmbStoretype.Items.Add("半成品");
            cmbStoretype.Items.Add("成品");
            cmbStoretype.SelectedIndex = 0;
        }

        /// <summary>
        /// 创建仓库
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreat_Click(object sender, EventArgs e)
        {
            string storeEnd = string.Format("{0}-{1}-{2}", txtStoreNum.Text, txtRecharNum.Text.ToUpper(), storeLayerNum.Text);
            string storeStar = string.Format("{0}-{1}-{2}", textStarRow.Text, txtColumnStar.Text.ToUpper(), txtLayerStar.Text);
            if (!sortUnit.CreatStroe(storeStar, storeEnd, cmbStoretype.SelectedIndex))
            {
                LogBusiness.RecordLog("管理员", "创建仓库结构" + storeEnd + "失败", "创建仓库结构");
                MessageBox.Show("构造仓库结构失败，请删除结构以后再次重新构造", "提示！", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtRecharNum.Text = string.Empty;
                txtStoreNum.Text = string.Empty;
                storeLayerNum.Text = string.Empty;
            }
            else
            {
                LogBusiness.RecordLog("管理员", "创建仓库结构" + storeEnd + "成功", "创建仓库结构");
                txtRecharNum.Clear();
                txtStoreNum.Clear();
                storeLayerNum.Clear();
                MessageBox.Show("构造仓库结构成功", "提示！", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CreatStore_Load(object sender, EventArgs e)
        {

        }
    }
}
