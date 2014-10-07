using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Web;

namespace Manufaktura.Orm
{
    public abstract class SqlPredicate
    {
        public string ParameterName { get; protected set; }
        public object ParameterValue { get; protected set; }

        public abstract string GetSql();

        protected SqlPredicate()
        {

        }
    }
}