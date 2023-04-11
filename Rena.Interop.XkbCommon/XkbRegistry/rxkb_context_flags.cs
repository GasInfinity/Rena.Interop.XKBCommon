namespace Rena.Interop.XkbCommon;

[NativeTypeName("unsigned int")]
public enum rxkb_context_flags : uint
{
    RXKB_CONTEXT_NO_FLAGS = 0,
    RXKB_CONTEXT_NO_DEFAULT_INCLUDES = (1 << 0),
    RXKB_CONTEXT_LOAD_EXOTIC_RULES = (1 << 1),
    RXKB_CONTEXT_NO_SECURE_GETENV = (1 << 2),
}
