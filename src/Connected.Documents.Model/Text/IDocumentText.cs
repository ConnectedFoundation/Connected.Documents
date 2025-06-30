using Connected.Entities;

namespace Connected.Documents.Text;

public interface IDocumentText<TPrimaryKey> : IEntity<TPrimaryKey>
  where TPrimaryKey : notnull
{
	string? Abstract { get; init; }
	string? Text { get; init; }
}
