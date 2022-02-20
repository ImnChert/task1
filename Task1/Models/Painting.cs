using System;
using Task1.Enums;

namespace Task1.Models
{
	/// <summary>
	/// An abstract class that implements a general description of paintings.
	/// </summary>
	public class Painting
	{
		public string Author { get; }
		public int Year { get; }
		public string Title { get; }
		public string Genre { get; }
		public PaintingTechnique Technique { get; }

		public Painting(string author, int year, string title, string genre, PaintingTechnique technique)
		{
			Author = author;
			Year = year;
			Title = title;
			Genre = genre;
			Technique = technique;
		}

		public override bool Equals(object obj)
		{
			var other = obj as Painting;

			if (other == null)
				return false;

			return (other.Author == Author) && (other.Title == Title)
					&& (other.Genre == Genre) && (Year == other.Year);
		}

		public override int GetHashCode()
		{
			return Tuple.Create(Author, Year, Title, Genre).GetHashCode();
		}

		public override string ToString() => $"{Author};{Year};{Title};{Genre};{Technique}";
	}
}
