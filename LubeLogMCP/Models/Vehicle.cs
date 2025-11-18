namespace LubeLogMCP.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string LicensePlate { get; set; }
        public List<ExtraField> ExtraFields { get; set; } = new List<ExtraField>();
        public string VehicleIdentifier { get; set; } = "LicensePlate";
        public string Identifier { get {
                if (VehicleIdentifier == "LicensePlate")
                {
                    return LicensePlate;
                }
                else
                {
                    if (ExtraFields.Any(x => x.Name == VehicleIdentifier))
                    {
                        return ExtraFields?.FirstOrDefault(x => x.Name == VehicleIdentifier)?.Value;
                    }
                    else
                    {
                        return "N/A";
                    }
                }
            } }
    }
    public class ExtraField
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }
}
