// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// How a type relates to its baseDefinition.
  /// </summary>
  public static class TypeDerivationRuleCodes
  {
    /// <summary>
    /// This definition adds additional rules to an existing concrete type.
    /// </summary>
    public static readonly Coding Constraint = new Coding
    {
      Code = "constraint",
      Display = "Constraint",
      System = "http://hl7.org/fhir/type-derivation-rule"
    };
    /// <summary>
    /// This definition defines a new type that adds additional elements to the base type.
    /// </summary>
    public static readonly Coding Specialization = new Coding
    {
      Code = "specialization",
      Display = "Specialization",
      System = "http://hl7.org/fhir/type-derivation-rule"
    };
  };
}