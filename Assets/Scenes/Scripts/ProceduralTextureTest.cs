using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class ProceduralTextureTest : MonoBehaviour
{
    public int Size = 128;

    [Range(0.01f, 0.1f)]
    public float NoiseScale = 0.05f;

    public Color From = Color.black;
    public Color To = Color.white;

    int _computedSize;
    float _computedNoiseScale;
    Color _computedFrom;
    Color _computedTo;

    void Awake()
    {
        Update();
    }

    void Update()
    {
        if (_computedSize == Size &&
            _computedNoiseScale == NoiseScale &&
            _computedFrom == From &&
            _computedTo == To)
            return;

        var tex = new Texture2D(Size, Size, TextureFormat.ARGB32, false);
        
        for(int y = 0; y < Size; y++)
            for(int x = 0; x < Size; x++)
            {
                var noise = Mathf.PerlinNoise(x * NoiseScale, y * NoiseScale);
                var color = Color.Lerp(From, To, noise);

                tex.SetPixel(x, y, color);
            }

        tex.Apply();

        _computedSize = Size;
        _computedNoiseScale = NoiseScale;
        _computedFrom = From;
        _computedTo = To;

        var material = GetComponent<MeshRenderer>()?.sharedMaterial;

        if (material != null)
            material.mainTexture = tex;
    }
}
