using System;
using System.Collections.Generic;
using System.Text;

// I Scott McFarland, 000778232, certify that this material is my original work. No other person's work has been used without due acknowledgement. I have not made my work available to anyone else.

namespace Problem4
{
    /// <summary>
    /// An auctioneer to run the auction
    /// </summary>
    public class Auctioneer : IObservable<Art>
    {
        /// <summary>
        /// Buyers present at the aution
        /// </summary>
        private List<IObserver<Art>> buyers;

        /// <summary>
        /// Art for sale
        /// </summary>
        private List<Art> allArt;

        /// <summary>
        /// Inform a particular buyer about a piece of art
        /// </summary>
        /// <param name="piece">The piece of art</param>
        /// <param name="buyer">The buyer</param>
        /// <returns>Whether the buyer bid on the art</returns>
        public bool ShowToBuyer(Art piece, IObserver<Art> buyer)
        {
            int numBids = piece.NumBids;
            buyer.OnNext(piece);
            return numBids != piece.NumBids;
        }

        /// <summary>
        /// Inform all buyers about a piece of art
        /// Run when art is added or bid on
        /// </summary>
        /// <param name="piece">The piece of art to inform buyers about</param>
        public void Update(Art piece)
        {
            // If this is a new piece of art, add it to the list
            if (!allArt.Contains(piece)) {
                allArt.Add(piece);
            }

            foreach (IObserver<Art> buyer in buyers.ToArray())
            {
                // If the buyer bid on the piece
                if (ShowToBuyer(piece, buyer))
                {
                    // If the buyer won the piece
                    if (piece.NumBids == 5)
                    {
                        // Remove the art and buyer from internal lists
                        allArt.Remove(piece);
                        buyer.OnCompleted();
                        buyers.Remove(buyer);

                        // We no longer have to worry about showing off this art
                        return;
                    }

                    // If the buyer didn't win the piece, end the current Update and start a new one
                    Update(piece);
                    return;
                }
            }
        }

        /// <summary>
        /// Add a buyer to the aution
        /// </summary>
        /// <param name="buyer">The buyer being added</param>
        /// <returns>A handle by which the buyer can unsubscribe</returns>
        public IDisposable Subscribe(IObserver<Art> buyer)
        {
            if (!buyers.Contains(buyer))
            {
                buyers.Add(buyer);
            }
            return new Unsubscriber<Art>(buyers, buyer);
        }

        /// <summary>
        /// Inform a buyer about all available art
        /// Used to catch up new subscribers
        /// </summary>
        /// <param name="buyer">The buyer to inform</param>
        public void CatchUp(IObserver<Art> buyer)
        {
            foreach (Art piece in allArt.ToArray())
            {
                // Update any piece the new buyer bids on
                if (ShowToBuyer(piece, buyer))
                {
                    Update(piece);
                }
            }
        }

        public Auctioneer()
        {
            buyers = new List<IObserver<Art>>();
            allArt = new List<Art>();
        }
    }
}
