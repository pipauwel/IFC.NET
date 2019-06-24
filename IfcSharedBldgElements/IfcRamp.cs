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
using BuildingSmart.IFC.IfcProductExtension;
using BuildingSmart.IFC.IfcRepresentationResource;
using BuildingSmart.IFC.IfcStructuralAnalysisDomain;
using BuildingSmart.IFC.IfcUtilityResource;

namespace BuildingSmart.IFC.IfcSharedBldgElements
{
	[Guid("537e375f-b293-4782-b530-2121ed518de0")]
	public partial class IfcRamp : IfcBuildingElement
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("Predefined shape types for a ramp that are specified in an Enum.")]
		[Required()]
		public IfcRampTypeEnum ShapeType { get; set; }
	
	
		public IfcRamp(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcRampTypeEnum shapeType)
			: base(globalId, ownerHistory)
		{
			this.ShapeType = shapeType;
		}
	
	
	}
	
}
