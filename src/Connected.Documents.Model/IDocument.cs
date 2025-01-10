using Connected.Entities;

namespace Connected.Documents;

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
	/// The user which created the document. Can be null if document was created by the system.
	/// </summary>
	int? Author { get; init; }
	/// <summary>
	/// The user last modified the document. Once user modifies the document it becomes the Owner. 
	/// </summary>
	/// <remarks>
	/// This behavior could be overriden in documents implementation.
	/// </remarks>
	int? Owner { get; init; }
}
