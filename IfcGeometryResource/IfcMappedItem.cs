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

using BuildingSmart.IFC.IfcPresentationAppearanceResource;
using BuildingSmart.IFC.IfcPresentationOrganizationResource;

namespace BuildingSmart.IFC.IfcGeometryResource
{
	[Guid("ffc10785-4b8a-40de-a1a6-87a49ef4ff7f")]
	public partial class IfcMappedItem : IfcRepresentationItem
	{
		[DataMember(Order = 0)] 
		[XmlElement]
		[Description("A representation map that is the source of the mapped item. It can be seen as a block (or cell or marco) definition.")]
		[Required()]
		public IfcRepresentationMap MappingSource { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlElement]
		[Description("A representation item that is the target onto which the mapping source is mapped. It is constraint to be a Cartesian transformation operator.")]
		[Required()]
		public IfcCartesianTransformationOperator MappingTarget { get; set; }
	
	
		public IfcMappedItem(IfcRepresentationMap mappingSource, IfcCartesianTransformationOperator mappingTarget)
		{
			this.MappingSource = mappingSource;
			this.MappingTarget = mappingTarget;
		}
	
	
	}
	
}
