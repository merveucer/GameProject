using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entities
{
    public class Campaign : IEntity, IOrderEntity
    {
        public int CampaignId { get; set; }
        public string CampaignName { get; set; }
        public string CampaignType { get; set; }
    }
}
