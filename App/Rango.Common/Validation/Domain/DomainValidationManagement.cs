using System.Collections.Generic;
using System.Web;

namespace Rango.Common.Validation.Domain
{
    public class DomainValidationManagement
    {
        public static bool HasErrors
        {
            get { return HttpContext.Current.Items["DomainValidation"] != null; }
        }

        public static void Add(DomainValidation newDomainValidation)
        {
            if (HttpContext.Current.Items["DomainValidation"] == null)
            {
                HttpContext.Current.Items["DomainValidation"] = new List<DomainValidation>();
            }

            (HttpContext.Current.Items as List<DomainValidation>).Add(newDomainValidation);
        }

        public static List<DomainValidation> GetAll()
        {
            return (List<DomainValidation>)HttpContext.Current.Items["DomainValidation"];
        }
    }
}