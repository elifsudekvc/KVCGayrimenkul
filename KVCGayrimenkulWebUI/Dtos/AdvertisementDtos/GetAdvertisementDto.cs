namespace KVCGayrimenkulWebUI.Dtos.AdvertisementDtos
{
	public class GetAdvertisementDto
	{
		public int AdvertisementID { get; set; }
		public string AdvertisementName { get; set; }
		public string Description { get; set; }
		public int SquareMeters { get; set; }
		public decimal Price { get; set; }
		public string ImageUrl { get; set; }
		public bool AdvertisementStatus { get; set; }
		public int CategoryID { get; set; }
	}
}
