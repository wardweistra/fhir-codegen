// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1
  // Option: "NAMESPACE" = "fhirCsR4"

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using fhirCsR4.Serialization;

namespace fhirCsR4.Models
{
  /// <summary>
  /// When multiple targets are present for a single goal instance, all targets must be met for the overall goal to be met.
  /// </summary>
  [JsonConverter(typeof(fhirCsR4.Serialization.JsonStreamComponentConverter<GoalTarget>))]
  public class GoalTarget : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// A CodeableConcept with just a text would be used instead of a string if the field was usually coded, or if the type associated with the Goal.target.measure defines a coded value.
    /// </summary>
    public Quantity DetailQuantity { get; set; }
    /// <summary>
    /// A CodeableConcept with just a text would be used instead of a string if the field was usually coded, or if the type associated with the Goal.target.measure defines a coded value.
    /// </summary>
    public Range DetailRange { get; set; }
    /// <summary>
    /// A CodeableConcept with just a text would be used instead of a string if the field was usually coded, or if the type associated with the Goal.target.measure defines a coded value.
    /// </summary>
    public CodeableConcept DetailCodeableConcept { get; set; }
    /// <summary>
    /// A CodeableConcept with just a text would be used instead of a string if the field was usually coded, or if the type associated with the Goal.target.measure defines a coded value.
    /// </summary>
    public string DetailString { get; set; }
    /// <summary>
    /// Extension container element for DetailString
    /// </summary>
    public Element _DetailString { get; set; }
    /// <summary>
    /// A CodeableConcept with just a text would be used instead of a string if the field was usually coded, or if the type associated with the Goal.target.measure defines a coded value.
    /// </summary>
    public bool? DetailBoolean { get; set; }
    /// <summary>
    /// Extension container element for DetailBoolean
    /// </summary>
    public Element _DetailBoolean { get; set; }
    /// <summary>
    /// A CodeableConcept with just a text would be used instead of a string if the field was usually coded, or if the type associated with the Goal.target.measure defines a coded value.
    /// </summary>
    public int? DetailInteger { get; set; }
    /// <summary>
    /// Extension container element for DetailInteger
    /// </summary>
    public Element _DetailInteger { get; set; }
    /// <summary>
    /// A CodeableConcept with just a text would be used instead of a string if the field was usually coded, or if the type associated with the Goal.target.measure defines a coded value.
    /// </summary>
    public Ratio DetailRatio { get; set; }
    /// <summary>
    /// Indicates either the date or the duration after start by which the goal should be met.
    /// </summary>
    public string DueDate { get; set; }
    /// <summary>
    /// Extension container element for DueDate
    /// </summary>
    public Element _DueDate { get; set; }
    /// <summary>
    /// Indicates either the date or the duration after start by which the goal should be met.
    /// </summary>
    public Duration DueDuration { get; set; }
    /// <summary>
    /// The parameter whose value is being tracked, e.g. body weight, blood pressure, or hemoglobin A1c level.
    /// </summary>
    public CodeableConcept Measure { get; set; }
    /// <summary>
    /// Serialize to a JSON object
    /// </summary>
    public new void SerializeJson(Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject)
      {
        writer.WriteStartObject();
      }
      ((fhirCsR4.Models.BackboneElement)this).SerializeJson(writer, options, false);

      if (Measure != null)
      {
        writer.WritePropertyName("measure");
        Measure.SerializeJson(writer, options);
      }

      if (DetailQuantity != null)
      {
        writer.WritePropertyName("detailQuantity");
        DetailQuantity.SerializeJson(writer, options);
      }

      if (DetailRange != null)
      {
        writer.WritePropertyName("detailRange");
        DetailRange.SerializeJson(writer, options);
      }

      if (DetailCodeableConcept != null)
      {
        writer.WritePropertyName("detailCodeableConcept");
        DetailCodeableConcept.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(DetailString))
      {
        writer.WriteString("detailString", (string)DetailString!);
      }

