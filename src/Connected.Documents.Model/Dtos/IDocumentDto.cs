using Connected.Services;

namespace Connected.Documents.Dtos;

public interface IDocumentDto : IDto
{
	string? Code { get; set; }
}
