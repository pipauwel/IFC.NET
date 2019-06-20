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
using BuildingSmart.IFC.IfcSharedBldgElements;
using BuildingSmart.IFC.IfcSharedComponentElements;
using BuildingSmart.IFC.IfcStructuralAnalysisDomain;
using BuildingSmart.IFC.IfcUtilityResource;

namespace BuildingSmart.IFC.IfcStructuralElementsDomain
{
	[Guid("33cccfc5-2da4-42df-8cac-9c14b6d955a6")]
	public partial class IfcTendon : IfcReinforcingElement
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("Predefined generic types for a tendon.    <blockquote class=\"change-ifc2x4\">IFC4 CHANGE&nbsp; Attribute made optional.</blockquote>")]
		public IfcTendonTypeEnum? PredefinedType { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		[Description("The nominal diameter defining the cross-section size of the tendon.    <blockquote class=\"change-ifc2x4\">IFC4 CHANGE&nbsp; Attribute made optional and deprecated.  Use respective attribute at <em>IfcTendonType</em> instead.</blockquote>")]
		public IfcPositiveLengthMeasure? NominalDiameter { get; set; }
	
		[DataMember(Order = 2)] 
		[XmlAttribute]
		[Description("The effective cross-section area of the tendon.    <blockquote class=\"change-ifc2x4\">IFC4 CHANGE&nbsp; Attribute made optional and deprecated.  Use respective attribute at <em>IfcTendonType</em> instead.</blockquote>")]
		public IfcAreaMeasure? CrossSectionArea { get; set; }
	
		[DataMember(Order = 3)] 
		[XmlAttribute]
		[Description("The maximum allowed tension force that can be applied on the tendon.")]
		public IfcForceMeasure? TensionForce { get; set; }
	
		[DataMember(Order = 4)] 
		[XmlAttribute]
		[Description("The prestress to be applied on the tendon.")]
		public IfcPressureMeasure? PreStress { get; set; }
	
		[DataMember(Order = 5)] 
		[XmlAttribute]
		[Description("The friction coefficient between tendon and tendon sheet while the tendon is unbonded.")]
		public IfcNormalisedRatioMeasure? FrictionCoefficient { get; set; }
	
		[DataMember(Order = 6)] 
		[XmlAttribute]
		[Description("The deformation of an anchor or slippage of tendons when the prestressing device is released.")]
		public IfcPositiveLengthMeasure? AnchorageSlip { get; set; }
	
		[DataMember(Order = 7)] 
		[XmlAttribute]
		[Description("The smallest curvature radius calculated on the whole effective length of the tendon where the tension properties are still valid.")]
		public IfcPositiveLengthMeasure? MinCurvatureRadius { get; set; }
	
	
		public IfcTendon(IfcGloballyUniqueId globalId)
			: base(globalId)
		{
		}
	
	
	}
	
}
