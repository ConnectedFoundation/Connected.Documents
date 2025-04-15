namespace Connected.Documents.Dtos;
public abstract class InsertDocumentDto : DocumentDto, IInsertDocumentDto
{
	public int? Author { get; set; }

	public DateTimeOffset Created { get; set; }
}
