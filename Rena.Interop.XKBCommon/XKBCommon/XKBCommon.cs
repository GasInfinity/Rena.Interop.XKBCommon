using System.Runtime.InteropServices;

namespace Rena.Interop.XKBCommon;

public static unsafe partial class XKBCommon
{
    [DllImport("xkbcommon", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xkb_keysym_get_name", ExactSpelling = true)]
    public static extern int keysym_get_name([NativeTypeName("xkb_keysym_t")] uint keysym, [NativeTypeName("char *")] sbyte* buffer, [NativeTypeName("size_t")] nuint size);

    [DllImport("xkbcommon", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xkb_keysym_from_name", ExactSpelling = true)]
    [return: NativeTypeName("xkb_keysym_t")]
    public static extern uint keysym_from_name([NativeTypeName("const char *")] sbyte* name, [NativeTypeName("enum xkb_keysym_flags")] xkb_keysym_flags flags);

    [DllImport("xkbcommon", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xkb_keysym_to_utf8", ExactSpelling = true)]
    public static extern int keysym_to_utf8([NativeTypeName("xkb_keysym_t")] uint keysym, [NativeTypeName("char *")] sbyte* buffer, [NativeTypeName("size_t")] nuint size);

    [DllImport("xkbcommon", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xkb_keysym_to_utf32", ExactSpelling = true)]
    [return: NativeTypeName("uint32_t")]
    public static extern uint keysym_to_utf32([NativeTypeName("xkb_keysym_t")] uint keysym);

    [DllImport("xkbcommon", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xkb_utf32_to_keysym", ExactSpelling = true)]
    [return: NativeTypeName("xkb_keysym_t")]
    public static extern uint utf32_to_keysym([NativeTypeName("uint32_t")] uint ucs);

    [DllImport("xkbcommon", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xkb_keysym_to_upper", ExactSpelling = true)]
    [return: NativeTypeName("xkb_keysym_t")]
    public static extern uint keysym_to_upper([NativeTypeName("xkb_keysym_t")] uint ks);

    [DllImport("xkbcommon", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xkb_keysym_to_lower", ExactSpelling = true)]
    [return: NativeTypeName("xkb_keysym_t")]
    public static extern uint keysym_to_lower([NativeTypeName("xkb_keysym_t")] uint ks);

    [DllImport("xkbcommon", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xkb_context_new", ExactSpelling = true)]
    [return: NativeTypeName("struct xkb_context *")]
    public static extern xkb_context* context_new([NativeTypeName("enum xkb_context_flags")] xkb_context_flags flags);

    [DllImport("xkbcommon", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xkb_context_ref", ExactSpelling = true)]
    [return: NativeTypeName("struct xkb_context *")]
    public static extern xkb_context* context_ref([NativeTypeName("struct xkb_context *")] xkb_context* context);

    [DllImport("xkbcommon", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xkb_context_unref", ExactSpelling = true)]
    public static extern void context_unref([NativeTypeName("struct xkb_context *")] xkb_context* context);

    [DllImport("xkbcommon", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xkb_context_set_user_data", ExactSpelling = true)]
    public static extern void context_set_user_data([NativeTypeName("struct xkb_context *")] xkb_context* context, void* user_data);

    [DllImport("xkbcommon", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xkb_context_get_user_data", ExactSpelling = true)]
    public static extern void* context_get_user_data([NativeTypeName("struct xkb_context *")] xkb_context* context);

    [DllImport("xkbcommon", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xkb_context_include_path_append", ExactSpelling = true)]
    public static extern int context_include_path_append([NativeTypeName("struct xkb_context *")] xkb_context* context, [NativeTypeName("const char *")] sbyte* path);

    [DllImport("xkbcommon", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xkb_context_include_path_append_default", ExactSpelling = true)]
    public static extern int context_include_path_append_default([NativeTypeName("struct xkb_context *")] xkb_context* context);

    [DllImport("xkbcommon", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xkb_context_include_path_reset_defaults", ExactSpelling = true)]
    public static extern int context_include_path_reset_defaults([NativeTypeName("struct xkb_context *")] xkb_context* context);

    [DllImport("xkbcommon", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xkb_context_include_path_clear", ExactSpelling = true)]
    public static extern void context_include_path_clear([NativeTypeName("struct xkb_context *")] xkb_context* context);

    [DllImport("xkbcommon", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xkb_context_num_include_paths", ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint context_num_include_paths([NativeTypeName("struct xkb_context *")] xkb_context* context);

    [DllImport("xkbcommon", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xkb_context_include_path_get", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* context_include_path_get([NativeTypeName("struct xkb_context *")] xkb_context* context, [NativeTypeName("unsigned int")] uint index);

    [DllImport("xkbcommon", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xkb_context_set_log_level", ExactSpelling = true)]
    public static extern void context_set_log_level([NativeTypeName("struct xkb_context *")] xkb_context* context, [NativeTypeName("enum xkb_log_level")] xkb_log_level level);

    [DllImport("xkbcommon", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xkb_context_get_log_level", ExactSpelling = true)]
    [return: NativeTypeName("enum xkb_log_level")]
    public static extern xkb_log_level context_get_log_level([NativeTypeName("struct xkb_context *")] xkb_context* context);

    [DllImport("xkbcommon", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xkb_context_set_log_verbosity", ExactSpelling = true)]
    public static extern void context_set_log_verbosity([NativeTypeName("struct xkb_context *")] xkb_context* context, int verbosity);

    [DllImport("xkbcommon", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xkb_context_get_log_verbosity", ExactSpelling = true)]
    public static extern int context_get_log_verbosity([NativeTypeName("struct xkb_context *")] xkb_context* context);

    [DllImport("xkbcommon", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xkb_keymap_new_from_names", ExactSpelling = true)]
    [return: NativeTypeName("struct xkb_keymap *")]
    public static extern xkb_keymap* keymap_new_from_names([NativeTypeName("struct xkb_context *")] xkb_context* context, [NativeTypeName("const struct xkb_rule_names *")] xkb_rule_names* names, [NativeTypeName("enum xkb_keymap_compile_flags")] xkb_keymap_compile_flags flags);

    [DllImport("xkbcommon", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xkb_keymap_new_from_string", ExactSpelling = true)]
    [return: NativeTypeName("struct xkb_keymap *")]
    public static extern xkb_keymap* keymap_new_from_string([NativeTypeName("struct xkb_context *")] xkb_context* context, [NativeTypeName("const char *")] sbyte* @string, [NativeTypeName("enum xkb_keymap_format")] xkb_keymap_format format, [NativeTypeName("enum xkb_keymap_compile_flags")] xkb_keymap_compile_flags flags);

    [DllImport("xkbcommon", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xkb_keymap_new_from_buffer", ExactSpelling = true)]
    [return: NativeTypeName("struct xkb_keymap *")]
    public static extern xkb_keymap* keymap_new_from_buffer([NativeTypeName("struct xkb_context *")] xkb_context* context, [NativeTypeName("const char *")] sbyte* buffer, [NativeTypeName("size_t")] nuint length, [NativeTypeName("enum xkb_keymap_format")] xkb_keymap_format format, [NativeTypeName("enum xkb_keymap_compile_flags")] xkb_keymap_compile_flags flags);

    [DllImport("xkbcommon", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xkb_keymap_ref", ExactSpelling = true)]
    [return: NativeTypeName("struct xkb_keymap *")]
    public static extern xkb_keymap* keymap_ref([NativeTypeName("struct xkb_keymap *")] xkb_keymap* keymap);

    [DllImport("xkbcommon", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xkb_keymap_unref", ExactSpelling = true)]
    public static extern void keymap_unref([NativeTypeName("struct xkb_keymap *")] xkb_keymap* keymap);

    [DllImport("xkbcommon", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xkb_keymap_get_as_string", ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* keymap_get_as_string([NativeTypeName("struct xkb_keymap *")] xkb_keymap* keymap, [NativeTypeName("enum xkb_keymap_format")] xkb_keymap_format format);

    [DllImport("xkbcommon", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xkb_keymap_min_keycode", ExactSpelling = true)]
    [return: NativeTypeName("xkb_keycode_t")]
    public static extern uint keymap_min_keycode([NativeTypeName("struct xkb_keymap *")] xkb_keymap* keymap);

    [DllImport("xkbcommon", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xkb_keymap_max_keycode", ExactSpelling = true)]
    [return: NativeTypeName("xkb_keycode_t")]
    public static extern uint keymap_max_keycode([NativeTypeName("struct xkb_keymap *")] xkb_keymap* keymap);

    [DllImport("xkbcommon", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xkb_keymap_key_for_each", ExactSpelling = true)]
    public static extern void keymap_key_for_each([NativeTypeName("struct xkb_keymap *")] xkb_keymap* keymap, [NativeTypeName("xkb_keymap_key_iter_t")] delegate* unmanaged[Cdecl]<xkb_keymap*, uint, void*, void> iter, void* data);

    [DllImport("xkbcommon", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xkb_keymap_key_get_name", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* keymap_key_get_name([NativeTypeName("struct xkb_keymap *")] xkb_keymap* keymap, [NativeTypeName("xkb_keycode_t")] uint key);

    [DllImport("xkbcommon", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xkb_keymap_key_by_name", ExactSpelling = true)]
    [return: NativeTypeName("xkb_keycode_t")]
    public static extern uint keymap_key_by_name([NativeTypeName("struct xkb_keymap *")] xkb_keymap* keymap, [NativeTypeName("const char *")] sbyte* name);

    [DllImport("xkbcommon", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xkb_keymap_num_mods", ExactSpelling = true)]
    [return: NativeTypeName("xkb_mod_index_t")]
    public static extern uint keymap_num_mods([NativeTypeName("struct xkb_keymap *")] xkb_keymap* keymap);

    [DllImport("xkbcommon", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xkb_keymap_mod_get_name", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* keymap_mod_get_name([NativeTypeName("struct xkb_keymap *")] xkb_keymap* keymap, [NativeTypeName("xkb_mod_index_t")] uint idx);

    [DllImport("xkbcommon", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xkb_keymap_mod_get_index", ExactSpelling = true)]
    [return: NativeTypeName("xkb_mod_index_t")]
    public static extern uint keymap_mod_get_index([NativeTypeName("struct xkb_keymap *")] xkb_keymap* keymap, [NativeTypeName("const char *")] sbyte* name);

    [DllImport("xkbcommon", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xkb_keymap_num_layouts", ExactSpelling = true)]
    [return: NativeTypeName("xkb_layout_index_t")]
    public static extern uint keymap_num_layouts([NativeTypeName("struct xkb_keymap *")] xkb_keymap* keymap);

    [DllImport("xkbcommon", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xkb_keymap_layout_get_name", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* keymap_layout_get_name([NativeTypeName("struct xkb_keymap *")] xkb_keymap* keymap, [NativeTypeName("xkb_layout_index_t")] uint idx);

    [DllImport("xkbcommon", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xkb_keymap_layout_get_index", ExactSpelling = true)]
    [return: NativeTypeName("xkb_layout_index_t")]
    public static extern uint keymap_layout_get_index([NativeTypeName("struct xkb_keymap *")] xkb_keymap* keymap, [NativeTypeName("const char *")] sbyte* name);

    [DllImport("xkbcommon", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xkb_keymap_num_leds", ExactSpelling = true)]
    [return: NativeTypeName("xkb_led_index_t")]
    public static extern uint keymap_num_leds([NativeTypeName("struct xkb_keymap *")] xkb_keymap* keymap);

    [DllImport("xkbcommon", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xkb_keymap_led_get_name", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* keymap_led_get_name([NativeTypeName("struct xkb_keymap *")] xkb_keymap* keymap, [NativeTypeName("xkb_led_index_t")] uint idx);

    [DllImport("xkbcommon", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xkb_keymap_led_get_index", ExactSpelling = true)]
    [return: NativeTypeName("xkb_led_index_t")]
    public static extern uint keymap_led_get_index([NativeTypeName("struct xkb_keymap *")] xkb_keymap* keymap, [NativeTypeName("const char *")] sbyte* name);

    [DllImport("xkbcommon", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xkb_keymap_num_layouts_for_key", ExactSpelling = true)]
    [return: NativeTypeName("xkb_layout_index_t")]
    public static extern uint keymap_num_layouts_for_key([NativeTypeName("struct xkb_keymap *")] xkb_keymap* keymap, [NativeTypeName("xkb_keycode_t")] uint key);

    [DllImport("xkbcommon", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xkb_keymap_num_levels_for_key", ExactSpelling = true)]
    [return: NativeTypeName("xkb_level_index_t")]
    public static extern uint keymap_num_levels_for_key([NativeTypeName("struct xkb_keymap *")] xkb_keymap* keymap, [NativeTypeName("xkb_keycode_t")] uint key, [NativeTypeName("xkb_layout_index_t")] uint layout);

    [DllImport("xkbcommon", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xkb_keymap_key_get_mods_for_level", ExactSpelling = true)]
    [return: NativeTypeName("size_t")]
    public static extern nuint keymap_key_get_mods_for_level([NativeTypeName("struct xkb_keymap *")] xkb_keymap* keymap, [NativeTypeName("xkb_keycode_t")] uint key, [NativeTypeName("xkb_layout_index_t")] uint layout, [NativeTypeName("xkb_level_index_t")] uint level, [NativeTypeName("xkb_mod_mask_t *")] uint* masks_out, [NativeTypeName("size_t")] nuint masks_size);

    [DllImport("xkbcommon", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xkb_keymap_key_get_syms_by_level", ExactSpelling = true)]
    public static extern int keymap_key_get_syms_by_level([NativeTypeName("struct xkb_keymap *")] xkb_keymap* keymap, [NativeTypeName("xkb_keycode_t")] uint key, [NativeTypeName("xkb_layout_index_t")] uint layout, [NativeTypeName("xkb_level_index_t")] uint level, [NativeTypeName("const xkb_keysym_t **")] uint** syms_out);

    [DllImport("xkbcommon", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xkb_keymap_key_repeats", ExactSpelling = true)]
    public static extern int keymap_key_repeats([NativeTypeName("struct xkb_keymap *")] xkb_keymap* keymap, [NativeTypeName("xkb_keycode_t")] uint key);

    [DllImport("xkbcommon", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xkb_state_new", ExactSpelling = true)]
    [return: NativeTypeName("struct xkb_state *")]
    public static extern xkb_state* state_new([NativeTypeName("struct xkb_keymap *")] xkb_keymap* keymap);

    [DllImport("xkbcommon", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xkb_state_ref", ExactSpelling = true)]
    [return: NativeTypeName("struct xkb_state *")]
    public static extern xkb_state* state_ref([NativeTypeName("struct xkb_state *")] xkb_state* state);

    [DllImport("xkbcommon", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xkb_state_unref", ExactSpelling = true)]
    public static extern void state_unref([NativeTypeName("struct xkb_state *")] xkb_state* state);

    [DllImport("xkbcommon", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xkb_state_get_keymap", ExactSpelling = true)]
    [return: NativeTypeName("struct xkb_keymap *")]
    public static extern xkb_keymap* state_get_keymap([NativeTypeName("struct xkb_state *")] xkb_state* state);

    [DllImport("xkbcommon", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xkb_state_update_key", ExactSpelling = true)]
    [return: NativeTypeName("enum xkb_state_component")]
    public static extern xkb_state_component state_update_key([NativeTypeName("struct xkb_state *")] xkb_state* state, [NativeTypeName("xkb_keycode_t")] uint key, [NativeTypeName("enum xkb_key_direction")] xkb_key_direction direction);

    [DllImport("xkbcommon", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xkb_state_update_mask", ExactSpelling = true)]
    [return: NativeTypeName("enum xkb_state_component")]
    public static extern xkb_state_component state_update_mask([NativeTypeName("struct xkb_state *")] xkb_state* state, [NativeTypeName("xkb_mod_mask_t")] uint depressed_mods, [NativeTypeName("xkb_mod_mask_t")] uint latched_mods, [NativeTypeName("xkb_mod_mask_t")] uint locked_mods, [NativeTypeName("xkb_layout_index_t")] uint depressed_layout, [NativeTypeName("xkb_layout_index_t")] uint latched_layout, [NativeTypeName("xkb_layout_index_t")] uint locked_layout);

    [DllImport("xkbcommon", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xkb_state_key_get_syms", ExactSpelling = true)]
    public static extern int state_key_get_syms([NativeTypeName("struct xkb_state *")] xkb_state* state, [NativeTypeName("xkb_keycode_t")] uint key, [NativeTypeName("const xkb_keysym_t **")] uint** syms_out);

    [DllImport("xkbcommon", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xkb_state_key_get_utf8", ExactSpelling = true)]
    public static extern int state_key_get_utf8([NativeTypeName("struct xkb_state *")] xkb_state* state, [NativeTypeName("xkb_keycode_t")] uint key, [NativeTypeName("char *")] sbyte* buffer, [NativeTypeName("size_t")] nuint size);

    [DllImport("xkbcommon", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xkb_state_key_get_utf32", ExactSpelling = true)]
    [return: NativeTypeName("uint32_t")]
    public static extern uint state_key_get_utf32([NativeTypeName("struct xkb_state *")] xkb_state* state, [NativeTypeName("xkb_keycode_t")] uint key);

    [DllImport("xkbcommon", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xkb_state_key_get_one_sym", ExactSpelling = true)]
    [return: NativeTypeName("xkb_keysym_t")]
    public static extern uint state_key_get_one_sym([NativeTypeName("struct xkb_state *")] xkb_state* state, [NativeTypeName("xkb_keycode_t")] uint key);

    [DllImport("xkbcommon", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xkb_state_key_get_layout", ExactSpelling = true)]
    [return: NativeTypeName("xkb_layout_index_t")]
    public static extern uint state_key_get_layout([NativeTypeName("struct xkb_state *")] xkb_state* state, [NativeTypeName("xkb_keycode_t")] uint key);

    [DllImport("xkbcommon", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xkb_state_key_get_level", ExactSpelling = true)]
    [return: NativeTypeName("xkb_level_index_t")]
    public static extern uint state_key_get_level([NativeTypeName("struct xkb_state *")] xkb_state* state, [NativeTypeName("xkb_keycode_t")] uint key, [NativeTypeName("xkb_layout_index_t")] uint layout);

    [DllImport("xkbcommon", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xkb_state_serialize_mods", ExactSpelling = true)]
    [return: NativeTypeName("xkb_mod_mask_t")]
    public static extern uint state_serialize_mods([NativeTypeName("struct xkb_state *")] xkb_state* state, [NativeTypeName("enum xkb_state_component")] xkb_state_component components);

    [DllImport("xkbcommon", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xkb_state_serialize_layout", ExactSpelling = true)]
    [return: NativeTypeName("xkb_layout_index_t")]
    public static extern uint state_serialize_layout([NativeTypeName("struct xkb_state *")] xkb_state* state, [NativeTypeName("enum xkb_state_component")] xkb_state_component components);

    [DllImport("xkbcommon", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xkb_state_mod_name_is_active", ExactSpelling = true)]
    public static extern int state_mod_name_is_active([NativeTypeName("struct xkb_state *")] xkb_state* state, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("enum xkb_state_component")] xkb_state_component type);

    [DllImport("xkbcommon", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xkb_state_mod_names_are_active", ExactSpelling = true)]
    public static extern int state_mod_names_are_active([NativeTypeName("struct xkb_state *")] xkb_state* state, [NativeTypeName("enum xkb_state_component")] xkb_state_component type, [NativeTypeName("enum xkb_state_match")] xkb_state_match match, __arglist);

    [DllImport("xkbcommon", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xkb_state_mod_index_is_active", ExactSpelling = true)]
    public static extern int state_mod_index_is_active([NativeTypeName("struct xkb_state *")] xkb_state* state, [NativeTypeName("xkb_mod_index_t")] uint idx, [NativeTypeName("enum xkb_state_component")] xkb_state_component type);

    [DllImport("xkbcommon", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xkb_state_mod_indices_are_active", ExactSpelling = true)]
    public static extern int state_mod_indices_are_active([NativeTypeName("struct xkb_state *")] xkb_state* state, [NativeTypeName("enum xkb_state_component")] xkb_state_component type, [NativeTypeName("enum xkb_state_match")] xkb_state_match match, __arglist);

    [DllImport("xkbcommon", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xkb_state_key_get_consumed_mods2", ExactSpelling = true)]
    [return: NativeTypeName("xkb_mod_mask_t")]
    public static extern uint state_key_get_consumed_mods2([NativeTypeName("struct xkb_state *")] xkb_state* state, [NativeTypeName("xkb_keycode_t")] uint key, [NativeTypeName("enum xkb_consumed_mode")] xkb_consumed_mode mode);

    [DllImport("xkbcommon", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xkb_state_key_get_consumed_mods", ExactSpelling = true)]
    [return: NativeTypeName("xkb_mod_mask_t")]
    public static extern uint state_key_get_consumed_mods([NativeTypeName("struct xkb_state *")] xkb_state* state, [NativeTypeName("xkb_keycode_t")] uint key);

    [DllImport("xkbcommon", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xkb_state_mod_index_is_consumed2", ExactSpelling = true)]
    public static extern int state_mod_index_is_consumed2([NativeTypeName("struct xkb_state *")] xkb_state* state, [NativeTypeName("xkb_keycode_t")] uint key, [NativeTypeName("xkb_mod_index_t")] uint idx, [NativeTypeName("enum xkb_consumed_mode")] xkb_consumed_mode mode);

    [DllImport("xkbcommon", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xkb_state_mod_index_is_consumed", ExactSpelling = true)]
    public static extern int state_mod_index_is_consumed([NativeTypeName("struct xkb_state *")] xkb_state* state, [NativeTypeName("xkb_keycode_t")] uint key, [NativeTypeName("xkb_mod_index_t")] uint idx);

    [DllImport("xkbcommon", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xkb_state_mod_mask_remove_consumed", ExactSpelling = true)]
    [return: NativeTypeName("xkb_mod_mask_t")]
    public static extern uint state_mod_mask_remove_consumed([NativeTypeName("struct xkb_state *")] xkb_state* state, [NativeTypeName("xkb_keycode_t")] uint key, [NativeTypeName("xkb_mod_mask_t")] uint mask);

    [DllImport("xkbcommon", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xkb_state_layout_name_is_active", ExactSpelling = true)]
    public static extern int state_layout_name_is_active([NativeTypeName("struct xkb_state *")] xkb_state* state, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("enum xkb_state_component")] xkb_state_component type);

    [DllImport("xkbcommon", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xkb_state_layout_index_is_active", ExactSpelling = true)]
    public static extern int state_layout_index_is_active([NativeTypeName("struct xkb_state *")] xkb_state* state, [NativeTypeName("xkb_layout_index_t")] uint idx, [NativeTypeName("enum xkb_state_component")] xkb_state_component type);

    [DllImport("xkbcommon", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xkb_state_led_name_is_active", ExactSpelling = true)]
    public static extern int state_led_name_is_active([NativeTypeName("struct xkb_state *")] xkb_state* state, [NativeTypeName("const char *")] sbyte* name);

    [DllImport("xkbcommon", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xkb_state_led_index_is_active", ExactSpelling = true)]
    public static extern int state_led_index_is_active([NativeTypeName("struct xkb_state *")] xkb_state* state, [NativeTypeName("xkb_led_index_t")] uint idx);

    [NativeTypeName("#define XKB_KEYCODE_INVALID (0xffffffff)")]
    public const uint XKB_KEYCODE_INVALID = (0xffffffff);

    [NativeTypeName("#define XKB_LAYOUT_INVALID (0xffffffff)")]
    public const uint XKB_LAYOUT_INVALID = (0xffffffff);

    [NativeTypeName("#define XKB_LEVEL_INVALID (0xffffffff)")]
    public const uint XKB_LEVEL_INVALID = (0xffffffff);

    [NativeTypeName("#define XKB_MOD_INVALID (0xffffffff)")]
    public const uint XKB_MOD_INVALID = (0xffffffff);

    [NativeTypeName("#define XKB_LED_INVALID (0xffffffff)")]
    public const uint XKB_LED_INVALID = (0xffffffff);

    [NativeTypeName("#define XKB_KEYCODE_MAX (0xffffffff - 1)")]
    public const uint XKB_KEYCODE_MAX = (0xffffffff - 1);
}
