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
using BuildingSmart.IFC.IfcStructuralAnalysisDomain;
using BuildingSmart.IFC.IfcUtilityResource;

namespace BuildingSmart.IFC.IfcStructuralElementsDomain
{
	[Guid("e9ba48f9-734e-4e7f-9a90-572fd19c5475")]
	public partial class IfcSurfaceFeature : IfcFeatureElement
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("Indicates the kind of surface feature.")]
		public IfcSurfaceFeatureTypeEnum? PredefinedType { get; set; }
	
	
		public IfcSurfaceFeature(IfcGloballyUniqueId globalId)
			: base(globalId)
		{
		}
	
	
	}
	
}
