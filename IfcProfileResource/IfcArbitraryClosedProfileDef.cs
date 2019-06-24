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
using BuildingSmart.IFC.IfcMeasureResource;

namespace BuildingSmart.IFC.IfcProfileResource
{
	[Guid("7bd49124-3b02-4378-9c53-cfe91d261947")]
	public partial class IfcArbitraryClosedProfileDef : IfcProfileDef
	{
		[DataMember(Order = 0)] 
		[Description("Bounded curve, defining the outer boundaries of the arbitrary profile.")]
		[Required()]
		public IfcCurve OuterCurve { get; set; }
	
	
		public IfcArbitraryClosedProfileDef(IfcProfileTypeEnum profileType, IfcCurve outerCurve)
			: base(profileType)
		{
			this.OuterCurve = outerCurve;
		}
	
	
	}
	
}
