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

using BuildingSmart.IFC.IfcGeometryResource;
using BuildingSmart.IFC.IfcPresentationAppearanceResource;
using BuildingSmart.IFC.IfcPresentationOrganizationResource;

namespace BuildingSmart.IFC.IfcPresentationDefinitionResource
{
	[Guid("4ab54421-83da-48e9-9931-2e0f8051029b")]
	public partial class IfcTextLiteralWithExtent : IfcTextLiteral
	{
		[DataMember(Order = 0)] 
		[XmlElement]
		[Description("The extent in the x and y direction of the text literal.")]
		[Required()]
		public IfcPlanarExtent Extent { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		[Description("The alignment of the text literal relative to its position.")]
		[Required()]
		public IfcBoxAlignment BoxAlignment { get; set; }
	
	
		public IfcTextLiteralWithExtent(IfcPresentableText literal, IfcAxis2Placement placement, IfcTextPath path, IfcPlanarExtent extent, IfcBoxAlignment boxAlignment)
			: base(literal, placement, path)
		{
			this.Extent = extent;
			this.BoxAlignment = boxAlignment;
		}
	
	
	}
	
}
