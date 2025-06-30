using Connected.Annotations;
using System.ComponentModel.DataAnnotations;

namespace Connected.Documents.Dtos;
public abstract class UpdateDocumentDto<TPrimaryKey> : DocumentDto, IUpdateDocumentDto<TPrimaryKey>
	where TPrimaryKey : notnull
{
	[MinValue(1)]
	public required TPrimaryKey Id { get; set; }
	public DateTimeOffset? Modified { get; set; }

	[MaxLength(256)]
	public string? Owner { get; set; }

	[MinValue(0)]
	public int FileCount { get; set; }
}
