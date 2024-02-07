namespace ContactListAPI.Server.Models
{
	public class Customer
	{
		public int CustomerID { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public DateTime DateOfBirth { get; set; }
		
		// prefer email, phone, mail as main communication 
		public string ContactPreference { get; set; }

		public ICollection<Phone> PhoneNumbers { get; set; }

		public ICollection<Address> Addresses { get; set; }
		

	}
}
