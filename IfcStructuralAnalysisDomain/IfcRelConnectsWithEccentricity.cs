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
using BuildingSmart.IFC.IfcGeometryResource;
using BuildingSmart.IFC.IfcKernel;
using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcStructuralLoadResource;
using BuildingSmart.IFC.IfcUtilityResource;

namespace BuildingSmart.IFC.IfcStructuralAnalysisDomain
{
	[Guid("b3ecec25-6d42-49a2-bd7d-e64a12cc90ea")]
	public partial class IfcRelConnectsWithEccentricity : IfcRelConnectsStructuralMember
	{
		[DataMember(Order = 0)] 
		[Description("<EPM-HTML>  The connection constraint explicitly states the eccentricity between a structural element and a structural connection, either given by two point (used to calculate the eccentricity), or by explicit x, y, and z offsets.  </EPM-HTML>")]
		[Required()]
		public IfcConnectionGeometry ConnectionConstraint { get; set; }
	
	
		public IfcRelConnectsWithEccentricity(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcStructuralMember relatingStructuralMember, IfcStructuralConnection relatedStructuralConnection, IfcConnectionGeometry connectionConstraint)
			: base(globalId, ownerHistory, relatingStructuralMember, relatedStructuralConnection)
		{
			this.ConnectionConstraint = connectionConstraint;
		}
	
	
	}
	
}
