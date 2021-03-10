using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface IMemberService
    {
        void Add(Member member);
        void Delete(Member member);
        void Update(Member member);
    }
}
