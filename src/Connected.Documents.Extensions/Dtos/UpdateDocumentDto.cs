using Connected.Annotations;

namespace Connected.Documents.Dtos;
public abstract class UpdateDocumentDto<TPrimaryKey> : DocumentDto, IUpdateDocumentDto<TPrimaryKey>
	where TPrimaryKey : notnull
{
	[MinValue(1)]
	public required TPrimaryKey Id { get; set; }
	public DateTimeOffset? Modified { get; set; }
	public int? Owner { get; set; }
}
