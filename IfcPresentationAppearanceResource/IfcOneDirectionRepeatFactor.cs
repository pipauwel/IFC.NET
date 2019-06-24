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
using BuildingSmart.IFC.IfcPresentationOrganizationResource;

namespace BuildingSmart.IFC.IfcPresentationAppearanceResource
{
	[Guid("4c04ea6b-0820-4dcb-8f54-d66875e0c39f")]
	public partial class IfcOneDirectionRepeatFactor : IfcGeometricRepresentationItem,
		IfcHatchLineDistanceSelect
	{
		[DataMember(Order = 0)] 
		[Description("A vector which specifies the relative positioning of hatch lines.")]
		[Required()]
		public IfcVector RepeatFactor { get; set; }
	
	
		public IfcOneDirectionRepeatFactor(IfcVector repeatFactor)
		{
			this.RepeatFactor = repeatFactor;
		}
	
	
	}
	
}
