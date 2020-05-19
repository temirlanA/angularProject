using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using angularProject.Entities;
using angularProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace angularProject.Controllers
{
    [ApiController]
    public class GameController : ControllerBase
    {
        private GameContext context;
        public GameController(GameContext gameContext)
        {
            context = gameContext;
        }
        // GET: api/Game
        [HttpGet]
        [Route("[controller]/players")]
        public async Task<IActionResult> Get()
        {
            var PlayersModel = new List<PlayersModel>();
            var Players = await context.Player
                .ToListAsync();
            if(!Players.Any())
                return NotFound();
            Players.ForEach(player =>
            {
                PlayersModel.Add(new PlayersModel() {
                    Id = player.PlayerId,
                    firstName = player.FirstName, 
                    lastName = player.LastName 
                });
            });


            return Ok(PlayersModel);
        }



        [HttpGet]
        [Route("[controller]/players/{id}")]
        public async Task<PlayersModel> Get(Guid id)
        {
            var player = await context.Player.FirstOrDefaultAsync(x => x.PlayerId == id);
            return new PlayersModel()
            {
                Id = player.PlayerId,
                firstName = player.FirstName,
                lastName = player.LastName
            };
        }

        [HttpPost]
        [Route("[controller]/players")]
        public async Task<IActionResult> Post(PlayersModel player)
        {
            if (ModelState.IsValid)
            {
                context.Player
                    .Add(new Player()
                    {
                        FirstName = player.firstName,
                        LastName = player.lastName
                    });
                await context.SaveChangesAsync();
                return Ok(player);
            }
            return BadRequest(ModelState);
        }

        [HttpPut]
        [Route("[controller]/players")]
        public async Task<IActionResult> Put(PlayersModel player)
        {
            if (ModelState.IsValid)
            {
                context.Update(new Player()
                {
                    PlayerId = player.Id,
                    FirstName = player.firstName,
                    LastName = player.lastName
                });
                await context.SaveChangesAsync();
                return Ok(player);
            }
            return BadRequest(ModelState);
        }

        [HttpDelete]
        [Route("[controller]/players/{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            Player player = context.Player.FirstOrDefault(p => p.PlayerId == id);
            if (player != null)
            {
                context.Player.Remove(player);
                await context.SaveChangesAsync();
            }
            return Ok(player);
        }






        [HttpGet]
        [Route("[controller]/teams")]
        public IActionResult Teams()
        {
            var TeamsModel = new List<TeamsModel>();
            var Teams = context.Team
                .ToList();
            Teams.ForEach(team =>
            {
                var teamPlayers = context.TeamPlayers
                    .Where(teamP => teamP.TeamPlayersId == team.TeamPlayers)
                    .FirstOrDefault();
                TeamsModel.Add(new TeamsModel() 
                { 
                    name = team.TeamName, 
                    player1 = context.Player.Where(player => player.PlayerId == teamPlayers.Player1).FirstOrDefault().LastName,
                    player2 = context.Player.Where(player => player.PlayerId == teamPlayers.Player2).FirstOrDefault().LastName,
                    player3 = context.Player.Where(player => player.PlayerId == teamPlayers.Player3).FirstOrDefault().LastName,
                    player4 = context.Player.Where(player => player.PlayerId == teamPlayers.Player4).FirstOrDefault().LastName,
                    player5 = context.Player.Where(player => player.PlayerId == teamPlayers.Player5).FirstOrDefault().LastName,
                    player6 = context.Player.Where(player => player.PlayerId == teamPlayers.Player6).FirstOrDefault().LastName,
                    player7 = context.Player.Where(player => player.PlayerId == teamPlayers.Player7).FirstOrDefault().LastName,
                    player8 = context.Player.Where(player => player.PlayerId == teamPlayers.Player8).FirstOrDefault().LastName,
                    player9 = context.Player.Where(player => player.PlayerId == teamPlayers.Player9).FirstOrDefault().LastName
                });
            });


            return Ok(TeamsModel);
        }

        [HttpGet]
        [Route("[controller]/matchs")]
        public IActionResult Matchs()
        {
            var MatchsModel = new List<MatchsModel>();
            var Matchs = context.Match
                .ToList();
            Matchs.ForEach(match =>
            {
                MatchsModel.Add(new MatchsModel() 
                { 
                    name = match.MacthName,
                    teamA = context.Team.Where(team => team.TeamId == match.TeamA).FirstOrDefault().TeamName,
                    teamB = context.Team.Where(team => team.TeamId == match.TeamB).FirstOrDefault().TeamName,
                });
            });


            return Ok(MatchsModel);
        }


    }
}
