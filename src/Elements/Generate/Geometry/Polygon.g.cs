//----------------------
// <auto-generated>
//     Generated using the NJsonSchema v10.0.27.0 (Newtonsoft.Json v12.0.0.0) (http://NJsonSchema.org)
// </auto-generated>
//----------------------
using Elements;
using Elements.GeoJSON;
using Elements.Geometry;
using Elements.Geometry.Solids;
using Elements.Properties;
using Elements.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using Line = Elements.Geometry.Line;
using Polygon = Elements.Geometry.Polygon;

namespace Elements.Geometry
{
    #pragma warning disable // Disable all warnings

    /// <summary>A closed planar polygon.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.27.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class Polygon : Polyline
    {
        [Newtonsoft.Json.JsonConstructor]
        public Polygon(IList<Vector3> @vertices)
            : base(vertices)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<Polygon>();
            if(validator != null)
            {
                validator.Validate(new object[]{ @vertices});
            }
        
        }
    
    
    }
}