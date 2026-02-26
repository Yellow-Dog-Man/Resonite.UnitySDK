using FrooxEngine.PhotonDust;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class EmitterHelper
{
    public static void SetFrom(this FrooxEngine.PhotonDust.ParticleEmitter emitter,
        FrooxEngine.PhotonDust.ParticleSystem system,
        UnityEngine.ParticleSystem.ShapeModule shape, UnityEngine.ParticleSystem.EmissionModule emission)
    {
        emitter.Enabled = shape.enabled;
        emitter.System = system;

        // TODO!!! Handle other styles?
        emitter.Rate = emission.rateOverTime.constant;
    }
}

public class ParticleSystemConverter : ResoniteComponentConverter<UnityEngine.ParticleSystem>
{
    public ParticleSystemWrapper ParticleSystem;
    public ParticleStyleWrapper ParticleStyle;

    public PositionSimulatorModuleWrapper PositionSimulator;
    public LifetimeRangeInitializerWrapper LifetimeInitializer;
    public SizeRangeInitializerWrapper SizeRangeInitializer;
    public ColorRangeInitializerWrapper ColorRangeInitializer;
    public SpeedRangeInitializerWrapper SpeedRangeInitializer;

    public BillboardParticleRendererWrapper BillboardRenderer;
    public MeshParticleRendererWrapper MeshRenderer;

    // Emitters
    public BoxEmitterWrapper BoxEmitter;
    public SphereEmitterWrapper SphereEmitter;
    public ConeEmitterWrapper ConeEmitter;
    public MeshEmitterWrapper MeshEmitter;
    public SkinnedMeshEmitterWrapper SkinnedMeshEmitter;
    public CircleEmitterWrapper CircleEmitter;

    // Modules

    TModule EnsureModule<TModule, TWrapper>(ref TWrapper wrapper)
        where TWrapper : ResoniteComponent<TModule>
        where TModule : ResoniteObject, IParticleSystemSubsystem, FrooxEngine.IWorldElement, new()
    {
        var style = ParticleStyle.Data;

        return EnsureComponent<TModule, TWrapper>(ref wrapper, module => style.Modules.Add(module));
    }

    TEmitter EnsureEmitter<TEmitter, TWrapper>(ref TWrapper wrapper)
        where TWrapper : ResoniteComponent<TEmitter>
        where TEmitter : ParticleEmitter, FrooxEngine.IWorldElement, new()
    {
        if (wrapper == null)
        {
            // Remove any previous emitters
            CleanupEmitters();

            wrapper = gameObject.AddComponent<TWrapper>();

            // Assign the system
            wrapper.Data.System = ParticleSystem.Data;
        }

        return wrapper.Data;
    }

