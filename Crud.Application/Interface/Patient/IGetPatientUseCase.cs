using Crud.Domain.Interface.Patient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Crud.Application.Interface.Patient
{
    public interface IGetPatientUseCase
    {
        public bool GetPatient(Expression<Func<IPatient, bool>> expression);

    }
}
