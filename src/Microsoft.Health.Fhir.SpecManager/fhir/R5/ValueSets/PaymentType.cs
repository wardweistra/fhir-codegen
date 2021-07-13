// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// This value set includes sample Payment Type codes.
  /// </summary>
  public static class PaymentTypeCodes
  {
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Adjustment = new Coding
    {
      Code = "adjustment",
      Display = "Adjustment",
      System = "http://terminology.hl7.org/CodeSystem/payment-type"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Advance = new Coding
    {
      Code = "advance",
      Display = "Advance",
      System = "http://terminology.hl7.org/CodeSystem/payment-type"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Payment = new Coding
    {
      Code = "payment",
      Display = "Payment",
      System = "http://terminology.hl7.org/CodeSystem/payment-type"
    };
  };
}