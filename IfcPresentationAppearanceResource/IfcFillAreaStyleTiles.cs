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
using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcPresentationOrganizationResource;

namespace BuildingSmart.IFC.IfcPresentationAppearanceResource
{
	[Guid("94e16249-95c6-4654-92c9-5cfac4e1e234")]
	public partial class IfcFillAreaStyleTiles : IfcGeometricRepresentationItem,
		IfcFillStyleSelect
	{
		[DataMember(Order = 0)] 
		[Description("A two direction repeat factor defining the shape and relative positioning of the tiles.  <blockquote class=\"change-ifc2x4\">IFC4 CHANGE&nbsp; The attribute type has changed to directly reference two <em>IfcVector</em>'s.</blockquote>")]
		[Required()]
		[MinLength(2)]
		[MaxLength(2)]
		public IList<IfcVector> TilingPattern { get; protected set; }
	
		[DataMember(Order = 1)] 
		[Description("A set of constituents of the tile being a styled item that is used as the annotation symbol for tiling the filled area.  <blockquote class=\"change-ifc2x4\">IFC4 CHANGE  The data type has been changed to <em>IfcStyledItem</em>.</blockquote>  <blockquote class=\"note\">NOTE&nbsp; Only <em>IfcStyleItem</em>'s that refer to a compatible geometric representation item and presentation style shall be used.</blockquote>")]
		[Required()]
		[MinLength(1)]
		public ISet<IfcStyledItem> Tiles { get; protected set; }
	
		[DataMember(Order = 2)] 
		[XmlAttribute]
		[Description("The scale factor applied to each tile as it is placed in the annotation fill area.")]
		[Required()]
		public IfcPositiveRatioMeasure TilingScale { get; set; }
	
	
		public IfcFillAreaStyleTiles(IfcVector[] tilingPattern, IfcStyledItem[] tiles, IfcPositiveRatioMeasure tilingScale)
		{
			this.TilingPattern = new List<IfcVector>(tilingPattern);
			this.Tiles = new HashSet<IfcStyledItem>(tiles);
			this.TilingScale = tilingScale;
		}
	
	
	}
	
}
