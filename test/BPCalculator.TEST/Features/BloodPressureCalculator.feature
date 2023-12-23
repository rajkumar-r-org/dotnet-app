Feature: BloodPressureCalculator
    In order to diagnose blood pressure conditions
    As a medical professional
    I want to categorize blood pressure readings

Scenario Outline: Categorizing blood pressure
    Given a systolic reading of 115 mmHg and a diastolic reading of 75 mmHg
    When the blood pressure is calculated
    Then the category should be Ideal

Examples: 
    | systolic | diastolic | category|
    | 145      | 95        | High    |
    | 130      | 85        | PreHigh |
    | 115      | 75        | Ideal   |
    | 85       | 55        | Low     |
