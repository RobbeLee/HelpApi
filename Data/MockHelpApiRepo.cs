using System.Collections.Generic;
using HelpApi.Models;

namespace HelpApi.Data
{
    public class MockHelpApiRepo : IHelpApiRepo
    {
        public IEnumerable<Command> GetAppCommands()
        {
            var commands = new List<Command>
            {
                new Command{Id=0, HowTo="boil an egg", Line="Boil water", Platform="kettle and pan"},
                new Command{Id=0, HowTo="cut bread", Line="Get a knife", Platform="knife and chopping board"},
                new Command{Id=0, HowTo="make cup of tea", Line="place teabag in cup", Platform="kettle and cup"}
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command{Id=0, HowTo="boil an egg", Line="Boil water", Platform="kettle and pan"};
        }
    }
}