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
using BuildingSmart.IFC.IfcPresentationResource;

namespace BuildingSmart.IFC.IfcPresentationAppearanceResource
{
	[Guid("571d69df-1dc0-4915-a86e-4798da613d70")]
	public abstract partial class IfcPreDefinedCurveFont : IfcPreDefinedItem,
		IfcCurveStyleFontSelect
	{
	
		protected IfcPreDefinedCurveFont(IfcLabel name)
			: base(name)
		{
		}
	
	
	}
	
}
