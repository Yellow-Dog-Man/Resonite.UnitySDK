using FrooxEngine;
using ResoniteLink;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using UnityEngine;

public class MeshConversionJob
{
    public const int MAX_UV_CHANNEL_COUNT = 8;

    public readonly UnityEngine.Mesh Source;
    public readonly StaticMeshWrapper Provider;

    public MeshConversionJob(UnityEngine.Mesh source, StaticMeshWrapper provider)
    {
        this.Source = source;
        this.Provider = provider;
    }

    public void Convert(AssetConversionManager manager, LinkInterface link)
    {
        var data = ConvertMesh(Source);
        var name = Source.name;

        Task.Run(async () =>
        {
            var result = await link.ImportMesh(data);

            if (!result.Success)
            {
                Debug.LogError($"Failed to convert mesh {name}: {result.ErrorInfo}");
                return;
            }

            // Assign the URL of the converted mesh
            Provider.Data.URL = result.AssetURL;

            // Send the update! 
            // We could just do it all at once, but having it pop piece by piece is more interactive and looks cooler :3
            var update = (UpdateComponent)Provider.CollectData(manager.Converter);
            var updateResult = await link.UpdateComponent(update);

            if (!updateResult.Success)
                Debug.LogError($"Failed to update asset provider with URL: " + updateResult.ErrorInfo);
        }).Wait();
    }

    public static ResoniteLink.ImportMeshRawData ConvertMesh(UnityEngine.Mesh mesh)
    {
        var data = new ResoniteLink.ImportMeshRawData();

        data.VertexCount = mesh.vertexCount;

        data.HasNormals = mesh.HasVertexAttribute(UnityEngine.Rendering.VertexAttribute.Normal);
        data.HasTangents = mesh.HasVertexAttribute(UnityEngine.Rendering.VertexAttribute.Tangent);
        data.HasColors = mesh.HasVertexAttribute(UnityEngine.Rendering.VertexAttribute.Color);

        data.UV_Channel_Dimensions = new List<int>();

        for(int uv = 0; uv < MAX_UV_CHANNEL_COUNT; uv++)
        {
            if (!mesh.HasVertexAttribute(UnityEngine.Rendering.VertexAttribute.TexCoord0 + uv))
                continue;

            // Pad any previous channels with 0
            while (data.UV_Channel_Dimensions.Count < uv)
                data.UV_Channel_Dimensions.Add(0);

            data.UV_Channel_Dimensions.Add(2);
        }

        //data.BoneWeightCount = mesh.HasVertexAttribute(UnityEngine.Rendering.VertexAttribute.BlendWeight) ? 4 : 0;

        data.Submeshes = new List<ResoniteLink.SubmeshRawData>();

        // Since there can be unsupported submeshes, keep the indexes of the ones that match
        // We skip over the unsupported ones
        // This should be rare, as Triangles & Points are most common, but we don't want to leave it unhandled
        // as this can still do at least partial conversion.
        // Ideally though if there are common submesh types that we don't support, we should add them to Resonite & ResoniteLink
        // Feel free to make a feature request for this if you run into it!
        var submeshIndexes = new List<int>();

        for(int s = 0; s < mesh.subMeshCount; s++)
        {
            var submesh = mesh.GetSubMesh(s);

            switch(submesh.topology)
            {
                case MeshTopology.Triangles:
                    var trigSubmesh = new TriangleSubmeshRawData();
                    trigSubmesh.TriangleCount = submesh.indexCount / 3;

                    data.Submeshes.Add(trigSubmesh);

                    submeshIndexes.Add(s);
                    break;

                case MeshTopology.Points:
                    var pointSubmesh = new PointSubmeshRawData();
                    pointSubmesh.PointCount = submesh.indexCount;

                    data.Submeshes.Add(pointSubmesh);

                    submeshIndexes.Add(s);
                    break;

                default:
                    Debug.LogWarning($"Unsupported submesh topology: {submesh.topology}");
                    break;
            }
        }

        // TODO!!! Blendshapes & Bones

        // Convert the vertex data
        data.AllocateBuffer();

        mesh.vertices.AsSpan().CopyTo(MemoryMarshal.Cast<float3, Vector3>(data.Positions));

        if(data.HasNormals)
            mesh.normals.AsSpan().CopyTo(MemoryMarshal.Cast<float3, Vector3>(data.Normals));

        if (data.HasTangents)
            mesh.tangents.AsSpan().CopyTo(MemoryMarshal.Cast<float4, Vector4>(data.Tangents));

        if (data.HasColors)
            mesh.colors.AsSpan().CopyTo(MemoryMarshal.Cast<color, Color>(data.Colors));

        for(int uv = 0; uv < data.UV_Channel_Dimensions.Count; uv++)
        {
            var dimensions = data.UV_Channel_Dimensions[uv];

            if (dimensions == 0)
                continue;

            if (dimensions != 2)
                throw new NotImplementedException("Only 2D UV's are currently supported");

            GetUVs(mesh, uv).AsSpan().CopyTo(MemoryMarshal.Cast<float2, Vector2>(data.AccessUV_2D(uv)));
        }

        // Convert submeshes
        for (int s = 0; s < data.Submeshes.Count; s++)
        {
            var submesh = data.Submeshes[s];
            var indicies = mesh.GetIndices(submeshIndexes[s]);

            indicies.AsSpan().CopyTo(submesh.Indices);
        }

        // TODO!!! Convert Blendshapes & Bones

        return data;
    }

    static Vector2[] GetUVs(UnityEngine.Mesh mesh, int uv)
    {
        switch(uv)
        {
            // Why is it not 0-indexed in Unity? ;_;
            case 0: return mesh.uv;
            case 1: return mesh.uv2;
            case 2: return mesh.uv3;
            case 3: return mesh.uv4;
            case 4: return mesh.uv5;
            case 5: return mesh.uv6;
            case 6: return mesh.uv7;
            case 7: return mesh.uv8;

            default:
                throw new ArgumentOutOfRangeException(nameof(uv));
        }
    }
}
