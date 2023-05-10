using DogFactsSamples.Data;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DogFactsSamples
{
    public partial class App : Application
    {

        static FactDataDatabase database;

        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        public static FactDataDatabase Database
        {
            get
            {
                if(database == null)
                {
                    database = new FactDataDatabase();
                    prefillDatabase();
                }
                return database;
            }
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

        static void prefillDatabase()
        {
            database.ClearAllAsync();
            List<JeffFactData> all = new List<JeffFactData>();
            all.Add(new JeffFactData() { TheFact = "Jeff's favorite band is The Beatles.", ShortFact = "Favorite Band", ImageSource = "thebeatles.jpg" });
            all.Add(new JeffFactData() { TheFact = "Jeff's favorite aircraft is the B-1B Lancer.", ShortFact = "Favorite Aircraft", ImageSource = "b1blancer.jpg" });
            all.Add(new JeffFactData() { TheFact = "Jeff uses Fusion360 to create 3D models and prints them on the ender 3 pro.", ShortFact = "3D Modeling/Printing", ImageSource = "ender3pro.jpg" });
            all.Add(new JeffFactData() { TheFact = "Jeff started learning to play the Guitar when he was 10 years old.", ShortFact = "Learning Guitar", ImageSource = "guitar.jpg" });
            all.Add(new JeffFactData() { TheFact = "Jeff shares a birthday with Payton Manning.", ShortFact = "Shares Birthday", ImageSource = "paytonmanning.jpg" });
            database.InsertList(all);
        }
    }
}
