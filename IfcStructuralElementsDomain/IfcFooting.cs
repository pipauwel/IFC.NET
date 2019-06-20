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
	[Guid("0664744b-65e2-41ea-9b44-6b0a1749f000")]
	public partial class IfcFooting : IfcBuildingElement
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("The generic type of the footing.    <blockquote class=\"change-ifc2x4\">IFC4 CHANGE&nbsp; Attribute made optional.  Type information can be provided by <em>IfcRelDefinesByType</em> and <em>IfcFootingType</em>.</font></blockquote>")]
		public IfcFootingTypeEnum? PredefinedType { get; set; }
	
	
		public IfcFooting(IfcGloballyUniqueId globalId)
			: base(globalId)
		{
		}
	
	
	}
	
}
