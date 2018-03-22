using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using JJECN_WMS.BaseFoundation;
using JJE_WMS_Entity;
using DevExpress.XtraGrid.Views.Base;
using JJE_Business.Business;

namespace JJECN_WMS.DataBaseManager
{
    public partial class ResizeStoreForm : BaseForm
    {
        StoreUnit storeUnit;
        public ResizeStoreForm()
        {
            InitializeComponent();
            storeUnit = new StoreUnit();
        }


        private void ResizeStoreForm_Load(object sender, EventArgs e)
        {
            this.cmbDel.Items.Add("单个删除");
            this.cmbDel.Items.Add("全部删除");
            cmbDel.SelectedIndex = 0;
            this.gridControlMessage.DataSource = storeUnit.GetStoreStructure();
        }


        /// <summary>
        /// 选择改变事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridView1_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            DataRow row = gridView1.GetDataRow(e.FocusedRowHandle);
            txtRowNumber.Text = row.ItemArray[0].ToString();
            txtColumnNumber.Text = row.ItemArray[1].ToString();
            txtLayerNumber.Text = row.ItemArray[2].ToString();
            txtUsedStatus.Text = row.ItemArray[3].ToString();
            txtStoreType.Text = row.ItemArray[6].ToString();
        }

        /// <summary>
        /// 确认保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (storeUnit.StoreStructUpdate(txtUsedStatus.Text, txtStoreType.Text, txtRowNumber.Text, txtColumnNumber.Text, txtLayerNumber.Text) == 1)
                LogBusiness.RecordLog("管理员", string.Format("将库位{0}-{1}-{2}状态修改为【使用状态{3}】", txtRowNumber.Text, txtColumnNumber.Text, txtLayerNumber.Text, txtUsedStatus.Text), "修改仓库结构属性");
            MessageBox.Show("修改成功，重启系统以后生效", "提示！", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        /// <summary>
        /// 删除该条信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            storeUnit.DeleteStoreStruct(cmbDel.SelectedItem.ToString(), txtRowNumber.Text, txtColumnNumber.Text, txtLayerNumber.Text);
            if (cmbDel.SelectedItem.ToString() != "全部删除")
            {
                LogBusiness.RecordLog("管理员", string.Format("将库位{0}-{1}-{2}删除", txtRowNumber.Text, txtColumnNumber.Text, txtLayerNumber.Text), "删除库位");
            }
            else
            {
                LogBusiness.RecordLog("管理员", "将仓库所有库位全部删除", "删除全部库位");
            }
            MessageBox.Show("删除成功，重启系统以后生效", "提示！", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
    }
}
