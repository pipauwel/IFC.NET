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

namespace BuildingSmart.IFC.IfcSharedComponentElements
{
	[Guid("f248ebd3-afb8-4ffe-9a34-195555c0b22b")]
	public partial class IfcBuildingElementPartType : IfcElementComponentType
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("Subtype of building element part")]
		[Required()]
		public IfcBuildingElementPartTypeEnum PredefinedType { get; set; }
	
	
		public IfcBuildingElementPartType(IfcGloballyUniqueId globalId, IfcBuildingElementPartTypeEnum predefinedType)
			: base(globalId)
		{
			this.PredefinedType = predefinedType;
		}
	
	
	}
	
}