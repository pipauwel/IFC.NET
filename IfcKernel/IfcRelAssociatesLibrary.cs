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
	[Guid("2a37b209-469f-4dc3-aa54-9e9dfa648295")]
	public partial class IfcRelAssociatesLibrary : IfcRelAssociates
	{
		[DataMember(Order = 0)] 
		[Description("Reference to a library, from which the definition of the property set is taken.")]
		[Required()]
		public IfcLibrarySelect RelatingLibrary { get; set; }
	
	
		public IfcRelAssociatesLibrary(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcRoot[] relatedObjects, IfcLibrarySelect relatingLibrary)
			: base(globalId, ownerHistory, relatedObjects)
		{
			this.RelatingLibrary = relatingLibrary;
		}
	
	
	}
	
}
