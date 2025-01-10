using Connected.Services;

namespace Connected.Documents.Dtos;
public interface IInsertDocumentDto : IDto
{
	int? Author { get; set; }
	DateTimeOffset Created { get; set; }
	string? Code { get; set; }
}
