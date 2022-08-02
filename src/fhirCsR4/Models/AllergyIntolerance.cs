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
  /// Details about each adverse reaction event linked to exposure to the identified substance.
  /// </summary>
  [JsonConverter(typeof(fhirCsR4.Serialization.JsonStreamComponentConverter<AllergyIntoleranceReaction>))]
  public class AllergyIntoleranceReaction : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// Use the description to provide any details of a particular event of the occurred reaction such as circumstances, reaction specifics, what happened before/after. Information, related to the event, but not describing a particular care should be captured in the comment field. For example: at the age of four, the patient was given penicillin for strep throat and subsequently developed severe hives.
    /// </summary>
    public string Description { get; set; }
    /// <summary>
    /// Extension container element for Description
    /// </summary>
    public Element _Description { get; set; }
    /// <summary>
    /// Coding of the route of exposure with a terminology should be used wherever possible.
    /// </summary>
    public CodeableConcept ExposureRoute { get; set; }
    /// <summary>
    /// Manifestation can be expressed as a single word, phrase or brief description. For example: nausea, rash or no reaction. It is preferable that manifestation should be coded with a terminology, where possible. The values entered here may be used to display on an application screen as part of a list of adverse reactions, as recommended in the UK NHS CUI guidelines.  Terminologies commonly used include, but are not limited to, SNOMED CT or ICD10.
    /// </summary>
    public List<CodeableConcept> Manifestation { get; set; }
    /// <summary>
    /// Use this field to record information indirectly related to a particular event and not captured in the description. For example: Clinical records are no longer available, recorded based on information provided to the patient by her mother and her mother is deceased.
    /// </summary>
    public List<Annotation> Note { get; set; }
    /// <summary>
    /// Record of the date and/or time of the onset of the Reaction.
    /// </summary>
    public string Onset { get; set; }
    /// <summary>
    /// Extension container element for Onset
    /// </summary>
    public Element _Onset { get; set; }
    /// <summary>
    /// It is acknowledged that this assessment is very subjective. There may be some specific practice domains where objective scales have been applied. Objective scales can be included in this model as extensions.
    /// </summary>
    public string Severity { get; set; }
    /// <summary>
    /// Extension container element for Severity
    /// </summary>
    public Element _Severity { get; set; }
    /// <summary>
    /// Coding of the specific substance (or pharmaceutical product) with a terminology capable of triggering decision support should be used wherever possible.  The 'code' element allows for the use of a specific substance or pharmaceutical product, or a group or class of substances. In the case of an allergy or intolerance to a class of substances, (for example, "penicillins"), the 'reaction.substance' element could be used to code the specific substance that was identified as having caused the reaction (for example, "amoxycillin"). Duplication of the value in the 'code' and 'reaction.substance' elements is acceptable when a specific substance has been recorded in 'code'.
    /// </summary>
    public CodeableConcept Substance { get; set; }
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

      if (Substance != null)
      {
        writer.WritePropertyName("substance");
        Substance.SerializeJson(writer, options);
      }

      if ((Manifestation != null) && (Manifestation.Count != 0))
      {
        writer.WritePropertyName("manifestation");
        writer.WriteStartArray();

        foreach (CodeableConcept valManifestation in Manifestation)
        {
          valManifestation.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (!string.IsNullOrEmpty(Description))
      {
        writer.WriteString("description", (string)Description!);
      }

      if (_Description != null)
      {
        writer.WritePropertyName("_description");
        _Description.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Onset))
      {
        writer.WriteString("onset", (string)Onset!);
      }

      if (_Onset != null)
      {
        writer.WritePropertyName("_onset");
        _Onset.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Severity))
      {
        writer.WriteString("severity", (string)Severity!);
      }

      if (_Severity != null)
      {
        writer.WritePropertyName("_severity");
        _Severity.SerializeJson(writer, options);
      }

      if (ExposureRoute != null)
      {
        writer.WritePropertyName("exposureRoute");
        ExposureRoute.SerializeJson(writer, options);
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
        case "description":
          Description = reader.GetString();
          break;

        case "_description":
          _Description = new fhirCsR4.Models.Element();
          _Description.DeserializeJson(ref reader, options);
          break;

        case "exposureRoute":
          ExposureRoute = new fhirCsR4.Models.CodeableConcept();
          ExposureRoute.DeserializeJson(ref reader, options);
          break;

        case "manifestation":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Manifestation = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR4.Models.CodeableConcept objManifestation = new fhirCsR4.Models.CodeableConcept();
            objManifestation.DeserializeJson(ref reader, options);
            Manifestation.Add(objManifestation);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Manifestation.Count == 0)
          {
            Manifestation = null;
          }

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

        case "onset":
          Onset = reader.GetString();
          break;

        case "_onset":
          _Onset = new fhirCsR4.Models.Element();
          _Onset.DeserializeJson(ref reader, options);
          break;

        case "severity":
          Severity = reader.GetString();
          break;

        case "_severity":
          _Severity = new fhirCsR4.Models.Element();
          _Severity.DeserializeJson(ref reader, options);
          break;

        case "substance":
          Substance = new fhirCsR4.Models.CodeableConcept();
          Substance.DeserializeJson(ref reader, options);
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
  /// Code Values for the AllergyIntolerance.reaction.severity field
  /// </summary>
  public static class AllergyIntoleranceReactionSeverityCodes {
    public const string MILD = "mild";
    public const string MODERATE = "moderate";
    public const string SEVERE = "severe";
    public static HashSet<string> Values = new HashSet<string>() {
      "mild",
      "moderate",
      "severe",
    };
  }
  /// <summary>
  /// Risk of harmful or undesirable, physiological response which is unique to an individual and associated with exposure to a substance.
  /// </summary>
  [JsonConverter(typeof(fhirCsR4.Serialization.JsonStreamComponentConverter<AllergyIntolerance>))]
  public class AllergyIntolerance : DomainResource,  IFhirJsonSerializable {
    /// <summary>
    /// Resource Type Name
    /// </summary>
    public override string ResourceType => "AllergyIntolerance";
    /// <summary>
    /// The recorder takes responsibility for the content, but can reference the source from where they got it.
    /// </summary>
    public Reference Asserter { get; set; }
    /// <summary>
    /// This data element has been included because it is currently being captured in some clinical systems. This data can be derived from the substance where coding systems are used, and is effectively redundant in that situation.  When searching on category, consider the implications of AllergyIntolerance resources without a category.  For example, when searching on category = medication, medication allergies that don't have a category valued will not be returned.  Refer to [search](search.html) for more information on how to search category with a :missing modifier to get allergies that don't have a category.  Additionally, category should be used with caution because category can be subjective based on the sender.
    /// </summary>
    public List<string> Category { get; set; }
    /// <summary>
    /// Extension container element for Category
    /// </summary>
    public List<Element> _Category { get; set; }
    /// <summary>
    /// Refer to [discussion](extensibility.html#Special-Case) if clincalStatus is missing data.
    /// The data type is CodeableConcept because clinicalStatus has some clinical judgment involved, such that there might need to be more specificity than the required FHIR value set allows. For example, a SNOMED coding might allow for additional specificity.
    /// </summary>
    public CodeableConcept ClinicalStatus { get; set; }
    /// <summary>
    /// It is strongly recommended that this element be populated using a terminology, where possible. For example, some terminologies used include RxNorm, SNOMED CT, DM+D, NDFRT, ICD-9, IDC-10, UNII, and ATC. Plain text should only be used if there is no appropriate terminology available. Additional details can be specified in the text.
    /// When a substance or product code is specified for the 'code' element, the "default" semantic context is that this is a positive statement of an allergy or intolerance (depending on the value of the 'type' element, if present) condition to the specified substance/product.  In the corresponding SNOMED CT allergy model, the specified substance/product is the target (destination) of the "Causative agent" relationship.
    /// The 'substanceExposureRisk' extension is available as a structured and more flexible alternative to the 'code' element for making positive or negative allergy or intolerance statements.  This extension provides the capability to make "no known allergy" (or "no risk of adverse reaction") statements regarding any coded substance/product (including cases when a pre-coordinated "no allergy to x" concept for that substance/product does not exist).  If the 'substanceExposureRisk' extension is present, the AllergyIntolerance.code element SHALL be omitted.
    /// </summary>
    public CodeableConcept Code { get; set; }
    /// <summary>
    /// The default criticality value for any propensity to an adverse reaction should be 'Low Risk', indicating at the very least a relative contraindication to deliberate or voluntary exposure to the substance. 'High Risk' is flagged if the clinician has identified a propensity for a more serious or potentially life-threatening reaction, such as anaphylaxis, and implies an absolute contraindication to deliberate or voluntary exposure to the substance. If this element is missing, the criticality is unknown (though it may be known elsewhere).  Systems that capture a severity at the condition level are actually representing the concept of criticality whereas the severity documented at the reaction level is representing the true reaction severity.  Existing systems that are capturing both condition criticality and reaction severity may use the term "severity" to represent both.  Criticality is the worst it could be in the future (i.e. situation-agnostic) whereas severity is situation-dependent.
    /// </summary>
    public string Criticality { get; set; }
    /// <summary>
    /// Extension container element for Criticality
    /// </summary>
    public Element _Criticality { get; set; }
    /// <summary>
    /// The encounter when the allergy or intolerance was asserted.
    /// </summary>
    public Reference Encounter { get; set; }
    /// <summary>
    /// This is a business identifier, not a resource identifier (see [discussion](resource.html#identifiers)).  It is best practice for the identifier to only appear on a single resource instance, however business practices may occasionally dictate that multiple resource instances with the same identifier can exist - possibly even with different resource types.  For example, multiple Patient and a Person resource instance might share the same social insurance number.
    /// </summary>
    public List<Identifier> Identifier { get; set; }
    /// <summary>
    /// This date may be replicated by one of the Onset of Reaction dates. Where a textual representation of the date of last occurrence is required e.g. 'In Childhood, '10 years ago' the Comment element should be used.
    /// </summary>
    public string LastOccurrence { get; set; }
    /// <summary>
    /// Extension container element for LastOccurrence
    /// </summary>
    public Element _LastOccurrence { get; set; }
    /// <summary>
    /// For example: including reason for flagging a seriousness of 'High Risk'; and instructions related to future exposure or administration of the substance, such as administration within an Intensive Care Unit or under corticosteroid cover. The notes should be related to an allergy or intolerance as a condition in general and not related to any particular episode of it. For episode notes and descriptions, use AllergyIntolerance.event.description and  AllergyIntolerance.event.notes.
    /// </summary>
    public List<Annotation> Note { get; set; }
    /// <summary>
    /// Estimated or actual date,  date-time, or age when allergy or intolerance was identified.
    /// </summary>
    public string OnsetDateTime { get; set; }
    /// <summary>
    /// Extension container element for OnsetDateTime
    /// </summary>
    public Element _OnsetDateTime { get; set; }
    /// <summary>
    /// Estimated or actual date,  date-time, or age when allergy or intolerance was identified.
    /// </summary>
    public Age OnsetAge { get; set; }
    /// <summary>
    /// Estimated or actual date,  date-time, or age when allergy or intolerance was identified.
    /// </summary>
    public Period OnsetPeriod { get; set; }
    /// <summary>
    /// Estimated or actual date,  date-time, or age when allergy or intolerance was identified.
    /// </summary>
    public Range OnsetRange { get; set; }
    /// <summary>
    /// Estimated or actual date,  date-time, or age when allergy or intolerance was identified.
    /// </summary>
    public string OnsetString { get; set; }
    /// <summary>
    /// Extension container element for OnsetString
    /// </summary>
    public Element _OnsetString { get; set; }
    /// <summary>
    /// The patient who has the allergy or intolerance.
    /// </summary>
    public Reference Patient { get; set; }
    /// <summary>
    /// Details about each adverse reaction event linked to exposure to the identified substance.
    /// </summary>
    public List<AllergyIntoleranceReaction> Reaction { get; set; }
    /// <summary>
    /// The recordedDate represents when this particular AllergyIntolerance record was created in the system, which is often a system-generated date.
    /// </summary>
    public string RecordedDate { get; set; }
    /// <summary>
    /// Extension container element for RecordedDate
    /// </summary>
    public Element _RecordedDate { get; set; }
    /// <summary>
    /// Individual who recorded the record and takes responsibility for its content.
    /// </summary>
    public Reference Recorder { get; set; }
    /// <summary>
    /// Allergic (typically immune-mediated) reactions have been traditionally regarded as an indicator for potential escalation to significant future risk. Contemporary knowledge suggests that some reactions previously thought to be immune-mediated are, in fact, non-immune, but in some cases can still pose a life threatening risk. It is acknowledged that many clinicians might not be in a position to distinguish the mechanism of a particular reaction. Often the term "allergy" is used rather generically and may overlap with the use of "intolerance" - in practice the boundaries between these two concepts might not be well-defined or understood. This data element is included nevertheless, because many legacy systems have captured this attribute. Immunologic testing may provide supporting evidence for the basis of the reaction and the causative substance, but no tests are 100% sensitive or specific for sensitivity to a particular substance. If, as is commonly the case, it is unclear whether the reaction is due to an allergy or an intolerance, then the type element should be omitted from the resource.
    /// </summary>
    public string Type { get; set; }
    /// <summary>
    /// Extension container element for Type
    /// </summary>
    public Element _Type { get; set; }
    /// <summary>
    /// The data type is CodeableConcept because verificationStatus has some clinical judgment involved, such that there might need to be more specificity than the required FHIR value set allows. For example, a SNOMED coding might allow for additional specificity.
    /// </summary>
    public CodeableConcept VerificationStatus { get; set; }
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

      if (ClinicalStatus != null)
      {
        writer.WritePropertyName("clinicalStatus");
        ClinicalStatus.SerializeJson(writer, options);
      }

      if (VerificationStatus != null)
      {
        writer.WritePropertyName("verificationStatus");
        VerificationStatus.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Type))
      {
        writer.WriteString("type", (string)Type!);
      }

      if (_Type != null)
      {
        writer.WritePropertyName("_type");
        _Type.SerializeJson(writer, options);
      }

      if ((Category != null) && (Category.Count != 0))
      {
        writer.WritePropertyName("category");
        writer.WriteStartArray();

        foreach (string valCategory in Category)
        {
          writer.WriteStringValue(valCategory);
        }

        writer.WriteEndArray();
      }

      if ((_Category != null) && (_Category.Count != 0))
      {
        writer.WritePropertyName("_category");
        writer.WriteStartArray();

        foreach (Element val_Category in _Category)
        {
          val_Category.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (!string.IsNullOrEmpty(Criticality))
      {
        writer.WriteString("criticality", (string)Criticality!);
      }

      if (_Criticality != null)
      {
        writer.WritePropertyName("_criticality");
        _Criticality.SerializeJson(writer, options);
      }

      if (Code != null)
      {
        writer.WritePropertyName("code");
        Code.SerializeJson(writer, options);
      }

      if (Patient != null)
      {
        writer.WritePropertyName("patient");
        Patient.SerializeJson(writer, options);
      }

      if (Encounter != null)
      {
        writer.WritePropertyName("encounter");
        Encounter.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(OnsetDateTime))
      {
        writer.WriteString("onsetDateTime", (string)OnsetDateTime!);
      }

      if (_OnsetDateTime != null)
      {
        writer.WritePropertyName("_onsetDateTime");
        _OnsetDateTime.SerializeJson(writer, options);
      }

      if (OnsetAge != null)
      {
        writer.WritePropertyName("onsetAge");
        OnsetAge.SerializeJson(writer, options);
      }

      if (OnsetPeriod != null)
      {
        writer.WritePropertyName("onsetPeriod");
        OnsetPeriod.SerializeJson(writer, options);
      }

      if (OnsetRange != null)
      {
        writer.WritePropertyName("onsetRange");
        OnsetRange.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(OnsetString))
      {
        writer.WriteString("onsetString", (string)OnsetString!);
      }

      if (_OnsetString != null)
      {
        writer.WritePropertyName("_onsetString");
        _OnsetString.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(RecordedDate))
      {
        writer.WriteString("recordedDate", (string)RecordedDate!);
      }

      if (_RecordedDate != null)
      {
        writer.WritePropertyName("_recordedDate");
        _RecordedDate.SerializeJson(writer, options);
      }

      if (Recorder != null)
      {
        writer.WritePropertyName("recorder");
        Recorder.SerializeJson(writer, options);
      }

      if (Asserter != null)
      {
        writer.WritePropertyName("asserter");
        Asserter.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(LastOccurrence))
      {
        writer.WriteString("lastOccurrence", (string)LastOccurrence!);
      }

      if (_LastOccurrence != null)
      {
        writer.WritePropertyName("_lastOccurrence");
        _LastOccurrence.SerializeJson(writer, options);
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

      if ((Reaction != null) && (Reaction.Count != 0))
      {
        writer.WritePropertyName("reaction");
        writer.WriteStartArray();

        foreach (AllergyIntoleranceReaction valReaction in Reaction)
        {
          valReaction.SerializeJson(writer, options, true);
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
        case "asserter":
          Asserter = new fhirCsR4.Models.Reference();
          Asserter.DeserializeJson(ref reader, options);
          break;

        case "category":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Category = new List<string>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Category.Add(reader.GetString());

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

        case "_category":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          _Category = new List<Element>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR4.Models.Element obj_Category = new fhirCsR4.Models.Element();
            obj_Category.DeserializeJson(ref reader, options);
            _Category.Add(obj_Category);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (_Category.Count == 0)
          {
            _Category = null;
          }

          break;

        case "clinicalStatus":
          ClinicalStatus = new fhirCsR4.Models.CodeableConcept();
          ClinicalStatus.DeserializeJson(ref reader, options);
          break;

        case "code":
          Code = new fhirCsR4.Models.CodeableConcept();
          Code.DeserializeJson(ref reader, options);
          break;

        case "criticality":
          Criticality = reader.GetString();
          break;

        case "_criticality":
          _Criticality = new fhirCsR4.Models.Element();
          _Criticality.DeserializeJson(ref reader, options);
          break;

        case "encounter":
          Encounter = new fhirCsR4.Models.Reference();
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

        case "lastOccurrence":
          LastOccurrence = reader.GetString();
          break;

        case "_lastOccurrence":
          _LastOccurrence = new fhirCsR4.Models.Element();
          _LastOccurrence.DeserializeJson(ref reader, options);
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

        case "onsetDateTime":
          OnsetDateTime = reader.GetString();
          break;

        case "_onsetDateTime":
          _OnsetDateTime = new fhirCsR4.Models.Element();
          _OnsetDateTime.DeserializeJson(ref reader, options);
          break;

        case "onsetAge":
          OnsetAge = new fhirCsR4.Models.Age();
          OnsetAge.DeserializeJson(ref reader, options);
          break;

        case "onsetPeriod":
          OnsetPeriod = new fhirCsR4.Models.Period();
          OnsetPeriod.DeserializeJson(ref reader, options);
          break;

        case "onsetRange":
          OnsetRange = new fhirCsR4.Models.Range();
          OnsetRange.DeserializeJson(ref reader, options);
          break;

        case "onsetString":
          OnsetString = reader.GetString();
          break;

        case "_onsetString":
          _OnsetString = new fhirCsR4.Models.Element();
          _OnsetString.DeserializeJson(ref reader, options);
          break;

        case "patient":
          Patient = new fhirCsR4.Models.Reference();
          Patient.DeserializeJson(ref reader, options);
          break;

        case "reaction":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Reaction = new List<AllergyIntoleranceReaction>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR4.Models.AllergyIntoleranceReaction objReaction = new fhirCsR4.Models.AllergyIntoleranceReaction();
            objReaction.DeserializeJson(ref reader, options);
            Reaction.Add(objReaction);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Reaction.Count == 0)
          {
            Reaction = null;
          }

          break;

        case "recordedDate":
          RecordedDate = reader.GetString();
          break;

        case "_recordedDate":
          _RecordedDate = new fhirCsR4.Models.Element();
          _RecordedDate.DeserializeJson(ref reader, options);
          break;

        case "recorder":
          Recorder = new fhirCsR4.Models.Reference();
          Recorder.DeserializeJson(ref reader, options);
          break;

        case "type":
          Type = reader.GetString();
          break;

        case "_type":
          _Type = new fhirCsR4.Models.Element();
          _Type.DeserializeJson(ref reader, options);
          break;

        case "verificationStatus":
          VerificationStatus = new fhirCsR4.Models.CodeableConcept();
          VerificationStatus.DeserializeJson(ref reader, options);
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
  /// Code Values for the AllergyIntolerance.category field
  /// </summary>
  public static class AllergyIntoleranceCategoryCodes {
    public const string FOOD = "food";
    public const string MEDICATION = "medication";
    public const string ENVIRONMENT = "environment";
    public const string BIOLOGIC = "biologic";
    public static HashSet<string> Values = new HashSet<string>() {
      "food",
      "medication",
      "environment",
      "biologic",
    };
  }
  /// <summary>
  /// Code Values for the AllergyIntolerance.criticality field
  /// </summary>
  public static class AllergyIntoleranceCriticalityCodes {
    public const string LOW = "low";
    public const string HIGH = "high";
    public const string UNABLE_TO_ASSESS = "unable-to-assess";
    public static HashSet<string> Values = new HashSet<string>() {
      "low",
      "high",
      "unable-to-assess",
    };
  }
  /// <summary>
  /// Code Values for the AllergyIntolerance.type field
  /// </summary>
  public static class AllergyIntoleranceTypeCodes {
    public const string ALLERGY = "allergy";
    public const string INTOLERANCE = "intolerance";
    public static HashSet<string> Values = new HashSet<string>() {
      "allergy",
      "intolerance",
    };
  }
}