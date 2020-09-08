using System.Collections.Generic;
using HelpApi.Models;

namespace HelpApi.Data
{
    public interface IHelpApiRepo
    {
        IEnumerable<Command> GetAppCommands();
        Command GetCommandById(int id);
    }
}