using Connected.Services;

namespace Connected.Documents.Comments.Dtos;

public interface IDocumentCommentDto<TPrimaryKey> : IDto
  where TPrimaryKey : notnull
{
	string? Text { get; set; }
}
