using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TShockAPI
{
	/// <summary>
	/// Represents a buff.
	/// </summary>
	public struct NetBuff
	{
		/// <summary>
		/// Gets the type.
		/// </summary>
		public int Type { get; }

		/// <summary>
		/// Gets the time.
		/// </summary>
		public int Time { get; }

		/// <summary>
		/// Initializes a new instance of the <see cref="NetBuff"/> class with the specified type and time.
		/// </summary>
		/// <param name="type">The type.</param>
		/// <param name="time">The time.</param>
		public NetBuff(int type, int time)
		{
			Type = type;
			Time = time;
		}

		/// <summary>
		/// Parses a <see cref="NetBuff"/> from the given string.
		/// </summary>
		/// <param name="input">The string.</param>
		/// <exception cref="ArgumentNullException"><paramref name="input"/> is null.</exception>
		/// <returns>A <see cref="NetBuff"/>.</returns>
		public static NetBuff Parse(string input)
		{
			if (input == null)
			{
				throw new ArgumentNullException(nameof(input));
			}

			var parsed = input.Split(',');
			if (parsed.Length != 2)
			{
				throw new FormatException("The string does not contain 2 sections.");
			}

			var buffType = int.Parse(parsed[0]);
			var buffTime = int.Parse(parsed[1]);
			return new NetBuff(buffType, buffTime);
		}

		/// <summary>
		/// Gets the string representation of this buff.
		/// </summary>
		/// <returns>The string representation.</returns>
		public override string ToString()
		{
			return $"{Type},{Time}";
		}
	}
}
