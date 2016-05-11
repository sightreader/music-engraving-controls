namespace Manufaktura.Controls.Desktop.Audio.Midi
{
	/// <summary>
	/// Defines constants for ChannelMessage types.
	/// </summary>
	public enum ChannelCommand
	{
		/// <summary>
		/// Represents the note-off command type.
		/// </summary>
		NoteOff = 0x80,

		/// <summary>
		/// Represents the note-on command type.
		/// </summary>
		NoteOn = 0x90,

		/// <summary>
		/// Represents the poly pressure (aftertouch) command type.
		/// </summary>
		PolyPressure = 0xA0,

		/// <summary>
		/// Represents the controller command type.
		/// </summary>
		Controller = 0xB0,

		/// <summary>
		/// Represents the program change command type.
		/// </summary>
		ProgramChange = 0xC0,

		/// <summary>
		/// Represents the channel pressure (aftertouch) command
		/// type.
		/// </summary>
		ChannelPressure = 0xD0,

		/// <summary>
		/// Represents the pitch wheel command type.
		/// </summary>
		PitchWheel = 0xE0
	}
}