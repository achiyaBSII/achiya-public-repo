namespace ConfigurationSuggestion
{
    public enum DataType
    {
        AnalogMeasurement,
        DigitalMeasurement
    }

    public class ValueBoundaries
    {
        public double Min { get; set; }
        public double Max { get; set; }
    }

    public class DataPoint
    {
        public uint? Index { get; set; }
        public string? Name { get; set; }
        public DataType Type { get; set; }
        public QuantityName? Unit { get; set; }
        public ValueBoundaries? Limitations { get; set; }
    }
}