#if WINFORMS_NAMESPACE
namespace System.Windows.Forms.Internal
#elif DRAWING_NAMESPACE
namespace System.Drawing.Internal
#else
namespace NotSteam.something
#endif
{
    /// <devdoc>
    ///    Specifies the layout of a device context.
    /// </devdoc>
#if WINFORMS_PUBLIC_GRAPHICS_LIBRARY
    public
#else
    internal
#endif
    enum DeviceContextBackgroundMode
    {
        Transparent = 1,
        Opaque = 2
    }
}