using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface IOrderService
    {
        void Sale(List<IOrderEntity> orderEntities);
    }
}
