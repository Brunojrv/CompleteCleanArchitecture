using Crud.Domain.Enum;

namespace Crud.Domain.Interface.Patient
{
    public interface IPatient
    {
        public PatientLevel PatientLevel { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateUpdated { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string MedicalRecordNumber { get; set; }
    }
}
