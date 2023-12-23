using System;
using Xunit;

using BPCalculator;

namespace BPCalculator.TEST;


public class UnitTest1
{
    // Test for High Blood Pressure
        [Theory]
        [InlineData(140, 90)]
        [InlineData(180, 100)]
        public void BloodPressure_HighCategory(int systolic, int diastolic)
        {
            var bp = new BloodPressure { Systolic = systolic, Diastolic = diastolic };
            Assert.Equal(BPCategory.High, bp.Category);
        }

        // Test for Pre-High Blood Pressure
        [Theory]
        [InlineData(120, 80)]
        [InlineData(139, 89)]
        public void BloodPressure_PreHighCategory(int systolic, int diastolic)
        {
            var bp = new BloodPressure { Systolic = systolic, Diastolic = diastolic };
            Assert.Equal(BPCategory.PreHigh, bp.Category);
        }

        // Test for Ideal Blood Pressure
        [Theory]
        [InlineData(90, 60)]
        [InlineData(119, 79)]
        public void BloodPressure_IdealCategory(int systolic, int diastolic)
        {
            var bp = new BloodPressure { Systolic = systolic, Diastolic = diastolic };
            Assert.Equal(BPCategory.Ideal, bp.Category);
        }

        // Test for Low Blood Pressure
        [Theory]
        [InlineData(70, 40)]
        [InlineData(89, 59)]
        public void BloodPressure_LowCategory(int systolic, int diastolic)
        {
            var bp = new BloodPressure { Systolic = systolic, Diastolic = diastolic };
            Assert.Equal(BPCategory.Low, bp.Category);
        }

        // Test for Invalid Values
        [Theory]
        [InlineData(191, 101)]
        [InlineData(69, 39)]
        public void BloodPressure_InvalidValues(int systolic, int diastolic)
        {
            var bp = new BloodPressure { Systolic = systolic, Diastolic = diastolic };
            // Here, you need to check for validation failure
            // This depends on how you handle validation in your application
        }
}