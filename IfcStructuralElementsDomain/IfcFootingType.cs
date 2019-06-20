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
	[Guid("82272f47-5c4e-4c73-a82a-c5167bd15f6c")]
	public partial class IfcFootingType : IfcBuildingElementType
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("Subtype of footing.")]
		[Required()]
		public IfcFootingTypeEnum PredefinedType { get; set; }
	
	
		public IfcFootingType(IfcGloballyUniqueId globalId, IfcFootingTypeEnum predefinedType)
			: base(globalId)
		{
			this.PredefinedType = predefinedType;
		}
	
	
	}
	
}
