//----------------------
// <auto-generated>
//     Generated using the NJsonSchema v10.1.21.0 (Newtonsoft.Json v12.0.0.0) (http://NJsonSchema.org)
// </auto-generated>
//----------------------
using Elements;
using Elements.GeoJSON;
using Elements.Geometry;
using Elements.Geometry.Solids;
//using Elements.Properties;
using Elements.Validators;
using Elements.Serialization.JSON;
using System;
using System.Collections.Generic;
using System.Linq;
using Line = Elements.Geometry.Line;
using Polygon = Elements.Geometry.Polygon;

namespace Elements
{
    #pragma warning disable // Disable all warnings

    /// <summary>A horizontal Roof.</summary>
    [Newtonsoft.Json.JsonConverter(typeof(Elements.Serialization.JSON.JsonInheritanceConverter), "discriminator")]
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v12.0.0.0)")]
    //[UserElement]
	public partial class Roof : GeometricElement
    {
        [Newtonsoft.Json.JsonConstructor]
        public Roof(Mesh @envelope, Mesh @topside, Mesh @underside, Polygon @perimeter, double @elevation, double @highpoint, double @thickness, double @area, Transform @transform, Material @material, Representation @representation, bool @isElementDefinition, System.Guid @id, string @name)
            : base(transform, material, representation, isElementDefinition, id, name)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<Roof>
            ();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @envelope, @topside, @underside, @perimeter, @elevation, @highpoint, @thickness, @area, @transform, @material, @representation, @isElementDefinition, @id, @name});
            }
        
                this.Envelope = @envelope;
                this.Topside = @topside;
                this.Underside = @underside;
                this.Perimeter = @perimeter;
                this.Elevation = @elevation;
                this.Highpoint = @highpoint;
                this.Thickness = @thickness;
                this.Area = @area;
            
            if(validator != null)
            {
            validator.PostConstruct(this);
            }
            }
    
        /// <summary>Boundary of the Roof system as a Mesh.</summary>
        [Newtonsoft.Json.JsonProperty("Envelope", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Mesh Envelope { get; set; }
    
        /// <summary>Top surface of the Roof as a Mesh.</summary>
        [Newtonsoft.Json.JsonProperty("Topside", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Mesh Topside { get; set; }
    
        /// <summary>Bottom surface of the Roof as a Mesh.</summary>
        [Newtonsoft.Json.JsonProperty("Underside", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Mesh Underside { get; set; }
    
        /// <summary>Bottom perimter of the Roof as a Polygon.</summary>
        [Newtonsoft.Json.JsonProperty("Perimeter", Required = Newtonsoft.Json.Required.AllowNull)]
        public Polygon Perimeter { get; set; }
    
        /// <summary>Elevation of the Roof's lowest underside point.</summary>
        [Newtonsoft.Json.JsonProperty("Elevation", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Range(0D, double.MaxValue)]
        public double Elevation { get; set; }
    
        /// <summary>Elevation of the Roof's highest topside point.</summary>
        [Newtonsoft.Json.JsonProperty("Highpoint", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Range(0D, double.MaxValue)]
        public double Highpoint { get; set; }
    
        /// <summary>The thickness of the Roof at its thinnest point between Topside surface and Underside surface.</summary>
        [Newtonsoft.Json.JsonProperty("Thickness", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Range(0D, double.MaxValue)]
        public double Thickness { get; set; }
    
        /// <summary>The area of the Roof Topside surface.</summary>
        [Newtonsoft.Json.JsonProperty("Area", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Range(0D, double.MaxValue)]
        public double Area { get; set; }
    
    
    }
}