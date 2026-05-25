using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace HiveApps.SharedKernel.Text;

/// <summary>
/// Provides helper methods for generating URL-friendly slugs from human-readable text.
/// </summary>
public static partial class SlugGenerator
{
    /// <summary>
    /// Generates a URL-friendly slug from the specified text.
    /// </summary>
    /// <param name="value">The source text used to generate the slug.</param>
    /// <returns>A normalized, lowercase and URL-friendly slug.</returns>
    /// <exception cref="ArgumentException">Thrown when the source text is null, empty or whitespace.</exception>
    public static string Generate(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentException("Slug source value cannot be empty.", nameof(value));
        }

        var normalized = value.Trim().Normalize(NormalizationForm.FormD);
        var builder = new StringBuilder();

        foreach (var character in normalized)
        {
            var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(character);

            if (unicodeCategory != UnicodeCategory.NonSpacingMark)
            {
                builder.Append(character);
            }
        }

        var withoutDiacritics = builder
            .ToString()
            .Normalize(NormalizationForm.FormC)
            .ToLowerInvariant();

        var slug = InvalidSlugCharactersRegex()
            .Replace(withoutDiacritics, "-");

        slug = DuplicateHyphenRegex()
            .Replace(slug, "-")
            .Trim('-');

        if (string.IsNullOrWhiteSpace(slug))
        {
            throw new ArgumentException("Slug source value must contain at least one valid character.", nameof(value));
        }

        return slug;
    }

    /// <summary>
    /// Gets a regular expression that matches characters that are not valid in a slug.
    /// </summary>
    /// <returns>A compiled regular expression for invalid slug characters.</returns>
    [GeneratedRegex(@"[^a-z0-9]+", RegexOptions.Compiled)]
    private static partial Regex InvalidSlugCharactersRegex();

    /// <summary>
    /// Gets a regular expression that matches duplicated hyphen separators.
    /// </summary>
    /// <returns>A compiled regular expression for duplicated hyphens.</returns>
    [GeneratedRegex(@"-+", RegexOptions.Compiled)]
    private static partial Regex DuplicateHyphenRegex();
}