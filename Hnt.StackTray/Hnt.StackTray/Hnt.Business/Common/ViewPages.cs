using Hnt.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hnt.Business.Common
{
    public class ViewPages : INotifyPropertyChanged
    {
        private int _number;
        public int Number
        {
            get { return _number; }
            set
            {
                _number = value;
                NotifyPropertyChanged("Number");
            }
        }

        private int _currentSize;
        public int CurrentSize
        {
            get { return _currentSize; }
            set
            {
                _currentSize = value;
                NotifyPropertyChanged("CurrentSize");
            }
        }

        private int _total;
        public int Total
        {
            get { return _total; }
            set
            {
                _total = value;
                NotifyPropertyChanged("Total");
            }
        }

        private List<Page> _pages;
        public List<Page> Pages
        {
            get { return _pages; }
            set
            {
                _pages = value;
                NotifyPropertyChanged("Pages");
            }
        }

        private List<StackTrays> _listRegDept;
        public List<StackTrays> ListRegDept
        {
            get { return _listRegDept; }
            set
            {
                _listRegDept = value;
                NotifyPropertyChanged("ListRegDept");
            }
        }

        private List<StackTrays> _listBind;
        public List<StackTrays> ListBind
        {
            get { return _listBind; }
            set
            {
                _listBind = value;
                NotifyPropertyChanged("ListBind");
            }
        }

        #region INotyfyPropertyChanged 成员
        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string PropertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
            }
        }
        #endregion

        public ViewPages(List<StackTrays> listRegDept)
        {
            this.Number = 14;//设置每页显示数目
            this.ListRegDept = listRegDept;
            this.Total = ListRegDept.Count() / this.Number + 1;//获取总页数

            this.Pages = new List<Page>();//初始化所有页数数组
            for (int i = 1; i <= this.Total; i++)
            {
                this.Pages.Add(new Page { Name = i.ToString(), PageSize = i });
            }
            this.CurrentSize = 1;//设置当前显示页面
            Fun_Pager(this.CurrentSize);
        }
        /// <summary>
        /// 分页方法
        /// </summary>
        /// <param name="CurrentSize">当前页数</param>
        public void Fun_Pager(int CurrentSize)
        {
            this.CurrentSize = CurrentSize;
            this.ListBind = this.ListRegDept.Take(this.Number * this.CurrentSize)
                .Skip(this.Number * (this.CurrentSize - 1)).ToList();
        }
    }

    public class Page
    {
        public string Name { get; set; }
        public int PageSize { get; set; }
    }

}
