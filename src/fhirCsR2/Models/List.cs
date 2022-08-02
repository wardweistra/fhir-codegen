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
  /// Entries in this list.
  /// </summary>
  [JsonConverter(typeof(fhirCsR2.Serialization.JsonStreamComponentConverter<ListEntry>))]
  public class ListEntry : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// The date may be significant for understanding the meaning of items in a working list.
    /// </summary>
    public string Date { get; set; }
    /// <summary>
    /// Extension container element for Date
    /// </summary>
    public Element _Date { get; set; }
    /// <summary>
    /// The flag element may contain codes that an application processing the list does not understand. However there can be no ambiguity if a list item is actually marked as "deleted".
    /// </summary>
    public bool? Deleted { get; set; }
    /// <summary>
    /// Extension container element for Deleted
    /// </summary>
    public Element _Deleted { get; set; }
    /// <summary>
    /// This field is present to support various clinical uses of lists, such as a discharge summary medication list, where flags specify whether the medication was added, modified, or deleted from the list.
    /// </summary>
    public CodeableConcept Flag { get; set; }
    /// <summary>
    /// A reference to the actual resource from which data was derived.
    /// </summary>
    public Reference Item { get; set; }
    /// <summary>
    /// Serialize to a JSON object
    /// </summary>
    public new void SerializeJson(Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject)
      {
        writer.WriteStartObject();
      }
      ((fhirCsR2.Models.BackboneElement)this).SerializeJson(writer, options, false);

      if (Flag != null)
      {
        writer.WritePropertyName("flag");
        Flag.SerializeJson(writer, options);
      }

      if (Deleted != null)
      {
        writer.WriteBoolean("deleted", (bool)Deleted!);
      }

      if (_Deleted != null)
      {
        writer.WritePropertyName("_deleted");
        _Deleted.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Date))
      {
        writer.WriteString("date", (string)Date!);
      }

      if (_Date != null)
      {
        writer.WritePropertyName("_date");
        _Date.SerializeJson(writer, options);
      }

      if (Item != null)
      {
        writer.WritePropertyName("item");
        Item.SerializeJson(writer, options);
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
        case "date":
          Date = reader.GetString();
          break;

        case "_date":
          _Date = new fhirCsR2.Models.Element();
          _Date.DeserializeJson(ref reader, options);
          break;

        case "deleted":
          Deleted = reader.GetBoolean();
          break;

        case "_deleted":
          _Deleted = new fhirCsR2.Models.Element();
          _Deleted.DeserializeJson(ref reader, options);
          break;

        case "flag":
          Flag = new fhirCsR2.Models.CodeableConcept();
          Flag.DeserializeJson(ref reader, options);
          break;

        case "item":
          Item = new fhirCsR2.Models.Reference();
          Item.DeserializeJson(ref reader, options);
          break;

        default:
          ((fhirCsR2.Models.BackboneElement)this).DeserializeJsonProperty(ref reader, options, propertyName);
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
  /// A set of information summarized from a list of other resources.
  /// </summary>
  [JsonConverter(typeof(fhirCsR2.Serialization.JsonStreamComponentConverter<List>))]
  public class List : DomainResource,  IFhirJsonSerializable {
    /// <summary>
    /// Resource Type Name
    /// </summary>
    public override string ResourceType => "List";
    /// <summary>
    /// Lists often contain subsets of resources rather than an exhaustive list.  The code identifies what type of subset is included.
    /// </summary>
    public CodeableConcept Code { get; set; }
    /// <summary>
    /// Identifies how current the list is which affects relevance.
    /// </summary>
    public string Date { get; set; }
    /// <summary>
    /// Extension container element for Date
    /// </summary>
    public Element _Date { get; set; }
    /// <summary>
    /// Allows capturing things like "none exist" or "not asked" which can be important for most lists.
    /// </summary>
    public CodeableConcept EmptyReason { get; set; }
    /// <summary>
    /// The encounter that is the context in which this list was created.
    /// </summary>
    public Reference Encounter { get; set; }
    /// <summary>
    /// Entries in this list.
    /// </summary>
    public List<ListEntry> Entry { get; set; }
    /// <summary>
    /// Identifier for the List assigned for business purposes outside the context of FHIR.
    /// </summary>
    public List<Identifier> Identifier { get; set; }
    /// <summary>
    /// Lists are used in various ways, and it must be known in what way it is safe to use them.
    /// </summary>
    public string Mode { get; set; }
    /// <summary>
    /// Extension container element for Mode
    /// </summary>
    public Element _Mode { get; set; }
    /// <summary>
    /// Comments that apply to the overall list.
    /// </summary>
    public string Note { get; set; }
    /// <summary>
    /// Extension container element for Note
    /// </summary>
    public Element _Note { get; set; }
    /// <summary>
    /// Important for presentation and rendering.  Lists may be sorted to place more important information first or to group related entries.
    /// </summary>
    public CodeableConcept OrderedBy { get; set; }
    /// <summary>
    /// Allows follow-up as well as context.
    /// </summary>
    public Reference Source { get; set; }
    /// <summary>
    /// Indicates the current state of this list.
    /// </summary>
    public string Status { get; set; }
    /// <summary>
    /// Extension container element for Status
    /// </summary>
    public Element _Status { get; set; }
    /// <summary>
    /// The primary purpose of listing the subject explicitly is to help with finding the right list.
    /// </summary>
    public Reference Subject { get; set; }
    /// <summary>
    /// Allows customization beyond just the code identifying the kind of list.
    /// </summary>
    public string Title { get; set; }
    /// <summary>
    /// Extension container element for Title
    /// </summary>
    public Element _Title { get; set; }
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

      if (!string.IsNullOrEmpty(Title))
      {
        writer.WriteString("title", (string)Title!);
      }

      if (_Title != null)
      {
        writer.WritePropertyName("_title");
        _Title.SerializeJson(writer, options);
      }

      if (Code != null)
      {
        writer.WritePropertyName("code");
        Code.SerializeJson(writer, options);
      }

      if (Subject != null)
      {
        writer.WritePropertyName("subject");
        Subject.SerializeJson(writer, options);
      }

      if (Source != null)
      {
        writer.WritePropertyName("source");
        Source.SerializeJson(writer, options);
      }

      if (Encounter != null)
      {
        writer.WritePropertyName("encounter");
        Encounter.SerializeJson(writer, options);
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

      if (!string.IsNullOrEmpty(Date))
      {
        writer.WriteString("date", (string)Date!);
      }

      if (_Date != null)
      {
        writer.WritePropertyName("_date");
        _Date.SerializeJson(writer, options);
      }

      if (OrderedBy != null)
      {
        writer.WritePropertyName("orderedBy");
        OrderedBy.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Mode))
      {
        writer.WriteString("mode", (string)Mode!);
      }

      if (_Mode != null)
      {
        writer.WritePropertyName("_mode");
        _Mode.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Note))
      {
        writer.WriteString("note", (string)Note!);
      }

      if (_Note != null)
      {
        writer.WritePropertyName("_note");
        _Note.SerializeJson(writer, options);
      }

      if ((Entry != null) && (Entry.Count != 0))
      {
        writer.WritePropertyName("entry");
        writer.WriteStartArray();

        foreach (ListEntry valEntry in Entry)
        {
          valEntry.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (EmptyReason != null)
      {
        writer.WritePropertyName("emptyReason");
        EmptyReason.SerializeJson(writer, options);
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
        case "code":
          Code = new fhirCsR2.Models.CodeableConcept();
          Code.DeserializeJson(ref reader, options);
          break;

        case "date":
          Date = reader.GetString();
          break;

        case "_date":
          _Date = new fhirCsR2.Models.Element();
          _Date.DeserializeJson(ref reader, options);
          break;

        case "emptyReason":
          EmptyReason = new fhirCsR2.Models.CodeableConcept();
          EmptyReason.DeserializeJson(ref reader, options);
          break;

        case "encounter":
          Encounter = new fhirCsR2.Models.Reference();
          Encounter.DeserializeJson(ref reader, options);
          break;

        case "entry":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Entry = new List<ListEntry>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR2.Models.ListEntry objEntry = new fhirCsR2.Models.ListEntry();
            objEntry.DeserializeJson(ref reader, options);
            Entry.Add(objEntry);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Entry.Count == 0)
          {
            Entry = null;
          }

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

        case "mode":
          Mode = reader.GetString();
          break;

        case "_mode":
          _Mode = new fhirCsR2.Models.Element();
          _Mode.DeserializeJson(ref reader, options);
          break;

        case "note":
          Note = reader.GetString();
          break;

        case "_note":
          _Note = new fhirCsR2.Models.Element();
          _Note.DeserializeJson(ref reader, options);
          break;

        case "orderedBy":
          OrderedBy = new fhirCsR2.Models.CodeableConcept();
          OrderedBy.DeserializeJson(ref reader, options);
          break;

        case "source":
          Source = new fhirCsR2.Models.Reference();
          Source.DeserializeJson(ref reader, options);
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

        case "title":
          Title = reader.GetString();
          break;

        case "_title":
          _Title = new fhirCsR2.Models.Element();
          _Title.DeserializeJson(ref reader, options);
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
  /// Code Values for the List.mode field
  /// </summary>
  public static class ListModeCodes {
    public const string WORKING = "working";
    public const string SNAPSHOT = "snapshot";
    public const string CHANGES = "changes";
    public static HashSet<string> Values = new HashSet<string>() {
      "working",
      "snapshot",
      "changes",
    };
  }
  /// <summary>
  /// Code Values for the List.status field
  /// </summary>
  public static class ListStatusCodes {
    public const string CURRENT = "current";
    public const string RETIRED = "retired";
    public const string ENTERED_IN_ERROR = "entered-in-error";
    public static HashSet<string> Values = new HashSet<string>() {
      "current",
      "retired",
      "entered-in-error",
    };
  }
}