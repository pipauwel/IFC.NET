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
	[Guid("02dac9ec-9223-41cb-9796-40c07ad2dae0")]
	public partial class IfcSymbolStyle : IfcPresentationStyle,
		IfcPresentationStyleSelect
	{
		[DataMember(Order = 0)] 
		[Description("The style applied to the symbol for its visual appearance.")]
		[Required()]
		public IfcSymbolStyleSelect StyleOfSymbol { get; set; }
	
	
		public IfcSymbolStyle(IfcSymbolStyleSelect styleOfSymbol)
		{
			this.StyleOfSymbol = styleOfSymbol;
		}
	
	
	}
	
}
