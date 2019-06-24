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
	[Guid("f70fa03b-812a-4bb0-a82d-8113ca7bbddd")]
	public partial class IfcRoof : IfcBuildingElement
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("Predefined shape types for a roof that are specified in an enumeration.")]
		[Required()]
		public IfcRoofTypeEnum ShapeType { get; set; }
	
	
		public IfcRoof(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcRoofTypeEnum shapeType)
			: base(globalId, ownerHistory)
		{
			this.ShapeType = shapeType;
		}
	
	
	}
	
}
