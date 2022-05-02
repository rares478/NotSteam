#if WINFORMS_NAMESPACE
namespace System.Windows.Forms.Internal
#elif DRAWING_NAMESPACE
namespace System.Drawing.Internal
#else
namespace NotSteam.something
#endif
{
    /// <devdoc>
    /// </devdoc>
#if WINFORMS_PUBLIC_GRAPHICS_LIBRARY
    public
#else
    internal
#endif
    enum RegionCombineMode
    {
        AND = 1,
        OR = 2,
        XOR = 3,
        DIFF = 4,
        COPY = 5,
        MIN = AND,
        MAX = COPY
    }
}