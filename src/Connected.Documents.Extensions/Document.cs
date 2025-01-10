using Connected.Annotations;
using Connected.Annotations.Entities;
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
public abstract record Document<TPrimaryKey> : ConsistentEntity<TPrimaryKey>, IDocument<TPrimaryKey>
	where TPrimaryKey : notnull
{
	/// <summary>
	/// The date when document was created.
	/// </summary>
	[Ordinal(0), Date(DateKind.DateTime2, 7)]
	public DateTimeOffset Created { get; init; }
	/// <summary>
	/// The date when document was last updated.
	/// </summary>
	[Ordinal(1), Date(DateKind.DateTime2, 7)]
	public DateTimeOffset? Modified { get; init; }
	/// <summary>
	/// The unique identifier of the document. This is
	/// usually set by a customer specific numbering system. 
	/// </summary>
	[Ordinal(2), Length(32)]
	public string? Code { get; init; }
	/// <summary>
	/// The user which created the document. Can be null if document was created by the system.
	/// </summary>
	[Ordinal(3)]
	public int? Author { get; init; }
	/// <summary>
	/// The user last modified the document. Once user modifies the document it becomes the Owner. 
	/// </summary>
	/// <remarks>
	/// This behavior could be overriden in documents implementation.
	/// </remarks>
	[Ordinal(4)]
	public int? Owner { get; init; }
}
