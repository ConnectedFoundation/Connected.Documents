using Connected.Entities;

namespace Connected.Documents.Text;

public interface IDocumentText<TPrimaryKey> : IEntity<TPrimaryKey>
  where TPrimaryKey : notnull
{
	string? Title { get; init; }
	string? Abstract { get; init; }
	string? Text { get; init; }
}
