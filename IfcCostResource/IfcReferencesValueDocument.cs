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

using BuildingSmart.IFC.IfcExternalReferenceResource;
using BuildingSmart.IFC.IfcMeasureResource;

namespace BuildingSmart.IFC.IfcCostResource
{
	[Guid("40a470f7-a897-4241-8b52-574730c6954d")]
	public partial class IfcReferencesValueDocument
	{
		[DataMember(Order = 0)] 
		[Description("A document such as a price list or quotation from which costs are obtained.")]
		[Required()]
		public IfcDocumentSelect ReferencedDocument { get; set; }
	
		[DataMember(Order = 1)] 
		[Description("Costs obtained from a single document such as a price list or quotation.")]
		[Required()]
		[MinLength(1)]
		public ISet<IfcAppliedValue> ReferencingValues { get; protected set; }
	
		[DataMember(Order = 2)] 
		[XmlAttribute]
		[Description("A name used to identify or qualify the relationship to the document from which values may be referenced..")]
		public IfcLabel? Name { get; set; }
	
		[DataMember(Order = 3)] 
		[XmlAttribute]
		[Description("A description of the relationship to the document from which values may be referenced.")]
		public IfcText? Description { get; set; }
	
	
		public IfcReferencesValueDocument(IfcDocumentSelect referencedDocument, IfcAppliedValue[] referencingValues)
		{
			this.ReferencedDocument = referencedDocument;
			this.ReferencingValues = new HashSet<IfcAppliedValue>(referencingValues);
		}
	
	
	}
	
}
