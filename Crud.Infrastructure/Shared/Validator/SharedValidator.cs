using SharpCompress.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud.Infrastructure.Shared.Validator
{
    public static class SharedValidator
    {
        public static void ValidEntity<T>(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));
        }
    }
}
