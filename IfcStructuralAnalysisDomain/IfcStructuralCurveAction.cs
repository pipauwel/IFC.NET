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
	[Guid("948541ee-3298-408e-a404-6fd5b84b81e9")]
	public partial class IfcStructuralCurveAction : IfcStructuralAction
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("Defines whether load values are given per true length of the curve on which they act, or per length of the projection of the curve in load direction.  The latter is only applicable to loads which act in global coordinate directions.")]
		public IfcProjectedOrTrueLengthEnum? ProjectedOrTrue { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		[Description("Type of action according to its distribution of load values.")]
		[Required()]
		public IfcStructuralCurveActivityTypeEnum PredefinedType { get; set; }
	
	
		public IfcStructuralCurveAction(IfcGloballyUniqueId globalId, IfcStructuralLoad appliedLoad, IfcGlobalOrLocalEnum globalOrLocal, IfcStructuralCurveActivityTypeEnum predefinedType)
			: base(globalId, appliedLoad, globalOrLocal)
		{
			this.PredefinedType = predefinedType;
		}
	
	
	}
	
}
