using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ch6_WCFService.Web
{
    public class StartingHands
    {
        public string Nickname { get; set; }
        public string Notes { get; set; }
        public string Card1 { get; set; }
        public string Card2 { get; set; }

        public static List<StartingHands> GetHands()
        {
            List<StartingHands> hands = new List<StartingHands>();

            hands.Add(
                new StartingHands()
                {
                    Nickname = "Big Slick",
                    Notes = "Also referred to as Anna Kournikova.",
                    Card1 = "As",
                    Card2 = "Ks"
                });

            hands.Add(
            new StartingHands()
            {
                Nickname = "Pocket Rockets",
                Notes = "Also referred to as Bullets.",
                Card1 = "As",
                Card2 = "Ad"
            });

            hands.Add(
                new StartingHands()
                {
                    Nickname = "Blackjack",
                    Notes = "The casino game blackjack.",
                    Card1 = "As",
                    Card2 = "Js"
                });

            hands.Add(
                new StartingHands()
                {
                    Nickname = "Cowboys",
                    Notes = "Also referred to as King Kong",
                    Card1 = "Ks",
                    Card2 = "Kd"
                });

            hands.Add(
                new StartingHands()
                {
                    Nickname = "Doyle Brunson",
                    Notes = "Named after poker great Doyle Brunson",
                    Card1 = "Ts",
                    Card2 = "2s"
                });


            return hands;
        }
    }
}
