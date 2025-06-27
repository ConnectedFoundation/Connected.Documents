using Connected.Services;
using System.ComponentModel.DataAnnotations;

namespace Connected.Documents.Dtos;

public abstract class DocumentDto : Dto, IDocumentDto
{
	[MaxLength(DefaultCodeLength)]
	public virtual string? Code { get; set; }

	[MaxLength(DefaultTitleLength)]
	public virtual string? Title { get; set; }
}
