using Connected.Services;

namespace Connected.Documents.Comments.Dtos;

public interface IUpdateDocumentCommentDto<TPrimaryKey> : IDocumentCommentDto<TPrimaryKey>, IPrimaryKeyDto<long>
  where TPrimaryKey : notnull
{
}
