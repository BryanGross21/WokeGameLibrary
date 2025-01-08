using System;

namespace WokeGameLibrary
{
	public enum Recommendation 
	{
		WOKE,
		NOT_WOKE,
		SOMEWHAT_WOKE
	}
	public class GameInfo
	{
		private string _name = "";

		public string Name 
		{
			get 
			{
				return _name;
			}
			set 
			{
				_name = value;
			}
		}

		private string _developer = "";

		public string Developer 
		{
			get 
			{
				return _developer;
			}
			set 
			{
				_developer = value;
			}
		}

		private string _publisher = "";

		public string Publisher 
		{
			get 
			{
				return _publisher;
			}
			set 
			{
				_publisher = value;
			}
		}

		private string _description = "";

		public string Description 
		{
			get 
			{
				return _description;
			}
			set 
			{
				_description = value;
			}
		}

		private string _releaseYear = "";

		public string releaseYear 
		{
			get 
			{
				return _releaseYear;
			}
			set 
			{
				_releaseYear = value;
			}
		}

		private Recommendation _recommendation;

		public Recommendation isWoke 
		{
			get 
			{
				return _recommendation;
			}
			set 
			{
				_recommendation = value;
			}
		}
	}
}
