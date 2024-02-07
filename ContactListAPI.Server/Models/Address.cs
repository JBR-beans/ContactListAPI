namespace ContactListAPI.Server.Models
{
	public class Address
	{
		public int ResidenceID { get; set; }
		public string Residence { get; set; }

		public int BillingAddressID { get; set; }
		public string BillingAddress { get; set; }

		public int ShippingAddressID { get; set; }
		public string ShippingAddress { get; set; }


	}
}
