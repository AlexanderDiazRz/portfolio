namespace PortfolioAlexander.Models;

public sealed class PortfolioViewModel
{
    public IReadOnlyList<ProjectItem> Projects { get; init; } = [];
}

public sealed record ProjectItem(
    string Number,
    string Title,
    string Eyebrow,
    string Description,
    string Status,
    IReadOnlyList<string> Technologies,
    string? Url,
    string LinkLabel,
    string? ImageUrl = null,
    string? ImageAlt = null,
    string? ImageVariant = null,
    string? ImageCaption = null,
    string? ImageHeading = null);
