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

using BuildingSmart.IFC.IfcGeometricConstraintResource;
using BuildingSmart.IFC.IfcGeometricModelResource;
using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcPresentationAppearanceResource;
using BuildingSmart.IFC.IfcPresentationOrganizationResource;

namespace BuildingSmart.IFC.IfcGeometryResource
{
	[Guid("a15c5ebd-7a08-41d4-ac69-184ee254821c")]
	public partial class IfcRectangularTrimmedSurface : IfcBoundedSurface
	{
		[DataMember(Order = 0)] 
		[Description("Surface being trimmed.")]
		[Required()]
		public IfcSurface BasisSurface { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		[Description("First u parametric value.")]
		[Required()]
		public IfcParameterValue U1 { get; set; }
	
		[DataMember(Order = 2)] 
		[XmlAttribute]
		[Description("First v parametric value.")]
		[Required()]
		public IfcParameterValue V1 { get; set; }
	
		[DataMember(Order = 3)] 
		[XmlAttribute]
		[Description("Second u parametric value.")]
		[Required()]
		public IfcParameterValue U2 { get; set; }
	
		[DataMember(Order = 4)] 
		[XmlAttribute]
		[Description("Second v parametric value.")]
		[Required()]
		public IfcParameterValue V2 { get; set; }
	
		[DataMember(Order = 5)] 
		[Description("Flag to indicate whether the direction of the first parameter of the trimmed surface agrees with or opposes the sense of u in the basis surface.")]
		[Required()]
		public Boolean Usense { get; set; }
	
		[DataMember(Order = 6)] 
		[Description("Flag to indicate whether the direction of the second parameter of the trimmed surface agrees with or opposes the sense of v in the basis surface.")]
		[Required()]
		public Boolean Vsense { get; set; }
	
	
		public IfcRectangularTrimmedSurface(IfcSurface basisSurface, IfcParameterValue u1, IfcParameterValue v1, IfcParameterValue u2, IfcParameterValue v2, Boolean usense, Boolean vsense)
		{
			this.BasisSurface = basisSurface;
			this.U1 = u1;
			this.V1 = v1;
			this.U2 = u2;
			this.V2 = v2;
			this.Usense = usense;
			this.Vsense = vsense;
		}
	
		public new IfcDimensionCount Dim { get { return new IfcDimensionCount(); } }
	
	
	}
	
}
