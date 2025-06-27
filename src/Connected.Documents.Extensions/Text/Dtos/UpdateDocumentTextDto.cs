namespace Connected.Documents.Text.Dtos;

public abstract class UpdateDocumentTextDto<TPrimaryKey> : DocumentTextDto<TPrimaryKey>, IUpdateDocumentTextDto<TPrimaryKey>
  where TPrimaryKey : notnull
{
}
