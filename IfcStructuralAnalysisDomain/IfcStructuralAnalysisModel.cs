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
using BuildingSmart.IFC.IfcUtilityResource;

namespace BuildingSmart.IFC.IfcStructuralAnalysisDomain
{
	[Guid("b796d1f5-5fcb-4c3a-8308-76c88bd1f02e")]
	public partial class IfcStructuralAnalysisModel : IfcSystem
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("Defines the type of the structural analysis model.")]
		[Required()]
		public IfcAnalysisModelTypeEnum PredefinedType { get; set; }
	
		[DataMember(Order = 1)] 
		[Description("If the selected model type (PredefinedType) describes a 2D system the orientation is needed to define the upright direction to the focused plane (z-axes). This is needed because all data for the structural analysis model (structural members, structural activities) are defined by using 3-D space. The orientation is given in relation to the coordinate system of the project. By 3D systems this value is not asserted.")]
		public IfcAxis2Placement3D OrientationOf2DPlane { get; set; }
	
		[DataMember(Order = 2)] 
		[Description("References to all load groups to be analyzed.")]
		[MinLength(1)]
		public ISet<IfcStructuralLoadGroup> LoadedBy { get; protected set; }
	
		[DataMember(Order = 3)] 
		[Description("References to all result groups available for this structural analysis model.")]
		[MinLength(1)]
		public ISet<IfcStructuralResultGroup> HasResults { get; protected set; }
	
	
		public IfcStructuralAnalysisModel(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcAnalysisModelTypeEnum predefinedType)
			: base(globalId, ownerHistory)
		{
			this.PredefinedType = predefinedType;
			this.LoadedBy = new HashSet<IfcStructuralLoadGroup>();
			this.HasResults = new HashSet<IfcStructuralResultGroup>();
		}
	
	
	}
	
}
