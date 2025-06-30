using Connected.Services;

namespace Connected.Documents.Text.Dtos;

public interface IDocumentTextDto<TPrimaryKey> : IPrimaryKeyDto<TPrimaryKey>
	where TPrimaryKey : notnull
{
	string? Abstract { get; set; }
	string? Text { get; set; }
}
