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
	[Guid("8ab654a3-24e1-46b6-8dfd-39758b74dc21")]
	public partial class IfcFillAreaStyleTiles : IfcGeometricRepresentationItem,
		IfcFillStyleSelect
	{
		[DataMember(Order = 0)] 
		[Description("A two direction repeat factor defining the shape and relative positioning of the tiles.")]
		[Required()]
		public IfcOneDirectionRepeatFactor TilingPattern { get; set; }
	
		[DataMember(Order = 1)] 
		[Description("A set of constituents of the tile.")]
		[Required()]
		[MinLength(1)]
		public ISet<IfcFillAreaStyleTileShapeSelect> Tiles { get; protected set; }
	
		[DataMember(Order = 2)] 
		[XmlAttribute]
		[Description("The scale factor applied to each tile as it is placed in the annotation fill area.")]
		[Required()]
		public IfcPositiveRatioMeasure TilingScale { get; set; }
	
	
		public IfcFillAreaStyleTiles(IfcOneDirectionRepeatFactor tilingPattern, IfcFillAreaStyleTileShapeSelect[] tiles, IfcPositiveRatioMeasure tilingScale)
		{
			this.TilingPattern = tilingPattern;
			this.Tiles = new HashSet<IfcFillAreaStyleTileShapeSelect>(tiles);
			this.TilingScale = tilingScale;
		}
	
	
	}
	
}
