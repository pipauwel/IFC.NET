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
using BuildingSmart.IFC.IfcPresentationAppearanceResource;
using BuildingSmart.IFC.IfcPresentationOrganizationResource;

namespace BuildingSmart.IFC.IfcTopologyResource
{
	[Guid("b04c081f-98f1-4a81-aa6c-88bad0e295b1")]
	public partial class IfcFaceOuterBound : IfcFaceBound
	{
	
		public IfcFaceOuterBound(IfcLoop bound, IfcBoolean orientation)
			: base(bound, orientation)
		{
		}
	
	
	}
	
}
