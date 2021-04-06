using System;
using System.Collections.Generic;
using System.Text;

// I Scott McFarland, 000778232, certify that this material is my original work. No other person's work has been used without due acknowledgement. I have not made my work available to anyone else.

namespace Problem4
{
    public class Buyer : IObserver<Art>
    {
        /// <summary>
        /// Handle for unsubscribing from the auction
        /// </summary>
        private IDisposable unsubscriber;

        /// <summary>
        /// The maximum this buyer can spend
        /// </summary>
        public int budget { get; set; }

        /// <summary>
        /// The art the buyer has purchased, if any
        /// </summary>
        public Art purchased { get; set; }

        /// <summary>
        /// The most recent art that the buyer bid on, used for setting `purchased`
        /// </summary>
        private Art recentBid { get; set; }



        /// <summary>
        /// Run if the auctioneer sends an error message
        /// Stubbed out, never occurs
        /// </summary>
        public virtual void OnError(Exception error)
        {
            // Stub
        }

        /// <summary>
        /// Run when the buyer wins a bid and is removed from the auction
        /// </summary>
        public virtual void OnCompleted()
        {
            purchased = recentBid;
        }

        /// <summary>
        /// Run whenever a piece of art is updated (added to the auction or bid on)
        /// 
        /// The default buyer wants to buy any available art for the minimum price, 
        /// and will voluntarily leave the auction if any piece of art becomes too
        /// expensive for their budget
        /// 
        /// Other buyer classes could inheret from this one and override this behaviour
        /// </summary>
        /// <param name="piece">The art for sale</param>
        public virtual void OnNext(Art piece)
        {
            if (budget > piece.Price)
            {
                // Record the bid if it was placed sucessfully
                if (piece.Bid(piece.Price + 1, this))
                {
                    recentBid = piece;
                }
            }
            else
            {
                Unsubscribe();
            }
        }

        /// <summary>
        /// Subscribe to an auctioneer's auction
        /// </summary>
        /// <param name="auctioneer">The auctioneer to subscribe to</param>
        public virtual void Subscribe(Auctioneer auctioneer)
        {
            unsubscriber = auctioneer.Subscribe(this);
            auctioneer.CatchUp(this);
        }

        /// <summary>
        /// Unsubscribe from the auction
        /// </summary>
        public virtual void Unsubscribe()
        {
            unsubscriber.Dispose();
        }

        public Buyer(int budget)
        {
            this.budget = budget;
        }
    }
}
