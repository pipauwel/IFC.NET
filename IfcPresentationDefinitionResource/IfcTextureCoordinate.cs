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


namespace BuildingSmart.IFC.IfcPresentationDefinitionResource
{
	[Guid("b2cdbd80-cb69-4247-ac58-2a3ef452036e")]
	public abstract partial class IfcTextureCoordinate
	{
		[InverseProperty("TextureCoordinates")] 
		[MinLength(1)]
		[MaxLength(1)]
		public ISet<IfcAnnotationSurface> AnnotatedSurface { get; protected set; }
	
	
		protected IfcTextureCoordinate()
		{
			this.AnnotatedSurface = new HashSet<IfcAnnotationSurface>();
		}
	
	
	}
	
}
