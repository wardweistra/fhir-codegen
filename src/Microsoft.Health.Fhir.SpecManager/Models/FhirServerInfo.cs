﻿// <copyright file="FhirServerInfo.cs" company="Microsoft Corporation">
//     Copyright (c) Microsoft Corporation. All rights reserved.
//     Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// </copyright>

using fhirCsR2.Models;
using Microsoft.Health.Fhir.CodeGenCommon.Extensions;
using Microsoft.Health.Fhir.SpecManager.Manager;

namespace Microsoft.Health.Fhir.SpecManager.Models;

/// <summary>A FHIR server.</summary>
public class FhirServerInfo
{
    private readonly List<SystemRestfulInteraction> _serverInteractions;
    private readonly FhirPackageCommon.FhirSequenceEnum _fhirMajorVersion;

    /// <summary>Initializes a new instance of the <see cref="FhirServerInfo"/> class.</summary>
    /// <param name="serverInteractions">       The server interaction flags.</param>
    /// <param name="url">                      FHIR Base URL for the server.</param>
    /// <param name="fhirVersion">              The server-reported FHIR version.</param>
    /// <param name="softwareName">             The FHIR Server software name.</param>
    /// <param name="softwareVersion">          The FHIR Server software version.</param>
    /// <param name="softwareReleaseDate">      The FHIR Server software release date.</param>
    /// <param name="implementationDescription">Information describing the implementation.</param>
    /// <param name="implementationUrl">        URL of the implementation.</param>
    /// <param name="instantiates">             Canonical URL of another capability statement this implements.</param>
    /// <param name="implementationGuides">     Implementation guides supported.</param>
    /// <param name="resourceInteractions">     The server interactions by resource.</param>
    /// <param name="serverSearchParameters">   The search parameters for searching all resources.</param>
    /// <param name="serverOperations">         The operations defined at the system level operation.</param>
    public FhirServerInfo(
        List<string> serverInteractions,
        string url,
        string fhirVersion,
        string softwareName,
        string softwareVersion,
        string softwareReleaseDate,
        string implementationDescription,
        string implementationUrl,
        IEnumerable<string> instantiates,
        IEnumerable<string> implementationGuides,
        Dictionary<string, FhirServerResourceInfo> resourceInteractions,
        Dictionary<string, FhirServerSearchParam> serverSearchParameters,
        Dictionary<string, FhirServerOperation> serverOperations)
    {
        Url = url;
        FhirVersion = fhirVersion;

        _fhirMajorVersion = FhirPackageCommon.MajorReleaseForVersion(fhirVersion);

        SoftwareName = softwareName;
        SoftwareVersion = softwareVersion;
        SoftwareReleaseDate = softwareReleaseDate;
        ImplementationDescription = implementationDescription;
        ImplementationUrl = implementationUrl;
        Instantiates = instantiates;
        ImplementationGuides = implementationGuides;
        ResourceInteractions = resourceInteractions;
        ServerSearchParameters = serverSearchParameters;
        ServerOperations = serverOperations;

        _serverInteractions = new List<SystemRestfulInteraction>();

        if (serverInteractions != null)
        {
            foreach (string interaction in serverInteractions)
            {
                _serverInteractions.Add(interaction.ToFhirEnum<SystemRestfulInteraction>());
            }
        }
    }

