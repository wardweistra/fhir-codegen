// <auto-generated/>
// Contents of: hl7.fhir.r4.core version: 4.0.1

using System;
using System.Buffers;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using Hl7.Fhir.Model;
using Hl7.Fhir.Model.JsonExtensions;
using Hl7.Fhir.Serialization;

/*
  Copyright (c) 2011+, HL7, Inc.
  All rights reserved.
  
  Redistribution and use in source and binary forms, with or without modification, 
  are permitted provided that the following conditions are met:
  
   * Redistributions of source code must retain the above copyright notice, this 
     list of conditions and the following disclaimer.
   * Redistributions in binary form must reproduce the above copyright notice, 
     this list of conditions and the following disclaimer in the documentation 
     and/or other materials provided with the distribution.
   * Neither the name of HL7 nor the names of its contributors may be used to 
     endorse or promote products derived from this software without specific 
     prior written permission.
  
  THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND 
  ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED 
  WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. 
  IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, 
  INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT 
  NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR 
  PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, 
  WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) 
  ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE 
  POSSIBILITY OF SUCH DAMAGE.
  
*/

namespace Hl7.Fhir.Model.JsonExtensions
{
  /// <summary>
  /// JSON Serialization Extensions for GuidanceResponse
  /// </summary>
  public static class GuidanceResponseJsonExtensions
  {
    /// <summary>
    /// Serialize a FHIR GuidanceResponse into JSON
    /// </summary>
    public static void SerializeJson(this GuidanceResponse current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      writer.WriteString("resourceType","GuidanceResponse");
      // Complex: GuidanceResponse, Export: GuidanceResponse, Base: DomainResource (DomainResource)
      ((Hl7.Fhir.Model.DomainResource)current).SerializeJson(writer, options, false);

      if (current.RequestIdentifier != null)
      {
        writer.WritePropertyName("requestIdentifier");
        current.RequestIdentifier.SerializeJson(writer, options);
      }

      if ((current.Identifier != null) && (current.Identifier.Count != 0))
      {
        writer.WritePropertyName("identifier");
        writer.WriteStartArray();
        foreach (Identifier val in current.Identifier)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if (current.Module != null)
      {
        switch (current.Module)
        {
          case FhirUri v_FhirUri:
            writer.WriteString("moduleUri",v_FhirUri.Value);
            break;
          case Canonical v_Canonical:
            writer.WriteString("moduleCanonical",v_Canonical.Value);
            break;
          case CodeableConcept v_CodeableConcept:
            writer.WritePropertyName("moduleCodeableConcept");
            v_CodeableConcept.SerializeJson(writer, options);
            break;
        }
      }
      writer.WriteString("status",Hl7.Fhir.Utility.EnumUtility.GetLiteral(current.StatusElement.Value));

      if (current.Subject != null)
      {
        writer.WritePropertyName("subject");
        current.Subject.SerializeJson(writer, options);
      }

      if (current.Encounter != null)
      {
        writer.WritePropertyName("encounter");
        current.Encounter.SerializeJson(writer, options);
      }

      if (current.OccurrenceDateTimeElement != null)
      {
        if (!string.IsNullOrEmpty(current.OccurrenceDateTimeElement.Value))
        {
          writer.WriteString("occurrenceDateTime",current.OccurrenceDateTimeElement.Value);
        }
        if (current.OccurrenceDateTimeElement.HasExtensions() || (!string.IsNullOrEmpty(current.OccurrenceDateTimeElement.ElementId)))
        {
          JsonStreamUtilities.SerializeExtensionList(writer,options,"_occurrenceDateTime",false,current.OccurrenceDateTimeElement.Extension,current.OccurrenceDateTimeElement.ElementId);
        }
      }

      if (current.Performer != null)
      {
        writer.WritePropertyName("performer");
        current.Performer.SerializeJson(writer, options);
      }

      if ((current.ReasonCode != null) && (current.ReasonCode.Count != 0))
      {
        writer.WritePropertyName("reasonCode");
        writer.WriteStartArray();
        foreach (CodeableConcept val in current.ReasonCode)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.ReasonReference != null) && (current.ReasonReference.Count != 0))
      {
        writer.WritePropertyName("reasonReference");
        writer.WriteStartArray();
        foreach (ResourceReference val in current.ReasonReference)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.Note != null) && (current.Note.Count != 0))
      {
        writer.WritePropertyName("note");
        writer.WriteStartArray();
        foreach (Annotation val in current.Note)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.EvaluationMessage != null) && (current.EvaluationMessage.Count != 0))
      {
        writer.WritePropertyName("evaluationMessage");
        writer.WriteStartArray();
        foreach (ResourceReference val in current.EvaluationMessage)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if (current.OutputParameters != null)
      {
        writer.WritePropertyName("outputParameters");
        current.OutputParameters.SerializeJson(writer, options);
      }

      if (current.Result != null)
      {
        writer.WritePropertyName("result");
        current.Result.SerializeJson(writer, options);
      }

      if ((current.DataRequirement != null) && (current.DataRequirement.Count != 0))
      {
        writer.WritePropertyName("dataRequirement");
        writer.WriteStartArray();
        foreach (DataRequirement val in current.DataRequirement)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR GuidanceResponse
    /// </summary>
    public static void DeserializeJson(this GuidanceResponse current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
          if (Hl7.Fhir.Serialization.FhirSerializerOptions.Debug) { Console.WriteLine($"GuidanceResponse >>> GuidanceResponse.{propertyName}, depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}"); }
          reader.Read();
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException($"GuidanceResponse: invalid state! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
    }

    /// <summary>
    /// Deserialize JSON into a FHIR GuidanceResponse
    /// </summary>
    public static void DeserializeJsonProperty(this GuidanceResponse current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "requestIdentifier":
          current.RequestIdentifier = new Hl7.Fhir.Model.Identifier();
          ((Hl7.Fhir.Model.Identifier)current.RequestIdentifier).DeserializeJson(ref reader, options);
          break;

        case "identifier":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"GuidanceResponse error reading 'identifier' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Identifier = new List<Identifier>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.Identifier v_Identifier = new Hl7.Fhir.Model.Identifier();
            v_Identifier.DeserializeJson(ref reader, options);
            current.Identifier.Add(v_Identifier);

            if (!reader.Read())
            {
              throw new JsonException($"GuidanceResponse error reading 'identifier' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Identifier.Count == 0)
          {
            current.Identifier = null;
          }
          break;

        case "moduleUri":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.Module = new FhirUri();
            reader.Skip();
          }
          else
          {
            current.Module = new FhirUri(reader.GetString());
          }
          break;

        case "_moduleUri":
          if (current.Module == null) { current.Module = new FhirUri(); }
          ((Hl7.Fhir.Model.Element)current.Module).DeserializeJson(ref reader, options);
          break;

        case "moduleCanonical":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.Module = new Canonical();
            reader.Skip();
          }
          else
          {
            current.Module = new Canonical(reader.GetString());
          }
          break;

        case "_moduleCanonical":
          if (current.Module == null) { current.Module = new Canonical(); }
          ((Hl7.Fhir.Model.Element)current.Module).DeserializeJson(ref reader, options);
          break;

        case "moduleCodeableConcept":
          current.Module = new Hl7.Fhir.Model.CodeableConcept();
          ((Hl7.Fhir.Model.CodeableConcept)current.Module).DeserializeJson(ref reader, options);
          break;

        case "status":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.StatusElement = new Code<Hl7.Fhir.Model.GuidanceResponse.GuidanceResponseStatus>();
            reader.Skip();
          }
          else
          {
            current.StatusElement = new Code<Hl7.Fhir.Model.GuidanceResponse.GuidanceResponseStatus>(Hl7.Fhir.Utility.EnumUtility.ParseLiteral<Hl7.Fhir.Model.GuidanceResponse.GuidanceResponseStatus>(reader.GetString()));
          }
          break;

        case "_status":
          if (current.StatusElement == null) { current.StatusElement = new Code<Hl7.Fhir.Model.GuidanceResponse.GuidanceResponseStatus>(); }
          ((Hl7.Fhir.Model.Element)current.StatusElement).DeserializeJson(ref reader, options);
          break;

        case "subject":
          current.Subject = new Hl7.Fhir.Model.ResourceReference();
          ((Hl7.Fhir.Model.ResourceReference)current.Subject).DeserializeJson(ref reader, options);
          break;

        case "encounter":
          current.Encounter = new Hl7.Fhir.Model.ResourceReference();
          ((Hl7.Fhir.Model.ResourceReference)current.Encounter).DeserializeJson(ref reader, options);
          break;

        case "occurrenceDateTime":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.OccurrenceDateTimeElement = new FhirDateTime();
            reader.Skip();
          }
          else
          {
            current.OccurrenceDateTimeElement = new FhirDateTime(reader.GetString());
          }
          break;

        case "_occurrenceDateTime":
          if (current.OccurrenceDateTimeElement == null) { current.OccurrenceDateTimeElement = new FhirDateTime(); }
          ((Hl7.Fhir.Model.Element)current.OccurrenceDateTimeElement).DeserializeJson(ref reader, options);
          break;

        case "performer":
          current.Performer = new Hl7.Fhir.Model.ResourceReference();
          ((Hl7.Fhir.Model.ResourceReference)current.Performer).DeserializeJson(ref reader, options);
          break;

        case "reasonCode":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"GuidanceResponse error reading 'reasonCode' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.ReasonCode = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.CodeableConcept v_ReasonCode = new Hl7.Fhir.Model.CodeableConcept();
            v_ReasonCode.DeserializeJson(ref reader, options);
            current.ReasonCode.Add(v_ReasonCode);

            if (!reader.Read())
            {
              throw new JsonException($"GuidanceResponse error reading 'reasonCode' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.ReasonCode.Count == 0)
          {
            current.ReasonCode = null;
          }
          break;

        case "reasonReference":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"GuidanceResponse error reading 'reasonReference' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.ReasonReference = new List<ResourceReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.ResourceReference v_ReasonReference = new Hl7.Fhir.Model.ResourceReference();
            v_ReasonReference.DeserializeJson(ref reader, options);
            current.ReasonReference.Add(v_ReasonReference);

            if (!reader.Read())
            {
              throw new JsonException($"GuidanceResponse error reading 'reasonReference' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.ReasonReference.Count == 0)
          {
            current.ReasonReference = null;
          }
          break;

        case "note":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"GuidanceResponse error reading 'note' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Note = new List<Annotation>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.Annotation v_Note = new Hl7.Fhir.Model.Annotation();
            v_Note.DeserializeJson(ref reader, options);
            current.Note.Add(v_Note);

            if (!reader.Read())
            {
              throw new JsonException($"GuidanceResponse error reading 'note' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Note.Count == 0)
          {
            current.Note = null;
          }
          break;

        case "evaluationMessage":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"GuidanceResponse error reading 'evaluationMessage' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.EvaluationMessage = new List<ResourceReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.ResourceReference v_EvaluationMessage = new Hl7.Fhir.Model.ResourceReference();
            v_EvaluationMessage.DeserializeJson(ref reader, options);
            current.EvaluationMessage.Add(v_EvaluationMessage);

            if (!reader.Read())
            {
              throw new JsonException($"GuidanceResponse error reading 'evaluationMessage' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.EvaluationMessage.Count == 0)
          {
            current.EvaluationMessage = null;
          }
          break;

        case "outputParameters":
          current.OutputParameters = new Hl7.Fhir.Model.ResourceReference();
          ((Hl7.Fhir.Model.ResourceReference)current.OutputParameters).DeserializeJson(ref reader, options);
          break;

        case "result":
          current.Result = new Hl7.Fhir.Model.ResourceReference();
          ((Hl7.Fhir.Model.ResourceReference)current.Result).DeserializeJson(ref reader, options);
          break;

        case "dataRequirement":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"GuidanceResponse error reading 'dataRequirement' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.DataRequirement = new List<DataRequirement>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.DataRequirement v_DataRequirement = new Hl7.Fhir.Model.DataRequirement();
            v_DataRequirement.DeserializeJson(ref reader, options);
            current.DataRequirement.Add(v_DataRequirement);

            if (!reader.Read())
            {
              throw new JsonException($"GuidanceResponse error reading 'dataRequirement' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.DataRequirement.Count == 0)
          {
            current.DataRequirement = null;
          }
          break;

        // Complex: GuidanceResponse, Export: GuidanceResponse, Base: DomainResource
        default:
          ((Hl7.Fhir.Model.DomainResource)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Resource converter to support Sytem.Text.Json interop.
    /// </summary>
    public class GuidanceResponseJsonConverter : JsonConverter<GuidanceResponse>
    {
      /// <summary>
      /// Writes a specified value as JSON.
      /// </summary>
      public override void Write(Utf8JsonWriter writer, GuidanceResponse value, JsonSerializerOptions options)
      {
        value.SerializeJson(writer, options, true);
        writer.Flush();
      }
      /// <summary>
      /// Reads and converts the JSON to a typed object.
      /// </summary>
      public override GuidanceResponse Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
      {
        GuidanceResponse target = new GuidanceResponse();
        target.DeserializeJson(ref reader, options);
        return target;
      }
    }
  }

}

// end of file