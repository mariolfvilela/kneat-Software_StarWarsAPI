using System;
using System.Collections.Generic;
using Star_Wars.Application.ViewModels;
using StarWars.Domain.Common;

namespace Star_Wars.Application.Interfaces
{
    public interface IAppServicoBase<TEntityDomain, TEntityViewModel>
        where TEntityDomain : EntityBase
        where TEntityViewModel : ViewModelBase
    {
        void Register(TEntityViewModel baseViewModel);
        IEnumerable<TEntityViewModel> GetAll();
        TEntityViewModel GetById(Guid id);
        void Update(TEntityViewModel baseViewModel);
        void Remove(Guid id);
        IList<TEntityViewModel> GetAllHistory(Guid id);
    }
}
