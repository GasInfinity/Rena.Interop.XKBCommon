namespace Rena.Interop.XkbCommon;

[NativeTypeName("unsigned int")]
public enum xkb_state_match : uint
{
    XKB_STATE_MATCH_ANY = (1 << 0),
    XKB_STATE_MATCH_ALL = (1 << 1),
    XKB_STATE_MATCH_NON_EXCLUSIVE = (1 << 16),
}
