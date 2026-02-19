using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace FrooxEngine
{
    public partial class TextRenderer
    {
        public void SetFrom(UnityEngine.TextMesh renderer, IConversionContext context)
        {
            // There's no base to set these from, so we can't use the shared one?
            persistent = true;
            Enabled = true;

            Text = renderer.text;

            switch(renderer.fontStyle)
            {
                case FontStyle.Italic: Text = $"<i>{Text}</i>"; break;
                case FontStyle.Bold: Text = $"<b>{Text}</b>"; break;
                case FontStyle.BoldAndItalic: Text = $"<b><i>{Text}</i></b>"; break;
            }

            Color = renderer.color.ToColorX_sRGB();

            switch(renderer.alignment)
            {
                case TextAlignment.Left: 
                    HorizontalAlign = Elements.Assets.TextHorizontalAlignment.Left;
                    break;

                case TextAlignment.Right:
                    HorizontalAlign = Elements.Assets.TextHorizontalAlignment.Right;
                    break;

                case TextAlignment.Center:
                    HorizontalAlign = Elements.Assets.TextHorizontalAlignment.Center;
                    break;
            }

            Size = renderer.characterSize;

            // TODO!!! Handle case when it's set to 0?
            // That should use the default font size
            if (renderer.fontSize > 0)
                Size *= renderer.fontSize;

            LineHeight = 1;
            ParseRichText = true;
        }
    }
}

public class TextRendererConverter : ResoniteSingleComponentConverter<UnityEngine.TextMesh, FrooxEngine.TextRendererWrapper>
{
    protected override void UpdateConversion(UnityEngine.TextMesh target, IConversionContext context)
    {
        Binding.Data.SetFrom(target, context);
    }

    [ConverterSupressionHandler]
    public static void FilterConverters(Transform root, List<Component> toConvert)
    {
        Debug.Log("Filtering converters");

        // TextMesh uses the MeshRenderer for actual rendering, so we don't want it to be converted as an actual mesh renderer
        // We move it from the list
        toConvert.RemoveAll(c => c is UnityEngine.MeshRenderer);
    }
}