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
	[Guid("9d0506f4-1626-4bd0-8b81-426609d1f6c0")]
	public abstract partial class IfcPreDefinedCurveFont : IfcPreDefinedItem,
		IfcCurveStyleFontSelect
	{
	
		protected IfcPreDefinedCurveFont(IfcLabel name)
			: base(name)
		{
		}
	
	
	}
	
}
