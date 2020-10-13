using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace TrackerLibrary.Models
{
    public class PrizeModel
    {
        /// <summary>
        /// The unique identifier for the prize
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Represents the entry field for place number.
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// Represents the entry field for place name.
        /// </summary>
        public string PlaceName { get; set; }

        /// <summary>
        /// Represents the prize awarded for placement.
        /// </summary>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// Represents the percentage awarded for placement.
        /// </summary>
        public double PrizePercentage { get; set; }

        public PrizeModel()
        {
            
        }

        public PrizeModel(string placeNumber, string placeName, string prizeAmount, string prizePercentage)
        {
            int.TryParse(placeNumber, out int placeNumberValue);
            PlaceNumber = placeNumberValue;
            
            PlaceName = placeName;

            decimal.TryParse(prizeAmount, out decimal prizeAmountValue);
            PrizeAmount = prizeAmountValue;

            double.TryParse(prizePercentage, out double prizePercentageValue);
            PrizePercentage = prizePercentageValue;
        }
    }
}
