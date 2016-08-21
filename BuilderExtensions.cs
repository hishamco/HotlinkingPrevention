using Microsoft.AspNetCore.Builder;

namespace HotlinkingPrevention
{
    public static class BuilderExtensions
    {
        public static IApplicationBuilder UseHotlinkingPreventionMiddleware(this IApplicationBuilder app)
        {
            return app.UseMiddleware<HotlinkingPreventionMiddleware>();
        }
    }
}