// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// Substance category codes
  /// </summary>
  public static class SubstanceCategoryCodes
  {
    /// <summary>
    /// A substance that causes an allergic reaction.
    /// </summary>
    public static readonly Coding Allergen = new Coding
    {
      Code = "allergen",
      Display = "Allergen",
      System = "http://terminology.hl7.org/CodeSystem/substance-category"
    };
    /// <summary>
    /// A substance that is produced by or extracted from a biological source.
    /// </summary>
    public static readonly Coding BiologicalSubstance = new Coding
    {
      Code = "biological",
      Display = "Biological Substance",
      System = "http://terminology.hl7.org/CodeSystem/substance-category"
    };
    /// <summary>
    /// A substance that comes directly from a human or an animal (e.g. blood, urine, feces, tears, etc.).
    /// </summary>
    public static readonly Coding BodySubstance = new Coding
    {
      Code = "body",
      Display = "Body Substance",
      System = "http://terminology.hl7.org/CodeSystem/substance-category"
    };
    /// <summary>
    /// Any organic or inorganic substance of a particular molecular identity, including -- (i) any combination of such substances occurring in whole or in part as a result of a chemical reaction or occurring in nature and (ii) any element or uncombined radical (http://www.epa.gov/opptintr/import-export/pubs/importguide.pdf).
    /// </summary>
    public static readonly Coding Chemical = new Coding
    {
      Code = "chemical",
      Display = "Chemical",
      System = "http://terminology.hl7.org/CodeSystem/substance-category"
    };
    /// <summary>
    /// A substance intended for use in the diagnosis, cure, mitigation, treatment, or prevention of disease in man or other animals (Federal Food Drug and Cosmetic Act).
    /// </summary>
    public static readonly Coding DrugOrMedicament = new Coding
    {
      Code = "drug",
      Display = "Drug or Medicament",
      System = "http://terminology.hl7.org/CodeSystem/substance-category"
    };
    /// <summary>
    /// A food, dietary ingredient, or dietary supplement for human or animal.
    /// </summary>
    public static readonly Coding DietarySubstance = new Coding
    {
      Code = "food",
      Display = "Dietary Substance",
      System = "http://terminology.hl7.org/CodeSystem/substance-category"
    };
    /// <summary>
    /// A finished product which is not normally ingested, absorbed or injected (e.g. steel, iron, wood, plastic and paper).
    /// </summary>
    public static readonly Coding Material = new Coding
    {
      Code = "material",
      Display = "Material",
      System = "http://terminology.hl7.org/CodeSystem/substance-category"
    };

    /// <summary>
    /// Literal for code: Allergen
    /// </summary>
    public const string LiteralAllergen = "allergen";

    /// <summary>
    /// Literal for code: SubstanceCategoryAllergen
    /// </summary>
    public const string LiteralSubstanceCategoryAllergen = "http://terminology.hl7.org/CodeSystem/substance-category#allergen";

    /// <summary>
    /// Literal for code: BiologicalSubstance
    /// </summary>
    public const string LiteralBiologicalSubstance = "biological";

    /// <summary>
    /// Literal for code: SubstanceCategoryBiologicalSubstance
    /// </summary>
    public const string LiteralSubstanceCategoryBiologicalSubstance = "http://terminology.hl7.org/CodeSystem/substance-category#biological";

    /// <summary>
    /// Literal for code: BodySubstance
    /// </summary>
    public const string LiteralBodySubstance = "body";

    /// <summary>
    /// Literal for code: SubstanceCategoryBodySubstance
    /// </summary>
    public const string LiteralSubstanceCategoryBodySubstance = "http://terminology.hl7.org/CodeSystem/substance-category#body";

    /// <summary>
    /// Literal for code: Chemical
    /// </summary>
    public const string LiteralChemical = "chemical";

    /// <summary>
    /// Literal for code: SubstanceCategoryChemical
    /// </summary>
    public const string LiteralSubstanceCategoryChemical = "http://terminology.hl7.org/CodeSystem/substance-category#chemical";

    /// <summary>
    /// Literal for code: DrugOrMedicament
    /// </summary>
    public const string LiteralDrugOrMedicament = "drug";

    /// <summary>
    /// Literal for code: SubstanceCategoryDrugOrMedicament
    /// </summary>
    public const string LiteralSubstanceCategoryDrugOrMedicament = "http://terminology.hl7.org/CodeSystem/substance-category#drug";

    /// <summary>
    /// Literal for code: DietarySubstance
    /// </summary>
    public const string LiteralDietarySubstance = "food";

    /// <summary>
    /// Literal for code: SubstanceCategoryDietarySubstance
    /// </summary>
    public const string LiteralSubstanceCategoryDietarySubstance = "http://terminology.hl7.org/CodeSystem/substance-category#food";

    /// <summary>
    /// Literal for code: Material
    /// </summary>
    public const string LiteralMaterial = "material";

    /// <summary>
    /// Literal for code: SubstanceCategoryMaterial
    /// </summary>
    public const string LiteralSubstanceCategoryMaterial = "http://terminology.hl7.org/CodeSystem/substance-category#material";

    /// <summary>
    /// Dictionary for looking up SubstanceCategory Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "allergen", Allergen }, 
      { "http://terminology.hl7.org/CodeSystem/substance-category#allergen", Allergen }, 
      { "biological", BiologicalSubstance }, 
      { "http://terminology.hl7.org/CodeSystem/substance-category#biological", BiologicalSubstance }, 
      { "body", BodySubstance }, 
      { "http://terminology.hl7.org/CodeSystem/substance-category#body", BodySubstance }, 
      { "chemical", Chemical }, 
      { "http://terminology.hl7.org/CodeSystem/substance-category#chemical", Chemical }, 
      { "drug", DrugOrMedicament }, 
      { "http://terminology.hl7.org/CodeSystem/substance-category#drug", DrugOrMedicament }, 
      { "food", DietarySubstance }, 
      { "http://terminology.hl7.org/CodeSystem/substance-category#food", DietarySubstance }, 
      { "material", Material }, 
      { "http://terminology.hl7.org/CodeSystem/substance-category#material", Material }, 
    };
  };
}