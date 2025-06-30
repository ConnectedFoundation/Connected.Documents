using Connected.Services;

namespace Connected.Documents.Dtos;
public interface IUpdateDocumentDto<TPrimaryKey> : IDocumentDto, IPrimaryKeyDto<TPrimaryKey>
	where TPrimaryKey : notnull
{
	DateTimeOffset? Modified { get; set; }
	string? Owner { get; set; }
	int FileCount { get; set; }
}
