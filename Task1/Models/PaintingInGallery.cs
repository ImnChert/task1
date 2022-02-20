using System;
using Task1.Enums;

namespace Task1.Models
{
	/// <summary>
	/// A class describing paintings in galleries.
	/// </summary>
	public class PaintingInGallery : Painting
	{
		public bool IsBeingExhibited { get; private set; }
		public int HallNumber { get; private set; }
		public int RoomSeatInTheHall { get; private set; }
		public DateTime WhenItWasExhibited { get; private set; }
		public TimeSpan HowMuchWasExhibited
		{
			get
			{
				if (IsBeingExhibited)
				{
					return DateTime.Now - WhenItWasExhibited;
				}

				return HowMuchWasExhibited;
			}
			private set => HowMuchWasExhibited = value;
		}

		public PaintingInGallery(string author, int year, string title, string genre, PaintingTechnique technique, bool isBeingExhibited, int hallNumber, int roomSeatInTheHall)
			: base(author, year, title, genre, technique)
		{
			IsBeingExhibited = isBeingExhibited;
			HallNumber = hallNumber;
			RoomSeatInTheHall = roomSeatInTheHall;

			if (IsBeingExhibited)
			{
				WhenItWasExhibited = DateTime.Now;
			}
		}
		/// <summary>
		/// Transfers the painting from the warehouse to the exhibited and sets the time when the picture was hung.
		/// </summary>
		/// <param name="hallNumber">Hall number.</param>
		/// <param name="roomSeatInTheHall">Room seat in the hall.</param>
		/// <exception cref="Exception">No painting found.</exception>
		public void HangThePicture(int hallNumber, int roomSeatInTheHall)
		{
			if (IsBeingExhibited == false)
			{
				IsBeingExhibited = true;
				WhenItWasExhibited = DateTime.Now;
				HallNumber = hallNumber;
				RoomSeatInTheHall = roomSeatInTheHall;
			}
			else
			{
				throw new Exception("The painting is already hanging");
			}
		}
		/// <summary>
		/// Transfers the painting from the exhibited to the warehouse and sets how long the picture hung.
		/// </summary>
		/// <exception cref="Exception">No painting found.</exception>
		public void TakingDownThePicture()
		{
			if (IsBeingExhibited == true)
			{
				IsBeingExhibited = false;
				HowMuchWasExhibited = DateTime.Now - WhenItWasExhibited;
				HallNumber = 0;
				RoomSeatInTheHall = 0;
			}
			else
			{
				throw new Exception("The painting is already taking down");
			}
		}
	}
}
