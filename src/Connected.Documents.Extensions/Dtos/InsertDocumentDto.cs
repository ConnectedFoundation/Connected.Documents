using System.ComponentModel.DataAnnotations;

namespace Connected.Documents.Dtos;
public abstract class InsertDocumentDto : DocumentDto, IInsertDocumentDto
{
	[MaxLength(256)]
	public string? Author { get; set; }

	public DateTimeOffset Created { get; set; }
}
