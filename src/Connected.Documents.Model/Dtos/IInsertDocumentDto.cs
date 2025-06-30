namespace Connected.Documents.Dtos;
public interface IInsertDocumentDto : IDocumentDto
{
	string? Author { get; set; }
	DateTimeOffset Created { get; set; }
}
