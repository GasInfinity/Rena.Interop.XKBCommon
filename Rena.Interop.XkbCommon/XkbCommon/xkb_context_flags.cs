namespace Rena.Interop.XkbCommon;

[NativeTypeName("unsigned int")]
public enum xkb_context_flags : uint
{
    XKB_CONTEXT_NO_FLAGS = 0,
    XKB_CONTEXT_NO_DEFAULT_INCLUDES = (1 << 0),
    XKB_CONTEXT_NO_ENVIRONMENT_NAMES = (1 << 1),
    XKB_CONTEXT_NO_SECURE_GETENV = (1 << 2),
}
