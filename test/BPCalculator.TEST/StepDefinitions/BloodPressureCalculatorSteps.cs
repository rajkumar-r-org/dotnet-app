using System;
using TechTalk.SpecFlow;
using Xunit;
using BPCalculator;

[Binding]
public class BloodPressureCalculatorSteps
{
    private readonly BloodPressure _bloodPressure = new BloodPressure();
    private BPCategory _result;

    [Given(@"a systolic reading of (.*) mmHg and a diastolic reading of (.*) mmHg")]
    public void GivenASystolicReadingAndADiastolicReading(int systolic, int diastolic)
    {
        _bloodPressure.Systolic = systolic;
        _bloodPressure.Diastolic = diastolic;
    }

    [When(@"the blood pressure is calculated")]
    public void WhenTheBloodPressureIsCalculated()
    {
        _result = _bloodPressure.Category;
    }

    [Then(@"the category should be (.*)")]
    public void ThenTheCategoryShouldBe(string expectedCategory)
    {
        var expectedEnum = (BPCategory)Enum.Parse(typeof(BPCategory), expectedCategory.Replace(" ", ""), true);
        Assert.Equal(expectedEnum, _result);

    }
}
