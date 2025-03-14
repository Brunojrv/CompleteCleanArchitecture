using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud.Application.Interface.Patient
{
    public interface IDeletePatientUseCase
    {
        public bool DeletePatient(string idPatient);

    }
}
