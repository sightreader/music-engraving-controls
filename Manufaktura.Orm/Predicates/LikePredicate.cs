using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Manufaktura.Orm
{
    public class LikePredicate : SqlPredicate
    {
        public string ParameterName { get; protected set; }
        public object ParameterValue { get; protected set; }

        public LikePredicate(string parameterName, object parameterValue) 
        {
            ParameterName = parameterName;
            ParameterValue = parameterValue;
        }

        public override string GetSql(ref int parameterCounter)
        {
            return string.Format (" {0} LIKE @P{1} ", ParameterName, parameterCounter++);
        }

        public override object[] GetParameterValues()
        {
            return new[] { ParameterValue };
        }
    }
}