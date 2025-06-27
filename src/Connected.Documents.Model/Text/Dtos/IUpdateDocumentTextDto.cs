using Connected.Services;

namespace Connected.Documents.Text.Dtos;

public interface IUpdateDocumentTextDto<TPrimaryKey> : IDocumentTextDto<TPrimaryKey>, IPrimaryKeyDto<TPrimaryKey>
  where TPrimaryKey : notnull
{
}
