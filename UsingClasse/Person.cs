using System;
using System.Collections.Generic;
using System.Text;

namespace UsingClasse
{
	internal class Person
	{
		public string Name;
		public int Cash;

		/// <summary>
		/// Writes Name and amount to console
		/// </summary>
		public void WriteMyInfo()
		{
			Console.WriteLine(Name + " has " + Cash + " bucks ");
		}

		/// <summary>
		/// Give cash and removed from wallet (or prints to the console if there is not enough cash)
		/// </summary>
		/// <param name="amount">Amount of Cash to give</param>
		/// <returns>The amount of cash removed from the wallet ( if the amount is invalid)</returns>
		public int GiveCash(int amount)
		{
			if (amount <= 0)
			{
				Console.WriteLine(Name + " say: " + amount + " is not a valid amount");
				return 0;
			}
			if (amount > Cash)
			{
				Console.WriteLine(Name + " say: " + " I do not have that amount to give " + amount);
				return 0;
			}
			Cash -= amount;
			return amount;
		}

		/// <summary>
		/// Recieving cash and adding it to the wallet ( or printing to the console the amount is invalid)
		/// </summary>
		/// <param name="amount">Amount of cash given.	</param>
		public void ReciveCash(int amount)
		{
			if (amount <= 0)
			{
				Console.WriteLine(Name + " say: " + amount + " is not an amount I will take ");
			}
			else
			{
				Cash += amount;
			}
		}
	}
}