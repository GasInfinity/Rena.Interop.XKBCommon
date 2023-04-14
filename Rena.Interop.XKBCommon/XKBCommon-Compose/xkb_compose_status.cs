namespace Rena.Interop.XKBCommon;

[NativeTypeName("unsigned int")]
public enum xkb_compose_status : uint
{
    XKB_COMPOSE_NOTHING,
    XKB_COMPOSE_COMPOSING,
    XKB_COMPOSE_COMPOSED,
    XKB_COMPOSE_CANCELLED,
}
