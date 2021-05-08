using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entities
{
    public class Game : IEntity, IOrderEntity
    {
        public int GameId { get; set; }
        public string GameName { get; set; }
    }
}
