using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class OrderManager : IOrderService
    {
        public void Sale(List<IOrderEntity> orderEntities)
        {
            Console.WriteLine("Satış başarıyla gerçekleştirildi.");
        }
    }
}
