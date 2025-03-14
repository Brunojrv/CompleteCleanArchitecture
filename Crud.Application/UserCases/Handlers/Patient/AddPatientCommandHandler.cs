using Crud.Application.Interface.Patient;
using Crud.Domain.Interface.Patient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud.Application.UserCases.Handlers
{
    public class AddPatientCommandHandler : IAddPatientUseCase
    {
        public bool AddPatient(IPatient patient)
        {
            throw new NotImplementedException();
        }
    }
}
