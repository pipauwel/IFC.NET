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
using BuildingSmart.IFC.IfcKernel;
using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcRepresentationResource;
using BuildingSmart.IFC.IfcStructuralLoadResource;
using BuildingSmart.IFC.IfcUtilityResource;

namespace BuildingSmart.IFC.IfcStructuralAnalysisDomain
{
	[Guid("79f64af6-81ab-4779-a424-b1df2d05afd6")]
	public partial class IfcStructuralPlanarActionVarying : IfcStructuralPlanarAction
	{
		[DataMember(Order = 0)] 
		[Description("A shape aspect, containing a list of shape representations, each defining either one Cartesian point or one point on curve (by parameter values) which are needed to provide the positions of the VaryingAppliedLoads. The values contained in the list of IfcShapeAspect.ShapeRepresentations correspond to the values at the same position in the list VaryingAppliedLoads.")]
		[Required()]
		public IfcShapeAspect VaryingAppliedLoadLocation { get; set; }
	
		[DataMember(Order = 1)] 
		[Description("A list containing load values which are assigned to the position defined through the shape aspect. The first load is already defined by the inherited attribute AppliedLoad and shall not be contained in this list.")]
		[Required()]
		[MinLength(2)]
		public IList<IfcStructuralLoad> SubsequentAppliedLoads { get; protected set; }
	
	
		public IfcStructuralPlanarActionVarying(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcStructuralLoad appliedLoad, IfcGlobalOrLocalEnum globalOrLocal, Boolean destabilizingLoad, IfcProjectedOrTrueLengthEnum projectedOrTrue, IfcShapeAspect varyingAppliedLoadLocation, IfcStructuralLoad[] subsequentAppliedLoads)
			: base(globalId, ownerHistory, appliedLoad, globalOrLocal, destabilizingLoad, projectedOrTrue)
		{
			this.VaryingAppliedLoadLocation = varyingAppliedLoadLocation;
			this.SubsequentAppliedLoads = new List<IfcStructuralLoad>(subsequentAppliedLoads);
		}
	
		public new IList<IfcStructuralLoad> VaryingAppliedLoads { get { return null; } }
	
	
	}
	
}
