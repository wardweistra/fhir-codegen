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
  /// Limited to 'real' people rather than equipment.
  /// </summary>
  [JsonConverter(typeof(fhirCsR3.Serialization.JsonStreamComponentConverter<ProcedurePerformer>))]
  public class ProcedurePerformer : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// The practitioner who was involved in the procedure.
    /// </summary>
    public Reference Actor { get; set; }
    /// <summary>
    /// The organization the device or practitioner was acting on behalf of.
    /// </summary>
    public Reference OnBehalfOf { get; set; }
    /// <summary>
    /// For example: surgeon, anaethetist, endoscopist.
    /// </summary>
    public CodeableConcept Role { get; set; }
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

      if (Role != null)
      {
        writer.WritePropertyName("role");
        Role.SerializeJson(writer, options);
      }

      if (Actor != null)
      {
        writer.WritePropertyName("actor");
        Actor.SerializeJson(writer, options);
      }

      if (OnBehalfOf != null)
      {
        writer.WritePropertyName("onBehalfOf");
        OnBehalfOf.SerializeJson(writer, options);
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
        case "actor":
          Actor = new fhirCsR3.Models.Reference();
          Actor.DeserializeJson(ref reader, options);
          break;

        case "onBehalfOf":
          OnBehalfOf = new fhirCsR3.Models.Reference();
          OnBehalfOf.DeserializeJson(ref reader, options);
          break;

        case "role":
          Role = new fhirCsR3.Models.CodeableConcept();
          Role.DeserializeJson(ref reader, options);
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
  /// A device that is implanted, removed or otherwise manipulated (calibration, battery replacement, fitting a prosthesis, attaching a wound-vac, etc.) as a focal portion of the Procedure.
  /// </summary>
  [JsonConverter(typeof(fhirCsR3.Serialization.JsonStreamComponentConverter<ProcedureFocalDevice>))]
  public class ProcedureFocalDevice : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// The kind of change that happened to the device during the procedure.
    /// </summary>
    public CodeableConcept Action { get; set; }
    /// <summary>
    /// The device that was manipulated (changed) during the procedure.
    /// </summary>
    public Reference Manipulated { get; set; }
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

      if (Action != null)
      {
        writer.WritePropertyName("action");
        Action.SerializeJson(writer, options);
      }

      if (Manipulated != null)
      {
        writer.WritePropertyName("manipulated");
        Manipulated.SerializeJson(writer, options);
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
        case "action":
          Action = new fhirCsR3.Models.CodeableConcept();
          Action.DeserializeJson(ref reader, options);
          break;

        case "manipulated":
          Manipulated = new fhirCsR3.Models.Reference();
          Manipulated.DeserializeJson(ref reader, options);
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
  /// An action that is or was performed on a patient. This can be a physical intervention like an operation, or less invasive like counseling or hypnotherapy.
  /// </summary>
  [JsonConverter(typeof(fhirCsR3.Serialization.JsonStreamComponentConverter<Procedure>))]
  public class Procedure : DomainResource,  IFhirJsonSerializable {
    /// <summary>
    /// Resource Type Name
    /// </summary>
    public override string ResourceType => "Procedure";
    /// <summary>
    /// A reference to a resource that contains details of the request for this procedure.
    /// </summary>
    public List<Reference> BasedOn { get; set; }
    /// <summary>
    /// Detailed and structured anatomical location information. Multiple locations are allowed - e.g. multiple punch biopsies of a lesion.
    /// </summary>
    public List<CodeableConcept> BodySite { get; set; }
    /// <summary>
    /// A code that classifies the procedure for searching, sorting and display purposes (e.g. "Surgical Procedure").
    /// </summary>
    public CodeableConcept Category { get; set; }
    /// <summary>
    /// The specific procedure that is performed. Use text if the exact nature of the procedure cannot be coded (e.g. "Laparoscopic Appendectomy").
    /// </summary>
    public CodeableConcept Code { get; set; }
    /// <summary>
    /// If complications are only expressed by the narrative text, they can be captured using the CodeableConcept.text.
    /// </summary>
    public List<CodeableConcept> Complication { get; set; }
    /// <summary>
    /// Any complications that occurred during the procedure, or in the immediate post-performance period.
    /// </summary>
    public List<Reference> ComplicationDetail { get; set; }
    /// <summary>
    /// The encounter during which the procedure was performed.
    /// </summary>
    public Reference Context { get; set; }
    /// <summary>
    /// A protocol, guideline, orderset or other definition that was adhered to in whole or in part by this procedure.
    /// </summary>
    public List<Reference> Definition { get; set; }
    /// <summary>
    /// A device that is implanted, removed or otherwise manipulated (calibration, battery replacement, fitting a prosthesis, attaching a wound-vac, etc.) as a focal portion of the Procedure.
    /// </summary>
    public List<ProcedureFocalDevice> FocalDevice { get; set; }
    /// <summary>
    /// If the procedure required specific follow up - e.g. removal of sutures. The followup may be represented as a simple note, or could potentially be more complex in which case the CarePlan resource can be used.
    /// </summary>
    public List<CodeableConcept> FollowUp { get; set; }
    /// <summary>
    /// This records identifiers associated with this procedure that are defined by business processes and/or used to refer to it when a direct URL reference to the resource itself is not appropriate (e.g. in CDA documents, or in written / printed documentation).
    /// </summary>
    public List<Identifier> Identifier { get; set; }
    /// <summary>
    /// The location where the procedure actually happened.  E.g. a newborn at home, a tracheostomy at a restaurant.
    /// </summary>
    public Reference Location { get; set; }
    /// <summary>
    /// If true, it means the procedure did not occur as described.  Typically it would be accompanied by attributes describing the type of activity.  It might also be accompanied by body site information or time information (i.e. no procedure was done to the left arm or no procedure was done in this 2-year period).  Specifying additional information such as performer, outcome, etc. is generally inappropriate.  For example, it's not that useful to say "There was no appendectomy done at 12:03pm June 6th by Dr. Smith with a successful outcome" as it implies that there *could* have been an appendectomy done at any other time, by any other clinician or with any other outcome.
    /// This element is labeled as a modifier because it indicates that a procedure didn't happen.
    /// </summary>
    public bool? NotDone { get; set; }
    /// <summary>
    /// Extension container element for NotDone
    /// </summary>
    public Element _NotDone { get; set; }
    /// <summary>
    /// A code indicating why the procedure was not performed.
    /// </summary>
    public CodeableConcept NotDoneReason { get; set; }
    /// <summary>
    /// Any other notes about the procedure.  E.g. the operative notes.
    /// </summary>
    public List<Annotation> Note { get; set; }
    /// <summary>
    /// If outcome contains narrative text only, it can be captured using the CodeableConcept.text.
    /// </summary>
    public CodeableConcept Outcome { get; set; }
    /// <summary>
    /// The MedicationAdministration has a partOf reference to Procedure, but this is not a circular reference.  For a surgical procedure, the anesthesia related medicationAdministration is part of the procedure.  For an IV medication administration,  the procedure to insert the IV port is part of the medication administration.
    /// </summary>
    public List<Reference> PartOf { get; set; }
    /// <summary>
    /// The date(time)/period over which the procedure was performed. Allows a period to support complex procedures that span more than one date, and also allows for the length of the procedure to be captured.
    /// </summary>
    public string PerformedDateTime { get; set; }
    /// <summary>
    /// Extension container element for PerformedDateTime
    /// </summary>
    public Element _PerformedDateTime { get; set; }
    /// <summary>
    /// The date(time)/period over which the procedure was performed. Allows a period to support complex procedures that span more than one date, and also allows for the length of the procedure to be captured.
    /// </summary>
    public Period PerformedPeriod { get; set; }
    /// <summary>
    /// Limited to 'real' people rather than equipment.
    /// </summary>
    public List<ProcedurePerformer> Performer { get; set; }
    /// <summary>
    /// The coded reason why the procedure was performed. This may be coded entity of some type, or may simply be present as text.
    /// </summary>
    public List<CodeableConcept> ReasonCode { get; set; }
    /// <summary>
    /// e.g. endoscopy for dilatation and biopsy, combination diagnosis and therapeutic.
    /// </summary>
    public List<Reference> ReasonReference { get; set; }
    /// <summary>
    /// There could potentially be multiple reports - e.g. if this was a procedure which took multiple biopsies resulting in a number of anatomical pathology reports.
    /// </summary>
    public List<Reference> Report { get; set; }
    /// <summary>
    /// The unknown code is not to be used to convey other statuses.  The unknown code should be used when one of the statuses applies, but the authoring system doesn't know the current state of the procedure.
    /// This element is labeled as a modifier because the status contains codes that mark the resource as not currently valid.
    /// </summary>
    public string Status { get; set; }
    /// <summary>
    /// Extension container element for Status
    /// </summary>
    public Element _Status { get; set; }
    /// <summary>
    /// The person, animal or group on which the procedure was performed.
    /// </summary>
    public Reference Subject { get; set; }
    /// <summary>
    /// For devices actually implanted or removed, use Procedure.device.
    /// </summary>
    public List<CodeableConcept> UsedCode { get; set; }
    /// <summary>
    /// For devices actually implanted or removed, use Procedure.device.
    /// </summary>
    public List<Reference> UsedReference { get; set; }
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

      if ((Definition != null) && (Definition.Count != 0))
      {
        writer.WritePropertyName("definition");
        writer.WriteStartArray();

        foreach (Reference valDefinition in Definition)
        {
          valDefinition.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((BasedOn != null) && (BasedOn.Count != 0))
      {
        writer.WritePropertyName("basedOn");
        writer.WriteStartArray();

        foreach (Reference valBasedOn in BasedOn)
        {
          valBasedOn.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((PartOf != null) && (PartOf.Count != 0))
      {
        writer.WritePropertyName("partOf");
        writer.WriteStartArray();

        foreach (Reference valPartOf in PartOf)
        {
          valPartOf.SerializeJson(writer, options, true);
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

      if (NotDone != null)
      {
        writer.WriteBoolean("notDone", (bool)NotDone!);
      }

      if (_NotDone != null)
      {
        writer.WritePropertyName("_notDone");
        _NotDone.SerializeJson(writer, options);
      }

      if (NotDoneReason != null)
      {
        writer.WritePropertyName("notDoneReason");
        NotDoneReason.SerializeJson(writer, options);
      }

      if (Category != null)
      {
        writer.WritePropertyName("category");
        Category.SerializeJson(writer, options);
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

      if (Context != null)
      {
        writer.WritePropertyName("context");
        Context.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(PerformedDateTime))
      {
        writer.WriteString("performedDateTime", (string)PerformedDateTime!);
      }

      if (_PerformedDateTime != null)
      {
        writer.WritePropertyName("_performedDateTime");
        _PerformedDateTime.SerializeJson(writer, options);
      }

      if (PerformedPeriod != null)
      {
        writer.WritePropertyName("performedPeriod");
        PerformedPeriod.SerializeJson(writer, options);
      }

      if ((Performer != null) && (Performer.Count != 0))
      {
        writer.WritePropertyName("performer");
        writer.WriteStartArray();

        foreach (ProcedurePerformer valPerformer in Performer)
        {
          valPerformer.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (Location != null)
      {
        writer.WritePropertyName("location");
        Location.SerializeJson(writer, options);
      }

      if ((ReasonCode != null) && (ReasonCode.Count != 0))
      {
        writer.WritePropertyName("reasonCode");
        writer.WriteStartArray();

        foreach (CodeableConcept valReasonCode in ReasonCode)
        {
          valReasonCode.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((ReasonReference != null) && (ReasonReference.Count != 0))
      {
        writer.WritePropertyName("reasonReference");
        writer.WriteStartArray();

        foreach (Reference valReasonReference in ReasonReference)
        {
          valReasonReference.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((BodySite != null) && (BodySite.Count != 0))
      {
        writer.WritePropertyName("bodySite");
        writer.WriteStartArray();

        foreach (CodeableConcept valBodySite in BodySite)
        {
          valBodySite.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (Outcome != null)
      {
        writer.WritePropertyName("outcome");
        Outcome.SerializeJson(writer, options);
      }

      if ((Report != null) && (Report.Count != 0))
      {
        writer.WritePropertyName("report");
        writer.WriteStartArray();

        foreach (Reference valReport in Report)
        {
          valReport.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((Complication != null) && (Complication.Count != 0))
      {
        writer.WritePropertyName("complication");
        writer.WriteStartArray();

        foreach (CodeableConcept valComplication in Complication)
        {
          valComplication.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((ComplicationDetail != null) && (ComplicationDetail.Count != 0))
      {
        writer.WritePropertyName("complicationDetail");
        writer.WriteStartArray();

        foreach (Reference valComplicationDetail in ComplicationDetail)
        {
          valComplicationDetail.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((FollowUp != null) && (FollowUp.Count != 0))
      {
        writer.WritePropertyName("followUp");
        writer.WriteStartArray();

        foreach (CodeableConcept valFollowUp in FollowUp)
        {
          valFollowUp.SerializeJson(writer, options, true);
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

      if ((FocalDevice != null) && (FocalDevice.Count != 0))
      {
        writer.WritePropertyName("focalDevice");
        writer.WriteStartArray();

        foreach (ProcedureFocalDevice valFocalDevice in FocalDevice)
        {
          valFocalDevice.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((UsedReference != null) && (UsedReference.Count != 0))
      {
        writer.WritePropertyName("usedReference");
        writer.WriteStartArray();

        foreach (Reference valUsedReference in UsedReference)
        {
          valUsedReference.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((UsedCode != null) && (UsedCode.Count != 0))
      {
        writer.WritePropertyName("usedCode");
        writer.WriteStartArray();

        foreach (CodeableConcept valUsedCode in UsedCode)
        {
          valUsedCode.SerializeJson(writer, options, true);
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
        case "basedOn":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          BasedOn = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR3.Models.Reference objBasedOn = new fhirCsR3.Models.Reference();
            objBasedOn.DeserializeJson(ref reader, options);
            BasedOn.Add(objBasedOn);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (BasedOn.Count == 0)
          {
            BasedOn = null;
          }

          break;

        case "bodySite":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          BodySite = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR3.Models.CodeableConcept objBodySite = new fhirCsR3.Models.CodeableConcept();
            objBodySite.DeserializeJson(ref reader, options);
            BodySite.Add(objBodySite);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (BodySite.Count == 0)
          {
            BodySite = null;
          }

          break;

        case "category":
          Category = new fhirCsR3.Models.CodeableConcept();
          Category.DeserializeJson(ref reader, options);
          break;

        case "code":
          Code = new fhirCsR3.Models.CodeableConcept();
          Code.DeserializeJson(ref reader, options);
          break;

        case "complication":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Complication = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR3.Models.CodeableConcept objComplication = new fhirCsR3.Models.CodeableConcept();
            objComplication.DeserializeJson(ref reader, options);
            Complication.Add(objComplication);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Complication.Count == 0)
          {
            Complication = null;
          }

          break;

        case "complicationDetail":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          ComplicationDetail = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR3.Models.Reference objComplicationDetail = new fhirCsR3.Models.Reference();
            objComplicationDetail.DeserializeJson(ref reader, options);
            ComplicationDetail.Add(objComplicationDetail);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (ComplicationDetail.Count == 0)
          {
            ComplicationDetail = null;
          }

          break;

        case "context":
          Context = new fhirCsR3.Models.Reference();
          Context.DeserializeJson(ref reader, options);
          break;

        case "definition":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Definition = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR3.Models.Reference objDefinition = new fhirCsR3.Models.Reference();
            objDefinition.DeserializeJson(ref reader, options);
            Definition.Add(objDefinition);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Definition.Count == 0)
          {
            Definition = null;
          }

          break;

        case "focalDevice":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          FocalDevice = new List<ProcedureFocalDevice>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR3.Models.ProcedureFocalDevice objFocalDevice = new fhirCsR3.Models.ProcedureFocalDevice();
            objFocalDevice.DeserializeJson(ref reader, options);
            FocalDevice.Add(objFocalDevice);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (FocalDevice.Count == 0)
          {
            FocalDevice = null;
          }

          break;

        case "followUp":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          FollowUp = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR3.Models.CodeableConcept objFollowUp = new fhirCsR3.Models.CodeableConcept();
            objFollowUp.DeserializeJson(ref reader, options);
            FollowUp.Add(objFollowUp);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (FollowUp.Count == 0)
          {
            FollowUp = null;
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

        case "location":
          Location = new fhirCsR3.Models.Reference();
          Location.DeserializeJson(ref reader, options);
          break;

        case "notDone":
          NotDone = reader.GetBoolean();
          break;

        case "_notDone":
          _NotDone = new fhirCsR3.Models.Element();
          _NotDone.DeserializeJson(ref reader, options);
          break;

        case "notDoneReason":
          NotDoneReason = new fhirCsR3.Models.CodeableConcept();
          NotDoneReason.DeserializeJson(ref reader, options);
          break;

        case "note":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Note = new List<Annotation>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR3.Models.Annotation objNote = new fhirCsR3.Models.Annotation();
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

        case "outcome":
          Outcome = new fhirCsR3.Models.CodeableConcept();
          Outcome.DeserializeJson(ref reader, options);
          break;

        case "partOf":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          PartOf = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR3.Models.Reference objPartOf = new fhirCsR3.Models.Reference();
            objPartOf.DeserializeJson(ref reader, options);
            PartOf.Add(objPartOf);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (PartOf.Count == 0)
          {
            PartOf = null;
          }

          break;

        case "performedDateTime":
          PerformedDateTime = reader.GetString();
          break;

        case "_performedDateTime":
          _PerformedDateTime = new fhirCsR3.Models.Element();
          _PerformedDateTime.DeserializeJson(ref reader, options);
          break;

        case "performedPeriod":
          PerformedPeriod = new fhirCsR3.Models.Period();
          PerformedPeriod.DeserializeJson(ref reader, options);
          break;

        case "performer":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Performer = new List<ProcedurePerformer>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR3.Models.ProcedurePerformer objPerformer = new fhirCsR3.Models.ProcedurePerformer();
            objPerformer.DeserializeJson(ref reader, options);
            Performer.Add(objPerformer);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Performer.Count == 0)
          {
            Performer = null;
          }

          break;

        case "reasonCode":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          ReasonCode = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR3.Models.CodeableConcept objReasonCode = new fhirCsR3.Models.CodeableConcept();
            objReasonCode.DeserializeJson(ref reader, options);
            ReasonCode.Add(objReasonCode);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (ReasonCode.Count == 0)
          {
            ReasonCode = null;
          }

          break;

        case "reasonReference":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          ReasonReference = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR3.Models.Reference objReasonReference = new fhirCsR3.Models.Reference();
            objReasonReference.DeserializeJson(ref reader, options);
            ReasonReference.Add(objReasonReference);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (ReasonReference.Count == 0)
          {
            ReasonReference = null;
          }

          break;

        case "report":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Report = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR3.Models.Reference objReport = new fhirCsR3.Models.Reference();
            objReport.DeserializeJson(ref reader, options);
            Report.Add(objReport);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Report.Count == 0)
          {
            Report = null;
          }

          break;

        case "status":
          Status = reader.GetString();
          break;

        case "_status":
          _Status = new fhirCsR3.Models.Element();
          _Status.DeserializeJson(ref reader, options);
          break;

        case "subject":
          Subject = new fhirCsR3.Models.Reference();
          Subject.DeserializeJson(ref reader, options);
          break;

        case "usedCode":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          UsedCode = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR3.Models.CodeableConcept objUsedCode = new fhirCsR3.Models.CodeableConcept();
            objUsedCode.DeserializeJson(ref reader, options);
            UsedCode.Add(objUsedCode);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (UsedCode.Count == 0)
          {
            UsedCode = null;
          }

          break;

        case "usedReference":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          UsedReference = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR3.Models.Reference objUsedReference = new fhirCsR3.Models.Reference();
            objUsedReference.DeserializeJson(ref reader, options);
            UsedReference.Add(objUsedReference);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (UsedReference.Count == 0)
          {
            UsedReference = null;
          }

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
  /// Code Values for the Procedure.status field
  /// </summary>
  public static class ProcedureStatusCodes {
    public const string PREPARATION = "preparation";
    public const string IN_PROGRESS = "in-progress";
    public const string SUSPENDED = "suspended";
    public const string ABORTED = "aborted";
    public const string COMPLETED = "completed";
    public const string ENTERED_IN_ERROR = "entered-in-error";
    public const string UNKNOWN = "unknown";
    public static HashSet<string> Values = new HashSet<string>() {
      "preparation",
      "in-progress",
      "suspended",
      "aborted",
      "completed",
      "entered-in-error",
      "unknown",
    };
  }
}