using Connected.Annotations;

namespace Connected.Documents.Comments.Dtos;

public abstract class UpdateDocumentCommentDto<TPrimaryKey> : DocumentCommentDto<TPrimaryKey>, IUpdateDocumentCommentDto<TPrimaryKey>
  where TPrimaryKey : notnull
{
	[MinValue(1)]
	public long Id { get; set; }
}
