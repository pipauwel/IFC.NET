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
using BuildingSmart.IFC.IfcUtilityResource;

namespace BuildingSmart.IFC.IfcStructuralAnalysisDomain
{
	[Guid("0220cd79-a55b-4394-b463-e381c4e5129c")]
	public partial class IfcStructuralSurfaceMember : IfcStructuralMember
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("Defines the load carrying behavior of the member, as far as it is taken into account in the analysis.")]
		[Required()]
		public IfcStructuralSurfaceTypeEnum PredefinedType { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		[Description("Defines the typically understood thickness of the structural face member, i.e. the smallest spatial dimension of the element.")]
		public IfcPositiveLengthMeasure? Thickness { get; set; }
	
	
		public IfcStructuralSurfaceMember(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcStructuralSurfaceTypeEnum predefinedType)
			: base(globalId, ownerHistory)
		{
			this.PredefinedType = predefinedType;
		}
	
	
	}
	
}
