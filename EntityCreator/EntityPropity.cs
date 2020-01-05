using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityCreator
{
    class EntityPropity
    {
        private string className;
        private List<Column> columnsPropoty;
        private string classAuthor;
        private string nameSpace;
        private string classExplain;

        public List<Column> ColumnsPropoty { get => columnsPropoty; set => columnsPropoty = value; }
        public string ClassAuthor { get => classAuthor; set => classAuthor = value; }
        public string NameSpace { get => nameSpace; set => nameSpace = value; }
        public string ClassName { get => className; set => className = value; }
        public string ClassExplain { get => classExplain; set => classExplain = value; }
    }

    struct Column
    {
        string name;
        string type;
        string description;

        public string Name { get => name; set => name = value; }
        public string Type { get => type; set => type = value; }
        public string Description { get => description; set => description = value; }
    }
}
