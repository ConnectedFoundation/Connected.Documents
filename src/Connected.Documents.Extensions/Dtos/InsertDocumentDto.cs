using Connected.Services;
using System.ComponentModel.DataAnnotations;

namespace Connected.Documents.Dtos;
public abstract class InsertDocumentDto : Dto, IInsertDocumentDto
{
	public int? Author { get; set; }

	public DateTimeOffset Created { get; set; }

	[MaxLength(32)]
	public string? Code { get; set; }
}
