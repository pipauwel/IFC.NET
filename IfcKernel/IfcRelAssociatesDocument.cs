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
	[Guid("e5157cca-2d77-44ab-8df1-4977c66acd14")]
	public partial class IfcRelAssociatesDocument : IfcRelAssociates
	{
		[DataMember(Order = 0)] 
		[Description("Document information or reference which is applied to the objects.")]
		[Required()]
		public IfcDocumentSelect RelatingDocument { get; set; }
	
	
		public IfcRelAssociatesDocument(IfcGloballyUniqueId globalId, IfcDefinitionSelect[] relatedObjects, IfcDocumentSelect relatingDocument)
			: base(globalId, relatedObjects)
		{
			this.RelatingDocument = relatingDocument;
		}
	
	
	}
	
}
