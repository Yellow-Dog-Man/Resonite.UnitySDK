using UnityEngine;

namespace ResoniteSDK {
    public class LilToonAssetCache
    {

        public Texture2D MainTexture;

        public Hash128? MainTextureBakeHash;

        public Texture2D EmissionMap;

        public Hash128? EmissionMapBakeHash;

        public Texture2D ShadowRampTexture;

        public Hash128? ShadowRampBakeHash;

        internal struct BakeHash
        {
            private Hash128 value;

            public Hash128 Value => value;

            public void Add(bool item)
            {
                value.Append(item ? 1 : 0);
            }

            public void Add(float item)
            {
                value.Append(item);
            }

            public void Add(Vector2 item)
            {
                value.Append(item.x);
                value.Append(item.y);
            }

            public void Add(Vector4 item)
            {
                value.Append(item.x);
                value.Append(item.y);
                value.Append(item.z);
                value.Append(item.w);
            }

            public void Add(Color item)
            {
                value.Append(item.r);
                value.Append(item.g);
                value.Append(item.b);
                value.Append(item.a);
            }

            public void Add(Texture item)
            {
                if (item == null)
                {
                    value.Append(0);
                    return;
                }

                value.Append(item.GetInstanceID());
                value.Append((int)item.updateCount);
                value.Append((int)item.wrapMode);
                value.Append((int)item.wrapModeU);
                value.Append((int)item.wrapModeV);
                value.Append((int)item.wrapModeW);
                value.Append((int)item.filterMode);
                value.Append(item.anisoLevel);
                value.Append(item.mipMapBias);
            }
        }
    }
}