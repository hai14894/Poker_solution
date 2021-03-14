using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerGame
{
    class Program
    {
        // create Cards class with 4 Suits
        public static List<string> Cards(string symbol)
        {
            List<string> cards = new List<string>();
            for (int i = 2; i < 11; i++)
            {
                cards.Add(i + " of " + symbol);
            }
            cards.Add("Jack" + " of " + symbol);
            cards.Add("Queen" + " of " + symbol);
            cards.Add("King" + " of " + symbol);
            cards.Add("Ace" + " of " + symbol);
            return cards;
        } //Cards function end
        public static void Main(string[] args)
        {
            //Create 52-card deck

            List<string> clubs = Cards("Club");
            List<string> diamonds = Cards("Diamond");
            List<string> hearts = Cards("Heart");
            List<string> spades = Cards("Spade");

            List<string> deck = clubs.Concat(diamonds).Concat(hearts).Concat(spades).ToList();
            //create BOTS




            Console.WriteLine("WELCOME TO TERMINAL POKER GAME ");





            string[] players = { "Bot 1", "BOT 2", "BOT 3", "BOT 4" };


            //getting card  from deck

            Random rand = new Random();



            var All_BOT_cards = new List<string>();


            foreach (string player in players)
            {

                int card1_index = rand.Next(deck.Count);
                string card1 = deck[card1_index];
                deck.Remove(card1);

                int card2_index = rand.Next(deck.Count);
                string card2 = deck[card2_index];
                deck.Remove(card2);

                int card3_index = rand.Next(deck.Count);
                string card3 = deck[card3_index];
                deck.Remove(card3);

                int card4_index = rand.Next(deck.Count);
                string card4 = deck[card4_index];
                deck.Remove(card4);

                int card5_index = rand.Next(deck.Count);
                string card5 = deck[card5_index];
                deck.Remove(card5);

                bool is_highcard, is_one_pair, is_two_pair, is_three_of_a_kind, is_straight, is_flush, is_full_house, is_four_of_a_kind, is_straight_flush;
                var BOT_cards = new List<string>();



                BOT_cards.Add(card1);
                BOT_cards.Add(card2);
                BOT_cards.Add(card3);
                BOT_cards.Add(card4);
                BOT_cards.Add(card5);



                All_BOT_cards.Add(card1);
                All_BOT_cards.Add(card2);
                All_BOT_cards.Add(card3);
                All_BOT_cards.Add(card4);
                All_BOT_cards.Add(card5);





                Console.WriteLine(">> {0} 's cards : ", player);

                BOT_cards.ForEach(i => Console.WriteLine(i));


                Console.WriteLine("========================");

            }

            Console.ReadLine();
        }


    }
}

