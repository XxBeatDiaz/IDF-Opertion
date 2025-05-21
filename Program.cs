using IDFOpertion.Models;

namespace IDFOpertion
{
    class Program
    {
        static void Main(string[] args)
        {
            List<F16FighterJet> fighterJets = new List<F16FighterJet>()
            {
                new F16FighterJet(),
                new F16FighterJet(),
                new F16FighterJet(),
                new F16FighterJet()
            };

            List<Artillery> artilleries = new List<Artillery>()
            {
                new Artillery(),
                new Artillery(),
                new Artillery(),
                new Artillery()
            };

            List<Hermes460Drone> hermes460Drones = new List<Hermes460Drone>()
            {
                new Hermes460Drone(),
                new Hermes460Drone(),
                new Hermes460Drone(),
                new Hermes460Drone()
            };

            List <Terrorist> terrorists = new List<Terrorist>()
            {
                new Terrorist("avi", 3, "Alive",["a","b"]),
                new Terrorist("yosi", 1, "Alive",["a","b"]),
                new Terrorist("yoni", 4, "Alive",["a","b"]),
                new Terrorist("tamar", 1, "Alive",["a","b"]),
                new Terrorist("malka", 2, "Alive",["a","b"])
            };

            IDF idf = new IDF(2002, "avi", [artilleries, fighterJets, hermes460Drones]);


        }
    }
}