using System;

// I Scott McFarland, 000778232, certify that this material is my original work. No other person's work has been used without due acknowledgement. I have not made my work available to anyone else.

namespace Problem4
{
    /// <summary>
    /// Art for sale at the aution
    /// </summary>
    public class Art
    {
        /// <summary>
        /// The year the art was created
        /// </summary>
        public int Year { get; set; }

        /// <summary>
        /// The starting price for the aution
        /// </summary>
        public int Price { get; set; }

        /// <summary>
        /// Number of bids that have been placed on this piece of artwork
        /// </summary>
        public int NumBids { get; set; }

        /// <summary>
        /// The current highest bidder on the art
        /// </summary>
        public IObserver<Art> HighBidder { get; set; }

        /// <summary>
        /// Place a bid on the object
        /// </summary>
        /// <param name="price">The new price of the art</param>
        /// <param name="bidder">The buyer placing the bid</param>
        /// <returns>Whether the bid was sucessfully placed</returns>
        public bool Bid(int price, IObserver<Art> bidder)
        {
            if (price <= this.Price)
            {
                throw new ArgumentException("New price must be greater than current price");
            }

            // Fail to place additional bids after 5 or if the current winning buyer
            // is trying to bid again
            if (this.NumBids == 5 || this.HighBidder == bidder)
            {
                return false;
            }

            this.Price = price;
            this.NumBids++;
            this.HighBidder = bidder;

            return true;
        }

        public Art(int year, int price)
        {
            this.Year = year;
            this.Price = price;
            this.NumBids = 0;
            this.HighBidder = null;
        }
    }
}
