using System;
using System.Runtime.Serialization;

namespace DateOverrideTests
{
    public class TestEntity<T> where T : IComparable, IFormattable, ISerializable
    {
        public T Date { get; private set; }
    }
}