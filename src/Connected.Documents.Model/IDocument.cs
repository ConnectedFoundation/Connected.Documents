using Connected.Entities;

namespace Connected.Documents;

public enum DocumentStatus
{
	Draft = 0,
	Ready = 1,
	Complete = 2,
	Cancel = 3
}

/// <summary>
/// Represents the base entity for all documents.
/// </summary>
/// <remarks>
/// Document is primary entity of the business processes. It provides
/// schema which is used in a business process lifecycle. Documents, apart from 
/// some basic validation, do not provide any specifiec business logic. Business
/// processes are entirely responsible for the business logic.
/// </remarks>
public interface IDocument<TPrimaryKey> : IEntity<TPrimaryKey>
	where TPrimaryKey : notnull
{
	/// <summary>
	/// The date when document was created.
	/// </summary>
	DateTimeOffset Created { get; init; }
	/// <summary>
	/// The date when document was last updated.
	/// </summary>
	DateTimeOffset? Modified { get; init; }
	/// <summary>
	/// The unique identifier of the document. This is
	/// usually set by a customer specific numbering system. 
	/// </summary>
	string? Code { get; init; }
	/// <summary>
	/// The identity which created the document. Can be null if document was created by the system.
	/// </summary>
	string? Author { get; init; }
	/// <summary>
	/// The identity last modified the document. Once identity modifies the document it becomes the Owner. 
	/// </summary>
	/// <remarks>
	/// This behavior could be overriden in documents implementation.
	/// </remarks>
	string? Owner { get; init; }
	/// <summary>
	/// Number of attached file to the document. 
	/// </summary>
	/// <remarks>
	/// A document can have a number of associated file typically uploaded in the file storage. This
	/// property is a shortcut to the number of uploaded files linked to the document.
	/// </remarks>
	int FileCount { get; init; }
	/// <summary>
	/// Title of the document. 
	/// </summary>
	/// <remarks>
	/// A document can optionaly have a title which briefly describes its content.
	/// </remarks>
	string? Title { get; init; }
	/// <summary>
	/// The url of the document. 
	/// </summary>
	/// <remarks>
	/// If a document can be accessed directly by the url this property contains its value.
	/// </remarks>
	string? Url { get; init; }

	DocumentStatus Status { get; init; }
}
