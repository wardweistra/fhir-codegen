// <auto-generated />
// Built from: hl7.fhir.r3.core version: 3.0.2
  // Option: "NAMESPACE" = "fhirCsR3"

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using fhirCsR3.Serialization;

namespace fhirCsR3.Models
{
  /// <summary>
  /// A suite of underwrite specific classifiers, for example may be used to identify a class of coverage or employer group, Policy, Plan.
  /// </summary>
  [JsonConverter(typeof(fhirCsR3.Serialization.JsonStreamComponentConverter<CoverageGrouping>))]
  public class CoverageGrouping : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// Identifies a style or collective of coverage issues by the underwriter, for example may be used to identify a class of coverage such as a level of deductables or co-payment.
    /// </summary>
    public string Class { get; set; }
    /// <summary>
    /// Extension container element for Class
    /// </summary>
    public Element _Class { get; set; }
    /// <summary>
    /// A short description for the class.
    /// </summary>
    public string ClassDisplay { get; set; }
    /// <summary>
    /// Extension container element for ClassDisplay
    /// </summary>
    public Element _ClassDisplay { get; set; }
    /// <summary>
    /// Identifies a style or collective of coverage issued by the underwriter, for example may be used to identify an employer group. May also be referred to as a Policy or Group ID.
    /// </summary>
    public string Group { get; set; }
    /// <summary>
    /// Extension container element for Group
    /// </summary>
    public Element _Group { get; set; }
    /// <summary>
    /// A short description for the group.
    /// </summary>
    public string GroupDisplay { get; set; }
    /// <summary>
    /// Extension container element for GroupDisplay
    /// </summary>
    public Element _GroupDisplay { get; set; }
    /// <summary>
    /// Identifies a style or collective of coverage issued by the underwriter, for example may be used to identify a collection of benefits provided to employees. May be referred to as a Section or Division ID.
    /// </summary>
    public string Plan { get; set; }
    /// <summary>
    /// Extension container element for Plan
    /// </summary>
    public Element _Plan { get; set; }
    /// <summary>
    /// A short description for the plan.
    /// </summary>
    public string PlanDisplay { get; set; }
    /// <summary>
    /// Extension container element for PlanDisplay
    /// </summary>
    public Element _PlanDisplay { get; set; }
    /// <summary>
    /// Identifies a sub-style or sub-collective of coverage issues by the underwriter, for example may be used to identify a subclass of coverage such as a sub-level of deductables or co-payment.
    /// </summary>
    public string SubClass { get; set; }
    /// <summary>
    /// Extension container element for SubClass
    /// </summary>
    public Element _SubClass { get; set; }
    /// <summary>
    /// A short description for the subclass.
    /// </summary>
    public string SubClassDisplay { get; set; }
    /// <summary>
    /// Extension container element for SubClassDisplay
    /// </summary>
    public Element _SubClassDisplay { get; set; }
    /// <summary>
    /// Identifies a style or collective of coverage issued by the underwriter, for example may be used to identify a subset of an employer group.
    /// </summary>
    public string SubGroup { get; set; }
    /// <summary>
    /// Extension container element for SubGroup
    /// </summary>
    public Element _SubGroup { get; set; }
    /// <summary>
    /// A short description for the subgroup.
    /// </summary>
    public string SubGroupDisplay { get; set; }
    /// <summary>
    /// Extension container element for SubGroupDisplay
    /// </summary>
    public Element _SubGroupDisplay { get; set; }
    /// <summary>
    /// Identifies a sub-style or sub-collective of coverage issued by the underwriter, for example may be used to identify a subset of a collection of benefits provided to employees.
    /// </summary>
    public string SubPlan { get; set; }
    /// <summary>
    /// Extension container element for SubPlan
    /// </summary>
    public Element _SubPlan { get; set; }
    /// <summary>
    /// A short description for the subplan.
    /// </summary>
    public string SubPlanDisplay { get; set; }
    /// <summary>
    /// Extension container element for SubPlanDisplay
    /// </summary>
    public Element _SubPlanDisplay { get; set; }
    /// <summary>
    /// Serialize to a JSON object
    /// </summary>
    public new void SerializeJson(Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject)
      {
        writer.WriteStartObject();
      }
      ((fhirCsR3.Models.BackboneElement)this).SerializeJson(writer, options, false);

      if (!string.IsNullOrEmpty(Group))
      {
        writer.WriteString("group", (string)Group!);
      }

