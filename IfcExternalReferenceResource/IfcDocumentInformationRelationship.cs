// This file may be edited manually or auto-generated using IfcKit at www.buildingsmart-tech.org.
// IFC content is copyright (C) 1996-2018 BuildingSMART International Ltd.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;

using BuildingSmart.IFC.IfcMeasureResource;

namespace BuildingSmart.IFC.IfcExternalReferenceResource
{
	[Guid("79f322fe-2390-4be9-ac5e-2c79ccbfc1d5")]
	public partial class IfcDocumentInformationRelationship : IfcResourceLevelRelationship
	{
		[DataMember(Order = 0)] 
		[XmlElement]
		[Description("The document that acts as the parent, referencing or original document in a relationship.")]
		[Required()]
		public IfcDocumentInformation RelatingDocument { get; set; }
	
		[DataMember(Order = 1)] 
		[Description("The document that acts as the child, referenced or replacing document in a relationship.")]
		[Required()]
		[MinLength(1)]
		public ISet<IfcDocumentInformation> RelatedDocuments { get; protected set; }
	
		[DataMember(Order = 2)] 
		[XmlAttribute]
		[Description("Describes the type of relationship between documents. This could be sub-document, replacement etc. The interpretation has to be established in an application context.")]
		public IfcLabel? RelationshipType { get; set; }
	
	
		public IfcDocumentInformationRelationship(IfcDocumentInformation relatingDocument, IfcDocumentInformation[] relatedDocuments)
		{
			this.RelatingDocument = relatingDocument;
			this.RelatedDocuments = new HashSet<IfcDocumentInformation>(relatedDocuments);
		}
	
	
	}
	
}
