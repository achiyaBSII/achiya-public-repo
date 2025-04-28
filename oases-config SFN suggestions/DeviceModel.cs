using System.Runtime.Serialization;

namespace ConfigurationSuggestion
{
    public class DeviceModel
    {
        public EntityCategory Category { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public DateTime? YearOfManufacture { get; set; }
        public string? Description { get; set; }
        public string? Comment { get; set; }
        List<DataPoint> DataPoints { get; set; }
    }
}
