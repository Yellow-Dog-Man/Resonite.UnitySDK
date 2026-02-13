using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class MemberConversionHelper
{
    public static List<ResoniteLink.Member> ConvertList<T>(this List<T> list, Func<T, ResoniteLink.Member> conversion)
    {
        if (list == null || list.Count == 0)
            return new List<ResoniteLink.Member>();

        return list.Select(m => conversion(m)).ToList();
    }
}
