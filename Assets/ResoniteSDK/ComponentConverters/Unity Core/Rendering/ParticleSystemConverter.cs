using FrooxEngine.PhotonDust;
using UnityEngine;
using ParticleSystem = FrooxEngine.PhotonDust.ParticleSystem;

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
    public ResRef<ParticleSystem> ParticleSystem;
    public ResRef<ParticleStyle> ParticleStyle;

    public ResRef<PositionSimulatorModule> PositionSimulator;
    public ResRef<LifetimeRangeInitializer> LifetimeInitializer;
    public ResRef<SizeRangeInitializer> SizeRangeInitializer;
    public ResRef<ColorRangeInitializer> ColorRangeInitializer;
    public ResRef<SpeedRangeInitializer> SpeedRangeInitializer;

    public ResRef<BillboardParticleRenderer> BillboardRenderer;
    public ResRef<MeshParticleRenderer> MeshRenderer;

    // Emitters
    public ResRef<BoxEmitter> BoxEmitter;
    public ResRef<SphereEmitter> SphereEmitter;
    public ResRef<ConeEmitter> ConeEmitter;
    public ResRef<MeshEmitter> MeshEmitter;
    public ResRef<SkinnedMeshEmitter> SkinnedMeshEmitter;
    public ResRef<CircleEmitter> CircleEmitter;

    // Modules

    TModule EnsureModule<TModule>(ref ResRef<TModule> wrapper)
        where TModule : ResoniteObject, IParticleSystemSubsystem, FrooxEngine.IWorldElement, new()
    {
        var style = ParticleStyle.Binding;

        return EnsureComponent<TModule>(ref wrapper, module => style.Modules.Add(module));
    }

    TEmitter EnsureEmitter<TEmitter>(ref ResRef<TEmitter> emitter)
        where TEmitter : ParticleEmitter, FrooxEngine.IWorldElement, new()
    {
        if (emitter == null)
        {
            // Remove any previous emitters
            CleanupEmitters();

            emitter = gameObject.AddResoniteComponent<TEmitter>();

            // Assign the system
            emitter.Binding.System = ParticleSystem.Binding;
        }

        return emitter.Binding;
    }

    protected override void UpdateConversion(UnityEngine.ParticleSystem target, IConversionContext context)
    {
        var system = EnsureComponent<FrooxEngine.PhotonDust.ParticleSystem>(ref ParticleSystem);
        var style = EnsureComponent<FrooxEngine.PhotonDust.ParticleStyle>(ref ParticleStyle,
            s => system.Style = s);

        var lifetime = EnsureModule<LifetimeRangeInitializer>(ref LifetimeInitializer);
        var size = EnsureModule<SizeRangeInitializer>(ref SizeRangeInitializer);
        var color = EnsureModule<ColorRangeInitializer>(ref ColorRangeInitializer);
        var speed = EnsureModule<SpeedRangeInitializer>(ref SpeedRangeInitializer);

        var position = EnsureModule<PositionSimulatorModule>(ref PositionSimulator);

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
                    BillboardRenderer = gameObject.AddResoniteComponent<BillboardParticleRenderer>();
                    system.Style.Renderer = BillboardRenderer.Binding;
                }

                var billboard = BillboardRenderer.Binding;
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
                    MeshRenderer = gameObject.AddResoniteComponent<MeshParticleRenderer>();
                    system.Style.Renderer = MeshRenderer.Binding;
                }

                var mesh = MeshRenderer.Binding;

                mesh.Material = context.GetMaterial(renderer.sharedMaterial);
                mesh.Mesh = context.GetMesh(renderer.mesh);

                break;
        }

        switch (shape.shapeType)
        {
            case ParticleSystemShapeType.Sphere:
                var sphere = EnsureEmitter(ref SphereEmitter);

                sphere.SetFrom(system, shape, emission);

                sphere.Radius = shape.radius;
                break;

            case ParticleSystemShapeType.Box:
                var box = EnsureEmitter(ref BoxEmitter);

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
                var circle = EnsureEmitter(ref CircleEmitter);

                circle.SetFrom(system, shape, emission);

                circle.Radius = shape.radius;
                circle.Scale = Vector2.one;
                break;

            case ParticleSystemShapeType.Cone:
                var cone = EnsureEmitter(ref ConeEmitter);

                cone.SetFrom(system, shape, emission);

                cone.BaseRadius = shape.radius;
                cone.Height = shape.length;
                break;

            case ParticleSystemShapeType.Mesh:
                var mesh = EnsureEmitter(ref MeshEmitter);

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
                var skin = EnsureEmitter(ref SkinnedMeshEmitter);

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
        ParticleStyle.Binding.Modules.Data.RemoveAll(m => m.Data == null);
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