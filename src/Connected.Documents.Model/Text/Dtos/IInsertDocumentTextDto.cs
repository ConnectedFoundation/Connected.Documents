namespace Connected.Documents.Text.Dtos;

public interface IInsertDocumentTextDto<TPrimaryKey> : IDocumentTextDto<TPrimaryKey>
	where TPrimaryKey : notnull
{

}
