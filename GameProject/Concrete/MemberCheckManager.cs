using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class MemberCheckManager : IMemberCheckService
    {
        public bool CheckIfRealPerson(Member member)
        {
            return false;
        }
    }
}
