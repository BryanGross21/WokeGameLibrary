using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WokeGameLibrary
{
	public class GameList
	{
		public ArrayList gameList = new();

		string FileName = Environment.CurrentDirectory + "\\wokegames.txt";

		public GameList() 
		{
			string[] gameInfo;
			using (StreamReader sr = new(FileName)) 
			{
				string currentLine;
				while ((currentLine = sr.ReadLine()) != null) 
				{
					gameInfo = currentLine.Split("}");
					GameInfo newGame = new();
					newGame.Name = gameInfo[0];
					newGame.releaseYear = gameInfo[1];
					newGame.Developer = gameInfo[2];
					newGame.Publisher = gameInfo[3];
					if (gameInfo[4] == "Recommended")
					{
						newGame.isWoke = Recommendation.NOT_WOKE;
					}
					else if (gameInfo[4] == "Informational")
					{
						newGame.isWoke = Recommendation.SOMEWHAT_WOKE;
					}
					else 
					{
						newGame.isWoke = Recommendation.WOKE;
					}
					newGame.Description = gameInfo[5];
					gameList.Add(newGame);
				}
			}
		}
	}
}
