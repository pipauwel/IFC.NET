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

namespace BuildingSmart.IFC.IfcSharedComponentElements
{
	[Guid("a8383055-66b2-4dac-abe1-98562ba38cad")]
	public partial class IfcBuildingElementPart : IfcElementComponent
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("Subtype of building element part")]
		public IfcBuildingElementPartTypeEnum? PredefinedType { get; set; }
	
	
		public IfcBuildingElementPart(IfcGloballyUniqueId globalId)
			: base(globalId)
		{
		}
	
	
	}
	
}
