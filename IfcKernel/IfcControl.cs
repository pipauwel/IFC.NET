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

using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcUtilityResource;

namespace BuildingSmart.IFC.IfcKernel
{
	[Guid("5cc95018-83bd-4c3b-ba54-1475cf5cbdb7")]
	public abstract partial class IfcControl : IfcObject
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("An identifying designation given to a control      It is the identifier at the occurrence level.       <blockquote class=\"change-ifc2x4\">IFC4 CHANGE  Attribute unified by promoting from various subtypes of <em>IfcControl</em>.   </blockquote>")]
		public IfcIdentifier? Identification { get; set; }
	
		[InverseProperty("RelatingControl")] 
		[Description("Reference to the relationship that associates the control to the object(s) being controlled.")]
		public ISet<IfcRelAssignsToControl> Controls { get; protected set; }
	
	
		protected IfcControl(IfcGloballyUniqueId globalId)
			: base(globalId)
		{
			this.Controls = new HashSet<IfcRelAssignsToControl>();
		}
	
	
	}
	
}
