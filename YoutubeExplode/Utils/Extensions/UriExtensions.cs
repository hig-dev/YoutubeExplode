using System;

namespace YoutubeExplode.Utils.Extensions;

internal static class UriExtensions
{
    public static string Domain(this Uri uri) => uri.Scheme + Uri.SchemeDelimiter + uri.Host;
}
