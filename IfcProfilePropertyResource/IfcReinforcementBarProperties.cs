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

using BuildingSmart.IFC.IfcMeasureResource;

namespace BuildingSmart.IFC.IFCPROFILEPROPERTYRESOURCE
{
	[Guid("c4654b2f-b43b-4b9d-97dd-3ee7b9fdfb75")]
	public partial class IfcReinforcementBarProperties
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("The total effective cross-section area of the reinforcement of a specific steel grade.")]
		[Required()]
		public IfcAreaMeasure TotalCrossSectionArea { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		[Description("The nominal steel grade defined according to local standards.")]
		[Required()]
		public IfcLabel SteelGrade { get; set; }
	
		[DataMember(Order = 2)] 
		[XmlAttribute]
		[Description("Indicator for whether the bar surface is plain or textured.")]
		public IfcReinforcingBarSurfaceEnum? BarSurface { get; set; }
	
		[DataMember(Order = 3)] 
		[XmlAttribute]
		[Description("The effective depth, i.e. the distance of the specific reinforcement cross section area or reinforcement configuration in a row, counted from a common specific reference point. Usually the reference point is the upper surface (for beams and slabs) or a similar projection in a plane (for columns).")]
		public IfcLengthMeasure? EffectiveDepth { get; set; }
	
		[DataMember(Order = 4)] 
		[XmlAttribute]
		[Description("The nominal diameter defining the cross-section size of the reinforcing bar. The bar diameter should be identical for all bars included in the specific reinforcement configuration.")]
		public IfcPositiveLengthMeasure? NominalBarDiameter { get; set; }
	
		[DataMember(Order = 5)] 
		[XmlAttribute]
		[Description("The number of bars with identical nominal diameter and steel grade included in the specific reinforcement configuration.")]
		public IfcCountMeasure? BarCount { get; set; }
	
	
		public IfcReinforcementBarProperties(IfcAreaMeasure totalCrossSectionArea, IfcLabel steelGrade)
		{
			this.TotalCrossSectionArea = totalCrossSectionArea;
			this.SteelGrade = steelGrade;
		}
	
	
	}
	
}
