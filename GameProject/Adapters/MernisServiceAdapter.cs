using GameProject.Abstract;
using GameProject.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Adapters
{
    public class MernisServiceAdapter : IMemberCheckService
    {
        public bool CheckIfRealPerson(Member member)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            var result = client.TCKimlikNoDogrulaAsync(Convert.ToInt64(member.NationalityId), member.FirstName, member.LastName, member.DateOfBirth.Year).Result;

            return result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
