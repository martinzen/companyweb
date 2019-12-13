using System;
using System.Collections.Generic;

namespace Venkant.Models
{
    public class MockClientRepository //: IClientsRepository
    {
      //  private List<Clients> _clientsList;

        // dependcing injection and unit testing that why we use IclinetsRepository -Change is much isieare as welll
        /*
        public MockClientRepository() {
            _clientsList = new List<Clients>()
            {
                new Clients(){ Id = 1, Name = "Martin", Email="martin.zivkovik@gmail.com", Model="MacBook Pro", Problem="Broken Screen", Fix = "Replaced Screen" }

            };
        }

        public Clients GetClient(int Id)
        {
            throw new NotImplementedException();
        }
        */
      
    }
}
