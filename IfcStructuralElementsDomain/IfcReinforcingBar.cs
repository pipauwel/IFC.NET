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
using BuildingSmart.IFC.IFCPROFILEPROPERTYRESOURCE;
using BuildingSmart.IFC.IfcRepresentationResource;
using BuildingSmart.IFC.IfcStructuralAnalysisDomain;
using BuildingSmart.IFC.IfcUtilityResource;

namespace BuildingSmart.IFC.IfcStructuralElementsDomain
{
	[Guid("cf91911e-b109-410a-bc39-45bb696de10e")]
	public partial class IfcReinforcingBar : IfcReinforcingElement
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("The nominal diameter defining the cross-section size of the reinforcing bar.")]
		[Required()]
		public IfcPositiveLengthMeasure NominalDiameter { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		[Description("The effective cross-section area of the reinforcing bar.")]
		[Required()]
		public IfcAreaMeasure CrossSectionArea { get; set; }
	
		[DataMember(Order = 2)] 
		[XmlAttribute]
		[Description("The total length of the reinforcing bar. The total length of bended bars are calculated according to local standards with corrections for the bends.")]
		public IfcPositiveLengthMeasure? BarLength { get; set; }
	
		[DataMember(Order = 3)] 
		[XmlAttribute]
		[Description("The role, purpose or usage of the bar, i.e. the kind of loads and stresses it is intended to carry.")]
		[Required()]
		public IfcReinforcingBarRoleEnum BarRole { get; set; }
	
		[DataMember(Order = 4)] 
		[XmlAttribute]
		[Description("Indicator for whether the bar surface is plain or textured.")]
		public IfcReinforcingBarSurfaceEnum? BarSurface { get; set; }
	
	
		public IfcReinforcingBar(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcPositiveLengthMeasure nominalDiameter, IfcAreaMeasure crossSectionArea, IfcReinforcingBarRoleEnum barRole)
			: base(globalId, ownerHistory)
		{
			this.NominalDiameter = nominalDiameter;
			this.CrossSectionArea = crossSectionArea;
			this.BarRole = barRole;
		}
	
	
	}
	
}
