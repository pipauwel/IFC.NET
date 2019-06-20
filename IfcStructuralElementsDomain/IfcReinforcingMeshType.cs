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
using BuildingSmart.IFC.IfcSharedComponentElements;
using BuildingSmart.IFC.IfcUtilityResource;

namespace BuildingSmart.IFC.IfcStructuralElementsDomain
{
	[Guid("c55468d2-4e66-449a-9e37-6795ea684389")]
	public partial class IfcReinforcingMeshType : IfcReinforcingElementType
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("Subtype of reinforcing mesh.")]
		[Required()]
		public IfcReinforcingMeshTypeEnum PredefinedType { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		[Description("The overall length of the mesh measured in its longitudinal direction.")]
		public IfcPositiveLengthMeasure? MeshLength { get; set; }
	
		[DataMember(Order = 2)] 
		[XmlAttribute]
		[Description("The overall width of the mesh measured in its transversal direction.")]
		public IfcPositiveLengthMeasure? MeshWidth { get; set; }
	
		[DataMember(Order = 3)] 
		[XmlAttribute]
		[Description("The nominal diameter denoting the cross-section size of the longitudinal bars.")]
		public IfcPositiveLengthMeasure? LongitudinalBarNominalDiameter { get; set; }
	
		[DataMember(Order = 4)] 
		[XmlAttribute]
		[Description("The nominal diameter denoting the cross-section size of the transverse bars.")]
		public IfcPositiveLengthMeasure? TransverseBarNominalDiameter { get; set; }
	
		[DataMember(Order = 5)] 
		[XmlAttribute]
		[Description("The effective cross-section area of the longitudinal bars of the mesh.")]
		public IfcAreaMeasure? LongitudinalBarCrossSectionArea { get; set; }
	
		[DataMember(Order = 6)] 
		[XmlAttribute]
		[Description("The effective cross-section area of the transverse bars of the mesh.")]
		public IfcAreaMeasure? TransverseBarCrossSectionArea { get; set; }
	
		[DataMember(Order = 7)] 
		[XmlAttribute]
		[Description("The spacing between the longitudinal bars.  Note: an even distribution of bars is presumed; other cases are handled by classification or property sets.")]
		public IfcPositiveLengthMeasure? LongitudinalBarSpacing { get; set; }
	
		[DataMember(Order = 8)] 
		[XmlAttribute]
		[Description("The spacing between the transverse bars.  Note: an even distribution of bars is presumed; other cases are handled by classification or property sets.")]
		public IfcPositiveLengthMeasure? TransverseBarSpacing { get; set; }
	
		[DataMember(Order = 9)] 
		[XmlAttribute]
		[Description("If this mesh type is bent rather than planar, this attribute provides a shape code per a standard like ACI 315, ISO 3766, or a similar standard.  It is presumed that a single standard for defining the mesh bending is used throughout the project and that this standard is referenced from the <em>IfcProject</em> object through the <em>IfcDocumentReference</em> mechanism.")]
		public IfcLabel? BendingShapeCode { get; set; }
	
		[DataMember(Order = 10)] 
		[Description("If this mesh type is bent rather than planar, this attribute provides bending shape parameters. Their meaning is defined by the bending shape code and the respective standard.")]
		[MinLength(1)]
		public IList<IfcBendingParameterSelect> BendingParameters { get; protected set; }
	
	
		public IfcReinforcingMeshType(IfcGloballyUniqueId globalId, IfcReinforcingMeshTypeEnum predefinedType)
			: base(globalId)
		{
			this.PredefinedType = predefinedType;
			this.BendingParameters = new List<IfcBendingParameterSelect>();
		}
	
	
	}
	
}
