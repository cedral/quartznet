using System;
using System.Data.Common;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quartz.Impl.AdoJobStore
{
    public class SqlServerDelegate : SqlCeDelegate
    {
        public override void AddCommandParameter(
            DbCommand cmd,
            string paramName,
            object? paramValue,
            Enum? dataType = null,
            int? size = null)
        {
            if (size == null)
            {
                if (paramValue is string)
                {   // always use same size for strings so only one query plan is required
                    size = 4000;
                }
                else if (dataType != null && dataType.Equals(DbProvider.Metadata.DbBinaryType))
                {
                    size = -1;
                }
            }

            base.AddCommandParameter(cmd, paramName, paramValue, dataType, size);
        }
    }
}
