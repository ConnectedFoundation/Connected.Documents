using Connected.Annotations;

namespace Connected.Documents.Text.Dtos;

public abstract class InsertDocumentTextDto<TPrimaryKey> : DocumentTextDto<TPrimaryKey>, IInsertDocumentTextDto<TPrimaryKey>
	where TPrimaryKey : notnull
{
	[MinValue(1)]
	public required virtual TPrimaryKey Document { get; set; }
}
