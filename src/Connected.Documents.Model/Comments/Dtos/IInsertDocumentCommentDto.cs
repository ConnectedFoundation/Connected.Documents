namespace Connected.Documents.Comments.Dtos;

public interface IInsertDocumentCommentDto<TPrimaryKey> : IDocumentCommentDto<TPrimaryKey>
  where TPrimaryKey : notnull
{
	TPrimaryKey Document { get; set; }
	string? Identity { get; set; }
	DateTimeOffset Created { get; set; }
	long? Parent { get; set; }
}
