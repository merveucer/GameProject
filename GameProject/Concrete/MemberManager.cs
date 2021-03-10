using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class MemberManager : IMemberService
    {
        private IMemberCheckService _memberCheckService;

        public MemberManager(IMemberCheckService memberCheckService)
        {
            _memberCheckService = memberCheckService;
        }

        public void Add(Member member)
        {
            if (_memberCheckService.CheckIfRealPerson(member))
            {
                Console.WriteLine(member.FirstName + " isimli yeni üye eklendi.");
            }
            else
            {
                Console.WriteLine("Lütfen bilgilerinizi doğru giriniz.");
            }
        }

        public void Delete(Member member)
        {
            Console.WriteLine(member.FirstName + " isimli üye silindi.");

        }

        public void Update(Member member)
        {
            Console.WriteLine(member.FirstName + " isimli üye güncellendi.");

        }
    }
}