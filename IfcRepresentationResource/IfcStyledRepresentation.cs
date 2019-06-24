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
using BuildingSmart.IFC.IfcPresentationOrganizationResource;

namespace BuildingSmart.IFC.IfcRepresentationResource
{
	[Guid("55d288dc-b692-4e8f-bce7-00edbed0874a")]
	public partial class IfcStyledRepresentation : IfcStyleModel
	{
	
		public IfcStyledRepresentation(IfcRepresentationContext contextOfItems, IfcRepresentationItem[] items)
			: base(contextOfItems, items)
		{
		}
	
	
	}
	
}
