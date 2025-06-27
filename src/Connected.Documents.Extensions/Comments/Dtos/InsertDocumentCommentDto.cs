using Connected.Annotations;
using System.ComponentModel.DataAnnotations;

namespace Connected.Documents.Comments.Dtos;

public abstract class InsertDocumentCommentDto<TPrimaryKey> : DocumentCommentDto<TPrimaryKey>, IInsertDocumentCommentDto<TPrimaryKey>
  where TPrimaryKey : notnull
{
	[Required, MinValue(1)]
	public required virtual TPrimaryKey Document { get; set; }

	public virtual string? Identity { get; set; }

	[NonDefault]
	public DateTimeOffset Created { get; set; }

	public long? Parent { get; set; }
}
