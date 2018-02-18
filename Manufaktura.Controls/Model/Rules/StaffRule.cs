using System;

namespace Manufaktura.Controls.Model.Rules
{
    /// <summary>
    /// Base class for implementing staff rules
    /// </summary>
    /// <typeparam name="TSymbol"></typeparam>
    public abstract class StaffRule<TSymbol> : StaffRule where TSymbol : MusicalSymbol
    {
        /// <summary>
        /// Applies rule to staff and newElement.
        /// </summary>
        /// <param name="staff">Staff</param>
        /// <param name="newElement">Element to apply the rule on</param>
        public abstract void Apply(Staff staff, TSymbol newElement);

        /// <summary>
        /// Condition that must be satisfied for this rule to be applied.
        /// </summary>
        /// <param name="staff">Staff</param>
        /// <param name="newElement">Element to apply the rule on</param>
        /// <returns></returns>
        public abstract bool Condition(Staff staff, TSymbol newElement);

        internal override void Apply(Staff staff, ViewModel newElement)
        {
            var typedSymbol = newElement as TSymbol;
            if (typedSymbol == null) throw new InvalidCastException(string.Format("Element must be of type {0}.", typeof(TSymbol).Name));
            Apply(staff, typedSymbol);
        }

        internal override bool Condition(Staff staff, ViewModel newElement)
        {
            var typedSymbol = newElement as TSymbol;
            if (typedSymbol == null) return false;
            return Condition(staff, typedSymbol);
        }
    }

    /// <summary>
    /// Base class for implementing staff rules
    /// </summary>
    public abstract class StaffRule
    {

        /// <summary>
        /// Applies rule to staff and newElement.
        /// </summary>
        internal abstract void Apply(Staff staff, ViewModel newElement);

        /// <summary>
        /// Condition that must be satisfied for this rule to be applied.
        /// </summary>
        internal abstract bool Condition(Staff staff, ViewModel newElement);
    }
}