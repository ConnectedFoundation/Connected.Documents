using Connected.Annotations;
using Connected.Services;
using System.ComponentModel.DataAnnotations;

namespace Connected.Documents.Text.Dtos;

public abstract class DocumentTextDto<TPrimaryKey> : Dto, IDocumentTextDto<TPrimaryKey>
	where TPrimaryKey : notnull
{
	[MaxLength(256)]
	public virtual string? Title { get; set; }

	[MaxLength(2048)]
	public virtual string? Abstract { get; set; }

	public virtual string? Text { get; set; }

	[Required, MinValue(1)]
	public required virtual TPrimaryKey Id { get; set; }
}
