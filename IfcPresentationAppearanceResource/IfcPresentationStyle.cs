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

namespace BuildingSmart.IFC.IfcPresentationAppearanceResource
{
	[Guid("ab926025-a25c-40a8-9608-000b0b34210c")]
	public abstract partial class IfcPresentationStyle :
		IfcStyleAssignmentSelect
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("Name of the presentation style.")]
		public IfcLabel? Name { get; set; }
	
	
		protected IfcPresentationStyle()
		{
		}
	
	
	}
	
}
