namespace Rena.Interop.XKBCommon;

[NativeTypeName("unsigned int")]
public enum rxkb_log_level : uint
{
    RXKB_LOG_LEVEL_CRITICAL = 10,
    RXKB_LOG_LEVEL_ERROR = 20,
    RXKB_LOG_LEVEL_WARNING = 30,
    RXKB_LOG_LEVEL_INFO = 40,
    RXKB_LOG_LEVEL_DEBUG = 50,
}
