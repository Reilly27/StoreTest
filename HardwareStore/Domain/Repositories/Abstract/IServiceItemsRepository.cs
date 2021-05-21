using HardwareStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HardwareStore.Domain.Repositories.Abstract
{
  public  interface IServiceItemsRepository
    {
        IQueryable<Serviceitem> GetServiceitems();

        Serviceitem GetServiceitemById(Guid id);
        void SaveServiceitem(Serviceitem entity);
        void DeleteServiceitem(Guid id);
        
   }
}
