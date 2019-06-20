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

namespace BuildingSmart.IFC.IfcTopologyResource
{
	[Guid("606bfe59-169d-4543-89a1-60d81d609835")]
	public partial class IfcPolyLoop : IfcLoop
	{
		[DataMember(Order = 0)] 
		[Description("List of points defining the loop. There are no repeated points in the list.")]
		[Required()]
		[CustomValidation(typeof(IfcPolyLoop), "Unique")]
		[MinLength(3)]
		public IList<IfcCartesianPoint> Polygon { get; protected set; }
	
	
		public IfcPolyLoop(IfcCartesianPoint[] polygon)
		{
			this.Polygon = new List<IfcCartesianPoint>(polygon);
		}
	
	
	}
	
}
