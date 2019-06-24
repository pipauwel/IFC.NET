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
	[Guid("f1b23e5d-c76d-4754-8b04-ea3d52f51a16")]
	public partial class IfcReinforcingMesh : IfcReinforcingElement
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("The overall length of the mesh measured in its longitudinal direction.")]
		public IfcPositiveLengthMeasure? MeshLength { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		[Description("The overall width of the mesh measured in its transversal direction.")]
		public IfcPositiveLengthMeasure? MeshWidth { get; set; }
	
		[DataMember(Order = 2)] 
		[XmlAttribute]
		[Description("The nominal diameter denoting the cross-section size of the longitudinal bars.")]
		[Required()]
		public IfcPositiveLengthMeasure LongitudinalBarNominalDiameter { get; set; }
	
		[DataMember(Order = 3)] 
		[XmlAttribute]
		[Description("The nominal diameter denoting the cross-section size of the transverse bars.")]
		[Required()]
		public IfcPositiveLengthMeasure TransverseBarNominalDiameter { get; set; }
	
		[DataMember(Order = 4)] 
		[XmlAttribute]
		[Description("The effective cross-section area of the longitudinal bars of the mesh.")]
		[Required()]
		public IfcAreaMeasure LongitudinalBarCrossSectionArea { get; set; }
	
		[DataMember(Order = 5)] 
		[XmlAttribute]
		[Description("The effective cross-section area of the transverse bars of the mesh.")]
		[Required()]
		public IfcAreaMeasure TransverseBarCrossSectionArea { get; set; }
	
		[DataMember(Order = 6)] 
		[XmlAttribute]
		[Description("The spacing between the longitudinal bars. Note: an even distribution of bars is presumed; other cases are handled by Psets.")]
		[Required()]
		public IfcPositiveLengthMeasure LongitudinalBarSpacing { get; set; }
	
		[DataMember(Order = 7)] 
		[XmlAttribute]
		[Description("The spacing between the transverse bars. Note: an even distribution of bars is presumed; other cases are handled by Psets.")]
		[Required()]
		public IfcPositiveLengthMeasure TransverseBarSpacing { get; set; }
	
	
		public IfcReinforcingMesh(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcPositiveLengthMeasure longitudinalBarNominalDiameter, IfcPositiveLengthMeasure transverseBarNominalDiameter, IfcAreaMeasure longitudinalBarCrossSectionArea, IfcAreaMeasure transverseBarCrossSectionArea, IfcPositiveLengthMeasure longitudinalBarSpacing, IfcPositiveLengthMeasure transverseBarSpacing)
			: base(globalId, ownerHistory)
		{
			this.LongitudinalBarNominalDiameter = longitudinalBarNominalDiameter;
			this.TransverseBarNominalDiameter = transverseBarNominalDiameter;
			this.LongitudinalBarCrossSectionArea = longitudinalBarCrossSectionArea;
			this.TransverseBarCrossSectionArea = transverseBarCrossSectionArea;
			this.LongitudinalBarSpacing = longitudinalBarSpacing;
			this.TransverseBarSpacing = transverseBarSpacing;
		}
	
	
	}
	
}
