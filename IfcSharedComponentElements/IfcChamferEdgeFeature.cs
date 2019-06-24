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

namespace BuildingSmart.IFC.IfcSharedComponentElements
{
	[Guid("be8da1db-acc3-47d4-8e94-ab610f9c3be9")]
	public partial class IfcChamferEdgeFeature : IfcEdgeFeature
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("The width of the feature chamfer cross section.")]
		public IfcPositiveLengthMeasure? Width { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		[Description("The height of the feature chamfer cross section.")]
		public IfcPositiveLengthMeasure? Height { get; set; }
	
	
		public IfcChamferEdgeFeature(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory)
			: base(globalId, ownerHistory)
		{
		}
	
	
	}
	
}
