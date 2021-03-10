using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class GameManager : IGameService
    {
        public void Sale(List<IEntity> entities)
        {
            Console.WriteLine("Satış başarıyla gerçekleştirildi.");
        }
    }
}
