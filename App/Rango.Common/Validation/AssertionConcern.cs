using System;
using System.Text.RegularExpressions;
using Rango.Common.Validation.Domain;
using System.Collections;
using System.Collections.Generic;

namespace Rango.Common.Validation
{
    public class AssertionConcern
    {
        #region Métodos Utilizados
        public static bool AssertArgumentEmpty(string stringValue, string message)
        {
            if (stringValue == null || stringValue.Trim().Length == 0)
            {
                DomainValidationManagement.Add(new DomainValidation(message));
                return false;
            }

            return true;
        }

        public static bool AssertArgumentNotEquals(object object1, object object2, string message)
        {
            if (!object1.Equals(object2))
            {
                DomainValidationManagement.Add(new DomainValidation(message));
                return false;
            }

            return true;
        }

        public static bool AssertArgumentLength(string stringValue, int minimum, int maximum, string message)
        {
            if (AssertArgumentEmpty(stringValue, message))
            {
                DomainValidationManagement.Add(new DomainValidation(message));
                return false;
            }

            int length = stringValue.Trim().Length;
            if (length < minimum || length > maximum)
            {
                DomainValidationManagement.Add(new DomainValidation(message));
                return false;
            }

            return true;
        }

        public static bool AssertArgumentNotNull(object object1, string message)
        {
            if (object1 == null)
            {
                DomainValidationManagement.Add(new DomainValidation(message));
                return false;
            }

            return true;
        }

        public static bool AssertArgumentContainsElement<T>(object list, string message)
        {
            if (list == null || !(list is IEnumerable) || ((List<T>)list).Count == 0)
            {
                DomainValidationManagement.Add(new DomainValidation(message));
                return false;
            }

            return true;
        }

        public static bool AssertArgumentLength(string stringValue, int maximum, string message)
        {
            int length = stringValue.Trim().Length;
            if (length > maximum)
            {
                DomainValidationManagement.Add(new DomainValidation(message));
                return false;
            }

            return true;
        }

        public static bool AssertArgumentGreaterThanZero(int value, string message)
        {
            if (value <= 0)
            {
                DomainValidationManagement.Add(new DomainValidation(message));
                return false;
            }

            return true;
        }

        public static bool AssertArgumentRangeNumeric(int value, int min, int max, string message)
        {
            if (value < min || value > max)
            {
                DomainValidationManagement.Add(new DomainValidation(message));
                return false;
            }

            return true;
        }

        #endregion


        #region Excluir
        //TODO: Excluir métodos
        public static void AssertArgumentFalse(bool boolValue, string message)
        {
            if (boolValue)
            {
                throw new InvalidOperationException(message);
            }
        }

        
        public static void AssertArgumentMatches(string pattern, string stringValue, string message)
        {
            Regex regex = new Regex(pattern);

            if (!regex.IsMatch(stringValue))
            {
                throw new InvalidOperationException(message);
            }
        }

        public static void AssertArgumentRange(double value, double minimum, double maximum, string message)
        {
            if (value < minimum || value > maximum)
            {
                throw new InvalidOperationException(message);
            }
        }

        public static void AssertArgumentRange(float value, float minimum, float maximum, string message)
        {
            if (value < minimum || value > maximum)
            {
                throw new InvalidOperationException(message);
            }
        } 
        #endregion
    }
}