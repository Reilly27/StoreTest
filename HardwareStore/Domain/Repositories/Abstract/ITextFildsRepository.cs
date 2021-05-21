using HardwareStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HardwareStore.Domain.Repositories.Abstract
{
  public interface ITextFildsRepository
    {
        IQueryable<TextField> GetTextFields();

        TextField GetTextFieldById(Guid id);
        TextField GetTextFieldByCodeWord(string codeWord);
        void SeveTextField(TextField entity);
        void DeleteTextField(Guid id);
    }
}
