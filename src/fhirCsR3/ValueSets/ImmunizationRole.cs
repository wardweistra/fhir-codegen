// <auto-generated />
// Built from: hl7.fhir.r3.core version: 3.0.2
  // Option: "NAMESPACE" = "fhirCsR3"

using fhirCsR3.Models;

namespace fhirCsR3.ValueSets
{
  /// <summary>
  /// The value set to instantiate this attribute should be drawn from a terminologically robust code system that consists of or contains concepts to support describing the role a practitioner may play in the immunization event. This value set is provided as a suggestive example.
  /// </summary>
  public static class ImmunizationRoleCodes
  {
    /// <summary>
    /// Administering Provider
    /// </summary>
    public static readonly Coding AdministeringProvider = new Coding
    {
      Code = "AP",
      Display = "Administering Provider",
      System = "http://hl7.org/fhir/v2/0443"
    };
    /// <summary>
    /// Ordering Provider
    /// </summary>
    public static readonly Coding OrderingProvider = new Coding
    {
      Code = "OP",
      Display = "Ordering Provider",
      System = "http://hl7.org/fhir/v2/0443"
    };

    /// <summary>
    /// Literal for code: AdministeringProvider
    /// </summary>
    public const string LiteralAdministeringProvider = "AP";

    /// <summary>
    /// Literal for code: V20443AdministeringProvider
    /// </summary>
    public const string LiteralV20443AdministeringProvider = "http://hl7.org/fhir/v2/0443#AP";

    /// <summary>
    /// Literal for code: OrderingProvider
    /// </summary>
    public const string LiteralOrderingProvider = "OP";

    /// <summary>
    /// Literal for code: V20443OrderingProvider
    /// </summary>
    public const string LiteralV20443OrderingProvider = "http://hl7.org/fhir/v2/0443#OP";

    /// <summary>
    /// Dictionary for looking up ImmunizationRole Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "AP", AdministeringProvider }, 
      { "http://hl7.org/fhir/v2/0443#AP", AdministeringProvider }, 
      { "OP", OrderingProvider }, 
      { "http://hl7.org/fhir/v2/0443#OP", OrderingProvider }, 
    };
  };
}