using Connected.Services;

namespace Connected.Documents.Text.Dtos;

public interface IDocumentTextDto<TPrimaryKey> : IPrimaryKeyDto<TPrimaryKey>
	where TPrimaryKey : notnull
{
	string? Title { get; set; }
	string? Abstract { get; set; }
	string? Text { get; set; }
}
