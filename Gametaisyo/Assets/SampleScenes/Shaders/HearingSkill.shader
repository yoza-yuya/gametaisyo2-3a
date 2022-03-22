﻿Shader "Unlit/HearingSkill"
{
    Properties
    {
        _MainTex("Texture", 2D) = "white" {}
        [HDR] _Color("Color", Color) = (1,1,1,1)
    }

        CGINCLUDE
#include "UnityCG.cginc"
            struct appdata
        {
            float4 vertex : POSITION;
            float2 uv : TEXCOORD0;
        };

        struct v2f
        {
            float2 uv : TEXCOORD0;
            float4 vertex : SV_POSITION;
            UNITY_FOG_COORDS(1)
        };

        sampler2D _MainTex;
        float4 _MainTex_ST;
        float4 _Color;

        v2f vert(appdata v)
        {
            v2f o;
            o.vertex = UnityObjectToClipPos(v.vertex);
            o.uv = TRANSFORM_TEX(v.uv, _MainTex);
            UNITY_TRANSFER_FOG(o, o.vertex);
            return o;
        }

        fixed4 frag(v2f i) : SV_Target
        {
            // sample the texture
            fixed4 col = tex2D(_MainTex, i.uv) * _Color;
        // apply fog
        UNITY_APPLY_FOG(i.fogCoord, col);
        return col;
        }
            ENDCG

            SubShader
        {
            Tags{ "RenderType" = "Opaque" "Queue" = "Geometry+10" }
                LOD 100

                Pass
            {
                CULL Back
                ZWrite Off
                ZTest Greater
                CGPROGRAM
                #pragma vertex vert
                #pragma fragment frag
                // make fog work
                #pragma multi_compile_fog
                ENDCG
            }
        }
}
