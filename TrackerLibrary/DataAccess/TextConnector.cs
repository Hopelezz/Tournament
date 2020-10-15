using System;
using System.Collections.Generic;
using System.Text;
using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextHelpers;
using System.Linq;

namespace TrackerLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        private const string PrizesFile = "PrizeModels.cvs";
        private const string PeopleFile = "PersonModels.cvs";
        public PersonModel CreatePerson(PersonModel model)
        {
            //Load the text file and convert the text to list<PeopleModel>
            List<PersonModel> people = PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();

            //finds the max ID
            int currentId = 1;

            if (people.Count > 0)
            {
                currentId = people.OrderByDescending(x => x.Id).First().Id + 1;
            }

            //sets the model.Id to have this--> currentId = people.OrderByDescending(x => x.Id).First().Id + 1;
            model.Id = currentId;

            //Add the new record with the new ID (max + 1)
            people.Add(model);

            //convert the prizes to List<string>
            //save the list<string> to the text file
            people.SaveToPeopleFile(PeopleFile);

            return model;
        }

        //TODO + Wire up the CreatePrize for text files
        /// <summary>
        /// Saves a new prize to the text database
        /// </summary>
        /// <param name="model">The prize information</param>
        /// <returns>The prizer information, including the unique identifier.</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            //load the text file and convert the text to list<PrizeModel>
            List<PrizeModel> prizes = PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();

            //finds the max ID
            int currentId = 1;

            if (prizes.Count > 0)
            {
                currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;
            }

            //sets the model.Id to have this--> currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;
            model.Id = currentId;
           
            //add the new record with the new ID (max + 1)
            prizes.Add(model);

            //convert the prizes to List<string>
            //save the list<string> to the text file
            prizes.SaveToPrizeFile(PrizesFile);

            return model;
        }

        public List<PersonModel> GetPerson_All()
        {
            return PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();
        }
    }
}
