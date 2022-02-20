using System.Collections.Generic;
using Task1.Models;

namespace Task1.Interfaces
{
	/// <summary>
	/// The interface implementing the storage.
	/// </summary>
	internal interface IStorage
	{
		public List<Painting> Paintings { get; set; }
	}
}
