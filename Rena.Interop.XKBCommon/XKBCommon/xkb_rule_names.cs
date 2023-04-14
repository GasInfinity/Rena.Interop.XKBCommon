namespace Rena.Interop.XKBCommon;

public unsafe partial struct xkb_rule_names
{
    [NativeTypeName("const char *")]
    public sbyte* rules;

    [NativeTypeName("const char *")]
    public sbyte* model;

    [NativeTypeName("const char *")]
    public sbyte* layout;

    [NativeTypeName("const char *")]
    public sbyte* variant;

    [NativeTypeName("const char *")]
    public sbyte* options;
}
