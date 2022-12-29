namespace ListViewExample
{
    public class Camera
    {
        public Camera(string manufacturer, string type, string model)
        {
            Manufacturer = manufacturer;
            Type = type;
            Model = model;
            
        }

        public string Manufacturer { get; set; }
        public string Type { get; set; }
        public string Model { get; set; }
    };
}