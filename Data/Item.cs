
using System.Text.Json.Serialization;

namespace Bike_Service_IMS.Data
{
    public class Item
    {
        [JsonIgnore]
        private static int nextId = 1;
        public int Id
        { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public DateTime AddedDate { get; set; }
        public string AddedBy { get; set; }
        public double PurchasePrice { get; set; }
        public double SellingPrice { get; set; }
        public Item()
        {
            Id = nextId++;
        }
    }

}
