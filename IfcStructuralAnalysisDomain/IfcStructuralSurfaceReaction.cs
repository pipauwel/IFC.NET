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
	[Guid("e9d95f21-bd10-40ff-ada5-a024a15bf019")]
	public partial class IfcStructuralSurfaceReaction : IfcStructuralReaction
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("Type of reaction according to its distribution of load values.")]
		[Required()]
		public IfcStructuralSurfaceActivityTypeEnum PredefinedType { get; set; }
	
	
		public IfcStructuralSurfaceReaction(IfcGloballyUniqueId globalId, IfcStructuralLoad appliedLoad, IfcGlobalOrLocalEnum globalOrLocal, IfcStructuralSurfaceActivityTypeEnum predefinedType)
			: base(globalId, appliedLoad, globalOrLocal)
		{
			this.PredefinedType = predefinedType;
		}
	
	
	}
	
}
