﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace BPCalculator
{
    // BP categories
    public enum BPCategory
    {
        [Display(Name="Low Blood Pressure")] Low,
        [Display(Name="Ideal Blood Pressure")] Ideal,
        [Display(Name="Pre-High Blood Pressure")] PreHigh,
        [Display(Name="High Blood Pressure")] High
    };

    public class BloodPressure
    {
        public const int SystolicMin = 70;
        public const int SystolicMax = 190;
        public const int DiastolicMin = 40;
        public const int DiastolicMax = 100;

        [Range(SystolicMin, SystolicMax, ErrorMessage = "Invalid Systolic Value")]
        public int Systolic { get; set; } // mmHG

        [Range(DiastolicMin, DiastolicMax, ErrorMessage = "Invalid Diastolic Value")]
        public int Diastolic { get; set; } // mmHG

        // calculate BP category
        public BPCategory Category
        {
            get
            {
                // According to the chart provided
                if (Systolic >= 140 && Diastolic >= 90)
                {
                    return BPCategory.High;
                }
                else if (Systolic >= 120 && Diastolic >= 80)
                {
                    return BPCategory.PreHigh;
                }
                else if (Systolic >= 90 && Diastolic >= 60)
                {
                    return BPCategory.Ideal;
                }
                else
                {
                    return BPCategory.Low;
                }
            }
        }

        // New feature: Get health advice based on BP category
        public string GetHealthAdvice()
        {
            switch (Category)
            {
                case BPCategory.Low:
                    return "Blood pressure is low. Consider consulting a healthcare provider.";
                case BPCategory.Ideal:
                    return "Blood pressure is at an ideal level. Keep up the healthy lifestyle!";
                case BPCategory.PreHigh:
                    return "Pre-high blood pressure. Consider lifestyle changes and regular monitoring.";
                case BPCategory.High:
                    return "High blood pressure. Consult a healthcare provider for advice.";
                default:
                    return "Blood pressure category not determined.";
            }
        }
    }
}