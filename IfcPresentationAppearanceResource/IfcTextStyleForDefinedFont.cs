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

using BuildingSmart.IFC.IfcPresentationResource;

namespace BuildingSmart.IFC.IfcPresentationAppearanceResource
{
	[Guid("81ee382b-1d17-4541-94b0-d12f8d8ad706")]
	public partial class IfcTextStyleForDefinedFont :
		IfcCharacterStyleSelect
	{
		[DataMember(Order = 0)] 
		[Description("<EPM-HTML>  This property describes the text color of an element (often referred to as the foreground color).  </EPM-HTML>")]
		[Required()]
		public IfcColour Colour { get; set; }
	
		[DataMember(Order = 1)] 
		[Description("<EPM-HTML>  This property sets the background color of an element.  </EPM-HTML>")]
		public IfcColour BackgroundColour { get; set; }
	
	
		public IfcTextStyleForDefinedFont(IfcColour colour)
		{
			this.Colour = colour;
		}
	
	
	}
	
}
