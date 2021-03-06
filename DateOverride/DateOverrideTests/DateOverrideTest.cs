using System;
using DateOverride;
using FluentAssertions;
using Xunit;

namespace DateOverrideTests
{
    public class UnitTest1
    {
        [Fact]
        public void Should_set_DateTime()
        {
            //Arrange
            var sut = new TestEntity<DateTime>();

            var today = DateTime.Now;
            var tomorrow = DateTime.Now.AddDays(1);
            
            //Act
            sut.SetDate(nameof(sut.Date), tomorrow);
            
            //Assert
            sut.Date.Should().BeAfter(today);
        }
        
        [Fact]
        public void Should_set_DateTimeOffset()
        {
            //Arrange
            var sut = new TestEntity<DateTimeOffset>();

            var today = DateTimeOffset.Now;
            var tomorrow = DateTimeOffset.Now.AddDays(1);
            
            //Act
            sut.SetDate(nameof(sut.Date), tomorrow);
            
            //Assert
            sut.Date.Should().BeAfter(today);
        }
        
        [Fact]
        public void Should_not_throw_null_ref_for_empty_field_name()
        {
            //Arrange
            var sut = new TestEntity<DateTimeOffset>();

            var tomorrow = DateTimeOffset.Now.AddDays(1);
            
            //Act
            Action act = () => sut.SetDate("", tomorrow);
            
            //Assert
            sut.Date.Should().Be(default);
            act.Should().NotThrow();
        }
    }
}