    /// <summary>Initializes a new instance of the <see cref="FhirServerInfo"/> class.</summary>
    /// <param name="serverInteractions">       The server interaction flags.</param>
    /// <param name="url">                      FHIR Base URL for the server.</param>
    /// <param name="fhirVersion">              The server-reported FHIR version.</param>
    /// <param name="softwareName">             The FHIR Server software name.</param>
    /// <param name="softwareVersion">          The FHIR Server software version.</param>
    /// <param name="softwareReleaseDate">      The FHIR Server software release date.</param>
    /// <param name="implementationDescription">Information describing the implementation.</param>
    /// <param name="implementationUrl">        URL of the implementation.</param>
    /// <param name="resourceInteractions">     The server interactions by resource.</param>
    /// <param name="serverSearchParameters">   The search parameters for searching all resources.</param>
    /// <param name="serverOperations">         The operations defined at the system level operation.</param>
    public FhirServerInfo(
        List<SystemRestfulInteraction> serverInteractions,
        string url,
        string fhirVersion,
        string softwareName,
        string softwareVersion,
        string softwareReleaseDate,
        string implementationDescription,
        string implementationUrl,
        IEnumerable<string> instantiates,
        IEnumerable<string> implementationGuides,
        Dictionary<string, FhirServerResourceInfo> resourceInteractions,
        Dictionary<string, FhirServerSearchParam> serverSearchParameters,
        Dictionary<string, FhirServerOperation> serverOperations)
    {
        Url = url;
        FhirVersion = fhirVersion;

        if (string.IsNullOrEmpty(fhirVersion))
        {
            _fhirMajorVersion = 0;
        }
        else
        {
            _fhirMajorVersion = FhirPackageCommon.MajorReleaseForVersion(fhirVersion);
        }

        SoftwareName = softwareName;
        SoftwareVersion = softwareVersion;
        SoftwareReleaseDate = softwareReleaseDate;
        ImplementationDescription = implementationDescription;
        ImplementationUrl = implementationUrl;
        Instantiates = instantiates;
        ImplementationGuides = implementationGuides;
        ResourceInteractions = resourceInteractions;
        ServerSearchParameters = serverSearchParameters;
        ServerOperations = serverOperations;

        _serverInteractions = serverInteractions;
    }

    /// <summary>Initializes a new instance of the <see cref="FhirServerInfo"/> class.</summary>
    /// <exception cref="ArgumentNullException">Thrown when one or more required arguments are null.</exception>
    /// <param name="source">Source for the.</param>
    /// <param name="info">  The information.</param>
    public FhirServerInfo(FhirServerInfo source, FhirVersionInfo info)
    {
        if (source == null)
        {
            throw new ArgumentNullException(nameof(source));
        }

        Url = source.Url;
        FhirVersion = source.FhirVersion;
        _fhirMajorVersion = source._fhirMajorVersion;

        SoftwareName = source.SoftwareName;
        SoftwareVersion = source.SoftwareVersion;
        SoftwareReleaseDate = source.SoftwareReleaseDate;
        ImplementationDescription = source.ImplementationDescription;
        ImplementationUrl = source.ImplementationUrl;

        Instantiates = source.Instantiates?.ToArray();
        ImplementationGuides = source.ImplementationGuides?.ToArray();

        Dictionary<string, FhirServerResourceInfo> resourceInteractions = new Dictionary<string, FhirServerResourceInfo>();

        foreach (KeyValuePair<string, FhirServerResourceInfo> kvp in source.ResourceInteractions)
        {
            if (!info.Resources.ContainsKey(kvp.Key))
            {
                continue;
            }

            resourceInteractions.Add(kvp.Key, (FhirServerResourceInfo)kvp.Value.Clone());
        }

        _serverInteractions = new List<SystemRestfulInteraction>();
        source.ServerInteractions.ForEach(i => _serverInteractions.Add(i));

        Dictionary<string, FhirServerSearchParam> serverSearchParameters = new Dictionary<string, FhirServerSearchParam>();
        foreach (KeyValuePair<string, FhirServerSearchParam> kvp in source.ServerSearchParameters)
        {
            serverSearchParameters.Add(kvp.Key, (FhirServerSearchParam)kvp.Value.Clone());
        }

        Dictionary<string, FhirServerOperation> serverOperations = new Dictionary<string, FhirServerOperation>();
        foreach (KeyValuePair<string, FhirServerOperation> kvp in source.ServerOperations)
        {
            serverOperations.Add(kvp.Key, (FhirServerOperation)kvp.Value.Clone());
        }

        ResourceInteractions = resourceInteractions;
        ServerSearchParameters = serverSearchParameters;
        ServerOperations = serverOperations;
    }

    /// <summary>Values that represent system restful interactions.</summary>
    public enum SystemRestfulInteraction : int
    {
        /// <summary>Update, create or delete a set of resources as a single transaction.</summary>
        [FhirLiteral("transaction")]
        Transaction,

        /// <summary>Perform a set of a separate interactions in a single http operation.</summary>
        [FhirLiteral("batch")]
        Batch,

        /// <summary>Search all resources based on some filter criteria.</summary>
        [FhirLiteral("search-system")]
        SearchSystem,

        /// <summary>Retrieve the change history for all resources on a system.</summary>
        [FhirLiteral("history-system")]
        HistorySystem,
    }

    /// <summary>Gets FHIR Base URL for the server.</summary>
    public string Url { get; }

    /// <summary>Gets the server-reported FHIR version.</summary>
    public string FhirVersion { get; }