      if (_DetailString != null)
      {
        writer.WritePropertyName("_detailString");
        _DetailString.SerializeJson(writer, options);
      }

      if (DetailBoolean != null)
      {
        writer.WriteBoolean("detailBoolean", (bool)DetailBoolean!);
      }

      if (_DetailBoolean != null)
      {
        writer.WritePropertyName("_detailBoolean");
        _DetailBoolean.SerializeJson(writer, options);
      }

      if (DetailInteger != null)
      {
        writer.WriteNumber("detailInteger", (int)DetailInteger!);
      }

      if (_DetailInteger != null)
      {
        writer.WritePropertyName("_detailInteger");
        _DetailInteger.SerializeJson(writer, options);
      }

      if (DetailRatio != null)
      {
        writer.WritePropertyName("detailRatio");
        DetailRatio.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(DueDate))
      {
        writer.WriteString("dueDate", (string)DueDate!);
      }

      if (_DueDate != null)
      {
        writer.WritePropertyName("_dueDate");
        _DueDate.SerializeJson(writer, options);
      }

      if (DueDuration != null)
      {
        writer.WritePropertyName("dueDuration");
        DueDuration.SerializeJson(writer, options);
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
        case "detailQuantity":
          DetailQuantity = new fhirCsR4.Models.Quantity();
          DetailQuantity.DeserializeJson(ref reader, options);
          break;

        case "detailRange":
          DetailRange = new fhirCsR4.Models.Range();
          DetailRange.DeserializeJson(ref reader, options);
          break;

        case "detailCodeableConcept":
          DetailCodeableConcept = new fhirCsR4.Models.CodeableConcept();
          DetailCodeableConcept.DeserializeJson(ref reader, options);
          break;

        case "detailString":
          DetailString = reader.GetString();
          break;

        case "_detailString":
          _DetailString = new fhirCsR4.Models.Element();
          _DetailString.DeserializeJson(ref reader, options);
          break;

        case "detailBoolean":
          DetailBoolean = reader.GetBoolean();
          break;

        case "_detailBoolean":
          _DetailBoolean = new fhirCsR4.Models.Element();
          _DetailBoolean.DeserializeJson(ref reader, options);
          break;

        case "detailInteger":
          DetailInteger = reader.GetInt32();
          break;

        case "_detailInteger":
          _DetailInteger = new fhirCsR4.Models.Element();
          _DetailInteger.DeserializeJson(ref reader, options);
          break;

        case "detailRatio":
          DetailRatio = new fhirCsR4.Models.Ratio();
          DetailRatio.DeserializeJson(ref reader, options);
          break;

        case "dueDate":
          DueDate = reader.GetString();
          break;

        case "_dueDate":
          _DueDate = new fhirCsR4.Models.Element();
          _DueDate.DeserializeJson(ref reader, options);
          break;

        case "dueDuration":
          DueDuration = new fhirCsR4.Models.Duration();
          DueDuration.DeserializeJson(ref reader, options);
          break;

        case "measure":
          Measure = new fhirCsR4.Models.CodeableConcept();
          Measure.DeserializeJson(ref reader, options);
          break;

        default:
          ((fhirCsR4.Models.BackboneElement)this).DeserializeJsonProperty(ref reader, options, propertyName);
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
  /// Describes the intended objective(s) for a patient, group or organization care, for example, weight loss, restoring an activity of daily living, obtaining herd immunity via immunization, meeting a process improvement objective, etc.
  /// </summary>
  [JsonConverter(typeof(fhirCsR4.Serialization.JsonStreamComponentConverter<Goal>))]
  public class Goal : DomainResource,  IFhirJsonSerializable {
    /// <summary>
    /// Resource Type Name
    /// </summary>
    public override string ResourceType => "Goal";
    /// <summary>
    /// Describes the progression, or lack thereof, towards the goal against the target.
    /// </summary>
    public CodeableConcept AchievementStatus { get; set; }
    /// <summary>
    /// The identified conditions and other health record elements that are intended to be addressed by the goal.
    /// </summary>
    public List<Reference> Addresses { get; set; }
    /// <summary>
    /// Indicates a category the goal falls within.
    /// </summary>
    public List<CodeableConcept> Category { get; set; }
    /// <summary>
    /// If no code is available, use CodeableConcept.text.
    /// </summary>
    public CodeableConcept Description { get; set; }
    /// <summary>
    /// This is the individual responsible for establishing the goal, not necessarily who recorded it.  (For that, use the Provenance resource.).
    /// </summary>
    public Reference ExpressedBy { get; set; }
    /// <summary>
    /// This is a business identifier, not a resource identifier (see [discussion](resource.html#identifiers)).  It is best practice for the identifier to only appear on a single resource instance, however business practices may occasionally dictate that multiple resource instances with the same identifier can exist - possibly even with different resource types.  For example, multiple Patient and a Person resource instance might share the same social insurance number.
    /// </summary>
    public List<Identifier> Identifier { get; set; }
    /// <summary>
    /// This element is labeled as a modifier because the lifecycleStatus contains codes that mark the resource as not currently valid.
    /// </summary>
    public string LifecycleStatus { get; set; }
    /// <summary>
    /// Extension container element for LifecycleStatus
    /// </summary>
    public Element _LifecycleStatus { get; set; }
    /// <summary>
    /// May be used for progress notes, concerns or other related information that doesn't actually describe the goal itself.
    /// </summary>
    public List<Annotation> Note { get; set; }
    /// <summary>
    /// Note that this should not duplicate the goal status.
    /// </summary>
    public List<CodeableConcept> OutcomeCode { get; set; }
    /// <summary>
    /// The goal outcome is independent of the outcome of the related activities.  For example, if the Goal is to achieve a target body weight of 150 lb and a care plan activity is defined to diet, then the care plan’s activity outcome could be calories consumed whereas goal outcome is an observation for the actual body weight measured.
    /// </summary>
    public List<Reference> OutcomeReference { get; set; }
    /// <summary>
    /// Extensions are available to track priorities as established by each participant (i.e. Priority from the patient's perspective, different practitioners' perspectives, family member's perspectives)
    /// The ordinal extension on Coding can be used to convey a numerically comparable ranking to priority.  (Keep in mind that different coding systems may use a "low value=important".
    /// </summary>
    public CodeableConcept Priority { get; set; }
    /// <summary>
    /// The date or event after which the goal should begin being pursued.
    /// </summary>
    public string StartDate { get; set; }
    /// <summary>
    /// Extension container element for StartDate
    /// </summary>
    public Element _StartDate { get; set; }
    /// <summary>
    /// The date or event after which the goal should begin being pursued.
    /// </summary>
    public CodeableConcept StartCodeableConcept { get; set; }
    /// <summary>
    /// To see the date for past statuses, query history.
    /// </summary>
    public string StatusDate { get; set; }
    /// <summary>
    /// Extension container element for StatusDate
    /// </summary>
    public Element _StatusDate { get; set; }
    /// <summary>
    /// This will typically be captured for statuses such as rejected, on-hold or cancelled, but could be present for others.
    /// </summary>
    public string StatusReason { get; set; }
    /// <summary>
    /// Extension container element for StatusReason
    /// </summary>
    public Element _StatusReason { get; set; }
    /// <summary>
    /// Identifies the patient, group or organization for whom the goal is being established.
    /// </summary>
    public Reference Subject { get; set; }
    /// <summary>
    /// When multiple targets are present for a single goal instance, all targets must be met for the overall goal to be met.
    /// </summary>
    public List<GoalTarget> Target { get; set; }
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


      ((fhirCsR4.Models.DomainResource)this).SerializeJson(writer, options, false);

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

      if (!string.IsNullOrEmpty(LifecycleStatus))
      {
        writer.WriteString("lifecycleStatus", (string)LifecycleStatus!);
      }

      if (_LifecycleStatus != null)
      {
        writer.WritePropertyName("_lifecycleStatus");
        _LifecycleStatus.SerializeJson(writer, options);
      }

      if (AchievementStatus != null)
      {
        writer.WritePropertyName("achievementStatus");
        AchievementStatus.SerializeJson(writer, options);
      }

      if ((Category != null) && (Category.Count != 0))
      {
        writer.WritePropertyName("category");
        writer.WriteStartArray();

        foreach (CodeableConcept valCategory in Category)
        {
          valCategory.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (Priority != null)
      {
        writer.WritePropertyName("priority");
        Priority.SerializeJson(writer, options);
      }

      if (Description != null)
      {
        writer.WritePropertyName("description");
        Description.SerializeJson(writer, options);
      }

      if (Subject != null)
      {
        writer.WritePropertyName("subject");
        Subject.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(StartDate))
      {
        writer.WriteString("startDate", (string)StartDate!);
      }

      if (_StartDate != null)
      {
        writer.WritePropertyName("_startDate");
        _StartDate.SerializeJson(writer, options);
      }

      if (StartCodeableConcept != null)
      {
        writer.WritePropertyName("startCodeableConcept");
        StartCodeableConcept.SerializeJson(writer, options);
      }

      if ((Target != null) && (Target.Count != 0))
      {
        writer.WritePropertyName("target");
        writer.WriteStartArray();

        foreach (GoalTarget valTarget in Target)
        {
          valTarget.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (!string.IsNullOrEmpty(StatusDate))
      {
        writer.WriteString("statusDate", (string)StatusDate!);
      }

      if (_StatusDate != null)
      {
        writer.WritePropertyName("_statusDate");
        _StatusDate.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(StatusReason))
      {
        writer.WriteString("statusReason", (string)StatusReason!);
      }

      if (_StatusReason != null)
      {
        writer.WritePropertyName("_statusReason");
        _StatusReason.SerializeJson(writer, options);
      }

      if (ExpressedBy != null)
      {
        writer.WritePropertyName("expressedBy");
        ExpressedBy.SerializeJson(writer, options);
      }

      if ((Addresses != null) && (Addresses.Count != 0))
      {
        writer.WritePropertyName("addresses");
        writer.WriteStartArray();

        foreach (Reference valAddresses in Addresses)
        {
          valAddresses.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((Note != null) && (Note.Count != 0))
      {
        writer.WritePropertyName("note");
        writer.WriteStartArray();

        foreach (Annotation valNote in Note)
        {
          valNote.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((OutcomeCode != null) && (OutcomeCode.Count != 0))
      {
        writer.WritePropertyName("outcomeCode");
        writer.WriteStartArray();

        foreach (CodeableConcept valOutcomeCode in OutcomeCode)
        {
          valOutcomeCode.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((OutcomeReference != null) && (OutcomeReference.Count != 0))
      {
        writer.WritePropertyName("outcomeReference");
        writer.WriteStartArray();

        foreach (Reference valOutcomeReference in OutcomeReference)
        {
          valOutcomeReference.SerializeJson(writer, options, true);
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
        case "achievementStatus":
          AchievementStatus = new fhirCsR4.Models.CodeableConcept();
          AchievementStatus.DeserializeJson(ref reader, options);
          break;

        case "addresses":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Addresses = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR4.Models.Reference objAddresses = new fhirCsR4.Models.Reference();
            objAddresses.DeserializeJson(ref reader, options);
            Addresses.Add(objAddresses);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Addresses.Count == 0)
          {
            Addresses = null;
          }

          break;

        case "category":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Category = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR4.Models.CodeableConcept objCategory = new fhirCsR4.Models.CodeableConcept();
            objCategory.DeserializeJson(ref reader, options);
            Category.Add(objCategory);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Category.Count == 0)
          {
            Category = null;
          }

          break;

        case "description":
          Description = new fhirCsR4.Models.CodeableConcept();
          Description.DeserializeJson(ref reader, options);
          break;

        case "expressedBy":
          ExpressedBy = new fhirCsR4.Models.Reference();
          ExpressedBy.DeserializeJson(ref reader, options);
          break;

        case "identifier":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Identifier = new List<Identifier>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR4.Models.Identifier objIdentifier = new fhirCsR4.Models.Identifier();
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

        case "lifecycleStatus":
          LifecycleStatus = reader.GetString();
          break;

        case "_lifecycleStatus":
          _LifecycleStatus = new fhirCsR4.Models.Element();
          _LifecycleStatus.DeserializeJson(ref reader, options);
          break;

        case "note":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Note = new List<Annotation>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR4.Models.Annotation objNote = new fhirCsR4.Models.Annotation();
            objNote.DeserializeJson(ref reader, options);
            Note.Add(objNote);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Note.Count == 0)
          {
            Note = null;
          }

          break;

        case "outcomeCode":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          OutcomeCode = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR4.Models.CodeableConcept objOutcomeCode = new fhirCsR4.Models.CodeableConcept();
            objOutcomeCode.DeserializeJson(ref reader, options);
            OutcomeCode.Add(objOutcomeCode);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (OutcomeCode.Count == 0)
          {
            OutcomeCode = null;
          }

          break;

        case "outcomeReference":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          OutcomeReference = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR4.Models.Reference objOutcomeReference = new fhirCsR4.Models.Reference();
            objOutcomeReference.DeserializeJson(ref reader, options);
            OutcomeReference.Add(objOutcomeReference);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (OutcomeReference.Count == 0)
          {
            OutcomeReference = null;
          }

          break;

        case "priority":
          Priority = new fhirCsR4.Models.CodeableConcept();
          Priority.DeserializeJson(ref reader, options);
          break;

        case "startDate":
          StartDate = reader.GetString();
          break;

        case "_startDate":
          _StartDate = new fhirCsR4.Models.Element();
          _StartDate.DeserializeJson(ref reader, options);
          break;

        case "startCodeableConcept":
          StartCodeableConcept = new fhirCsR4.Models.CodeableConcept();
          StartCodeableConcept.DeserializeJson(ref reader, options);
          break;

        case "statusDate":
          StatusDate = reader.GetString();
          break;

        case "_statusDate":
          _StatusDate = new fhirCsR4.Models.Element();
          _StatusDate.DeserializeJson(ref reader, options);
          break;

        case "statusReason":
          StatusReason = reader.GetString();
          break;

        case "_statusReason":
          _StatusReason = new fhirCsR4.Models.Element();
          _StatusReason.DeserializeJson(ref reader, options);
          break;

        case "subject":
          Subject = new fhirCsR4.Models.Reference();
          Subject.DeserializeJson(ref reader, options);
          break;

        case "target":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Target = new List<GoalTarget>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR4.Models.GoalTarget objTarget = new fhirCsR4.Models.GoalTarget();
            objTarget.DeserializeJson(ref reader, options);
            Target.Add(objTarget);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Target.Count == 0)
          {
            Target = null;
          }

          break;

        default:
          ((fhirCsR4.Models.DomainResource)this).DeserializeJsonProperty(ref reader, options, propertyName);
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
  /// Code Values for the Goal.lifecycleStatus field
  /// </summary>
  public static class GoalLifecycleStatusCodes {
    public const string PROPOSED = "proposed";
    public const string PLANNED = "planned";
    public const string ACCEPTED = "accepted";
    public const string ACTIVE = "active";
    public const string ON_HOLD = "on-hold";
    public const string COMPLETED = "completed";
    public const string CANCELLED = "cancelled";
    public const string ENTERED_IN_ERROR = "entered-in-error";
    public const string REJECTED = "rejected";
    public static HashSet<string> Values = new HashSet<string>() {
      "proposed",
      "planned",
      "accepted",
      "active",
      "on-hold",
      "completed",
      "cancelled",
      "entered-in-error",
      "rejected",
    };
  }
}