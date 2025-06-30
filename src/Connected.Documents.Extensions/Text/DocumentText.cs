using Connected.Annotations;
using Connected.Annotations.Entities;
using Connected.Entities;

namespace Connected.Documents.Text;

public abstract record DocumentText<TPrimaryKey> : Entity<TPrimaryKey>, IDocumentText<TPrimaryKey>
  where TPrimaryKey : notnull
{


	[Ordinal(0), Length(2048)]
	public virtual string? Abstract { get; init; }

	[Ordinal(1), Length(-1)]
	public virtual string? Text { get; init; }
}
