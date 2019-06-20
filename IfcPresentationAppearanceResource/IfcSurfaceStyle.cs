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
	[Guid("359b755a-e87c-418d-bb14-8b2fd007e3ba")]
	public partial class IfcSurfaceStyle : IfcPresentationStyle,
		IfcPresentationStyleSelect
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("An indication of which side of the surface to apply the style.")]
		[Required()]
		public IfcSurfaceSide Side { get; set; }
	
		[DataMember(Order = 1)] 
		[Description("A collection of different surface styles.")]
		[Required()]
		[MinLength(1)]
		[MaxLength(5)]
		public ISet<IfcSurfaceStyleElementSelect> Styles { get; protected set; }
	
	
		public IfcSurfaceStyle(IfcSurfaceSide side, IfcSurfaceStyleElementSelect[] styles)
		{
			this.Side = side;
			this.Styles = new HashSet<IfcSurfaceStyleElementSelect>(styles);
		}
	
	
	}
	
}
