using System.Text.Json.Serialization;

namespace Elsa.Workflows.Models;

/// <summary>
/// A bookmark represents a location in a workflow where the workflow can be resumed at a later time.
/// </summary>
/// <param name="Id">The ID of the bookmark.</param>
/// <param name="Name">The name of the bookmark.</param>
/// <param name="Hash">The hash of the bookmark.</param>
/// <param name="Payload">The data associated with the bookmark.</param>
/// <param name="ActivityId">The ID of the activity associated with the bookmark.</param>
/// <param name="ActivityNodeId">The ID of the activity node associated with the bookmark.</param>
/// <param name="ActivityInstanceId">The ID of the activity instance associated with the bookmark.</param>
/// <param name="CreatedAt">The date and time the bookmark was created.</param>
/// <param name="AutoBurn">Whether or not the bookmark should be automatically burned.</param>
/// <param name="CallbackMethodName">The name of the method on the activity class to invoke when the bookmark is resumed.</param>
/// <param name="Metadata">Custom properties associated with the bookmark.</param>
public record Bookmark(
    string Id,
    string Name,
    string Hash,
    object? Payload,
    string ActivityId,
    string ActivityNodeId,
    string? ActivityInstanceId,
    DateTimeOffset CreatedAt,
    bool AutoBurn = true,
    string? CallbackMethodName = null,
    bool AutoComplete = true,
    IDictionary<string, string>? Metadata = null)
{
    /// <inheritdoc />
    [JsonConstructor]
    public Bookmark() : this("", "", "",  null, "", "", "", default, false)
    {
    }
}