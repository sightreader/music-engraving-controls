namespace Manufaktura.Controls.Model
{
	/// <summary>
	/// Indicates that class represents element of tuplet
	/// </summary>
	internal interface ICanBeElementOfTuplet
	{
		TupletType Tuplet { get; set; }

		double? TupletWeightOverride { get; set; }

		/// <summary>
		/// Vertical placement of tuplet sign.
		/// </summary>
		VerticalPlacement? TupletPlacement { get; set; }
	}
}