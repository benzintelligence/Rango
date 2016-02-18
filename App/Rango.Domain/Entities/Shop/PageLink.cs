using Rango.Common.Resources.Errors;
using Rango.Common.Validation;
namespace Rango.Domain.Entities.Shop
{
    public class PageLink
    {

        #region Constructor
        public PageLink(string UrlPage, string NetworkName, int id = 0)
        {
            Validate(id, UrlPage, NetworkName);
        }
        #endregion

        #region properties
        public int Id { get; set; }

        public string UrlPage { get; set; }

        public string NetworkName { get; set; }
        #endregion

        #region Methods
        public void Validate(int Id, string UrlPage, string NetworkName)
        {

            if (Id > 0)
            {
                this.Id = Id;
            }

            if (AssertionConcern.AssertArgumentLength(UrlPage, 0, 255, Errors.UrlPageInvalid))
            {
                this.UrlPage = UrlPage;
            }

            if (AssertionConcern.AssertArgumentNotNull(NetworkName, Errors.NetworkNameInvalid))
            {
                this.NetworkName = NetworkName;
            }

        }
        #endregion

    }
}