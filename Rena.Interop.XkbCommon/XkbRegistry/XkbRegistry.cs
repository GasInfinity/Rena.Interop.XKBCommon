using System.Runtime.InteropServices;

namespace Rena.Interop.XkbCommon;

public static unsafe partial class XkbRegistry
{
    [DllImport("xkbregistry", CallingConvention = CallingConvention.Cdecl, EntryPoint = "rxkb_context_new", ExactSpelling = true)]
    [return: NativeTypeName("struct rxkb_context *")]
    public static extern rxkb_context* context_new([NativeTypeName("enum rxkb_context_flags")] rxkb_context_flags flags);

    [DllImport("xkbregistry", CallingConvention = CallingConvention.Cdecl, EntryPoint = "rxkb_context_set_log_level", ExactSpelling = true)]
    public static extern void context_set_log_level([NativeTypeName("struct rxkb_context *")] rxkb_context* ctx, [NativeTypeName("enum rxkb_log_level")] rxkb_log_level level);

    [DllImport("xkbregistry", CallingConvention = CallingConvention.Cdecl, EntryPoint = "rxkb_context_get_log_level", ExactSpelling = true)]
    [return: NativeTypeName("enum rxkb_log_level")]
    public static extern rxkb_log_level context_get_log_level([NativeTypeName("struct rxkb_context *")] rxkb_context* ctx);

