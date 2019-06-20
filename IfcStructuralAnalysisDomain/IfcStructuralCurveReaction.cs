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
	[Guid("d85746e9-e456-40b1-9f23-87262b226375")]
	public partial class IfcStructuralCurveReaction : IfcStructuralReaction
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("Type of reaction according to its distribution of load values.")]
		[Required()]
		public IfcStructuralCurveActivityTypeEnum PredefinedType { get; set; }
	
	
		public IfcStructuralCurveReaction(IfcGloballyUniqueId globalId, IfcStructuralLoad appliedLoad, IfcGlobalOrLocalEnum globalOrLocal, IfcStructuralCurveActivityTypeEnum predefinedType)
			: base(globalId, appliedLoad, globalOrLocal)
		{
			this.PredefinedType = predefinedType;
		}
	
	
	}
	
}
