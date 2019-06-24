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

namespace BuildingSmart.IFC.IfcPresentationDefinitionResource
{
	[Guid("4f599f7a-bf71-4ebd-b620-50f26bd659ca")]
	public abstract partial class IfcPreDefinedSymbol : IfcPreDefinedItem,
		IfcDefinedSymbolSelect
	{
	
		protected IfcPreDefinedSymbol(IfcLabel name)
			: base(name)
		{
		}
	
	
	}
	
}
