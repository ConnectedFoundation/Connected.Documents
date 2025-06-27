using Connected.Services;

namespace Connected.Documents.Comments.Dtos;

public abstract class DocumentCommentDto<TPrimaryKey> : Dto, IDocumentCommentDto<TPrimaryKey>
  where TPrimaryKey : notnull
{
	public virtual string? Text { get; set; }
}
