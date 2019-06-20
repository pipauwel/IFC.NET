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
using BuildingSmart.IFC.IfcPresentationDefinitionResource;

namespace BuildingSmart.IFC.IfcPresentationAppearanceResource
{
	[Guid("fb656ee5-6639-4cdf-b4c7-660220b1e753")]
	public abstract partial class IfcPreDefinedColour : IfcPreDefinedItem,
		IfcColour
	{
	
		protected IfcPreDefinedColour(IfcLabel name)
			: base(name)
		{
		}
	
	
	}
	
}
