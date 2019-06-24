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
using BuildingSmart.IFC.IfcUtilityResource;

namespace BuildingSmart.IFC.IfcKernel
{
	[Guid("d40d6e07-fca6-44d6-8ff0-7428d418bb6a")]
	public partial class IfcRelAssociatesDocument : IfcRelAssociates
	{
		[DataMember(Order = 0)] 
		[Description("Document information or reference which is applied to the objects.")]
		[Required()]
		public IfcDocumentSelect RelatingDocument { get; set; }
	
	
		public IfcRelAssociatesDocument(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcRoot[] relatedObjects, IfcDocumentSelect relatingDocument)
			: base(globalId, ownerHistory, relatedObjects)
		{
			this.RelatingDocument = relatingDocument;
		}
	
	
	}
	
}
