using GameProject.Abstract;
using GameProject.Adapters;
using GameProject.Concrete;
using GameProject.Entities;
using System;
using System.Collections.Generic;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Member member = new Member
            {
                MemberId = 1,
                FirstName = "Merve",
                LastName = "Merve",
                DateOfBirth = new DateTime(1900, 1, 1),
                NationalityId = "11111111111"
            };

            Campaign campaign = new Campaign
            {
                CampaignId = 1,
                CampaignName = "Kampanya 1",
                CampaignType = "Bahar"
            };

            Game game = new Game
            {
                GameId = 1,
                GameName = "Oyun 1"
            };

            List<IEntity> salesList = new List<IEntity> { member, game, campaign };
            List<IEntity> salesList2 = new List<IEntity> { member, game };

            //MemberManager memberManager = new MemberManager(new MemberCheckManager()); // Testing
            MemberManager memberManager = new MemberManager(new MernisServiceAdapter()); // Real Checking
            memberManager.Add(new Member
            {
                MemberId = 2,
                FirstName = "Üçer",
                LastName = "Üçer",
                DateOfBirth = new DateTime(1900, 1, 1),
                NationalityId = "11111111111"
            });
            memberManager.Delete(member);
            memberManager.Update(member);

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(new Campaign
            {
                CampaignId = 2,
                CampaignName = "Kampanya 2",
                CampaignType = "Yaz"
            });
            campaignManager.Delete(campaign);
            campaignManager.Update(campaign);

            GameManager gameManager = new GameManager();
            gameManager.Sale(salesList);
        }
    }
}
