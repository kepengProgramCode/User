using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityCreator
{
    class WriteEntity : IWriteEntitys
    {
        public bool Write(FileStream fs, EntityPropity headerOfEntity)
        {
            List<Column> columns = headerOfEntity.ColumnsPropoty;
            //向流中写入字符
            StreamWriter sw = new StreamWriter(fs);
            //写入类的头部信息
            sw.WriteLine("/*\n" + "*作者：" + headerOfEntity.ClassAuthor + "\n" + "*创建时间：" + DateTime.Now.ToString() + " \n" + "*/\n");
            sw.WriteLine("using Snt.Framework.DataAttribute;");
            sw.WriteLine("using Snt.Framework.Entities;");
            sw.WriteLine("using System;" + "\n");
            //判断命名空间
            if (headerOfEntity.NameSpace != "")
            {
                //写入命名空间
                sw.WriteLine("namespace " + headerOfEntity.NameSpace + "\n{");
                sw.WriteLine("    [Table(" + "\"" + headerOfEntity.ClassName + "\"" + ")]");
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.Append("    [Column(new string[]{" + "\"" + columns[0].Name + "\"}");
                for (int i = 1; i < columns.Count - 1; i++)
                {
                    stringBuilder.AppendFormat(",{0}{1}{2}", "\"", columns[i].Name, "\"");
                }
                sw.WriteLine(stringBuilder.ToString() + ")]");
                stringBuilder.Clear();
                //写入类说明
                sw.WriteLine("    /// <summary>\n" + "    /// " + headerOfEntity.ClassExplain + "\n    /// </summary>");
                //写类的定义
                sw.WriteLine("    public class " + headerOfEntity.ClassName + ":EntityBase");
                sw.WriteLine("    {");
                for (int i = 0; i < columns.Count - 1; i++)
                {
                    stringBuilder.AppendFormat("       public const string {0} = {1}{2}{3};{4}", columns[i].Name.ToUpper(), "\"", columns[i].Name, "\"", "\n");
                }
                sw.WriteLine(stringBuilder.ToString());
                //写属性
                for (int i = 0; i < columns.Count - 1; i++)
                {
                    sw.WriteLine("       private " + columns[i].Type + " " + FirstToLower(columns[i].Name) + ";\n" + "       /// <summary>\n" + "       /// " + columns[i].Description + "\n" +
                                  "       /// </summary>\n" +
                                  "       public " + columns[i].Type + " " + columns[i].Name + "\n" +
                                  "       {\n" +
                                  "         get { return " + FirstToLower(columns[i].Name) + "; }\n" +
                                  "         set { " + FirstToLower(columns[i].Name) + " = value; }\n" +
                                  "       }\n");
                }
                sw.Write("    }\n");
                sw.WriteLine("}");
            }
            sw.Close();
            fs.Close();
            return true;
        }
        /// <summary>
        /// 用来将首字母大写，如果以下划线开头，则把第二个字母大写
        /// </summary>
        /// <param name="letter">传入的字符串</param>
        /// <returns></returns>
        private string FirstToUpper(string letter)
        {
            string str;
            //这种情况是为Java的命名规范设计的
            if (letter.Substring(0, 1) == "-")
            {
                str = letter.Substring(1, 1);
                str = str.ToUpper();
                return str + letter.Substring(2);
            }

            str = letter.Substring(0, 1);
            str = str.ToUpper();
            return str + letter.Substring(1);
        }

        private string FirstToLower(string letter)
        {
            string str;
            //这种情况是为Java的命名规范设计的
            if (letter.Substring(0, 1) == "-")
            {
                str = letter.Substring(1, 1);
                str = str.ToLower();
                return str + letter.Substring(2);
            }

            str = letter.Substring(0, 1);
            str = str.ToLower();
            return str + letter.Substring(1);
        }
    }
}