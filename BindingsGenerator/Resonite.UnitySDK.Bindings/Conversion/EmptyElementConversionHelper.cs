using System;
using System.Collections.Generic;
using System.Text;

public static class EmptyElementConversionHelper
{
    public static ResoniteLink.EmptyElement ToLinkEmpty(this FrooxEngine.EmptySyncElement element, IConversionContext context)
    {
        var linkEmpty = new ResoniteLink.EmptyElement();

        // We only need the empty element ID, it has no actual data
        linkEmpty.ID = context.GetIdOrAllocate(element);

        return linkEmpty;
    }
}