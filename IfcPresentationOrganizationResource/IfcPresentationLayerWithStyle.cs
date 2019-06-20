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
using BuildingSmart.IFC.IfcPresentationAppearanceResource;

namespace BuildingSmart.IFC.IfcPresentationOrganizationResource
{
	[Guid("d58d8ae7-e309-454d-b3f1-2b58ce4d583d")]
	public partial class IfcPresentationLayerWithStyle : IfcPresentationLayerAssignment
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("A logical setting, TRUE indicates that the layer is set to 'On', FALSE that the layer is set to 'Off', UNKNOWN that such information is not available.")]
		[Required()]
		public IfcLogical LayerOn { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		[Description("A logical setting, TRUE indicates that the layer is set to 'Frozen', FALSE that the layer is set to 'Not frozen', UNKNOWN that such information is not available.")]
		[Required()]
		public IfcLogical LayerFrozen { get; set; }
	
		[DataMember(Order = 2)] 
		[XmlAttribute]
		[Description("A logical setting, TRUE indicates that the layer is set to 'Blocked', FALSE that the layer is set to 'Not blocked', UNKNOWN that such information is not available.")]
		[Required()]
		public IfcLogical LayerBlocked { get; set; }
	
		[DataMember(Order = 3)] 
		[Description("Assignment of presentation styles to the layer to provide a default style for representation items.  <blockquote class=\"note\">NOTE&nbsp; In most cases the assignment of styles to a layer is restricted to an <em>IfcCurveStyle</em> representing the layer curve colour, layer curve thickness, and layer curve type.    </blockquote>    <blockquote class=\"change-ifc2x4\">  IFC4 CHANGE&nbsp; The data type has been changed from <em>IfcPresentationStyleSelect</em> (now deprecated) to <em>IfcPresentationStyle</em>.  </blockquote>")]
		[Required()]
		public ISet<IfcPresentationStyle> LayerStyles { get; protected set; }
	
	
		public IfcPresentationLayerWithStyle(IfcLabel name, IfcLayeredItem[] assignedItems, IfcLogical layerOn, IfcLogical layerFrozen, IfcLogical layerBlocked, IfcPresentationStyle[] layerStyles)
			: base(name, assignedItems)
		{
			this.LayerOn = layerOn;
			this.LayerFrozen = layerFrozen;
			this.LayerBlocked = layerBlocked;
			this.LayerStyles = new HashSet<IfcPresentationStyle>(layerStyles);
		}
	
	
	}
	
}
