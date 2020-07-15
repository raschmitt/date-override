using System;
using System.Runtime.Serialization;

namespace DateOverride
{
    public static class DateOverride
    {
        /// <summary>
        /// Overrides a Date or DateTime property with a given date
        /// </summary>
        /// <param name="target">The object from witch the property will be set</param>
        /// <param name="fieldName">The name of the property to be set, as a string</param>
        /// <param name="date">The date to set</param>
        public static void SetDate<T>(this object target, string fieldName, T date) 
            where T : IComparable, IFormattable, ISerializable
        {
            target.GetType().GetProperty(fieldName)?.SetValue(target, date);
        }
    }
}