using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Manufaktura.Orm.Portable
{
    public abstract class SqlPredicate
    {
        public abstract string GetSql(ref int parameterCounter);

        public virtual object[] GetParameterValues()
        {
            return new object[] {};
        }

        protected SqlPredicate()
        {

        }
    }
}