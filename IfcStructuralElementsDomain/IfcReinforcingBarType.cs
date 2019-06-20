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

using BuildingSmart.IFC.IfcGeometryResource;
using BuildingSmart.IFC.IfcKernel;
using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcProductExtension;
using BuildingSmart.IFC.IfcProfileResource;
using BuildingSmart.IFC.IfcSharedComponentElements;
using BuildingSmart.IFC.IfcUtilityResource;

namespace BuildingSmart.IFC.IfcStructuralElementsDomain
{
	[Guid("c46e7d75-e366-4cf2-839d-664d7f121513")]
	public partial class IfcReinforcingBarType : IfcReinforcingElementType
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("Subtype of reinforcing bar.")]
		[Required()]
		public IfcReinforcingBarTypeEnum PredefinedType { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		[Description("The nominal diameter defining the cross-section size of the reinforcing bar.")]
		public IfcPositiveLengthMeasure? NominalDiameter { get; set; }
	
		[DataMember(Order = 2)] 
		[XmlAttribute]
		[Description("The effective cross-section area of the reinforcing bar.")]
		public IfcAreaMeasure? CrossSectionArea { get; set; }
	
		[DataMember(Order = 3)] 
		[XmlAttribute]
		[Description("The total length of the reinforcing bar. The total length of bended bars are calculated according to local standards with corrections for the bends.")]
		public IfcPositiveLengthMeasure? BarLength { get; set; }
	
		[DataMember(Order = 4)] 
		[XmlAttribute]
		[Description("Indicator for whether the bar surface is plain or textured.")]
		public IfcReinforcingBarSurfaceEnum? BarSurface { get; set; }
	
		[DataMember(Order = 5)] 
		[XmlAttribute]
		[Description("Shape code per a standard like ACI 315, ISO 3766, or a similar standard.  It is presumed that a single standard for defining the bar bending is used throughout the project and that this standard is referenced from the <em>IfcProject</em> object through the <em>IfcDocumentReference</em> mechanism.")]
		public IfcLabel? BendingShapeCode { get; set; }
	
		[DataMember(Order = 6)] 
		[Description("Bending shape parameters.  Their meaning is defined by the bending shape code and the respective standard.")]
		[MinLength(1)]
		public IList<IfcBendingParameterSelect> BendingParameters { get; protected set; }
	
	
		public IfcReinforcingBarType(IfcGloballyUniqueId globalId, IfcReinforcingBarTypeEnum predefinedType)
			: base(globalId)
		{
			this.PredefinedType = predefinedType;
			this.BendingParameters = new List<IfcBendingParameterSelect>();
		}
	
	
	}
	
}
