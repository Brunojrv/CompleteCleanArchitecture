using Crud.Domain.Interface.Patient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud.Application.Interface.Patient
{
    public interface IUpdatePatientUseCase
    {
        public bool UpdatePatient(IPatient patient);

    }
}