    /// <summary>Gets the major version.</summary>
    public FhirPackageCommon.FhirSequenceEnum MajorVersion => _fhirMajorVersion;

    /// <summary>Gets the FHIR Server software name.</summary>
    public string SoftwareName { get; }

    /// <summary>Gets the FHIR Server software version.</summary>
    public string SoftwareVersion { get; }

    /// <summary>Gets the FHIR Server software release date.</summary>
    public string SoftwareReleaseDate { get; }

    /// <summary>Gets information describing the implementation.</summary>
    public string ImplementationDescription { get; }

    /// <summary>Gets URL of the implementation.</summary>
    public string ImplementationUrl { get; }

    /// <summary>Gets the Canonical URLs of other capability statement this implements.</summary>
    public IEnumerable<string> Instantiates { get; }

    /// <summary>Gets the Implementation guides supported.</summary>
    public IEnumerable<string> ImplementationGuides { get; }

    /// <summary>Gets the server interactions by resource.</summary>
    public Dictionary<string, FhirServerResourceInfo> ResourceInteractions { get; }

    /// <summary>Gets the server interactions.</summary>
    public List<SystemRestfulInteraction> ServerInteractions => _serverInteractions;

    /// <summary>Gets the search parameters for searching all resources.</summary>
    public Dictionary<string, FhirServerSearchParam> ServerSearchParameters { get; }

    /// <summary>Gets the operations defined at the system level operation.</summary>
    public Dictionary<string, FhirServerOperation> ServerOperations { get; }

    public record struct ResolvedCanonical(
        string Canonical,
        FhirArtifactClassEnum ArtifactClass,
        object ResourceObject);

    /// <summary>
    /// Tries to resolve all packages for definitional resources
    /// supported by a server.
    /// </summary>
    /// <returns></returns>
    public bool TryResolveServerPackages()
    {
        if (string.IsNullOrEmpty(FhirVersion))
        {
            return false;
        }

        if (!FhirPackageCommon.TryGetMajorReleaseForVersion(FhirVersion, out FhirPackageCommon.FhirSequenceEnum sequence))
        {
            Console.WriteLine($"Unknown FHIR version on server: {FhirVersion} - cannot process.");
            return false;
        }

        string corePackage = FhirPackageCommon.PackageBaseForRelease(sequence) + ".core";

        if (!FhirManager.Current.HasLoadedPackage(corePackage, out _))
        {
            FhirManager.Current.LoadPackages(
                    new string[] { corePackage + "#latest" } ,
                    false,
                    true,
                    true,
                    false,
                    string.Empty,
                    out _);
        }

        HashSet<string> attempted = new();
        Dictionary<string, ResolvedCanonical> canonicals = new();

        if (ImplementationGuides != null)
        {
            foreach (string ig in ImplementationGuides)
            {
            }
        }

        if (ServerOperations != null)
        {
            foreach (FhirServerOperation serverOp in ServerOperations.Values)
            {
                if (attempted.Contains(serverOp.DefinitionCanonical))
                {
                    continue;
                }

                attempted.Add(serverOp.DefinitionCanonical);

                if (!FhirManager.Current.TryResolveCanonical(sequence, serverOp.DefinitionCanonical, out FhirArtifactClassEnum ac, out _) ||
                    (ac != FhirArtifactClassEnum.Operation))
                {
                    Console.WriteLine(" <<< Failed to resolve canonical: " + serverOp.DefinitionCanonical);
                }
            }
        }

        if (ResourceInteractions != null)
        {
            foreach (FhirServerResourceInfo resourceInteraction in ResourceInteractions.Values)
            {
                if (resourceInteraction.Operations != null)
                {
                    foreach (FhirServerOperation resourceOp in resourceInteraction.Operations.Values)
                    {
                        if (attempted.Contains(resourceOp.DefinitionCanonical))
                        {
                            continue;
                        }

                        attempted.Add(resourceOp.DefinitionCanonical);

                        if (!FhirManager.Current.TryResolveCanonical(sequence, resourceOp.DefinitionCanonical, out FhirArtifactClassEnum ac, out _) ||
                            (ac != FhirArtifactClassEnum.Operation))
                        {
                            Console.WriteLine(" <<< Failed to resolve canonical: " + resourceOp.DefinitionCanonical);
                        }
                    }
                }
            }
        }

        return true;
    }
}
