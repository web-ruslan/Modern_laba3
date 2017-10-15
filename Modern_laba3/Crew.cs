using System;

namespace Modern_laba3
{
    [Serializable]
    public class Crew : Entity
    {
        public static int idCount;
        public string CarNumber { get; set; }
        public string DriverName { get; set; }

        public Crew()
        {
            Id = idCount++;
            Deleted = false;
        }

        public override string ToString()
        {
            return string.Format("Водій: {0} - номер авто: {1}", DriverName, CarNumber);
        }
    }
}
