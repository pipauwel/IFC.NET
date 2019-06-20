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

namespace BuildingSmart.IFC.IfcSharedBldgElements
{
	[Guid("39b687ba-1327-4a70-927b-47733d3e370b")]
	public partial class IfcRailing : IfcBuildingElement
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("Predefined generic types for a railing that are specified in an enumeration. There may be a property set given for the predefined types.  <blockquote class=\"note\">NOTE&nbsp; The <em>PredefinedType</em> shall only be used, if no <em>IfcRailingType</em> is assigned, providing its own <em>IfcRailingType.PredefinedType</em>.</blockquote>  <blockquote class=\"change-ifc2x\">IFC2x CHANGE&nbsp; The attribute has been changed into an OPTIONAL attribute.</blockquote>")]
		public IfcRailingTypeEnum? PredefinedType { get; set; }
	
	
		public IfcRailing(IfcGloballyUniqueId globalId)
			: base(globalId)
		{
		}
	
	
	}
	
}
