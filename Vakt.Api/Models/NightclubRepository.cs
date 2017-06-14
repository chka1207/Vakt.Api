using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vakt.Api.Models
{
   public interface INightclubRepository
    {
        IEnumerable<Nightclub> GetAll();
    }

    public class InMemoryNightClubRepository : INightclubRepository
    {
        private List<Nightclub> nightclubs;

        public InMemoryNightClubRepository()
        {
            nightclubs = new List<Nightclub>
            {
                new Nightclub {NightclubName="Hogges", NightclubAdress="Storgatan", NightclubCity="Hudiksvall", NightclubPhoneNumber="0650-12345", OwnerFirstName="Hogge", OwnerLastName="Strandell", OwnerPhoneNumber="0650-12345"},
                new Nightclub {NightclubName="Olearys", NightclubAdress="Storgatan", NightclubCity="Hudiksvall", NightclubPhoneNumber="0650-12345", OwnerFirstName="Elvan", OwnerLastName="Anon", OwnerPhoneNumber="0650-12345"},
                new Nightclub {NightclubName="Sigges", NightclubAdress="Hamnplan 1", NightclubCity="Hudiksvall", NightclubPhoneNumber="0650-12345", OwnerFirstName="Sigge", OwnerLastName="Wassberg", OwnerPhoneNumber="0650-12345"},
            };
        }

        public IEnumerable<Nightclub> GetAll()
        {
            return nightclubs;
        }
    }
}
