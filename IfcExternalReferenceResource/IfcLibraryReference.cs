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
using BuildingSmart.IFC.IfcPresentationOrganizationResource;
using BuildingSmart.IFC.IfcPropertyResource;

namespace BuildingSmart.IFC.IfcExternalReferenceResource
{
	[Guid("cfdbc669-8a34-4570-ad57-0939f779948e")]
	public partial class IfcLibraryReference : IfcExternalReference,
		IfcLibrarySelect
	{
		[InverseProperty("LibraryReference")] 
		[Description("The library information that is being referenced.")]
		[MaxLength(1)]
		public ISet<IfcLibraryInformation> ReferenceIntoLibrary { get; protected set; }
	
	
		public IfcLibraryReference()
		{
			this.ReferenceIntoLibrary = new HashSet<IfcLibraryInformation>();
		}
	
	
	}
	
}
