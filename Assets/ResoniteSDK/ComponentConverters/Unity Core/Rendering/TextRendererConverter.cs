using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public static class TextRendererHelper
{
    public static void SetFrom(this FrooxEngine.TextRenderer resonite, UnityEngine.TextMesh unity, IConversionContext context)
    {
        // There's no base to set these from, so we can't use the shared one?
        resonite.persistent = true;
        resonite.Enabled = true;

        resonite.Text = unity.text;

        switch (unity.fontStyle)
        {
            case FontStyle.Italic: resonite.Text = $"<i>{resonite.Text}</i>"; break;
            case FontStyle.Bold: resonite.Text = $"<b>{resonite.Text}</b>"; break;
            case FontStyle.BoldAndItalic: resonite.Text = $"<b><i>{resonite.Text}</i></b>"; break;
        }

        resonite.Color = unity.color.ToColorX_sRGB();

        switch (unity.alignment)
        {
            case TextAlignment.Left:
                resonite.HorizontalAlign = Elements.Assets.TextHorizontalAlignment.Left;
                break;

            case TextAlignment.Right:
                resonite.HorizontalAlign = Elements.Assets.TextHorizontalAlignment.Right;
                break;

            case TextAlignment.Center:
                resonite.HorizontalAlign = Elements.Assets.TextHorizontalAlignment.Center;
                break;
        }

        resonite.Size = unity.characterSize;

        // TODO!!! Handle case when it's set to 0?
        // That should use the default font size
        if (unity.fontSize > 0)
            resonite.Size *= unity.fontSize;

        resonite.LineHeight = 1;
        resonite.ParseRichText = true;
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
        // TextMesh uses the MeshRenderer for actual rendering, so we don't want it to be converted as an actual mesh renderer
        // We move it from the list
        toConvert.RemoveAll(c => c is UnityEngine.MeshRenderer);
    }
}