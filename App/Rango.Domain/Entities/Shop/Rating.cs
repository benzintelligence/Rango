using Rango.Common.Resources.Errors;
using Rango.Common.Validation;
namespace Rango.Domain.Entities.Rating
{
    public class Rating
    {

        #region Constructor
        public Rating(int Attendance, int QualityFood, int Delivery, string Commentary, int idRating = 0)
        {
            Validate(Attendance, QualityFood, Delivery, Commentary, idRating);
        } 
        #endregion

        #region properties
        public int IdRating { get; private set; }

        public int Attendance { get; private set; }

        public int QualityFood { get; private set; }

        public int Delivery { get; private set; }

        public string Commentary { get; private set; }
        #endregion

        #region Methods
        public void Validate(int Attendance, int QualityFood, int Delivery, string Commentary, int idRating)
        {

            if (idRating > 0)
            {
                this.IdRating = idRating;
            }

            if (AssertionConcern.AssertArgumentRangeNumeric(Attendance, 0,5, Errors.RangeNumeric))
            {
                this.Attendance = Attendance;
            }

            if (AssertionConcern.AssertArgumentRangeNumeric(QualityFood, 0,5, Errors.RangeNumeric))
            {
                this.QualityFood = QualityFood;
            }

            if (AssertionConcern.AssertArgumentRangeNumeric(Delivery, 0,5, Errors.RangeNumeric))
            {
                this.Delivery = Delivery;
            }

            if (AssertionConcern.AssertArgumentLength(Commentary, 0, 500, Errors.CommentaryInvalid))
            {
                this.Commentary = Commentary;
            }

        }
        #endregion

    }
}