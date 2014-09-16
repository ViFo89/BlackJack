using System;
using System.Collections.Generic;


namespace BlackJack
{
    public class GameTable
    {
        private List<Player> players;
        private Dealer dealer;
        private Deck deck;


        public GameTable(List<Player> players, int numOfDecks)
        {
            this.players = players;
            Init(numOfDecks);
        }
        public GameTable(int numOfDecks)
        {
            players = new List<Player>();
            
            Init(numOfDecks);
        }
        private void Init(int numOfDecks)
        {
            dealer = new Dealer();
            deck = new Deck(numOfDecks);
            deck.ShuffleCards();
        }

        public void AddPlayer(Player player)
        {
            players.Add(player);
        }

        public void StartGame()
        {
            bool isRunning = true;

            while (isRunning)
            {


                DealCards();
                AskPlayersForAction();
                AskDealerForAction();

                isRunning = false;
            }
        }

        private void AskDealerForAction()
        {
            string answer = dealer.AskForAction();
        }

        private void AskPlayersForAction()
        {
            foreach (var player in players)
            {
                string answer = player.AskForAction();
            }
        }

        private void DealCards()
        {
            Card card;
            foreach (var player in players)
            {
                card = deck.DealCard();
                player.GiveCard(card);
                Console.WriteLine("Player " + player.Name + " got " + card.CardColor+ " " + card.CardValue);
            }
            card = deck.DealCard();
            dealer.GiveCard(card);
            Console.WriteLine("Dealer got " + card.CardColor + " " + card.CardValue);
        }
    }
}
