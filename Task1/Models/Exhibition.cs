using System.Collections.Generic;
using Task1.Interfaces;

namespace Task1.Models
{
	/// <summary>
	/// A class describing the gallery's showroom.
	/// </summary>
	internal class Exhibition : IStorage
	{
		public List<Painting> Paintings { get; set; }

		public Exhibition()
		{
			Paintings = new List<Painting>();
		}
	}
}