      if (_Group != null)
      {
        writer.WritePropertyName("_group");
        _Group.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(GroupDisplay))
      {
        writer.WriteString("groupDisplay", (string)GroupDisplay!);
      }

      if (_GroupDisplay != null)
      {
        writer.WritePropertyName("_groupDisplay");
        _GroupDisplay.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(SubGroup))
      {
        writer.WriteString("subGroup", (string)SubGroup!);
      }

      if (_SubGroup != null)
      {
        writer.WritePropertyName("_subGroup");
        _SubGroup.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(SubGroupDisplay))
      {
        writer.WriteString("subGroupDisplay", (string)SubGroupDisplay!);
      }

      if (_SubGroupDisplay != null)
      {
        writer.WritePropertyName("_subGroupDisplay");
        _SubGroupDisplay.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Plan))
      {
        writer.WriteString("plan", (string)Plan!);
      }

      if (_Plan != null)
      {
        writer.WritePropertyName("_plan");
        _Plan.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(PlanDisplay))
      {
        writer.WriteString("planDisplay", (string)PlanDisplay!);
      }

      if (_PlanDisplay != null)
      {
        writer.WritePropertyName("_planDisplay");
        _PlanDisplay.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(SubPlan))
      {
        writer.WriteString("subPlan", (string)SubPlan!);
      }

      if (_SubPlan != null)
      {
        writer.WritePropertyName("_subPlan");
        _SubPlan.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(SubPlanDisplay))
      {
        writer.WriteString("subPlanDisplay", (string)SubPlanDisplay!);
      }

      if (_SubPlanDisplay != null)
      {
        writer.WritePropertyName("_subPlanDisplay");
        _SubPlanDisplay.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Class))
      {
        writer.WriteString("class", (string)Class!);
      }

      if (_Class != null)
      {
        writer.WritePropertyName("_class");
        _Class.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(ClassDisplay))
      {
        writer.WriteString("classDisplay", (string)ClassDisplay!);
      }

      if (_ClassDisplay != null)
      {
        writer.WritePropertyName("_classDisplay");
        _ClassDisplay.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(SubClass))
      {
        writer.WriteString("subClass", (string)SubClass!);
      }

      if (_SubClass != null)
      {
        writer.WritePropertyName("_subClass");
        _SubClass.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(SubClassDisplay))
      {
        writer.WriteString("subClassDisplay", (string)SubClassDisplay!);
      }

      if (_SubClassDisplay != null)
      {
        writer.WritePropertyName("_subClassDisplay");
        _SubClassDisplay.SerializeJson(writer, options);
      }

      if (includeStartObject)
      {
        writer.WriteEndObject();
      }
    }
    /// <summary>
    /// Deserialize a JSON property
    /// </summary>
    public new void DeserializeJsonProperty(ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "class":
          Class = reader.GetString();
          break;

        case "_class":
          _Class = new fhirCsR3.Models.Element();
          _Class.DeserializeJson(ref reader, options);
          break;

        case "classDisplay":
          ClassDisplay = reader.GetString();
          break;

        case "_classDisplay":
          _ClassDisplay = new fhirCsR3.Models.Element();
          _ClassDisplay.DeserializeJson(ref reader, options);
          break;

        case "group":
          Group = reader.GetString();
          break;

        case "_group":
          _Group = new fhirCsR3.Models.Element();
          _Group.DeserializeJson(ref reader, options);
          break;

        case "groupDisplay":
          GroupDisplay = reader.GetString();
          break;

        case "_groupDisplay":
          _GroupDisplay = new fhirCsR3.Models.Element();
          _GroupDisplay.DeserializeJson(ref reader, options);
          break;

        case "plan":
          Plan = reader.GetString();
          break;

        case "_plan":
          _Plan = new fhirCsR3.Models.Element();
          _Plan.DeserializeJson(ref reader, options);
          break;

        case "planDisplay":
          PlanDisplay = reader.GetString();
          break;

        case "_planDisplay":
          _PlanDisplay = new fhirCsR3.Models.Element();
          _PlanDisplay.DeserializeJson(ref reader, options);
          break;

        case "subClass":
          SubClass = reader.GetString();
          break;

        case "_subClass":
          _SubClass = new fhirCsR3.Models.Element();
          _SubClass.DeserializeJson(ref reader, options);
          break;

        case "subClassDisplay":
          SubClassDisplay = reader.GetString();
          break;

        case "_subClassDisplay":
          _SubClassDisplay = new fhirCsR3.Models.Element();
          _SubClassDisplay.DeserializeJson(ref reader, options);
          break;

        case "subGroup":
          SubGroup = reader.GetString();
          break;

        case "_subGroup":
          _SubGroup = new fhirCsR3.Models.Element();
          _SubGroup.DeserializeJson(ref reader, options);
          break;

        case "subGroupDisplay":
          SubGroupDisplay = reader.GetString();
          break;

        case "_subGroupDisplay":
          _SubGroupDisplay = new fhirCsR3.Models.Element();
          _SubGroupDisplay.DeserializeJson(ref reader, options);
          break;

        case "subPlan":
          SubPlan = reader.GetString();
          break;

        case "_subPlan":
          _SubPlan = new fhirCsR3.Models.Element();
          _SubPlan.DeserializeJson(ref reader, options);
          break;

        case "subPlanDisplay":
          SubPlanDisplay = reader.GetString();
          break;

        case "_subPlanDisplay":
          _SubPlanDisplay = new fhirCsR3.Models.Element();
          _SubPlanDisplay.DeserializeJson(ref reader, options);
          break;

        default:
          ((fhirCsR3.Models.BackboneElement)this).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Deserialize a JSON object
    /// </summary>
    public new void DeserializeJson(ref Utf8JsonReader reader, JsonSerializerOptions options)
    {
      string propertyName;

      while (reader.Read())
      {
        if (reader.TokenType == JsonTokenType.EndObject)
        {
          return;
        }

        if (reader.TokenType == JsonTokenType.PropertyName)
        {
          propertyName = reader.GetString();
          reader.Read();
          this.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException();
    }
  }
  /// <summary>
  /// Financial instrument which may be used to reimburse or pay for health care products and services.
  /// </summary>
  [JsonConverter(typeof(fhirCsR3.Serialization.JsonStreamComponentConverter<Coverage>))]
  public class Coverage : DomainResource,  IFhirJsonSerializable {
    /// <summary>
    /// Resource Type Name
    /// </summary>
    public override string ResourceType => "Coverage";
    /// <summary>
    /// The party who benefits from the insurance coverage., the patient when services are provided.
    /// </summary>
    public Reference Beneficiary { get; set; }
    /// <summary>
    /// The policy(s) which constitute this insurance coverage.
    /// </summary>
    public List<Reference> Contract { get; set; }
    /// <summary>
    /// A unique identifier for a dependent under the coverage.
    /// </summary>
    public string Dependent { get; set; }
    /// <summary>
    /// Extension container element for Dependent
    /// </summary>
    public Element _Dependent { get; set; }
    /// <summary>
    /// A suite of underwrite specific classifiers, for example may be used to identify a class of coverage or employer group, Policy, Plan.
    /// </summary>
    public CoverageGrouping Grouping { get; set; }
    /// <summary>
    /// The main (and possibly only) identifier for the coverage - often referred to as a Member Id, Certificate number, Personal Health Number or Case ID. May be constructed as the concatination of the Coverage.SubscriberID and the Coverage.dependant.
    /// </summary>
    public List<Identifier> Identifier { get; set; }
    /// <summary>
    /// The insurer-specific identifier for the insurer-defined network of providers to which the beneficiary may seek treatment which will be covered at the 'in-network' rate, otherwise 'out of network' terms and conditions apply.
    /// </summary>
    public string Network { get; set; }
    /// <summary>
    /// Extension container element for Network
    /// </summary>
    public Element _Network { get; set; }
    /// <summary>
    /// The order of applicability of this coverage relative to other coverages which are currently inforce. Note, there may be gaps in the numbering and this does not imply primary, secondard etc. as the specific positioning of coverages depends upon the episode of care.
    /// </summary>
    public uint? Order { get; set; }
    /// <summary>
    /// The program or plan underwriter or payor including both insurance and non-insurance agreements, such as patient-pay agreements. May provide multiple identifiers such as insurance company identifier or business identifier (BIN number).
    /// </summary>
    public List<Reference> Payor { get; set; }
    /// <summary>
    /// Time period during which the coverage is in force. A missing start date indicates the start date isn't known, a missing end date means the coverage is continuing to be in force.
    /// </summary>
    public Period Period { get; set; }
    /// <summary>
    /// The party who 'owns' the insurance policy,  may be an individual, corporation or the subscriber's employer.
    /// </summary>
    public Reference PolicyHolder { get; set; }
    /// <summary>
    /// The relationship of beneficiary (patient) to the subscriber.
    /// </summary>
    public CodeableConcept Relationship { get; set; }
    /// <summary>
    /// An optional counter for a particular instance of the identified coverage which increments upon each renewal.
    /// </summary>
    public string Sequence { get; set; }
    /// <summary>
    /// Extension container element for Sequence
    /// </summary>
    public Element _Sequence { get; set; }
    /// <summary>
    /// This element is labeled as a modifier because the status contains the code entered-in-error that marks the coverage as not currently valid.
    /// </summary>
    public string Status { get; set; }
    /// <summary>
    /// Extension container element for Status
    /// </summary>
    public Element _Status { get; set; }
    /// <summary>
    /// The party who has signed-up for or 'owns' the contractual relationship to the policy or to whom the benefit of the policy for services rendered to them or their family is due.
    /// </summary>
    public Reference Subscriber { get; set; }
    /// <summary>
    /// The insurer assigned ID for the Subscriber.
    /// </summary>
    public string SubscriberId { get; set; }
    /// <summary>
    /// Extension container element for SubscriberId
    /// </summary>
    public Element _SubscriberId { get; set; }
    /// <summary>
    /// The type of coverage: social program, medical plan, accident coverage (workers compensation, auto), group health or payment by an individual or organization.
    /// </summary>
    public CodeableConcept Type { get; set; }
    /// <summary>
    /// Serialize to a JSON object
    /// </summary>
    public new void SerializeJson(Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject)
      {
        writer.WriteStartObject();
      }
      if (!string.IsNullOrEmpty(ResourceType))
      {
        writer.WriteString("resourceType", (string)ResourceType!);
      }


      ((fhirCsR3.Models.DomainResource)this).SerializeJson(writer, options, false);

      if ((Identifier != null) && (Identifier.Count != 0))
      {
        writer.WritePropertyName("identifier");
        writer.WriteStartArray();

        foreach (Identifier valIdentifier in Identifier)
        {
          valIdentifier.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (!string.IsNullOrEmpty(Status))
      {
        writer.WriteString("status", (string)Status!);
      }

      if (_Status != null)
      {
        writer.WritePropertyName("_status");
        _Status.SerializeJson(writer, options);
      }

      if (Type != null)
      {
        writer.WritePropertyName("type");
        Type.SerializeJson(writer, options);
      }

      if (PolicyHolder != null)
      {
        writer.WritePropertyName("policyHolder");
        PolicyHolder.SerializeJson(writer, options);
      }

      if (Subscriber != null)
      {
        writer.WritePropertyName("subscriber");
        Subscriber.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(SubscriberId))
      {
        writer.WriteString("subscriberId", (string)SubscriberId!);
      }

      if (_SubscriberId != null)
      {
        writer.WritePropertyName("_subscriberId");
        _SubscriberId.SerializeJson(writer, options);
      }

      if (Beneficiary != null)
      {
        writer.WritePropertyName("beneficiary");
        Beneficiary.SerializeJson(writer, options);
      }

      if (Relationship != null)
      {
        writer.WritePropertyName("relationship");
        Relationship.SerializeJson(writer, options);
      }

      if (Period != null)
      {
        writer.WritePropertyName("period");
        Period.SerializeJson(writer, options);
      }

      if ((Payor != null) && (Payor.Count != 0))
      {
        writer.WritePropertyName("payor");
        writer.WriteStartArray();

        foreach (Reference valPayor in Payor)
        {
          valPayor.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (Grouping != null)
      {
        writer.WritePropertyName("grouping");
        Grouping.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Dependent))
      {
        writer.WriteString("dependent", (string)Dependent!);
      }

      if (_Dependent != null)
      {
        writer.WritePropertyName("_dependent");
        _Dependent.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Sequence))
      {
        writer.WriteString("sequence", (string)Sequence!);
      }

      if (_Sequence != null)
      {
        writer.WritePropertyName("_sequence");
        _Sequence.SerializeJson(writer, options);
      }

      if (Order != null)
      {
        writer.WriteNumber("order", (uint)Order!);
      }

      if (!string.IsNullOrEmpty(Network))
      {
        writer.WriteString("network", (string)Network!);
      }

      if (_Network != null)
      {
        writer.WritePropertyName("_network");
        _Network.SerializeJson(writer, options);
      }

      if ((Contract != null) && (Contract.Count != 0))
      {
        writer.WritePropertyName("contract");
        writer.WriteStartArray();

        foreach (Reference valContract in Contract)
        {
          valContract.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (includeStartObject)
      {
        writer.WriteEndObject();
      }
    }
    /// <summary>
    /// Deserialize a JSON property
    /// </summary>
    public new void DeserializeJsonProperty(ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "beneficiary":
          Beneficiary = new fhirCsR3.Models.Reference();
          Beneficiary.DeserializeJson(ref reader, options);
          break;

        case "contract":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Contract = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR3.Models.Reference objContract = new fhirCsR3.Models.Reference();
            objContract.DeserializeJson(ref reader, options);
            Contract.Add(objContract);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Contract.Count == 0)
          {
            Contract = null;
          }

          break;

        case "dependent":
          Dependent = reader.GetString();
          break;

        case "_dependent":
          _Dependent = new fhirCsR3.Models.Element();
          _Dependent.DeserializeJson(ref reader, options);
          break;

        case "grouping":
          Grouping = new fhirCsR3.Models.CoverageGrouping();
          Grouping.DeserializeJson(ref reader, options);
          break;

        case "identifier":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Identifier = new List<Identifier>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR3.Models.Identifier objIdentifier = new fhirCsR3.Models.Identifier();
            objIdentifier.DeserializeJson(ref reader, options);
            Identifier.Add(objIdentifier);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Identifier.Count == 0)
          {
            Identifier = null;
          }

          break;

        case "network":
          Network = reader.GetString();
          break;

        case "_network":
          _Network = new fhirCsR3.Models.Element();
          _Network.DeserializeJson(ref reader, options);
          break;

        case "order":
          Order = reader.GetUInt32();
          break;

        case "payor":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Payor = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR3.Models.Reference objPayor = new fhirCsR3.Models.Reference();
            objPayor.DeserializeJson(ref reader, options);
            Payor.Add(objPayor);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Payor.Count == 0)
          {
            Payor = null;
          }

          break;

        case "period":
          Period = new fhirCsR3.Models.Period();
          Period.DeserializeJson(ref reader, options);
          break;

        case "policyHolder":
          PolicyHolder = new fhirCsR3.Models.Reference();
          PolicyHolder.DeserializeJson(ref reader, options);
          break;

        case "relationship":
          Relationship = new fhirCsR3.Models.CodeableConcept();
          Relationship.DeserializeJson(ref reader, options);
          break;

        case "sequence":
          Sequence = reader.GetString();
          break;

        case "_sequence":
          _Sequence = new fhirCsR3.Models.Element();
          _Sequence.DeserializeJson(ref reader, options);
          break;

        case "status":
          Status = reader.GetString();
          break;

        case "_status":
          _Status = new fhirCsR3.Models.Element();
          _Status.DeserializeJson(ref reader, options);
          break;

        case "subscriber":
          Subscriber = new fhirCsR3.Models.Reference();
          Subscriber.DeserializeJson(ref reader, options);
          break;

        case "subscriberId":
          SubscriberId = reader.GetString();
          break;

        case "_subscriberId":
          _SubscriberId = new fhirCsR3.Models.Element();
          _SubscriberId.DeserializeJson(ref reader, options);
          break;

        case "type":
          Type = new fhirCsR3.Models.CodeableConcept();
          Type.DeserializeJson(ref reader, options);
          break;

        default:
          ((fhirCsR3.Models.DomainResource)this).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Deserialize a JSON object
    /// </summary>
    public new void DeserializeJson(ref Utf8JsonReader reader, JsonSerializerOptions options)
    {
      string propertyName;

      while (reader.Read())
      {
        if (reader.TokenType == JsonTokenType.EndObject)
        {
          return;
        }

        if (reader.TokenType == JsonTokenType.PropertyName)
        {
          propertyName = reader.GetString();
          reader.Read();
          this.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException();
    }
  }
  /// <summary>
  /// Code Values for the Coverage.status field
  /// </summary>
  public static class CoverageStatusCodes {
    public const string ACTIVE = "active";
    public const string CANCELLED = "cancelled";
    public const string DRAFT = "draft";
    public const string ENTERED_IN_ERROR = "entered-in-error";
    public static HashSet<string> Values = new HashSet<string>() {
      "active",
      "cancelled",
      "draft",
      "entered-in-error",
    };
  }
}