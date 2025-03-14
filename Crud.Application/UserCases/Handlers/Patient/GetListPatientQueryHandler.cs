using Crud.Application.Interface.Patient;
using Crud.Domain.Interface.Patient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Crud.Application.UserCases.Handlers
{
    public class GetListPatientQueryHandler : IGetListPatientUseCase
    {
        public List<IPatient> GetListPatient(Expression<Func<IPatient, bool>> expression)
        {
            throw new NotImplementedException();
        }
    }
}
