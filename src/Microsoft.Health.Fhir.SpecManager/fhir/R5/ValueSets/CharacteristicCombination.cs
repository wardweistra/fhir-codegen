// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// Logical grouping of characteristics.
  /// </summary>
  public static class CharacteristicCombinationCodes
  {
    /// <summary>
    /// Combine characteristics with AND.
    /// </summary>
    public static readonly Coding Intersection = new Coding
    {
      Code = "intersection",
      Display = "intersection",
      System = "http://hl7.org/fhir/characteristic-combination"
    };
    /// <summary>
    /// Combine characteristics with OR.
    /// </summary>
    public static readonly Coding Union = new Coding
    {
      Code = "union",
      Display = "union",
      System = "http://hl7.org/fhir/characteristic-combination"
    };
  };
}