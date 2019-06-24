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

using BuildingSmart.IFC.IfcActorResource;
using BuildingSmart.IFC.IfcDateTimeResource;
using BuildingSmart.IFC.IfcMeasureResource;

namespace BuildingSmart.IFC.IfcExternalReferenceResource
{
	[Guid("18f6d470-1412-4a7d-b9f4-aac72f975e94")]
	public partial class IfcLibraryInformation :
		IfcLibrarySelect
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("The name which is used to identify the library.")]
		[Required()]
		public IfcLabel Name { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		[Description("Identifier for the library version used for reference.")]
		public IfcLabel? Version { get; set; }
	
		[DataMember(Order = 2)] 
		[Description("Information of the organization that acts as the library publisher.")]
		public IfcOrganization Publisher { get; set; }
	
		[DataMember(Order = 3)] 
		[Description("Date of the referenced version of the library.")]
		public IfcCalendarDate VersionDate { get; set; }
	
		[DataMember(Order = 4)] 
		[Description("Information on the library being referenced.")]
		[MinLength(1)]
		public ISet<IfcLibraryReference> LibraryReference { get; protected set; }
	
	
		public IfcLibraryInformation(IfcLabel name)
		{
			this.Name = name;
			this.LibraryReference = new HashSet<IfcLibraryReference>();
		}
	
	
	}
	
}
