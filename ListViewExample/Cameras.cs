using System.Collections.Generic;

namespace ListViewExample
{
    public class Cameras
    {
        private List<Camera> cameraList = new List<Camera>() 
        {
            new Camera("Lumix", "Compact", "L001"),
            new Camera("Lumix", "Compact", "L002"),
            new Camera("Lumix", "DSLR", "L003"),
            new Camera("Canon", "DSLR", "C001"),
            new Camera("Canon", "Bridge", "C002"),
            new Camera("Nikon", "Compact", "N001")
        };

        public List<Camera> CameraList 
        { 
            get
            {
                return cameraList;
            }
        }
    }
}