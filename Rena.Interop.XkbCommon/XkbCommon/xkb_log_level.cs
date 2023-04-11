namespace Rena.Interop.XkbCommon;

[NativeTypeName("unsigned int")]
public enum xkb_log_level : uint
{
    XKB_LOG_LEVEL_CRITICAL = 10,
    XKB_LOG_LEVEL_ERROR = 20,
    XKB_LOG_LEVEL_WARNING = 30,
    XKB_LOG_LEVEL_INFO = 40,
    XKB_LOG_LEVEL_DEBUG = 50,
}
