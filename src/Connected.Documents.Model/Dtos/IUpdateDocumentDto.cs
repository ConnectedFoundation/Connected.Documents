using Connected.Services;

namespace Connected.Documents.Dtos;
public interface IUpdateDocumentDto<TPrimaryKey> : IDto
	where TPrimaryKey : notnull
{
	TPrimaryKey Id { get; set; }
	DateTimeOffset? Modified { get; set; }
	int? Owner { get; set; }
	string? Code { get; set; }
}
