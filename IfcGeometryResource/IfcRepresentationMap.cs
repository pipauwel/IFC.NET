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

using BuildingSmart.IFC.IfcRepresentationResource;

namespace BuildingSmart.IFC.IfcGeometryResource
{
	[Guid("380d19f2-c934-472a-9c62-ffcfbdd23698")]
	public partial class IfcRepresentationMap
	{
		[DataMember(Order = 0)] 
		[Description("An axis2 placement that defines the position about which the mapped  representation is mapped.")]
		[Required()]
		public IfcAxis2Placement MappingOrigin { get; set; }
	
		[DataMember(Order = 1)] 
		[Description("A representation that is mapped to at least one mapped item.")]
		[Required()]
		public IfcRepresentation MappedRepresentation { get; set; }
	
		[InverseProperty("MappingSource")] 
		public ISet<IfcMappedItem> MapUsage { get; protected set; }
	
	
		public IfcRepresentationMap(IfcAxis2Placement mappingOrigin, IfcRepresentation mappedRepresentation)
		{
			this.MappingOrigin = mappingOrigin;
			this.MappedRepresentation = mappedRepresentation;
			this.MapUsage = new HashSet<IfcMappedItem>();
		}
	
	
	}
	
}
