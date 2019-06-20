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
using BuildingSmart.IFC.IfcProductExtension;
using BuildingSmart.IFC.IfcUtilityResource;

namespace BuildingSmart.IFC.IfcSharedBldgElements
{
	[Guid("7116fa64-a466-426e-84ce-c82bc9a1a8c4")]
	public partial class IfcStairFlightType : IfcBuildingElementType
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("Identifies the predefined types of a stair flight element from which the type required may be set.")]
		[Required()]
		public IfcStairFlightTypeEnum PredefinedType { get; set; }
	
	
		public IfcStairFlightType(IfcGloballyUniqueId globalId, IfcStairFlightTypeEnum predefinedType)
			: base(globalId)
		{
			this.PredefinedType = predefinedType;
		}
	
	
	}
	
}