using HardwareStore.Domain.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HardwareStore.Domain
{
    public class DataManager
    {
        public ITextFildsRepository TextFilds { get; set; }
        public IServiceItemsRepository ServiceItems { get; set; }      

        public DataManager( ITextFildsRepository textFildsRepository, IServiceItemsRepository serviceItemsRepository)
        {
            TextFilds = textFildsRepository;
            ServiceItems = serviceItemsRepository;
            
        }
    }
}
