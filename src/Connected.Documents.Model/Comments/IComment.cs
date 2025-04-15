using Connected.Entities;

namespace Connected.Documents.Comments;

public interface IComment<TPrimaryKey> : IEntity<long>
	where TPrimaryKey : notnull
{
	TPrimaryKey Document { get; init; }
	string Text { get; init; }
	string? Identity { get; init; }
	DateTimeOffset Created { get; init; }
	long? Parent { get; init; }
}
