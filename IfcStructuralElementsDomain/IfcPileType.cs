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

namespace BuildingSmart.IFC.IfcStructuralElementsDomain
{
	[Guid("3694a657-5c71-4fa9-8223-0f80ab28ae3b")]
	public partial class IfcPileType : IfcBuildingElementType
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("Subtype of pile.")]
		[Required()]
		public IfcPileTypeEnum PredefinedType { get; set; }
	
	
		public IfcPileType(IfcGloballyUniqueId globalId, IfcPileTypeEnum predefinedType)
			: base(globalId)
		{
			this.PredefinedType = predefinedType;
		}
	
	
	}
	
}
