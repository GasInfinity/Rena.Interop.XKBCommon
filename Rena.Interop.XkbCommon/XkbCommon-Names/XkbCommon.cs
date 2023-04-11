using System;

namespace Rena.Interop.XkbCommon;

public static partial class XkbCommon
{
    [NativeTypeName("#define XKB_MOD_NAME_SHIFT \"Shift\"")]
    public static ReadOnlySpan<byte> XKB_MOD_NAME_SHIFT => new byte[] { 0x53, 0x68, 0x69, 0x66, 0x74, 0x00 };

    [NativeTypeName("#define XKB_MOD_NAME_CAPS \"Lock\"")]
    public static ReadOnlySpan<byte> XKB_MOD_NAME_CAPS => new byte[] { 0x4C, 0x6F, 0x63, 0x6B, 0x00 };

    [NativeTypeName("#define XKB_MOD_NAME_CTRL \"Control\"")]
    public static ReadOnlySpan<byte> XKB_MOD_NAME_CTRL => new byte[] { 0x43, 0x6F, 0x6E, 0x74, 0x72, 0x6F, 0x6C, 0x00 };

    [NativeTypeName("#define XKB_MOD_NAME_ALT \"Mod1\"")]
    public static ReadOnlySpan<byte> XKB_MOD_NAME_ALT => new byte[] { 0x4D, 0x6F, 0x64, 0x31, 0x00 };

    [NativeTypeName("#define XKB_MOD_NAME_NUM \"Mod2\"")]
    public static ReadOnlySpan<byte> XKB_MOD_NAME_NUM => new byte[] { 0x4D, 0x6F, 0x64, 0x32, 0x00 };

    [NativeTypeName("#define XKB_MOD_NAME_LOGO \"Mod4\"")]
    public static ReadOnlySpan<byte> XKB_MOD_NAME_LOGO => new byte[] { 0x4D, 0x6F, 0x64, 0x34, 0x00 };

    [NativeTypeName("#define XKB_LED_NAME_CAPS \"Caps Lock\"")]
    public static ReadOnlySpan<byte> XKB_LED_NAME_CAPS => new byte[] { 0x43, 0x61, 0x70, 0x73, 0x20, 0x4C, 0x6F, 0x63, 0x6B, 0x00 };

    [NativeTypeName("#define XKB_LED_NAME_NUM \"Num Lock\"")]
    public static ReadOnlySpan<byte> XKB_LED_NAME_NUM => new byte[] { 0x4E, 0x75, 0x6D, 0x20, 0x4C, 0x6F, 0x63, 0x6B, 0x00 };

    [NativeTypeName("#define XKB_LED_NAME_SCROLL \"Scroll Lock\"")]
    public static ReadOnlySpan<byte> XKB_LED_NAME_SCROLL => new byte[] { 0x53, 0x63, 0x72, 0x6F, 0x6C, 0x6C, 0x20, 0x4C, 0x6F, 0x63, 0x6B, 0x00 };
}
