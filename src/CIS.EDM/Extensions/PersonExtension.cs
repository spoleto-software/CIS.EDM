using CIS.EDM.Models;

namespace CIS.EDM.Extensions
{
    public static class PersonExtension
    {
        /// <summary>
        /// Фамилия, имя, отчество полностью.
        /// </summary>
        public static string GetFullName(this Person person)
        {
            return $"{person.Surname} {person.FirstName} {person.Patronymic}";
        }
    }
}
