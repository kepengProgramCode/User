using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityCreator
{
    public partial class CreateEntiteForm : Form
    {
        List<CheckBox> listCheckBox = new List<CheckBox>();
        public CreateEntiteForm()
        {
            InitializeComponent();
            this.btnExport.Enabled = false;
            this.btnConnectionDb.Enabled = false;
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            string connection = $"Data Source={txtServerName.Text};Initial Catalog=master;User ID={txtUserName.Text};Password={txtPwd.Text}";
            SqlConnection sqlConnection = new SqlConnection(connection);
            if (sqlConnection.State != ConnectionState.Connecting)
            {
                sqlConnection.Open();
                string commamdText = "SELECT name FROM sysdatabases";
                SqlCommand sqlCommand = new SqlCommand(commamdText, sqlConnection);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                int index = 0;
                while (reader.Read())
                {
                    index++;
                    if (index > 6)
                    {
                        cobmDatabaseName.Items.Add((string)reader["name"]);
                    }
                }
                sqlConnection.Close();
                if (cobmDatabaseName.Items.Count > 0)
                {
                    btnConnectionDb.Enabled = true;
                    checkBoxAll.Enabled = false;
                    cobmDatabaseName.SelectedIndex = 0;
                }
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            List<EntityPropity> entityPropities = new List<EntityPropity>();
            string connection = $"Data Source={txtServerName.Text};Initial Catalog={cobmDatabaseName.SelectedItem.ToString()};User ID={txtUserName.Text};Password={txtPwd.Text}";
            SqlConnection sqlConnection = new SqlConnection(connection);
            if (sqlConnection.State != ConnectionState.Connecting)
            {
                for (int i = 0; i < listCheckBox.Count; i++)
                {
                    sqlConnection.Open();
                    // SELECT TableName = OBJECT_NAME(c.object_id),ColumnsName = c.name,Description = ex.value,ColumnType = t.name,Length = c.max_length FROM sys.columns c LEFT OUTER JOIN sys.extended_properties ex ON ex.major_id = c.object_id AND ex.minor_id = c.column_id AND ex.name = 'MS_Description'LEFT OUTER JOIN systypes t ON c.system_type_id = t.xtype WHERE OBJECTPROPERTY(c.object_id, 'IsMsShipped') = 0 AND OBJECT_NAME(c.object_id ) = 'StorageLocation'
                    string commamdText = $"SELECT TableName = OBJECT_NAME(c.object_id),ColumnsName = c.name,Description = ex.value,ColumnType = t.name,Length = c.max_length FROM sys.columns c LEFT OUTER JOIN sys.extended_properties ex ON ex.major_id = c.object_id AND ex.minor_id = c.column_id AND ex.name = 'MS_Description'LEFT OUTER JOIN systypes t ON c.system_type_id = t.xtype WHERE OBJECTPROPERTY(c.object_id, 'IsMsShipped') = 0 AND OBJECT_NAME(c.object_id ) = '{listCheckBox[i].Name}'";
                    SqlCommand sqlCommand = new SqlCommand(commamdText, sqlConnection);
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    List<Column> lis = new List<Column>();
                    while (reader.Read())
                    {
                        Column column = new Column();
                        column.Name = reader["ColumnsName"].ToString();
                        column.Description = reader["Description"].ToString();
                        switch (reader["ColumnType"].ToString())
                        {
                            case "int":
                                column.Type = "int";
                                break;
                            case "float":
                                column.Type = "float";
                                break;
                            case "datetime":
                                column.Type = "DateTime";
                                break;
                            default:
                                column.Type = "string";
                                break;
                        }
                        lis.Add(column);
                    }
                    EntityPropity entityPropity = new EntityPropity();
                    entityPropity.ClassAuthor = "";
                    entityPropity.ClassExplain = "";
                    entityPropity.ClassName = listCheckBox[i].Name;
                    entityPropity.ColumnsPropoty = lis;
                    entityPropity.NameSpace = txtNamespace.Text;
                    entityPropities.Add(entityPropity);
                    sqlConnection.Close();
                }
                FolderBrowserDialog dialog = new FolderBrowserDialog();
                dialog.Description = "将实体类保存到：";
                IWriteEntitys writeEntitys = new WriteEntity();
                //设置保存窗口的显示
                DialogResult result = dialog.ShowDialog();
                bool res = true;
                if (result == DialogResult.OK)
                {
                    for (int i = 0; i < entityPropities.Count; i++)
                    {
                        FileStream fs = new FileStream(dialog.SelectedPath + "\\" + entityPropities[i].ClassName + ".cs", FileMode.Create, FileAccess.Write);
                        res &= writeEntitys.Write(fs, entityPropities[i]);
                    }
                    if (res)
                    {
                        MessageBox.Show("保存成功！");
                    }
                }
            }
        }

        private void btnConnectionDb_Click(object sender, EventArgs e)
        {
            string connection = $"Data Source={txtServerName.Text};Initial Catalog={cobmDatabaseName.SelectedItem.ToString()};User ID={txtUserName.Text};Password={txtPwd.Text}";
            SqlConnection sqlConnection = new SqlConnection(connection);
            if (sqlConnection.State != ConnectionState.Connecting)
            {
                sqlConnection.Open();
                string commamdText = $"SELECT TABLE_NAME FROM {cobmDatabaseName.SelectedItem.ToString()}.information_schema.tables";
                SqlCommand sqlCommand = new SqlCommand(commamdText, sqlConnection);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                int x = 30; int y = 30;
                while (reader.Read())
                {
                    CheckBox chkbox = new CheckBox();
                    chkbox.Location = new Point(x, y);
                    chkbox.Width = 200;
                    chkbox.Name = reader["TABLE_NAME"].ToString();
                    chkbox.Text = reader["TABLE_NAME"].ToString();
                    chkbox.Click += Chkbox_Click;
                    groupBox2.Controls.Add(chkbox);
                    if (x == 780)
                    {
                        x = 30;
                        y += 30;
                    }
                    else
                    {
                        x += 250;
                    }
                }
                sqlConnection.Close();
                if (groupBox2.Controls.Count > 0)
                    this.checkBoxAll.Enabled = true;
            }
        }

        /// <summary>
        /// 单选
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Chkbox_Click(object sender, EventArgs e)
        {
            CheckBox check = sender as CheckBox;
            if (check.Checked)
            {
                listCheckBox.Add(check);
            }
            else
            {
                listCheckBox.Remove(listCheckBox.Find(o => o.Name == check.Name));
            }
            btnExport.Enabled = listCheckBox.Count > 0 ? true : false;
        }

        /// <summary>
        /// 全选反选
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxAll_Click(object sender, EventArgs e)
        {
            listCheckBox.Clear();
            CheckBox check = sender as CheckBox;
            if (check.Checked)
            {
                this.btnExport.Enabled = true;
                foreach (CheckBox item in groupBox2.Controls)
                {
                    item.Checked = true;
                    listCheckBox.Add((CheckBox)item);
                }
            }
            else
            {
                this.btnExport.Enabled = false;
                foreach (CheckBox item in groupBox2.Controls)
                {
                    item.Checked = false;
                }
            }
        }
    }
}
