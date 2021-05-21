using HardwareStore.Domain.Entities;
using HardwareStore.Domain.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HardwareStore.Domain.Repositories.EntityFramework
{
    public class EFServiceitemsRepository : IServiceItemsRepository
    {

        private readonly AppDbContext context;
        public EFServiceitemsRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<Serviceitem> GetServiceitems()
        {
            return context.Serviceitems;
        }

        public Serviceitem GetServiceitemById(Guid id)
        {
            return context.Serviceitems.FirstOrDefault(x => x.Id == id);
        }

        public void SaveServiceitem(Serviceitem entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void DeleteServiceitem(Guid id)
        {
            context.Serviceitems.Remove(new Serviceitem() { Id = id });
            context.SaveChanges();
        }           
    }
}
