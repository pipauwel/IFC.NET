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

namespace BuildingSmart.IFC.IfcStructuralElementsDomain
{
	[Guid("1b518a02-392f-43e1-b4e1-0135ac1adc2b")]
	public partial class IfcTendon : IfcReinforcingElement
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("Predefined generic types for a tendon.")]
		[Required()]
		public IfcTendonTypeEnum PredefinedType { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		[Description("The nominal diameter defining the cross-section size of the tendon.")]
		[Required()]
		public IfcPositiveLengthMeasure NominalDiameter { get; set; }
	
		[DataMember(Order = 2)] 
		[XmlAttribute]
		[Description("The effective cross-section area of the tendon.")]
		[Required()]
		public IfcAreaMeasure CrossSectionArea { get; set; }
	
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
		[Description("The friction coefficient for the bond between the tendon and the surrounding concrete.")]
		public IfcNormalisedRatioMeasure? FrictionCoefficient { get; set; }
	
		[DataMember(Order = 6)] 
		[XmlAttribute]
		[Description("The deformation of an anchor or slippage of tendons when the prestressing device is released.")]
		public IfcPositiveLengthMeasure? AnchorageSlip { get; set; }
	
		[DataMember(Order = 7)] 
		[XmlAttribute]
		[Description("The smallest curvature radius calculated on the whole effective length of the tendon where the tension properties are still valid.")]
		public IfcPositiveLengthMeasure? MinCurvatureRadius { get; set; }
	
	
		public IfcTendon(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcTendonTypeEnum predefinedType, IfcPositiveLengthMeasure nominalDiameter, IfcAreaMeasure crossSectionArea)
			: base(globalId, ownerHistory)
		{
			this.PredefinedType = predefinedType;
			this.NominalDiameter = nominalDiameter;
			this.CrossSectionArea = crossSectionArea;
		}
	
	
	}
	
}
