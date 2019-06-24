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


namespace BuildingSmart.IFC.IfcPresentationOrganizationResource
{
	[Guid("4ac4c177-7e04-43cd-a011-14392fb9d2ba")]
	public partial class IfcLightIntensityDistribution :
		IfcLightDistributionDataSourceSelect
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("Standardized  light distribution curve used to define the luminous intensity of the light in all directions.")]
		[Required()]
		public IfcLightDistributionCurveEnum LightDistributionCurve { get; set; }
	
		[DataMember(Order = 1)] 
		[Description("<EPM-HTML>  <P>Light distribution data applied to the light source. It is defined by a list of main plane angles (B or C according to the light distribution curve chosen) that includes (for each B or C angle) a second list of secondary plane angles (the &#946; or &#947; angles) and the according luminous intensity distribution measures.  </P>  </EPM-HTML>")]
		[Required()]
		[MinLength(1)]
		public IList<IfcLightDistributionData> DistributionData { get; protected set; }
	
	
		public IfcLightIntensityDistribution(IfcLightDistributionCurveEnum lightDistributionCurve, IfcLightDistributionData[] distributionData)
		{
			this.LightDistributionCurve = lightDistributionCurve;
			this.DistributionData = new List<IfcLightDistributionData>(distributionData);
		}
	
	
	}
	
}
