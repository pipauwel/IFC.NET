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
	[Guid("f41eee63-3267-438e-9a36-80d52d1ec158")]
	public abstract partial class IfcPreDefinedTextFont : IfcPreDefinedItem,
		IfcTextFontSelect
	{
	
		protected IfcPreDefinedTextFont(IfcLabel name)
			: base(name)
		{
		}
	
	
	}
	
}
