using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class SdfRenderFeature : ScriptableRendererFeature
{

    public enum TextureSize
    {
        _64 = 64,
        _128 = 128,
        _256 = 256,
        _512 = 512,
        _1024 = 1024
    }
    [Serializable]
    public class FeatureSettings
    {
        public TextureSize size = TextureSize._64;
    }

    private SDFGeneratorPass m_SDFGeneratorPass;
    
    public override void Create()
    {
        if (m_SDFGeneratorPass == null)
        {
            m_SDFGeneratorPass = new SDFGeneratorPass();
            m_SDFGeneratorPass.renderPassEvent = RenderPassEvent.BeforeRendering;
        }
    }

    public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
    {
        renderer.EnqueuePass(m_SDFGeneratorPass);
    }

    

    public static class ShaderConstants
    {
        public static int s_AABB = Shader.PropertyToID("_AABB");
    }
    
    public class SDFGeneratorPass : ScriptableRenderPass
    {
        private RTHandle m_DummyRenderTarget;
        public override void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData)
        {
            base.OnCameraSetup(cmd, ref renderingData);
            m_DummyRenderTarget = 
        }

        public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
        {
            
        }
    }
}
