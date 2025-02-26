﻿// <copyright file="ValueSetReferenceInfo.cs" company="Microsoft Corporation">
//     Copyright (c) Microsoft Corporation. All rights reserved.
//     Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// </copyright>

namespace Microsoft.Health.Fhir.CodeGenCommon.Models;

/// <summary>Information about the value set reference.</summary>
public class ValueSetReferenceInfo
{
    public record struct VsReferenceRec(
        string Path,
        IEnumerable<string> FhirTypes,
        FhirElement.ElementDefinitionBindingStrength BindingStrength);

    private Dictionary<string, FhirElement> _referencingElementsByPath;
    private Dictionary<string, VsReferenceRec> _vsRecsByPath;
    private FhirElement.ElementDefinitionBindingStrength _strongestBinding;

    /// <summary>
    /// Initializes a new instance of the <see cref="ValueSetReferenceInfo"/> class.
    /// </summary>
    public ValueSetReferenceInfo()
    {
        _vsRecsByPath = new();
        _referencingElementsByPath = new();
        _strongestBinding = FhirElement.ElementDefinitionBindingStrength.Example;
    }

    /// <summary>Gets the paths.</summary>
    public Dictionary<string, VsReferenceRec> VsRecsByPath => _vsRecsByPath;

    public Dictionary<string, FhirElement> ReferencingElementsByPath => _referencingElementsByPath;

    /// <summary>Gets the strongest binding.</summary>
    public FhirElement.ElementDefinitionBindingStrength StrongestBinding => _strongestBinding;

    /// <summary>Adds a path and checks for changes to strongest binding level.</summary>
    /// <param name="elementPath">Full pathname of the file.</param>
    /// <param name="strength">   The strength of the value set binding to the given element.</param>
    public void AddPath(
        string elementPath,
        IEnumerable<string> elementTypes,
        FhirElement.ElementDefinitionBindingStrength strength)
    {
        if (!_vsRecsByPath.ContainsKey(elementPath))
        {
            _vsRecsByPath.Add(elementPath, new (elementPath, elementTypes, strength));
        }

        if (strength < _strongestBinding)
        {
            _strongestBinding = (FhirElement.ElementDefinitionBindingStrength)strength;
        }
    }

    public void AddPath(FhirElement element)
    {
        if ((element == null) ||
            string.IsNullOrEmpty(element.Path) ||
            (element.ValueSetBindingStrength == null) ||
            _referencingElementsByPath.ContainsKey(element.Path))
        {
            return;
        }

        FhirElement.ElementDefinitionBindingStrength strength = (FhirElement.ElementDefinitionBindingStrength)element.ValueSetBindingStrength!;

        if (!_vsRecsByPath.ContainsKey(element.Path))
        {
            _vsRecsByPath.Add(
                element.Path,
                new(
                    element.Path,
                    element.ElementTypes.Keys,
                    strength));
        }

        _referencingElementsByPath.Add(element.Path, element);

        if (strength < _strongestBinding)
        {
            _strongestBinding = strength;
        }
    }
}
