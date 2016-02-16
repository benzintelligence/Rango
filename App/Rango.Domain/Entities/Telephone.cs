using Rango.Common.Resources.Errors;
using Rango.Common.Validation;

namespace Rango.Domain.Entities
{
    public class Telephone
    {
        #region Consctrutor
        public Telephone(string ddi, string codeState, string number, int id = 0)
        {
            Validate(ddi, codeState, number, id);
        } 
        #endregion

        #region Properties
        public int Id { get; private set; }

        public string DDI { get; private set; }

        public string CodeState { get; private set; }

        public string Number { get; private set; }
        #endregion

        #region Methods
        public void Validate(string ddi, string codeState, string number, int id)
        {
            if (id > 0)
            {
                Id = id;
            }

            if (AssertionConcern.AssertArgumentLength(ddi, 1, 4, Errors.DDITelephone))
            {
                DDI = ddi;
            }

            if (AssertionConcern.AssertArgumentLength(codeState, 3, Errors.CodeStateTelephone))
            {
                CodeState = codeState;
            }

            if (AssertionConcern.AssertArgumentLength(number, 5, 9, Errors.NumberTelephone))
            {
                Number = number;
            }
        }
        #endregion
    }
}