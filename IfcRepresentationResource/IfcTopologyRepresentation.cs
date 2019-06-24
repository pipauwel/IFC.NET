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
	[Guid("8d53a039-971a-4a3d-b4b8-05f6ddfe4e60")]
	public partial class IfcTopologyRepresentation : IfcShapeModel
	{
	
		public IfcTopologyRepresentation(IfcRepresentationContext contextOfItems, IfcRepresentationItem[] items)
			: base(contextOfItems, items)
		{
		}
	
	
	}
	
}
