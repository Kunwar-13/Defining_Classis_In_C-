using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    internal class Run
    {

        public void Logic()
        {
            UI ui = new UI(); 
            
            MemberOfSocialClub[] memberOfSocialClubs = new MemberOfSocialClub[5];


            for (int i = 0; i < memberOfSocialClubs.Length; i++) 
            {
                memberOfSocialClubs[i] = new MemberOfSocialClub();
                memberOfSocialClubs[i].SetAllData(((i * i * i * 8) - (i * i)), $"Hell{i}o", $"W{i}orld", $"{i}HelloWorld.{i}@gmail.com", new DateTime(2001 + i, 02, 14));
            }

            foreach (var memberOfSocialClub in memberOfSocialClubs) 
            {
                
                ui.Display($"Member's Name: {memberOfSocialClub.GetName()}");

                ui.Display($"Member's Age: {memberOfSocialClub.CalculateAge()}");

            }

        }

    }
}
