using Crud.Domain.Enum;
using Crud.Domain.Interface.Patient;
using Crud.Domain.ValueObject.Address;
using Crud.Domain.ValueObject.ContactInformation;

namespace Crud.Domain.AggregateRoot
{
    public class Patient : IPatient
    {
        public string Id { get; set; }

        public Address Address { get; set; }

        public ContactInformation ContactInformation { get; set; }

        public PatientLevel PatientLevel { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateUpdated { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string MedicalRecordNumber { get; set; }
    }
}