    protected override void UpdateConversion(UnityEngine.ParticleSystem target, IConversionContext context)
    {
        var system = EnsureComponent<FrooxEngine.PhotonDust.ParticleSystem, ParticleSystemWrapper>(ref ParticleSystem);
        var style = EnsureComponent<FrooxEngine.PhotonDust.ParticleStyle, ParticleStyleWrapper>(ref ParticleStyle,
            s => system.Style = s);

        var lifetime = EnsureModule<LifetimeRangeInitializer, LifetimeRangeInitializerWrapper>(ref LifetimeInitializer);
        var size = EnsureModule<SizeRangeInitializer, SizeRangeInitializerWrapper>(ref SizeRangeInitializer);
        var color = EnsureModule<ColorRangeInitializer, ColorRangeInitializerWrapper>(ref ColorRangeInitializer);
        var speed = EnsureModule<SpeedRangeInitializer, SpeedRangeInitializerWrapper>(ref SpeedRangeInitializer);

        var position = EnsureModule<PositionSimulatorModule, PositionSimulatorModuleWrapper>(ref PositionSimulator);

        system.Enabled = true;
        system.persistent = true;

        var main = target.main;
        var renderer = target.gameObject.GetComponent<ParticleSystemRenderer>();
        var emission = target.emission;
        var shape = target.shape;

        system.MaxParticleCount = main.maxParticles;
        system.Style = style;

        // Lifetime
        switch (main.startLifetime.mode)
        {
            case ParticleSystemCurveMode.Constant:
                lifetime.MinValue = lifetime.MaxValue = main.startLifetime.constant;
                break;

            case ParticleSystemCurveMode.TwoConstants:
                lifetime.MinValue = main.startLifetime.constantMin;
                lifetime.MaxValue = main.startLifetime.constantMax;
                break;
        }

        // Size
        switch (main.startSize.mode)
        {
            case ParticleSystemCurveMode.Constant:
                size.MinValue = size.MaxValue = main.startSize.constant * Vector3.one;
                break;

            case ParticleSystemCurveMode.TwoConstants:
                size.MinValue = main.startSize.constantMin * Vector3.one;
                size.MaxValue = main.startSize.constantMax * Vector3.one;
                break;
        }

        // Speed
        switch (main.startSpeed.mode)
        {
            case ParticleSystemCurveMode.Constant:
                speed.MinValue = speed.MaxValue = main.startSpeed.constant;
                break;

            case ParticleSystemCurveMode.TwoConstants:
                speed.MinValue = main.startSpeed.constantMin;
                speed.MaxValue = main.startSpeed.constantMax;
                break;
        }

        // Color
        switch (main.startColor.mode)
        {
            case ParticleSystemGradientMode.Color:
                color.MinValue = color.MaxValue = main.startColor.color.ToColorX_sRGB();
                break;

            case ParticleSystemGradientMode.TwoColors:
                color.MinValue = main.startColor.colorMin.ToColorX_sRGB();
                color.MaxValue = main.startColor.colorMax.ToColorX_sRGB();
                break;
        }

        switch (renderer.renderMode)
        {
            case ParticleSystemRenderMode.Billboard:
                if (BillboardRenderer == null)
                {
                    CleanupRenderers();
                    BillboardRenderer = gameObject.AddComponent<BillboardParticleRendererWrapper>();
                    system.Style.Renderer = BillboardRenderer.Data;
                }

                var billboard = BillboardRenderer.Data;
                var provider = context.GetMaterial(renderer.sharedMaterial);

                billboard.Material = provider;
                billboard.MinBillboardScreenSize = renderer.minParticleSize;
                billboard.MaxBillboardScreenSize = renderer.maxParticleSize;

                billboard.Alignment = Renderite.Shared.BillboardAlignment.Facing;

                break;

            case ParticleSystemRenderMode.Mesh:
                if (MeshRenderer == null)
                {
                    CleanupRenderers();
                    MeshRenderer = gameObject.AddComponent<MeshParticleRendererWrapper>();
                    system.Style.Renderer = MeshRenderer.Data;
                }

                var mesh = MeshRenderer.Data;

                mesh.Material = context.GetMaterial(renderer.sharedMaterial);
                mesh.Mesh = context.GetMesh(renderer.mesh);

                break;
        }

        switch (shape.shapeType)
        {
            case ParticleSystemShapeType.Sphere:
                var sphere = EnsureEmitter<SphereEmitter, SphereEmitterWrapper>(ref SphereEmitter);

                sphere.SetFrom(system, shape, emission);

                sphere.Radius = shape.radius;
                break;

            case ParticleSystemShapeType.Box:
                var box = EnsureEmitter<BoxEmitter, BoxEmitterWrapper>(ref BoxEmitter);

                box.SetFrom(system, shape, emission);

                box.Size = shape.scale;

                box.EmitFromShell = shape.shapeType == ParticleSystemShapeType.BoxShell;

                box.Color0 = Color.white.ToColorX_sRGB();
                box.Color1 = Color.white.ToColorX_sRGB();
                box.Color2 = Color.white.ToColorX_sRGB();
                box.Color3 = Color.white.ToColorX_sRGB();
                box.Color4 = Color.white.ToColorX_sRGB();
                box.Color5 = Color.white.ToColorX_sRGB();
                box.Color6 = Color.white.ToColorX_sRGB();
                box.Color7 = Color.white.ToColorX_sRGB();
                break;

            case ParticleSystemShapeType.Circle:
                var circle = EnsureEmitter<CircleEmitter, CircleEmitterWrapper>(ref CircleEmitter);

                circle.SetFrom(system, shape, emission);

                circle.Radius = shape.radius;
                circle.Scale = Vector2.one;
                break;

            case ParticleSystemShapeType.Cone:
                var cone = EnsureEmitter<ConeEmitter, ConeEmitterWrapper>(ref ConeEmitter);

                cone.SetFrom(system, shape, emission);

                cone.BaseRadius = shape.radius;
                cone.Height = shape.length;
                break;

            case ParticleSystemShapeType.Mesh:
                var mesh = EnsureEmitter<MeshEmitter, MeshEmitterWrapper>(ref MeshEmitter);

                mesh.SetFrom(system, shape, emission);

                mesh.Mesh = context.GetMesh(shape.mesh);
                mesh.UniformDistribution = true;

                switch(shape.meshShapeType)
                {
                    case ParticleSystemMeshShapeType.Vertex: mesh.EmitFrom = PhotonDust.MeshEmissionSource.Vertices; break;
                    case ParticleSystemMeshShapeType.Edge: mesh.EmitFrom = PhotonDust.MeshEmissionSource.Edges; break;
                    case ParticleSystemMeshShapeType.Triangle: mesh.EmitFrom = PhotonDust.MeshEmissionSource.Faces; break;
                }
                break;

            case ParticleSystemShapeType.SkinnedMeshRenderer:
                var skin = EnsureEmitter<SkinnedMeshEmitter, SkinnedMeshEmitterWrapper>(ref SkinnedMeshEmitter);

                skin.SetFrom(system, shape, emission);

                switch (shape.meshShapeType)
                {
                    case ParticleSystemMeshShapeType.Vertex: skin.EmitFrom = PhotonDust.MeshEmissionSource.Vertices; break;
                    case ParticleSystemMeshShapeType.Edge: skin.EmitFrom = PhotonDust.MeshEmissionSource.Edges; break;
                    case ParticleSystemMeshShapeType.Triangle: skin.EmitFrom = PhotonDust.MeshEmissionSource.Faces; break;
                }

                // TODO!!!
                //skin.Skin = shape.skinnedMeshRenderer;
                break;
        }

        CleanupRemovedModules();
    }

    void CleanupRemovedModules()
    {
        ParticleStyle.Data.Modules.Data.RemoveAll(m => m.Data == null);
    }

    void CleanupRenderers()
    {
        if (BillboardRenderer != null)
            DestroyImmediate(BillboardRenderer);

        if (MeshRenderer != null)
            DestroyImmediate(MeshRenderer);
    }

    void CleanupEmitters()
    {
        if (BoxEmitter != null)
            DestroyImmediate(BoxEmitter);

        if (SphereEmitter != null)
            DestroyImmediate(SphereEmitter);

        if (ConeEmitter != null)
            DestroyImmediate(ConeEmitter);

        if (MeshEmitter != null)
            DestroyImmediate(MeshEmitter);

        if (SkinnedMeshEmitter != null)
            DestroyImmediate(SkinnedMeshEmitter);

        if (CircleEmitter != null)
            DestroyImmediate(CircleEmitter);
    }

    protected override void Cleanup()
    {
        CleanupRenderers();
        CleanupEmitters();
    }
}