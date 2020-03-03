using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DotNetCore.Results;
using Star_Wars.Application.ViewModels;
using StarWars.Domain.Common;

namespace Star_Wars.Application.Interfaces
{
    public interface IAppServicoBase<TEntityDomain, TEntityViewModel>
        where TEntityDomain : EntityBase
        where TEntityViewModel : ViewModelBase
    {
        Task<IDataResult<int>> AddAsync(TEntityViewModel entityViewModel);
        Task<IResult> RemoveByIdAsync(int id);
        Task<IResult> RemoveAsync(TEntityViewModel entityViewModel);
        Task<TEntityViewModel> UpdateAsync(TEntityViewModel entityViewModel);
        Task<TEntityViewModel> GetByIdAsync(int id);
        Task<IEnumerable<TEntityViewModel>> ListAsync();
    }
}
