using System.Runtime.InteropServices;

namespace Rena.Interop.XkbCommon;

public static unsafe partial class XkbCommonX11
{
    [DllImport("xkbcommon-x11", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xkb_x11_setup_xkb_extension", ExactSpelling = true)]
    public static extern int setup_xkb_extension([NativeTypeName("xcb_connection_t *")] void* connection, [NativeTypeName("uint16_t")] ushort major_xkb_version, [NativeTypeName("uint16_t")] ushort minor_xkb_version, [NativeTypeName("enum xkb_x11_setup_xkb_extension_flags")] xkb_x11_setup_xkb_extension_flags flags, [NativeTypeName("uint16_t *")] ushort* major_xkb_version_out, [NativeTypeName("uint16_t *")] ushort* minor_xkb_version_out, [NativeTypeName("uint8_t *")] byte* base_event_out, [NativeTypeName("uint8_t *")] byte* base_error_out);

    [DllImport("xkbcommon-x11", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xkb_x11_get_core_keyboard_device_id", ExactSpelling = true)]
    [return: NativeTypeName("int32_t")]
    public static extern int get_core_keyboard_device_id([NativeTypeName("xcb_connection_t *")] void* connection);

    [DllImport("xkbcommon-x11", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xkb_x11_keymap_new_from_device", ExactSpelling = true)]
    [return: NativeTypeName("struct xkb_keymap *")]
    public static extern xkb_keymap* keymap_new_from_device([NativeTypeName("struct xkb_context *")] xkb_context* context, [NativeTypeName("xcb_connection_t *")] void* connection, [NativeTypeName("int32_t")] int device_id, [NativeTypeName("enum xkb_keymap_compile_flags")] xkb_keymap_compile_flags flags);

    [DllImport("xkbcommon-x11", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xkb_x11_state_new_from_device", ExactSpelling = true)]
    [return: NativeTypeName("struct xkb_state *")]
    public static extern xkb_state* state_new_from_device([NativeTypeName("struct xkb_keymap *")] xkb_keymap* keymap, [NativeTypeName("xcb_connection_t *")] void* connection, [NativeTypeName("int32_t")] int device_id);

    [NativeTypeName("#define XKB_X11_MIN_MAJOR_XKB_VERSION 1")]
    public const int XKB_X11_MIN_MAJOR_XKB_VERSION = 1;

    [NativeTypeName("#define XKB_X11_MIN_MINOR_XKB_VERSION 0")]
    public const int XKB_X11_MIN_MINOR_XKB_VERSION = 0;
}
