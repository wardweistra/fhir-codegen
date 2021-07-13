// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// Estimate of the potential clinical harm, or seriousness, of a reaction to an identified substance.
  /// </summary>
  public static class AllergyIntoleranceCriticalityCodes
  {
    /// <summary>
    /// Worst case result of a future exposure is assessed to be life-threatening or having high potential for organ system failure.
    /// </summary>
    public static readonly Coding HighRisk = new Coding
    {
      Code = "high",
      Display = "High Risk",
      System = "http://hl7.org/fhir/allergy-intolerance-criticality"
    };
    /// <summary>
    /// Worst case result of a future exposure is not assessed to be life-threatening or having high potential for organ system failure.
    /// </summary>
    public static readonly Coding LowRisk = new Coding
    {
      Code = "low",
      Display = "Low Risk",
      System = "http://hl7.org/fhir/allergy-intolerance-criticality"
    };
    /// <summary>
    /// Unable to assess the worst case result of a future exposure.
    /// </summary>
    public static readonly Coding UnableToAssessRisk = new Coding
    {
      Code = "unable-to-assess",
      Display = "Unable to Assess Risk",
      System = "http://hl7.org/fhir/allergy-intolerance-criticality"
    };
  };
}