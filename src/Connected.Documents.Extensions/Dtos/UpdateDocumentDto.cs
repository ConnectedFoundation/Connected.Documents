using Connected.Services;
using System.ComponentModel.DataAnnotations;

namespace Connected.Documents.Dtos;
public abstract class UpdateDocumentDto<TPrimaryKey> : Dto, IUpdateDocumentDto<TPrimaryKey>
	where TPrimaryKey : notnull
{
	public required TPrimaryKey Id { get; set; }
	public DateTimeOffset? Modified { get; set; }
	public int? Owner { get; set; }

	[MaxLength(32)]
	public string? Code { get; set; }
}
