// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// How a rule statement is applied, such as adding additional consent or removing consent.
  /// </summary>
  public static class ConsentProvisionTypeCodes
  {
    /// <summary>
    /// Consent is denied for actions meeting these rules.
    /// </summary>
    public static readonly Coding OptOut = new Coding
    {
      Code = "deny",
      Display = "Opt Out",
      System = "http://hl7.org/fhir/consent-provision-type"
    };
    /// <summary>
    /// Consent is provided for actions meeting these rules.
    /// </summary>
    public static readonly Coding OptIn = new Coding
    {
      Code = "permit",
      Display = "Opt In",
      System = "http://hl7.org/fhir/consent-provision-type"
    };

    /// <summary>
    /// Literal for code: OptOut
    /// </summary>
    public const string LiteralOptOut = "deny";

    /// <summary>
    /// Literal for code: ConsentProvisionTypeOptOut
    /// </summary>
    public const string LiteralConsentProvisionTypeOptOut = "http://hl7.org/fhir/consent-provision-type#deny";

    /// <summary>
    /// Literal for code: OptIn
    /// </summary>
    public const string LiteralOptIn = "permit";

    /// <summary>
    /// Literal for code: ConsentProvisionTypeOptIn
    /// </summary>
    public const string LiteralConsentProvisionTypeOptIn = "http://hl7.org/fhir/consent-provision-type#permit";

    /// <summary>
    /// Dictionary for looking up ConsentProvisionType Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "deny", OptOut }, 
      { "http://hl7.org/fhir/consent-provision-type#deny", OptOut }, 
      { "permit", OptIn }, 
      { "http://hl7.org/fhir/consent-provision-type#permit", OptIn }, 
    };
  };
}