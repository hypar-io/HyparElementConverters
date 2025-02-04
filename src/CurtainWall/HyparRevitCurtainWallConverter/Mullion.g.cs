//----------------------
// <auto-generated>
//     Generated using the NJsonSchema v10.1.21.0 (Newtonsoft.Json v12.0.0.0) (http://NJsonSchema.org)
// </auto-generated>
//----------------------
using Elements;
using Elements.GeoJSON;
using Elements.Geometry;
using Elements.Geometry.Solids;
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

    [Newtonsoft.Json.JsonConverter(typeof(Elements.Serialization.JSON.JsonInheritanceConverter), "discriminator")]
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class Mullion : GeometricElement
    {
        [Newtonsoft.Json.JsonConstructor]
        public Mullion(Profile @profile, Line @centerLine, double @length, Transform @transform, Material @material, Representation @representation, bool @isElementDefinition, System.Guid @id, string @name)
            : base(transform, material, representation, isElementDefinition, id, name)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<Mullion>
            ();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @profile, @centerLine, @length, @transform, @material, @representation, @isElementDefinition, @id, @name});
            }
        
                this.Profile = @profile;
                this.CenterLine = @centerLine;
                this.Length = @length;
            
            if(validator != null)
            {
            validator.PostConstruct(this);
            }
            }
    
        /// <summary>The cross-section of the mullion.</summary>
        [Newtonsoft.Json.JsonProperty("Profile", Required = Newtonsoft.Json.Required.AllowNull)]
        public Profile Profile { get; set; }
    
        /// <summary>The center line of the mullion.</summary>
        [Newtonsoft.Json.JsonProperty("CenterLine", Required = Newtonsoft.Json.Required.AllowNull)]
        public Line CenterLine { get; set; }
    
        /// <summary>The length of the mullion.</summary>
        [Newtonsoft.Json.JsonProperty("Length", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double Length { get; set; }
    
    
    }
}