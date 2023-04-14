namespace Rena.Interop.XKBCommon;

[NativeTypeName("unsigned int")]
public enum xkb_keysym_flags : uint
{
    XKB_KEYSYM_NO_FLAGS = 0,
    XKB_KEYSYM_CASE_INSENSITIVE = (1 << 0),
}
