// <auto-generated />
// Built from: hl7.fhir.r2.core version: 1.0.2
  // Option: "NAMESPACE" = "fhirCsR2"

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using fhirCsR2.Serialization;

namespace fhirCsR2.Models
{
  /// <summary>
  /// Prospective warnings of potential issues when providing care to the patient.
  /// </summary>
  [JsonConverter(typeof(fhirCsR2.Serialization.JsonStreamComponentConverter<Flag>))]
  public class Flag : DomainResource,  IFhirJsonSerializable {
    /// <summary>
    /// Resource Type Name
    /// </summary>
    public override string ResourceType => "Flag";
    /// <summary>
    /// The person, organization or device that created the flag.
    /// </summary>
    public Reference Author { get; set; }
    /// <summary>
    /// Allows an flag to be divided into different categories like clinical, administrative etc. Intended to be used as a means of filtering which flags are displayed to particular user or in a given context.
    /// </summary>
    public CodeableConcept Category { get; set; }
    /// <summary>
    /// The coded value or textual component of the flag to display to the user.
    /// </summary>
    public CodeableConcept Code { get; set; }
    /// <summary>
    /// This alert is only relevant during the encounter.
    /// </summary>
    public Reference Encounter { get; set; }
    /// <summary>
    /// Identifier assigned to the flag for external use (outside the FHIR environment).
    /// </summary>
    public List<Identifier> Identifier { get; set; }
    /// <summary>
    /// The period of time from the activation of the flag to inactivation of the flag. If the flag is active, the end of the period should be unspecified.
    /// </summary>
    public Period Period { get; set; }
    /// <summary>
    /// Supports basic workflow.
    /// </summary>
    public string Status { get; set; }
    /// <summary>
    /// Extension container element for Status
    /// </summary>
    public Element _Status { get; set; }
    /// <summary>
    /// The patient, location, group , organization , or practitioner this is about record this flag is associated with.
    /// </summary>
    public Reference Subject { get; set; }
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


      ((fhirCsR2.Models.DomainResource)this).SerializeJson(writer, options, false);

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

      if (Category != null)
      {
        writer.WritePropertyName("category");
        Category.SerializeJson(writer, options);
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

      if (Period != null)
      {
        writer.WritePropertyName("period");
        Period.SerializeJson(writer, options);
      }

      if (Subject != null)
      {
        writer.WritePropertyName("subject");
        Subject.SerializeJson(writer, options);
      }

      if (Encounter != null)
      {
        writer.WritePropertyName("encounter");
        Encounter.SerializeJson(writer, options);
      }

      if (Author != null)
      {
        writer.WritePropertyName("author");
        Author.SerializeJson(writer, options);
      }

      if (Code != null)
      {
        writer.WritePropertyName("code");
        Code.SerializeJson(writer, options);
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
        case "author":
          Author = new fhirCsR2.Models.Reference();
          Author.DeserializeJson(ref reader, options);
          break;

        case "category":
          Category = new fhirCsR2.Models.CodeableConcept();
          Category.DeserializeJson(ref reader, options);
          break;

        case "code":
          Code = new fhirCsR2.Models.CodeableConcept();
          Code.DeserializeJson(ref reader, options);
          break;

        case "encounter":
          Encounter = new fhirCsR2.Models.Reference();
          Encounter.DeserializeJson(ref reader, options);
          break;

        case "identifier":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Identifier = new List<Identifier>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR2.Models.Identifier objIdentifier = new fhirCsR2.Models.Identifier();
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

        case "period":
          Period = new fhirCsR2.Models.Period();
          Period.DeserializeJson(ref reader, options);
          break;

        case "status":
          Status = reader.GetString();
          break;

        case "_status":
          _Status = new fhirCsR2.Models.Element();
          _Status.DeserializeJson(ref reader, options);
          break;

        case "subject":
          Subject = new fhirCsR2.Models.Reference();
          Subject.DeserializeJson(ref reader, options);
          break;

        default:
          ((fhirCsR2.Models.DomainResource)this).DeserializeJsonProperty(ref reader, options, propertyName);
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
  /// Code Values for the Flag.status field
  /// </summary>
  public static class FlagStatusCodes {
    public const string ACTIVE = "active";
    public const string INACTIVE = "inactive";
    public const string ENTERED_IN_ERROR = "entered-in-error";
    public static HashSet<string> Values = new HashSet<string>() {
      "active",
      "inactive",
      "entered-in-error",
    };
  }
}