    [DllImport("xkbregistry", CallingConvention = CallingConvention.Cdecl, EntryPoint = "rxkb_context_parse", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte context_parse([NativeTypeName("struct rxkb_context *")] rxkb_context* ctx, [NativeTypeName("const char *")] sbyte* ruleset);

    [DllImport("xkbregistry", CallingConvention = CallingConvention.Cdecl, EntryPoint = "rxkb_context_parse_default_ruleset", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte context_parse_default_ruleset([NativeTypeName("struct rxkb_context *")] rxkb_context* ctx);

    [DllImport("xkbregistry", CallingConvention = CallingConvention.Cdecl, EntryPoint = "rxkb_context_ref", ExactSpelling = true)]
    [return: NativeTypeName("struct rxkb_context *")]
    public static extern rxkb_context* context_ref([NativeTypeName("struct rxkb_context *")] rxkb_context* ctx);

    [DllImport("xkbregistry", CallingConvention = CallingConvention.Cdecl, EntryPoint = "rxkb_context_unref", ExactSpelling = true)]
    [return: NativeTypeName("struct rxkb_context *")]
    public static extern rxkb_context* context_unref([NativeTypeName("struct rxkb_context *")] rxkb_context* ctx);

    [DllImport("xkbregistry", CallingConvention = CallingConvention.Cdecl, EntryPoint = "rxkb_context_set_user_data", ExactSpelling = true)]
    public static extern void context_set_user_data([NativeTypeName("struct rxkb_context *")] rxkb_context* ctx, void* user_data);

    [DllImport("xkbregistry", CallingConvention = CallingConvention.Cdecl, EntryPoint = "rxkb_context_get_user_data", ExactSpelling = true)]
    public static extern void* context_get_user_data([NativeTypeName("struct rxkb_context *")] rxkb_context* ctx);

    [DllImport("xkbregistry", CallingConvention = CallingConvention.Cdecl, EntryPoint = "rxkb_context_include_path_append", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte context_include_path_append([NativeTypeName("struct rxkb_context *")] rxkb_context* ctx, [NativeTypeName("const char *")] sbyte* path);

    [DllImport("xkbregistry", CallingConvention = CallingConvention.Cdecl, EntryPoint = "rxkb_context_include_path_append_default", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte context_include_path_append_default([NativeTypeName("struct rxkb_context *")] rxkb_context* ctx);

    [DllImport("xkbregistry", CallingConvention = CallingConvention.Cdecl, EntryPoint = "rxkb_model_first", ExactSpelling = true)]
    [return: NativeTypeName("struct rxkb_model *")]
    public static extern rxkb_model* model_first([NativeTypeName("struct rxkb_context *")] rxkb_context* ctx);

    [DllImport("xkbregistry", CallingConvention = CallingConvention.Cdecl, EntryPoint = "rxkb_model_next", ExactSpelling = true)]
    [return: NativeTypeName("struct rxkb_model *")]
    public static extern rxkb_model* model_next([NativeTypeName("struct rxkb_model *")] rxkb_model* m);

    [DllImport("xkbregistry", CallingConvention = CallingConvention.Cdecl, EntryPoint = "rxkb_model_ref", ExactSpelling = true)]
    [return: NativeTypeName("struct rxkb_model *")]
    public static extern rxkb_model* model_ref([NativeTypeName("struct rxkb_model *")] rxkb_model* m);

    [DllImport("xkbregistry", CallingConvention = CallingConvention.Cdecl, EntryPoint = "rxkb_model_unref", ExactSpelling = true)]
    [return: NativeTypeName("struct rxkb_model *")]
    public static extern rxkb_model* model_unref([NativeTypeName("struct rxkb_model *")] rxkb_model* m);

    [DllImport("xkbregistry", CallingConvention = CallingConvention.Cdecl, EntryPoint = "rxkb_model_get_name", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* model_get_name([NativeTypeName("struct rxkb_model *")] rxkb_model* m);

    [DllImport("xkbregistry", CallingConvention = CallingConvention.Cdecl, EntryPoint = "rxkb_model_get_description", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* model_get_description([NativeTypeName("struct rxkb_model *")] rxkb_model* m);

    [DllImport("xkbregistry", CallingConvention = CallingConvention.Cdecl, EntryPoint = "rxkb_model_get_vendor", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* model_get_vendor([NativeTypeName("struct rxkb_model *")] rxkb_model* m);

    [DllImport("xkbregistry", CallingConvention = CallingConvention.Cdecl, EntryPoint = "rxkb_model_get_popularity", ExactSpelling = true)]
    [return: NativeTypeName("enum rxkb_popularity")]
    public static extern rxkb_popularity model_get_popularity([NativeTypeName("struct rxkb_model *")] rxkb_model* m);

    [DllImport("xkbregistry", CallingConvention = CallingConvention.Cdecl, EntryPoint = "rxkb_layout_first", ExactSpelling = true)]
    [return: NativeTypeName("struct rxkb_layout *")]
    public static extern rxkb_layout* layout_first([NativeTypeName("struct rxkb_context *")] rxkb_context* ctx);

    [DllImport("xkbregistry", CallingConvention = CallingConvention.Cdecl, EntryPoint = "rxkb_layout_next", ExactSpelling = true)]
    [return: NativeTypeName("struct rxkb_layout *")]
    public static extern rxkb_layout* layout_next([NativeTypeName("struct rxkb_layout *")] rxkb_layout* l);

    [DllImport("xkbregistry", CallingConvention = CallingConvention.Cdecl, EntryPoint = "rxkb_layout_ref", ExactSpelling = true)]
    [return: NativeTypeName("struct rxkb_layout *")]
    public static extern rxkb_layout* layout_ref([NativeTypeName("struct rxkb_layout *")] rxkb_layout* l);

    [DllImport("xkbregistry", CallingConvention = CallingConvention.Cdecl, EntryPoint = "rxkb_layout_unref", ExactSpelling = true)]
    [return: NativeTypeName("struct rxkb_layout *")]
    public static extern rxkb_layout* layout_unref([NativeTypeName("struct rxkb_layout *")] rxkb_layout* l);

    [DllImport("xkbregistry", CallingConvention = CallingConvention.Cdecl, EntryPoint = "rxkb_layout_get_name", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* layout_get_name([NativeTypeName("struct rxkb_layout *")] rxkb_layout* l);

    [DllImport("xkbregistry", CallingConvention = CallingConvention.Cdecl, EntryPoint = "rxkb_layout_get_variant", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* layout_get_variant([NativeTypeName("struct rxkb_layout *")] rxkb_layout* l);

    [DllImport("xkbregistry", CallingConvention = CallingConvention.Cdecl, EntryPoint = "rxkb_layout_get_brief", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* layout_get_brief([NativeTypeName("struct rxkb_layout *")] rxkb_layout* l);

    [DllImport("xkbregistry", CallingConvention = CallingConvention.Cdecl, EntryPoint = "rxkb_layout_get_description", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* layout_get_description([NativeTypeName("struct rxkb_layout *")] rxkb_layout* l);

    [DllImport("xkbregistry", CallingConvention = CallingConvention.Cdecl, EntryPoint = "rxkb_layout_get_popularity", ExactSpelling = true)]
    [return: NativeTypeName("enum rxkb_popularity")]
    public static extern rxkb_popularity layout_get_popularity([NativeTypeName("struct rxkb_layout *")] rxkb_layout* l);

    [DllImport("xkbregistry", CallingConvention = CallingConvention.Cdecl, EntryPoint = "rxkb_option_group_first", ExactSpelling = true)]
    [return: NativeTypeName("struct rxkb_option_group *")]
    public static extern rxkb_option_group* option_group_first([NativeTypeName("struct rxkb_context *")] rxkb_context* ctx);

    [DllImport("xkbregistry", CallingConvention = CallingConvention.Cdecl, EntryPoint = "rxkb_option_group_next", ExactSpelling = true)]
    [return: NativeTypeName("struct rxkb_option_group *")]
    public static extern rxkb_option_group* option_group_next([NativeTypeName("struct rxkb_option_group *")] rxkb_option_group* g);

    [DllImport("xkbregistry", CallingConvention = CallingConvention.Cdecl, EntryPoint = "rxkb_option_group_ref", ExactSpelling = true)]
    [return: NativeTypeName("struct rxkb_option_group *")]
    public static extern rxkb_option_group* option_group_ref([NativeTypeName("struct rxkb_option_group *")] rxkb_option_group* g);

    [DllImport("xkbregistry", CallingConvention = CallingConvention.Cdecl, EntryPoint = "rxkb_option_group_unref", ExactSpelling = true)]
    [return: NativeTypeName("struct rxkb_option_group *")]
    public static extern rxkb_option_group* option_group_unref([NativeTypeName("struct rxkb_option_group *")] rxkb_option_group* g);

    [DllImport("xkbregistry", CallingConvention = CallingConvention.Cdecl, EntryPoint = "rxkb_option_group_get_name", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* option_group_get_name([NativeTypeName("struct rxkb_option_group *")] rxkb_option_group* m);

    [DllImport("xkbregistry", CallingConvention = CallingConvention.Cdecl, EntryPoint = "rxkb_option_group_get_description", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* option_group_get_description([NativeTypeName("struct rxkb_option_group *")] rxkb_option_group* m);

    [DllImport("xkbregistry", CallingConvention = CallingConvention.Cdecl, EntryPoint = "rxkb_option_group_allows_multiple", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte option_group_allows_multiple([NativeTypeName("struct rxkb_option_group *")] rxkb_option_group* g);

    [DllImport("xkbregistry", CallingConvention = CallingConvention.Cdecl, EntryPoint = "rxkb_option_group_get_popularity", ExactSpelling = true)]
    [return: NativeTypeName("enum rxkb_popularity")]
    public static extern rxkb_popularity option_group_get_popularity([NativeTypeName("struct rxkb_option_group *")] rxkb_option_group* g);

    [DllImport("xkbregistry", CallingConvention = CallingConvention.Cdecl, EntryPoint = "rxkb_option_first", ExactSpelling = true)]
    [return: NativeTypeName("struct rxkb_option *")]
    public static extern rxkb_option* option_first([NativeTypeName("struct rxkb_option_group *")] rxkb_option_group* group);

    [DllImport("xkbregistry", CallingConvention = CallingConvention.Cdecl, EntryPoint = "rxkb_option_next", ExactSpelling = true)]
    [return: NativeTypeName("struct rxkb_option *")]
    public static extern rxkb_option* option_next([NativeTypeName("struct rxkb_option *")] rxkb_option* o);

    [DllImport("xkbregistry", CallingConvention = CallingConvention.Cdecl, EntryPoint = "rxkb_option_ref", ExactSpelling = true)]
    [return: NativeTypeName("struct rxkb_option *")]
    public static extern rxkb_option* option_ref([NativeTypeName("struct rxkb_option *")] rxkb_option* o);

    [DllImport("xkbregistry", CallingConvention = CallingConvention.Cdecl, EntryPoint = "rxkb_option_unref", ExactSpelling = true)]
    [return: NativeTypeName("struct rxkb_option *")]
    public static extern rxkb_option* option_unref([NativeTypeName("struct rxkb_option *")] rxkb_option* o);

    [DllImport("xkbregistry", CallingConvention = CallingConvention.Cdecl, EntryPoint = "rxkb_option_get_name", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* option_get_name([NativeTypeName("struct rxkb_option *")] rxkb_option* o);

    [DllImport("xkbregistry", CallingConvention = CallingConvention.Cdecl, EntryPoint = "rxkb_option_get_brief", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* option_get_brief([NativeTypeName("struct rxkb_option *")] rxkb_option* o);

    [DllImport("xkbregistry", CallingConvention = CallingConvention.Cdecl, EntryPoint = "rxkb_option_get_description", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* option_get_description([NativeTypeName("struct rxkb_option *")] rxkb_option* o);

    [DllImport("xkbregistry", CallingConvention = CallingConvention.Cdecl, EntryPoint = "rxkb_option_get_popularity", ExactSpelling = true)]
    [return: NativeTypeName("enum rxkb_popularity")]
    public static extern rxkb_popularity option_get_popularity([NativeTypeName("struct rxkb_option *")] rxkb_option* o);

    [DllImport("xkbregistry", CallingConvention = CallingConvention.Cdecl, EntryPoint = "rxkb_iso639_code_ref", ExactSpelling = true)]
    [return: NativeTypeName("struct rxkb_iso639_code *")]
    public static extern rxkb_iso639_code* iso639_code_ref([NativeTypeName("struct rxkb_iso639_code *")] rxkb_iso639_code* iso639);

    [DllImport("xkbregistry", CallingConvention = CallingConvention.Cdecl, EntryPoint = "rxkb_iso639_code_unref", ExactSpelling = true)]
    [return: NativeTypeName("struct rxkb_iso639_code *")]
    public static extern rxkb_iso639_code* iso639_code_unref([NativeTypeName("struct rxkb_iso639_code *")] rxkb_iso639_code* iso639);

    [DllImport("xkbregistry", CallingConvention = CallingConvention.Cdecl, EntryPoint = "rxkb_iso639_code_get_code", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* iso639_code_get_code([NativeTypeName("struct rxkb_iso639_code *")] rxkb_iso639_code* iso639);

    [DllImport("xkbregistry", CallingConvention = CallingConvention.Cdecl, EntryPoint = "rxkb_layout_get_iso639_first", ExactSpelling = true)]
    [return: NativeTypeName("struct rxkb_iso639_code *")]
    public static extern rxkb_iso639_code* layout_get_iso639_first([NativeTypeName("struct rxkb_layout *")] rxkb_layout* layout);

    [DllImport("xkbregistry", CallingConvention = CallingConvention.Cdecl, EntryPoint = "rxkb_iso639_code_next", ExactSpelling = true)]
    [return: NativeTypeName("struct rxkb_iso639_code *")]
    public static extern rxkb_iso639_code* iso639_code_next([NativeTypeName("struct rxkb_iso639_code *")] rxkb_iso639_code* iso639);

    [DllImport("xkbregistry", CallingConvention = CallingConvention.Cdecl, EntryPoint = "rxkb_iso3166_code_ref", ExactSpelling = true)]
    [return: NativeTypeName("struct rxkb_iso3166_code *")]
    public static extern rxkb_iso3166_code* iso3166_code_ref([NativeTypeName("struct rxkb_iso3166_code *")] rxkb_iso3166_code* iso3166);

    [DllImport("xkbregistry", CallingConvention = CallingConvention.Cdecl, EntryPoint = "rxkb_iso3166_code_unref", ExactSpelling = true)]
    [return: NativeTypeName("struct rxkb_iso3166_code *")]
    public static extern rxkb_iso3166_code* iso3166_code_unref([NativeTypeName("struct rxkb_iso3166_code *")] rxkb_iso3166_code* iso3166);

    [DllImport("xkbregistry", CallingConvention = CallingConvention.Cdecl, EntryPoint = "rxkb_iso3166_code_get_code", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* iso3166_code_get_code([NativeTypeName("struct rxkb_iso3166_code *")] rxkb_iso3166_code* iso3166);

    [DllImport("xkbregistry", CallingConvention = CallingConvention.Cdecl, EntryPoint = "rxkb_layout_get_iso3166_first", ExactSpelling = true)]
    [return: NativeTypeName("struct rxkb_iso3166_code *")]
    public static extern rxkb_iso3166_code* layout_get_iso3166_first([NativeTypeName("struct rxkb_layout *")] rxkb_layout* layout);

    [DllImport("xkbregistry", CallingConvention = CallingConvention.Cdecl, EntryPoint = "rxkb_iso3166_code_next", ExactSpelling = true)]
    [return: NativeTypeName("struct rxkb_iso3166_code *")]
    public static extern rxkb_iso3166_code* iso3166_code_next([NativeTypeName("struct rxkb_iso3166_code *")] rxkb_iso3166_code* iso3166);
}
