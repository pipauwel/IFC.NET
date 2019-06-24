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
using BuildingSmart.IFC.IfcPresentationDefinitionResource;
using BuildingSmart.IFC.IfcPresentationOrganizationResource;

namespace BuildingSmart.IFC.IfcPresentationAppearanceResource
{
	[Guid("e6426bbb-6818-4e03-8b46-0273e8673f1b")]
	public partial class IfcFillAreaStyleTileSymbolWithStyle : IfcGeometricRepresentationItem,
		IfcFillAreaStyleTileShapeSelect
	{
		[DataMember(Order = 0)] 
		[Description("A styled annotation symbol.")]
		[Required()]
		public IfcAnnotationSymbolOccurrence Symbol { get; set; }
	
	
		public IfcFillAreaStyleTileSymbolWithStyle(IfcAnnotationSymbolOccurrence symbol)
		{
			this.Symbol = symbol;
		}
	
	
	}
	
}
