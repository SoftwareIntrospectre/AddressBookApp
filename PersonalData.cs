using System;
using System.Drawing;

namespace AddressBookApp
{

	class PersonalData
	{
		string Prefix { get; set; }
		string FirstName { get; set; }
		string MiddleName { get; set; }
		string LastName { get; set; }
		string Suffix { get; set; }

		string NickName { get; set; }

		DateTime BirthDate { get; set; }

		int Age
		{
			get
			{
				DateTime.Now - BirthDate;
			}

			set {; }
		}

		Enum HealthStatus
		{
			Alive,
			Deceased,
			Unknown
		};

		Enum Sex
		{
			Male,
			Female,
			Non-Binary,
			Unspecified
		};
	}
}