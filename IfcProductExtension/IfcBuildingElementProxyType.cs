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
	[Guid("cd70cd66-cecd-4fbe-aabb-a1b0bb005f04")]
	public partial class IfcBuildingElementProxyType : IfcBuildingElementType
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("<EPM-HTML>  Predefined types to define the particular type of an building element proxy. There may be property set definitions available for each predefined or user defined type.  </EPM-HTML>")]
		[Required()]
		public IfcBuildingElementProxyTypeEnum PredefinedType { get; set; }
	
	
		public IfcBuildingElementProxyType(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcBuildingElementProxyTypeEnum predefinedType)
			: base(globalId, ownerHistory)
		{
			this.PredefinedType = predefinedType;
		}
	
	
	}
	
}
