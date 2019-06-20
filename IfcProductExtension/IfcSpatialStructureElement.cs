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
using BuildingSmart.IFC.IfcRepresentationResource;
using BuildingSmart.IFC.IfcUtilityResource;

namespace BuildingSmart.IFC.IfcProductExtension
{
	[Guid("061ba193-076d-4292-a0ce-c96d7aba692e")]
	public abstract partial class IfcSpatialStructureElement : IfcSpatialElement
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("Denotes, whether the predefined spatial structure element represents itself, or an aggregate (complex) or a part (part). The interpretation is given separately for each subtype of spatial structure element. If no <em>CompositionType</em> is asserted, the dafault value 'ELEMENT' applies.  <blockquote class=\"change-ifc2x4\">IFC4 CHANGE&nbsp; Attribute made optional.</blockquote>")]
		public IfcElementCompositionEnum? CompositionType { get; set; }
	
	
		protected IfcSpatialStructureElement(IfcGloballyUniqueId globalId)
			: base(globalId)
		{
		}
	
	
	}
	
}
