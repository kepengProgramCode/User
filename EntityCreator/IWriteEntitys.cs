using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityCreator
{
    interface IWriteEntitys
    {
        bool Write(FileStream fs, EntityPropity headerOfEntity);
    }
}
