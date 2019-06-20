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

namespace BuildingSmart.IFC.IfcGeometricModelResource
{
	[Guid("18fe3405-d1b4-4632-b93d-b36e1cdf00c1")]
	public partial class IfcCartesianPointList3D : IfcCartesianPointList
	{
		[DataMember(Order = 0)] 
		[Description("Two-dimensional list of Cartesian points provided by three coordinates.")]
		[Required()]
		[MinLength(1)]
		public IList<IfcLengthMeasure> CoordList { get; protected set; }
	
	
		public IfcCartesianPointList3D(IfcLengthMeasure[] coordList)
		{
			this.CoordList = new List<IfcLengthMeasure>(coordList);
		}
	
	
	}
	
}
