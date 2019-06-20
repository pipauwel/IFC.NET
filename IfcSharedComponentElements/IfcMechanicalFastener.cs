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
	[Guid("3f389407-9e81-4218-8102-56eb71651146")]
	public partial class IfcMechanicalFastener : IfcElementComponent
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("The nominal diameter describing the cross-section size of the fastener type.    <blockquote class=\"change-ifc2x4\">  IFC4 CHANGE&nbsp; Deprecated; the respective attribute of <em>IfcMechanicalFastenerType</em> should be used instead.  </blockquote>")]
		public IfcPositiveLengthMeasure? NominalDiameter { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		[Description("The nominal length describing the longitudinal dimensions of the fastener type.    <blockquote class=\"change-ifc2x4\">  IFC4 CHANGE&nbsp; Deprecated; the respective attribute of <em>IfcMechanicalFastenerType</em> should be used instead.  </blockquote>")]
		public IfcPositiveLengthMeasure? NominalLength { get; set; }
	
		[DataMember(Order = 2)] 
		[XmlAttribute]
		[Description("Subtype of mechanical fastener")]
		public IfcMechanicalFastenerTypeEnum? PredefinedType { get; set; }
	
	
		public IfcMechanicalFastener(IfcGloballyUniqueId globalId)
			: base(globalId)
		{
		}
	
	
	}
	
}
