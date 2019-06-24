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

namespace BuildingSmart.IFC.IfcPresentationResource
{
	[Guid("210cab92-54d9-4ef4-b29c-d0bc75321733")]
	public abstract partial class IfcPreDefinedColour : IfcPreDefinedItem,
		IfcColour
	{
	
		protected IfcPreDefinedColour(IfcLabel name)
			: base(name)
		{
		}
	
	
	}
	
}
