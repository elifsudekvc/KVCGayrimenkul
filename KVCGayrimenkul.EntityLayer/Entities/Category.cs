namespace KVCGayrimenkul.EntityLayer.Entities
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public bool CategoryStatus { get; set; }

        public List<Advertisement> Advertisements { get; set; }
    }
}
