using System;
using System.Collections.Generic;
using System.Text;

// I Scott McFarland, 000778232, certify that this material is my original work. No other person's work has been used without due acknowledgement. I have not made my work available to anyone else.

namespace Problem4
{
    internal class Unsubscriber<Art> : IDisposable
    {
        /// <summary>
        /// List of all buyers
        /// </summary>
        private List<IObserver<Art>> buyers;

        /// <summary>
        /// The buyer who can unsubscribe using this object
        /// </summary>
        private IObserver<Art> buyer;

        /// <summary>
        /// Unsubscribe from the auction
        /// </summary>
        public void Dispose()
        {
            if (buyers.Contains(buyer))
            {
                buyers.Remove(buyer);
            }
        }

        internal Unsubscriber(List<IObserver<Art>> buyers, IObserver<Art> buyer)
        {
            this.buyers = buyers;
            this.buyer = buyer;
        }
    }
}
