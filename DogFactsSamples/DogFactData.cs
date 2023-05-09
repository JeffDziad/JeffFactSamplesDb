using System;
using System.Collections.Generic;

namespace DogFactsSamples
{
    public class DogFactData
    {
        public DogFactData()
        {
        }
        public static IEnumerable<DogFactData> All { private set; get; }
        public string TheFact { get; set; }
        public string ShortFact { get; set; }
        static DogFactData()
        {
            List<DogFactData> all = new List<DogFactData>();
            all.Add(new DogFactData() { TheFact = "Dogs noses are wet to help absorb scent chemicals", ShortFact = "Dog Noses" });
            all.Add(new DogFactData() { TheFact = "Three dogs survived the Titanic sinking", ShortFact = "Titanic" });
            all.Add(new DogFactData() { TheFact = "A Bloodhound’s sense of smell can be used as evidence in court", ShortFact = "Legal not Beagle" });
            all.Add(new DogFactData() { TheFact = "Basenji dogs don’t bark, they yodel", ShortFact = "Yodelling pups" });
            all.Add(new DogFactData() { TheFact = "The Ewoks in Star Wars were based on a dog", ShortFact = "Star Wars" });
            All = all;

        }
    }
}