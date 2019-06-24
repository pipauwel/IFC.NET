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
using BuildingSmart.IFC.IfcPresentationAppearanceResource;
using BuildingSmart.IFC.IfcPresentationOrganizationResource;

namespace BuildingSmart.IFC.IfcGeometricModelResource
{
	[Guid("fdc6a245-73d0-49ab-af10-8bcd9e75d397")]
	public partial class IfcHalfSpaceSolid : IfcGeometricRepresentationItem,
		IfcBooleanOperand
	{
		[DataMember(Order = 0)] 
		[Description("Surface defining side of half space.")]
		[Required()]
		public IfcSurface BaseSurface { get; set; }
	
		[DataMember(Order = 1)] 
		[Description("The agreement flag is TRUE if the normal to the BaseSurface points away from the material of the IfcHalfSpaceSolid. Otherwise it is FALSE.")]
		[Required()]
		public Boolean AgreementFlag { get; set; }
	
	
		public IfcHalfSpaceSolid(IfcSurface baseSurface, Boolean agreementFlag)
		{
			this.BaseSurface = baseSurface;
			this.AgreementFlag = agreementFlag;
		}
	
		public new IfcDimensionCount Dim { get { return new IfcDimensionCount(); } }
	
	
	}
	
}
