using Manufaktura.Orm.Predicates;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace Manufaktura.Orm.Linq
{
    public static class Linq2PredicateParser
    {
        public static SqlPredicate Parse(Expression expression)
        {
            var methodCallExpression = expression as MethodCallExpression;
            if (methodCallExpression != null)
            {
                if (methodCallExpression.Method.Name == nameof(string.Contains))
                {
                    var memberExpression = methodCallExpression.Object as MemberExpression;
                    return QB.Like(memberExpression.Member.Name, Expression.Lambda(methodCallExpression.Arguments.First()).Compile().DynamicInvoke() );
                }
                else
                {
                    throw new Exception($"Unsupported method {methodCallExpression.Method.Name} in expression {expression}.");
                }
            }

            var binaryExpression = expression as BinaryExpression;
            if (binaryExpression == null) throw new Exception($"Unsupported expression {expression}.");

            switch(binaryExpression.NodeType)
            {
                case ExpressionType.AndAlso:
                    return QB.And(Parse(binaryExpression.Left), Parse(binaryExpression.Right));

                case ExpressionType.OrElse:
                    return QB.Or(Parse(binaryExpression.Left), Parse(binaryExpression.Right));

                case ExpressionType.NotEqual:
                    var nameAndValue0 = GetColumnNameAndParameterValue(binaryExpression);
                    return QB.NEq(nameAndValue0.Item1, nameAndValue0.Item2);

                case ExpressionType.Equal:
                    var nameAndValue1 = GetColumnNameAndParameterValue(binaryExpression);
                    return QB.Eq(nameAndValue1.Item1, nameAndValue1.Item2);

                case ExpressionType.LessThan:
                    var nameAndValue2 = GetColumnNameAndParameterValue(binaryExpression);
                    return QB.Le(nameAndValue2.Item1, nameAndValue2.Item2);

                case ExpressionType.LessThanOrEqual:
                    var nameAndValue3 = GetColumnNameAndParameterValue(binaryExpression);
                    return QB.LEq(nameAndValue3.Item1, nameAndValue3.Item2);

                case ExpressionType.GreaterThan:
                    var nameAndValue4 = GetColumnNameAndParameterValue(binaryExpression);
                    return QB.Gr(nameAndValue4.Item1, nameAndValue4.Item2);

                case ExpressionType.GreaterThanOrEqual:
                    var nameAndValue5 = GetColumnNameAndParameterValue(binaryExpression);
                    return QB.GEq(nameAndValue5.Item1, nameAndValue5.Item2);

                default:
                    throw new Exception($"Unsupported expression {expression}.");
            }
        }

        private static Tuple<string, object> GetColumnNameAndParameterValue(BinaryExpression expression)
        {
            var memberExpression = expression.Left as MemberExpression ?? expression.Right as MemberExpression;
            if (memberExpression == null) throw new Exception($"Can't find column name in expression {expression}.");
            var otherExpression = expression.Left is MemberExpression ? expression.Right : expression.Left;
            return new Tuple<string, object>(memberExpression.Member.Name, Expression.Lambda(otherExpression).Compile().DynamicInvoke());
        }

    }
}