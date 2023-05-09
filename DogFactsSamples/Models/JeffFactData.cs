using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace DogFactsSamples
{
    public class JeffFactData    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; } 
        public string TheFact { get; set; }
        public string ShortFact { get; set; }
        public string ImageSource { get; set; }
        
    }
}
