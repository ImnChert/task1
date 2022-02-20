using System.Collections.Generic;
using Task1.Interfaces;

namespace Task1.Models
{
	/// <summary>
	/// A class describing the gallery warehouse.
	/// </summary>
	internal class Warehouse : IStorage
	{
		public List<Painting> Paintings { get; set; }

		public Warehouse()
		{
			Paintings = new List<Painting>();
		}
	}
}
