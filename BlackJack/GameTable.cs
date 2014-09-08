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
        }

        public void AddPlayer(Player player)
        {
            players.Add(player);
        }

        public void StartGame()
        {
            bool isRunning = players.Count >= 0;

            while (isRunning)
            {
                DealCards();
                AskPlayers();
                AskDealer();

                isRunning = false;
            }
        }

        private void AskDealer()
        {
            string answer = dealer.askForAction();
        }

        private void AskPlayers()
        {
            
        }

        private void DealCards()
        {
            Card card;
            foreach (var player in players)
            {
                card = deck.DealCard();
                player.GiveCard(card);
                Console.WriteLine("Player "+player.Name + " got " + card.cardValue);
            }
            card = deck.DealCard();
            dealer.GiveCard(card);
            Console.WriteLine("Dealer got " + card.cardValue);
        }
    }
}
