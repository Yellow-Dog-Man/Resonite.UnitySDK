using BepuPhysics.Collidables;
using FrooxEngine;
using ResoniteLink;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace ResoniteSDK.Editor {
    public struct AssetMap<A> : IEquatable<AssetMap<A>>
        where A : UnityEngine.Object
    {
        public readonly A Asset;
        public readonly AssetMessagePostProcessor PostProcessor;

        public AssetMap(A asset, AssetMessagePostProcessor postProcessor)
        {
            this.Asset = asset;
            PostProcessor = postProcessor;
        }

        public bool Equals(AssetMap<A> other) => Asset == other.Asset && PostProcessor == other.PostProcessor;
        public override int GetHashCode() => HashCode.Combine(Asset, PostProcessor);
    }

    public class AssetConversionManager
    {
        public const string ASSETS_ROOT_NAME = "__UnityAssets";

        public SceneConverter Converter { get; private set; }
        public Transform AssetsRoot { get; private set; }

        public bool HasPendingChanges => _scheduledConversions.Count > 0 || _updatedAssetProviderRoots.Count > 0;

        Dictionary<AssetMap<UnityEngine.Mesh>, MeshConverter> _meshes = new Dictionary<AssetMap<UnityEngine.Mesh>, MeshConverter>();
        Dictionary<AssetMap<UnityEngine.Texture2D>, Texture2DConverter> _textures = new Dictionary<AssetMap<UnityEngine.Texture2D>, Texture2DConverter>();
        Dictionary<AssetMap<UnityEngine.Cubemap>, CubemapConverter> _cubemaps = new Dictionary<AssetMap<UnityEngine.Cubemap>, CubemapConverter>();
        Dictionary<AssetMap<UnityEngine.AudioClip>, AudioClipConverter> _audioClips = new Dictionary<AssetMap<UnityEngine.AudioClip>, AudioClipConverter>();

        Dictionary<UnityEngine.Material, ResoniteMaterialConverter> _materials = new Dictionary<UnityEngine.Material, ResoniteMaterialConverter>();
        Dictionary<UnityEngine.Material, FrooxEngine.IAssetProvider<FrooxEngine.Material>> _cachedMaterials = new Dictionary<UnityEngine.Material, IAssetProvider<FrooxEngine.Material>>();

        HashSet<AssetConverter> _checkedConverters = new HashSet<AssetConverter>();
        Queue<AssetConverter> _scheduledConversions = new Queue<AssetConverter>();

        HashSet<Transform> _updatedAssetProviderRoots = new HashSet<Transform>();

        public IEnumerable<Transform> UpdatedAssetProviderRoots => _updatedAssetProviderRoots;

        public AssetConversionManager(SceneConverter converter)
        {
            Converter = converter;

            // Check if there's already assets root in the world
            var roots = SceneManager.GetActiveScene().GetRootGameObjects();

            AssetsRoot = roots.FirstOrDefault(r => r.name == ASSETS_ROOT_NAME)?.transform;

            if(AssetsRoot != null)
            {
                // Scan all the existing converters
                ScanConverters<StaticMesh, UnityEngine.Mesh, FrooxEngine.Mesh, MeshConverter>(_meshes);
                ScanConverters<StaticTexture2D, UnityEngine.Texture2D, FrooxEngine.Texture2D, Texture2DConverter>(_textures);
                ScanConverters<StaticCubemap, UnityEngine.Cubemap, FrooxEngine.Cubemap, CubemapConverter>(_cubemaps);
                ScanConverters<StaticAudioClip, UnityEngine.AudioClip, FrooxEngine.AudioClip, AudioClipConverter>(_audioClips);

                // Materials are special!
                ScanMaterials();
            }
            else
                AssetsRoot = (new GameObject(ASSETS_ROOT_NAME)).transform; // Create new root
        }

        void ScanConverters<TProvider, TUnity, TResonite, TConverter>(Dictionary<AssetMap<TUnity>, TConverter> map)
            where TProvider : FrooxEngine.Component, IAssetProvider<TResonite>, new()
            where TResonite : FrooxEngine.IAsset
            where TConverter : AssetConverter<TProvider, TUnity, TResonite>
            where TUnity : UnityEngine.Object
        {
            var converters = AssetsRoot.GetComponentsInChildren<TConverter>();

            foreach (var converter in converters)
            {
                if (converter.Source == null || converter.Provider == null)
                {
                    // TODO!!! Cleanup?
                    continue;
                }

                map.Add(new AssetMap<TUnity>(converter.Source, converter.PostProcessor), converter);
            }
        }

        void ScanMaterials()
        {
            var converters = AssetsRoot.GetComponentsInChildren<ResoniteMaterialConverter>();

            foreach (var converter in converters)
            {
                if (converter.Source == null)
                {
                    // TODO!!! Cleanup?
                    continue;
                }

                _materials.Add(converter.Source, converter);
            }
        }

        public void BeginConversion()
        {
            // Clear all the cached materials from previous conversion. Unlike other asset types, materials can
            // change between conversions - e.g. their parameters are updated, so we want to re-run the conversion
            // every time.
            _cachedMaterials.Clear();

            // Since we're running a new conversion batch, we need to re-check all the converters again, because the assets
            // might have changed.
            _checkedConverters.Clear();
        }

        public bool HasMesh(UnityEngine.Mesh mesh, AssetMessagePostProcessor postProcessor = null) =>
            _meshes.ContainsKey(new AssetMap<UnityEngine.Mesh>(mesh, postProcessor));

        public bool HasTexture2D(UnityEngine.Texture2D texture2D, AssetMessagePostProcessor postProcessor = null) =>
            _textures.ContainsKey(new AssetMap<UnityEngine.Texture2D>(texture2D, postProcessor));
        public bool HasCubemap(UnityEngine.Cubemap cubemap, AssetMessagePostProcessor postProcessor = null) =>
            _cubemaps.ContainsKey(new AssetMap<UnityEngine.Cubemap>(cubemap, postProcessor));
        public bool HasAudioClip(UnityEngine.AudioClip audioClip, AssetMessagePostProcessor postProcessor = null) => 
            _audioClips.ContainsKey(new AssetMap<UnityEngine.AudioClip>(audioClip, postProcessor));
        public bool HasMaterial(UnityEngine.Material material, AssetMessagePostProcessor postProcessor = null) => _materials.ContainsKey(material);

        public IAssetProvider<FrooxEngine.Mesh> GetMesh(UnityEngine.Mesh mesh, AssetMessagePostProcessor postProcessor = null) =>
            GetAsset<StaticMesh, UnityEngine.Mesh, FrooxEngine.Mesh, MeshConverter>(
                mesh, postProcessor, _meshes);

        public IAssetProvider<FrooxEngine.Texture2D> GetTexture2D(UnityEngine.Texture2D texture, AssetMessagePostProcessor postProcessor = null) =>
            GetAsset<StaticTexture2D, UnityEngine.Texture2D, FrooxEngine.Texture2D, Texture2DConverter>(
                texture, postProcessor, _textures);

        public IAssetProvider<FrooxEngine.Cubemap> GetCubemap(UnityEngine.Cubemap cubemap, AssetMessagePostProcessor postProcessor = null) =>
            GetAsset<StaticCubemap, UnityEngine.Cubemap, FrooxEngine.Cubemap, CubemapConverter>(
                cubemap, postProcessor, _cubemaps);

        public IAssetProvider<FrooxEngine.AudioClip> GetAudioClip(UnityEngine.AudioClip audioClip, AssetMessagePostProcessor postProcessor = null) =>
            GetAsset<StaticAudioClip, UnityEngine.AudioClip, FrooxEngine.AudioClip, AudioClipConverter>(
                audioClip, postProcessor, _audioClips);

        TProvider GetAsset<TProvider, TUnity, TResonite, TConverter>(TUnity unity, AssetMessagePostProcessor postProcessor,
            Dictionary<AssetMap<TUnity>, TConverter> converters)
            where TProvider : FrooxEngine.Component, IAssetProvider<TResonite>, new()
            where TResonite : FrooxEngine.IAsset
            where TConverter : AssetConverter<TProvider, TUnity, TResonite>
            where TUnity : UnityEngine.Object
        {
            if (unity == null)
                throw new ArgumentNullException(nameof(unity));

            bool needsToConvert = false;

            var identity = new AssetMap<TUnity>(unity, postProcessor);

            if (!converters.TryGetValue(identity, out var converter))
            {
                // There's no active converter for this, so create one
                var go = new GameObject();
                go.transform.parent = AssetsRoot;

                converter = go.AddComponent<TConverter>();
                converter.Initialize(unity, postProcessor);

                // Since it's brand new it needs to be converted for the first time
                needsToConvert = true;

                converters.Add(identity, converter);
            }
            else if (_checkedConverters.Add(converter) && converter.HasAssetChanged())
            {
                // We haven't checked this conversion yet for updates and the asset has changed
                // so we need to run the conversion again to update the data
                needsToConvert = true;
            }

            if (needsToConvert)
            {
                _scheduledConversions.Enqueue(converter);

                _updatedAssetProviderRoots.Add(converter.Provider.Container.transform);
            }

            return converter.Provider.Binding;
        }

        public IAssetProvider<FrooxEngine.Material> GetMaterial(UnityEngine.Material material)
        {
            // Check if there's already conversion and it's bee updated
            if (_cachedMaterials.TryGetValue(material, out var provider))
                return provider;

            // Check if there's an active converter
            if (!_materials.TryGetValue(material, out var converter))
            {
                // There's no converter! Try to find one
                var converterType = MaterialConverterRepository.TryGetConverter(material);

                if(converterType == null)
                {
                    Debug.LogWarning($"Unable to convert material {material}. Shader: {material.shader?.name}");

                    // Set it to null. We still want to cache null converted material so we're not doing
                    // this whole search & evaluation every single time this material is requested
                    converter = null;
                }
                else
                {
                    // Create the conversion
                    var root = new GameObject($"Material - {material.name}");
                    root.transform.parent = AssetsRoot;

                    // Attach the converter itself
                    converter = (ResoniteMaterialConverter)root.AddComponent(converterType);
                    converter.Source = material;

                    // We do want to store the converter across conversions - they will update existing material
                    // in place in most cases, so we don't want to keep making new ones all the time
                    _materials.Add(material, converter);
                }
            }

            // Update the conversion and get the latest material provider
            // This is important, because converter can change the actual material instance depending on the
            // properties provided. The converter can all be null, hence the null check
            provider = converter?.UpdateConversion(material, Converter);

            if (provider != null)
                _updatedAssetProviderRoots.Add(converter.transform);

            // Cache it for this run - the same material only needs to be converted/updated once per run
            _cachedMaterials.Add(material, provider);

            return provider;
        }

        public void ProcessConversions(LinkInterface link)
        {
            try
            {
                int totalToConvert = _scheduledConversions.Count;

                while (_scheduledConversions.Count > 0)
                {
                    var progress = (totalToConvert - _scheduledConversions.Count) / (float)totalToConvert;

                    var job = _scheduledConversions.Dequeue();

                    EditorUtility.DisplayProgressBar("Converting assets...", $"{job.AssetClass}: {job.AssetName}", progress);

                    job.Convert(Converter, link);
                }

                // Once conversions are processed, clear this. This is only relevant before the conversions take place
                _updatedAssetProviderRoots.Clear();
            }
            finally
            {
                EditorUtility.ClearProgressBar();
            }
        }
    }
}