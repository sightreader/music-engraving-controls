namespace Manufaktura.Orm.Portable.Predicates
{
    public class NotEqualsPredicate : ConditionPredicate
    {
        public NotEqualsPredicate(string parameterName, object parameterValue) : base(parameterName, parameterValue)
        {
        }

        public override string OperatorText
        {
            get { return "<>"; }
        }
    }
}