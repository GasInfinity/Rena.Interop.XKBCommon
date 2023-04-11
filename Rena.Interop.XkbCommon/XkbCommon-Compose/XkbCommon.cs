using System.Runtime.InteropServices;

namespace Rena.Interop.XkbCommon;

public static unsafe partial class XkbCommon
{
    [DllImport("xkbcommon", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xkb_compose_table_new_from_locale", ExactSpelling = true)]
    [return: NativeTypeName("struct xkb_compose_table *")]
    public static extern xkb_compose_table* compose_table_new_from_locale([NativeTypeName("struct xkb_context *")] xkb_context* context, [NativeTypeName("const char *")] sbyte* locale, [NativeTypeName("enum xkb_compose_compile_flags")] xkb_compose_compile_flags flags);

    [DllImport("xkbcommon", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xkb_compose_table_new_from_buffer", ExactSpelling = true)]
    [return: NativeTypeName("struct xkb_compose_table *")]
    public static extern xkb_compose_table* compose_table_new_from_buffer([NativeTypeName("struct xkb_context *")] xkb_context* context, [NativeTypeName("const char *")] sbyte* buffer, [NativeTypeName("size_t")] nuint length, [NativeTypeName("const char *")] sbyte* locale, [NativeTypeName("enum xkb_compose_format")] xkb_compose_format format, [NativeTypeName("enum xkb_compose_compile_flags")] xkb_compose_compile_flags flags);

    [DllImport("xkbcommon", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xkb_compose_table_ref", ExactSpelling = true)]
    [return: NativeTypeName("struct xkb_compose_table *")]
    public static extern xkb_compose_table* compose_table_ref([NativeTypeName("struct xkb_compose_table *")] xkb_compose_table* table);

    [DllImport("xkbcommon", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xkb_compose_table_unref", ExactSpelling = true)]
    public static extern void compose_table_unref([NativeTypeName("struct xkb_compose_table *")] xkb_compose_table* table);

    [DllImport("xkbcommon", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xkb_compose_state_new", ExactSpelling = true)]
    [return: NativeTypeName("struct xkb_compose_state *")]
    public static extern xkb_compose_state* compose_state_new([NativeTypeName("struct xkb_compose_table *")] xkb_compose_table* table, [NativeTypeName("enum xkb_compose_state_flags")] xkb_compose_state_flags flags);

    [DllImport("xkbcommon", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xkb_compose_state_ref", ExactSpelling = true)]
    [return: NativeTypeName("struct xkb_compose_state *")]
    public static extern xkb_compose_state* compose_state_ref([NativeTypeName("struct xkb_compose_state *")] xkb_compose_state* state);

    [DllImport("xkbcommon", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xkb_compose_state_unref", ExactSpelling = true)]
    public static extern void compose_state_unref([NativeTypeName("struct xkb_compose_state *")] xkb_compose_state* state);

    [DllImport("xkbcommon", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xkb_compose_state_get_compose_table", ExactSpelling = true)]
    [return: NativeTypeName("struct xkb_compose_table *")]
    public static extern xkb_compose_table* compose_state_get_compose_table([NativeTypeName("struct xkb_compose_state *")] xkb_compose_state* state);

    [DllImport("xkbcommon", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xkb_compose_state_feed", ExactSpelling = true)]
    [return: NativeTypeName("enum xkb_compose_feed_result")]
    public static extern xkb_compose_feed_result compose_state_feed([NativeTypeName("struct xkb_compose_state *")] xkb_compose_state* state, [NativeTypeName("xkb_keysym_t")] uint keysym);

    [DllImport("xkbcommon", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xkb_compose_state_reset", ExactSpelling = true)]
    public static extern void compose_state_reset([NativeTypeName("struct xkb_compose_state *")] xkb_compose_state* state);

    [DllImport("xkbcommon", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xkb_compose_state_get_status", ExactSpelling = true)]
    [return: NativeTypeName("enum xkb_compose_status")]
    public static extern xkb_compose_status compose_state_get_status([NativeTypeName("struct xkb_compose_state *")] xkb_compose_state* state);

    [DllImport("xkbcommon", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xkb_compose_state_get_utf8", ExactSpelling = true)]
    public static extern int compose_state_get_utf8([NativeTypeName("struct xkb_compose_state *")] xkb_compose_state* state, [NativeTypeName("char *")] sbyte* buffer, [NativeTypeName("size_t")] nuint size);

    [DllImport("xkbcommon", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xkb_compose_state_get_one_sym", ExactSpelling = true)]
    [return: NativeTypeName("xkb_keysym_t")]
    public static extern uint compose_state_get_one_sym([NativeTypeName("struct xkb_compose_state *")] xkb_compose_state* state);
}
