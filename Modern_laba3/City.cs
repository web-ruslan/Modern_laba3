using System;

namespace Modern_laba3
{
    [Serializable]
    public class City : Entity
    {
        public static int idCount;
        public string Name { get; set; }
        public City()
        {
            Id = idCount++;
            Deleted = false;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}