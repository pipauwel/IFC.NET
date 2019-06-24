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


namespace BuildingSmart.IFC.IfcPresentationAppearanceResource
{
	[Guid("1381d678-94e6-417d-bf36-57cc610f9189")]
	public partial class IfcTextStyleTextModel :
		IfcTextStyleSelect
	{
		[DataMember(Order = 0)] 
		[Description("<EPM-HTML>  The property specifies the indentation that appears before the first formatted line.    <blockquote> <small>NOTE&nbsp; It has been introduced for later compliance to full CSS1 support.</small></blockquote>  </EPM-HTML>")]
		public IfcSizeSelect TextIndent { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		[Description("<EPM-HTML>  This property describes how text is aligned horizontally within the element. The actual justification algorithm used is dependent on the rendering algorithm.  </EPM-HTML>")]
		public IfcTextAlignment? TextAlign { get; set; }
	
		[DataMember(Order = 2)] 
		[XmlAttribute]
		[Description("<EPM-HTML>  This property describes decorations that are added to the text of an element.  </EPM-HTML>")]
		public IfcTextDecoration? TextDecoration { get; set; }
	
		[DataMember(Order = 3)] 
		[Description("<EPM-HTML>  The length unit indicates an addition to the default space between characters. Values can be negative, but there may be implementation-specific limits. The user agent is free to select the exact spacing algorithm. The letter spacing may also be influenced by justification (which is a value of the 'align' property).    <blockquote> <small>NOTE&nbsp; The following values are allowed, <i>IfcDescriptiveMeasure</i> with value='normal', or <i>IfcLengthMeasure<i>, the length unit is globally defined at <i>IfcUnitAssignment</i>.</small></blockquote>  </EPM-HTML>")]
		public IfcSizeSelect LetterSpacing { get; set; }
	
		[DataMember(Order = 4)] 
		[Description("<EPM-HTML>  The length unit indicates an addition to the default space between words. Values can be negative, but there may be implementation-specific limits. The user agent is free to select the exact spacing algorithm. The word spacing may also be influenced by justification (which is a value of the 'text-align' property).    <blockquote> <small>NOTE&nbsp; It has been introduced for later compliance to full CSS1 support.</small></blockquote>  </EPM-HTML>")]
		public IfcSizeSelect WordSpacing { get; set; }
	
		[DataMember(Order = 5)] 
		[XmlAttribute]
		[Description("<EPM-HTML>  This property describes how text characters may transform to upper case, lower case, or capitalized case, independent of the character case used in the text literal.    <blockquote> <small>NOTE&nbsp; It has been introduced for later compliance to full CSS1 support.</small></blockquote>  </EPM-HTML>")]
		public IfcTextTransformation? TextTransform { get; set; }
	
		[DataMember(Order = 6)] 
		[Description("<EPM-HTML>  The property sets the distance between two adjacent lines' baselines.<br>  When a ratio value is specified, the line height is given by the font size of the current element multiplied with the numerical value. A value of 'normal' sets the line height to a reasonable value for the element's font. It is suggested that user agents set the 'normal' value to be a ratio number in the range of 1.0 to 1.2.    <blockquote> <small>NOTE&nbsp; The following values are allowed:<br> <i>IfcDescriptiveMeasure</i> with value='normal', or <br>  <i>IfcLengthMeasure<i>, with non-negative values, the length unit is globally defined at <i>IfcUnitAssignment</i>, or <br><i>IfcRatioMeasure</i>.</small></blockquote>  </EPM-HTML>")]
		public IfcSizeSelect LineHeight { get; set; }
	
	
		public IfcTextStyleTextModel()
		{
		}
	
	
	}
	
}
