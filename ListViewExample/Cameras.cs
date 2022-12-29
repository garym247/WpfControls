using System.Collections.Generic;

namespace ListViewExample
{
    public class Cameras
    {
        private List<string> cameraList = new List<string>() 
        {
            "Camera_1",
            "Camera_2",
            "Camera_3",
            "Camera_4"
        };

        public List<string> CameraList 
        { 
            get
            {
                return cameraList;
            }
        }
    }
}