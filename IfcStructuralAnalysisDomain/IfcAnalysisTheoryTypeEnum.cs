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


namespace BuildingSmart.IFC.IfcStructuralAnalysisDomain
{
	[Guid("3744faf0-78cc-4f10-aaee-7f3d8f165fef")]
	public enum IfcAnalysisTheoryTypeEnum
	{
		FIRST_ORDER_THEORY = 1,
	
		SECOND_ORDER_THEORY = 2,
	
		THIRD_ORDER_THEORY = 3,
	
		FULL_NONLINEAR_THEORY = 4,
	
		USERDEFINED = -1,
	
		NOTDEFINED = 0,
	
	}
}
