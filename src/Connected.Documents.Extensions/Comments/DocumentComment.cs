using Connected.Annotations;
using Connected.Annotations.Entities;
using Connected.Entities;
using System.ComponentModel.DataAnnotations;

namespace Connected.Documents.Comments;

public abstract record DocumentComment<TPrimaryKey> : ConsistentEntity<long>, IDocumentComment<TPrimaryKey>
  where TPrimaryKey : notnull
{
	[Ordinal(0), Index(false)]
	public required TPrimaryKey Document { get; init; }

	[Ordinal(1), MaxLength(-1)]
	public string? Text { get; init; }

	[Ordinal(2)]
	public string? Identity { get; init; }

	[Ordinal(3), Date(DateKind.DateTime)]
	public DateTimeOffset Created { get; init; }

	[Ordinal(4)]
	public long? Parent { get; init; }
}
