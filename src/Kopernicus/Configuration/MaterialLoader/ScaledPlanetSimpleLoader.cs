// Material wrapper generated by shader translator tool
using System;
using Kopernicus.MaterialWrapper;
using UnityEngine;

namespace Kopernicus
{
    namespace Configuration
    {
        [RequireConfigType(ConfigType.Node)]
        public class ScaledPlanetSimpleLoader : ScaledPlanetSimple
        {
            // Main Color, default = (1,1,1,1)
            [ParserTarget("color")]
            public ColorParser colorSetter
            {
                get { return color; }
                set { color = value; }
            }

            // Specular Color, default = (0.5,0.5,0.5,1)
            [ParserTarget("specColor")]
            public ColorParser specColorSetter
            {
                get { return specColor; }
                set { specColor = value; }
            }

            // Shininess, default = 0.078125
            [ParserTarget("shininess")]
            public NumericParser<Single> shininessSetter
            {
                get { return shininess; }
                set { shininess = value; }
            }

            [ParserTarget("texture")]
            public Texture2DParser textureSetter
            {
                get { return mainTex; }
                set { mainTex = value; }
            }

            // Base (RGB) Gloss (A), default = "white" { }
            [ParserTarget("mainTex")]
            public Texture2DParser mainTexSetter
            {
                get { return mainTex; }
                set { mainTex = value; }
            }

            [ParserTarget("mainTexScale")]
            private Vector2Parser mainTexScaleSetter
            {
                get { return mainTexScale; }
                set { mainTexScale = value; }
            }

            [ParserTarget("mainTexOffset")]
            private Vector2Parser mainTexOffsetSetter
            {
                get { return mainTexOffset; }
                set { mainTexOffset = value; }
            }

            [ParserTarget("normals")]
            public Texture2DParser normalsSetter
            {
                get { return bumpMap; }
                set { bumpMap = value; }
            }

            // Normalmap, default = "bump" { }
            [ParserTarget("bumpMap")]
            public Texture2DParser bumpMapSetter
            {
                get { return bumpMap; }
                set { bumpMap = value; }
            }

            [ParserTarget("bumpMapScale")]
            private Vector2Parser bumpMapScaleSetter
            {
                get { return bumpMapScale; }
                set { bumpMapScale = value; }
            }

            [ParserTarget("bumpMapOffset")]
            private Vector2Parser bumpMapOffsetSetter
            {
                get { return bumpMapOffset; }
                set { bumpMapOffset = value; }
            }

            // Opacity, default = 1
            [ParserTarget("opacity")]
            public NumericParser<Single> opacitySetter
            {
                get { return opacity; }
                set { opacity = value; }
            }

            // Resource Map (RGB), default = "black" { }
            [ParserTarget("resourceMap")]
            public Texture2DParser resourceMapSetter
            {
                get { return resourceMap; }
                set { resourceMap = value; }
            }

            [ParserTarget("resourceMapScale")]
            private Vector2Parser resourceMapScaleSetter
            {
                get { return resourceMapScale; }
                set { resourceMapScale = value; }
            }

            [ParserTarget("resourceMapOffset")]
            private Vector2Parser resourceMapOffsetSetter
            {
                get { return resourceMapOffset; }
                set { resourceMapOffset = value; }
            }

            // Constructors
            public ScaledPlanetSimpleLoader () : base() { }
            [Obsolete("Creating materials from shader source String is no longer supported. Use Shader assets instead.")]
            public ScaledPlanetSimpleLoader (String contents) : base (contents) { }
            public ScaledPlanetSimpleLoader (Material material) : base(material) { }
        }
    }
}