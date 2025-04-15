namespace Connected.Documents.Dtos;
public interface IInsertDocumentDto : IDocumentDto
{
	int? Author { get; set; }
	DateTimeOffset Created { get; set; }
}
