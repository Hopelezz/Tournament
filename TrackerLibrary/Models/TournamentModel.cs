using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models
{
    public class TournamentModel
    {
        /// <summary>
        /// Represents the name of the Tournament.
        /// </summary>
        public string TournamentName { get; set; }

        /// <summary>
        /// Represents the Entry Fee.
        /// </summary>
        public decimal EntryFee { get; set; }

        /// <summary>
        /// Represents Team being entered for list.
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();

        /// <summary>
        /// Represents the list of Prizes.
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();

        /// <summary>
        /// Represents the round selected from the list.
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}
