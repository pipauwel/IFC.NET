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

using BuildingSmart.IFC.IfcGeometryResource;
using BuildingSmart.IFC.IfcKernel;
using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcUtilityResource;

namespace BuildingSmart.IFC.IfcProductExtension
{
	[Guid("5918be21-23fb-417c-bf05-65f1d12ea348")]
	public partial class IfcSpaceType : IfcSpatialStructureElementType
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("<EPM-HTML>  Predefined types to define the particular type of space. There may be property set definitions available for each predefined type.  </EPM-HTML>")]
		[Required()]
		public IfcSpaceTypeEnum PredefinedType { get; set; }
	
	
		public IfcSpaceType(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcSpaceTypeEnum predefinedType)
			: base(globalId, ownerHistory)
		{
			this.PredefinedType = predefinedType;
		}
	
	
	}
	
}
