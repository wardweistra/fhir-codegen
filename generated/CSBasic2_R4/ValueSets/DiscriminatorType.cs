// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// How an element value is interpreted when discrimination is evaluated.
  /// </summary>
  public static class DiscriminatorTypeCodes
  {
    /// <summary>
    /// The slices are differentiated by the presence or absence of the nominated element.
    /// </summary>
    public static readonly Coding Exists = new Coding
    {
      Code = "exists",
      Display = "Exists",
      System = "http://hl7.org/fhir/discriminator-type"
    };
    /// <summary>
    /// The slices have different values in the nominated element, as determined by testing them against the applicable ElementDefinition.pattern[x].
    /// </summary>
    public static readonly Coding Pattern = new Coding
    {
      Code = "pattern",
      Display = "Pattern",
      System = "http://hl7.org/fhir/discriminator-type"
    };
    /// <summary>
    /// The slices are differentiated by conformance of the nominated element to a specified profile. Note that if the path specifies .resolve() then the profile is the target profile on the reference. In this case, validation by the possible profiles is required to differentiate the slices.
    /// </summary>
    public static readonly Coding Profile = new Coding
    {
      Code = "profile",
      Display = "Profile",
      System = "http://hl7.org/fhir/discriminator-type"
    };
    /// <summary>
    /// The slices are differentiated by type of the nominated element.
    /// </summary>
    public static readonly Coding Type = new Coding
    {
      Code = "type",
      Display = "Type",
      System = "http://hl7.org/fhir/discriminator-type"
    };
    /// <summary>
    /// The slices have different values in the nominated element.
    /// </summary>
    public static readonly Coding Value = new Coding
    {
      Code = "value",
      Display = "Value",
      System = "http://hl7.org/fhir/discriminator-type"
    };
  };
}