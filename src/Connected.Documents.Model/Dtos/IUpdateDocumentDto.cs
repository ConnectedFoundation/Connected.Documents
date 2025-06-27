using Connected.Services;

namespace Connected.Documents.Dtos;
public interface IUpdateDocumentDto<TPrimaryKey> : IDocumentDto, IPrimaryKeyDto<TPrimaryKey>
	where TPrimaryKey : notnull
{
	DateTimeOffset? Modified { get; set; }
	int? Owner { get; set; }
	int FileCount { get; set; }
}
