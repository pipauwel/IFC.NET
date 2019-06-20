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

using BuildingSmart.IFC.IfcKernel;
using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcPresentationOrganizationResource;
using BuildingSmart.IFC.IfcPropertyResource;

namespace BuildingSmart.IFC.IfcExternalReferenceResource
{
	[Guid("d5b0d04f-2b00-489b-a200-4b5b96eaec68")]
	public partial class IfcDocumentReference : IfcExternalReference,
		IfcDocumentSelect
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("Description of the document reference for informational purposes.  <blockquote class=\"change-ifc2x4\">IFC4 CHANGE&nbsp; New attribute added at the end of the attribute list.</blockquote>")]
		public IfcText? Description { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlElement]
		[Description("The document that is referenced.")]
		public IfcDocumentInformation ReferencedDocument { get; set; }
	
		[InverseProperty("RelatingDocument")] 
		[Description("The document reference with which objects are associated.  <blockquote class=\"change-ifc2x4\">IFC4 CHANGE&nbsp; New inverse attribute.</blockquote>")]
		public ISet<IfcRelAssociatesDocument> DocumentRefForObjects { get; protected set; }
	
	
		public IfcDocumentReference()
		{
			this.DocumentRefForObjects = new HashSet<IfcRelAssociatesDocument>();
		}
	
	
	}
	
}
