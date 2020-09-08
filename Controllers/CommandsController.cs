using System.Collections.Generic;
using HelpApi.Data;
using HelpApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace HelpApi.Controllers
{
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly IHelpApiRepo _repository;

        public CommandsController(IHelpApiRepo repository)
        {
            _repository = repository;
        }
        //private readonly MockHelpApiRepo _repository = new MockHelpApiRepo();
        //GET api/commands
        [HttpGet]
        public ActionResult <IEnumerable<Command>> GetAllCommands()
        {
            var commandItems = _repository.GetAppCommands();

            return Ok(commandItems);
        }

        //GET api/commands/5
        [HttpGet("{id}")]
        public ActionResult <Command> GetCommandById(int id)
        {
            var commandItem = _repository.GetCommandById(id);
            return Ok(commandItem);
        }
    }
}