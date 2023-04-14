namespace Rena.Interop.XKBCommon;

public static partial class XKBCommon
{
    [NativeTypeName("#define XKB_KEY_NoSymbol 0x000000")]
    public const int XKB_KEY_NoSymbol = 0x000000;

    [NativeTypeName("#define XKB_KEY_VoidSymbol 0xffffff")]
    public const int XKB_KEY_VoidSymbol = 0xffffff;

    [NativeTypeName("#define XKB_KEY_BackSpace 0xff08")]
    public const int XKB_KEY_BackSpace = 0xff08;

    [NativeTypeName("#define XKB_KEY_Tab 0xff09")]
    public const int XKB_KEY_Tab = 0xff09;

    [NativeTypeName("#define XKB_KEY_Linefeed 0xff0a")]
    public const int XKB_KEY_Linefeed = 0xff0a;

    [NativeTypeName("#define XKB_KEY_Clear 0xff0b")]
    public const int XKB_KEY_Clear = 0xff0b;

    [NativeTypeName("#define XKB_KEY_Return 0xff0d")]
    public const int XKB_KEY_Return = 0xff0d;

    [NativeTypeName("#define XKB_KEY_Pause 0xff13")]
    public const int XKB_KEY_Pause = 0xff13;

    [NativeTypeName("#define XKB_KEY_Scroll_Lock 0xff14")]
    public const int XKB_KEY_Scroll_Lock = 0xff14;

    [NativeTypeName("#define XKB_KEY_Sys_Req 0xff15")]
    public const int XKB_KEY_Sys_Req = 0xff15;

    [NativeTypeName("#define XKB_KEY_Escape 0xff1b")]
    public const int XKB_KEY_Escape = 0xff1b;

    [NativeTypeName("#define XKB_KEY_Delete 0xffff")]
    public const int XKB_KEY_Delete = 0xffff;

    [NativeTypeName("#define XKB_KEY_Multi_key 0xff20")]
    public const int XKB_KEY_Multi_key = 0xff20;

    [NativeTypeName("#define XKB_KEY_Codeinput 0xff37")]
    public const int XKB_KEY_Codeinput = 0xff37;

    [NativeTypeName("#define XKB_KEY_SingleCandidate 0xff3c")]
    public const int XKB_KEY_SingleCandidate = 0xff3c;

    [NativeTypeName("#define XKB_KEY_MultipleCandidate 0xff3d")]
    public const int XKB_KEY_MultipleCandidate = 0xff3d;

    [NativeTypeName("#define XKB_KEY_PreviousCandidate 0xff3e")]
    public const int XKB_KEY_PreviousCandidate = 0xff3e;

    [NativeTypeName("#define XKB_KEY_Kanji 0xff21")]
    public const int XKB_KEY_Kanji = 0xff21;

    [NativeTypeName("#define XKB_KEY_Muhenkan 0xff22")]
    public const int XKB_KEY_Muhenkan = 0xff22;

    [NativeTypeName("#define XKB_KEY_Henkan_Mode 0xff23")]
    public const int XKB_KEY_Henkan_Mode = 0xff23;

    [NativeTypeName("#define XKB_KEY_Henkan 0xff23")]
    public const int XKB_KEY_Henkan = 0xff23;

    [NativeTypeName("#define XKB_KEY_Romaji 0xff24")]
    public const int XKB_KEY_Romaji = 0xff24;

    [NativeTypeName("#define XKB_KEY_Hiragana 0xff25")]
    public const int XKB_KEY_Hiragana = 0xff25;

    [NativeTypeName("#define XKB_KEY_Katakana 0xff26")]
    public const int XKB_KEY_Katakana = 0xff26;

    [NativeTypeName("#define XKB_KEY_Hiragana_Katakana 0xff27")]
    public const int XKB_KEY_Hiragana_Katakana = 0xff27;

    [NativeTypeName("#define XKB_KEY_Zenkaku 0xff28")]
    public const int XKB_KEY_Zenkaku = 0xff28;

    [NativeTypeName("#define XKB_KEY_Hankaku 0xff29")]
    public const int XKB_KEY_Hankaku = 0xff29;

    [NativeTypeName("#define XKB_KEY_Zenkaku_Hankaku 0xff2a")]
    public const int XKB_KEY_Zenkaku_Hankaku = 0xff2a;

    [NativeTypeName("#define XKB_KEY_Touroku 0xff2b")]
    public const int XKB_KEY_Touroku = 0xff2b;

    [NativeTypeName("#define XKB_KEY_Massyo 0xff2c")]
    public const int XKB_KEY_Massyo = 0xff2c;

    [NativeTypeName("#define XKB_KEY_Kana_Lock 0xff2d")]
    public const int XKB_KEY_Kana_Lock = 0xff2d;

    [NativeTypeName("#define XKB_KEY_Kana_Shift 0xff2e")]
    public const int XKB_KEY_Kana_Shift = 0xff2e;

    [NativeTypeName("#define XKB_KEY_Eisu_Shift 0xff2f")]
    public const int XKB_KEY_Eisu_Shift = 0xff2f;

    [NativeTypeName("#define XKB_KEY_Eisu_toggle 0xff30")]
    public const int XKB_KEY_Eisu_toggle = 0xff30;

    [NativeTypeName("#define XKB_KEY_Kanji_Bangou 0xff37")]
    public const int XKB_KEY_Kanji_Bangou = 0xff37;

    [NativeTypeName("#define XKB_KEY_Zen_Koho 0xff3d")]
    public const int XKB_KEY_Zen_Koho = 0xff3d;

    [NativeTypeName("#define XKB_KEY_Mae_Koho 0xff3e")]
    public const int XKB_KEY_Mae_Koho = 0xff3e;

    [NativeTypeName("#define XKB_KEY_Home 0xff50")]
    public const int XKB_KEY_Home = 0xff50;

    [NativeTypeName("#define XKB_KEY_Left 0xff51")]
    public const int XKB_KEY_Left = 0xff51;

    [NativeTypeName("#define XKB_KEY_Up 0xff52")]
    public const int XKB_KEY_Up = 0xff52;

    [NativeTypeName("#define XKB_KEY_Right 0xff53")]
    public const int XKB_KEY_Right = 0xff53;

    [NativeTypeName("#define XKB_KEY_Down 0xff54")]
    public const int XKB_KEY_Down = 0xff54;

    [NativeTypeName("#define XKB_KEY_Prior 0xff55")]
    public const int XKB_KEY_Prior = 0xff55;

    [NativeTypeName("#define XKB_KEY_Page_Up 0xff55")]
    public const int XKB_KEY_Page_Up = 0xff55;

    [NativeTypeName("#define XKB_KEY_Next 0xff56")]
    public const int XKB_KEY_Next = 0xff56;

    [NativeTypeName("#define XKB_KEY_Page_Down 0xff56")]
    public const int XKB_KEY_Page_Down = 0xff56;

    [NativeTypeName("#define XKB_KEY_End 0xff57")]
    public const int XKB_KEY_End = 0xff57;

    [NativeTypeName("#define XKB_KEY_Begin 0xff58")]
    public const int XKB_KEY_Begin = 0xff58;

    [NativeTypeName("#define XKB_KEY_Select 0xff60")]
    public const int XKB_KEY_Select = 0xff60;

    [NativeTypeName("#define XKB_KEY_Print 0xff61")]
    public const int XKB_KEY_Print = 0xff61;

    [NativeTypeName("#define XKB_KEY_Execute 0xff62")]
    public const int XKB_KEY_Execute = 0xff62;

    [NativeTypeName("#define XKB_KEY_Insert 0xff63")]
    public const int XKB_KEY_Insert = 0xff63;

    [NativeTypeName("#define XKB_KEY_Undo 0xff65")]
    public const int XKB_KEY_Undo = 0xff65;

    [NativeTypeName("#define XKB_KEY_Redo 0xff66")]
    public const int XKB_KEY_Redo = 0xff66;

    [NativeTypeName("#define XKB_KEY_Menu 0xff67")]
    public const int XKB_KEY_Menu = 0xff67;

    [NativeTypeName("#define XKB_KEY_Find 0xff68")]
    public const int XKB_KEY_Find = 0xff68;

    [NativeTypeName("#define XKB_KEY_Cancel 0xff69")]
    public const int XKB_KEY_Cancel = 0xff69;

    [NativeTypeName("#define XKB_KEY_Help 0xff6a")]
    public const int XKB_KEY_Help = 0xff6a;

    [NativeTypeName("#define XKB_KEY_Break 0xff6b")]
    public const int XKB_KEY_Break = 0xff6b;

    [NativeTypeName("#define XKB_KEY_Mode_switch 0xff7e")]
    public const int XKB_KEY_Mode_switch = 0xff7e;

    [NativeTypeName("#define XKB_KEY_script_switch 0xff7e")]
    public const int XKB_KEY_script_switch = 0xff7e;

    [NativeTypeName("#define XKB_KEY_Num_Lock 0xff7f")]
    public const int XKB_KEY_Num_Lock = 0xff7f;

    [NativeTypeName("#define XKB_KEY_KP_Space 0xff80")]
    public const int XKB_KEY_KP_Space = 0xff80;

    [NativeTypeName("#define XKB_KEY_KP_Tab 0xff89")]
    public const int XKB_KEY_KP_Tab = 0xff89;

    [NativeTypeName("#define XKB_KEY_KP_Enter 0xff8d")]
    public const int XKB_KEY_KP_Enter = 0xff8d;

    [NativeTypeName("#define XKB_KEY_KP_F1 0xff91")]
    public const int XKB_KEY_KP_F1 = 0xff91;

    [NativeTypeName("#define XKB_KEY_KP_F2 0xff92")]
    public const int XKB_KEY_KP_F2 = 0xff92;

    [NativeTypeName("#define XKB_KEY_KP_F3 0xff93")]
    public const int XKB_KEY_KP_F3 = 0xff93;

    [NativeTypeName("#define XKB_KEY_KP_F4 0xff94")]
    public const int XKB_KEY_KP_F4 = 0xff94;

    [NativeTypeName("#define XKB_KEY_KP_Home 0xff95")]
    public const int XKB_KEY_KP_Home = 0xff95;

    [NativeTypeName("#define XKB_KEY_KP_Left 0xff96")]
    public const int XKB_KEY_KP_Left = 0xff96;

    [NativeTypeName("#define XKB_KEY_KP_Up 0xff97")]
    public const int XKB_KEY_KP_Up = 0xff97;

    [NativeTypeName("#define XKB_KEY_KP_Right 0xff98")]
    public const int XKB_KEY_KP_Right = 0xff98;

    [NativeTypeName("#define XKB_KEY_KP_Down 0xff99")]
    public const int XKB_KEY_KP_Down = 0xff99;

    [NativeTypeName("#define XKB_KEY_KP_Prior 0xff9a")]
    public const int XKB_KEY_KP_Prior = 0xff9a;

    [NativeTypeName("#define XKB_KEY_KP_Page_Up 0xff9a")]
    public const int XKB_KEY_KP_Page_Up = 0xff9a;

    [NativeTypeName("#define XKB_KEY_KP_Next 0xff9b")]
    public const int XKB_KEY_KP_Next = 0xff9b;

    [NativeTypeName("#define XKB_KEY_KP_Page_Down 0xff9b")]
    public const int XKB_KEY_KP_Page_Down = 0xff9b;

    [NativeTypeName("#define XKB_KEY_KP_End 0xff9c")]
    public const int XKB_KEY_KP_End = 0xff9c;

    [NativeTypeName("#define XKB_KEY_KP_Begin 0xff9d")]
    public const int XKB_KEY_KP_Begin = 0xff9d;

    [NativeTypeName("#define XKB_KEY_KP_Insert 0xff9e")]
    public const int XKB_KEY_KP_Insert = 0xff9e;

    [NativeTypeName("#define XKB_KEY_KP_Delete 0xff9f")]
    public const int XKB_KEY_KP_Delete = 0xff9f;

    [NativeTypeName("#define XKB_KEY_KP_Equal 0xffbd")]
    public const int XKB_KEY_KP_Equal = 0xffbd;

    [NativeTypeName("#define XKB_KEY_KP_Multiply 0xffaa")]
    public const int XKB_KEY_KP_Multiply = 0xffaa;

    [NativeTypeName("#define XKB_KEY_KP_Add 0xffab")]
    public const int XKB_KEY_KP_Add = 0xffab;

    [NativeTypeName("#define XKB_KEY_KP_Separator 0xffac")]
    public const int XKB_KEY_KP_Separator = 0xffac;

    [NativeTypeName("#define XKB_KEY_KP_Subtract 0xffad")]
    public const int XKB_KEY_KP_Subtract = 0xffad;

    [NativeTypeName("#define XKB_KEY_KP_Decimal 0xffae")]
    public const int XKB_KEY_KP_Decimal = 0xffae;

    [NativeTypeName("#define XKB_KEY_KP_Divide 0xffaf")]
    public const int XKB_KEY_KP_Divide = 0xffaf;

    [NativeTypeName("#define XKB_KEY_KP_0 0xffb0")]
    public const int XKB_KEY_KP_0 = 0xffb0;

    [NativeTypeName("#define XKB_KEY_KP_1 0xffb1")]
    public const int XKB_KEY_KP_1 = 0xffb1;

    [NativeTypeName("#define XKB_KEY_KP_2 0xffb2")]
    public const int XKB_KEY_KP_2 = 0xffb2;

    [NativeTypeName("#define XKB_KEY_KP_3 0xffb3")]
    public const int XKB_KEY_KP_3 = 0xffb3;

    [NativeTypeName("#define XKB_KEY_KP_4 0xffb4")]
    public const int XKB_KEY_KP_4 = 0xffb4;

    [NativeTypeName("#define XKB_KEY_KP_5 0xffb5")]
    public const int XKB_KEY_KP_5 = 0xffb5;

    [NativeTypeName("#define XKB_KEY_KP_6 0xffb6")]
    public const int XKB_KEY_KP_6 = 0xffb6;

    [NativeTypeName("#define XKB_KEY_KP_7 0xffb7")]
    public const int XKB_KEY_KP_7 = 0xffb7;

    [NativeTypeName("#define XKB_KEY_KP_8 0xffb8")]
    public const int XKB_KEY_KP_8 = 0xffb8;

    [NativeTypeName("#define XKB_KEY_KP_9 0xffb9")]
    public const int XKB_KEY_KP_9 = 0xffb9;

    [NativeTypeName("#define XKB_KEY_F1 0xffbe")]
    public const int XKB_KEY_F1 = 0xffbe;

    [NativeTypeName("#define XKB_KEY_F2 0xffbf")]
    public const int XKB_KEY_F2 = 0xffbf;

    [NativeTypeName("#define XKB_KEY_F3 0xffc0")]
    public const int XKB_KEY_F3 = 0xffc0;

    [NativeTypeName("#define XKB_KEY_F4 0xffc1")]
    public const int XKB_KEY_F4 = 0xffc1;

    [NativeTypeName("#define XKB_KEY_F5 0xffc2")]
    public const int XKB_KEY_F5 = 0xffc2;

    [NativeTypeName("#define XKB_KEY_F6 0xffc3")]
    public const int XKB_KEY_F6 = 0xffc3;

    [NativeTypeName("#define XKB_KEY_F7 0xffc4")]
    public const int XKB_KEY_F7 = 0xffc4;

    [NativeTypeName("#define XKB_KEY_F8 0xffc5")]
    public const int XKB_KEY_F8 = 0xffc5;

    [NativeTypeName("#define XKB_KEY_F9 0xffc6")]
    public const int XKB_KEY_F9 = 0xffc6;

    [NativeTypeName("#define XKB_KEY_F10 0xffc7")]
    public const int XKB_KEY_F10 = 0xffc7;

    [NativeTypeName("#define XKB_KEY_F11 0xffc8")]
    public const int XKB_KEY_F11 = 0xffc8;

    [NativeTypeName("#define XKB_KEY_L1 0xffc8")]
    public const int XKB_KEY_L1 = 0xffc8;

    [NativeTypeName("#define XKB_KEY_F12 0xffc9")]
    public const int XKB_KEY_F12 = 0xffc9;

    [NativeTypeName("#define XKB_KEY_L2 0xffc9")]
    public const int XKB_KEY_L2 = 0xffc9;

    [NativeTypeName("#define XKB_KEY_F13 0xffca")]
    public const int XKB_KEY_F13 = 0xffca;

    [NativeTypeName("#define XKB_KEY_L3 0xffca")]
    public const int XKB_KEY_L3 = 0xffca;

    [NativeTypeName("#define XKB_KEY_F14 0xffcb")]
    public const int XKB_KEY_F14 = 0xffcb;

    [NativeTypeName("#define XKB_KEY_L4 0xffcb")]
    public const int XKB_KEY_L4 = 0xffcb;

    [NativeTypeName("#define XKB_KEY_F15 0xffcc")]
    public const int XKB_KEY_F15 = 0xffcc;

    [NativeTypeName("#define XKB_KEY_L5 0xffcc")]
    public const int XKB_KEY_L5 = 0xffcc;

    [NativeTypeName("#define XKB_KEY_F16 0xffcd")]
    public const int XKB_KEY_F16 = 0xffcd;

    [NativeTypeName("#define XKB_KEY_L6 0xffcd")]
    public const int XKB_KEY_L6 = 0xffcd;

    [NativeTypeName("#define XKB_KEY_F17 0xffce")]
    public const int XKB_KEY_F17 = 0xffce;

    [NativeTypeName("#define XKB_KEY_L7 0xffce")]
    public const int XKB_KEY_L7 = 0xffce;

    [NativeTypeName("#define XKB_KEY_F18 0xffcf")]
    public const int XKB_KEY_F18 = 0xffcf;

    [NativeTypeName("#define XKB_KEY_L8 0xffcf")]
    public const int XKB_KEY_L8 = 0xffcf;

    [NativeTypeName("#define XKB_KEY_F19 0xffd0")]
    public const int XKB_KEY_F19 = 0xffd0;

    [NativeTypeName("#define XKB_KEY_L9 0xffd0")]
    public const int XKB_KEY_L9 = 0xffd0;

    [NativeTypeName("#define XKB_KEY_F20 0xffd1")]
    public const int XKB_KEY_F20 = 0xffd1;

    [NativeTypeName("#define XKB_KEY_L10 0xffd1")]
    public const int XKB_KEY_L10 = 0xffd1;

    [NativeTypeName("#define XKB_KEY_F21 0xffd2")]
    public const int XKB_KEY_F21 = 0xffd2;

    [NativeTypeName("#define XKB_KEY_R1 0xffd2")]
    public const int XKB_KEY_R1 = 0xffd2;

    [NativeTypeName("#define XKB_KEY_F22 0xffd3")]
    public const int XKB_KEY_F22 = 0xffd3;

    [NativeTypeName("#define XKB_KEY_R2 0xffd3")]
    public const int XKB_KEY_R2 = 0xffd3;

    [NativeTypeName("#define XKB_KEY_F23 0xffd4")]
    public const int XKB_KEY_F23 = 0xffd4;

    [NativeTypeName("#define XKB_KEY_R3 0xffd4")]
    public const int XKB_KEY_R3 = 0xffd4;

    [NativeTypeName("#define XKB_KEY_F24 0xffd5")]
    public const int XKB_KEY_F24 = 0xffd5;

    [NativeTypeName("#define XKB_KEY_R4 0xffd5")]
    public const int XKB_KEY_R4 = 0xffd5;

    [NativeTypeName("#define XKB_KEY_F25 0xffd6")]
    public const int XKB_KEY_F25 = 0xffd6;

    [NativeTypeName("#define XKB_KEY_R5 0xffd6")]
    public const int XKB_KEY_R5 = 0xffd6;

    [NativeTypeName("#define XKB_KEY_F26 0xffd7")]
    public const int XKB_KEY_F26 = 0xffd7;

    [NativeTypeName("#define XKB_KEY_R6 0xffd7")]
    public const int XKB_KEY_R6 = 0xffd7;

    [NativeTypeName("#define XKB_KEY_F27 0xffd8")]
    public const int XKB_KEY_F27 = 0xffd8;

    [NativeTypeName("#define XKB_KEY_R7 0xffd8")]
    public const int XKB_KEY_R7 = 0xffd8;

    [NativeTypeName("#define XKB_KEY_F28 0xffd9")]
    public const int XKB_KEY_F28 = 0xffd9;

    [NativeTypeName("#define XKB_KEY_R8 0xffd9")]
    public const int XKB_KEY_R8 = 0xffd9;

    [NativeTypeName("#define XKB_KEY_F29 0xffda")]
    public const int XKB_KEY_F29 = 0xffda;

    [NativeTypeName("#define XKB_KEY_R9 0xffda")]
    public const int XKB_KEY_R9 = 0xffda;

    [NativeTypeName("#define XKB_KEY_F30 0xffdb")]
    public const int XKB_KEY_F30 = 0xffdb;

    [NativeTypeName("#define XKB_KEY_R10 0xffdb")]
    public const int XKB_KEY_R10 = 0xffdb;

    [NativeTypeName("#define XKB_KEY_F31 0xffdc")]
    public const int XKB_KEY_F31 = 0xffdc;

    [NativeTypeName("#define XKB_KEY_R11 0xffdc")]
    public const int XKB_KEY_R11 = 0xffdc;

    [NativeTypeName("#define XKB_KEY_F32 0xffdd")]
    public const int XKB_KEY_F32 = 0xffdd;

    [NativeTypeName("#define XKB_KEY_R12 0xffdd")]
    public const int XKB_KEY_R12 = 0xffdd;

    [NativeTypeName("#define XKB_KEY_F33 0xffde")]
    public const int XKB_KEY_F33 = 0xffde;

    [NativeTypeName("#define XKB_KEY_R13 0xffde")]
    public const int XKB_KEY_R13 = 0xffde;

    [NativeTypeName("#define XKB_KEY_F34 0xffdf")]
    public const int XKB_KEY_F34 = 0xffdf;

    [NativeTypeName("#define XKB_KEY_R14 0xffdf")]
    public const int XKB_KEY_R14 = 0xffdf;

    [NativeTypeName("#define XKB_KEY_F35 0xffe0")]
    public const int XKB_KEY_F35 = 0xffe0;

    [NativeTypeName("#define XKB_KEY_R15 0xffe0")]
    public const int XKB_KEY_R15 = 0xffe0;

    [NativeTypeName("#define XKB_KEY_Shift_L 0xffe1")]
    public const int XKB_KEY_Shift_L = 0xffe1;

    [NativeTypeName("#define XKB_KEY_Shift_R 0xffe2")]
    public const int XKB_KEY_Shift_R = 0xffe2;

    [NativeTypeName("#define XKB_KEY_Control_L 0xffe3")]
    public const int XKB_KEY_Control_L = 0xffe3;

    [NativeTypeName("#define XKB_KEY_Control_R 0xffe4")]
    public const int XKB_KEY_Control_R = 0xffe4;

    [NativeTypeName("#define XKB_KEY_Caps_Lock 0xffe5")]
    public const int XKB_KEY_Caps_Lock = 0xffe5;

    [NativeTypeName("#define XKB_KEY_Shift_Lock 0xffe6")]
    public const int XKB_KEY_Shift_Lock = 0xffe6;

    [NativeTypeName("#define XKB_KEY_Meta_L 0xffe7")]
    public const int XKB_KEY_Meta_L = 0xffe7;

    [NativeTypeName("#define XKB_KEY_Meta_R 0xffe8")]
    public const int XKB_KEY_Meta_R = 0xffe8;

    [NativeTypeName("#define XKB_KEY_Alt_L 0xffe9")]
    public const int XKB_KEY_Alt_L = 0xffe9;

    [NativeTypeName("#define XKB_KEY_Alt_R 0xffea")]
    public const int XKB_KEY_Alt_R = 0xffea;

    [NativeTypeName("#define XKB_KEY_Super_L 0xffeb")]
    public const int XKB_KEY_Super_L = 0xffeb;

    [NativeTypeName("#define XKB_KEY_Super_R 0xffec")]
    public const int XKB_KEY_Super_R = 0xffec;

    [NativeTypeName("#define XKB_KEY_Hyper_L 0xffed")]
    public const int XKB_KEY_Hyper_L = 0xffed;

    [NativeTypeName("#define XKB_KEY_Hyper_R 0xffee")]
    public const int XKB_KEY_Hyper_R = 0xffee;

    [NativeTypeName("#define XKB_KEY_ISO_Lock 0xfe01")]
    public const int XKB_KEY_ISO_Lock = 0xfe01;

    [NativeTypeName("#define XKB_KEY_ISO_Level2_Latch 0xfe02")]
    public const int XKB_KEY_ISO_Level2_Latch = 0xfe02;

    [NativeTypeName("#define XKB_KEY_ISO_Level3_Shift 0xfe03")]
    public const int XKB_KEY_ISO_Level3_Shift = 0xfe03;

    [NativeTypeName("#define XKB_KEY_ISO_Level3_Latch 0xfe04")]
    public const int XKB_KEY_ISO_Level3_Latch = 0xfe04;

    [NativeTypeName("#define XKB_KEY_ISO_Level3_Lock 0xfe05")]
    public const int XKB_KEY_ISO_Level3_Lock = 0xfe05;

    [NativeTypeName("#define XKB_KEY_ISO_Level5_Shift 0xfe11")]
    public const int XKB_KEY_ISO_Level5_Shift = 0xfe11;

    [NativeTypeName("#define XKB_KEY_ISO_Level5_Latch 0xfe12")]
    public const int XKB_KEY_ISO_Level5_Latch = 0xfe12;

    [NativeTypeName("#define XKB_KEY_ISO_Level5_Lock 0xfe13")]
    public const int XKB_KEY_ISO_Level5_Lock = 0xfe13;

    [NativeTypeName("#define XKB_KEY_ISO_Group_Shift 0xff7e")]
    public const int XKB_KEY_ISO_Group_Shift = 0xff7e;

    [NativeTypeName("#define XKB_KEY_ISO_Group_Latch 0xfe06")]
    public const int XKB_KEY_ISO_Group_Latch = 0xfe06;

    [NativeTypeName("#define XKB_KEY_ISO_Group_Lock 0xfe07")]
    public const int XKB_KEY_ISO_Group_Lock = 0xfe07;

    [NativeTypeName("#define XKB_KEY_ISO_Next_Group 0xfe08")]
    public const int XKB_KEY_ISO_Next_Group = 0xfe08;

    [NativeTypeName("#define XKB_KEY_ISO_Next_Group_Lock 0xfe09")]
    public const int XKB_KEY_ISO_Next_Group_Lock = 0xfe09;

    [NativeTypeName("#define XKB_KEY_ISO_Prev_Group 0xfe0a")]
    public const int XKB_KEY_ISO_Prev_Group = 0xfe0a;

    [NativeTypeName("#define XKB_KEY_ISO_Prev_Group_Lock 0xfe0b")]
    public const int XKB_KEY_ISO_Prev_Group_Lock = 0xfe0b;

    [NativeTypeName("#define XKB_KEY_ISO_First_Group 0xfe0c")]
    public const int XKB_KEY_ISO_First_Group = 0xfe0c;

    [NativeTypeName("#define XKB_KEY_ISO_First_Group_Lock 0xfe0d")]
    public const int XKB_KEY_ISO_First_Group_Lock = 0xfe0d;

    [NativeTypeName("#define XKB_KEY_ISO_Last_Group 0xfe0e")]
    public const int XKB_KEY_ISO_Last_Group = 0xfe0e;

    [NativeTypeName("#define XKB_KEY_ISO_Last_Group_Lock 0xfe0f")]
    public const int XKB_KEY_ISO_Last_Group_Lock = 0xfe0f;

    [NativeTypeName("#define XKB_KEY_ISO_Left_Tab 0xfe20")]
    public const int XKB_KEY_ISO_Left_Tab = 0xfe20;

    [NativeTypeName("#define XKB_KEY_ISO_Move_Line_Up 0xfe21")]
    public const int XKB_KEY_ISO_Move_Line_Up = 0xfe21;

    [NativeTypeName("#define XKB_KEY_ISO_Move_Line_Down 0xfe22")]
    public const int XKB_KEY_ISO_Move_Line_Down = 0xfe22;

    [NativeTypeName("#define XKB_KEY_ISO_Partial_Line_Up 0xfe23")]
    public const int XKB_KEY_ISO_Partial_Line_Up = 0xfe23;

    [NativeTypeName("#define XKB_KEY_ISO_Partial_Line_Down 0xfe24")]
    public const int XKB_KEY_ISO_Partial_Line_Down = 0xfe24;

    [NativeTypeName("#define XKB_KEY_ISO_Partial_Space_Left 0xfe25")]
    public const int XKB_KEY_ISO_Partial_Space_Left = 0xfe25;

    [NativeTypeName("#define XKB_KEY_ISO_Partial_Space_Right 0xfe26")]
    public const int XKB_KEY_ISO_Partial_Space_Right = 0xfe26;

    [NativeTypeName("#define XKB_KEY_ISO_Set_Margin_Left 0xfe27")]
    public const int XKB_KEY_ISO_Set_Margin_Left = 0xfe27;

    [NativeTypeName("#define XKB_KEY_ISO_Set_Margin_Right 0xfe28")]
    public const int XKB_KEY_ISO_Set_Margin_Right = 0xfe28;

    [NativeTypeName("#define XKB_KEY_ISO_Release_Margin_Left 0xfe29")]
    public const int XKB_KEY_ISO_Release_Margin_Left = 0xfe29;

    [NativeTypeName("#define XKB_KEY_ISO_Release_Margin_Right 0xfe2a")]
    public const int XKB_KEY_ISO_Release_Margin_Right = 0xfe2a;

    [NativeTypeName("#define XKB_KEY_ISO_Release_Both_Margins 0xfe2b")]
    public const int XKB_KEY_ISO_Release_Both_Margins = 0xfe2b;

    [NativeTypeName("#define XKB_KEY_ISO_Fast_Cursor_Left 0xfe2c")]
    public const int XKB_KEY_ISO_Fast_Cursor_Left = 0xfe2c;

    [NativeTypeName("#define XKB_KEY_ISO_Fast_Cursor_Right 0xfe2d")]
    public const int XKB_KEY_ISO_Fast_Cursor_Right = 0xfe2d;

    [NativeTypeName("#define XKB_KEY_ISO_Fast_Cursor_Up 0xfe2e")]
    public const int XKB_KEY_ISO_Fast_Cursor_Up = 0xfe2e;

    [NativeTypeName("#define XKB_KEY_ISO_Fast_Cursor_Down 0xfe2f")]
    public const int XKB_KEY_ISO_Fast_Cursor_Down = 0xfe2f;

    [NativeTypeName("#define XKB_KEY_ISO_Continuous_Underline 0xfe30")]
    public const int XKB_KEY_ISO_Continuous_Underline = 0xfe30;

    [NativeTypeName("#define XKB_KEY_ISO_Discontinuous_Underline 0xfe31")]
    public const int XKB_KEY_ISO_Discontinuous_Underline = 0xfe31;

    [NativeTypeName("#define XKB_KEY_ISO_Emphasize 0xfe32")]
    public const int XKB_KEY_ISO_Emphasize = 0xfe32;

    [NativeTypeName("#define XKB_KEY_ISO_Center_Object 0xfe33")]
    public const int XKB_KEY_ISO_Center_Object = 0xfe33;

    [NativeTypeName("#define XKB_KEY_ISO_Enter 0xfe34")]
    public const int XKB_KEY_ISO_Enter = 0xfe34;

    [NativeTypeName("#define XKB_KEY_dead_grave 0xfe50")]
    public const int XKB_KEY_dead_grave = 0xfe50;

    [NativeTypeName("#define XKB_KEY_dead_acute 0xfe51")]
    public const int XKB_KEY_dead_acute = 0xfe51;

    [NativeTypeName("#define XKB_KEY_dead_circumflex 0xfe52")]
    public const int XKB_KEY_dead_circumflex = 0xfe52;

    [NativeTypeName("#define XKB_KEY_dead_tilde 0xfe53")]
    public const int XKB_KEY_dead_tilde = 0xfe53;

    [NativeTypeName("#define XKB_KEY_dead_perispomeni 0xfe53")]
    public const int XKB_KEY_dead_perispomeni = 0xfe53;

    [NativeTypeName("#define XKB_KEY_dead_macron 0xfe54")]
    public const int XKB_KEY_dead_macron = 0xfe54;

    [NativeTypeName("#define XKB_KEY_dead_breve 0xfe55")]
    public const int XKB_KEY_dead_breve = 0xfe55;

    [NativeTypeName("#define XKB_KEY_dead_abovedot 0xfe56")]
    public const int XKB_KEY_dead_abovedot = 0xfe56;

    [NativeTypeName("#define XKB_KEY_dead_diaeresis 0xfe57")]
    public const int XKB_KEY_dead_diaeresis = 0xfe57;

    [NativeTypeName("#define XKB_KEY_dead_abovering 0xfe58")]
    public const int XKB_KEY_dead_abovering = 0xfe58;

    [NativeTypeName("#define XKB_KEY_dead_doubleacute 0xfe59")]
    public const int XKB_KEY_dead_doubleacute = 0xfe59;

    [NativeTypeName("#define XKB_KEY_dead_caron 0xfe5a")]
    public const int XKB_KEY_dead_caron = 0xfe5a;

    [NativeTypeName("#define XKB_KEY_dead_cedilla 0xfe5b")]
    public const int XKB_KEY_dead_cedilla = 0xfe5b;

    [NativeTypeName("#define XKB_KEY_dead_ogonek 0xfe5c")]
    public const int XKB_KEY_dead_ogonek = 0xfe5c;

    [NativeTypeName("#define XKB_KEY_dead_iota 0xfe5d")]
    public const int XKB_KEY_dead_iota = 0xfe5d;

    [NativeTypeName("#define XKB_KEY_dead_voiced_sound 0xfe5e")]
    public const int XKB_KEY_dead_voiced_sound = 0xfe5e;

    [NativeTypeName("#define XKB_KEY_dead_semivoiced_sound 0xfe5f")]
    public const int XKB_KEY_dead_semivoiced_sound = 0xfe5f;

    [NativeTypeName("#define XKB_KEY_dead_belowdot 0xfe60")]
    public const int XKB_KEY_dead_belowdot = 0xfe60;

    [NativeTypeName("#define XKB_KEY_dead_hook 0xfe61")]
    public const int XKB_KEY_dead_hook = 0xfe61;

    [NativeTypeName("#define XKB_KEY_dead_horn 0xfe62")]
    public const int XKB_KEY_dead_horn = 0xfe62;

    [NativeTypeName("#define XKB_KEY_dead_stroke 0xfe63")]
    public const int XKB_KEY_dead_stroke = 0xfe63;

    [NativeTypeName("#define XKB_KEY_dead_abovecomma 0xfe64")]
    public const int XKB_KEY_dead_abovecomma = 0xfe64;

    [NativeTypeName("#define XKB_KEY_dead_psili 0xfe64")]
    public const int XKB_KEY_dead_psili = 0xfe64;

    [NativeTypeName("#define XKB_KEY_dead_abovereversedcomma 0xfe65")]
    public const int XKB_KEY_dead_abovereversedcomma = 0xfe65;

    [NativeTypeName("#define XKB_KEY_dead_dasia 0xfe65")]
    public const int XKB_KEY_dead_dasia = 0xfe65;

    [NativeTypeName("#define XKB_KEY_dead_doublegrave 0xfe66")]
    public const int XKB_KEY_dead_doublegrave = 0xfe66;

    [NativeTypeName("#define XKB_KEY_dead_belowring 0xfe67")]
    public const int XKB_KEY_dead_belowring = 0xfe67;

    [NativeTypeName("#define XKB_KEY_dead_belowmacron 0xfe68")]
    public const int XKB_KEY_dead_belowmacron = 0xfe68;

    [NativeTypeName("#define XKB_KEY_dead_belowcircumflex 0xfe69")]
    public const int XKB_KEY_dead_belowcircumflex = 0xfe69;

    [NativeTypeName("#define XKB_KEY_dead_belowtilde 0xfe6a")]
    public const int XKB_KEY_dead_belowtilde = 0xfe6a;

    [NativeTypeName("#define XKB_KEY_dead_belowbreve 0xfe6b")]
    public const int XKB_KEY_dead_belowbreve = 0xfe6b;

    [NativeTypeName("#define XKB_KEY_dead_belowdiaeresis 0xfe6c")]
    public const int XKB_KEY_dead_belowdiaeresis = 0xfe6c;

    [NativeTypeName("#define XKB_KEY_dead_invertedbreve 0xfe6d")]
    public const int XKB_KEY_dead_invertedbreve = 0xfe6d;

    [NativeTypeName("#define XKB_KEY_dead_belowcomma 0xfe6e")]
    public const int XKB_KEY_dead_belowcomma = 0xfe6e;

    [NativeTypeName("#define XKB_KEY_dead_currency 0xfe6f")]
    public const int XKB_KEY_dead_currency = 0xfe6f;

    [NativeTypeName("#define XKB_KEY_dead_lowline 0xfe90")]
    public const int XKB_KEY_dead_lowline = 0xfe90;

    [NativeTypeName("#define XKB_KEY_dead_aboveverticalline 0xfe91")]
    public const int XKB_KEY_dead_aboveverticalline = 0xfe91;

    [NativeTypeName("#define XKB_KEY_dead_belowverticalline 0xfe92")]
    public const int XKB_KEY_dead_belowverticalline = 0xfe92;

    [NativeTypeName("#define XKB_KEY_dead_longsolidusoverlay 0xfe93")]
    public const int XKB_KEY_dead_longsolidusoverlay = 0xfe93;

    [NativeTypeName("#define XKB_KEY_dead_a 0xfe80")]
    public const int XKB_KEY_dead_a = 0xfe80;

    [NativeTypeName("#define XKB_KEY_dead_A 0xfe81")]
    public const int XKB_KEY_dead_A = 0xfe81;

    [NativeTypeName("#define XKB_KEY_dead_e 0xfe82")]
    public const int XKB_KEY_dead_e = 0xfe82;

    [NativeTypeName("#define XKB_KEY_dead_E 0xfe83")]
    public const int XKB_KEY_dead_E = 0xfe83;

    [NativeTypeName("#define XKB_KEY_dead_i 0xfe84")]
    public const int XKB_KEY_dead_i = 0xfe84;

    [NativeTypeName("#define XKB_KEY_dead_I 0xfe85")]
    public const int XKB_KEY_dead_I = 0xfe85;

    [NativeTypeName("#define XKB_KEY_dead_o 0xfe86")]
    public const int XKB_KEY_dead_o = 0xfe86;

    [NativeTypeName("#define XKB_KEY_dead_O 0xfe87")]
    public const int XKB_KEY_dead_O = 0xfe87;

    [NativeTypeName("#define XKB_KEY_dead_u 0xfe88")]
    public const int XKB_KEY_dead_u = 0xfe88;

    [NativeTypeName("#define XKB_KEY_dead_U 0xfe89")]
    public const int XKB_KEY_dead_U = 0xfe89;

    [NativeTypeName("#define XKB_KEY_dead_small_schwa 0xfe8a")]
    public const int XKB_KEY_dead_small_schwa = 0xfe8a;

    [NativeTypeName("#define XKB_KEY_dead_capital_schwa 0xfe8b")]
    public const int XKB_KEY_dead_capital_schwa = 0xfe8b;

    [NativeTypeName("#define XKB_KEY_dead_greek 0xfe8c")]
    public const int XKB_KEY_dead_greek = 0xfe8c;

    [NativeTypeName("#define XKB_KEY_First_Virtual_Screen 0xfed0")]
    public const int XKB_KEY_First_Virtual_Screen = 0xfed0;

    [NativeTypeName("#define XKB_KEY_Prev_Virtual_Screen 0xfed1")]
    public const int XKB_KEY_Prev_Virtual_Screen = 0xfed1;

    [NativeTypeName("#define XKB_KEY_Next_Virtual_Screen 0xfed2")]
    public const int XKB_KEY_Next_Virtual_Screen = 0xfed2;

    [NativeTypeName("#define XKB_KEY_Last_Virtual_Screen 0xfed4")]
    public const int XKB_KEY_Last_Virtual_Screen = 0xfed4;

    [NativeTypeName("#define XKB_KEY_Terminate_Server 0xfed5")]
    public const int XKB_KEY_Terminate_Server = 0xfed5;

    [NativeTypeName("#define XKB_KEY_AccessX_Enable 0xfe70")]
    public const int XKB_KEY_AccessX_Enable = 0xfe70;

    [NativeTypeName("#define XKB_KEY_AccessX_Feedback_Enable 0xfe71")]
    public const int XKB_KEY_AccessX_Feedback_Enable = 0xfe71;

    [NativeTypeName("#define XKB_KEY_RepeatKeys_Enable 0xfe72")]
    public const int XKB_KEY_RepeatKeys_Enable = 0xfe72;

    [NativeTypeName("#define XKB_KEY_SlowKeys_Enable 0xfe73")]
    public const int XKB_KEY_SlowKeys_Enable = 0xfe73;

    [NativeTypeName("#define XKB_KEY_BounceKeys_Enable 0xfe74")]
    public const int XKB_KEY_BounceKeys_Enable = 0xfe74;

    [NativeTypeName("#define XKB_KEY_StickyKeys_Enable 0xfe75")]
    public const int XKB_KEY_StickyKeys_Enable = 0xfe75;

    [NativeTypeName("#define XKB_KEY_MouseKeys_Enable 0xfe76")]
    public const int XKB_KEY_MouseKeys_Enable = 0xfe76;

    [NativeTypeName("#define XKB_KEY_MouseKeys_Accel_Enable 0xfe77")]
    public const int XKB_KEY_MouseKeys_Accel_Enable = 0xfe77;

    [NativeTypeName("#define XKB_KEY_Overlay1_Enable 0xfe78")]
    public const int XKB_KEY_Overlay1_Enable = 0xfe78;

    [NativeTypeName("#define XKB_KEY_Overlay2_Enable 0xfe79")]
    public const int XKB_KEY_Overlay2_Enable = 0xfe79;

    [NativeTypeName("#define XKB_KEY_AudibleBell_Enable 0xfe7a")]
    public const int XKB_KEY_AudibleBell_Enable = 0xfe7a;

    [NativeTypeName("#define XKB_KEY_Pointer_Left 0xfee0")]
    public const int XKB_KEY_Pointer_Left = 0xfee0;

    [NativeTypeName("#define XKB_KEY_Pointer_Right 0xfee1")]
    public const int XKB_KEY_Pointer_Right = 0xfee1;

    [NativeTypeName("#define XKB_KEY_Pointer_Up 0xfee2")]
    public const int XKB_KEY_Pointer_Up = 0xfee2;

    [NativeTypeName("#define XKB_KEY_Pointer_Down 0xfee3")]
    public const int XKB_KEY_Pointer_Down = 0xfee3;

    [NativeTypeName("#define XKB_KEY_Pointer_UpLeft 0xfee4")]
    public const int XKB_KEY_Pointer_UpLeft = 0xfee4;

    [NativeTypeName("#define XKB_KEY_Pointer_UpRight 0xfee5")]
    public const int XKB_KEY_Pointer_UpRight = 0xfee5;

    [NativeTypeName("#define XKB_KEY_Pointer_DownLeft 0xfee6")]
    public const int XKB_KEY_Pointer_DownLeft = 0xfee6;

    [NativeTypeName("#define XKB_KEY_Pointer_DownRight 0xfee7")]
    public const int XKB_KEY_Pointer_DownRight = 0xfee7;

    [NativeTypeName("#define XKB_KEY_Pointer_Button_Dflt 0xfee8")]
    public const int XKB_KEY_Pointer_Button_Dflt = 0xfee8;

    [NativeTypeName("#define XKB_KEY_Pointer_Button1 0xfee9")]
    public const int XKB_KEY_Pointer_Button1 = 0xfee9;

    [NativeTypeName("#define XKB_KEY_Pointer_Button2 0xfeea")]
    public const int XKB_KEY_Pointer_Button2 = 0xfeea;

    [NativeTypeName("#define XKB_KEY_Pointer_Button3 0xfeeb")]
    public const int XKB_KEY_Pointer_Button3 = 0xfeeb;

    [NativeTypeName("#define XKB_KEY_Pointer_Button4 0xfeec")]
    public const int XKB_KEY_Pointer_Button4 = 0xfeec;

    [NativeTypeName("#define XKB_KEY_Pointer_Button5 0xfeed")]
    public const int XKB_KEY_Pointer_Button5 = 0xfeed;

    [NativeTypeName("#define XKB_KEY_Pointer_DblClick_Dflt 0xfeee")]
    public const int XKB_KEY_Pointer_DblClick_Dflt = 0xfeee;

    [NativeTypeName("#define XKB_KEY_Pointer_DblClick1 0xfeef")]
    public const int XKB_KEY_Pointer_DblClick1 = 0xfeef;

    [NativeTypeName("#define XKB_KEY_Pointer_DblClick2 0xfef0")]
    public const int XKB_KEY_Pointer_DblClick2 = 0xfef0;

    [NativeTypeName("#define XKB_KEY_Pointer_DblClick3 0xfef1")]
    public const int XKB_KEY_Pointer_DblClick3 = 0xfef1;

    [NativeTypeName("#define XKB_KEY_Pointer_DblClick4 0xfef2")]
    public const int XKB_KEY_Pointer_DblClick4 = 0xfef2;

    [NativeTypeName("#define XKB_KEY_Pointer_DblClick5 0xfef3")]
    public const int XKB_KEY_Pointer_DblClick5 = 0xfef3;

    [NativeTypeName("#define XKB_KEY_Pointer_Drag_Dflt 0xfef4")]
    public const int XKB_KEY_Pointer_Drag_Dflt = 0xfef4;

    [NativeTypeName("#define XKB_KEY_Pointer_Drag1 0xfef5")]
    public const int XKB_KEY_Pointer_Drag1 = 0xfef5;

    [NativeTypeName("#define XKB_KEY_Pointer_Drag2 0xfef6")]
    public const int XKB_KEY_Pointer_Drag2 = 0xfef6;

    [NativeTypeName("#define XKB_KEY_Pointer_Drag3 0xfef7")]
    public const int XKB_KEY_Pointer_Drag3 = 0xfef7;

    [NativeTypeName("#define XKB_KEY_Pointer_Drag4 0xfef8")]
    public const int XKB_KEY_Pointer_Drag4 = 0xfef8;

    [NativeTypeName("#define XKB_KEY_Pointer_Drag5 0xfefd")]
    public const int XKB_KEY_Pointer_Drag5 = 0xfefd;

    [NativeTypeName("#define XKB_KEY_Pointer_EnableKeys 0xfef9")]
    public const int XKB_KEY_Pointer_EnableKeys = 0xfef9;

    [NativeTypeName("#define XKB_KEY_Pointer_Accelerate 0xfefa")]
    public const int XKB_KEY_Pointer_Accelerate = 0xfefa;

    [NativeTypeName("#define XKB_KEY_Pointer_DfltBtnNext 0xfefb")]
    public const int XKB_KEY_Pointer_DfltBtnNext = 0xfefb;

    [NativeTypeName("#define XKB_KEY_Pointer_DfltBtnPrev 0xfefc")]
    public const int XKB_KEY_Pointer_DfltBtnPrev = 0xfefc;

    [NativeTypeName("#define XKB_KEY_ch 0xfea0")]
    public const int XKB_KEY_ch = 0xfea0;

    [NativeTypeName("#define XKB_KEY_Ch 0xfea1")]
    public const int XKB_KEY_Ch = 0xfea1;

    [NativeTypeName("#define XKB_KEY_CH 0xfea2")]
    public const int XKB_KEY_CH = 0xfea2;

    [NativeTypeName("#define XKB_KEY_c_h 0xfea3")]
    public const int XKB_KEY_c_h = 0xfea3;

    [NativeTypeName("#define XKB_KEY_C_h 0xfea4")]
    public const int XKB_KEY_C_h = 0xfea4;

    [NativeTypeName("#define XKB_KEY_C_H 0xfea5")]
    public const int XKB_KEY_C_H = 0xfea5;

    [NativeTypeName("#define XKB_KEY_3270_Duplicate 0xfd01")]
    public const int XKB_KEY_3270_Duplicate = 0xfd01;

    [NativeTypeName("#define XKB_KEY_3270_FieldMark 0xfd02")]
    public const int XKB_KEY_3270_FieldMark = 0xfd02;

    [NativeTypeName("#define XKB_KEY_3270_Right2 0xfd03")]
    public const int XKB_KEY_3270_Right2 = 0xfd03;

    [NativeTypeName("#define XKB_KEY_3270_Left2 0xfd04")]
    public const int XKB_KEY_3270_Left2 = 0xfd04;

    [NativeTypeName("#define XKB_KEY_3270_BackTab 0xfd05")]
    public const int XKB_KEY_3270_BackTab = 0xfd05;

    [NativeTypeName("#define XKB_KEY_3270_EraseEOF 0xfd06")]
    public const int XKB_KEY_3270_EraseEOF = 0xfd06;

    [NativeTypeName("#define XKB_KEY_3270_EraseInput 0xfd07")]
    public const int XKB_KEY_3270_EraseInput = 0xfd07;

    [NativeTypeName("#define XKB_KEY_3270_Reset 0xfd08")]
    public const int XKB_KEY_3270_Reset = 0xfd08;

    [NativeTypeName("#define XKB_KEY_3270_Quit 0xfd09")]
    public const int XKB_KEY_3270_Quit = 0xfd09;

    [NativeTypeName("#define XKB_KEY_3270_PA1 0xfd0a")]
    public const int XKB_KEY_3270_PA1 = 0xfd0a;

    [NativeTypeName("#define XKB_KEY_3270_PA2 0xfd0b")]
    public const int XKB_KEY_3270_PA2 = 0xfd0b;

    [NativeTypeName("#define XKB_KEY_3270_PA3 0xfd0c")]
    public const int XKB_KEY_3270_PA3 = 0xfd0c;

    [NativeTypeName("#define XKB_KEY_3270_Test 0xfd0d")]
    public const int XKB_KEY_3270_Test = 0xfd0d;

    [NativeTypeName("#define XKB_KEY_3270_Attn 0xfd0e")]
    public const int XKB_KEY_3270_Attn = 0xfd0e;

    [NativeTypeName("#define XKB_KEY_3270_CursorBlink 0xfd0f")]
    public const int XKB_KEY_3270_CursorBlink = 0xfd0f;

    [NativeTypeName("#define XKB_KEY_3270_AltCursor 0xfd10")]
    public const int XKB_KEY_3270_AltCursor = 0xfd10;

    [NativeTypeName("#define XKB_KEY_3270_KeyClick 0xfd11")]
    public const int XKB_KEY_3270_KeyClick = 0xfd11;

    [NativeTypeName("#define XKB_KEY_3270_Jump 0xfd12")]
    public const int XKB_KEY_3270_Jump = 0xfd12;

    [NativeTypeName("#define XKB_KEY_3270_Ident 0xfd13")]
    public const int XKB_KEY_3270_Ident = 0xfd13;

    [NativeTypeName("#define XKB_KEY_3270_Rule 0xfd14")]
    public const int XKB_KEY_3270_Rule = 0xfd14;

    [NativeTypeName("#define XKB_KEY_3270_Copy 0xfd15")]
    public const int XKB_KEY_3270_Copy = 0xfd15;

    [NativeTypeName("#define XKB_KEY_3270_Play 0xfd16")]
    public const int XKB_KEY_3270_Play = 0xfd16;

    [NativeTypeName("#define XKB_KEY_3270_Setup 0xfd17")]
    public const int XKB_KEY_3270_Setup = 0xfd17;

    [NativeTypeName("#define XKB_KEY_3270_Record 0xfd18")]
    public const int XKB_KEY_3270_Record = 0xfd18;

    [NativeTypeName("#define XKB_KEY_3270_ChangeScreen 0xfd19")]
    public const int XKB_KEY_3270_ChangeScreen = 0xfd19;

    [NativeTypeName("#define XKB_KEY_3270_DeleteWord 0xfd1a")]
    public const int XKB_KEY_3270_DeleteWord = 0xfd1a;

    [NativeTypeName("#define XKB_KEY_3270_ExSelect 0xfd1b")]
    public const int XKB_KEY_3270_ExSelect = 0xfd1b;

    [NativeTypeName("#define XKB_KEY_3270_CursorSelect 0xfd1c")]
    public const int XKB_KEY_3270_CursorSelect = 0xfd1c;

    [NativeTypeName("#define XKB_KEY_3270_PrintScreen 0xfd1d")]
    public const int XKB_KEY_3270_PrintScreen = 0xfd1d;

    [NativeTypeName("#define XKB_KEY_3270_Enter 0xfd1e")]
    public const int XKB_KEY_3270_Enter = 0xfd1e;

    [NativeTypeName("#define XKB_KEY_space 0x0020")]
    public const int XKB_KEY_space = 0x0020;

    [NativeTypeName("#define XKB_KEY_exclam 0x0021")]
    public const int XKB_KEY_exclam = 0x0021;

    [NativeTypeName("#define XKB_KEY_quotedbl 0x0022")]
    public const int XKB_KEY_quotedbl = 0x0022;

    [NativeTypeName("#define XKB_KEY_numbersign 0x0023")]
    public const int XKB_KEY_numbersign = 0x0023;

    [NativeTypeName("#define XKB_KEY_dollar 0x0024")]
    public const int XKB_KEY_dollar = 0x0024;

    [NativeTypeName("#define XKB_KEY_percent 0x0025")]
    public const int XKB_KEY_percent = 0x0025;

    [NativeTypeName("#define XKB_KEY_ampersand 0x0026")]
    public const int XKB_KEY_ampersand = 0x0026;

    [NativeTypeName("#define XKB_KEY_apostrophe 0x0027")]
    public const int XKB_KEY_apostrophe = 0x0027;

    [NativeTypeName("#define XKB_KEY_quoteright 0x0027")]
    public const int XKB_KEY_quoteright = 0x0027;

    [NativeTypeName("#define XKB_KEY_parenleft 0x0028")]
    public const int XKB_KEY_parenleft = 0x0028;

    [NativeTypeName("#define XKB_KEY_parenright 0x0029")]
    public const int XKB_KEY_parenright = 0x0029;

    [NativeTypeName("#define XKB_KEY_asterisk 0x002a")]
    public const int XKB_KEY_asterisk = 0x002a;

    [NativeTypeName("#define XKB_KEY_plus 0x002b")]
    public const int XKB_KEY_plus = 0x002b;

    [NativeTypeName("#define XKB_KEY_comma 0x002c")]
    public const int XKB_KEY_comma = 0x002c;

    [NativeTypeName("#define XKB_KEY_minus 0x002d")]
    public const int XKB_KEY_minus = 0x002d;

    [NativeTypeName("#define XKB_KEY_period 0x002e")]
    public const int XKB_KEY_period = 0x002e;

    [NativeTypeName("#define XKB_KEY_slash 0x002f")]
    public const int XKB_KEY_slash = 0x002f;

    [NativeTypeName("#define XKB_KEY_0 0x0030")]
    public const int XKB_KEY_0 = 0x0030;

    [NativeTypeName("#define XKB_KEY_1 0x0031")]
    public const int XKB_KEY_1 = 0x0031;

    [NativeTypeName("#define XKB_KEY_2 0x0032")]
    public const int XKB_KEY_2 = 0x0032;

    [NativeTypeName("#define XKB_KEY_3 0x0033")]
    public const int XKB_KEY_3 = 0x0033;

    [NativeTypeName("#define XKB_KEY_4 0x0034")]
    public const int XKB_KEY_4 = 0x0034;

    [NativeTypeName("#define XKB_KEY_5 0x0035")]
    public const int XKB_KEY_5 = 0x0035;

    [NativeTypeName("#define XKB_KEY_6 0x0036")]
    public const int XKB_KEY_6 = 0x0036;

    [NativeTypeName("#define XKB_KEY_7 0x0037")]
    public const int XKB_KEY_7 = 0x0037;

    [NativeTypeName("#define XKB_KEY_8 0x0038")]
    public const int XKB_KEY_8 = 0x0038;

    [NativeTypeName("#define XKB_KEY_9 0x0039")]
    public const int XKB_KEY_9 = 0x0039;

    [NativeTypeName("#define XKB_KEY_colon 0x003a")]
    public const int XKB_KEY_colon = 0x003a;

    [NativeTypeName("#define XKB_KEY_semicolon 0x003b")]
    public const int XKB_KEY_semicolon = 0x003b;

    [NativeTypeName("#define XKB_KEY_less 0x003c")]
    public const int XKB_KEY_less = 0x003c;

    [NativeTypeName("#define XKB_KEY_equal 0x003d")]
    public const int XKB_KEY_equal = 0x003d;

    [NativeTypeName("#define XKB_KEY_greater 0x003e")]
    public const int XKB_KEY_greater = 0x003e;

    [NativeTypeName("#define XKB_KEY_question 0x003f")]
    public const int XKB_KEY_question = 0x003f;

    [NativeTypeName("#define XKB_KEY_at 0x0040")]
    public const int XKB_KEY_at = 0x0040;

    [NativeTypeName("#define XKB_KEY_A 0x0041")]
    public const int XKB_KEY_A = 0x0041;

    [NativeTypeName("#define XKB_KEY_B 0x0042")]
    public const int XKB_KEY_B = 0x0042;

    [NativeTypeName("#define XKB_KEY_C 0x0043")]
    public const int XKB_KEY_C = 0x0043;

    [NativeTypeName("#define XKB_KEY_D 0x0044")]
    public const int XKB_KEY_D = 0x0044;

    [NativeTypeName("#define XKB_KEY_E 0x0045")]
    public const int XKB_KEY_E = 0x0045;

    [NativeTypeName("#define XKB_KEY_F 0x0046")]
    public const int XKB_KEY_F = 0x0046;

    [NativeTypeName("#define XKB_KEY_G 0x0047")]
    public const int XKB_KEY_G = 0x0047;

    [NativeTypeName("#define XKB_KEY_H 0x0048")]
    public const int XKB_KEY_H = 0x0048;

    [NativeTypeName("#define XKB_KEY_I 0x0049")]
    public const int XKB_KEY_I = 0x0049;

    [NativeTypeName("#define XKB_KEY_J 0x004a")]
    public const int XKB_KEY_J = 0x004a;

    [NativeTypeName("#define XKB_KEY_K 0x004b")]
    public const int XKB_KEY_K = 0x004b;

    [NativeTypeName("#define XKB_KEY_L 0x004c")]
    public const int XKB_KEY_L = 0x004c;

    [NativeTypeName("#define XKB_KEY_M 0x004d")]
    public const int XKB_KEY_M = 0x004d;

    [NativeTypeName("#define XKB_KEY_N 0x004e")]
    public const int XKB_KEY_N = 0x004e;

    [NativeTypeName("#define XKB_KEY_O 0x004f")]
    public const int XKB_KEY_O = 0x004f;

    [NativeTypeName("#define XKB_KEY_P 0x0050")]
    public const int XKB_KEY_P = 0x0050;

    [NativeTypeName("#define XKB_KEY_Q 0x0051")]
    public const int XKB_KEY_Q = 0x0051;

    [NativeTypeName("#define XKB_KEY_R 0x0052")]
    public const int XKB_KEY_R = 0x0052;

    [NativeTypeName("#define XKB_KEY_S 0x0053")]
    public const int XKB_KEY_S = 0x0053;

    [NativeTypeName("#define XKB_KEY_T 0x0054")]
    public const int XKB_KEY_T = 0x0054;

    [NativeTypeName("#define XKB_KEY_U 0x0055")]
    public const int XKB_KEY_U = 0x0055;

    [NativeTypeName("#define XKB_KEY_V 0x0056")]
    public const int XKB_KEY_V = 0x0056;

    [NativeTypeName("#define XKB_KEY_W 0x0057")]
    public const int XKB_KEY_W = 0x0057;

    [NativeTypeName("#define XKB_KEY_X 0x0058")]
    public const int XKB_KEY_X = 0x0058;

    [NativeTypeName("#define XKB_KEY_Y 0x0059")]
    public const int XKB_KEY_Y = 0x0059;

    [NativeTypeName("#define XKB_KEY_Z 0x005a")]
    public const int XKB_KEY_Z = 0x005a;

    [NativeTypeName("#define XKB_KEY_bracketleft 0x005b")]
    public const int XKB_KEY_bracketleft = 0x005b;

    [NativeTypeName("#define XKB_KEY_backslash 0x005c")]
    public const int XKB_KEY_backslash = 0x005c;

    [NativeTypeName("#define XKB_KEY_bracketright 0x005d")]
    public const int XKB_KEY_bracketright = 0x005d;

    [NativeTypeName("#define XKB_KEY_asciicircum 0x005e")]
    public const int XKB_KEY_asciicircum = 0x005e;

    [NativeTypeName("#define XKB_KEY_underscore 0x005f")]
    public const int XKB_KEY_underscore = 0x005f;

    [NativeTypeName("#define XKB_KEY_grave 0x0060")]
    public const int XKB_KEY_grave = 0x0060;

    [NativeTypeName("#define XKB_KEY_quoteleft 0x0060")]
    public const int XKB_KEY_quoteleft = 0x0060;

    [NativeTypeName("#define XKB_KEY_a 0x0061")]
    public const int XKB_KEY_a = 0x0061;

    [NativeTypeName("#define XKB_KEY_b 0x0062")]
    public const int XKB_KEY_b = 0x0062;

    [NativeTypeName("#define XKB_KEY_c 0x0063")]
    public const int XKB_KEY_c = 0x0063;

    [NativeTypeName("#define XKB_KEY_d 0x0064")]
    public const int XKB_KEY_d = 0x0064;

    [NativeTypeName("#define XKB_KEY_e 0x0065")]
    public const int XKB_KEY_e = 0x0065;

    [NativeTypeName("#define XKB_KEY_f 0x0066")]
    public const int XKB_KEY_f = 0x0066;

    [NativeTypeName("#define XKB_KEY_g 0x0067")]
    public const int XKB_KEY_g = 0x0067;

    [NativeTypeName("#define XKB_KEY_h 0x0068")]
    public const int XKB_KEY_h = 0x0068;

    [NativeTypeName("#define XKB_KEY_i 0x0069")]
    public const int XKB_KEY_i = 0x0069;

    [NativeTypeName("#define XKB_KEY_j 0x006a")]
    public const int XKB_KEY_j = 0x006a;

    [NativeTypeName("#define XKB_KEY_k 0x006b")]
    public const int XKB_KEY_k = 0x006b;

    [NativeTypeName("#define XKB_KEY_l 0x006c")]
    public const int XKB_KEY_l = 0x006c;

    [NativeTypeName("#define XKB_KEY_m 0x006d")]
    public const int XKB_KEY_m = 0x006d;

    [NativeTypeName("#define XKB_KEY_n 0x006e")]
    public const int XKB_KEY_n = 0x006e;

    [NativeTypeName("#define XKB_KEY_o 0x006f")]
    public const int XKB_KEY_o = 0x006f;

    [NativeTypeName("#define XKB_KEY_p 0x0070")]
    public const int XKB_KEY_p = 0x0070;

    [NativeTypeName("#define XKB_KEY_q 0x0071")]
    public const int XKB_KEY_q = 0x0071;

    [NativeTypeName("#define XKB_KEY_r 0x0072")]
    public const int XKB_KEY_r = 0x0072;

    [NativeTypeName("#define XKB_KEY_s 0x0073")]
    public const int XKB_KEY_s = 0x0073;

    [NativeTypeName("#define XKB_KEY_t 0x0074")]
    public const int XKB_KEY_t = 0x0074;

    [NativeTypeName("#define XKB_KEY_u 0x0075")]
    public const int XKB_KEY_u = 0x0075;

    [NativeTypeName("#define XKB_KEY_v 0x0076")]
    public const int XKB_KEY_v = 0x0076;

    [NativeTypeName("#define XKB_KEY_w 0x0077")]
    public const int XKB_KEY_w = 0x0077;

    [NativeTypeName("#define XKB_KEY_x 0x0078")]
    public const int XKB_KEY_x = 0x0078;

    [NativeTypeName("#define XKB_KEY_y 0x0079")]
    public const int XKB_KEY_y = 0x0079;

    [NativeTypeName("#define XKB_KEY_z 0x007a")]
    public const int XKB_KEY_z = 0x007a;

    [NativeTypeName("#define XKB_KEY_braceleft 0x007b")]
    public const int XKB_KEY_braceleft = 0x007b;

    [NativeTypeName("#define XKB_KEY_bar 0x007c")]
    public const int XKB_KEY_bar = 0x007c;

    [NativeTypeName("#define XKB_KEY_braceright 0x007d")]
    public const int XKB_KEY_braceright = 0x007d;

    [NativeTypeName("#define XKB_KEY_asciitilde 0x007e")]
    public const int XKB_KEY_asciitilde = 0x007e;

    [NativeTypeName("#define XKB_KEY_nobreakspace 0x00a0")]
    public const int XKB_KEY_nobreakspace = 0x00a0;

    [NativeTypeName("#define XKB_KEY_exclamdown 0x00a1")]
    public const int XKB_KEY_exclamdown = 0x00a1;

    [NativeTypeName("#define XKB_KEY_cent 0x00a2")]
    public const int XKB_KEY_cent = 0x00a2;

    [NativeTypeName("#define XKB_KEY_sterling 0x00a3")]
    public const int XKB_KEY_sterling = 0x00a3;

    [NativeTypeName("#define XKB_KEY_currency 0x00a4")]
    public const int XKB_KEY_currency = 0x00a4;

    [NativeTypeName("#define XKB_KEY_yen 0x00a5")]
    public const int XKB_KEY_yen = 0x00a5;

    [NativeTypeName("#define XKB_KEY_brokenbar 0x00a6")]
    public const int XKB_KEY_brokenbar = 0x00a6;

    [NativeTypeName("#define XKB_KEY_section 0x00a7")]
    public const int XKB_KEY_section = 0x00a7;

    [NativeTypeName("#define XKB_KEY_diaeresis 0x00a8")]
    public const int XKB_KEY_diaeresis = 0x00a8;

    [NativeTypeName("#define XKB_KEY_copyright 0x00a9")]
    public const int XKB_KEY_copyright = 0x00a9;

    [NativeTypeName("#define XKB_KEY_ordfeminine 0x00aa")]
    public const int XKB_KEY_ordfeminine = 0x00aa;

    [NativeTypeName("#define XKB_KEY_guillemotleft 0x00ab")]
    public const int XKB_KEY_guillemotleft = 0x00ab;

    [NativeTypeName("#define XKB_KEY_notsign 0x00ac")]
    public const int XKB_KEY_notsign = 0x00ac;

    [NativeTypeName("#define XKB_KEY_hyphen 0x00ad")]
    public const int XKB_KEY_hyphen = 0x00ad;

    [NativeTypeName("#define XKB_KEY_registered 0x00ae")]
    public const int XKB_KEY_registered = 0x00ae;

    [NativeTypeName("#define XKB_KEY_macron 0x00af")]
    public const int XKB_KEY_macron = 0x00af;

    [NativeTypeName("#define XKB_KEY_degree 0x00b0")]
    public const int XKB_KEY_degree = 0x00b0;

    [NativeTypeName("#define XKB_KEY_plusminus 0x00b1")]
    public const int XKB_KEY_plusminus = 0x00b1;

    [NativeTypeName("#define XKB_KEY_twosuperior 0x00b2")]
    public const int XKB_KEY_twosuperior = 0x00b2;

    [NativeTypeName("#define XKB_KEY_threesuperior 0x00b3")]
    public const int XKB_KEY_threesuperior = 0x00b3;

    [NativeTypeName("#define XKB_KEY_acute 0x00b4")]
    public const int XKB_KEY_acute = 0x00b4;

    [NativeTypeName("#define XKB_KEY_mu 0x00b5")]
    public const int XKB_KEY_mu = 0x00b5;

    [NativeTypeName("#define XKB_KEY_paragraph 0x00b6")]
    public const int XKB_KEY_paragraph = 0x00b6;

    [NativeTypeName("#define XKB_KEY_periodcentered 0x00b7")]
    public const int XKB_KEY_periodcentered = 0x00b7;

    [NativeTypeName("#define XKB_KEY_cedilla 0x00b8")]
    public const int XKB_KEY_cedilla = 0x00b8;

    [NativeTypeName("#define XKB_KEY_onesuperior 0x00b9")]
    public const int XKB_KEY_onesuperior = 0x00b9;

    [NativeTypeName("#define XKB_KEY_masculine 0x00ba")]
    public const int XKB_KEY_masculine = 0x00ba;

    [NativeTypeName("#define XKB_KEY_guillemotright 0x00bb")]
    public const int XKB_KEY_guillemotright = 0x00bb;

    [NativeTypeName("#define XKB_KEY_onequarter 0x00bc")]
    public const int XKB_KEY_onequarter = 0x00bc;

    [NativeTypeName("#define XKB_KEY_onehalf 0x00bd")]
    public const int XKB_KEY_onehalf = 0x00bd;

    [NativeTypeName("#define XKB_KEY_threequarters 0x00be")]
    public const int XKB_KEY_threequarters = 0x00be;

    [NativeTypeName("#define XKB_KEY_questiondown 0x00bf")]
    public const int XKB_KEY_questiondown = 0x00bf;

    [NativeTypeName("#define XKB_KEY_Agrave 0x00c0")]
    public const int XKB_KEY_Agrave = 0x00c0;

    [NativeTypeName("#define XKB_KEY_Aacute 0x00c1")]
    public const int XKB_KEY_Aacute = 0x00c1;

    [NativeTypeName("#define XKB_KEY_Acircumflex 0x00c2")]
    public const int XKB_KEY_Acircumflex = 0x00c2;

    [NativeTypeName("#define XKB_KEY_Atilde 0x00c3")]
    public const int XKB_KEY_Atilde = 0x00c3;

    [NativeTypeName("#define XKB_KEY_Adiaeresis 0x00c4")]
    public const int XKB_KEY_Adiaeresis = 0x00c4;

    [NativeTypeName("#define XKB_KEY_Aring 0x00c5")]
    public const int XKB_KEY_Aring = 0x00c5;

    [NativeTypeName("#define XKB_KEY_AE 0x00c6")]
    public const int XKB_KEY_AE = 0x00c6;

    [NativeTypeName("#define XKB_KEY_Ccedilla 0x00c7")]
    public const int XKB_KEY_Ccedilla = 0x00c7;

    [NativeTypeName("#define XKB_KEY_Egrave 0x00c8")]
    public const int XKB_KEY_Egrave = 0x00c8;

    [NativeTypeName("#define XKB_KEY_Eacute 0x00c9")]
    public const int XKB_KEY_Eacute = 0x00c9;

    [NativeTypeName("#define XKB_KEY_Ecircumflex 0x00ca")]
    public const int XKB_KEY_Ecircumflex = 0x00ca;

    [NativeTypeName("#define XKB_KEY_Ediaeresis 0x00cb")]
    public const int XKB_KEY_Ediaeresis = 0x00cb;

    [NativeTypeName("#define XKB_KEY_Igrave 0x00cc")]
    public const int XKB_KEY_Igrave = 0x00cc;

    [NativeTypeName("#define XKB_KEY_Iacute 0x00cd")]
    public const int XKB_KEY_Iacute = 0x00cd;

    [NativeTypeName("#define XKB_KEY_Icircumflex 0x00ce")]
    public const int XKB_KEY_Icircumflex = 0x00ce;

    [NativeTypeName("#define XKB_KEY_Idiaeresis 0x00cf")]
    public const int XKB_KEY_Idiaeresis = 0x00cf;

    [NativeTypeName("#define XKB_KEY_ETH 0x00d0")]
    public const int XKB_KEY_ETH = 0x00d0;

    [NativeTypeName("#define XKB_KEY_Eth 0x00d0")]
    public const int XKB_KEY_Eth = 0x00d0;

    [NativeTypeName("#define XKB_KEY_Ntilde 0x00d1")]
    public const int XKB_KEY_Ntilde = 0x00d1;

    [NativeTypeName("#define XKB_KEY_Ograve 0x00d2")]
    public const int XKB_KEY_Ograve = 0x00d2;

    [NativeTypeName("#define XKB_KEY_Oacute 0x00d3")]
    public const int XKB_KEY_Oacute = 0x00d3;

    [NativeTypeName("#define XKB_KEY_Ocircumflex 0x00d4")]
    public const int XKB_KEY_Ocircumflex = 0x00d4;

    [NativeTypeName("#define XKB_KEY_Otilde 0x00d5")]
    public const int XKB_KEY_Otilde = 0x00d5;

    [NativeTypeName("#define XKB_KEY_Odiaeresis 0x00d6")]
    public const int XKB_KEY_Odiaeresis = 0x00d6;

    [NativeTypeName("#define XKB_KEY_multiply 0x00d7")]
    public const int XKB_KEY_multiply = 0x00d7;

    [NativeTypeName("#define XKB_KEY_Oslash 0x00d8")]
    public const int XKB_KEY_Oslash = 0x00d8;

    [NativeTypeName("#define XKB_KEY_Ooblique 0x00d8")]
    public const int XKB_KEY_Ooblique = 0x00d8;

    [NativeTypeName("#define XKB_KEY_Ugrave 0x00d9")]
    public const int XKB_KEY_Ugrave = 0x00d9;

    [NativeTypeName("#define XKB_KEY_Uacute 0x00da")]
    public const int XKB_KEY_Uacute = 0x00da;

    [NativeTypeName("#define XKB_KEY_Ucircumflex 0x00db")]
    public const int XKB_KEY_Ucircumflex = 0x00db;

    [NativeTypeName("#define XKB_KEY_Udiaeresis 0x00dc")]
    public const int XKB_KEY_Udiaeresis = 0x00dc;

    [NativeTypeName("#define XKB_KEY_Yacute 0x00dd")]
    public const int XKB_KEY_Yacute = 0x00dd;

    [NativeTypeName("#define XKB_KEY_THORN 0x00de")]
    public const int XKB_KEY_THORN = 0x00de;

    [NativeTypeName("#define XKB_KEY_Thorn 0x00de")]
    public const int XKB_KEY_Thorn = 0x00de;

    [NativeTypeName("#define XKB_KEY_ssharp 0x00df")]
    public const int XKB_KEY_ssharp = 0x00df;

    [NativeTypeName("#define XKB_KEY_agrave 0x00e0")]
    public const int XKB_KEY_agrave = 0x00e0;

    [NativeTypeName("#define XKB_KEY_aacute 0x00e1")]
    public const int XKB_KEY_aacute = 0x00e1;

    [NativeTypeName("#define XKB_KEY_acircumflex 0x00e2")]
    public const int XKB_KEY_acircumflex = 0x00e2;

    [NativeTypeName("#define XKB_KEY_atilde 0x00e3")]
    public const int XKB_KEY_atilde = 0x00e3;

    [NativeTypeName("#define XKB_KEY_adiaeresis 0x00e4")]
    public const int XKB_KEY_adiaeresis = 0x00e4;

    [NativeTypeName("#define XKB_KEY_aring 0x00e5")]
    public const int XKB_KEY_aring = 0x00e5;

    [NativeTypeName("#define XKB_KEY_ae 0x00e6")]
    public const int XKB_KEY_ae = 0x00e6;

    [NativeTypeName("#define XKB_KEY_ccedilla 0x00e7")]
    public const int XKB_KEY_ccedilla = 0x00e7;

    [NativeTypeName("#define XKB_KEY_egrave 0x00e8")]
    public const int XKB_KEY_egrave = 0x00e8;

    [NativeTypeName("#define XKB_KEY_eacute 0x00e9")]
    public const int XKB_KEY_eacute = 0x00e9;

    [NativeTypeName("#define XKB_KEY_ecircumflex 0x00ea")]
    public const int XKB_KEY_ecircumflex = 0x00ea;

    [NativeTypeName("#define XKB_KEY_ediaeresis 0x00eb")]
    public const int XKB_KEY_ediaeresis = 0x00eb;

    [NativeTypeName("#define XKB_KEY_igrave 0x00ec")]
    public const int XKB_KEY_igrave = 0x00ec;

    [NativeTypeName("#define XKB_KEY_iacute 0x00ed")]
    public const int XKB_KEY_iacute = 0x00ed;

    [NativeTypeName("#define XKB_KEY_icircumflex 0x00ee")]
    public const int XKB_KEY_icircumflex = 0x00ee;

    [NativeTypeName("#define XKB_KEY_idiaeresis 0x00ef")]
    public const int XKB_KEY_idiaeresis = 0x00ef;

    [NativeTypeName("#define XKB_KEY_eth 0x00f0")]
    public const int XKB_KEY_eth = 0x00f0;

    [NativeTypeName("#define XKB_KEY_ntilde 0x00f1")]
    public const int XKB_KEY_ntilde = 0x00f1;

    [NativeTypeName("#define XKB_KEY_ograve 0x00f2")]
    public const int XKB_KEY_ograve = 0x00f2;

    [NativeTypeName("#define XKB_KEY_oacute 0x00f3")]
    public const int XKB_KEY_oacute = 0x00f3;

    [NativeTypeName("#define XKB_KEY_ocircumflex 0x00f4")]
    public const int XKB_KEY_ocircumflex = 0x00f4;

    [NativeTypeName("#define XKB_KEY_otilde 0x00f5")]
    public const int XKB_KEY_otilde = 0x00f5;

    [NativeTypeName("#define XKB_KEY_odiaeresis 0x00f6")]
    public const int XKB_KEY_odiaeresis = 0x00f6;

    [NativeTypeName("#define XKB_KEY_division 0x00f7")]
    public const int XKB_KEY_division = 0x00f7;

    [NativeTypeName("#define XKB_KEY_oslash 0x00f8")]
    public const int XKB_KEY_oslash = 0x00f8;

    [NativeTypeName("#define XKB_KEY_ooblique 0x00f8")]
    public const int XKB_KEY_ooblique = 0x00f8;

    [NativeTypeName("#define XKB_KEY_ugrave 0x00f9")]
    public const int XKB_KEY_ugrave = 0x00f9;

    [NativeTypeName("#define XKB_KEY_uacute 0x00fa")]
    public const int XKB_KEY_uacute = 0x00fa;

    [NativeTypeName("#define XKB_KEY_ucircumflex 0x00fb")]
    public const int XKB_KEY_ucircumflex = 0x00fb;

    [NativeTypeName("#define XKB_KEY_udiaeresis 0x00fc")]
    public const int XKB_KEY_udiaeresis = 0x00fc;

    [NativeTypeName("#define XKB_KEY_yacute 0x00fd")]
    public const int XKB_KEY_yacute = 0x00fd;

    [NativeTypeName("#define XKB_KEY_thorn 0x00fe")]
    public const int XKB_KEY_thorn = 0x00fe;

    [NativeTypeName("#define XKB_KEY_ydiaeresis 0x00ff")]
    public const int XKB_KEY_ydiaeresis = 0x00ff;

    [NativeTypeName("#define XKB_KEY_Aogonek 0x01a1")]
    public const int XKB_KEY_Aogonek = 0x01a1;

    [NativeTypeName("#define XKB_KEY_breve 0x01a2")]
    public const int XKB_KEY_breve = 0x01a2;

    [NativeTypeName("#define XKB_KEY_Lstroke 0x01a3")]
    public const int XKB_KEY_Lstroke = 0x01a3;

    [NativeTypeName("#define XKB_KEY_Lcaron 0x01a5")]
    public const int XKB_KEY_Lcaron = 0x01a5;

    [NativeTypeName("#define XKB_KEY_Sacute 0x01a6")]
    public const int XKB_KEY_Sacute = 0x01a6;

    [NativeTypeName("#define XKB_KEY_Scaron 0x01a9")]
    public const int XKB_KEY_Scaron = 0x01a9;

    [NativeTypeName("#define XKB_KEY_Scedilla 0x01aa")]
    public const int XKB_KEY_Scedilla = 0x01aa;

    [NativeTypeName("#define XKB_KEY_Tcaron 0x01ab")]
    public const int XKB_KEY_Tcaron = 0x01ab;

    [NativeTypeName("#define XKB_KEY_Zacute 0x01ac")]
    public const int XKB_KEY_Zacute = 0x01ac;

    [NativeTypeName("#define XKB_KEY_Zcaron 0x01ae")]
    public const int XKB_KEY_Zcaron = 0x01ae;

    [NativeTypeName("#define XKB_KEY_Zabovedot 0x01af")]
    public const int XKB_KEY_Zabovedot = 0x01af;

    [NativeTypeName("#define XKB_KEY_aogonek 0x01b1")]
    public const int XKB_KEY_aogonek = 0x01b1;

    [NativeTypeName("#define XKB_KEY_ogonek 0x01b2")]
    public const int XKB_KEY_ogonek = 0x01b2;

    [NativeTypeName("#define XKB_KEY_lstroke 0x01b3")]
    public const int XKB_KEY_lstroke = 0x01b3;

    [NativeTypeName("#define XKB_KEY_lcaron 0x01b5")]
    public const int XKB_KEY_lcaron = 0x01b5;

    [NativeTypeName("#define XKB_KEY_sacute 0x01b6")]
    public const int XKB_KEY_sacute = 0x01b6;

    [NativeTypeName("#define XKB_KEY_caron 0x01b7")]
    public const int XKB_KEY_caron = 0x01b7;

    [NativeTypeName("#define XKB_KEY_scaron 0x01b9")]
    public const int XKB_KEY_scaron = 0x01b9;

    [NativeTypeName("#define XKB_KEY_scedilla 0x01ba")]
    public const int XKB_KEY_scedilla = 0x01ba;

    [NativeTypeName("#define XKB_KEY_tcaron 0x01bb")]
    public const int XKB_KEY_tcaron = 0x01bb;

    [NativeTypeName("#define XKB_KEY_zacute 0x01bc")]
    public const int XKB_KEY_zacute = 0x01bc;

    [NativeTypeName("#define XKB_KEY_doubleacute 0x01bd")]
    public const int XKB_KEY_doubleacute = 0x01bd;

    [NativeTypeName("#define XKB_KEY_zcaron 0x01be")]
    public const int XKB_KEY_zcaron = 0x01be;

    [NativeTypeName("#define XKB_KEY_zabovedot 0x01bf")]
    public const int XKB_KEY_zabovedot = 0x01bf;

    [NativeTypeName("#define XKB_KEY_Racute 0x01c0")]
    public const int XKB_KEY_Racute = 0x01c0;

    [NativeTypeName("#define XKB_KEY_Abreve 0x01c3")]
    public const int XKB_KEY_Abreve = 0x01c3;

    [NativeTypeName("#define XKB_KEY_Lacute 0x01c5")]
    public const int XKB_KEY_Lacute = 0x01c5;

    [NativeTypeName("#define XKB_KEY_Cacute 0x01c6")]
    public const int XKB_KEY_Cacute = 0x01c6;

    [NativeTypeName("#define XKB_KEY_Ccaron 0x01c8")]
    public const int XKB_KEY_Ccaron = 0x01c8;

    [NativeTypeName("#define XKB_KEY_Eogonek 0x01ca")]
    public const int XKB_KEY_Eogonek = 0x01ca;

    [NativeTypeName("#define XKB_KEY_Ecaron 0x01cc")]
    public const int XKB_KEY_Ecaron = 0x01cc;

    [NativeTypeName("#define XKB_KEY_Dcaron 0x01cf")]
    public const int XKB_KEY_Dcaron = 0x01cf;

    [NativeTypeName("#define XKB_KEY_Dstroke 0x01d0")]
    public const int XKB_KEY_Dstroke = 0x01d0;

    [NativeTypeName("#define XKB_KEY_Nacute 0x01d1")]
    public const int XKB_KEY_Nacute = 0x01d1;

    [NativeTypeName("#define XKB_KEY_Ncaron 0x01d2")]
    public const int XKB_KEY_Ncaron = 0x01d2;

    [NativeTypeName("#define XKB_KEY_Odoubleacute 0x01d5")]
    public const int XKB_KEY_Odoubleacute = 0x01d5;

    [NativeTypeName("#define XKB_KEY_Rcaron 0x01d8")]
    public const int XKB_KEY_Rcaron = 0x01d8;

    [NativeTypeName("#define XKB_KEY_Uring 0x01d9")]
    public const int XKB_KEY_Uring = 0x01d9;

    [NativeTypeName("#define XKB_KEY_Udoubleacute 0x01db")]
    public const int XKB_KEY_Udoubleacute = 0x01db;

    [NativeTypeName("#define XKB_KEY_Tcedilla 0x01de")]
    public const int XKB_KEY_Tcedilla = 0x01de;

    [NativeTypeName("#define XKB_KEY_racute 0x01e0")]
    public const int XKB_KEY_racute = 0x01e0;

    [NativeTypeName("#define XKB_KEY_abreve 0x01e3")]
    public const int XKB_KEY_abreve = 0x01e3;

    [NativeTypeName("#define XKB_KEY_lacute 0x01e5")]
    public const int XKB_KEY_lacute = 0x01e5;

    [NativeTypeName("#define XKB_KEY_cacute 0x01e6")]
    public const int XKB_KEY_cacute = 0x01e6;

    [NativeTypeName("#define XKB_KEY_ccaron 0x01e8")]
    public const int XKB_KEY_ccaron = 0x01e8;

    [NativeTypeName("#define XKB_KEY_eogonek 0x01ea")]
    public const int XKB_KEY_eogonek = 0x01ea;

    [NativeTypeName("#define XKB_KEY_ecaron 0x01ec")]
    public const int XKB_KEY_ecaron = 0x01ec;

    [NativeTypeName("#define XKB_KEY_dcaron 0x01ef")]
    public const int XKB_KEY_dcaron = 0x01ef;

    [NativeTypeName("#define XKB_KEY_dstroke 0x01f0")]
    public const int XKB_KEY_dstroke = 0x01f0;

    [NativeTypeName("#define XKB_KEY_nacute 0x01f1")]
    public const int XKB_KEY_nacute = 0x01f1;

    [NativeTypeName("#define XKB_KEY_ncaron 0x01f2")]
    public const int XKB_KEY_ncaron = 0x01f2;

    [NativeTypeName("#define XKB_KEY_odoubleacute 0x01f5")]
    public const int XKB_KEY_odoubleacute = 0x01f5;

    [NativeTypeName("#define XKB_KEY_rcaron 0x01f8")]
    public const int XKB_KEY_rcaron = 0x01f8;

    [NativeTypeName("#define XKB_KEY_uring 0x01f9")]
    public const int XKB_KEY_uring = 0x01f9;

    [NativeTypeName("#define XKB_KEY_udoubleacute 0x01fb")]
    public const int XKB_KEY_udoubleacute = 0x01fb;

    [NativeTypeName("#define XKB_KEY_tcedilla 0x01fe")]
    public const int XKB_KEY_tcedilla = 0x01fe;

    [NativeTypeName("#define XKB_KEY_abovedot 0x01ff")]
    public const int XKB_KEY_abovedot = 0x01ff;

    [NativeTypeName("#define XKB_KEY_Hstroke 0x02a1")]
    public const int XKB_KEY_Hstroke = 0x02a1;

    [NativeTypeName("#define XKB_KEY_Hcircumflex 0x02a6")]
    public const int XKB_KEY_Hcircumflex = 0x02a6;

    [NativeTypeName("#define XKB_KEY_Iabovedot 0x02a9")]
    public const int XKB_KEY_Iabovedot = 0x02a9;

    [NativeTypeName("#define XKB_KEY_Gbreve 0x02ab")]
    public const int XKB_KEY_Gbreve = 0x02ab;

    [NativeTypeName("#define XKB_KEY_Jcircumflex 0x02ac")]
    public const int XKB_KEY_Jcircumflex = 0x02ac;

    [NativeTypeName("#define XKB_KEY_hstroke 0x02b1")]
    public const int XKB_KEY_hstroke = 0x02b1;

    [NativeTypeName("#define XKB_KEY_hcircumflex 0x02b6")]
    public const int XKB_KEY_hcircumflex = 0x02b6;

    [NativeTypeName("#define XKB_KEY_idotless 0x02b9")]
    public const int XKB_KEY_idotless = 0x02b9;

    [NativeTypeName("#define XKB_KEY_gbreve 0x02bb")]
    public const int XKB_KEY_gbreve = 0x02bb;

    [NativeTypeName("#define XKB_KEY_jcircumflex 0x02bc")]
    public const int XKB_KEY_jcircumflex = 0x02bc;

    [NativeTypeName("#define XKB_KEY_Cabovedot 0x02c5")]
    public const int XKB_KEY_Cabovedot = 0x02c5;

    [NativeTypeName("#define XKB_KEY_Ccircumflex 0x02c6")]
    public const int XKB_KEY_Ccircumflex = 0x02c6;

    [NativeTypeName("#define XKB_KEY_Gabovedot 0x02d5")]
    public const int XKB_KEY_Gabovedot = 0x02d5;

    [NativeTypeName("#define XKB_KEY_Gcircumflex 0x02d8")]
    public const int XKB_KEY_Gcircumflex = 0x02d8;

    [NativeTypeName("#define XKB_KEY_Ubreve 0x02dd")]
    public const int XKB_KEY_Ubreve = 0x02dd;

    [NativeTypeName("#define XKB_KEY_Scircumflex 0x02de")]
    public const int XKB_KEY_Scircumflex = 0x02de;

    [NativeTypeName("#define XKB_KEY_cabovedot 0x02e5")]
    public const int XKB_KEY_cabovedot = 0x02e5;

    [NativeTypeName("#define XKB_KEY_ccircumflex 0x02e6")]
    public const int XKB_KEY_ccircumflex = 0x02e6;

    [NativeTypeName("#define XKB_KEY_gabovedot 0x02f5")]
    public const int XKB_KEY_gabovedot = 0x02f5;

    [NativeTypeName("#define XKB_KEY_gcircumflex 0x02f8")]
    public const int XKB_KEY_gcircumflex = 0x02f8;

    [NativeTypeName("#define XKB_KEY_ubreve 0x02fd")]
    public const int XKB_KEY_ubreve = 0x02fd;

    [NativeTypeName("#define XKB_KEY_scircumflex 0x02fe")]
    public const int XKB_KEY_scircumflex = 0x02fe;

    [NativeTypeName("#define XKB_KEY_kra 0x03a2")]
    public const int XKB_KEY_kra = 0x03a2;

    [NativeTypeName("#define XKB_KEY_kappa 0x03a2")]
    public const int XKB_KEY_kappa = 0x03a2;

    [NativeTypeName("#define XKB_KEY_Rcedilla 0x03a3")]
    public const int XKB_KEY_Rcedilla = 0x03a3;

    [NativeTypeName("#define XKB_KEY_Itilde 0x03a5")]
    public const int XKB_KEY_Itilde = 0x03a5;

    [NativeTypeName("#define XKB_KEY_Lcedilla 0x03a6")]
    public const int XKB_KEY_Lcedilla = 0x03a6;

    [NativeTypeName("#define XKB_KEY_Emacron 0x03aa")]
    public const int XKB_KEY_Emacron = 0x03aa;

    [NativeTypeName("#define XKB_KEY_Gcedilla 0x03ab")]
    public const int XKB_KEY_Gcedilla = 0x03ab;

    [NativeTypeName("#define XKB_KEY_Tslash 0x03ac")]
    public const int XKB_KEY_Tslash = 0x03ac;

    [NativeTypeName("#define XKB_KEY_rcedilla 0x03b3")]
    public const int XKB_KEY_rcedilla = 0x03b3;

    [NativeTypeName("#define XKB_KEY_itilde 0x03b5")]
    public const int XKB_KEY_itilde = 0x03b5;

    [NativeTypeName("#define XKB_KEY_lcedilla 0x03b6")]
    public const int XKB_KEY_lcedilla = 0x03b6;

    [NativeTypeName("#define XKB_KEY_emacron 0x03ba")]
    public const int XKB_KEY_emacron = 0x03ba;

    [NativeTypeName("#define XKB_KEY_gcedilla 0x03bb")]
    public const int XKB_KEY_gcedilla = 0x03bb;

    [NativeTypeName("#define XKB_KEY_tslash 0x03bc")]
    public const int XKB_KEY_tslash = 0x03bc;

    [NativeTypeName("#define XKB_KEY_ENG 0x03bd")]
    public const int XKB_KEY_ENG = 0x03bd;

    [NativeTypeName("#define XKB_KEY_eng 0x03bf")]
    public const int XKB_KEY_eng = 0x03bf;

    [NativeTypeName("#define XKB_KEY_Amacron 0x03c0")]
    public const int XKB_KEY_Amacron = 0x03c0;

    [NativeTypeName("#define XKB_KEY_Iogonek 0x03c7")]
    public const int XKB_KEY_Iogonek = 0x03c7;

    [NativeTypeName("#define XKB_KEY_Eabovedot 0x03cc")]
    public const int XKB_KEY_Eabovedot = 0x03cc;

    [NativeTypeName("#define XKB_KEY_Imacron 0x03cf")]
    public const int XKB_KEY_Imacron = 0x03cf;

    [NativeTypeName("#define XKB_KEY_Ncedilla 0x03d1")]
    public const int XKB_KEY_Ncedilla = 0x03d1;

    [NativeTypeName("#define XKB_KEY_Omacron 0x03d2")]
    public const int XKB_KEY_Omacron = 0x03d2;

    [NativeTypeName("#define XKB_KEY_Kcedilla 0x03d3")]
    public const int XKB_KEY_Kcedilla = 0x03d3;

    [NativeTypeName("#define XKB_KEY_Uogonek 0x03d9")]
    public const int XKB_KEY_Uogonek = 0x03d9;

    [NativeTypeName("#define XKB_KEY_Utilde 0x03dd")]
    public const int XKB_KEY_Utilde = 0x03dd;

    [NativeTypeName("#define XKB_KEY_Umacron 0x03de")]
    public const int XKB_KEY_Umacron = 0x03de;

    [NativeTypeName("#define XKB_KEY_amacron 0x03e0")]
    public const int XKB_KEY_amacron = 0x03e0;

    [NativeTypeName("#define XKB_KEY_iogonek 0x03e7")]
    public const int XKB_KEY_iogonek = 0x03e7;

    [NativeTypeName("#define XKB_KEY_eabovedot 0x03ec")]
    public const int XKB_KEY_eabovedot = 0x03ec;

    [NativeTypeName("#define XKB_KEY_imacron 0x03ef")]
    public const int XKB_KEY_imacron = 0x03ef;

    [NativeTypeName("#define XKB_KEY_ncedilla 0x03f1")]
    public const int XKB_KEY_ncedilla = 0x03f1;

    [NativeTypeName("#define XKB_KEY_omacron 0x03f2")]
    public const int XKB_KEY_omacron = 0x03f2;

    [NativeTypeName("#define XKB_KEY_kcedilla 0x03f3")]
    public const int XKB_KEY_kcedilla = 0x03f3;

    [NativeTypeName("#define XKB_KEY_uogonek 0x03f9")]
    public const int XKB_KEY_uogonek = 0x03f9;

    [NativeTypeName("#define XKB_KEY_utilde 0x03fd")]
    public const int XKB_KEY_utilde = 0x03fd;

    [NativeTypeName("#define XKB_KEY_umacron 0x03fe")]
    public const int XKB_KEY_umacron = 0x03fe;

    [NativeTypeName("#define XKB_KEY_Wcircumflex 0x1000174")]
    public const int XKB_KEY_Wcircumflex = 0x1000174;

    [NativeTypeName("#define XKB_KEY_wcircumflex 0x1000175")]
    public const int XKB_KEY_wcircumflex = 0x1000175;

    [NativeTypeName("#define XKB_KEY_Ycircumflex 0x1000176")]
    public const int XKB_KEY_Ycircumflex = 0x1000176;

    [NativeTypeName("#define XKB_KEY_ycircumflex 0x1000177")]
    public const int XKB_KEY_ycircumflex = 0x1000177;

    [NativeTypeName("#define XKB_KEY_Babovedot 0x1001e02")]
    public const int XKB_KEY_Babovedot = 0x1001e02;

    [NativeTypeName("#define XKB_KEY_babovedot 0x1001e03")]
    public const int XKB_KEY_babovedot = 0x1001e03;

    [NativeTypeName("#define XKB_KEY_Dabovedot 0x1001e0a")]
    public const int XKB_KEY_Dabovedot = 0x1001e0a;

    [NativeTypeName("#define XKB_KEY_dabovedot 0x1001e0b")]
    public const int XKB_KEY_dabovedot = 0x1001e0b;

    [NativeTypeName("#define XKB_KEY_Fabovedot 0x1001e1e")]
    public const int XKB_KEY_Fabovedot = 0x1001e1e;

    [NativeTypeName("#define XKB_KEY_fabovedot 0x1001e1f")]
    public const int XKB_KEY_fabovedot = 0x1001e1f;

    [NativeTypeName("#define XKB_KEY_Mabovedot 0x1001e40")]
    public const int XKB_KEY_Mabovedot = 0x1001e40;

    [NativeTypeName("#define XKB_KEY_mabovedot 0x1001e41")]
    public const int XKB_KEY_mabovedot = 0x1001e41;

    [NativeTypeName("#define XKB_KEY_Pabovedot 0x1001e56")]
    public const int XKB_KEY_Pabovedot = 0x1001e56;

    [NativeTypeName("#define XKB_KEY_pabovedot 0x1001e57")]
    public const int XKB_KEY_pabovedot = 0x1001e57;

    [NativeTypeName("#define XKB_KEY_Sabovedot 0x1001e60")]
    public const int XKB_KEY_Sabovedot = 0x1001e60;

    [NativeTypeName("#define XKB_KEY_sabovedot 0x1001e61")]
    public const int XKB_KEY_sabovedot = 0x1001e61;

    [NativeTypeName("#define XKB_KEY_Tabovedot 0x1001e6a")]
    public const int XKB_KEY_Tabovedot = 0x1001e6a;

    [NativeTypeName("#define XKB_KEY_tabovedot 0x1001e6b")]
    public const int XKB_KEY_tabovedot = 0x1001e6b;

    [NativeTypeName("#define XKB_KEY_Wgrave 0x1001e80")]
    public const int XKB_KEY_Wgrave = 0x1001e80;

    [NativeTypeName("#define XKB_KEY_wgrave 0x1001e81")]
    public const int XKB_KEY_wgrave = 0x1001e81;

    [NativeTypeName("#define XKB_KEY_Wacute 0x1001e82")]
    public const int XKB_KEY_Wacute = 0x1001e82;

    [NativeTypeName("#define XKB_KEY_wacute 0x1001e83")]
    public const int XKB_KEY_wacute = 0x1001e83;

    [NativeTypeName("#define XKB_KEY_Wdiaeresis 0x1001e84")]
    public const int XKB_KEY_Wdiaeresis = 0x1001e84;

    [NativeTypeName("#define XKB_KEY_wdiaeresis 0x1001e85")]
    public const int XKB_KEY_wdiaeresis = 0x1001e85;

    [NativeTypeName("#define XKB_KEY_Ygrave 0x1001ef2")]
    public const int XKB_KEY_Ygrave = 0x1001ef2;

    [NativeTypeName("#define XKB_KEY_ygrave 0x1001ef3")]
    public const int XKB_KEY_ygrave = 0x1001ef3;

    [NativeTypeName("#define XKB_KEY_OE 0x13bc")]
    public const int XKB_KEY_OE = 0x13bc;

    [NativeTypeName("#define XKB_KEY_oe 0x13bd")]
    public const int XKB_KEY_oe = 0x13bd;

    [NativeTypeName("#define XKB_KEY_Ydiaeresis 0x13be")]
    public const int XKB_KEY_Ydiaeresis = 0x13be;

    [NativeTypeName("#define XKB_KEY_overline 0x047e")]
    public const int XKB_KEY_overline = 0x047e;

    [NativeTypeName("#define XKB_KEY_kana_fullstop 0x04a1")]
    public const int XKB_KEY_kana_fullstop = 0x04a1;

    [NativeTypeName("#define XKB_KEY_kana_openingbracket 0x04a2")]
    public const int XKB_KEY_kana_openingbracket = 0x04a2;

    [NativeTypeName("#define XKB_KEY_kana_closingbracket 0x04a3")]
    public const int XKB_KEY_kana_closingbracket = 0x04a3;

    [NativeTypeName("#define XKB_KEY_kana_comma 0x04a4")]
    public const int XKB_KEY_kana_comma = 0x04a4;

    [NativeTypeName("#define XKB_KEY_kana_conjunctive 0x04a5")]
    public const int XKB_KEY_kana_conjunctive = 0x04a5;

    [NativeTypeName("#define XKB_KEY_kana_middledot 0x04a5")]
    public const int XKB_KEY_kana_middledot = 0x04a5;

    [NativeTypeName("#define XKB_KEY_kana_WO 0x04a6")]
    public const int XKB_KEY_kana_WO = 0x04a6;

    [NativeTypeName("#define XKB_KEY_kana_a 0x04a7")]
    public const int XKB_KEY_kana_a = 0x04a7;

    [NativeTypeName("#define XKB_KEY_kana_i 0x04a8")]
    public const int XKB_KEY_kana_i = 0x04a8;

    [NativeTypeName("#define XKB_KEY_kana_u 0x04a9")]
    public const int XKB_KEY_kana_u = 0x04a9;

    [NativeTypeName("#define XKB_KEY_kana_e 0x04aa")]
    public const int XKB_KEY_kana_e = 0x04aa;

    [NativeTypeName("#define XKB_KEY_kana_o 0x04ab")]
    public const int XKB_KEY_kana_o = 0x04ab;

    [NativeTypeName("#define XKB_KEY_kana_ya 0x04ac")]
    public const int XKB_KEY_kana_ya = 0x04ac;

    [NativeTypeName("#define XKB_KEY_kana_yu 0x04ad")]
    public const int XKB_KEY_kana_yu = 0x04ad;

    [NativeTypeName("#define XKB_KEY_kana_yo 0x04ae")]
    public const int XKB_KEY_kana_yo = 0x04ae;

    [NativeTypeName("#define XKB_KEY_kana_tsu 0x04af")]
    public const int XKB_KEY_kana_tsu = 0x04af;

    [NativeTypeName("#define XKB_KEY_kana_tu 0x04af")]
    public const int XKB_KEY_kana_tu = 0x04af;

    [NativeTypeName("#define XKB_KEY_prolongedsound 0x04b0")]
    public const int XKB_KEY_prolongedsound = 0x04b0;

    [NativeTypeName("#define XKB_KEY_kana_A 0x04b1")]
    public const int XKB_KEY_kana_A = 0x04b1;

    [NativeTypeName("#define XKB_KEY_kana_I 0x04b2")]
    public const int XKB_KEY_kana_I = 0x04b2;

    [NativeTypeName("#define XKB_KEY_kana_U 0x04b3")]
    public const int XKB_KEY_kana_U = 0x04b3;

    [NativeTypeName("#define XKB_KEY_kana_E 0x04b4")]
    public const int XKB_KEY_kana_E = 0x04b4;

    [NativeTypeName("#define XKB_KEY_kana_O 0x04b5")]
    public const int XKB_KEY_kana_O = 0x04b5;

    [NativeTypeName("#define XKB_KEY_kana_KA 0x04b6")]
    public const int XKB_KEY_kana_KA = 0x04b6;

    [NativeTypeName("#define XKB_KEY_kana_KI 0x04b7")]
    public const int XKB_KEY_kana_KI = 0x04b7;

    [NativeTypeName("#define XKB_KEY_kana_KU 0x04b8")]
    public const int XKB_KEY_kana_KU = 0x04b8;

    [NativeTypeName("#define XKB_KEY_kana_KE 0x04b9")]
    public const int XKB_KEY_kana_KE = 0x04b9;

    [NativeTypeName("#define XKB_KEY_kana_KO 0x04ba")]
    public const int XKB_KEY_kana_KO = 0x04ba;

    [NativeTypeName("#define XKB_KEY_kana_SA 0x04bb")]
    public const int XKB_KEY_kana_SA = 0x04bb;

    [NativeTypeName("#define XKB_KEY_kana_SHI 0x04bc")]
    public const int XKB_KEY_kana_SHI = 0x04bc;

    [NativeTypeName("#define XKB_KEY_kana_SU 0x04bd")]
    public const int XKB_KEY_kana_SU = 0x04bd;

    [NativeTypeName("#define XKB_KEY_kana_SE 0x04be")]
    public const int XKB_KEY_kana_SE = 0x04be;

    [NativeTypeName("#define XKB_KEY_kana_SO 0x04bf")]
    public const int XKB_KEY_kana_SO = 0x04bf;

    [NativeTypeName("#define XKB_KEY_kana_TA 0x04c0")]
    public const int XKB_KEY_kana_TA = 0x04c0;

    [NativeTypeName("#define XKB_KEY_kana_CHI 0x04c1")]
    public const int XKB_KEY_kana_CHI = 0x04c1;

    [NativeTypeName("#define XKB_KEY_kana_TI 0x04c1")]
    public const int XKB_KEY_kana_TI = 0x04c1;

    [NativeTypeName("#define XKB_KEY_kana_TSU 0x04c2")]
    public const int XKB_KEY_kana_TSU = 0x04c2;

    [NativeTypeName("#define XKB_KEY_kana_TU 0x04c2")]
    public const int XKB_KEY_kana_TU = 0x04c2;

    [NativeTypeName("#define XKB_KEY_kana_TE 0x04c3")]
    public const int XKB_KEY_kana_TE = 0x04c3;

    [NativeTypeName("#define XKB_KEY_kana_TO 0x04c4")]
    public const int XKB_KEY_kana_TO = 0x04c4;

    [NativeTypeName("#define XKB_KEY_kana_NA 0x04c5")]
    public const int XKB_KEY_kana_NA = 0x04c5;

    [NativeTypeName("#define XKB_KEY_kana_NI 0x04c6")]
    public const int XKB_KEY_kana_NI = 0x04c6;

    [NativeTypeName("#define XKB_KEY_kana_NU 0x04c7")]
    public const int XKB_KEY_kana_NU = 0x04c7;

    [NativeTypeName("#define XKB_KEY_kana_NE 0x04c8")]
    public const int XKB_KEY_kana_NE = 0x04c8;

    [NativeTypeName("#define XKB_KEY_kana_NO 0x04c9")]
    public const int XKB_KEY_kana_NO = 0x04c9;

    [NativeTypeName("#define XKB_KEY_kana_HA 0x04ca")]
    public const int XKB_KEY_kana_HA = 0x04ca;

    [NativeTypeName("#define XKB_KEY_kana_HI 0x04cb")]
    public const int XKB_KEY_kana_HI = 0x04cb;

    [NativeTypeName("#define XKB_KEY_kana_FU 0x04cc")]
    public const int XKB_KEY_kana_FU = 0x04cc;

    [NativeTypeName("#define XKB_KEY_kana_HU 0x04cc")]
    public const int XKB_KEY_kana_HU = 0x04cc;

    [NativeTypeName("#define XKB_KEY_kana_HE 0x04cd")]
    public const int XKB_KEY_kana_HE = 0x04cd;

    [NativeTypeName("#define XKB_KEY_kana_HO 0x04ce")]
    public const int XKB_KEY_kana_HO = 0x04ce;

    [NativeTypeName("#define XKB_KEY_kana_MA 0x04cf")]
    public const int XKB_KEY_kana_MA = 0x04cf;

    [NativeTypeName("#define XKB_KEY_kana_MI 0x04d0")]
    public const int XKB_KEY_kana_MI = 0x04d0;

    [NativeTypeName("#define XKB_KEY_kana_MU 0x04d1")]
    public const int XKB_KEY_kana_MU = 0x04d1;

    [NativeTypeName("#define XKB_KEY_kana_ME 0x04d2")]
    public const int XKB_KEY_kana_ME = 0x04d2;

    [NativeTypeName("#define XKB_KEY_kana_MO 0x04d3")]
    public const int XKB_KEY_kana_MO = 0x04d3;

    [NativeTypeName("#define XKB_KEY_kana_YA 0x04d4")]
    public const int XKB_KEY_kana_YA = 0x04d4;

    [NativeTypeName("#define XKB_KEY_kana_YU 0x04d5")]
    public const int XKB_KEY_kana_YU = 0x04d5;

    [NativeTypeName("#define XKB_KEY_kana_YO 0x04d6")]
    public const int XKB_KEY_kana_YO = 0x04d6;

    [NativeTypeName("#define XKB_KEY_kana_RA 0x04d7")]
    public const int XKB_KEY_kana_RA = 0x04d7;

    [NativeTypeName("#define XKB_KEY_kana_RI 0x04d8")]
    public const int XKB_KEY_kana_RI = 0x04d8;

    [NativeTypeName("#define XKB_KEY_kana_RU 0x04d9")]
    public const int XKB_KEY_kana_RU = 0x04d9;

    [NativeTypeName("#define XKB_KEY_kana_RE 0x04da")]
    public const int XKB_KEY_kana_RE = 0x04da;

    [NativeTypeName("#define XKB_KEY_kana_RO 0x04db")]
    public const int XKB_KEY_kana_RO = 0x04db;

    [NativeTypeName("#define XKB_KEY_kana_WA 0x04dc")]
    public const int XKB_KEY_kana_WA = 0x04dc;

    [NativeTypeName("#define XKB_KEY_kana_N 0x04dd")]
    public const int XKB_KEY_kana_N = 0x04dd;

    [NativeTypeName("#define XKB_KEY_voicedsound 0x04de")]
    public const int XKB_KEY_voicedsound = 0x04de;

    [NativeTypeName("#define XKB_KEY_semivoicedsound 0x04df")]
    public const int XKB_KEY_semivoicedsound = 0x04df;

    [NativeTypeName("#define XKB_KEY_kana_switch 0xff7e")]
    public const int XKB_KEY_kana_switch = 0xff7e;

    [NativeTypeName("#define XKB_KEY_Farsi_0 0x10006f0")]
    public const int XKB_KEY_Farsi_0 = 0x10006f0;

    [NativeTypeName("#define XKB_KEY_Farsi_1 0x10006f1")]
    public const int XKB_KEY_Farsi_1 = 0x10006f1;

    [NativeTypeName("#define XKB_KEY_Farsi_2 0x10006f2")]
    public const int XKB_KEY_Farsi_2 = 0x10006f2;

    [NativeTypeName("#define XKB_KEY_Farsi_3 0x10006f3")]
    public const int XKB_KEY_Farsi_3 = 0x10006f3;

    [NativeTypeName("#define XKB_KEY_Farsi_4 0x10006f4")]
    public const int XKB_KEY_Farsi_4 = 0x10006f4;

    [NativeTypeName("#define XKB_KEY_Farsi_5 0x10006f5")]
    public const int XKB_KEY_Farsi_5 = 0x10006f5;

    [NativeTypeName("#define XKB_KEY_Farsi_6 0x10006f6")]
    public const int XKB_KEY_Farsi_6 = 0x10006f6;

    [NativeTypeName("#define XKB_KEY_Farsi_7 0x10006f7")]
    public const int XKB_KEY_Farsi_7 = 0x10006f7;

    [NativeTypeName("#define XKB_KEY_Farsi_8 0x10006f8")]
    public const int XKB_KEY_Farsi_8 = 0x10006f8;

    [NativeTypeName("#define XKB_KEY_Farsi_9 0x10006f9")]
    public const int XKB_KEY_Farsi_9 = 0x10006f9;

    [NativeTypeName("#define XKB_KEY_Arabic_percent 0x100066a")]
    public const int XKB_KEY_Arabic_percent = 0x100066a;

    [NativeTypeName("#define XKB_KEY_Arabic_superscript_alef 0x1000670")]
    public const int XKB_KEY_Arabic_superscript_alef = 0x1000670;

    [NativeTypeName("#define XKB_KEY_Arabic_tteh 0x1000679")]
    public const int XKB_KEY_Arabic_tteh = 0x1000679;

    [NativeTypeName("#define XKB_KEY_Arabic_peh 0x100067e")]
    public const int XKB_KEY_Arabic_peh = 0x100067e;

    [NativeTypeName("#define XKB_KEY_Arabic_tcheh 0x1000686")]
    public const int XKB_KEY_Arabic_tcheh = 0x1000686;

    [NativeTypeName("#define XKB_KEY_Arabic_ddal 0x1000688")]
    public const int XKB_KEY_Arabic_ddal = 0x1000688;

    [NativeTypeName("#define XKB_KEY_Arabic_rreh 0x1000691")]
    public const int XKB_KEY_Arabic_rreh = 0x1000691;

    [NativeTypeName("#define XKB_KEY_Arabic_comma 0x05ac")]
    public const int XKB_KEY_Arabic_comma = 0x05ac;

    [NativeTypeName("#define XKB_KEY_Arabic_fullstop 0x10006d4")]
    public const int XKB_KEY_Arabic_fullstop = 0x10006d4;

    [NativeTypeName("#define XKB_KEY_Arabic_0 0x1000660")]
    public const int XKB_KEY_Arabic_0 = 0x1000660;

    [NativeTypeName("#define XKB_KEY_Arabic_1 0x1000661")]
    public const int XKB_KEY_Arabic_1 = 0x1000661;

    [NativeTypeName("#define XKB_KEY_Arabic_2 0x1000662")]
    public const int XKB_KEY_Arabic_2 = 0x1000662;

    [NativeTypeName("#define XKB_KEY_Arabic_3 0x1000663")]
    public const int XKB_KEY_Arabic_3 = 0x1000663;

    [NativeTypeName("#define XKB_KEY_Arabic_4 0x1000664")]
    public const int XKB_KEY_Arabic_4 = 0x1000664;

    [NativeTypeName("#define XKB_KEY_Arabic_5 0x1000665")]
    public const int XKB_KEY_Arabic_5 = 0x1000665;

    [NativeTypeName("#define XKB_KEY_Arabic_6 0x1000666")]
    public const int XKB_KEY_Arabic_6 = 0x1000666;

    [NativeTypeName("#define XKB_KEY_Arabic_7 0x1000667")]
    public const int XKB_KEY_Arabic_7 = 0x1000667;

    [NativeTypeName("#define XKB_KEY_Arabic_8 0x1000668")]
    public const int XKB_KEY_Arabic_8 = 0x1000668;

    [NativeTypeName("#define XKB_KEY_Arabic_9 0x1000669")]
    public const int XKB_KEY_Arabic_9 = 0x1000669;

    [NativeTypeName("#define XKB_KEY_Arabic_semicolon 0x05bb")]
    public const int XKB_KEY_Arabic_semicolon = 0x05bb;

    [NativeTypeName("#define XKB_KEY_Arabic_question_mark 0x05bf")]
    public const int XKB_KEY_Arabic_question_mark = 0x05bf;

    [NativeTypeName("#define XKB_KEY_Arabic_hamza 0x05c1")]
    public const int XKB_KEY_Arabic_hamza = 0x05c1;

    [NativeTypeName("#define XKB_KEY_Arabic_maddaonalef 0x05c2")]
    public const int XKB_KEY_Arabic_maddaonalef = 0x05c2;

    [NativeTypeName("#define XKB_KEY_Arabic_hamzaonalef 0x05c3")]
    public const int XKB_KEY_Arabic_hamzaonalef = 0x05c3;

    [NativeTypeName("#define XKB_KEY_Arabic_hamzaonwaw 0x05c4")]
    public const int XKB_KEY_Arabic_hamzaonwaw = 0x05c4;

    [NativeTypeName("#define XKB_KEY_Arabic_hamzaunderalef 0x05c5")]
    public const int XKB_KEY_Arabic_hamzaunderalef = 0x05c5;

    [NativeTypeName("#define XKB_KEY_Arabic_hamzaonyeh 0x05c6")]
    public const int XKB_KEY_Arabic_hamzaonyeh = 0x05c6;

    [NativeTypeName("#define XKB_KEY_Arabic_alef 0x05c7")]
    public const int XKB_KEY_Arabic_alef = 0x05c7;

    [NativeTypeName("#define XKB_KEY_Arabic_beh 0x05c8")]
    public const int XKB_KEY_Arabic_beh = 0x05c8;

    [NativeTypeName("#define XKB_KEY_Arabic_tehmarbuta 0x05c9")]
    public const int XKB_KEY_Arabic_tehmarbuta = 0x05c9;

    [NativeTypeName("#define XKB_KEY_Arabic_teh 0x05ca")]
    public const int XKB_KEY_Arabic_teh = 0x05ca;

    [NativeTypeName("#define XKB_KEY_Arabic_theh 0x05cb")]
    public const int XKB_KEY_Arabic_theh = 0x05cb;

    [NativeTypeName("#define XKB_KEY_Arabic_jeem 0x05cc")]
    public const int XKB_KEY_Arabic_jeem = 0x05cc;

    [NativeTypeName("#define XKB_KEY_Arabic_hah 0x05cd")]
    public const int XKB_KEY_Arabic_hah = 0x05cd;

    [NativeTypeName("#define XKB_KEY_Arabic_khah 0x05ce")]
    public const int XKB_KEY_Arabic_khah = 0x05ce;

    [NativeTypeName("#define XKB_KEY_Arabic_dal 0x05cf")]
    public const int XKB_KEY_Arabic_dal = 0x05cf;

    [NativeTypeName("#define XKB_KEY_Arabic_thal 0x05d0")]
    public const int XKB_KEY_Arabic_thal = 0x05d0;

    [NativeTypeName("#define XKB_KEY_Arabic_ra 0x05d1")]
    public const int XKB_KEY_Arabic_ra = 0x05d1;

    [NativeTypeName("#define XKB_KEY_Arabic_zain 0x05d2")]
    public const int XKB_KEY_Arabic_zain = 0x05d2;

    [NativeTypeName("#define XKB_KEY_Arabic_seen 0x05d3")]
    public const int XKB_KEY_Arabic_seen = 0x05d3;

    [NativeTypeName("#define XKB_KEY_Arabic_sheen 0x05d4")]
    public const int XKB_KEY_Arabic_sheen = 0x05d4;

    [NativeTypeName("#define XKB_KEY_Arabic_sad 0x05d5")]
    public const int XKB_KEY_Arabic_sad = 0x05d5;

    [NativeTypeName("#define XKB_KEY_Arabic_dad 0x05d6")]
    public const int XKB_KEY_Arabic_dad = 0x05d6;

    [NativeTypeName("#define XKB_KEY_Arabic_tah 0x05d7")]
    public const int XKB_KEY_Arabic_tah = 0x05d7;

    [NativeTypeName("#define XKB_KEY_Arabic_zah 0x05d8")]
    public const int XKB_KEY_Arabic_zah = 0x05d8;

    [NativeTypeName("#define XKB_KEY_Arabic_ain 0x05d9")]
    public const int XKB_KEY_Arabic_ain = 0x05d9;

    [NativeTypeName("#define XKB_KEY_Arabic_ghain 0x05da")]
    public const int XKB_KEY_Arabic_ghain = 0x05da;

    [NativeTypeName("#define XKB_KEY_Arabic_tatweel 0x05e0")]
    public const int XKB_KEY_Arabic_tatweel = 0x05e0;

    [NativeTypeName("#define XKB_KEY_Arabic_feh 0x05e1")]
    public const int XKB_KEY_Arabic_feh = 0x05e1;

    [NativeTypeName("#define XKB_KEY_Arabic_qaf 0x05e2")]
    public const int XKB_KEY_Arabic_qaf = 0x05e2;

    [NativeTypeName("#define XKB_KEY_Arabic_kaf 0x05e3")]
    public const int XKB_KEY_Arabic_kaf = 0x05e3;

    [NativeTypeName("#define XKB_KEY_Arabic_lam 0x05e4")]
    public const int XKB_KEY_Arabic_lam = 0x05e4;

    [NativeTypeName("#define XKB_KEY_Arabic_meem 0x05e5")]
    public const int XKB_KEY_Arabic_meem = 0x05e5;

    [NativeTypeName("#define XKB_KEY_Arabic_noon 0x05e6")]
    public const int XKB_KEY_Arabic_noon = 0x05e6;

    [NativeTypeName("#define XKB_KEY_Arabic_ha 0x05e7")]
    public const int XKB_KEY_Arabic_ha = 0x05e7;

    [NativeTypeName("#define XKB_KEY_Arabic_heh 0x05e7")]
    public const int XKB_KEY_Arabic_heh = 0x05e7;

    [NativeTypeName("#define XKB_KEY_Arabic_waw 0x05e8")]
    public const int XKB_KEY_Arabic_waw = 0x05e8;

    [NativeTypeName("#define XKB_KEY_Arabic_alefmaksura 0x05e9")]
    public const int XKB_KEY_Arabic_alefmaksura = 0x05e9;

    [NativeTypeName("#define XKB_KEY_Arabic_yeh 0x05ea")]
    public const int XKB_KEY_Arabic_yeh = 0x05ea;

    [NativeTypeName("#define XKB_KEY_Arabic_fathatan 0x05eb")]
    public const int XKB_KEY_Arabic_fathatan = 0x05eb;

    [NativeTypeName("#define XKB_KEY_Arabic_dammatan 0x05ec")]
    public const int XKB_KEY_Arabic_dammatan = 0x05ec;

    [NativeTypeName("#define XKB_KEY_Arabic_kasratan 0x05ed")]
    public const int XKB_KEY_Arabic_kasratan = 0x05ed;

    [NativeTypeName("#define XKB_KEY_Arabic_fatha 0x05ee")]
    public const int XKB_KEY_Arabic_fatha = 0x05ee;

    [NativeTypeName("#define XKB_KEY_Arabic_damma 0x05ef")]
    public const int XKB_KEY_Arabic_damma = 0x05ef;

    [NativeTypeName("#define XKB_KEY_Arabic_kasra 0x05f0")]
    public const int XKB_KEY_Arabic_kasra = 0x05f0;

    [NativeTypeName("#define XKB_KEY_Arabic_shadda 0x05f1")]
    public const int XKB_KEY_Arabic_shadda = 0x05f1;

    [NativeTypeName("#define XKB_KEY_Arabic_sukun 0x05f2")]
    public const int XKB_KEY_Arabic_sukun = 0x05f2;

    [NativeTypeName("#define XKB_KEY_Arabic_madda_above 0x1000653")]
    public const int XKB_KEY_Arabic_madda_above = 0x1000653;

    [NativeTypeName("#define XKB_KEY_Arabic_hamza_above 0x1000654")]
    public const int XKB_KEY_Arabic_hamza_above = 0x1000654;

    [NativeTypeName("#define XKB_KEY_Arabic_hamza_below 0x1000655")]
    public const int XKB_KEY_Arabic_hamza_below = 0x1000655;

    [NativeTypeName("#define XKB_KEY_Arabic_jeh 0x1000698")]
    public const int XKB_KEY_Arabic_jeh = 0x1000698;

    [NativeTypeName("#define XKB_KEY_Arabic_veh 0x10006a4")]
    public const int XKB_KEY_Arabic_veh = 0x10006a4;

    [NativeTypeName("#define XKB_KEY_Arabic_keheh 0x10006a9")]
    public const int XKB_KEY_Arabic_keheh = 0x10006a9;

    [NativeTypeName("#define XKB_KEY_Arabic_gaf 0x10006af")]
    public const int XKB_KEY_Arabic_gaf = 0x10006af;

    [NativeTypeName("#define XKB_KEY_Arabic_noon_ghunna 0x10006ba")]
    public const int XKB_KEY_Arabic_noon_ghunna = 0x10006ba;

    [NativeTypeName("#define XKB_KEY_Arabic_heh_doachashmee 0x10006be")]
    public const int XKB_KEY_Arabic_heh_doachashmee = 0x10006be;

    [NativeTypeName("#define XKB_KEY_Farsi_yeh 0x10006cc")]
    public const int XKB_KEY_Farsi_yeh = 0x10006cc;

    [NativeTypeName("#define XKB_KEY_Arabic_farsi_yeh 0x10006cc")]
    public const int XKB_KEY_Arabic_farsi_yeh = 0x10006cc;

    [NativeTypeName("#define XKB_KEY_Arabic_yeh_baree 0x10006d2")]
    public const int XKB_KEY_Arabic_yeh_baree = 0x10006d2;

    [NativeTypeName("#define XKB_KEY_Arabic_heh_goal 0x10006c1")]
    public const int XKB_KEY_Arabic_heh_goal = 0x10006c1;

    [NativeTypeName("#define XKB_KEY_Arabic_switch 0xff7e")]
    public const int XKB_KEY_Arabic_switch = 0xff7e;

    [NativeTypeName("#define XKB_KEY_Cyrillic_GHE_bar 0x1000492")]
    public const int XKB_KEY_Cyrillic_GHE_bar = 0x1000492;

    [NativeTypeName("#define XKB_KEY_Cyrillic_ghe_bar 0x1000493")]
    public const int XKB_KEY_Cyrillic_ghe_bar = 0x1000493;

    [NativeTypeName("#define XKB_KEY_Cyrillic_ZHE_descender 0x1000496")]
    public const int XKB_KEY_Cyrillic_ZHE_descender = 0x1000496;

    [NativeTypeName("#define XKB_KEY_Cyrillic_zhe_descender 0x1000497")]
    public const int XKB_KEY_Cyrillic_zhe_descender = 0x1000497;

    [NativeTypeName("#define XKB_KEY_Cyrillic_KA_descender 0x100049a")]
    public const int XKB_KEY_Cyrillic_KA_descender = 0x100049a;

    [NativeTypeName("#define XKB_KEY_Cyrillic_ka_descender 0x100049b")]
    public const int XKB_KEY_Cyrillic_ka_descender = 0x100049b;

    [NativeTypeName("#define XKB_KEY_Cyrillic_KA_vertstroke 0x100049c")]
    public const int XKB_KEY_Cyrillic_KA_vertstroke = 0x100049c;

    [NativeTypeName("#define XKB_KEY_Cyrillic_ka_vertstroke 0x100049d")]
    public const int XKB_KEY_Cyrillic_ka_vertstroke = 0x100049d;

    [NativeTypeName("#define XKB_KEY_Cyrillic_EN_descender 0x10004a2")]
    public const int XKB_KEY_Cyrillic_EN_descender = 0x10004a2;

    [NativeTypeName("#define XKB_KEY_Cyrillic_en_descender 0x10004a3")]
    public const int XKB_KEY_Cyrillic_en_descender = 0x10004a3;

    [NativeTypeName("#define XKB_KEY_Cyrillic_U_straight 0x10004ae")]
    public const int XKB_KEY_Cyrillic_U_straight = 0x10004ae;

    [NativeTypeName("#define XKB_KEY_Cyrillic_u_straight 0x10004af")]
    public const int XKB_KEY_Cyrillic_u_straight = 0x10004af;

    [NativeTypeName("#define XKB_KEY_Cyrillic_U_straight_bar 0x10004b0")]
    public const int XKB_KEY_Cyrillic_U_straight_bar = 0x10004b0;

    [NativeTypeName("#define XKB_KEY_Cyrillic_u_straight_bar 0x10004b1")]
    public const int XKB_KEY_Cyrillic_u_straight_bar = 0x10004b1;

    [NativeTypeName("#define XKB_KEY_Cyrillic_HA_descender 0x10004b2")]
    public const int XKB_KEY_Cyrillic_HA_descender = 0x10004b2;

    [NativeTypeName("#define XKB_KEY_Cyrillic_ha_descender 0x10004b3")]
    public const int XKB_KEY_Cyrillic_ha_descender = 0x10004b3;

    [NativeTypeName("#define XKB_KEY_Cyrillic_CHE_descender 0x10004b6")]
    public const int XKB_KEY_Cyrillic_CHE_descender = 0x10004b6;

    [NativeTypeName("#define XKB_KEY_Cyrillic_che_descender 0x10004b7")]
    public const int XKB_KEY_Cyrillic_che_descender = 0x10004b7;

    [NativeTypeName("#define XKB_KEY_Cyrillic_CHE_vertstroke 0x10004b8")]
    public const int XKB_KEY_Cyrillic_CHE_vertstroke = 0x10004b8;

    [NativeTypeName("#define XKB_KEY_Cyrillic_che_vertstroke 0x10004b9")]
    public const int XKB_KEY_Cyrillic_che_vertstroke = 0x10004b9;

    [NativeTypeName("#define XKB_KEY_Cyrillic_SHHA 0x10004ba")]
    public const int XKB_KEY_Cyrillic_SHHA = 0x10004ba;

    [NativeTypeName("#define XKB_KEY_Cyrillic_shha 0x10004bb")]
    public const int XKB_KEY_Cyrillic_shha = 0x10004bb;

    [NativeTypeName("#define XKB_KEY_Cyrillic_SCHWA 0x10004d8")]
    public const int XKB_KEY_Cyrillic_SCHWA = 0x10004d8;

    [NativeTypeName("#define XKB_KEY_Cyrillic_schwa 0x10004d9")]
    public const int XKB_KEY_Cyrillic_schwa = 0x10004d9;

    [NativeTypeName("#define XKB_KEY_Cyrillic_I_macron 0x10004e2")]
    public const int XKB_KEY_Cyrillic_I_macron = 0x10004e2;

    [NativeTypeName("#define XKB_KEY_Cyrillic_i_macron 0x10004e3")]
    public const int XKB_KEY_Cyrillic_i_macron = 0x10004e3;

    [NativeTypeName("#define XKB_KEY_Cyrillic_O_bar 0x10004e8")]
    public const int XKB_KEY_Cyrillic_O_bar = 0x10004e8;

    [NativeTypeName("#define XKB_KEY_Cyrillic_o_bar 0x10004e9")]
    public const int XKB_KEY_Cyrillic_o_bar = 0x10004e9;

    [NativeTypeName("#define XKB_KEY_Cyrillic_U_macron 0x10004ee")]
    public const int XKB_KEY_Cyrillic_U_macron = 0x10004ee;

    [NativeTypeName("#define XKB_KEY_Cyrillic_u_macron 0x10004ef")]
    public const int XKB_KEY_Cyrillic_u_macron = 0x10004ef;

    [NativeTypeName("#define XKB_KEY_Serbian_dje 0x06a1")]
    public const int XKB_KEY_Serbian_dje = 0x06a1;

    [NativeTypeName("#define XKB_KEY_Macedonia_gje 0x06a2")]
    public const int XKB_KEY_Macedonia_gje = 0x06a2;

    [NativeTypeName("#define XKB_KEY_Cyrillic_io 0x06a3")]
    public const int XKB_KEY_Cyrillic_io = 0x06a3;

    [NativeTypeName("#define XKB_KEY_Ukrainian_ie 0x06a4")]
    public const int XKB_KEY_Ukrainian_ie = 0x06a4;

    [NativeTypeName("#define XKB_KEY_Ukranian_je 0x06a4")]
    public const int XKB_KEY_Ukranian_je = 0x06a4;

    [NativeTypeName("#define XKB_KEY_Macedonia_dse 0x06a5")]
    public const int XKB_KEY_Macedonia_dse = 0x06a5;

    [NativeTypeName("#define XKB_KEY_Ukrainian_i 0x06a6")]
    public const int XKB_KEY_Ukrainian_i = 0x06a6;

    [NativeTypeName("#define XKB_KEY_Ukranian_i 0x06a6")]
    public const int XKB_KEY_Ukranian_i = 0x06a6;

    [NativeTypeName("#define XKB_KEY_Ukrainian_yi 0x06a7")]
    public const int XKB_KEY_Ukrainian_yi = 0x06a7;

    [NativeTypeName("#define XKB_KEY_Ukranian_yi 0x06a7")]
    public const int XKB_KEY_Ukranian_yi = 0x06a7;

    [NativeTypeName("#define XKB_KEY_Cyrillic_je 0x06a8")]
    public const int XKB_KEY_Cyrillic_je = 0x06a8;

    [NativeTypeName("#define XKB_KEY_Serbian_je 0x06a8")]
    public const int XKB_KEY_Serbian_je = 0x06a8;

    [NativeTypeName("#define XKB_KEY_Cyrillic_lje 0x06a9")]
    public const int XKB_KEY_Cyrillic_lje = 0x06a9;

    [NativeTypeName("#define XKB_KEY_Serbian_lje 0x06a9")]
    public const int XKB_KEY_Serbian_lje = 0x06a9;

    [NativeTypeName("#define XKB_KEY_Cyrillic_nje 0x06aa")]
    public const int XKB_KEY_Cyrillic_nje = 0x06aa;

    [NativeTypeName("#define XKB_KEY_Serbian_nje 0x06aa")]
    public const int XKB_KEY_Serbian_nje = 0x06aa;

    [NativeTypeName("#define XKB_KEY_Serbian_tshe 0x06ab")]
    public const int XKB_KEY_Serbian_tshe = 0x06ab;

    [NativeTypeName("#define XKB_KEY_Macedonia_kje 0x06ac")]
    public const int XKB_KEY_Macedonia_kje = 0x06ac;

    [NativeTypeName("#define XKB_KEY_Ukrainian_ghe_with_upturn 0x06ad")]
    public const int XKB_KEY_Ukrainian_ghe_with_upturn = 0x06ad;

    [NativeTypeName("#define XKB_KEY_Byelorussian_shortu 0x06ae")]
    public const int XKB_KEY_Byelorussian_shortu = 0x06ae;

    [NativeTypeName("#define XKB_KEY_Cyrillic_dzhe 0x06af")]
    public const int XKB_KEY_Cyrillic_dzhe = 0x06af;

    [NativeTypeName("#define XKB_KEY_Serbian_dze 0x06af")]
    public const int XKB_KEY_Serbian_dze = 0x06af;

    [NativeTypeName("#define XKB_KEY_numerosign 0x06b0")]
    public const int XKB_KEY_numerosign = 0x06b0;

    [NativeTypeName("#define XKB_KEY_Serbian_DJE 0x06b1")]
    public const int XKB_KEY_Serbian_DJE = 0x06b1;

    [NativeTypeName("#define XKB_KEY_Macedonia_GJE 0x06b2")]
    public const int XKB_KEY_Macedonia_GJE = 0x06b2;

    [NativeTypeName("#define XKB_KEY_Cyrillic_IO 0x06b3")]
    public const int XKB_KEY_Cyrillic_IO = 0x06b3;

    [NativeTypeName("#define XKB_KEY_Ukrainian_IE 0x06b4")]
    public const int XKB_KEY_Ukrainian_IE = 0x06b4;

    [NativeTypeName("#define XKB_KEY_Ukranian_JE 0x06b4")]
    public const int XKB_KEY_Ukranian_JE = 0x06b4;

    [NativeTypeName("#define XKB_KEY_Macedonia_DSE 0x06b5")]
    public const int XKB_KEY_Macedonia_DSE = 0x06b5;

    [NativeTypeName("#define XKB_KEY_Ukrainian_I 0x06b6")]
    public const int XKB_KEY_Ukrainian_I = 0x06b6;

    [NativeTypeName("#define XKB_KEY_Ukranian_I 0x06b6")]
    public const int XKB_KEY_Ukranian_I = 0x06b6;

    [NativeTypeName("#define XKB_KEY_Ukrainian_YI 0x06b7")]
    public const int XKB_KEY_Ukrainian_YI = 0x06b7;

    [NativeTypeName("#define XKB_KEY_Ukranian_YI 0x06b7")]
    public const int XKB_KEY_Ukranian_YI = 0x06b7;

    [NativeTypeName("#define XKB_KEY_Cyrillic_JE 0x06b8")]
    public const int XKB_KEY_Cyrillic_JE = 0x06b8;

    [NativeTypeName("#define XKB_KEY_Serbian_JE 0x06b8")]
    public const int XKB_KEY_Serbian_JE = 0x06b8;

    [NativeTypeName("#define XKB_KEY_Cyrillic_LJE 0x06b9")]
    public const int XKB_KEY_Cyrillic_LJE = 0x06b9;

    [NativeTypeName("#define XKB_KEY_Serbian_LJE 0x06b9")]
    public const int XKB_KEY_Serbian_LJE = 0x06b9;

    [NativeTypeName("#define XKB_KEY_Cyrillic_NJE 0x06ba")]
    public const int XKB_KEY_Cyrillic_NJE = 0x06ba;

    [NativeTypeName("#define XKB_KEY_Serbian_NJE 0x06ba")]
    public const int XKB_KEY_Serbian_NJE = 0x06ba;

    [NativeTypeName("#define XKB_KEY_Serbian_TSHE 0x06bb")]
    public const int XKB_KEY_Serbian_TSHE = 0x06bb;

    [NativeTypeName("#define XKB_KEY_Macedonia_KJE 0x06bc")]
    public const int XKB_KEY_Macedonia_KJE = 0x06bc;

    [NativeTypeName("#define XKB_KEY_Ukrainian_GHE_WITH_UPTURN 0x06bd")]
    public const int XKB_KEY_Ukrainian_GHE_WITH_UPTURN = 0x06bd;

    [NativeTypeName("#define XKB_KEY_Byelorussian_SHORTU 0x06be")]
    public const int XKB_KEY_Byelorussian_SHORTU = 0x06be;

    [NativeTypeName("#define XKB_KEY_Cyrillic_DZHE 0x06bf")]
    public const int XKB_KEY_Cyrillic_DZHE = 0x06bf;

    [NativeTypeName("#define XKB_KEY_Serbian_DZE 0x06bf")]
    public const int XKB_KEY_Serbian_DZE = 0x06bf;

    [NativeTypeName("#define XKB_KEY_Cyrillic_yu 0x06c0")]
    public const int XKB_KEY_Cyrillic_yu = 0x06c0;

    [NativeTypeName("#define XKB_KEY_Cyrillic_a 0x06c1")]
    public const int XKB_KEY_Cyrillic_a = 0x06c1;

    [NativeTypeName("#define XKB_KEY_Cyrillic_be 0x06c2")]
    public const int XKB_KEY_Cyrillic_be = 0x06c2;

    [NativeTypeName("#define XKB_KEY_Cyrillic_tse 0x06c3")]
    public const int XKB_KEY_Cyrillic_tse = 0x06c3;

    [NativeTypeName("#define XKB_KEY_Cyrillic_de 0x06c4")]
    public const int XKB_KEY_Cyrillic_de = 0x06c4;

    [NativeTypeName("#define XKB_KEY_Cyrillic_ie 0x06c5")]
    public const int XKB_KEY_Cyrillic_ie = 0x06c5;

    [NativeTypeName("#define XKB_KEY_Cyrillic_ef 0x06c6")]
    public const int XKB_KEY_Cyrillic_ef = 0x06c6;

    [NativeTypeName("#define XKB_KEY_Cyrillic_ghe 0x06c7")]
    public const int XKB_KEY_Cyrillic_ghe = 0x06c7;

    [NativeTypeName("#define XKB_KEY_Cyrillic_ha 0x06c8")]
    public const int XKB_KEY_Cyrillic_ha = 0x06c8;

    [NativeTypeName("#define XKB_KEY_Cyrillic_i 0x06c9")]
    public const int XKB_KEY_Cyrillic_i = 0x06c9;

    [NativeTypeName("#define XKB_KEY_Cyrillic_shorti 0x06ca")]
    public const int XKB_KEY_Cyrillic_shorti = 0x06ca;

    [NativeTypeName("#define XKB_KEY_Cyrillic_ka 0x06cb")]
    public const int XKB_KEY_Cyrillic_ka = 0x06cb;

    [NativeTypeName("#define XKB_KEY_Cyrillic_el 0x06cc")]
    public const int XKB_KEY_Cyrillic_el = 0x06cc;

    [NativeTypeName("#define XKB_KEY_Cyrillic_em 0x06cd")]
    public const int XKB_KEY_Cyrillic_em = 0x06cd;

    [NativeTypeName("#define XKB_KEY_Cyrillic_en 0x06ce")]
    public const int XKB_KEY_Cyrillic_en = 0x06ce;

    [NativeTypeName("#define XKB_KEY_Cyrillic_o 0x06cf")]
    public const int XKB_KEY_Cyrillic_o = 0x06cf;

    [NativeTypeName("#define XKB_KEY_Cyrillic_pe 0x06d0")]
    public const int XKB_KEY_Cyrillic_pe = 0x06d0;

    [NativeTypeName("#define XKB_KEY_Cyrillic_ya 0x06d1")]
    public const int XKB_KEY_Cyrillic_ya = 0x06d1;

    [NativeTypeName("#define XKB_KEY_Cyrillic_er 0x06d2")]
    public const int XKB_KEY_Cyrillic_er = 0x06d2;

    [NativeTypeName("#define XKB_KEY_Cyrillic_es 0x06d3")]
    public const int XKB_KEY_Cyrillic_es = 0x06d3;

    [NativeTypeName("#define XKB_KEY_Cyrillic_te 0x06d4")]
    public const int XKB_KEY_Cyrillic_te = 0x06d4;

    [NativeTypeName("#define XKB_KEY_Cyrillic_u 0x06d5")]
    public const int XKB_KEY_Cyrillic_u = 0x06d5;

    [NativeTypeName("#define XKB_KEY_Cyrillic_zhe 0x06d6")]
    public const int XKB_KEY_Cyrillic_zhe = 0x06d6;

    [NativeTypeName("#define XKB_KEY_Cyrillic_ve 0x06d7")]
    public const int XKB_KEY_Cyrillic_ve = 0x06d7;

    [NativeTypeName("#define XKB_KEY_Cyrillic_softsign 0x06d8")]
    public const int XKB_KEY_Cyrillic_softsign = 0x06d8;

    [NativeTypeName("#define XKB_KEY_Cyrillic_yeru 0x06d9")]
    public const int XKB_KEY_Cyrillic_yeru = 0x06d9;

    [NativeTypeName("#define XKB_KEY_Cyrillic_ze 0x06da")]
    public const int XKB_KEY_Cyrillic_ze = 0x06da;

    [NativeTypeName("#define XKB_KEY_Cyrillic_sha 0x06db")]
    public const int XKB_KEY_Cyrillic_sha = 0x06db;

    [NativeTypeName("#define XKB_KEY_Cyrillic_e 0x06dc")]
    public const int XKB_KEY_Cyrillic_e = 0x06dc;

    [NativeTypeName("#define XKB_KEY_Cyrillic_shcha 0x06dd")]
    public const int XKB_KEY_Cyrillic_shcha = 0x06dd;

    [NativeTypeName("#define XKB_KEY_Cyrillic_che 0x06de")]
    public const int XKB_KEY_Cyrillic_che = 0x06de;

    [NativeTypeName("#define XKB_KEY_Cyrillic_hardsign 0x06df")]
    public const int XKB_KEY_Cyrillic_hardsign = 0x06df;

    [NativeTypeName("#define XKB_KEY_Cyrillic_YU 0x06e0")]
    public const int XKB_KEY_Cyrillic_YU = 0x06e0;

    [NativeTypeName("#define XKB_KEY_Cyrillic_A 0x06e1")]
    public const int XKB_KEY_Cyrillic_A = 0x06e1;

    [NativeTypeName("#define XKB_KEY_Cyrillic_BE 0x06e2")]
    public const int XKB_KEY_Cyrillic_BE = 0x06e2;

    [NativeTypeName("#define XKB_KEY_Cyrillic_TSE 0x06e3")]
    public const int XKB_KEY_Cyrillic_TSE = 0x06e3;

    [NativeTypeName("#define XKB_KEY_Cyrillic_DE 0x06e4")]
    public const int XKB_KEY_Cyrillic_DE = 0x06e4;

    [NativeTypeName("#define XKB_KEY_Cyrillic_IE 0x06e5")]
    public const int XKB_KEY_Cyrillic_IE = 0x06e5;

    [NativeTypeName("#define XKB_KEY_Cyrillic_EF 0x06e6")]
    public const int XKB_KEY_Cyrillic_EF = 0x06e6;

    [NativeTypeName("#define XKB_KEY_Cyrillic_GHE 0x06e7")]
    public const int XKB_KEY_Cyrillic_GHE = 0x06e7;

    [NativeTypeName("#define XKB_KEY_Cyrillic_HA 0x06e8")]
    public const int XKB_KEY_Cyrillic_HA = 0x06e8;

    [NativeTypeName("#define XKB_KEY_Cyrillic_I 0x06e9")]
    public const int XKB_KEY_Cyrillic_I = 0x06e9;

    [NativeTypeName("#define XKB_KEY_Cyrillic_SHORTI 0x06ea")]
    public const int XKB_KEY_Cyrillic_SHORTI = 0x06ea;

    [NativeTypeName("#define XKB_KEY_Cyrillic_KA 0x06eb")]
    public const int XKB_KEY_Cyrillic_KA = 0x06eb;

    [NativeTypeName("#define XKB_KEY_Cyrillic_EL 0x06ec")]
    public const int XKB_KEY_Cyrillic_EL = 0x06ec;

    [NativeTypeName("#define XKB_KEY_Cyrillic_EM 0x06ed")]
    public const int XKB_KEY_Cyrillic_EM = 0x06ed;

    [NativeTypeName("#define XKB_KEY_Cyrillic_EN 0x06ee")]
    public const int XKB_KEY_Cyrillic_EN = 0x06ee;

    [NativeTypeName("#define XKB_KEY_Cyrillic_O 0x06ef")]
    public const int XKB_KEY_Cyrillic_O = 0x06ef;

    [NativeTypeName("#define XKB_KEY_Cyrillic_PE 0x06f0")]
    public const int XKB_KEY_Cyrillic_PE = 0x06f0;

    [NativeTypeName("#define XKB_KEY_Cyrillic_YA 0x06f1")]
    public const int XKB_KEY_Cyrillic_YA = 0x06f1;

    [NativeTypeName("#define XKB_KEY_Cyrillic_ER 0x06f2")]
    public const int XKB_KEY_Cyrillic_ER = 0x06f2;

    [NativeTypeName("#define XKB_KEY_Cyrillic_ES 0x06f3")]
    public const int XKB_KEY_Cyrillic_ES = 0x06f3;

    [NativeTypeName("#define XKB_KEY_Cyrillic_TE 0x06f4")]
    public const int XKB_KEY_Cyrillic_TE = 0x06f4;

    [NativeTypeName("#define XKB_KEY_Cyrillic_U 0x06f5")]
    public const int XKB_KEY_Cyrillic_U = 0x06f5;

    [NativeTypeName("#define XKB_KEY_Cyrillic_ZHE 0x06f6")]
    public const int XKB_KEY_Cyrillic_ZHE = 0x06f6;

    [NativeTypeName("#define XKB_KEY_Cyrillic_VE 0x06f7")]
    public const int XKB_KEY_Cyrillic_VE = 0x06f7;

    [NativeTypeName("#define XKB_KEY_Cyrillic_SOFTSIGN 0x06f8")]
    public const int XKB_KEY_Cyrillic_SOFTSIGN = 0x06f8;

    [NativeTypeName("#define XKB_KEY_Cyrillic_YERU 0x06f9")]
    public const int XKB_KEY_Cyrillic_YERU = 0x06f9;

    [NativeTypeName("#define XKB_KEY_Cyrillic_ZE 0x06fa")]
    public const int XKB_KEY_Cyrillic_ZE = 0x06fa;

    [NativeTypeName("#define XKB_KEY_Cyrillic_SHA 0x06fb")]
    public const int XKB_KEY_Cyrillic_SHA = 0x06fb;

    [NativeTypeName("#define XKB_KEY_Cyrillic_E 0x06fc")]
    public const int XKB_KEY_Cyrillic_E = 0x06fc;

    [NativeTypeName("#define XKB_KEY_Cyrillic_SHCHA 0x06fd")]
    public const int XKB_KEY_Cyrillic_SHCHA = 0x06fd;

    [NativeTypeName("#define XKB_KEY_Cyrillic_CHE 0x06fe")]
    public const int XKB_KEY_Cyrillic_CHE = 0x06fe;

    [NativeTypeName("#define XKB_KEY_Cyrillic_HARDSIGN 0x06ff")]
    public const int XKB_KEY_Cyrillic_HARDSIGN = 0x06ff;

    [NativeTypeName("#define XKB_KEY_Greek_ALPHAaccent 0x07a1")]
    public const int XKB_KEY_Greek_ALPHAaccent = 0x07a1;

    [NativeTypeName("#define XKB_KEY_Greek_EPSILONaccent 0x07a2")]
    public const int XKB_KEY_Greek_EPSILONaccent = 0x07a2;

    [NativeTypeName("#define XKB_KEY_Greek_ETAaccent 0x07a3")]
    public const int XKB_KEY_Greek_ETAaccent = 0x07a3;

    [NativeTypeName("#define XKB_KEY_Greek_IOTAaccent 0x07a4")]
    public const int XKB_KEY_Greek_IOTAaccent = 0x07a4;

    [NativeTypeName("#define XKB_KEY_Greek_IOTAdieresis 0x07a5")]
    public const int XKB_KEY_Greek_IOTAdieresis = 0x07a5;

    [NativeTypeName("#define XKB_KEY_Greek_IOTAdiaeresis 0x07a5")]
    public const int XKB_KEY_Greek_IOTAdiaeresis = 0x07a5;

    [NativeTypeName("#define XKB_KEY_Greek_OMICRONaccent 0x07a7")]
    public const int XKB_KEY_Greek_OMICRONaccent = 0x07a7;

    [NativeTypeName("#define XKB_KEY_Greek_UPSILONaccent 0x07a8")]
    public const int XKB_KEY_Greek_UPSILONaccent = 0x07a8;

    [NativeTypeName("#define XKB_KEY_Greek_UPSILONdieresis 0x07a9")]
    public const int XKB_KEY_Greek_UPSILONdieresis = 0x07a9;

    [NativeTypeName("#define XKB_KEY_Greek_OMEGAaccent 0x07ab")]
    public const int XKB_KEY_Greek_OMEGAaccent = 0x07ab;

    [NativeTypeName("#define XKB_KEY_Greek_accentdieresis 0x07ae")]
    public const int XKB_KEY_Greek_accentdieresis = 0x07ae;

    [NativeTypeName("#define XKB_KEY_Greek_horizbar 0x07af")]
    public const int XKB_KEY_Greek_horizbar = 0x07af;

    [NativeTypeName("#define XKB_KEY_Greek_alphaaccent 0x07b1")]
    public const int XKB_KEY_Greek_alphaaccent = 0x07b1;

    [NativeTypeName("#define XKB_KEY_Greek_epsilonaccent 0x07b2")]
    public const int XKB_KEY_Greek_epsilonaccent = 0x07b2;

    [NativeTypeName("#define XKB_KEY_Greek_etaaccent 0x07b3")]
    public const int XKB_KEY_Greek_etaaccent = 0x07b3;

    [NativeTypeName("#define XKB_KEY_Greek_iotaaccent 0x07b4")]
    public const int XKB_KEY_Greek_iotaaccent = 0x07b4;

    [NativeTypeName("#define XKB_KEY_Greek_iotadieresis 0x07b5")]
    public const int XKB_KEY_Greek_iotadieresis = 0x07b5;

    [NativeTypeName("#define XKB_KEY_Greek_iotaaccentdieresis 0x07b6")]
    public const int XKB_KEY_Greek_iotaaccentdieresis = 0x07b6;

    [NativeTypeName("#define XKB_KEY_Greek_omicronaccent 0x07b7")]
    public const int XKB_KEY_Greek_omicronaccent = 0x07b7;

    [NativeTypeName("#define XKB_KEY_Greek_upsilonaccent 0x07b8")]
    public const int XKB_KEY_Greek_upsilonaccent = 0x07b8;

    [NativeTypeName("#define XKB_KEY_Greek_upsilondieresis 0x07b9")]
    public const int XKB_KEY_Greek_upsilondieresis = 0x07b9;

    [NativeTypeName("#define XKB_KEY_Greek_upsilonaccentdieresis 0x07ba")]
    public const int XKB_KEY_Greek_upsilonaccentdieresis = 0x07ba;

    [NativeTypeName("#define XKB_KEY_Greek_omegaaccent 0x07bb")]
    public const int XKB_KEY_Greek_omegaaccent = 0x07bb;

    [NativeTypeName("#define XKB_KEY_Greek_ALPHA 0x07c1")]
    public const int XKB_KEY_Greek_ALPHA = 0x07c1;

    [NativeTypeName("#define XKB_KEY_Greek_BETA 0x07c2")]
    public const int XKB_KEY_Greek_BETA = 0x07c2;

    [NativeTypeName("#define XKB_KEY_Greek_GAMMA 0x07c3")]
    public const int XKB_KEY_Greek_GAMMA = 0x07c3;

    [NativeTypeName("#define XKB_KEY_Greek_DELTA 0x07c4")]
    public const int XKB_KEY_Greek_DELTA = 0x07c4;

    [NativeTypeName("#define XKB_KEY_Greek_EPSILON 0x07c5")]
    public const int XKB_KEY_Greek_EPSILON = 0x07c5;

    [NativeTypeName("#define XKB_KEY_Greek_ZETA 0x07c6")]
    public const int XKB_KEY_Greek_ZETA = 0x07c6;

    [NativeTypeName("#define XKB_KEY_Greek_ETA 0x07c7")]
    public const int XKB_KEY_Greek_ETA = 0x07c7;

    [NativeTypeName("#define XKB_KEY_Greek_THETA 0x07c8")]
    public const int XKB_KEY_Greek_THETA = 0x07c8;

    [NativeTypeName("#define XKB_KEY_Greek_IOTA 0x07c9")]
    public const int XKB_KEY_Greek_IOTA = 0x07c9;

    [NativeTypeName("#define XKB_KEY_Greek_KAPPA 0x07ca")]
    public const int XKB_KEY_Greek_KAPPA = 0x07ca;

    [NativeTypeName("#define XKB_KEY_Greek_LAMDA 0x07cb")]
    public const int XKB_KEY_Greek_LAMDA = 0x07cb;

    [NativeTypeName("#define XKB_KEY_Greek_LAMBDA 0x07cb")]
    public const int XKB_KEY_Greek_LAMBDA = 0x07cb;

    [NativeTypeName("#define XKB_KEY_Greek_MU 0x07cc")]
    public const int XKB_KEY_Greek_MU = 0x07cc;

    [NativeTypeName("#define XKB_KEY_Greek_NU 0x07cd")]
    public const int XKB_KEY_Greek_NU = 0x07cd;

    [NativeTypeName("#define XKB_KEY_Greek_XI 0x07ce")]
    public const int XKB_KEY_Greek_XI = 0x07ce;

    [NativeTypeName("#define XKB_KEY_Greek_OMICRON 0x07cf")]
    public const int XKB_KEY_Greek_OMICRON = 0x07cf;

    [NativeTypeName("#define XKB_KEY_Greek_PI 0x07d0")]
    public const int XKB_KEY_Greek_PI = 0x07d0;

    [NativeTypeName("#define XKB_KEY_Greek_RHO 0x07d1")]
    public const int XKB_KEY_Greek_RHO = 0x07d1;

    [NativeTypeName("#define XKB_KEY_Greek_SIGMA 0x07d2")]
    public const int XKB_KEY_Greek_SIGMA = 0x07d2;

    [NativeTypeName("#define XKB_KEY_Greek_TAU 0x07d4")]
    public const int XKB_KEY_Greek_TAU = 0x07d4;

    [NativeTypeName("#define XKB_KEY_Greek_UPSILON 0x07d5")]
    public const int XKB_KEY_Greek_UPSILON = 0x07d5;

    [NativeTypeName("#define XKB_KEY_Greek_PHI 0x07d6")]
    public const int XKB_KEY_Greek_PHI = 0x07d6;

    [NativeTypeName("#define XKB_KEY_Greek_CHI 0x07d7")]
    public const int XKB_KEY_Greek_CHI = 0x07d7;

    [NativeTypeName("#define XKB_KEY_Greek_PSI 0x07d8")]
    public const int XKB_KEY_Greek_PSI = 0x07d8;

    [NativeTypeName("#define XKB_KEY_Greek_OMEGA 0x07d9")]
    public const int XKB_KEY_Greek_OMEGA = 0x07d9;

    [NativeTypeName("#define XKB_KEY_Greek_alpha 0x07e1")]
    public const int XKB_KEY_Greek_alpha = 0x07e1;

    [NativeTypeName("#define XKB_KEY_Greek_beta 0x07e2")]
    public const int XKB_KEY_Greek_beta = 0x07e2;

    [NativeTypeName("#define XKB_KEY_Greek_gamma 0x07e3")]
    public const int XKB_KEY_Greek_gamma = 0x07e3;

    [NativeTypeName("#define XKB_KEY_Greek_delta 0x07e4")]
    public const int XKB_KEY_Greek_delta = 0x07e4;

    [NativeTypeName("#define XKB_KEY_Greek_epsilon 0x07e5")]
    public const int XKB_KEY_Greek_epsilon = 0x07e5;

    [NativeTypeName("#define XKB_KEY_Greek_zeta 0x07e6")]
    public const int XKB_KEY_Greek_zeta = 0x07e6;

    [NativeTypeName("#define XKB_KEY_Greek_eta 0x07e7")]
    public const int XKB_KEY_Greek_eta = 0x07e7;

    [NativeTypeName("#define XKB_KEY_Greek_theta 0x07e8")]
    public const int XKB_KEY_Greek_theta = 0x07e8;

    [NativeTypeName("#define XKB_KEY_Greek_iota 0x07e9")]
    public const int XKB_KEY_Greek_iota = 0x07e9;

    [NativeTypeName("#define XKB_KEY_Greek_kappa 0x07ea")]
    public const int XKB_KEY_Greek_kappa = 0x07ea;

    [NativeTypeName("#define XKB_KEY_Greek_lamda 0x07eb")]
    public const int XKB_KEY_Greek_lamda = 0x07eb;

    [NativeTypeName("#define XKB_KEY_Greek_lambda 0x07eb")]
    public const int XKB_KEY_Greek_lambda = 0x07eb;

    [NativeTypeName("#define XKB_KEY_Greek_mu 0x07ec")]
    public const int XKB_KEY_Greek_mu = 0x07ec;

    [NativeTypeName("#define XKB_KEY_Greek_nu 0x07ed")]
    public const int XKB_KEY_Greek_nu = 0x07ed;

    [NativeTypeName("#define XKB_KEY_Greek_xi 0x07ee")]
    public const int XKB_KEY_Greek_xi = 0x07ee;

    [NativeTypeName("#define XKB_KEY_Greek_omicron 0x07ef")]
    public const int XKB_KEY_Greek_omicron = 0x07ef;

    [NativeTypeName("#define XKB_KEY_Greek_pi 0x07f0")]
    public const int XKB_KEY_Greek_pi = 0x07f0;

    [NativeTypeName("#define XKB_KEY_Greek_rho 0x07f1")]
    public const int XKB_KEY_Greek_rho = 0x07f1;

    [NativeTypeName("#define XKB_KEY_Greek_sigma 0x07f2")]
    public const int XKB_KEY_Greek_sigma = 0x07f2;

    [NativeTypeName("#define XKB_KEY_Greek_finalsmallsigma 0x07f3")]
    public const int XKB_KEY_Greek_finalsmallsigma = 0x07f3;

    [NativeTypeName("#define XKB_KEY_Greek_tau 0x07f4")]
    public const int XKB_KEY_Greek_tau = 0x07f4;

    [NativeTypeName("#define XKB_KEY_Greek_upsilon 0x07f5")]
    public const int XKB_KEY_Greek_upsilon = 0x07f5;

    [NativeTypeName("#define XKB_KEY_Greek_phi 0x07f6")]
    public const int XKB_KEY_Greek_phi = 0x07f6;

    [NativeTypeName("#define XKB_KEY_Greek_chi 0x07f7")]
    public const int XKB_KEY_Greek_chi = 0x07f7;

    [NativeTypeName("#define XKB_KEY_Greek_psi 0x07f8")]
    public const int XKB_KEY_Greek_psi = 0x07f8;

    [NativeTypeName("#define XKB_KEY_Greek_omega 0x07f9")]
    public const int XKB_KEY_Greek_omega = 0x07f9;

    [NativeTypeName("#define XKB_KEY_Greek_switch 0xff7e")]
    public const int XKB_KEY_Greek_switch = 0xff7e;

    [NativeTypeName("#define XKB_KEY_leftradical 0x08a1")]
    public const int XKB_KEY_leftradical = 0x08a1;

    [NativeTypeName("#define XKB_KEY_topleftradical 0x08a2")]
    public const int XKB_KEY_topleftradical = 0x08a2;

    [NativeTypeName("#define XKB_KEY_horizconnector 0x08a3")]
    public const int XKB_KEY_horizconnector = 0x08a3;

    [NativeTypeName("#define XKB_KEY_topintegral 0x08a4")]
    public const int XKB_KEY_topintegral = 0x08a4;

    [NativeTypeName("#define XKB_KEY_botintegral 0x08a5")]
    public const int XKB_KEY_botintegral = 0x08a5;

    [NativeTypeName("#define XKB_KEY_vertconnector 0x08a6")]
    public const int XKB_KEY_vertconnector = 0x08a6;

    [NativeTypeName("#define XKB_KEY_topleftsqbracket 0x08a7")]
    public const int XKB_KEY_topleftsqbracket = 0x08a7;

    [NativeTypeName("#define XKB_KEY_botleftsqbracket 0x08a8")]
    public const int XKB_KEY_botleftsqbracket = 0x08a8;

    [NativeTypeName("#define XKB_KEY_toprightsqbracket 0x08a9")]
    public const int XKB_KEY_toprightsqbracket = 0x08a9;

    [NativeTypeName("#define XKB_KEY_botrightsqbracket 0x08aa")]
    public const int XKB_KEY_botrightsqbracket = 0x08aa;

    [NativeTypeName("#define XKB_KEY_topleftparens 0x08ab")]
    public const int XKB_KEY_topleftparens = 0x08ab;

    [NativeTypeName("#define XKB_KEY_botleftparens 0x08ac")]
    public const int XKB_KEY_botleftparens = 0x08ac;

    [NativeTypeName("#define XKB_KEY_toprightparens 0x08ad")]
    public const int XKB_KEY_toprightparens = 0x08ad;

    [NativeTypeName("#define XKB_KEY_botrightparens 0x08ae")]
    public const int XKB_KEY_botrightparens = 0x08ae;

    [NativeTypeName("#define XKB_KEY_leftmiddlecurlybrace 0x08af")]
    public const int XKB_KEY_leftmiddlecurlybrace = 0x08af;

    [NativeTypeName("#define XKB_KEY_rightmiddlecurlybrace 0x08b0")]
    public const int XKB_KEY_rightmiddlecurlybrace = 0x08b0;

    [NativeTypeName("#define XKB_KEY_topleftsummation 0x08b1")]
    public const int XKB_KEY_topleftsummation = 0x08b1;

    [NativeTypeName("#define XKB_KEY_botleftsummation 0x08b2")]
    public const int XKB_KEY_botleftsummation = 0x08b2;

    [NativeTypeName("#define XKB_KEY_topvertsummationconnector 0x08b3")]
    public const int XKB_KEY_topvertsummationconnector = 0x08b3;

    [NativeTypeName("#define XKB_KEY_botvertsummationconnector 0x08b4")]
    public const int XKB_KEY_botvertsummationconnector = 0x08b4;

    [NativeTypeName("#define XKB_KEY_toprightsummation 0x08b5")]
    public const int XKB_KEY_toprightsummation = 0x08b5;

    [NativeTypeName("#define XKB_KEY_botrightsummation 0x08b6")]
    public const int XKB_KEY_botrightsummation = 0x08b6;

    [NativeTypeName("#define XKB_KEY_rightmiddlesummation 0x08b7")]
    public const int XKB_KEY_rightmiddlesummation = 0x08b7;

    [NativeTypeName("#define XKB_KEY_lessthanequal 0x08bc")]
    public const int XKB_KEY_lessthanequal = 0x08bc;

    [NativeTypeName("#define XKB_KEY_notequal 0x08bd")]
    public const int XKB_KEY_notequal = 0x08bd;

    [NativeTypeName("#define XKB_KEY_greaterthanequal 0x08be")]
    public const int XKB_KEY_greaterthanequal = 0x08be;

    [NativeTypeName("#define XKB_KEY_integral 0x08bf")]
    public const int XKB_KEY_integral = 0x08bf;

    [NativeTypeName("#define XKB_KEY_therefore 0x08c0")]
    public const int XKB_KEY_therefore = 0x08c0;

    [NativeTypeName("#define XKB_KEY_variation 0x08c1")]
    public const int XKB_KEY_variation = 0x08c1;

    [NativeTypeName("#define XKB_KEY_infinity 0x08c2")]
    public const int XKB_KEY_infinity = 0x08c2;

    [NativeTypeName("#define XKB_KEY_nabla 0x08c5")]
    public const int XKB_KEY_nabla = 0x08c5;

    [NativeTypeName("#define XKB_KEY_approximate 0x08c8")]
    public const int XKB_KEY_approximate = 0x08c8;

    [NativeTypeName("#define XKB_KEY_similarequal 0x08c9")]
    public const int XKB_KEY_similarequal = 0x08c9;

    [NativeTypeName("#define XKB_KEY_ifonlyif 0x08cd")]
    public const int XKB_KEY_ifonlyif = 0x08cd;

    [NativeTypeName("#define XKB_KEY_implies 0x08ce")]
    public const int XKB_KEY_implies = 0x08ce;

    [NativeTypeName("#define XKB_KEY_identical 0x08cf")]
    public const int XKB_KEY_identical = 0x08cf;

    [NativeTypeName("#define XKB_KEY_radical 0x08d6")]
    public const int XKB_KEY_radical = 0x08d6;

    [NativeTypeName("#define XKB_KEY_includedin 0x08da")]
    public const int XKB_KEY_includedin = 0x08da;

    [NativeTypeName("#define XKB_KEY_includes 0x08db")]
    public const int XKB_KEY_includes = 0x08db;

    [NativeTypeName("#define XKB_KEY_intersection 0x08dc")]
    public const int XKB_KEY_intersection = 0x08dc;

    [NativeTypeName("#define XKB_KEY_union 0x08dd")]
    public const int XKB_KEY_union = 0x08dd;

    [NativeTypeName("#define XKB_KEY_logicaland 0x08de")]
    public const int XKB_KEY_logicaland = 0x08de;

    [NativeTypeName("#define XKB_KEY_logicalor 0x08df")]
    public const int XKB_KEY_logicalor = 0x08df;

    [NativeTypeName("#define XKB_KEY_partialderivative 0x08ef")]
    public const int XKB_KEY_partialderivative = 0x08ef;

    [NativeTypeName("#define XKB_KEY_function 0x08f6")]
    public const int XKB_KEY_function = 0x08f6;

    [NativeTypeName("#define XKB_KEY_leftarrow 0x08fb")]
    public const int XKB_KEY_leftarrow = 0x08fb;

    [NativeTypeName("#define XKB_KEY_uparrow 0x08fc")]
    public const int XKB_KEY_uparrow = 0x08fc;

    [NativeTypeName("#define XKB_KEY_rightarrow 0x08fd")]
    public const int XKB_KEY_rightarrow = 0x08fd;

    [NativeTypeName("#define XKB_KEY_downarrow 0x08fe")]
    public const int XKB_KEY_downarrow = 0x08fe;

    [NativeTypeName("#define XKB_KEY_blank 0x09df")]
    public const int XKB_KEY_blank = 0x09df;

    [NativeTypeName("#define XKB_KEY_soliddiamond 0x09e0")]
    public const int XKB_KEY_soliddiamond = 0x09e0;

    [NativeTypeName("#define XKB_KEY_checkerboard 0x09e1")]
    public const int XKB_KEY_checkerboard = 0x09e1;

    [NativeTypeName("#define XKB_KEY_ht 0x09e2")]
    public const int XKB_KEY_ht = 0x09e2;

    [NativeTypeName("#define XKB_KEY_ff 0x09e3")]
    public const int XKB_KEY_ff = 0x09e3;

    [NativeTypeName("#define XKB_KEY_cr 0x09e4")]
    public const int XKB_KEY_cr = 0x09e4;

    [NativeTypeName("#define XKB_KEY_lf 0x09e5")]
    public const int XKB_KEY_lf = 0x09e5;

    [NativeTypeName("#define XKB_KEY_nl 0x09e8")]
    public const int XKB_KEY_nl = 0x09e8;

    [NativeTypeName("#define XKB_KEY_vt 0x09e9")]
    public const int XKB_KEY_vt = 0x09e9;

    [NativeTypeName("#define XKB_KEY_lowrightcorner 0x09ea")]
    public const int XKB_KEY_lowrightcorner = 0x09ea;

    [NativeTypeName("#define XKB_KEY_uprightcorner 0x09eb")]
    public const int XKB_KEY_uprightcorner = 0x09eb;

    [NativeTypeName("#define XKB_KEY_upleftcorner 0x09ec")]
    public const int XKB_KEY_upleftcorner = 0x09ec;

    [NativeTypeName("#define XKB_KEY_lowleftcorner 0x09ed")]
    public const int XKB_KEY_lowleftcorner = 0x09ed;

    [NativeTypeName("#define XKB_KEY_crossinglines 0x09ee")]
    public const int XKB_KEY_crossinglines = 0x09ee;

    [NativeTypeName("#define XKB_KEY_horizlinescan1 0x09ef")]
    public const int XKB_KEY_horizlinescan1 = 0x09ef;

    [NativeTypeName("#define XKB_KEY_horizlinescan3 0x09f0")]
    public const int XKB_KEY_horizlinescan3 = 0x09f0;

    [NativeTypeName("#define XKB_KEY_horizlinescan5 0x09f1")]
    public const int XKB_KEY_horizlinescan5 = 0x09f1;

    [NativeTypeName("#define XKB_KEY_horizlinescan7 0x09f2")]
    public const int XKB_KEY_horizlinescan7 = 0x09f2;

    [NativeTypeName("#define XKB_KEY_horizlinescan9 0x09f3")]
    public const int XKB_KEY_horizlinescan9 = 0x09f3;

    [NativeTypeName("#define XKB_KEY_leftt 0x09f4")]
    public const int XKB_KEY_leftt = 0x09f4;

    [NativeTypeName("#define XKB_KEY_rightt 0x09f5")]
    public const int XKB_KEY_rightt = 0x09f5;

    [NativeTypeName("#define XKB_KEY_bott 0x09f6")]
    public const int XKB_KEY_bott = 0x09f6;

    [NativeTypeName("#define XKB_KEY_topt 0x09f7")]
    public const int XKB_KEY_topt = 0x09f7;

    [NativeTypeName("#define XKB_KEY_vertbar 0x09f8")]
    public const int XKB_KEY_vertbar = 0x09f8;

    [NativeTypeName("#define XKB_KEY_emspace 0x0aa1")]
    public const int XKB_KEY_emspace = 0x0aa1;

    [NativeTypeName("#define XKB_KEY_enspace 0x0aa2")]
    public const int XKB_KEY_enspace = 0x0aa2;

    [NativeTypeName("#define XKB_KEY_em3space 0x0aa3")]
    public const int XKB_KEY_em3space = 0x0aa3;

    [NativeTypeName("#define XKB_KEY_em4space 0x0aa4")]
    public const int XKB_KEY_em4space = 0x0aa4;

    [NativeTypeName("#define XKB_KEY_digitspace 0x0aa5")]
    public const int XKB_KEY_digitspace = 0x0aa5;

    [NativeTypeName("#define XKB_KEY_punctspace 0x0aa6")]
    public const int XKB_KEY_punctspace = 0x0aa6;

    [NativeTypeName("#define XKB_KEY_thinspace 0x0aa7")]
    public const int XKB_KEY_thinspace = 0x0aa7;

    [NativeTypeName("#define XKB_KEY_hairspace 0x0aa8")]
    public const int XKB_KEY_hairspace = 0x0aa8;

    [NativeTypeName("#define XKB_KEY_emdash 0x0aa9")]
    public const int XKB_KEY_emdash = 0x0aa9;

    [NativeTypeName("#define XKB_KEY_endash 0x0aaa")]
    public const int XKB_KEY_endash = 0x0aaa;

    [NativeTypeName("#define XKB_KEY_signifblank 0x0aac")]
    public const int XKB_KEY_signifblank = 0x0aac;

    [NativeTypeName("#define XKB_KEY_ellipsis 0x0aae")]
    public const int XKB_KEY_ellipsis = 0x0aae;

    [NativeTypeName("#define XKB_KEY_doubbaselinedot 0x0aaf")]
    public const int XKB_KEY_doubbaselinedot = 0x0aaf;

    [NativeTypeName("#define XKB_KEY_onethird 0x0ab0")]
    public const int XKB_KEY_onethird = 0x0ab0;

    [NativeTypeName("#define XKB_KEY_twothirds 0x0ab1")]
    public const int XKB_KEY_twothirds = 0x0ab1;

    [NativeTypeName("#define XKB_KEY_onefifth 0x0ab2")]
    public const int XKB_KEY_onefifth = 0x0ab2;

    [NativeTypeName("#define XKB_KEY_twofifths 0x0ab3")]
    public const int XKB_KEY_twofifths = 0x0ab3;

    [NativeTypeName("#define XKB_KEY_threefifths 0x0ab4")]
    public const int XKB_KEY_threefifths = 0x0ab4;

    [NativeTypeName("#define XKB_KEY_fourfifths 0x0ab5")]
    public const int XKB_KEY_fourfifths = 0x0ab5;

    [NativeTypeName("#define XKB_KEY_onesixth 0x0ab6")]
    public const int XKB_KEY_onesixth = 0x0ab6;

    [NativeTypeName("#define XKB_KEY_fivesixths 0x0ab7")]
    public const int XKB_KEY_fivesixths = 0x0ab7;

    [NativeTypeName("#define XKB_KEY_careof 0x0ab8")]
    public const int XKB_KEY_careof = 0x0ab8;

    [NativeTypeName("#define XKB_KEY_figdash 0x0abb")]
    public const int XKB_KEY_figdash = 0x0abb;

    [NativeTypeName("#define XKB_KEY_leftanglebracket 0x0abc")]
    public const int XKB_KEY_leftanglebracket = 0x0abc;

    [NativeTypeName("#define XKB_KEY_decimalpoint 0x0abd")]
    public const int XKB_KEY_decimalpoint = 0x0abd;

    [NativeTypeName("#define XKB_KEY_rightanglebracket 0x0abe")]
    public const int XKB_KEY_rightanglebracket = 0x0abe;

    [NativeTypeName("#define XKB_KEY_marker 0x0abf")]
    public const int XKB_KEY_marker = 0x0abf;

    [NativeTypeName("#define XKB_KEY_oneeighth 0x0ac3")]
    public const int XKB_KEY_oneeighth = 0x0ac3;

    [NativeTypeName("#define XKB_KEY_threeeighths 0x0ac4")]
    public const int XKB_KEY_threeeighths = 0x0ac4;

    [NativeTypeName("#define XKB_KEY_fiveeighths 0x0ac5")]
    public const int XKB_KEY_fiveeighths = 0x0ac5;

    [NativeTypeName("#define XKB_KEY_seveneighths 0x0ac6")]
    public const int XKB_KEY_seveneighths = 0x0ac6;

    [NativeTypeName("#define XKB_KEY_trademark 0x0ac9")]
    public const int XKB_KEY_trademark = 0x0ac9;

    [NativeTypeName("#define XKB_KEY_signaturemark 0x0aca")]
    public const int XKB_KEY_signaturemark = 0x0aca;

    [NativeTypeName("#define XKB_KEY_trademarkincircle 0x0acb")]
    public const int XKB_KEY_trademarkincircle = 0x0acb;

    [NativeTypeName("#define XKB_KEY_leftopentriangle 0x0acc")]
    public const int XKB_KEY_leftopentriangle = 0x0acc;

    [NativeTypeName("#define XKB_KEY_rightopentriangle 0x0acd")]
    public const int XKB_KEY_rightopentriangle = 0x0acd;

    [NativeTypeName("#define XKB_KEY_emopencircle 0x0ace")]
    public const int XKB_KEY_emopencircle = 0x0ace;

    [NativeTypeName("#define XKB_KEY_emopenrectangle 0x0acf")]
    public const int XKB_KEY_emopenrectangle = 0x0acf;

    [NativeTypeName("#define XKB_KEY_leftsinglequotemark 0x0ad0")]
    public const int XKB_KEY_leftsinglequotemark = 0x0ad0;

    [NativeTypeName("#define XKB_KEY_rightsinglequotemark 0x0ad1")]
    public const int XKB_KEY_rightsinglequotemark = 0x0ad1;

    [NativeTypeName("#define XKB_KEY_leftdoublequotemark 0x0ad2")]
    public const int XKB_KEY_leftdoublequotemark = 0x0ad2;

    [NativeTypeName("#define XKB_KEY_rightdoublequotemark 0x0ad3")]
    public const int XKB_KEY_rightdoublequotemark = 0x0ad3;

    [NativeTypeName("#define XKB_KEY_prescription 0x0ad4")]
    public const int XKB_KEY_prescription = 0x0ad4;

    [NativeTypeName("#define XKB_KEY_permille 0x0ad5")]
    public const int XKB_KEY_permille = 0x0ad5;

    [NativeTypeName("#define XKB_KEY_minutes 0x0ad6")]
    public const int XKB_KEY_minutes = 0x0ad6;

    [NativeTypeName("#define XKB_KEY_seconds 0x0ad7")]
    public const int XKB_KEY_seconds = 0x0ad7;

    [NativeTypeName("#define XKB_KEY_latincross 0x0ad9")]
    public const int XKB_KEY_latincross = 0x0ad9;

    [NativeTypeName("#define XKB_KEY_hexagram 0x0ada")]
    public const int XKB_KEY_hexagram = 0x0ada;

    [NativeTypeName("#define XKB_KEY_filledrectbullet 0x0adb")]
    public const int XKB_KEY_filledrectbullet = 0x0adb;

    [NativeTypeName("#define XKB_KEY_filledlefttribullet 0x0adc")]
    public const int XKB_KEY_filledlefttribullet = 0x0adc;

    [NativeTypeName("#define XKB_KEY_filledrighttribullet 0x0add")]
    public const int XKB_KEY_filledrighttribullet = 0x0add;

    [NativeTypeName("#define XKB_KEY_emfilledcircle 0x0ade")]
    public const int XKB_KEY_emfilledcircle = 0x0ade;

    [NativeTypeName("#define XKB_KEY_emfilledrect 0x0adf")]
    public const int XKB_KEY_emfilledrect = 0x0adf;

    [NativeTypeName("#define XKB_KEY_enopencircbullet 0x0ae0")]
    public const int XKB_KEY_enopencircbullet = 0x0ae0;

    [NativeTypeName("#define XKB_KEY_enopensquarebullet 0x0ae1")]
    public const int XKB_KEY_enopensquarebullet = 0x0ae1;

    [NativeTypeName("#define XKB_KEY_openrectbullet 0x0ae2")]
    public const int XKB_KEY_openrectbullet = 0x0ae2;

    [NativeTypeName("#define XKB_KEY_opentribulletup 0x0ae3")]
    public const int XKB_KEY_opentribulletup = 0x0ae3;

    [NativeTypeName("#define XKB_KEY_opentribulletdown 0x0ae4")]
    public const int XKB_KEY_opentribulletdown = 0x0ae4;

    [NativeTypeName("#define XKB_KEY_openstar 0x0ae5")]
    public const int XKB_KEY_openstar = 0x0ae5;

    [NativeTypeName("#define XKB_KEY_enfilledcircbullet 0x0ae6")]
    public const int XKB_KEY_enfilledcircbullet = 0x0ae6;

    [NativeTypeName("#define XKB_KEY_enfilledsqbullet 0x0ae7")]
    public const int XKB_KEY_enfilledsqbullet = 0x0ae7;

    [NativeTypeName("#define XKB_KEY_filledtribulletup 0x0ae8")]
    public const int XKB_KEY_filledtribulletup = 0x0ae8;

    [NativeTypeName("#define XKB_KEY_filledtribulletdown 0x0ae9")]
    public const int XKB_KEY_filledtribulletdown = 0x0ae9;

    [NativeTypeName("#define XKB_KEY_leftpointer 0x0aea")]
    public const int XKB_KEY_leftpointer = 0x0aea;

    [NativeTypeName("#define XKB_KEY_rightpointer 0x0aeb")]
    public const int XKB_KEY_rightpointer = 0x0aeb;

    [NativeTypeName("#define XKB_KEY_club 0x0aec")]
    public const int XKB_KEY_club = 0x0aec;

    [NativeTypeName("#define XKB_KEY_diamond 0x0aed")]
    public const int XKB_KEY_diamond = 0x0aed;

    [NativeTypeName("#define XKB_KEY_heart 0x0aee")]
    public const int XKB_KEY_heart = 0x0aee;

    [NativeTypeName("#define XKB_KEY_maltesecross 0x0af0")]
    public const int XKB_KEY_maltesecross = 0x0af0;

    [NativeTypeName("#define XKB_KEY_dagger 0x0af1")]
    public const int XKB_KEY_dagger = 0x0af1;

    [NativeTypeName("#define XKB_KEY_doubledagger 0x0af2")]
    public const int XKB_KEY_doubledagger = 0x0af2;

    [NativeTypeName("#define XKB_KEY_checkmark 0x0af3")]
    public const int XKB_KEY_checkmark = 0x0af3;

    [NativeTypeName("#define XKB_KEY_ballotcross 0x0af4")]
    public const int XKB_KEY_ballotcross = 0x0af4;

    [NativeTypeName("#define XKB_KEY_musicalsharp 0x0af5")]
    public const int XKB_KEY_musicalsharp = 0x0af5;

    [NativeTypeName("#define XKB_KEY_musicalflat 0x0af6")]
    public const int XKB_KEY_musicalflat = 0x0af6;

    [NativeTypeName("#define XKB_KEY_malesymbol 0x0af7")]
    public const int XKB_KEY_malesymbol = 0x0af7;

    [NativeTypeName("#define XKB_KEY_femalesymbol 0x0af8")]
    public const int XKB_KEY_femalesymbol = 0x0af8;

    [NativeTypeName("#define XKB_KEY_telephone 0x0af9")]
    public const int XKB_KEY_telephone = 0x0af9;

    [NativeTypeName("#define XKB_KEY_telephonerecorder 0x0afa")]
    public const int XKB_KEY_telephonerecorder = 0x0afa;

    [NativeTypeName("#define XKB_KEY_phonographcopyright 0x0afb")]
    public const int XKB_KEY_phonographcopyright = 0x0afb;

    [NativeTypeName("#define XKB_KEY_caret 0x0afc")]
    public const int XKB_KEY_caret = 0x0afc;

    [NativeTypeName("#define XKB_KEY_singlelowquotemark 0x0afd")]
    public const int XKB_KEY_singlelowquotemark = 0x0afd;

    [NativeTypeName("#define XKB_KEY_doublelowquotemark 0x0afe")]
    public const int XKB_KEY_doublelowquotemark = 0x0afe;

    [NativeTypeName("#define XKB_KEY_cursor 0x0aff")]
    public const int XKB_KEY_cursor = 0x0aff;

    [NativeTypeName("#define XKB_KEY_leftcaret 0x0ba3")]
    public const int XKB_KEY_leftcaret = 0x0ba3;

    [NativeTypeName("#define XKB_KEY_rightcaret 0x0ba6")]
    public const int XKB_KEY_rightcaret = 0x0ba6;

    [NativeTypeName("#define XKB_KEY_downcaret 0x0ba8")]
    public const int XKB_KEY_downcaret = 0x0ba8;

    [NativeTypeName("#define XKB_KEY_upcaret 0x0ba9")]
    public const int XKB_KEY_upcaret = 0x0ba9;

    [NativeTypeName("#define XKB_KEY_overbar 0x0bc0")]
    public const int XKB_KEY_overbar = 0x0bc0;

    [NativeTypeName("#define XKB_KEY_downtack 0x0bc2")]
    public const int XKB_KEY_downtack = 0x0bc2;

    [NativeTypeName("#define XKB_KEY_upshoe 0x0bc3")]
    public const int XKB_KEY_upshoe = 0x0bc3;

    [NativeTypeName("#define XKB_KEY_downstile 0x0bc4")]
    public const int XKB_KEY_downstile = 0x0bc4;

    [NativeTypeName("#define XKB_KEY_underbar 0x0bc6")]
    public const int XKB_KEY_underbar = 0x0bc6;

    [NativeTypeName("#define XKB_KEY_jot 0x0bca")]
    public const int XKB_KEY_jot = 0x0bca;

    [NativeTypeName("#define XKB_KEY_quad 0x0bcc")]
    public const int XKB_KEY_quad = 0x0bcc;

    [NativeTypeName("#define XKB_KEY_uptack 0x0bce")]
    public const int XKB_KEY_uptack = 0x0bce;

    [NativeTypeName("#define XKB_KEY_circle 0x0bcf")]
    public const int XKB_KEY_circle = 0x0bcf;

    [NativeTypeName("#define XKB_KEY_upstile 0x0bd3")]
    public const int XKB_KEY_upstile = 0x0bd3;

    [NativeTypeName("#define XKB_KEY_downshoe 0x0bd6")]
    public const int XKB_KEY_downshoe = 0x0bd6;

    [NativeTypeName("#define XKB_KEY_rightshoe 0x0bd8")]
    public const int XKB_KEY_rightshoe = 0x0bd8;

    [NativeTypeName("#define XKB_KEY_leftshoe 0x0bda")]
    public const int XKB_KEY_leftshoe = 0x0bda;

    [NativeTypeName("#define XKB_KEY_lefttack 0x0bdc")]
    public const int XKB_KEY_lefttack = 0x0bdc;

    [NativeTypeName("#define XKB_KEY_righttack 0x0bfc")]
    public const int XKB_KEY_righttack = 0x0bfc;

    [NativeTypeName("#define XKB_KEY_hebrew_doublelowline 0x0cdf")]
    public const int XKB_KEY_hebrew_doublelowline = 0x0cdf;

    [NativeTypeName("#define XKB_KEY_hebrew_aleph 0x0ce0")]
    public const int XKB_KEY_hebrew_aleph = 0x0ce0;

    [NativeTypeName("#define XKB_KEY_hebrew_bet 0x0ce1")]
    public const int XKB_KEY_hebrew_bet = 0x0ce1;

    [NativeTypeName("#define XKB_KEY_hebrew_beth 0x0ce1")]
    public const int XKB_KEY_hebrew_beth = 0x0ce1;

    [NativeTypeName("#define XKB_KEY_hebrew_gimel 0x0ce2")]
    public const int XKB_KEY_hebrew_gimel = 0x0ce2;

    [NativeTypeName("#define XKB_KEY_hebrew_gimmel 0x0ce2")]
    public const int XKB_KEY_hebrew_gimmel = 0x0ce2;

    [NativeTypeName("#define XKB_KEY_hebrew_dalet 0x0ce3")]
    public const int XKB_KEY_hebrew_dalet = 0x0ce3;

    [NativeTypeName("#define XKB_KEY_hebrew_daleth 0x0ce3")]
    public const int XKB_KEY_hebrew_daleth = 0x0ce3;

    [NativeTypeName("#define XKB_KEY_hebrew_he 0x0ce4")]
    public const int XKB_KEY_hebrew_he = 0x0ce4;

    [NativeTypeName("#define XKB_KEY_hebrew_waw 0x0ce5")]
    public const int XKB_KEY_hebrew_waw = 0x0ce5;

    [NativeTypeName("#define XKB_KEY_hebrew_zain 0x0ce6")]
    public const int XKB_KEY_hebrew_zain = 0x0ce6;

    [NativeTypeName("#define XKB_KEY_hebrew_zayin 0x0ce6")]
    public const int XKB_KEY_hebrew_zayin = 0x0ce6;

    [NativeTypeName("#define XKB_KEY_hebrew_chet 0x0ce7")]
    public const int XKB_KEY_hebrew_chet = 0x0ce7;

    [NativeTypeName("#define XKB_KEY_hebrew_het 0x0ce7")]
    public const int XKB_KEY_hebrew_het = 0x0ce7;

    [NativeTypeName("#define XKB_KEY_hebrew_tet 0x0ce8")]
    public const int XKB_KEY_hebrew_tet = 0x0ce8;

    [NativeTypeName("#define XKB_KEY_hebrew_teth 0x0ce8")]
    public const int XKB_KEY_hebrew_teth = 0x0ce8;

    [NativeTypeName("#define XKB_KEY_hebrew_yod 0x0ce9")]
    public const int XKB_KEY_hebrew_yod = 0x0ce9;

    [NativeTypeName("#define XKB_KEY_hebrew_finalkaph 0x0cea")]
    public const int XKB_KEY_hebrew_finalkaph = 0x0cea;

    [NativeTypeName("#define XKB_KEY_hebrew_kaph 0x0ceb")]
    public const int XKB_KEY_hebrew_kaph = 0x0ceb;

    [NativeTypeName("#define XKB_KEY_hebrew_lamed 0x0cec")]
    public const int XKB_KEY_hebrew_lamed = 0x0cec;

    [NativeTypeName("#define XKB_KEY_hebrew_finalmem 0x0ced")]
    public const int XKB_KEY_hebrew_finalmem = 0x0ced;

    [NativeTypeName("#define XKB_KEY_hebrew_mem 0x0cee")]
    public const int XKB_KEY_hebrew_mem = 0x0cee;

    [NativeTypeName("#define XKB_KEY_hebrew_finalnun 0x0cef")]
    public const int XKB_KEY_hebrew_finalnun = 0x0cef;

    [NativeTypeName("#define XKB_KEY_hebrew_nun 0x0cf0")]
    public const int XKB_KEY_hebrew_nun = 0x0cf0;

    [NativeTypeName("#define XKB_KEY_hebrew_samech 0x0cf1")]
    public const int XKB_KEY_hebrew_samech = 0x0cf1;

    [NativeTypeName("#define XKB_KEY_hebrew_samekh 0x0cf1")]
    public const int XKB_KEY_hebrew_samekh = 0x0cf1;

    [NativeTypeName("#define XKB_KEY_hebrew_ayin 0x0cf2")]
    public const int XKB_KEY_hebrew_ayin = 0x0cf2;

    [NativeTypeName("#define XKB_KEY_hebrew_finalpe 0x0cf3")]
    public const int XKB_KEY_hebrew_finalpe = 0x0cf3;

    [NativeTypeName("#define XKB_KEY_hebrew_pe 0x0cf4")]
    public const int XKB_KEY_hebrew_pe = 0x0cf4;

    [NativeTypeName("#define XKB_KEY_hebrew_finalzade 0x0cf5")]
    public const int XKB_KEY_hebrew_finalzade = 0x0cf5;

    [NativeTypeName("#define XKB_KEY_hebrew_finalzadi 0x0cf5")]
    public const int XKB_KEY_hebrew_finalzadi = 0x0cf5;

    [NativeTypeName("#define XKB_KEY_hebrew_zade 0x0cf6")]
    public const int XKB_KEY_hebrew_zade = 0x0cf6;

    [NativeTypeName("#define XKB_KEY_hebrew_zadi 0x0cf6")]
    public const int XKB_KEY_hebrew_zadi = 0x0cf6;

    [NativeTypeName("#define XKB_KEY_hebrew_qoph 0x0cf7")]
    public const int XKB_KEY_hebrew_qoph = 0x0cf7;

    [NativeTypeName("#define XKB_KEY_hebrew_kuf 0x0cf7")]
    public const int XKB_KEY_hebrew_kuf = 0x0cf7;

    [NativeTypeName("#define XKB_KEY_hebrew_resh 0x0cf8")]
    public const int XKB_KEY_hebrew_resh = 0x0cf8;

    [NativeTypeName("#define XKB_KEY_hebrew_shin 0x0cf9")]
    public const int XKB_KEY_hebrew_shin = 0x0cf9;

    [NativeTypeName("#define XKB_KEY_hebrew_taw 0x0cfa")]
    public const int XKB_KEY_hebrew_taw = 0x0cfa;

    [NativeTypeName("#define XKB_KEY_hebrew_taf 0x0cfa")]
    public const int XKB_KEY_hebrew_taf = 0x0cfa;

    [NativeTypeName("#define XKB_KEY_Hebrew_switch 0xff7e")]
    public const int XKB_KEY_Hebrew_switch = 0xff7e;

    [NativeTypeName("#define XKB_KEY_Thai_kokai 0x0da1")]
    public const int XKB_KEY_Thai_kokai = 0x0da1;

    [NativeTypeName("#define XKB_KEY_Thai_khokhai 0x0da2")]
    public const int XKB_KEY_Thai_khokhai = 0x0da2;

    [NativeTypeName("#define XKB_KEY_Thai_khokhuat 0x0da3")]
    public const int XKB_KEY_Thai_khokhuat = 0x0da3;

    [NativeTypeName("#define XKB_KEY_Thai_khokhwai 0x0da4")]
    public const int XKB_KEY_Thai_khokhwai = 0x0da4;

    [NativeTypeName("#define XKB_KEY_Thai_khokhon 0x0da5")]
    public const int XKB_KEY_Thai_khokhon = 0x0da5;

    [NativeTypeName("#define XKB_KEY_Thai_khorakhang 0x0da6")]
    public const int XKB_KEY_Thai_khorakhang = 0x0da6;

    [NativeTypeName("#define XKB_KEY_Thai_ngongu 0x0da7")]
    public const int XKB_KEY_Thai_ngongu = 0x0da7;

    [NativeTypeName("#define XKB_KEY_Thai_chochan 0x0da8")]
    public const int XKB_KEY_Thai_chochan = 0x0da8;

    [NativeTypeName("#define XKB_KEY_Thai_choching 0x0da9")]
    public const int XKB_KEY_Thai_choching = 0x0da9;

    [NativeTypeName("#define XKB_KEY_Thai_chochang 0x0daa")]
    public const int XKB_KEY_Thai_chochang = 0x0daa;

    [NativeTypeName("#define XKB_KEY_Thai_soso 0x0dab")]
    public const int XKB_KEY_Thai_soso = 0x0dab;

    [NativeTypeName("#define XKB_KEY_Thai_chochoe 0x0dac")]
    public const int XKB_KEY_Thai_chochoe = 0x0dac;

    [NativeTypeName("#define XKB_KEY_Thai_yoying 0x0dad")]
    public const int XKB_KEY_Thai_yoying = 0x0dad;

    [NativeTypeName("#define XKB_KEY_Thai_dochada 0x0dae")]
    public const int XKB_KEY_Thai_dochada = 0x0dae;

    [NativeTypeName("#define XKB_KEY_Thai_topatak 0x0daf")]
    public const int XKB_KEY_Thai_topatak = 0x0daf;

    [NativeTypeName("#define XKB_KEY_Thai_thothan 0x0db0")]
    public const int XKB_KEY_Thai_thothan = 0x0db0;

    [NativeTypeName("#define XKB_KEY_Thai_thonangmontho 0x0db1")]
    public const int XKB_KEY_Thai_thonangmontho = 0x0db1;

    [NativeTypeName("#define XKB_KEY_Thai_thophuthao 0x0db2")]
    public const int XKB_KEY_Thai_thophuthao = 0x0db2;

    [NativeTypeName("#define XKB_KEY_Thai_nonen 0x0db3")]
    public const int XKB_KEY_Thai_nonen = 0x0db3;

    [NativeTypeName("#define XKB_KEY_Thai_dodek 0x0db4")]
    public const int XKB_KEY_Thai_dodek = 0x0db4;

    [NativeTypeName("#define XKB_KEY_Thai_totao 0x0db5")]
    public const int XKB_KEY_Thai_totao = 0x0db5;

    [NativeTypeName("#define XKB_KEY_Thai_thothung 0x0db6")]
    public const int XKB_KEY_Thai_thothung = 0x0db6;

    [NativeTypeName("#define XKB_KEY_Thai_thothahan 0x0db7")]
    public const int XKB_KEY_Thai_thothahan = 0x0db7;

    [NativeTypeName("#define XKB_KEY_Thai_thothong 0x0db8")]
    public const int XKB_KEY_Thai_thothong = 0x0db8;

    [NativeTypeName("#define XKB_KEY_Thai_nonu 0x0db9")]
    public const int XKB_KEY_Thai_nonu = 0x0db9;

    [NativeTypeName("#define XKB_KEY_Thai_bobaimai 0x0dba")]
    public const int XKB_KEY_Thai_bobaimai = 0x0dba;

    [NativeTypeName("#define XKB_KEY_Thai_popla 0x0dbb")]
    public const int XKB_KEY_Thai_popla = 0x0dbb;

    [NativeTypeName("#define XKB_KEY_Thai_phophung 0x0dbc")]
    public const int XKB_KEY_Thai_phophung = 0x0dbc;

    [NativeTypeName("#define XKB_KEY_Thai_fofa 0x0dbd")]
    public const int XKB_KEY_Thai_fofa = 0x0dbd;

    [NativeTypeName("#define XKB_KEY_Thai_phophan 0x0dbe")]
    public const int XKB_KEY_Thai_phophan = 0x0dbe;

    [NativeTypeName("#define XKB_KEY_Thai_fofan 0x0dbf")]
    public const int XKB_KEY_Thai_fofan = 0x0dbf;

    [NativeTypeName("#define XKB_KEY_Thai_phosamphao 0x0dc0")]
    public const int XKB_KEY_Thai_phosamphao = 0x0dc0;

    [NativeTypeName("#define XKB_KEY_Thai_moma 0x0dc1")]
    public const int XKB_KEY_Thai_moma = 0x0dc1;

    [NativeTypeName("#define XKB_KEY_Thai_yoyak 0x0dc2")]
    public const int XKB_KEY_Thai_yoyak = 0x0dc2;

    [NativeTypeName("#define XKB_KEY_Thai_rorua 0x0dc3")]
    public const int XKB_KEY_Thai_rorua = 0x0dc3;

    [NativeTypeName("#define XKB_KEY_Thai_ru 0x0dc4")]
    public const int XKB_KEY_Thai_ru = 0x0dc4;

    [NativeTypeName("#define XKB_KEY_Thai_loling 0x0dc5")]
    public const int XKB_KEY_Thai_loling = 0x0dc5;

    [NativeTypeName("#define XKB_KEY_Thai_lu 0x0dc6")]
    public const int XKB_KEY_Thai_lu = 0x0dc6;

    [NativeTypeName("#define XKB_KEY_Thai_wowaen 0x0dc7")]
    public const int XKB_KEY_Thai_wowaen = 0x0dc7;

    [NativeTypeName("#define XKB_KEY_Thai_sosala 0x0dc8")]
    public const int XKB_KEY_Thai_sosala = 0x0dc8;

    [NativeTypeName("#define XKB_KEY_Thai_sorusi 0x0dc9")]
    public const int XKB_KEY_Thai_sorusi = 0x0dc9;

    [NativeTypeName("#define XKB_KEY_Thai_sosua 0x0dca")]
    public const int XKB_KEY_Thai_sosua = 0x0dca;

    [NativeTypeName("#define XKB_KEY_Thai_hohip 0x0dcb")]
    public const int XKB_KEY_Thai_hohip = 0x0dcb;

    [NativeTypeName("#define XKB_KEY_Thai_lochula 0x0dcc")]
    public const int XKB_KEY_Thai_lochula = 0x0dcc;

    [NativeTypeName("#define XKB_KEY_Thai_oang 0x0dcd")]
    public const int XKB_KEY_Thai_oang = 0x0dcd;

    [NativeTypeName("#define XKB_KEY_Thai_honokhuk 0x0dce")]
    public const int XKB_KEY_Thai_honokhuk = 0x0dce;

    [NativeTypeName("#define XKB_KEY_Thai_paiyannoi 0x0dcf")]
    public const int XKB_KEY_Thai_paiyannoi = 0x0dcf;

    [NativeTypeName("#define XKB_KEY_Thai_saraa 0x0dd0")]
    public const int XKB_KEY_Thai_saraa = 0x0dd0;

    [NativeTypeName("#define XKB_KEY_Thai_maihanakat 0x0dd1")]
    public const int XKB_KEY_Thai_maihanakat = 0x0dd1;

    [NativeTypeName("#define XKB_KEY_Thai_saraaa 0x0dd2")]
    public const int XKB_KEY_Thai_saraaa = 0x0dd2;

    [NativeTypeName("#define XKB_KEY_Thai_saraam 0x0dd3")]
    public const int XKB_KEY_Thai_saraam = 0x0dd3;

    [NativeTypeName("#define XKB_KEY_Thai_sarai 0x0dd4")]
    public const int XKB_KEY_Thai_sarai = 0x0dd4;

    [NativeTypeName("#define XKB_KEY_Thai_saraii 0x0dd5")]
    public const int XKB_KEY_Thai_saraii = 0x0dd5;

    [NativeTypeName("#define XKB_KEY_Thai_saraue 0x0dd6")]
    public const int XKB_KEY_Thai_saraue = 0x0dd6;

    [NativeTypeName("#define XKB_KEY_Thai_sarauee 0x0dd7")]
    public const int XKB_KEY_Thai_sarauee = 0x0dd7;

    [NativeTypeName("#define XKB_KEY_Thai_sarau 0x0dd8")]
    public const int XKB_KEY_Thai_sarau = 0x0dd8;

    [NativeTypeName("#define XKB_KEY_Thai_sarauu 0x0dd9")]
    public const int XKB_KEY_Thai_sarauu = 0x0dd9;

    [NativeTypeName("#define XKB_KEY_Thai_phinthu 0x0dda")]
    public const int XKB_KEY_Thai_phinthu = 0x0dda;

    [NativeTypeName("#define XKB_KEY_Thai_maihanakat_maitho 0x0dde")]
    public const int XKB_KEY_Thai_maihanakat_maitho = 0x0dde;

    [NativeTypeName("#define XKB_KEY_Thai_baht 0x0ddf")]
    public const int XKB_KEY_Thai_baht = 0x0ddf;

    [NativeTypeName("#define XKB_KEY_Thai_sarae 0x0de0")]
    public const int XKB_KEY_Thai_sarae = 0x0de0;

    [NativeTypeName("#define XKB_KEY_Thai_saraae 0x0de1")]
    public const int XKB_KEY_Thai_saraae = 0x0de1;

    [NativeTypeName("#define XKB_KEY_Thai_sarao 0x0de2")]
    public const int XKB_KEY_Thai_sarao = 0x0de2;

    [NativeTypeName("#define XKB_KEY_Thai_saraaimaimuan 0x0de3")]
    public const int XKB_KEY_Thai_saraaimaimuan = 0x0de3;

    [NativeTypeName("#define XKB_KEY_Thai_saraaimaimalai 0x0de4")]
    public const int XKB_KEY_Thai_saraaimaimalai = 0x0de4;

    [NativeTypeName("#define XKB_KEY_Thai_lakkhangyao 0x0de5")]
    public const int XKB_KEY_Thai_lakkhangyao = 0x0de5;

    [NativeTypeName("#define XKB_KEY_Thai_maiyamok 0x0de6")]
    public const int XKB_KEY_Thai_maiyamok = 0x0de6;

    [NativeTypeName("#define XKB_KEY_Thai_maitaikhu 0x0de7")]
    public const int XKB_KEY_Thai_maitaikhu = 0x0de7;

    [NativeTypeName("#define XKB_KEY_Thai_maiek 0x0de8")]
    public const int XKB_KEY_Thai_maiek = 0x0de8;

    [NativeTypeName("#define XKB_KEY_Thai_maitho 0x0de9")]
    public const int XKB_KEY_Thai_maitho = 0x0de9;

    [NativeTypeName("#define XKB_KEY_Thai_maitri 0x0dea")]
    public const int XKB_KEY_Thai_maitri = 0x0dea;

    [NativeTypeName("#define XKB_KEY_Thai_maichattawa 0x0deb")]
    public const int XKB_KEY_Thai_maichattawa = 0x0deb;

    [NativeTypeName("#define XKB_KEY_Thai_thanthakhat 0x0dec")]
    public const int XKB_KEY_Thai_thanthakhat = 0x0dec;

    [NativeTypeName("#define XKB_KEY_Thai_nikhahit 0x0ded")]
    public const int XKB_KEY_Thai_nikhahit = 0x0ded;

    [NativeTypeName("#define XKB_KEY_Thai_leksun 0x0df0")]
    public const int XKB_KEY_Thai_leksun = 0x0df0;

    [NativeTypeName("#define XKB_KEY_Thai_leknung 0x0df1")]
    public const int XKB_KEY_Thai_leknung = 0x0df1;

    [NativeTypeName("#define XKB_KEY_Thai_leksong 0x0df2")]
    public const int XKB_KEY_Thai_leksong = 0x0df2;

    [NativeTypeName("#define XKB_KEY_Thai_leksam 0x0df3")]
    public const int XKB_KEY_Thai_leksam = 0x0df3;

    [NativeTypeName("#define XKB_KEY_Thai_leksi 0x0df4")]
    public const int XKB_KEY_Thai_leksi = 0x0df4;

    [NativeTypeName("#define XKB_KEY_Thai_lekha 0x0df5")]
    public const int XKB_KEY_Thai_lekha = 0x0df5;

    [NativeTypeName("#define XKB_KEY_Thai_lekhok 0x0df6")]
    public const int XKB_KEY_Thai_lekhok = 0x0df6;

    [NativeTypeName("#define XKB_KEY_Thai_lekchet 0x0df7")]
    public const int XKB_KEY_Thai_lekchet = 0x0df7;

    [NativeTypeName("#define XKB_KEY_Thai_lekpaet 0x0df8")]
    public const int XKB_KEY_Thai_lekpaet = 0x0df8;

    [NativeTypeName("#define XKB_KEY_Thai_lekkao 0x0df9")]
    public const int XKB_KEY_Thai_lekkao = 0x0df9;

    [NativeTypeName("#define XKB_KEY_Hangul 0xff31")]
    public const int XKB_KEY_Hangul = 0xff31;

    [NativeTypeName("#define XKB_KEY_Hangul_Start 0xff32")]
    public const int XKB_KEY_Hangul_Start = 0xff32;

    [NativeTypeName("#define XKB_KEY_Hangul_End 0xff33")]
    public const int XKB_KEY_Hangul_End = 0xff33;

    [NativeTypeName("#define XKB_KEY_Hangul_Hanja 0xff34")]
    public const int XKB_KEY_Hangul_Hanja = 0xff34;

    [NativeTypeName("#define XKB_KEY_Hangul_Jamo 0xff35")]
    public const int XKB_KEY_Hangul_Jamo = 0xff35;

    [NativeTypeName("#define XKB_KEY_Hangul_Romaja 0xff36")]
    public const int XKB_KEY_Hangul_Romaja = 0xff36;

    [NativeTypeName("#define XKB_KEY_Hangul_Codeinput 0xff37")]
    public const int XKB_KEY_Hangul_Codeinput = 0xff37;

    [NativeTypeName("#define XKB_KEY_Hangul_Jeonja 0xff38")]
    public const int XKB_KEY_Hangul_Jeonja = 0xff38;

    [NativeTypeName("#define XKB_KEY_Hangul_Banja 0xff39")]
    public const int XKB_KEY_Hangul_Banja = 0xff39;

    [NativeTypeName("#define XKB_KEY_Hangul_PreHanja 0xff3a")]
    public const int XKB_KEY_Hangul_PreHanja = 0xff3a;

    [NativeTypeName("#define XKB_KEY_Hangul_PostHanja 0xff3b")]
    public const int XKB_KEY_Hangul_PostHanja = 0xff3b;

    [NativeTypeName("#define XKB_KEY_Hangul_SingleCandidate 0xff3c")]
    public const int XKB_KEY_Hangul_SingleCandidate = 0xff3c;

    [NativeTypeName("#define XKB_KEY_Hangul_MultipleCandidate 0xff3d")]
    public const int XKB_KEY_Hangul_MultipleCandidate = 0xff3d;

    [NativeTypeName("#define XKB_KEY_Hangul_PreviousCandidate 0xff3e")]
    public const int XKB_KEY_Hangul_PreviousCandidate = 0xff3e;

    [NativeTypeName("#define XKB_KEY_Hangul_Special 0xff3f")]
    public const int XKB_KEY_Hangul_Special = 0xff3f;

    [NativeTypeName("#define XKB_KEY_Hangul_switch 0xff7e")]
    public const int XKB_KEY_Hangul_switch = 0xff7e;

    [NativeTypeName("#define XKB_KEY_Hangul_Kiyeog 0x0ea1")]
    public const int XKB_KEY_Hangul_Kiyeog = 0x0ea1;

    [NativeTypeName("#define XKB_KEY_Hangul_SsangKiyeog 0x0ea2")]
    public const int XKB_KEY_Hangul_SsangKiyeog = 0x0ea2;

    [NativeTypeName("#define XKB_KEY_Hangul_KiyeogSios 0x0ea3")]
    public const int XKB_KEY_Hangul_KiyeogSios = 0x0ea3;

    [NativeTypeName("#define XKB_KEY_Hangul_Nieun 0x0ea4")]
    public const int XKB_KEY_Hangul_Nieun = 0x0ea4;

    [NativeTypeName("#define XKB_KEY_Hangul_NieunJieuj 0x0ea5")]
    public const int XKB_KEY_Hangul_NieunJieuj = 0x0ea5;

    [NativeTypeName("#define XKB_KEY_Hangul_NieunHieuh 0x0ea6")]
    public const int XKB_KEY_Hangul_NieunHieuh = 0x0ea6;

    [NativeTypeName("#define XKB_KEY_Hangul_Dikeud 0x0ea7")]
    public const int XKB_KEY_Hangul_Dikeud = 0x0ea7;

    [NativeTypeName("#define XKB_KEY_Hangul_SsangDikeud 0x0ea8")]
    public const int XKB_KEY_Hangul_SsangDikeud = 0x0ea8;

    [NativeTypeName("#define XKB_KEY_Hangul_Rieul 0x0ea9")]
    public const int XKB_KEY_Hangul_Rieul = 0x0ea9;

    [NativeTypeName("#define XKB_KEY_Hangul_RieulKiyeog 0x0eaa")]
    public const int XKB_KEY_Hangul_RieulKiyeog = 0x0eaa;

    [NativeTypeName("#define XKB_KEY_Hangul_RieulMieum 0x0eab")]
    public const int XKB_KEY_Hangul_RieulMieum = 0x0eab;

    [NativeTypeName("#define XKB_KEY_Hangul_RieulPieub 0x0eac")]
    public const int XKB_KEY_Hangul_RieulPieub = 0x0eac;

    [NativeTypeName("#define XKB_KEY_Hangul_RieulSios 0x0ead")]
    public const int XKB_KEY_Hangul_RieulSios = 0x0ead;

    [NativeTypeName("#define XKB_KEY_Hangul_RieulTieut 0x0eae")]
    public const int XKB_KEY_Hangul_RieulTieut = 0x0eae;

    [NativeTypeName("#define XKB_KEY_Hangul_RieulPhieuf 0x0eaf")]
    public const int XKB_KEY_Hangul_RieulPhieuf = 0x0eaf;

    [NativeTypeName("#define XKB_KEY_Hangul_RieulHieuh 0x0eb0")]
    public const int XKB_KEY_Hangul_RieulHieuh = 0x0eb0;

    [NativeTypeName("#define XKB_KEY_Hangul_Mieum 0x0eb1")]
    public const int XKB_KEY_Hangul_Mieum = 0x0eb1;

    [NativeTypeName("#define XKB_KEY_Hangul_Pieub 0x0eb2")]
    public const int XKB_KEY_Hangul_Pieub = 0x0eb2;

    [NativeTypeName("#define XKB_KEY_Hangul_SsangPieub 0x0eb3")]
    public const int XKB_KEY_Hangul_SsangPieub = 0x0eb3;

    [NativeTypeName("#define XKB_KEY_Hangul_PieubSios 0x0eb4")]
    public const int XKB_KEY_Hangul_PieubSios = 0x0eb4;

    [NativeTypeName("#define XKB_KEY_Hangul_Sios 0x0eb5")]
    public const int XKB_KEY_Hangul_Sios = 0x0eb5;

    [NativeTypeName("#define XKB_KEY_Hangul_SsangSios 0x0eb6")]
    public const int XKB_KEY_Hangul_SsangSios = 0x0eb6;

    [NativeTypeName("#define XKB_KEY_Hangul_Ieung 0x0eb7")]
    public const int XKB_KEY_Hangul_Ieung = 0x0eb7;

    [NativeTypeName("#define XKB_KEY_Hangul_Jieuj 0x0eb8")]
    public const int XKB_KEY_Hangul_Jieuj = 0x0eb8;

    [NativeTypeName("#define XKB_KEY_Hangul_SsangJieuj 0x0eb9")]
    public const int XKB_KEY_Hangul_SsangJieuj = 0x0eb9;

    [NativeTypeName("#define XKB_KEY_Hangul_Cieuc 0x0eba")]
    public const int XKB_KEY_Hangul_Cieuc = 0x0eba;

    [NativeTypeName("#define XKB_KEY_Hangul_Khieuq 0x0ebb")]
    public const int XKB_KEY_Hangul_Khieuq = 0x0ebb;

    [NativeTypeName("#define XKB_KEY_Hangul_Tieut 0x0ebc")]
    public const int XKB_KEY_Hangul_Tieut = 0x0ebc;

    [NativeTypeName("#define XKB_KEY_Hangul_Phieuf 0x0ebd")]
    public const int XKB_KEY_Hangul_Phieuf = 0x0ebd;

    [NativeTypeName("#define XKB_KEY_Hangul_Hieuh 0x0ebe")]
    public const int XKB_KEY_Hangul_Hieuh = 0x0ebe;

    [NativeTypeName("#define XKB_KEY_Hangul_A 0x0ebf")]
    public const int XKB_KEY_Hangul_A = 0x0ebf;

    [NativeTypeName("#define XKB_KEY_Hangul_AE 0x0ec0")]
    public const int XKB_KEY_Hangul_AE = 0x0ec0;

    [NativeTypeName("#define XKB_KEY_Hangul_YA 0x0ec1")]
    public const int XKB_KEY_Hangul_YA = 0x0ec1;

    [NativeTypeName("#define XKB_KEY_Hangul_YAE 0x0ec2")]
    public const int XKB_KEY_Hangul_YAE = 0x0ec2;

    [NativeTypeName("#define XKB_KEY_Hangul_EO 0x0ec3")]
    public const int XKB_KEY_Hangul_EO = 0x0ec3;

    [NativeTypeName("#define XKB_KEY_Hangul_E 0x0ec4")]
    public const int XKB_KEY_Hangul_E = 0x0ec4;

    [NativeTypeName("#define XKB_KEY_Hangul_YEO 0x0ec5")]
    public const int XKB_KEY_Hangul_YEO = 0x0ec5;

    [NativeTypeName("#define XKB_KEY_Hangul_YE 0x0ec6")]
    public const int XKB_KEY_Hangul_YE = 0x0ec6;

    [NativeTypeName("#define XKB_KEY_Hangul_O 0x0ec7")]
    public const int XKB_KEY_Hangul_O = 0x0ec7;

    [NativeTypeName("#define XKB_KEY_Hangul_WA 0x0ec8")]
    public const int XKB_KEY_Hangul_WA = 0x0ec8;

    [NativeTypeName("#define XKB_KEY_Hangul_WAE 0x0ec9")]
    public const int XKB_KEY_Hangul_WAE = 0x0ec9;

    [NativeTypeName("#define XKB_KEY_Hangul_OE 0x0eca")]
    public const int XKB_KEY_Hangul_OE = 0x0eca;

    [NativeTypeName("#define XKB_KEY_Hangul_YO 0x0ecb")]
    public const int XKB_KEY_Hangul_YO = 0x0ecb;

    [NativeTypeName("#define XKB_KEY_Hangul_U 0x0ecc")]
    public const int XKB_KEY_Hangul_U = 0x0ecc;

    [NativeTypeName("#define XKB_KEY_Hangul_WEO 0x0ecd")]
    public const int XKB_KEY_Hangul_WEO = 0x0ecd;

    [NativeTypeName("#define XKB_KEY_Hangul_WE 0x0ece")]
    public const int XKB_KEY_Hangul_WE = 0x0ece;

    [NativeTypeName("#define XKB_KEY_Hangul_WI 0x0ecf")]
    public const int XKB_KEY_Hangul_WI = 0x0ecf;

    [NativeTypeName("#define XKB_KEY_Hangul_YU 0x0ed0")]
    public const int XKB_KEY_Hangul_YU = 0x0ed0;

    [NativeTypeName("#define XKB_KEY_Hangul_EU 0x0ed1")]
    public const int XKB_KEY_Hangul_EU = 0x0ed1;

    [NativeTypeName("#define XKB_KEY_Hangul_YI 0x0ed2")]
    public const int XKB_KEY_Hangul_YI = 0x0ed2;

    [NativeTypeName("#define XKB_KEY_Hangul_I 0x0ed3")]
    public const int XKB_KEY_Hangul_I = 0x0ed3;

    [NativeTypeName("#define XKB_KEY_Hangul_J_Kiyeog 0x0ed4")]
    public const int XKB_KEY_Hangul_J_Kiyeog = 0x0ed4;

    [NativeTypeName("#define XKB_KEY_Hangul_J_SsangKiyeog 0x0ed5")]
    public const int XKB_KEY_Hangul_J_SsangKiyeog = 0x0ed5;

    [NativeTypeName("#define XKB_KEY_Hangul_J_KiyeogSios 0x0ed6")]
    public const int XKB_KEY_Hangul_J_KiyeogSios = 0x0ed6;

    [NativeTypeName("#define XKB_KEY_Hangul_J_Nieun 0x0ed7")]
    public const int XKB_KEY_Hangul_J_Nieun = 0x0ed7;

    [NativeTypeName("#define XKB_KEY_Hangul_J_NieunJieuj 0x0ed8")]
    public const int XKB_KEY_Hangul_J_NieunJieuj = 0x0ed8;

    [NativeTypeName("#define XKB_KEY_Hangul_J_NieunHieuh 0x0ed9")]
    public const int XKB_KEY_Hangul_J_NieunHieuh = 0x0ed9;

    [NativeTypeName("#define XKB_KEY_Hangul_J_Dikeud 0x0eda")]
    public const int XKB_KEY_Hangul_J_Dikeud = 0x0eda;

    [NativeTypeName("#define XKB_KEY_Hangul_J_Rieul 0x0edb")]
    public const int XKB_KEY_Hangul_J_Rieul = 0x0edb;

    [NativeTypeName("#define XKB_KEY_Hangul_J_RieulKiyeog 0x0edc")]
    public const int XKB_KEY_Hangul_J_RieulKiyeog = 0x0edc;

    [NativeTypeName("#define XKB_KEY_Hangul_J_RieulMieum 0x0edd")]
    public const int XKB_KEY_Hangul_J_RieulMieum = 0x0edd;

    [NativeTypeName("#define XKB_KEY_Hangul_J_RieulPieub 0x0ede")]
    public const int XKB_KEY_Hangul_J_RieulPieub = 0x0ede;

    [NativeTypeName("#define XKB_KEY_Hangul_J_RieulSios 0x0edf")]
    public const int XKB_KEY_Hangul_J_RieulSios = 0x0edf;

    [NativeTypeName("#define XKB_KEY_Hangul_J_RieulTieut 0x0ee0")]
    public const int XKB_KEY_Hangul_J_RieulTieut = 0x0ee0;

    [NativeTypeName("#define XKB_KEY_Hangul_J_RieulPhieuf 0x0ee1")]
    public const int XKB_KEY_Hangul_J_RieulPhieuf = 0x0ee1;

    [NativeTypeName("#define XKB_KEY_Hangul_J_RieulHieuh 0x0ee2")]
    public const int XKB_KEY_Hangul_J_RieulHieuh = 0x0ee2;

    [NativeTypeName("#define XKB_KEY_Hangul_J_Mieum 0x0ee3")]
    public const int XKB_KEY_Hangul_J_Mieum = 0x0ee3;

    [NativeTypeName("#define XKB_KEY_Hangul_J_Pieub 0x0ee4")]
    public const int XKB_KEY_Hangul_J_Pieub = 0x0ee4;

    [NativeTypeName("#define XKB_KEY_Hangul_J_PieubSios 0x0ee5")]
    public const int XKB_KEY_Hangul_J_PieubSios = 0x0ee5;

    [NativeTypeName("#define XKB_KEY_Hangul_J_Sios 0x0ee6")]
    public const int XKB_KEY_Hangul_J_Sios = 0x0ee6;

    [NativeTypeName("#define XKB_KEY_Hangul_J_SsangSios 0x0ee7")]
    public const int XKB_KEY_Hangul_J_SsangSios = 0x0ee7;

    [NativeTypeName("#define XKB_KEY_Hangul_J_Ieung 0x0ee8")]
    public const int XKB_KEY_Hangul_J_Ieung = 0x0ee8;

    [NativeTypeName("#define XKB_KEY_Hangul_J_Jieuj 0x0ee9")]
    public const int XKB_KEY_Hangul_J_Jieuj = 0x0ee9;

    [NativeTypeName("#define XKB_KEY_Hangul_J_Cieuc 0x0eea")]
    public const int XKB_KEY_Hangul_J_Cieuc = 0x0eea;

    [NativeTypeName("#define XKB_KEY_Hangul_J_Khieuq 0x0eeb")]
    public const int XKB_KEY_Hangul_J_Khieuq = 0x0eeb;

    [NativeTypeName("#define XKB_KEY_Hangul_J_Tieut 0x0eec")]
    public const int XKB_KEY_Hangul_J_Tieut = 0x0eec;

    [NativeTypeName("#define XKB_KEY_Hangul_J_Phieuf 0x0eed")]
    public const int XKB_KEY_Hangul_J_Phieuf = 0x0eed;

    [NativeTypeName("#define XKB_KEY_Hangul_J_Hieuh 0x0eee")]
    public const int XKB_KEY_Hangul_J_Hieuh = 0x0eee;

    [NativeTypeName("#define XKB_KEY_Hangul_RieulYeorinHieuh 0x0eef")]
    public const int XKB_KEY_Hangul_RieulYeorinHieuh = 0x0eef;

    [NativeTypeName("#define XKB_KEY_Hangul_SunkyeongeumMieum 0x0ef0")]
    public const int XKB_KEY_Hangul_SunkyeongeumMieum = 0x0ef0;

    [NativeTypeName("#define XKB_KEY_Hangul_SunkyeongeumPieub 0x0ef1")]
    public const int XKB_KEY_Hangul_SunkyeongeumPieub = 0x0ef1;

    [NativeTypeName("#define XKB_KEY_Hangul_PanSios 0x0ef2")]
    public const int XKB_KEY_Hangul_PanSios = 0x0ef2;

    [NativeTypeName("#define XKB_KEY_Hangul_KkogjiDalrinIeung 0x0ef3")]
    public const int XKB_KEY_Hangul_KkogjiDalrinIeung = 0x0ef3;

    [NativeTypeName("#define XKB_KEY_Hangul_SunkyeongeumPhieuf 0x0ef4")]
    public const int XKB_KEY_Hangul_SunkyeongeumPhieuf = 0x0ef4;

    [NativeTypeName("#define XKB_KEY_Hangul_YeorinHieuh 0x0ef5")]
    public const int XKB_KEY_Hangul_YeorinHieuh = 0x0ef5;

    [NativeTypeName("#define XKB_KEY_Hangul_AraeA 0x0ef6")]
    public const int XKB_KEY_Hangul_AraeA = 0x0ef6;

    [NativeTypeName("#define XKB_KEY_Hangul_AraeAE 0x0ef7")]
    public const int XKB_KEY_Hangul_AraeAE = 0x0ef7;

    [NativeTypeName("#define XKB_KEY_Hangul_J_PanSios 0x0ef8")]
    public const int XKB_KEY_Hangul_J_PanSios = 0x0ef8;

    [NativeTypeName("#define XKB_KEY_Hangul_J_KkogjiDalrinIeung 0x0ef9")]
    public const int XKB_KEY_Hangul_J_KkogjiDalrinIeung = 0x0ef9;

    [NativeTypeName("#define XKB_KEY_Hangul_J_YeorinHieuh 0x0efa")]
    public const int XKB_KEY_Hangul_J_YeorinHieuh = 0x0efa;

    [NativeTypeName("#define XKB_KEY_Korean_Won 0x0eff")]
    public const int XKB_KEY_Korean_Won = 0x0eff;

    [NativeTypeName("#define XKB_KEY_Armenian_ligature_ew 0x1000587")]
    public const int XKB_KEY_Armenian_ligature_ew = 0x1000587;

    [NativeTypeName("#define XKB_KEY_Armenian_full_stop 0x1000589")]
    public const int XKB_KEY_Armenian_full_stop = 0x1000589;

    [NativeTypeName("#define XKB_KEY_Armenian_verjaket 0x1000589")]
    public const int XKB_KEY_Armenian_verjaket = 0x1000589;

    [NativeTypeName("#define XKB_KEY_Armenian_separation_mark 0x100055d")]
    public const int XKB_KEY_Armenian_separation_mark = 0x100055d;

    [NativeTypeName("#define XKB_KEY_Armenian_but 0x100055d")]
    public const int XKB_KEY_Armenian_but = 0x100055d;

    [NativeTypeName("#define XKB_KEY_Armenian_hyphen 0x100058a")]
    public const int XKB_KEY_Armenian_hyphen = 0x100058a;

    [NativeTypeName("#define XKB_KEY_Armenian_yentamna 0x100058a")]
    public const int XKB_KEY_Armenian_yentamna = 0x100058a;

    [NativeTypeName("#define XKB_KEY_Armenian_exclam 0x100055c")]
    public const int XKB_KEY_Armenian_exclam = 0x100055c;

    [NativeTypeName("#define XKB_KEY_Armenian_amanak 0x100055c")]
    public const int XKB_KEY_Armenian_amanak = 0x100055c;

    [NativeTypeName("#define XKB_KEY_Armenian_accent 0x100055b")]
    public const int XKB_KEY_Armenian_accent = 0x100055b;

    [NativeTypeName("#define XKB_KEY_Armenian_shesht 0x100055b")]
    public const int XKB_KEY_Armenian_shesht = 0x100055b;

    [NativeTypeName("#define XKB_KEY_Armenian_question 0x100055e")]
    public const int XKB_KEY_Armenian_question = 0x100055e;

    [NativeTypeName("#define XKB_KEY_Armenian_paruyk 0x100055e")]
    public const int XKB_KEY_Armenian_paruyk = 0x100055e;

    [NativeTypeName("#define XKB_KEY_Armenian_AYB 0x1000531")]
    public const int XKB_KEY_Armenian_AYB = 0x1000531;

    [NativeTypeName("#define XKB_KEY_Armenian_ayb 0x1000561")]
    public const int XKB_KEY_Armenian_ayb = 0x1000561;

    [NativeTypeName("#define XKB_KEY_Armenian_BEN 0x1000532")]
    public const int XKB_KEY_Armenian_BEN = 0x1000532;

    [NativeTypeName("#define XKB_KEY_Armenian_ben 0x1000562")]
    public const int XKB_KEY_Armenian_ben = 0x1000562;

    [NativeTypeName("#define XKB_KEY_Armenian_GIM 0x1000533")]
    public const int XKB_KEY_Armenian_GIM = 0x1000533;

    [NativeTypeName("#define XKB_KEY_Armenian_gim 0x1000563")]
    public const int XKB_KEY_Armenian_gim = 0x1000563;

    [NativeTypeName("#define XKB_KEY_Armenian_DA 0x1000534")]
    public const int XKB_KEY_Armenian_DA = 0x1000534;

    [NativeTypeName("#define XKB_KEY_Armenian_da 0x1000564")]
    public const int XKB_KEY_Armenian_da = 0x1000564;

    [NativeTypeName("#define XKB_KEY_Armenian_YECH 0x1000535")]
    public const int XKB_KEY_Armenian_YECH = 0x1000535;

    [NativeTypeName("#define XKB_KEY_Armenian_yech 0x1000565")]
    public const int XKB_KEY_Armenian_yech = 0x1000565;

    [NativeTypeName("#define XKB_KEY_Armenian_ZA 0x1000536")]
    public const int XKB_KEY_Armenian_ZA = 0x1000536;

    [NativeTypeName("#define XKB_KEY_Armenian_za 0x1000566")]
    public const int XKB_KEY_Armenian_za = 0x1000566;

    [NativeTypeName("#define XKB_KEY_Armenian_E 0x1000537")]
    public const int XKB_KEY_Armenian_E = 0x1000537;

    [NativeTypeName("#define XKB_KEY_Armenian_e 0x1000567")]
    public const int XKB_KEY_Armenian_e = 0x1000567;

    [NativeTypeName("#define XKB_KEY_Armenian_AT 0x1000538")]
    public const int XKB_KEY_Armenian_AT = 0x1000538;

    [NativeTypeName("#define XKB_KEY_Armenian_at 0x1000568")]
    public const int XKB_KEY_Armenian_at = 0x1000568;

    [NativeTypeName("#define XKB_KEY_Armenian_TO 0x1000539")]
    public const int XKB_KEY_Armenian_TO = 0x1000539;

    [NativeTypeName("#define XKB_KEY_Armenian_to 0x1000569")]
    public const int XKB_KEY_Armenian_to = 0x1000569;

    [NativeTypeName("#define XKB_KEY_Armenian_ZHE 0x100053a")]
    public const int XKB_KEY_Armenian_ZHE = 0x100053a;

    [NativeTypeName("#define XKB_KEY_Armenian_zhe 0x100056a")]
    public const int XKB_KEY_Armenian_zhe = 0x100056a;

    [NativeTypeName("#define XKB_KEY_Armenian_INI 0x100053b")]
    public const int XKB_KEY_Armenian_INI = 0x100053b;

    [NativeTypeName("#define XKB_KEY_Armenian_ini 0x100056b")]
    public const int XKB_KEY_Armenian_ini = 0x100056b;

    [NativeTypeName("#define XKB_KEY_Armenian_LYUN 0x100053c")]
    public const int XKB_KEY_Armenian_LYUN = 0x100053c;

    [NativeTypeName("#define XKB_KEY_Armenian_lyun 0x100056c")]
    public const int XKB_KEY_Armenian_lyun = 0x100056c;

    [NativeTypeName("#define XKB_KEY_Armenian_KHE 0x100053d")]
    public const int XKB_KEY_Armenian_KHE = 0x100053d;

    [NativeTypeName("#define XKB_KEY_Armenian_khe 0x100056d")]
    public const int XKB_KEY_Armenian_khe = 0x100056d;

    [NativeTypeName("#define XKB_KEY_Armenian_TSA 0x100053e")]
    public const int XKB_KEY_Armenian_TSA = 0x100053e;

    [NativeTypeName("#define XKB_KEY_Armenian_tsa 0x100056e")]
    public const int XKB_KEY_Armenian_tsa = 0x100056e;

    [NativeTypeName("#define XKB_KEY_Armenian_KEN 0x100053f")]
    public const int XKB_KEY_Armenian_KEN = 0x100053f;

    [NativeTypeName("#define XKB_KEY_Armenian_ken 0x100056f")]
    public const int XKB_KEY_Armenian_ken = 0x100056f;

    [NativeTypeName("#define XKB_KEY_Armenian_HO 0x1000540")]
    public const int XKB_KEY_Armenian_HO = 0x1000540;

    [NativeTypeName("#define XKB_KEY_Armenian_ho 0x1000570")]
    public const int XKB_KEY_Armenian_ho = 0x1000570;

    [NativeTypeName("#define XKB_KEY_Armenian_DZA 0x1000541")]
    public const int XKB_KEY_Armenian_DZA = 0x1000541;

    [NativeTypeName("#define XKB_KEY_Armenian_dza 0x1000571")]
    public const int XKB_KEY_Armenian_dza = 0x1000571;

    [NativeTypeName("#define XKB_KEY_Armenian_GHAT 0x1000542")]
    public const int XKB_KEY_Armenian_GHAT = 0x1000542;

    [NativeTypeName("#define XKB_KEY_Armenian_ghat 0x1000572")]
    public const int XKB_KEY_Armenian_ghat = 0x1000572;

    [NativeTypeName("#define XKB_KEY_Armenian_TCHE 0x1000543")]
    public const int XKB_KEY_Armenian_TCHE = 0x1000543;

    [NativeTypeName("#define XKB_KEY_Armenian_tche 0x1000573")]
    public const int XKB_KEY_Armenian_tche = 0x1000573;

    [NativeTypeName("#define XKB_KEY_Armenian_MEN 0x1000544")]
    public const int XKB_KEY_Armenian_MEN = 0x1000544;

    [NativeTypeName("#define XKB_KEY_Armenian_men 0x1000574")]
    public const int XKB_KEY_Armenian_men = 0x1000574;

    [NativeTypeName("#define XKB_KEY_Armenian_HI 0x1000545")]
    public const int XKB_KEY_Armenian_HI = 0x1000545;

    [NativeTypeName("#define XKB_KEY_Armenian_hi 0x1000575")]
    public const int XKB_KEY_Armenian_hi = 0x1000575;

    [NativeTypeName("#define XKB_KEY_Armenian_NU 0x1000546")]
    public const int XKB_KEY_Armenian_NU = 0x1000546;

    [NativeTypeName("#define XKB_KEY_Armenian_nu 0x1000576")]
    public const int XKB_KEY_Armenian_nu = 0x1000576;

    [NativeTypeName("#define XKB_KEY_Armenian_SHA 0x1000547")]
    public const int XKB_KEY_Armenian_SHA = 0x1000547;

    [NativeTypeName("#define XKB_KEY_Armenian_sha 0x1000577")]
    public const int XKB_KEY_Armenian_sha = 0x1000577;

    [NativeTypeName("#define XKB_KEY_Armenian_VO 0x1000548")]
    public const int XKB_KEY_Armenian_VO = 0x1000548;

    [NativeTypeName("#define XKB_KEY_Armenian_vo 0x1000578")]
    public const int XKB_KEY_Armenian_vo = 0x1000578;

    [NativeTypeName("#define XKB_KEY_Armenian_CHA 0x1000549")]
    public const int XKB_KEY_Armenian_CHA = 0x1000549;

    [NativeTypeName("#define XKB_KEY_Armenian_cha 0x1000579")]
    public const int XKB_KEY_Armenian_cha = 0x1000579;

    [NativeTypeName("#define XKB_KEY_Armenian_PE 0x100054a")]
    public const int XKB_KEY_Armenian_PE = 0x100054a;

    [NativeTypeName("#define XKB_KEY_Armenian_pe 0x100057a")]
    public const int XKB_KEY_Armenian_pe = 0x100057a;

    [NativeTypeName("#define XKB_KEY_Armenian_JE 0x100054b")]
    public const int XKB_KEY_Armenian_JE = 0x100054b;

    [NativeTypeName("#define XKB_KEY_Armenian_je 0x100057b")]
    public const int XKB_KEY_Armenian_je = 0x100057b;

    [NativeTypeName("#define XKB_KEY_Armenian_RA 0x100054c")]
    public const int XKB_KEY_Armenian_RA = 0x100054c;

    [NativeTypeName("#define XKB_KEY_Armenian_ra 0x100057c")]
    public const int XKB_KEY_Armenian_ra = 0x100057c;

    [NativeTypeName("#define XKB_KEY_Armenian_SE 0x100054d")]
    public const int XKB_KEY_Armenian_SE = 0x100054d;

    [NativeTypeName("#define XKB_KEY_Armenian_se 0x100057d")]
    public const int XKB_KEY_Armenian_se = 0x100057d;

    [NativeTypeName("#define XKB_KEY_Armenian_VEV 0x100054e")]
    public const int XKB_KEY_Armenian_VEV = 0x100054e;

    [NativeTypeName("#define XKB_KEY_Armenian_vev 0x100057e")]
    public const int XKB_KEY_Armenian_vev = 0x100057e;

    [NativeTypeName("#define XKB_KEY_Armenian_TYUN 0x100054f")]
    public const int XKB_KEY_Armenian_TYUN = 0x100054f;

    [NativeTypeName("#define XKB_KEY_Armenian_tyun 0x100057f")]
    public const int XKB_KEY_Armenian_tyun = 0x100057f;

    [NativeTypeName("#define XKB_KEY_Armenian_RE 0x1000550")]
    public const int XKB_KEY_Armenian_RE = 0x1000550;

    [NativeTypeName("#define XKB_KEY_Armenian_re 0x1000580")]
    public const int XKB_KEY_Armenian_re = 0x1000580;

    [NativeTypeName("#define XKB_KEY_Armenian_TSO 0x1000551")]
    public const int XKB_KEY_Armenian_TSO = 0x1000551;

    [NativeTypeName("#define XKB_KEY_Armenian_tso 0x1000581")]
    public const int XKB_KEY_Armenian_tso = 0x1000581;

    [NativeTypeName("#define XKB_KEY_Armenian_VYUN 0x1000552")]
    public const int XKB_KEY_Armenian_VYUN = 0x1000552;

    [NativeTypeName("#define XKB_KEY_Armenian_vyun 0x1000582")]
    public const int XKB_KEY_Armenian_vyun = 0x1000582;

    [NativeTypeName("#define XKB_KEY_Armenian_PYUR 0x1000553")]
    public const int XKB_KEY_Armenian_PYUR = 0x1000553;

    [NativeTypeName("#define XKB_KEY_Armenian_pyur 0x1000583")]
    public const int XKB_KEY_Armenian_pyur = 0x1000583;

    [NativeTypeName("#define XKB_KEY_Armenian_KE 0x1000554")]
    public const int XKB_KEY_Armenian_KE = 0x1000554;

    [NativeTypeName("#define XKB_KEY_Armenian_ke 0x1000584")]
    public const int XKB_KEY_Armenian_ke = 0x1000584;

    [NativeTypeName("#define XKB_KEY_Armenian_O 0x1000555")]
    public const int XKB_KEY_Armenian_O = 0x1000555;

    [NativeTypeName("#define XKB_KEY_Armenian_o 0x1000585")]
    public const int XKB_KEY_Armenian_o = 0x1000585;

    [NativeTypeName("#define XKB_KEY_Armenian_FE 0x1000556")]
    public const int XKB_KEY_Armenian_FE = 0x1000556;

    [NativeTypeName("#define XKB_KEY_Armenian_fe 0x1000586")]
    public const int XKB_KEY_Armenian_fe = 0x1000586;

    [NativeTypeName("#define XKB_KEY_Armenian_apostrophe 0x100055a")]
    public const int XKB_KEY_Armenian_apostrophe = 0x100055a;

    [NativeTypeName("#define XKB_KEY_Georgian_an 0x10010d0")]
    public const int XKB_KEY_Georgian_an = 0x10010d0;

    [NativeTypeName("#define XKB_KEY_Georgian_ban 0x10010d1")]
    public const int XKB_KEY_Georgian_ban = 0x10010d1;

    [NativeTypeName("#define XKB_KEY_Georgian_gan 0x10010d2")]
    public const int XKB_KEY_Georgian_gan = 0x10010d2;

    [NativeTypeName("#define XKB_KEY_Georgian_don 0x10010d3")]
    public const int XKB_KEY_Georgian_don = 0x10010d3;

    [NativeTypeName("#define XKB_KEY_Georgian_en 0x10010d4")]
    public const int XKB_KEY_Georgian_en = 0x10010d4;

    [NativeTypeName("#define XKB_KEY_Georgian_vin 0x10010d5")]
    public const int XKB_KEY_Georgian_vin = 0x10010d5;

    [NativeTypeName("#define XKB_KEY_Georgian_zen 0x10010d6")]
    public const int XKB_KEY_Georgian_zen = 0x10010d6;

    [NativeTypeName("#define XKB_KEY_Georgian_tan 0x10010d7")]
    public const int XKB_KEY_Georgian_tan = 0x10010d7;

    [NativeTypeName("#define XKB_KEY_Georgian_in 0x10010d8")]
    public const int XKB_KEY_Georgian_in = 0x10010d8;

    [NativeTypeName("#define XKB_KEY_Georgian_kan 0x10010d9")]
    public const int XKB_KEY_Georgian_kan = 0x10010d9;

    [NativeTypeName("#define XKB_KEY_Georgian_las 0x10010da")]
    public const int XKB_KEY_Georgian_las = 0x10010da;

    [NativeTypeName("#define XKB_KEY_Georgian_man 0x10010db")]
    public const int XKB_KEY_Georgian_man = 0x10010db;

    [NativeTypeName("#define XKB_KEY_Georgian_nar 0x10010dc")]
    public const int XKB_KEY_Georgian_nar = 0x10010dc;

    [NativeTypeName("#define XKB_KEY_Georgian_on 0x10010dd")]
    public const int XKB_KEY_Georgian_on = 0x10010dd;

    [NativeTypeName("#define XKB_KEY_Georgian_par 0x10010de")]
    public const int XKB_KEY_Georgian_par = 0x10010de;

    [NativeTypeName("#define XKB_KEY_Georgian_zhar 0x10010df")]
    public const int XKB_KEY_Georgian_zhar = 0x10010df;

    [NativeTypeName("#define XKB_KEY_Georgian_rae 0x10010e0")]
    public const int XKB_KEY_Georgian_rae = 0x10010e0;

    [NativeTypeName("#define XKB_KEY_Georgian_san 0x10010e1")]
    public const int XKB_KEY_Georgian_san = 0x10010e1;

    [NativeTypeName("#define XKB_KEY_Georgian_tar 0x10010e2")]
    public const int XKB_KEY_Georgian_tar = 0x10010e2;

    [NativeTypeName("#define XKB_KEY_Georgian_un 0x10010e3")]
    public const int XKB_KEY_Georgian_un = 0x10010e3;

    [NativeTypeName("#define XKB_KEY_Georgian_phar 0x10010e4")]
    public const int XKB_KEY_Georgian_phar = 0x10010e4;

    [NativeTypeName("#define XKB_KEY_Georgian_khar 0x10010e5")]
    public const int XKB_KEY_Georgian_khar = 0x10010e5;

    [NativeTypeName("#define XKB_KEY_Georgian_ghan 0x10010e6")]
    public const int XKB_KEY_Georgian_ghan = 0x10010e6;

    [NativeTypeName("#define XKB_KEY_Georgian_qar 0x10010e7")]
    public const int XKB_KEY_Georgian_qar = 0x10010e7;

    [NativeTypeName("#define XKB_KEY_Georgian_shin 0x10010e8")]
    public const int XKB_KEY_Georgian_shin = 0x10010e8;

    [NativeTypeName("#define XKB_KEY_Georgian_chin 0x10010e9")]
    public const int XKB_KEY_Georgian_chin = 0x10010e9;

    [NativeTypeName("#define XKB_KEY_Georgian_can 0x10010ea")]
    public const int XKB_KEY_Georgian_can = 0x10010ea;

    [NativeTypeName("#define XKB_KEY_Georgian_jil 0x10010eb")]
    public const int XKB_KEY_Georgian_jil = 0x10010eb;

    [NativeTypeName("#define XKB_KEY_Georgian_cil 0x10010ec")]
    public const int XKB_KEY_Georgian_cil = 0x10010ec;

    [NativeTypeName("#define XKB_KEY_Georgian_char 0x10010ed")]
    public const int XKB_KEY_Georgian_char = 0x10010ed;

    [NativeTypeName("#define XKB_KEY_Georgian_xan 0x10010ee")]
    public const int XKB_KEY_Georgian_xan = 0x10010ee;

    [NativeTypeName("#define XKB_KEY_Georgian_jhan 0x10010ef")]
    public const int XKB_KEY_Georgian_jhan = 0x10010ef;

    [NativeTypeName("#define XKB_KEY_Georgian_hae 0x10010f0")]
    public const int XKB_KEY_Georgian_hae = 0x10010f0;

    [NativeTypeName("#define XKB_KEY_Georgian_he 0x10010f1")]
    public const int XKB_KEY_Georgian_he = 0x10010f1;

    [NativeTypeName("#define XKB_KEY_Georgian_hie 0x10010f2")]
    public const int XKB_KEY_Georgian_hie = 0x10010f2;

    [NativeTypeName("#define XKB_KEY_Georgian_we 0x10010f3")]
    public const int XKB_KEY_Georgian_we = 0x10010f3;

    [NativeTypeName("#define XKB_KEY_Georgian_har 0x10010f4")]
    public const int XKB_KEY_Georgian_har = 0x10010f4;

    [NativeTypeName("#define XKB_KEY_Georgian_hoe 0x10010f5")]
    public const int XKB_KEY_Georgian_hoe = 0x10010f5;

    [NativeTypeName("#define XKB_KEY_Georgian_fi 0x10010f6")]
    public const int XKB_KEY_Georgian_fi = 0x10010f6;

    [NativeTypeName("#define XKB_KEY_Xabovedot 0x1001e8a")]
    public const int XKB_KEY_Xabovedot = 0x1001e8a;

    [NativeTypeName("#define XKB_KEY_Ibreve 0x100012c")]
    public const int XKB_KEY_Ibreve = 0x100012c;

    [NativeTypeName("#define XKB_KEY_Zstroke 0x10001b5")]
    public const int XKB_KEY_Zstroke = 0x10001b5;

    [NativeTypeName("#define XKB_KEY_Gcaron 0x10001e6")]
    public const int XKB_KEY_Gcaron = 0x10001e6;

    [NativeTypeName("#define XKB_KEY_Ocaron 0x10001d1")]
    public const int XKB_KEY_Ocaron = 0x10001d1;

    [NativeTypeName("#define XKB_KEY_Obarred 0x100019f")]
    public const int XKB_KEY_Obarred = 0x100019f;

    [NativeTypeName("#define XKB_KEY_xabovedot 0x1001e8b")]
    public const int XKB_KEY_xabovedot = 0x1001e8b;

    [NativeTypeName("#define XKB_KEY_ibreve 0x100012d")]
    public const int XKB_KEY_ibreve = 0x100012d;

    [NativeTypeName("#define XKB_KEY_zstroke 0x10001b6")]
    public const int XKB_KEY_zstroke = 0x10001b6;

    [NativeTypeName("#define XKB_KEY_gcaron 0x10001e7")]
    public const int XKB_KEY_gcaron = 0x10001e7;

    [NativeTypeName("#define XKB_KEY_ocaron 0x10001d2")]
    public const int XKB_KEY_ocaron = 0x10001d2;

    [NativeTypeName("#define XKB_KEY_obarred 0x1000275")]
    public const int XKB_KEY_obarred = 0x1000275;

    [NativeTypeName("#define XKB_KEY_SCHWA 0x100018f")]
    public const int XKB_KEY_SCHWA = 0x100018f;

    [NativeTypeName("#define XKB_KEY_schwa 0x1000259")]
    public const int XKB_KEY_schwa = 0x1000259;

    [NativeTypeName("#define XKB_KEY_EZH 0x10001b7")]
    public const int XKB_KEY_EZH = 0x10001b7;

    [NativeTypeName("#define XKB_KEY_ezh 0x1000292")]
    public const int XKB_KEY_ezh = 0x1000292;

    [NativeTypeName("#define XKB_KEY_Lbelowdot 0x1001e36")]
    public const int XKB_KEY_Lbelowdot = 0x1001e36;

    [NativeTypeName("#define XKB_KEY_lbelowdot 0x1001e37")]
    public const int XKB_KEY_lbelowdot = 0x1001e37;

    [NativeTypeName("#define XKB_KEY_Abelowdot 0x1001ea0")]
    public const int XKB_KEY_Abelowdot = 0x1001ea0;

    [NativeTypeName("#define XKB_KEY_abelowdot 0x1001ea1")]
    public const int XKB_KEY_abelowdot = 0x1001ea1;

    [NativeTypeName("#define XKB_KEY_Ahook 0x1001ea2")]
    public const int XKB_KEY_Ahook = 0x1001ea2;

    [NativeTypeName("#define XKB_KEY_ahook 0x1001ea3")]
    public const int XKB_KEY_ahook = 0x1001ea3;

    [NativeTypeName("#define XKB_KEY_Acircumflexacute 0x1001ea4")]
    public const int XKB_KEY_Acircumflexacute = 0x1001ea4;

    [NativeTypeName("#define XKB_KEY_acircumflexacute 0x1001ea5")]
    public const int XKB_KEY_acircumflexacute = 0x1001ea5;

    [NativeTypeName("#define XKB_KEY_Acircumflexgrave 0x1001ea6")]
    public const int XKB_KEY_Acircumflexgrave = 0x1001ea6;

    [NativeTypeName("#define XKB_KEY_acircumflexgrave 0x1001ea7")]
    public const int XKB_KEY_acircumflexgrave = 0x1001ea7;

    [NativeTypeName("#define XKB_KEY_Acircumflexhook 0x1001ea8")]
    public const int XKB_KEY_Acircumflexhook = 0x1001ea8;

    [NativeTypeName("#define XKB_KEY_acircumflexhook 0x1001ea9")]
    public const int XKB_KEY_acircumflexhook = 0x1001ea9;

    [NativeTypeName("#define XKB_KEY_Acircumflextilde 0x1001eaa")]
    public const int XKB_KEY_Acircumflextilde = 0x1001eaa;

    [NativeTypeName("#define XKB_KEY_acircumflextilde 0x1001eab")]
    public const int XKB_KEY_acircumflextilde = 0x1001eab;

    [NativeTypeName("#define XKB_KEY_Acircumflexbelowdot 0x1001eac")]
    public const int XKB_KEY_Acircumflexbelowdot = 0x1001eac;

    [NativeTypeName("#define XKB_KEY_acircumflexbelowdot 0x1001ead")]
    public const int XKB_KEY_acircumflexbelowdot = 0x1001ead;

    [NativeTypeName("#define XKB_KEY_Abreveacute 0x1001eae")]
    public const int XKB_KEY_Abreveacute = 0x1001eae;

    [NativeTypeName("#define XKB_KEY_abreveacute 0x1001eaf")]
    public const int XKB_KEY_abreveacute = 0x1001eaf;

    [NativeTypeName("#define XKB_KEY_Abrevegrave 0x1001eb0")]
    public const int XKB_KEY_Abrevegrave = 0x1001eb0;

    [NativeTypeName("#define XKB_KEY_abrevegrave 0x1001eb1")]
    public const int XKB_KEY_abrevegrave = 0x1001eb1;

    [NativeTypeName("#define XKB_KEY_Abrevehook 0x1001eb2")]
    public const int XKB_KEY_Abrevehook = 0x1001eb2;

    [NativeTypeName("#define XKB_KEY_abrevehook 0x1001eb3")]
    public const int XKB_KEY_abrevehook = 0x1001eb3;

    [NativeTypeName("#define XKB_KEY_Abrevetilde 0x1001eb4")]
    public const int XKB_KEY_Abrevetilde = 0x1001eb4;

    [NativeTypeName("#define XKB_KEY_abrevetilde 0x1001eb5")]
    public const int XKB_KEY_abrevetilde = 0x1001eb5;

    [NativeTypeName("#define XKB_KEY_Abrevebelowdot 0x1001eb6")]
    public const int XKB_KEY_Abrevebelowdot = 0x1001eb6;

    [NativeTypeName("#define XKB_KEY_abrevebelowdot 0x1001eb7")]
    public const int XKB_KEY_abrevebelowdot = 0x1001eb7;

    [NativeTypeName("#define XKB_KEY_Ebelowdot 0x1001eb8")]
    public const int XKB_KEY_Ebelowdot = 0x1001eb8;

    [NativeTypeName("#define XKB_KEY_ebelowdot 0x1001eb9")]
    public const int XKB_KEY_ebelowdot = 0x1001eb9;

    [NativeTypeName("#define XKB_KEY_Ehook 0x1001eba")]
    public const int XKB_KEY_Ehook = 0x1001eba;

    [NativeTypeName("#define XKB_KEY_ehook 0x1001ebb")]
    public const int XKB_KEY_ehook = 0x1001ebb;

    [NativeTypeName("#define XKB_KEY_Etilde 0x1001ebc")]
    public const int XKB_KEY_Etilde = 0x1001ebc;

    [NativeTypeName("#define XKB_KEY_etilde 0x1001ebd")]
    public const int XKB_KEY_etilde = 0x1001ebd;

    [NativeTypeName("#define XKB_KEY_Ecircumflexacute 0x1001ebe")]
    public const int XKB_KEY_Ecircumflexacute = 0x1001ebe;

    [NativeTypeName("#define XKB_KEY_ecircumflexacute 0x1001ebf")]
    public const int XKB_KEY_ecircumflexacute = 0x1001ebf;

    [NativeTypeName("#define XKB_KEY_Ecircumflexgrave 0x1001ec0")]
    public const int XKB_KEY_Ecircumflexgrave = 0x1001ec0;

    [NativeTypeName("#define XKB_KEY_ecircumflexgrave 0x1001ec1")]
    public const int XKB_KEY_ecircumflexgrave = 0x1001ec1;

    [NativeTypeName("#define XKB_KEY_Ecircumflexhook 0x1001ec2")]
    public const int XKB_KEY_Ecircumflexhook = 0x1001ec2;

    [NativeTypeName("#define XKB_KEY_ecircumflexhook 0x1001ec3")]
    public const int XKB_KEY_ecircumflexhook = 0x1001ec3;

    [NativeTypeName("#define XKB_KEY_Ecircumflextilde 0x1001ec4")]
    public const int XKB_KEY_Ecircumflextilde = 0x1001ec4;

    [NativeTypeName("#define XKB_KEY_ecircumflextilde 0x1001ec5")]
    public const int XKB_KEY_ecircumflextilde = 0x1001ec5;

    [NativeTypeName("#define XKB_KEY_Ecircumflexbelowdot 0x1001ec6")]
    public const int XKB_KEY_Ecircumflexbelowdot = 0x1001ec6;

    [NativeTypeName("#define XKB_KEY_ecircumflexbelowdot 0x1001ec7")]
    public const int XKB_KEY_ecircumflexbelowdot = 0x1001ec7;

    [NativeTypeName("#define XKB_KEY_Ihook 0x1001ec8")]
    public const int XKB_KEY_Ihook = 0x1001ec8;

    [NativeTypeName("#define XKB_KEY_ihook 0x1001ec9")]
    public const int XKB_KEY_ihook = 0x1001ec9;

    [NativeTypeName("#define XKB_KEY_Ibelowdot 0x1001eca")]
    public const int XKB_KEY_Ibelowdot = 0x1001eca;

    [NativeTypeName("#define XKB_KEY_ibelowdot 0x1001ecb")]
    public const int XKB_KEY_ibelowdot = 0x1001ecb;

    [NativeTypeName("#define XKB_KEY_Obelowdot 0x1001ecc")]
    public const int XKB_KEY_Obelowdot = 0x1001ecc;

    [NativeTypeName("#define XKB_KEY_obelowdot 0x1001ecd")]
    public const int XKB_KEY_obelowdot = 0x1001ecd;

    [NativeTypeName("#define XKB_KEY_Ohook 0x1001ece")]
    public const int XKB_KEY_Ohook = 0x1001ece;

    [NativeTypeName("#define XKB_KEY_ohook 0x1001ecf")]
    public const int XKB_KEY_ohook = 0x1001ecf;

    [NativeTypeName("#define XKB_KEY_Ocircumflexacute 0x1001ed0")]
    public const int XKB_KEY_Ocircumflexacute = 0x1001ed0;

    [NativeTypeName("#define XKB_KEY_ocircumflexacute 0x1001ed1")]
    public const int XKB_KEY_ocircumflexacute = 0x1001ed1;

    [NativeTypeName("#define XKB_KEY_Ocircumflexgrave 0x1001ed2")]
    public const int XKB_KEY_Ocircumflexgrave = 0x1001ed2;

    [NativeTypeName("#define XKB_KEY_ocircumflexgrave 0x1001ed3")]
    public const int XKB_KEY_ocircumflexgrave = 0x1001ed3;

    [NativeTypeName("#define XKB_KEY_Ocircumflexhook 0x1001ed4")]
    public const int XKB_KEY_Ocircumflexhook = 0x1001ed4;

    [NativeTypeName("#define XKB_KEY_ocircumflexhook 0x1001ed5")]
    public const int XKB_KEY_ocircumflexhook = 0x1001ed5;

    [NativeTypeName("#define XKB_KEY_Ocircumflextilde 0x1001ed6")]
    public const int XKB_KEY_Ocircumflextilde = 0x1001ed6;

    [NativeTypeName("#define XKB_KEY_ocircumflextilde 0x1001ed7")]
    public const int XKB_KEY_ocircumflextilde = 0x1001ed7;

    [NativeTypeName("#define XKB_KEY_Ocircumflexbelowdot 0x1001ed8")]
    public const int XKB_KEY_Ocircumflexbelowdot = 0x1001ed8;

    [NativeTypeName("#define XKB_KEY_ocircumflexbelowdot 0x1001ed9")]
    public const int XKB_KEY_ocircumflexbelowdot = 0x1001ed9;

    [NativeTypeName("#define XKB_KEY_Ohornacute 0x1001eda")]
    public const int XKB_KEY_Ohornacute = 0x1001eda;

    [NativeTypeName("#define XKB_KEY_ohornacute 0x1001edb")]
    public const int XKB_KEY_ohornacute = 0x1001edb;

    [NativeTypeName("#define XKB_KEY_Ohorngrave 0x1001edc")]
    public const int XKB_KEY_Ohorngrave = 0x1001edc;

    [NativeTypeName("#define XKB_KEY_ohorngrave 0x1001edd")]
    public const int XKB_KEY_ohorngrave = 0x1001edd;

    [NativeTypeName("#define XKB_KEY_Ohornhook 0x1001ede")]
    public const int XKB_KEY_Ohornhook = 0x1001ede;

    [NativeTypeName("#define XKB_KEY_ohornhook 0x1001edf")]
    public const int XKB_KEY_ohornhook = 0x1001edf;

    [NativeTypeName("#define XKB_KEY_Ohorntilde 0x1001ee0")]
    public const int XKB_KEY_Ohorntilde = 0x1001ee0;

    [NativeTypeName("#define XKB_KEY_ohorntilde 0x1001ee1")]
    public const int XKB_KEY_ohorntilde = 0x1001ee1;

    [NativeTypeName("#define XKB_KEY_Ohornbelowdot 0x1001ee2")]
    public const int XKB_KEY_Ohornbelowdot = 0x1001ee2;

    [NativeTypeName("#define XKB_KEY_ohornbelowdot 0x1001ee3")]
    public const int XKB_KEY_ohornbelowdot = 0x1001ee3;

    [NativeTypeName("#define XKB_KEY_Ubelowdot 0x1001ee4")]
    public const int XKB_KEY_Ubelowdot = 0x1001ee4;

    [NativeTypeName("#define XKB_KEY_ubelowdot 0x1001ee5")]
    public const int XKB_KEY_ubelowdot = 0x1001ee5;

    [NativeTypeName("#define XKB_KEY_Uhook 0x1001ee6")]
    public const int XKB_KEY_Uhook = 0x1001ee6;

    [NativeTypeName("#define XKB_KEY_uhook 0x1001ee7")]
    public const int XKB_KEY_uhook = 0x1001ee7;

    [NativeTypeName("#define XKB_KEY_Uhornacute 0x1001ee8")]
    public const int XKB_KEY_Uhornacute = 0x1001ee8;

    [NativeTypeName("#define XKB_KEY_uhornacute 0x1001ee9")]
    public const int XKB_KEY_uhornacute = 0x1001ee9;

    [NativeTypeName("#define XKB_KEY_Uhorngrave 0x1001eea")]
    public const int XKB_KEY_Uhorngrave = 0x1001eea;

    [NativeTypeName("#define XKB_KEY_uhorngrave 0x1001eeb")]
    public const int XKB_KEY_uhorngrave = 0x1001eeb;

    [NativeTypeName("#define XKB_KEY_Uhornhook 0x1001eec")]
    public const int XKB_KEY_Uhornhook = 0x1001eec;

    [NativeTypeName("#define XKB_KEY_uhornhook 0x1001eed")]
    public const int XKB_KEY_uhornhook = 0x1001eed;

    [NativeTypeName("#define XKB_KEY_Uhorntilde 0x1001eee")]
    public const int XKB_KEY_Uhorntilde = 0x1001eee;

    [NativeTypeName("#define XKB_KEY_uhorntilde 0x1001eef")]
    public const int XKB_KEY_uhorntilde = 0x1001eef;

    [NativeTypeName("#define XKB_KEY_Uhornbelowdot 0x1001ef0")]
    public const int XKB_KEY_Uhornbelowdot = 0x1001ef0;

    [NativeTypeName("#define XKB_KEY_uhornbelowdot 0x1001ef1")]
    public const int XKB_KEY_uhornbelowdot = 0x1001ef1;

    [NativeTypeName("#define XKB_KEY_Ybelowdot 0x1001ef4")]
    public const int XKB_KEY_Ybelowdot = 0x1001ef4;

    [NativeTypeName("#define XKB_KEY_ybelowdot 0x1001ef5")]
    public const int XKB_KEY_ybelowdot = 0x1001ef5;

    [NativeTypeName("#define XKB_KEY_Yhook 0x1001ef6")]
    public const int XKB_KEY_Yhook = 0x1001ef6;

    [NativeTypeName("#define XKB_KEY_yhook 0x1001ef7")]
    public const int XKB_KEY_yhook = 0x1001ef7;

    [NativeTypeName("#define XKB_KEY_Ytilde 0x1001ef8")]
    public const int XKB_KEY_Ytilde = 0x1001ef8;

    [NativeTypeName("#define XKB_KEY_ytilde 0x1001ef9")]
    public const int XKB_KEY_ytilde = 0x1001ef9;

    [NativeTypeName("#define XKB_KEY_Ohorn 0x10001a0")]
    public const int XKB_KEY_Ohorn = 0x10001a0;

    [NativeTypeName("#define XKB_KEY_ohorn 0x10001a1")]
    public const int XKB_KEY_ohorn = 0x10001a1;

    [NativeTypeName("#define XKB_KEY_Uhorn 0x10001af")]
    public const int XKB_KEY_Uhorn = 0x10001af;

    [NativeTypeName("#define XKB_KEY_uhorn 0x10001b0")]
    public const int XKB_KEY_uhorn = 0x10001b0;

    [NativeTypeName("#define XKB_KEY_combining_tilde 0x1000303")]
    public const int XKB_KEY_combining_tilde = 0x1000303;

    [NativeTypeName("#define XKB_KEY_combining_grave 0x1000300")]
    public const int XKB_KEY_combining_grave = 0x1000300;

    [NativeTypeName("#define XKB_KEY_combining_acute 0x1000301")]
    public const int XKB_KEY_combining_acute = 0x1000301;

    [NativeTypeName("#define XKB_KEY_combining_hook 0x1000309")]
    public const int XKB_KEY_combining_hook = 0x1000309;

    [NativeTypeName("#define XKB_KEY_combining_belowdot 0x1000323")]
    public const int XKB_KEY_combining_belowdot = 0x1000323;

    [NativeTypeName("#define XKB_KEY_EcuSign 0x10020a0")]
    public const int XKB_KEY_EcuSign = 0x10020a0;

    [NativeTypeName("#define XKB_KEY_ColonSign 0x10020a1")]
    public const int XKB_KEY_ColonSign = 0x10020a1;

    [NativeTypeName("#define XKB_KEY_CruzeiroSign 0x10020a2")]
    public const int XKB_KEY_CruzeiroSign = 0x10020a2;

    [NativeTypeName("#define XKB_KEY_FFrancSign 0x10020a3")]
    public const int XKB_KEY_FFrancSign = 0x10020a3;

    [NativeTypeName("#define XKB_KEY_LiraSign 0x10020a4")]
    public const int XKB_KEY_LiraSign = 0x10020a4;

    [NativeTypeName("#define XKB_KEY_MillSign 0x10020a5")]
    public const int XKB_KEY_MillSign = 0x10020a5;

    [NativeTypeName("#define XKB_KEY_NairaSign 0x10020a6")]
    public const int XKB_KEY_NairaSign = 0x10020a6;

    [NativeTypeName("#define XKB_KEY_PesetaSign 0x10020a7")]
    public const int XKB_KEY_PesetaSign = 0x10020a7;

    [NativeTypeName("#define XKB_KEY_RupeeSign 0x10020a8")]
    public const int XKB_KEY_RupeeSign = 0x10020a8;

    [NativeTypeName("#define XKB_KEY_WonSign 0x10020a9")]
    public const int XKB_KEY_WonSign = 0x10020a9;

    [NativeTypeName("#define XKB_KEY_NewSheqelSign 0x10020aa")]
    public const int XKB_KEY_NewSheqelSign = 0x10020aa;

    [NativeTypeName("#define XKB_KEY_DongSign 0x10020ab")]
    public const int XKB_KEY_DongSign = 0x10020ab;

    [NativeTypeName("#define XKB_KEY_EuroSign 0x20ac")]
    public const int XKB_KEY_EuroSign = 0x20ac;

    [NativeTypeName("#define XKB_KEY_zerosuperior 0x1002070")]
    public const int XKB_KEY_zerosuperior = 0x1002070;

    [NativeTypeName("#define XKB_KEY_foursuperior 0x1002074")]
    public const int XKB_KEY_foursuperior = 0x1002074;

    [NativeTypeName("#define XKB_KEY_fivesuperior 0x1002075")]
    public const int XKB_KEY_fivesuperior = 0x1002075;

    [NativeTypeName("#define XKB_KEY_sixsuperior 0x1002076")]
    public const int XKB_KEY_sixsuperior = 0x1002076;

    [NativeTypeName("#define XKB_KEY_sevensuperior 0x1002077")]
    public const int XKB_KEY_sevensuperior = 0x1002077;

    [NativeTypeName("#define XKB_KEY_eightsuperior 0x1002078")]
    public const int XKB_KEY_eightsuperior = 0x1002078;

    [NativeTypeName("#define XKB_KEY_ninesuperior 0x1002079")]
    public const int XKB_KEY_ninesuperior = 0x1002079;

    [NativeTypeName("#define XKB_KEY_zerosubscript 0x1002080")]
    public const int XKB_KEY_zerosubscript = 0x1002080;

    [NativeTypeName("#define XKB_KEY_onesubscript 0x1002081")]
    public const int XKB_KEY_onesubscript = 0x1002081;

    [NativeTypeName("#define XKB_KEY_twosubscript 0x1002082")]
    public const int XKB_KEY_twosubscript = 0x1002082;

    [NativeTypeName("#define XKB_KEY_threesubscript 0x1002083")]
    public const int XKB_KEY_threesubscript = 0x1002083;

    [NativeTypeName("#define XKB_KEY_foursubscript 0x1002084")]
    public const int XKB_KEY_foursubscript = 0x1002084;

    [NativeTypeName("#define XKB_KEY_fivesubscript 0x1002085")]
    public const int XKB_KEY_fivesubscript = 0x1002085;

    [NativeTypeName("#define XKB_KEY_sixsubscript 0x1002086")]
    public const int XKB_KEY_sixsubscript = 0x1002086;

    [NativeTypeName("#define XKB_KEY_sevensubscript 0x1002087")]
    public const int XKB_KEY_sevensubscript = 0x1002087;

    [NativeTypeName("#define XKB_KEY_eightsubscript 0x1002088")]
    public const int XKB_KEY_eightsubscript = 0x1002088;

    [NativeTypeName("#define XKB_KEY_ninesubscript 0x1002089")]
    public const int XKB_KEY_ninesubscript = 0x1002089;

    [NativeTypeName("#define XKB_KEY_partdifferential 0x1002202")]
    public const int XKB_KEY_partdifferential = 0x1002202;

    [NativeTypeName("#define XKB_KEY_emptyset 0x1002205")]
    public const int XKB_KEY_emptyset = 0x1002205;

    [NativeTypeName("#define XKB_KEY_elementof 0x1002208")]
    public const int XKB_KEY_elementof = 0x1002208;

    [NativeTypeName("#define XKB_KEY_notelementof 0x1002209")]
    public const int XKB_KEY_notelementof = 0x1002209;

    [NativeTypeName("#define XKB_KEY_containsas 0x100220B")]
    public const int XKB_KEY_containsas = 0x100220B;

    [NativeTypeName("#define XKB_KEY_squareroot 0x100221A")]
    public const int XKB_KEY_squareroot = 0x100221A;

    [NativeTypeName("#define XKB_KEY_cuberoot 0x100221B")]
    public const int XKB_KEY_cuberoot = 0x100221B;

    [NativeTypeName("#define XKB_KEY_fourthroot 0x100221C")]
    public const int XKB_KEY_fourthroot = 0x100221C;

    [NativeTypeName("#define XKB_KEY_dintegral 0x100222C")]
    public const int XKB_KEY_dintegral = 0x100222C;

    [NativeTypeName("#define XKB_KEY_tintegral 0x100222D")]
    public const int XKB_KEY_tintegral = 0x100222D;

    [NativeTypeName("#define XKB_KEY_because 0x1002235")]
    public const int XKB_KEY_because = 0x1002235;

    [NativeTypeName("#define XKB_KEY_approxeq 0x1002248")]
    public const int XKB_KEY_approxeq = 0x1002248;

    [NativeTypeName("#define XKB_KEY_notapproxeq 0x1002247")]
    public const int XKB_KEY_notapproxeq = 0x1002247;

    [NativeTypeName("#define XKB_KEY_notidentical 0x1002262")]
    public const int XKB_KEY_notidentical = 0x1002262;

    [NativeTypeName("#define XKB_KEY_stricteq 0x1002263")]
    public const int XKB_KEY_stricteq = 0x1002263;

    [NativeTypeName("#define XKB_KEY_braille_dot_1 0xfff1")]
    public const int XKB_KEY_braille_dot_1 = 0xfff1;

    [NativeTypeName("#define XKB_KEY_braille_dot_2 0xfff2")]
    public const int XKB_KEY_braille_dot_2 = 0xfff2;

    [NativeTypeName("#define XKB_KEY_braille_dot_3 0xfff3")]
    public const int XKB_KEY_braille_dot_3 = 0xfff3;

    [NativeTypeName("#define XKB_KEY_braille_dot_4 0xfff4")]
    public const int XKB_KEY_braille_dot_4 = 0xfff4;

    [NativeTypeName("#define XKB_KEY_braille_dot_5 0xfff5")]
    public const int XKB_KEY_braille_dot_5 = 0xfff5;

    [NativeTypeName("#define XKB_KEY_braille_dot_6 0xfff6")]
    public const int XKB_KEY_braille_dot_6 = 0xfff6;

    [NativeTypeName("#define XKB_KEY_braille_dot_7 0xfff7")]
    public const int XKB_KEY_braille_dot_7 = 0xfff7;

    [NativeTypeName("#define XKB_KEY_braille_dot_8 0xfff8")]
    public const int XKB_KEY_braille_dot_8 = 0xfff8;

    [NativeTypeName("#define XKB_KEY_braille_dot_9 0xfff9")]
    public const int XKB_KEY_braille_dot_9 = 0xfff9;

    [NativeTypeName("#define XKB_KEY_braille_dot_10 0xfffa")]
    public const int XKB_KEY_braille_dot_10 = 0xfffa;

    [NativeTypeName("#define XKB_KEY_braille_blank 0x1002800")]
    public const int XKB_KEY_braille_blank = 0x1002800;

    [NativeTypeName("#define XKB_KEY_braille_dots_1 0x1002801")]
    public const int XKB_KEY_braille_dots_1 = 0x1002801;

    [NativeTypeName("#define XKB_KEY_braille_dots_2 0x1002802")]
    public const int XKB_KEY_braille_dots_2 = 0x1002802;

    [NativeTypeName("#define XKB_KEY_braille_dots_12 0x1002803")]
    public const int XKB_KEY_braille_dots_12 = 0x1002803;

    [NativeTypeName("#define XKB_KEY_braille_dots_3 0x1002804")]
    public const int XKB_KEY_braille_dots_3 = 0x1002804;

    [NativeTypeName("#define XKB_KEY_braille_dots_13 0x1002805")]
    public const int XKB_KEY_braille_dots_13 = 0x1002805;

    [NativeTypeName("#define XKB_KEY_braille_dots_23 0x1002806")]
    public const int XKB_KEY_braille_dots_23 = 0x1002806;

    [NativeTypeName("#define XKB_KEY_braille_dots_123 0x1002807")]
    public const int XKB_KEY_braille_dots_123 = 0x1002807;

    [NativeTypeName("#define XKB_KEY_braille_dots_4 0x1002808")]
    public const int XKB_KEY_braille_dots_4 = 0x1002808;

    [NativeTypeName("#define XKB_KEY_braille_dots_14 0x1002809")]
    public const int XKB_KEY_braille_dots_14 = 0x1002809;

    [NativeTypeName("#define XKB_KEY_braille_dots_24 0x100280a")]
    public const int XKB_KEY_braille_dots_24 = 0x100280a;

    [NativeTypeName("#define XKB_KEY_braille_dots_124 0x100280b")]
    public const int XKB_KEY_braille_dots_124 = 0x100280b;

    [NativeTypeName("#define XKB_KEY_braille_dots_34 0x100280c")]
    public const int XKB_KEY_braille_dots_34 = 0x100280c;

    [NativeTypeName("#define XKB_KEY_braille_dots_134 0x100280d")]
    public const int XKB_KEY_braille_dots_134 = 0x100280d;

    [NativeTypeName("#define XKB_KEY_braille_dots_234 0x100280e")]
    public const int XKB_KEY_braille_dots_234 = 0x100280e;

    [NativeTypeName("#define XKB_KEY_braille_dots_1234 0x100280f")]
    public const int XKB_KEY_braille_dots_1234 = 0x100280f;

    [NativeTypeName("#define XKB_KEY_braille_dots_5 0x1002810")]
    public const int XKB_KEY_braille_dots_5 = 0x1002810;

    [NativeTypeName("#define XKB_KEY_braille_dots_15 0x1002811")]
    public const int XKB_KEY_braille_dots_15 = 0x1002811;

    [NativeTypeName("#define XKB_KEY_braille_dots_25 0x1002812")]
    public const int XKB_KEY_braille_dots_25 = 0x1002812;

    [NativeTypeName("#define XKB_KEY_braille_dots_125 0x1002813")]
    public const int XKB_KEY_braille_dots_125 = 0x1002813;

    [NativeTypeName("#define XKB_KEY_braille_dots_35 0x1002814")]
    public const int XKB_KEY_braille_dots_35 = 0x1002814;

    [NativeTypeName("#define XKB_KEY_braille_dots_135 0x1002815")]
    public const int XKB_KEY_braille_dots_135 = 0x1002815;

    [NativeTypeName("#define XKB_KEY_braille_dots_235 0x1002816")]
    public const int XKB_KEY_braille_dots_235 = 0x1002816;

    [NativeTypeName("#define XKB_KEY_braille_dots_1235 0x1002817")]
    public const int XKB_KEY_braille_dots_1235 = 0x1002817;

    [NativeTypeName("#define XKB_KEY_braille_dots_45 0x1002818")]
    public const int XKB_KEY_braille_dots_45 = 0x1002818;

    [NativeTypeName("#define XKB_KEY_braille_dots_145 0x1002819")]
    public const int XKB_KEY_braille_dots_145 = 0x1002819;

    [NativeTypeName("#define XKB_KEY_braille_dots_245 0x100281a")]
    public const int XKB_KEY_braille_dots_245 = 0x100281a;

    [NativeTypeName("#define XKB_KEY_braille_dots_1245 0x100281b")]
    public const int XKB_KEY_braille_dots_1245 = 0x100281b;

    [NativeTypeName("#define XKB_KEY_braille_dots_345 0x100281c")]
    public const int XKB_KEY_braille_dots_345 = 0x100281c;

    [NativeTypeName("#define XKB_KEY_braille_dots_1345 0x100281d")]
    public const int XKB_KEY_braille_dots_1345 = 0x100281d;

    [NativeTypeName("#define XKB_KEY_braille_dots_2345 0x100281e")]
    public const int XKB_KEY_braille_dots_2345 = 0x100281e;

    [NativeTypeName("#define XKB_KEY_braille_dots_12345 0x100281f")]
    public const int XKB_KEY_braille_dots_12345 = 0x100281f;

    [NativeTypeName("#define XKB_KEY_braille_dots_6 0x1002820")]
    public const int XKB_KEY_braille_dots_6 = 0x1002820;

    [NativeTypeName("#define XKB_KEY_braille_dots_16 0x1002821")]
    public const int XKB_KEY_braille_dots_16 = 0x1002821;

    [NativeTypeName("#define XKB_KEY_braille_dots_26 0x1002822")]
    public const int XKB_KEY_braille_dots_26 = 0x1002822;

    [NativeTypeName("#define XKB_KEY_braille_dots_126 0x1002823")]
    public const int XKB_KEY_braille_dots_126 = 0x1002823;

    [NativeTypeName("#define XKB_KEY_braille_dots_36 0x1002824")]
    public const int XKB_KEY_braille_dots_36 = 0x1002824;

    [NativeTypeName("#define XKB_KEY_braille_dots_136 0x1002825")]
    public const int XKB_KEY_braille_dots_136 = 0x1002825;

    [NativeTypeName("#define XKB_KEY_braille_dots_236 0x1002826")]
    public const int XKB_KEY_braille_dots_236 = 0x1002826;

    [NativeTypeName("#define XKB_KEY_braille_dots_1236 0x1002827")]
    public const int XKB_KEY_braille_dots_1236 = 0x1002827;

    [NativeTypeName("#define XKB_KEY_braille_dots_46 0x1002828")]
    public const int XKB_KEY_braille_dots_46 = 0x1002828;

    [NativeTypeName("#define XKB_KEY_braille_dots_146 0x1002829")]
    public const int XKB_KEY_braille_dots_146 = 0x1002829;

    [NativeTypeName("#define XKB_KEY_braille_dots_246 0x100282a")]
    public const int XKB_KEY_braille_dots_246 = 0x100282a;

    [NativeTypeName("#define XKB_KEY_braille_dots_1246 0x100282b")]
    public const int XKB_KEY_braille_dots_1246 = 0x100282b;

    [NativeTypeName("#define XKB_KEY_braille_dots_346 0x100282c")]
    public const int XKB_KEY_braille_dots_346 = 0x100282c;

    [NativeTypeName("#define XKB_KEY_braille_dots_1346 0x100282d")]
    public const int XKB_KEY_braille_dots_1346 = 0x100282d;

    [NativeTypeName("#define XKB_KEY_braille_dots_2346 0x100282e")]
    public const int XKB_KEY_braille_dots_2346 = 0x100282e;

    [NativeTypeName("#define XKB_KEY_braille_dots_12346 0x100282f")]
    public const int XKB_KEY_braille_dots_12346 = 0x100282f;

    [NativeTypeName("#define XKB_KEY_braille_dots_56 0x1002830")]
    public const int XKB_KEY_braille_dots_56 = 0x1002830;

    [NativeTypeName("#define XKB_KEY_braille_dots_156 0x1002831")]
    public const int XKB_KEY_braille_dots_156 = 0x1002831;

    [NativeTypeName("#define XKB_KEY_braille_dots_256 0x1002832")]
    public const int XKB_KEY_braille_dots_256 = 0x1002832;

    [NativeTypeName("#define XKB_KEY_braille_dots_1256 0x1002833")]
    public const int XKB_KEY_braille_dots_1256 = 0x1002833;

    [NativeTypeName("#define XKB_KEY_braille_dots_356 0x1002834")]
    public const int XKB_KEY_braille_dots_356 = 0x1002834;

    [NativeTypeName("#define XKB_KEY_braille_dots_1356 0x1002835")]
    public const int XKB_KEY_braille_dots_1356 = 0x1002835;

    [NativeTypeName("#define XKB_KEY_braille_dots_2356 0x1002836")]
    public const int XKB_KEY_braille_dots_2356 = 0x1002836;

    [NativeTypeName("#define XKB_KEY_braille_dots_12356 0x1002837")]
    public const int XKB_KEY_braille_dots_12356 = 0x1002837;

    [NativeTypeName("#define XKB_KEY_braille_dots_456 0x1002838")]
    public const int XKB_KEY_braille_dots_456 = 0x1002838;

    [NativeTypeName("#define XKB_KEY_braille_dots_1456 0x1002839")]
    public const int XKB_KEY_braille_dots_1456 = 0x1002839;

    [NativeTypeName("#define XKB_KEY_braille_dots_2456 0x100283a")]
    public const int XKB_KEY_braille_dots_2456 = 0x100283a;

    [NativeTypeName("#define XKB_KEY_braille_dots_12456 0x100283b")]
    public const int XKB_KEY_braille_dots_12456 = 0x100283b;

    [NativeTypeName("#define XKB_KEY_braille_dots_3456 0x100283c")]
    public const int XKB_KEY_braille_dots_3456 = 0x100283c;

    [NativeTypeName("#define XKB_KEY_braille_dots_13456 0x100283d")]
    public const int XKB_KEY_braille_dots_13456 = 0x100283d;

    [NativeTypeName("#define XKB_KEY_braille_dots_23456 0x100283e")]
    public const int XKB_KEY_braille_dots_23456 = 0x100283e;

    [NativeTypeName("#define XKB_KEY_braille_dots_123456 0x100283f")]
    public const int XKB_KEY_braille_dots_123456 = 0x100283f;

    [NativeTypeName("#define XKB_KEY_braille_dots_7 0x1002840")]
    public const int XKB_KEY_braille_dots_7 = 0x1002840;

    [NativeTypeName("#define XKB_KEY_braille_dots_17 0x1002841")]
    public const int XKB_KEY_braille_dots_17 = 0x1002841;

    [NativeTypeName("#define XKB_KEY_braille_dots_27 0x1002842")]
    public const int XKB_KEY_braille_dots_27 = 0x1002842;

    [NativeTypeName("#define XKB_KEY_braille_dots_127 0x1002843")]
    public const int XKB_KEY_braille_dots_127 = 0x1002843;

    [NativeTypeName("#define XKB_KEY_braille_dots_37 0x1002844")]
    public const int XKB_KEY_braille_dots_37 = 0x1002844;

    [NativeTypeName("#define XKB_KEY_braille_dots_137 0x1002845")]
    public const int XKB_KEY_braille_dots_137 = 0x1002845;

    [NativeTypeName("#define XKB_KEY_braille_dots_237 0x1002846")]
    public const int XKB_KEY_braille_dots_237 = 0x1002846;

    [NativeTypeName("#define XKB_KEY_braille_dots_1237 0x1002847")]
    public const int XKB_KEY_braille_dots_1237 = 0x1002847;

    [NativeTypeName("#define XKB_KEY_braille_dots_47 0x1002848")]
    public const int XKB_KEY_braille_dots_47 = 0x1002848;

    [NativeTypeName("#define XKB_KEY_braille_dots_147 0x1002849")]
    public const int XKB_KEY_braille_dots_147 = 0x1002849;

    [NativeTypeName("#define XKB_KEY_braille_dots_247 0x100284a")]
    public const int XKB_KEY_braille_dots_247 = 0x100284a;

    [NativeTypeName("#define XKB_KEY_braille_dots_1247 0x100284b")]
    public const int XKB_KEY_braille_dots_1247 = 0x100284b;

    [NativeTypeName("#define XKB_KEY_braille_dots_347 0x100284c")]
    public const int XKB_KEY_braille_dots_347 = 0x100284c;

    [NativeTypeName("#define XKB_KEY_braille_dots_1347 0x100284d")]
    public const int XKB_KEY_braille_dots_1347 = 0x100284d;

    [NativeTypeName("#define XKB_KEY_braille_dots_2347 0x100284e")]
    public const int XKB_KEY_braille_dots_2347 = 0x100284e;

    [NativeTypeName("#define XKB_KEY_braille_dots_12347 0x100284f")]
    public const int XKB_KEY_braille_dots_12347 = 0x100284f;

    [NativeTypeName("#define XKB_KEY_braille_dots_57 0x1002850")]
    public const int XKB_KEY_braille_dots_57 = 0x1002850;

    [NativeTypeName("#define XKB_KEY_braille_dots_157 0x1002851")]
    public const int XKB_KEY_braille_dots_157 = 0x1002851;

    [NativeTypeName("#define XKB_KEY_braille_dots_257 0x1002852")]
    public const int XKB_KEY_braille_dots_257 = 0x1002852;

    [NativeTypeName("#define XKB_KEY_braille_dots_1257 0x1002853")]
    public const int XKB_KEY_braille_dots_1257 = 0x1002853;

    [NativeTypeName("#define XKB_KEY_braille_dots_357 0x1002854")]
    public const int XKB_KEY_braille_dots_357 = 0x1002854;

    [NativeTypeName("#define XKB_KEY_braille_dots_1357 0x1002855")]
    public const int XKB_KEY_braille_dots_1357 = 0x1002855;

    [NativeTypeName("#define XKB_KEY_braille_dots_2357 0x1002856")]
    public const int XKB_KEY_braille_dots_2357 = 0x1002856;

    [NativeTypeName("#define XKB_KEY_braille_dots_12357 0x1002857")]
    public const int XKB_KEY_braille_dots_12357 = 0x1002857;

    [NativeTypeName("#define XKB_KEY_braille_dots_457 0x1002858")]
    public const int XKB_KEY_braille_dots_457 = 0x1002858;

    [NativeTypeName("#define XKB_KEY_braille_dots_1457 0x1002859")]
    public const int XKB_KEY_braille_dots_1457 = 0x1002859;

    [NativeTypeName("#define XKB_KEY_braille_dots_2457 0x100285a")]
    public const int XKB_KEY_braille_dots_2457 = 0x100285a;

    [NativeTypeName("#define XKB_KEY_braille_dots_12457 0x100285b")]
    public const int XKB_KEY_braille_dots_12457 = 0x100285b;

    [NativeTypeName("#define XKB_KEY_braille_dots_3457 0x100285c")]
    public const int XKB_KEY_braille_dots_3457 = 0x100285c;

    [NativeTypeName("#define XKB_KEY_braille_dots_13457 0x100285d")]
    public const int XKB_KEY_braille_dots_13457 = 0x100285d;

    [NativeTypeName("#define XKB_KEY_braille_dots_23457 0x100285e")]
    public const int XKB_KEY_braille_dots_23457 = 0x100285e;

    [NativeTypeName("#define XKB_KEY_braille_dots_123457 0x100285f")]
    public const int XKB_KEY_braille_dots_123457 = 0x100285f;

    [NativeTypeName("#define XKB_KEY_braille_dots_67 0x1002860")]
    public const int XKB_KEY_braille_dots_67 = 0x1002860;

    [NativeTypeName("#define XKB_KEY_braille_dots_167 0x1002861")]
    public const int XKB_KEY_braille_dots_167 = 0x1002861;

    [NativeTypeName("#define XKB_KEY_braille_dots_267 0x1002862")]
    public const int XKB_KEY_braille_dots_267 = 0x1002862;

    [NativeTypeName("#define XKB_KEY_braille_dots_1267 0x1002863")]
    public const int XKB_KEY_braille_dots_1267 = 0x1002863;

    [NativeTypeName("#define XKB_KEY_braille_dots_367 0x1002864")]
    public const int XKB_KEY_braille_dots_367 = 0x1002864;

    [NativeTypeName("#define XKB_KEY_braille_dots_1367 0x1002865")]
    public const int XKB_KEY_braille_dots_1367 = 0x1002865;

    [NativeTypeName("#define XKB_KEY_braille_dots_2367 0x1002866")]
    public const int XKB_KEY_braille_dots_2367 = 0x1002866;

    [NativeTypeName("#define XKB_KEY_braille_dots_12367 0x1002867")]
    public const int XKB_KEY_braille_dots_12367 = 0x1002867;

    [NativeTypeName("#define XKB_KEY_braille_dots_467 0x1002868")]
    public const int XKB_KEY_braille_dots_467 = 0x1002868;

    [NativeTypeName("#define XKB_KEY_braille_dots_1467 0x1002869")]
    public const int XKB_KEY_braille_dots_1467 = 0x1002869;

    [NativeTypeName("#define XKB_KEY_braille_dots_2467 0x100286a")]
    public const int XKB_KEY_braille_dots_2467 = 0x100286a;

    [NativeTypeName("#define XKB_KEY_braille_dots_12467 0x100286b")]
    public const int XKB_KEY_braille_dots_12467 = 0x100286b;

    [NativeTypeName("#define XKB_KEY_braille_dots_3467 0x100286c")]
    public const int XKB_KEY_braille_dots_3467 = 0x100286c;

    [NativeTypeName("#define XKB_KEY_braille_dots_13467 0x100286d")]
    public const int XKB_KEY_braille_dots_13467 = 0x100286d;

    [NativeTypeName("#define XKB_KEY_braille_dots_23467 0x100286e")]
    public const int XKB_KEY_braille_dots_23467 = 0x100286e;

    [NativeTypeName("#define XKB_KEY_braille_dots_123467 0x100286f")]
    public const int XKB_KEY_braille_dots_123467 = 0x100286f;

    [NativeTypeName("#define XKB_KEY_braille_dots_567 0x1002870")]
    public const int XKB_KEY_braille_dots_567 = 0x1002870;

    [NativeTypeName("#define XKB_KEY_braille_dots_1567 0x1002871")]
    public const int XKB_KEY_braille_dots_1567 = 0x1002871;

    [NativeTypeName("#define XKB_KEY_braille_dots_2567 0x1002872")]
    public const int XKB_KEY_braille_dots_2567 = 0x1002872;

    [NativeTypeName("#define XKB_KEY_braille_dots_12567 0x1002873")]
    public const int XKB_KEY_braille_dots_12567 = 0x1002873;

    [NativeTypeName("#define XKB_KEY_braille_dots_3567 0x1002874")]
    public const int XKB_KEY_braille_dots_3567 = 0x1002874;

    [NativeTypeName("#define XKB_KEY_braille_dots_13567 0x1002875")]
    public const int XKB_KEY_braille_dots_13567 = 0x1002875;

    [NativeTypeName("#define XKB_KEY_braille_dots_23567 0x1002876")]
    public const int XKB_KEY_braille_dots_23567 = 0x1002876;

    [NativeTypeName("#define XKB_KEY_braille_dots_123567 0x1002877")]
    public const int XKB_KEY_braille_dots_123567 = 0x1002877;

    [NativeTypeName("#define XKB_KEY_braille_dots_4567 0x1002878")]
    public const int XKB_KEY_braille_dots_4567 = 0x1002878;

    [NativeTypeName("#define XKB_KEY_braille_dots_14567 0x1002879")]
    public const int XKB_KEY_braille_dots_14567 = 0x1002879;

    [NativeTypeName("#define XKB_KEY_braille_dots_24567 0x100287a")]
    public const int XKB_KEY_braille_dots_24567 = 0x100287a;

    [NativeTypeName("#define XKB_KEY_braille_dots_124567 0x100287b")]
    public const int XKB_KEY_braille_dots_124567 = 0x100287b;

    [NativeTypeName("#define XKB_KEY_braille_dots_34567 0x100287c")]
    public const int XKB_KEY_braille_dots_34567 = 0x100287c;

    [NativeTypeName("#define XKB_KEY_braille_dots_134567 0x100287d")]
    public const int XKB_KEY_braille_dots_134567 = 0x100287d;

    [NativeTypeName("#define XKB_KEY_braille_dots_234567 0x100287e")]
    public const int XKB_KEY_braille_dots_234567 = 0x100287e;

    [NativeTypeName("#define XKB_KEY_braille_dots_1234567 0x100287f")]
    public const int XKB_KEY_braille_dots_1234567 = 0x100287f;

    [NativeTypeName("#define XKB_KEY_braille_dots_8 0x1002880")]
    public const int XKB_KEY_braille_dots_8 = 0x1002880;

    [NativeTypeName("#define XKB_KEY_braille_dots_18 0x1002881")]
    public const int XKB_KEY_braille_dots_18 = 0x1002881;

    [NativeTypeName("#define XKB_KEY_braille_dots_28 0x1002882")]
    public const int XKB_KEY_braille_dots_28 = 0x1002882;

    [NativeTypeName("#define XKB_KEY_braille_dots_128 0x1002883")]
    public const int XKB_KEY_braille_dots_128 = 0x1002883;

    [NativeTypeName("#define XKB_KEY_braille_dots_38 0x1002884")]
    public const int XKB_KEY_braille_dots_38 = 0x1002884;

    [NativeTypeName("#define XKB_KEY_braille_dots_138 0x1002885")]
    public const int XKB_KEY_braille_dots_138 = 0x1002885;

    [NativeTypeName("#define XKB_KEY_braille_dots_238 0x1002886")]
    public const int XKB_KEY_braille_dots_238 = 0x1002886;

    [NativeTypeName("#define XKB_KEY_braille_dots_1238 0x1002887")]
    public const int XKB_KEY_braille_dots_1238 = 0x1002887;

    [NativeTypeName("#define XKB_KEY_braille_dots_48 0x1002888")]
    public const int XKB_KEY_braille_dots_48 = 0x1002888;

    [NativeTypeName("#define XKB_KEY_braille_dots_148 0x1002889")]
    public const int XKB_KEY_braille_dots_148 = 0x1002889;

    [NativeTypeName("#define XKB_KEY_braille_dots_248 0x100288a")]
    public const int XKB_KEY_braille_dots_248 = 0x100288a;

    [NativeTypeName("#define XKB_KEY_braille_dots_1248 0x100288b")]
    public const int XKB_KEY_braille_dots_1248 = 0x100288b;

    [NativeTypeName("#define XKB_KEY_braille_dots_348 0x100288c")]
    public const int XKB_KEY_braille_dots_348 = 0x100288c;

    [NativeTypeName("#define XKB_KEY_braille_dots_1348 0x100288d")]
    public const int XKB_KEY_braille_dots_1348 = 0x100288d;

    [NativeTypeName("#define XKB_KEY_braille_dots_2348 0x100288e")]
    public const int XKB_KEY_braille_dots_2348 = 0x100288e;

    [NativeTypeName("#define XKB_KEY_braille_dots_12348 0x100288f")]
    public const int XKB_KEY_braille_dots_12348 = 0x100288f;

    [NativeTypeName("#define XKB_KEY_braille_dots_58 0x1002890")]
    public const int XKB_KEY_braille_dots_58 = 0x1002890;

    [NativeTypeName("#define XKB_KEY_braille_dots_158 0x1002891")]
    public const int XKB_KEY_braille_dots_158 = 0x1002891;

    [NativeTypeName("#define XKB_KEY_braille_dots_258 0x1002892")]
    public const int XKB_KEY_braille_dots_258 = 0x1002892;

    [NativeTypeName("#define XKB_KEY_braille_dots_1258 0x1002893")]
    public const int XKB_KEY_braille_dots_1258 = 0x1002893;

    [NativeTypeName("#define XKB_KEY_braille_dots_358 0x1002894")]
    public const int XKB_KEY_braille_dots_358 = 0x1002894;

    [NativeTypeName("#define XKB_KEY_braille_dots_1358 0x1002895")]
    public const int XKB_KEY_braille_dots_1358 = 0x1002895;

    [NativeTypeName("#define XKB_KEY_braille_dots_2358 0x1002896")]
    public const int XKB_KEY_braille_dots_2358 = 0x1002896;

    [NativeTypeName("#define XKB_KEY_braille_dots_12358 0x1002897")]
    public const int XKB_KEY_braille_dots_12358 = 0x1002897;

    [NativeTypeName("#define XKB_KEY_braille_dots_458 0x1002898")]
    public const int XKB_KEY_braille_dots_458 = 0x1002898;

    [NativeTypeName("#define XKB_KEY_braille_dots_1458 0x1002899")]
    public const int XKB_KEY_braille_dots_1458 = 0x1002899;

    [NativeTypeName("#define XKB_KEY_braille_dots_2458 0x100289a")]
    public const int XKB_KEY_braille_dots_2458 = 0x100289a;

    [NativeTypeName("#define XKB_KEY_braille_dots_12458 0x100289b")]
    public const int XKB_KEY_braille_dots_12458 = 0x100289b;

    [NativeTypeName("#define XKB_KEY_braille_dots_3458 0x100289c")]
    public const int XKB_KEY_braille_dots_3458 = 0x100289c;

    [NativeTypeName("#define XKB_KEY_braille_dots_13458 0x100289d")]
    public const int XKB_KEY_braille_dots_13458 = 0x100289d;

    [NativeTypeName("#define XKB_KEY_braille_dots_23458 0x100289e")]
    public const int XKB_KEY_braille_dots_23458 = 0x100289e;

    [NativeTypeName("#define XKB_KEY_braille_dots_123458 0x100289f")]
    public const int XKB_KEY_braille_dots_123458 = 0x100289f;

    [NativeTypeName("#define XKB_KEY_braille_dots_68 0x10028a0")]
    public const int XKB_KEY_braille_dots_68 = 0x10028a0;

    [NativeTypeName("#define XKB_KEY_braille_dots_168 0x10028a1")]
    public const int XKB_KEY_braille_dots_168 = 0x10028a1;

    [NativeTypeName("#define XKB_KEY_braille_dots_268 0x10028a2")]
    public const int XKB_KEY_braille_dots_268 = 0x10028a2;

    [NativeTypeName("#define XKB_KEY_braille_dots_1268 0x10028a3")]
    public const int XKB_KEY_braille_dots_1268 = 0x10028a3;

    [NativeTypeName("#define XKB_KEY_braille_dots_368 0x10028a4")]
    public const int XKB_KEY_braille_dots_368 = 0x10028a4;

    [NativeTypeName("#define XKB_KEY_braille_dots_1368 0x10028a5")]
    public const int XKB_KEY_braille_dots_1368 = 0x10028a5;

    [NativeTypeName("#define XKB_KEY_braille_dots_2368 0x10028a6")]
    public const int XKB_KEY_braille_dots_2368 = 0x10028a6;

    [NativeTypeName("#define XKB_KEY_braille_dots_12368 0x10028a7")]
    public const int XKB_KEY_braille_dots_12368 = 0x10028a7;

    [NativeTypeName("#define XKB_KEY_braille_dots_468 0x10028a8")]
    public const int XKB_KEY_braille_dots_468 = 0x10028a8;

    [NativeTypeName("#define XKB_KEY_braille_dots_1468 0x10028a9")]
    public const int XKB_KEY_braille_dots_1468 = 0x10028a9;

    [NativeTypeName("#define XKB_KEY_braille_dots_2468 0x10028aa")]
    public const int XKB_KEY_braille_dots_2468 = 0x10028aa;

    [NativeTypeName("#define XKB_KEY_braille_dots_12468 0x10028ab")]
    public const int XKB_KEY_braille_dots_12468 = 0x10028ab;

    [NativeTypeName("#define XKB_KEY_braille_dots_3468 0x10028ac")]
    public const int XKB_KEY_braille_dots_3468 = 0x10028ac;

    [NativeTypeName("#define XKB_KEY_braille_dots_13468 0x10028ad")]
    public const int XKB_KEY_braille_dots_13468 = 0x10028ad;

    [NativeTypeName("#define XKB_KEY_braille_dots_23468 0x10028ae")]
    public const int XKB_KEY_braille_dots_23468 = 0x10028ae;

    [NativeTypeName("#define XKB_KEY_braille_dots_123468 0x10028af")]
    public const int XKB_KEY_braille_dots_123468 = 0x10028af;

    [NativeTypeName("#define XKB_KEY_braille_dots_568 0x10028b0")]
    public const int XKB_KEY_braille_dots_568 = 0x10028b0;

    [NativeTypeName("#define XKB_KEY_braille_dots_1568 0x10028b1")]
    public const int XKB_KEY_braille_dots_1568 = 0x10028b1;

    [NativeTypeName("#define XKB_KEY_braille_dots_2568 0x10028b2")]
    public const int XKB_KEY_braille_dots_2568 = 0x10028b2;

    [NativeTypeName("#define XKB_KEY_braille_dots_12568 0x10028b3")]
    public const int XKB_KEY_braille_dots_12568 = 0x10028b3;

    [NativeTypeName("#define XKB_KEY_braille_dots_3568 0x10028b4")]
    public const int XKB_KEY_braille_dots_3568 = 0x10028b4;

    [NativeTypeName("#define XKB_KEY_braille_dots_13568 0x10028b5")]
    public const int XKB_KEY_braille_dots_13568 = 0x10028b5;

    [NativeTypeName("#define XKB_KEY_braille_dots_23568 0x10028b6")]
    public const int XKB_KEY_braille_dots_23568 = 0x10028b6;

    [NativeTypeName("#define XKB_KEY_braille_dots_123568 0x10028b7")]
    public const int XKB_KEY_braille_dots_123568 = 0x10028b7;

    [NativeTypeName("#define XKB_KEY_braille_dots_4568 0x10028b8")]
    public const int XKB_KEY_braille_dots_4568 = 0x10028b8;

    [NativeTypeName("#define XKB_KEY_braille_dots_14568 0x10028b9")]
    public const int XKB_KEY_braille_dots_14568 = 0x10028b9;

    [NativeTypeName("#define XKB_KEY_braille_dots_24568 0x10028ba")]
    public const int XKB_KEY_braille_dots_24568 = 0x10028ba;

    [NativeTypeName("#define XKB_KEY_braille_dots_124568 0x10028bb")]
    public const int XKB_KEY_braille_dots_124568 = 0x10028bb;

    [NativeTypeName("#define XKB_KEY_braille_dots_34568 0x10028bc")]
    public const int XKB_KEY_braille_dots_34568 = 0x10028bc;

    [NativeTypeName("#define XKB_KEY_braille_dots_134568 0x10028bd")]
    public const int XKB_KEY_braille_dots_134568 = 0x10028bd;

    [NativeTypeName("#define XKB_KEY_braille_dots_234568 0x10028be")]
    public const int XKB_KEY_braille_dots_234568 = 0x10028be;

    [NativeTypeName("#define XKB_KEY_braille_dots_1234568 0x10028bf")]
    public const int XKB_KEY_braille_dots_1234568 = 0x10028bf;

    [NativeTypeName("#define XKB_KEY_braille_dots_78 0x10028c0")]
    public const int XKB_KEY_braille_dots_78 = 0x10028c0;

    [NativeTypeName("#define XKB_KEY_braille_dots_178 0x10028c1")]
    public const int XKB_KEY_braille_dots_178 = 0x10028c1;

    [NativeTypeName("#define XKB_KEY_braille_dots_278 0x10028c2")]
    public const int XKB_KEY_braille_dots_278 = 0x10028c2;

    [NativeTypeName("#define XKB_KEY_braille_dots_1278 0x10028c3")]
    public const int XKB_KEY_braille_dots_1278 = 0x10028c3;

    [NativeTypeName("#define XKB_KEY_braille_dots_378 0x10028c4")]
    public const int XKB_KEY_braille_dots_378 = 0x10028c4;

    [NativeTypeName("#define XKB_KEY_braille_dots_1378 0x10028c5")]
    public const int XKB_KEY_braille_dots_1378 = 0x10028c5;

    [NativeTypeName("#define XKB_KEY_braille_dots_2378 0x10028c6")]
    public const int XKB_KEY_braille_dots_2378 = 0x10028c6;

    [NativeTypeName("#define XKB_KEY_braille_dots_12378 0x10028c7")]
    public const int XKB_KEY_braille_dots_12378 = 0x10028c7;

    [NativeTypeName("#define XKB_KEY_braille_dots_478 0x10028c8")]
    public const int XKB_KEY_braille_dots_478 = 0x10028c8;

    [NativeTypeName("#define XKB_KEY_braille_dots_1478 0x10028c9")]
    public const int XKB_KEY_braille_dots_1478 = 0x10028c9;

    [NativeTypeName("#define XKB_KEY_braille_dots_2478 0x10028ca")]
    public const int XKB_KEY_braille_dots_2478 = 0x10028ca;

    [NativeTypeName("#define XKB_KEY_braille_dots_12478 0x10028cb")]
    public const int XKB_KEY_braille_dots_12478 = 0x10028cb;

    [NativeTypeName("#define XKB_KEY_braille_dots_3478 0x10028cc")]
    public const int XKB_KEY_braille_dots_3478 = 0x10028cc;

    [NativeTypeName("#define XKB_KEY_braille_dots_13478 0x10028cd")]
    public const int XKB_KEY_braille_dots_13478 = 0x10028cd;

    [NativeTypeName("#define XKB_KEY_braille_dots_23478 0x10028ce")]
    public const int XKB_KEY_braille_dots_23478 = 0x10028ce;

    [NativeTypeName("#define XKB_KEY_braille_dots_123478 0x10028cf")]
    public const int XKB_KEY_braille_dots_123478 = 0x10028cf;

    [NativeTypeName("#define XKB_KEY_braille_dots_578 0x10028d0")]
    public const int XKB_KEY_braille_dots_578 = 0x10028d0;

    [NativeTypeName("#define XKB_KEY_braille_dots_1578 0x10028d1")]
    public const int XKB_KEY_braille_dots_1578 = 0x10028d1;

    [NativeTypeName("#define XKB_KEY_braille_dots_2578 0x10028d2")]
    public const int XKB_KEY_braille_dots_2578 = 0x10028d2;

    [NativeTypeName("#define XKB_KEY_braille_dots_12578 0x10028d3")]
    public const int XKB_KEY_braille_dots_12578 = 0x10028d3;

    [NativeTypeName("#define XKB_KEY_braille_dots_3578 0x10028d4")]
    public const int XKB_KEY_braille_dots_3578 = 0x10028d4;

    [NativeTypeName("#define XKB_KEY_braille_dots_13578 0x10028d5")]
    public const int XKB_KEY_braille_dots_13578 = 0x10028d5;

    [NativeTypeName("#define XKB_KEY_braille_dots_23578 0x10028d6")]
    public const int XKB_KEY_braille_dots_23578 = 0x10028d6;

    [NativeTypeName("#define XKB_KEY_braille_dots_123578 0x10028d7")]
    public const int XKB_KEY_braille_dots_123578 = 0x10028d7;

    [NativeTypeName("#define XKB_KEY_braille_dots_4578 0x10028d8")]
    public const int XKB_KEY_braille_dots_4578 = 0x10028d8;

    [NativeTypeName("#define XKB_KEY_braille_dots_14578 0x10028d9")]
    public const int XKB_KEY_braille_dots_14578 = 0x10028d9;

    [NativeTypeName("#define XKB_KEY_braille_dots_24578 0x10028da")]
    public const int XKB_KEY_braille_dots_24578 = 0x10028da;

    [NativeTypeName("#define XKB_KEY_braille_dots_124578 0x10028db")]
    public const int XKB_KEY_braille_dots_124578 = 0x10028db;

    [NativeTypeName("#define XKB_KEY_braille_dots_34578 0x10028dc")]
    public const int XKB_KEY_braille_dots_34578 = 0x10028dc;

    [NativeTypeName("#define XKB_KEY_braille_dots_134578 0x10028dd")]
    public const int XKB_KEY_braille_dots_134578 = 0x10028dd;

    [NativeTypeName("#define XKB_KEY_braille_dots_234578 0x10028de")]
    public const int XKB_KEY_braille_dots_234578 = 0x10028de;

    [NativeTypeName("#define XKB_KEY_braille_dots_1234578 0x10028df")]
    public const int XKB_KEY_braille_dots_1234578 = 0x10028df;

    [NativeTypeName("#define XKB_KEY_braille_dots_678 0x10028e0")]
    public const int XKB_KEY_braille_dots_678 = 0x10028e0;

    [NativeTypeName("#define XKB_KEY_braille_dots_1678 0x10028e1")]
    public const int XKB_KEY_braille_dots_1678 = 0x10028e1;

    [NativeTypeName("#define XKB_KEY_braille_dots_2678 0x10028e2")]
    public const int XKB_KEY_braille_dots_2678 = 0x10028e2;

    [NativeTypeName("#define XKB_KEY_braille_dots_12678 0x10028e3")]
    public const int XKB_KEY_braille_dots_12678 = 0x10028e3;

    [NativeTypeName("#define XKB_KEY_braille_dots_3678 0x10028e4")]
    public const int XKB_KEY_braille_dots_3678 = 0x10028e4;

    [NativeTypeName("#define XKB_KEY_braille_dots_13678 0x10028e5")]
    public const int XKB_KEY_braille_dots_13678 = 0x10028e5;

    [NativeTypeName("#define XKB_KEY_braille_dots_23678 0x10028e6")]
    public const int XKB_KEY_braille_dots_23678 = 0x10028e6;

    [NativeTypeName("#define XKB_KEY_braille_dots_123678 0x10028e7")]
    public const int XKB_KEY_braille_dots_123678 = 0x10028e7;

    [NativeTypeName("#define XKB_KEY_braille_dots_4678 0x10028e8")]
    public const int XKB_KEY_braille_dots_4678 = 0x10028e8;

    [NativeTypeName("#define XKB_KEY_braille_dots_14678 0x10028e9")]
    public const int XKB_KEY_braille_dots_14678 = 0x10028e9;

    [NativeTypeName("#define XKB_KEY_braille_dots_24678 0x10028ea")]
    public const int XKB_KEY_braille_dots_24678 = 0x10028ea;

    [NativeTypeName("#define XKB_KEY_braille_dots_124678 0x10028eb")]
    public const int XKB_KEY_braille_dots_124678 = 0x10028eb;

    [NativeTypeName("#define XKB_KEY_braille_dots_34678 0x10028ec")]
    public const int XKB_KEY_braille_dots_34678 = 0x10028ec;

    [NativeTypeName("#define XKB_KEY_braille_dots_134678 0x10028ed")]
    public const int XKB_KEY_braille_dots_134678 = 0x10028ed;

    [NativeTypeName("#define XKB_KEY_braille_dots_234678 0x10028ee")]
    public const int XKB_KEY_braille_dots_234678 = 0x10028ee;

    [NativeTypeName("#define XKB_KEY_braille_dots_1234678 0x10028ef")]
    public const int XKB_KEY_braille_dots_1234678 = 0x10028ef;

    [NativeTypeName("#define XKB_KEY_braille_dots_5678 0x10028f0")]
    public const int XKB_KEY_braille_dots_5678 = 0x10028f0;

    [NativeTypeName("#define XKB_KEY_braille_dots_15678 0x10028f1")]
    public const int XKB_KEY_braille_dots_15678 = 0x10028f1;

    [NativeTypeName("#define XKB_KEY_braille_dots_25678 0x10028f2")]
    public const int XKB_KEY_braille_dots_25678 = 0x10028f2;

    [NativeTypeName("#define XKB_KEY_braille_dots_125678 0x10028f3")]
    public const int XKB_KEY_braille_dots_125678 = 0x10028f3;

    [NativeTypeName("#define XKB_KEY_braille_dots_35678 0x10028f4")]
    public const int XKB_KEY_braille_dots_35678 = 0x10028f4;

    [NativeTypeName("#define XKB_KEY_braille_dots_135678 0x10028f5")]
    public const int XKB_KEY_braille_dots_135678 = 0x10028f5;

    [NativeTypeName("#define XKB_KEY_braille_dots_235678 0x10028f6")]
    public const int XKB_KEY_braille_dots_235678 = 0x10028f6;

    [NativeTypeName("#define XKB_KEY_braille_dots_1235678 0x10028f7")]
    public const int XKB_KEY_braille_dots_1235678 = 0x10028f7;

    [NativeTypeName("#define XKB_KEY_braille_dots_45678 0x10028f8")]
    public const int XKB_KEY_braille_dots_45678 = 0x10028f8;

    [NativeTypeName("#define XKB_KEY_braille_dots_145678 0x10028f9")]
    public const int XKB_KEY_braille_dots_145678 = 0x10028f9;

    [NativeTypeName("#define XKB_KEY_braille_dots_245678 0x10028fa")]
    public const int XKB_KEY_braille_dots_245678 = 0x10028fa;

    [NativeTypeName("#define XKB_KEY_braille_dots_1245678 0x10028fb")]
    public const int XKB_KEY_braille_dots_1245678 = 0x10028fb;

    [NativeTypeName("#define XKB_KEY_braille_dots_345678 0x10028fc")]
    public const int XKB_KEY_braille_dots_345678 = 0x10028fc;

    [NativeTypeName("#define XKB_KEY_braille_dots_1345678 0x10028fd")]
    public const int XKB_KEY_braille_dots_1345678 = 0x10028fd;

    [NativeTypeName("#define XKB_KEY_braille_dots_2345678 0x10028fe")]
    public const int XKB_KEY_braille_dots_2345678 = 0x10028fe;

    [NativeTypeName("#define XKB_KEY_braille_dots_12345678 0x10028ff")]
    public const int XKB_KEY_braille_dots_12345678 = 0x10028ff;

    [NativeTypeName("#define XKB_KEY_Sinh_ng 0x1000d82")]
    public const int XKB_KEY_Sinh_ng = 0x1000d82;

    [NativeTypeName("#define XKB_KEY_Sinh_h2 0x1000d83")]
    public const int XKB_KEY_Sinh_h2 = 0x1000d83;

    [NativeTypeName("#define XKB_KEY_Sinh_a 0x1000d85")]
    public const int XKB_KEY_Sinh_a = 0x1000d85;

    [NativeTypeName("#define XKB_KEY_Sinh_aa 0x1000d86")]
    public const int XKB_KEY_Sinh_aa = 0x1000d86;

    [NativeTypeName("#define XKB_KEY_Sinh_ae 0x1000d87")]
    public const int XKB_KEY_Sinh_ae = 0x1000d87;

    [NativeTypeName("#define XKB_KEY_Sinh_aee 0x1000d88")]
    public const int XKB_KEY_Sinh_aee = 0x1000d88;

    [NativeTypeName("#define XKB_KEY_Sinh_i 0x1000d89")]
    public const int XKB_KEY_Sinh_i = 0x1000d89;

    [NativeTypeName("#define XKB_KEY_Sinh_ii 0x1000d8a")]
    public const int XKB_KEY_Sinh_ii = 0x1000d8a;

    [NativeTypeName("#define XKB_KEY_Sinh_u 0x1000d8b")]
    public const int XKB_KEY_Sinh_u = 0x1000d8b;

    [NativeTypeName("#define XKB_KEY_Sinh_uu 0x1000d8c")]
    public const int XKB_KEY_Sinh_uu = 0x1000d8c;

    [NativeTypeName("#define XKB_KEY_Sinh_ri 0x1000d8d")]
    public const int XKB_KEY_Sinh_ri = 0x1000d8d;

    [NativeTypeName("#define XKB_KEY_Sinh_rii 0x1000d8e")]
    public const int XKB_KEY_Sinh_rii = 0x1000d8e;

    [NativeTypeName("#define XKB_KEY_Sinh_lu 0x1000d8f")]
    public const int XKB_KEY_Sinh_lu = 0x1000d8f;

    [NativeTypeName("#define XKB_KEY_Sinh_luu 0x1000d90")]
    public const int XKB_KEY_Sinh_luu = 0x1000d90;

    [NativeTypeName("#define XKB_KEY_Sinh_e 0x1000d91")]
    public const int XKB_KEY_Sinh_e = 0x1000d91;

    [NativeTypeName("#define XKB_KEY_Sinh_ee 0x1000d92")]
    public const int XKB_KEY_Sinh_ee = 0x1000d92;

    [NativeTypeName("#define XKB_KEY_Sinh_ai 0x1000d93")]
    public const int XKB_KEY_Sinh_ai = 0x1000d93;

    [NativeTypeName("#define XKB_KEY_Sinh_o 0x1000d94")]
    public const int XKB_KEY_Sinh_o = 0x1000d94;

    [NativeTypeName("#define XKB_KEY_Sinh_oo 0x1000d95")]
    public const int XKB_KEY_Sinh_oo = 0x1000d95;

    [NativeTypeName("#define XKB_KEY_Sinh_au 0x1000d96")]
    public const int XKB_KEY_Sinh_au = 0x1000d96;

    [NativeTypeName("#define XKB_KEY_Sinh_ka 0x1000d9a")]
    public const int XKB_KEY_Sinh_ka = 0x1000d9a;

    [NativeTypeName("#define XKB_KEY_Sinh_kha 0x1000d9b")]
    public const int XKB_KEY_Sinh_kha = 0x1000d9b;

    [NativeTypeName("#define XKB_KEY_Sinh_ga 0x1000d9c")]
    public const int XKB_KEY_Sinh_ga = 0x1000d9c;

    [NativeTypeName("#define XKB_KEY_Sinh_gha 0x1000d9d")]
    public const int XKB_KEY_Sinh_gha = 0x1000d9d;

    [NativeTypeName("#define XKB_KEY_Sinh_ng2 0x1000d9e")]
    public const int XKB_KEY_Sinh_ng2 = 0x1000d9e;

    [NativeTypeName("#define XKB_KEY_Sinh_nga 0x1000d9f")]
    public const int XKB_KEY_Sinh_nga = 0x1000d9f;

    [NativeTypeName("#define XKB_KEY_Sinh_ca 0x1000da0")]
    public const int XKB_KEY_Sinh_ca = 0x1000da0;

    [NativeTypeName("#define XKB_KEY_Sinh_cha 0x1000da1")]
    public const int XKB_KEY_Sinh_cha = 0x1000da1;

    [NativeTypeName("#define XKB_KEY_Sinh_ja 0x1000da2")]
    public const int XKB_KEY_Sinh_ja = 0x1000da2;

    [NativeTypeName("#define XKB_KEY_Sinh_jha 0x1000da3")]
    public const int XKB_KEY_Sinh_jha = 0x1000da3;

    [NativeTypeName("#define XKB_KEY_Sinh_nya 0x1000da4")]
    public const int XKB_KEY_Sinh_nya = 0x1000da4;

    [NativeTypeName("#define XKB_KEY_Sinh_jnya 0x1000da5")]
    public const int XKB_KEY_Sinh_jnya = 0x1000da5;

    [NativeTypeName("#define XKB_KEY_Sinh_nja 0x1000da6")]
    public const int XKB_KEY_Sinh_nja = 0x1000da6;

    [NativeTypeName("#define XKB_KEY_Sinh_tta 0x1000da7")]
    public const int XKB_KEY_Sinh_tta = 0x1000da7;

    [NativeTypeName("#define XKB_KEY_Sinh_ttha 0x1000da8")]
    public const int XKB_KEY_Sinh_ttha = 0x1000da8;

    [NativeTypeName("#define XKB_KEY_Sinh_dda 0x1000da9")]
    public const int XKB_KEY_Sinh_dda = 0x1000da9;

    [NativeTypeName("#define XKB_KEY_Sinh_ddha 0x1000daa")]
    public const int XKB_KEY_Sinh_ddha = 0x1000daa;

    [NativeTypeName("#define XKB_KEY_Sinh_nna 0x1000dab")]
    public const int XKB_KEY_Sinh_nna = 0x1000dab;

    [NativeTypeName("#define XKB_KEY_Sinh_ndda 0x1000dac")]
    public const int XKB_KEY_Sinh_ndda = 0x1000dac;

    [NativeTypeName("#define XKB_KEY_Sinh_tha 0x1000dad")]
    public const int XKB_KEY_Sinh_tha = 0x1000dad;

    [NativeTypeName("#define XKB_KEY_Sinh_thha 0x1000dae")]
    public const int XKB_KEY_Sinh_thha = 0x1000dae;

    [NativeTypeName("#define XKB_KEY_Sinh_dha 0x1000daf")]
    public const int XKB_KEY_Sinh_dha = 0x1000daf;

    [NativeTypeName("#define XKB_KEY_Sinh_dhha 0x1000db0")]
    public const int XKB_KEY_Sinh_dhha = 0x1000db0;

    [NativeTypeName("#define XKB_KEY_Sinh_na 0x1000db1")]
    public const int XKB_KEY_Sinh_na = 0x1000db1;

    [NativeTypeName("#define XKB_KEY_Sinh_ndha 0x1000db3")]
    public const int XKB_KEY_Sinh_ndha = 0x1000db3;

    [NativeTypeName("#define XKB_KEY_Sinh_pa 0x1000db4")]
    public const int XKB_KEY_Sinh_pa = 0x1000db4;

    [NativeTypeName("#define XKB_KEY_Sinh_pha 0x1000db5")]
    public const int XKB_KEY_Sinh_pha = 0x1000db5;

    [NativeTypeName("#define XKB_KEY_Sinh_ba 0x1000db6")]
    public const int XKB_KEY_Sinh_ba = 0x1000db6;

    [NativeTypeName("#define XKB_KEY_Sinh_bha 0x1000db7")]
    public const int XKB_KEY_Sinh_bha = 0x1000db7;

    [NativeTypeName("#define XKB_KEY_Sinh_ma 0x1000db8")]
    public const int XKB_KEY_Sinh_ma = 0x1000db8;

    [NativeTypeName("#define XKB_KEY_Sinh_mba 0x1000db9")]
    public const int XKB_KEY_Sinh_mba = 0x1000db9;

    [NativeTypeName("#define XKB_KEY_Sinh_ya 0x1000dba")]
    public const int XKB_KEY_Sinh_ya = 0x1000dba;

    [NativeTypeName("#define XKB_KEY_Sinh_ra 0x1000dbb")]
    public const int XKB_KEY_Sinh_ra = 0x1000dbb;

    [NativeTypeName("#define XKB_KEY_Sinh_la 0x1000dbd")]
    public const int XKB_KEY_Sinh_la = 0x1000dbd;

    [NativeTypeName("#define XKB_KEY_Sinh_va 0x1000dc0")]
    public const int XKB_KEY_Sinh_va = 0x1000dc0;

    [NativeTypeName("#define XKB_KEY_Sinh_sha 0x1000dc1")]
    public const int XKB_KEY_Sinh_sha = 0x1000dc1;

    [NativeTypeName("#define XKB_KEY_Sinh_ssha 0x1000dc2")]
    public const int XKB_KEY_Sinh_ssha = 0x1000dc2;

    [NativeTypeName("#define XKB_KEY_Sinh_sa 0x1000dc3")]
    public const int XKB_KEY_Sinh_sa = 0x1000dc3;

    [NativeTypeName("#define XKB_KEY_Sinh_ha 0x1000dc4")]
    public const int XKB_KEY_Sinh_ha = 0x1000dc4;

    [NativeTypeName("#define XKB_KEY_Sinh_lla 0x1000dc5")]
    public const int XKB_KEY_Sinh_lla = 0x1000dc5;

    [NativeTypeName("#define XKB_KEY_Sinh_fa 0x1000dc6")]
    public const int XKB_KEY_Sinh_fa = 0x1000dc6;

    [NativeTypeName("#define XKB_KEY_Sinh_al 0x1000dca")]
    public const int XKB_KEY_Sinh_al = 0x1000dca;

    [NativeTypeName("#define XKB_KEY_Sinh_aa2 0x1000dcf")]
    public const int XKB_KEY_Sinh_aa2 = 0x1000dcf;

    [NativeTypeName("#define XKB_KEY_Sinh_ae2 0x1000dd0")]
    public const int XKB_KEY_Sinh_ae2 = 0x1000dd0;

    [NativeTypeName("#define XKB_KEY_Sinh_aee2 0x1000dd1")]
    public const int XKB_KEY_Sinh_aee2 = 0x1000dd1;

    [NativeTypeName("#define XKB_KEY_Sinh_i2 0x1000dd2")]
    public const int XKB_KEY_Sinh_i2 = 0x1000dd2;

    [NativeTypeName("#define XKB_KEY_Sinh_ii2 0x1000dd3")]
    public const int XKB_KEY_Sinh_ii2 = 0x1000dd3;

    [NativeTypeName("#define XKB_KEY_Sinh_u2 0x1000dd4")]
    public const int XKB_KEY_Sinh_u2 = 0x1000dd4;

    [NativeTypeName("#define XKB_KEY_Sinh_uu2 0x1000dd6")]
    public const int XKB_KEY_Sinh_uu2 = 0x1000dd6;

    [NativeTypeName("#define XKB_KEY_Sinh_ru2 0x1000dd8")]
    public const int XKB_KEY_Sinh_ru2 = 0x1000dd8;

    [NativeTypeName("#define XKB_KEY_Sinh_e2 0x1000dd9")]
    public const int XKB_KEY_Sinh_e2 = 0x1000dd9;

    [NativeTypeName("#define XKB_KEY_Sinh_ee2 0x1000dda")]
    public const int XKB_KEY_Sinh_ee2 = 0x1000dda;

    [NativeTypeName("#define XKB_KEY_Sinh_ai2 0x1000ddb")]
    public const int XKB_KEY_Sinh_ai2 = 0x1000ddb;

    [NativeTypeName("#define XKB_KEY_Sinh_o2 0x1000ddc")]
    public const int XKB_KEY_Sinh_o2 = 0x1000ddc;

    [NativeTypeName("#define XKB_KEY_Sinh_oo2 0x1000ddd")]
    public const int XKB_KEY_Sinh_oo2 = 0x1000ddd;

    [NativeTypeName("#define XKB_KEY_Sinh_au2 0x1000dde")]
    public const int XKB_KEY_Sinh_au2 = 0x1000dde;

    [NativeTypeName("#define XKB_KEY_Sinh_lu2 0x1000ddf")]
    public const int XKB_KEY_Sinh_lu2 = 0x1000ddf;

    [NativeTypeName("#define XKB_KEY_Sinh_ruu2 0x1000df2")]
    public const int XKB_KEY_Sinh_ruu2 = 0x1000df2;

    [NativeTypeName("#define XKB_KEY_Sinh_luu2 0x1000df3")]
    public const int XKB_KEY_Sinh_luu2 = 0x1000df3;

    [NativeTypeName("#define XKB_KEY_Sinh_kunddaliya 0x1000df4")]
    public const int XKB_KEY_Sinh_kunddaliya = 0x1000df4;

    [NativeTypeName("#define XKB_KEY_XF86ModeLock 0x1008FF01")]
    public const int XKB_KEY_XF86ModeLock = 0x1008FF01;

    [NativeTypeName("#define XKB_KEY_XF86MonBrightnessUp 0x1008FF02")]
    public const int XKB_KEY_XF86MonBrightnessUp = 0x1008FF02;

    [NativeTypeName("#define XKB_KEY_XF86MonBrightnessDown 0x1008FF03")]
    public const int XKB_KEY_XF86MonBrightnessDown = 0x1008FF03;

    [NativeTypeName("#define XKB_KEY_XF86KbdLightOnOff 0x1008FF04")]
    public const int XKB_KEY_XF86KbdLightOnOff = 0x1008FF04;

    [NativeTypeName("#define XKB_KEY_XF86KbdBrightnessUp 0x1008FF05")]
    public const int XKB_KEY_XF86KbdBrightnessUp = 0x1008FF05;

    [NativeTypeName("#define XKB_KEY_XF86KbdBrightnessDown 0x1008FF06")]
    public const int XKB_KEY_XF86KbdBrightnessDown = 0x1008FF06;

    [NativeTypeName("#define XKB_KEY_XF86MonBrightnessCycle 0x1008FF07")]
    public const int XKB_KEY_XF86MonBrightnessCycle = 0x1008FF07;

    [NativeTypeName("#define XKB_KEY_XF86Standby 0x1008FF10")]
    public const int XKB_KEY_XF86Standby = 0x1008FF10;

    [NativeTypeName("#define XKB_KEY_XF86AudioLowerVolume 0x1008FF11")]
    public const int XKB_KEY_XF86AudioLowerVolume = 0x1008FF11;

    [NativeTypeName("#define XKB_KEY_XF86AudioMute 0x1008FF12")]
    public const int XKB_KEY_XF86AudioMute = 0x1008FF12;

    [NativeTypeName("#define XKB_KEY_XF86AudioRaiseVolume 0x1008FF13")]
    public const int XKB_KEY_XF86AudioRaiseVolume = 0x1008FF13;

    [NativeTypeName("#define XKB_KEY_XF86AudioPlay 0x1008FF14")]
    public const int XKB_KEY_XF86AudioPlay = 0x1008FF14;

    [NativeTypeName("#define XKB_KEY_XF86AudioStop 0x1008FF15")]
    public const int XKB_KEY_XF86AudioStop = 0x1008FF15;

    [NativeTypeName("#define XKB_KEY_XF86AudioPrev 0x1008FF16")]
    public const int XKB_KEY_XF86AudioPrev = 0x1008FF16;

    [NativeTypeName("#define XKB_KEY_XF86AudioNext 0x1008FF17")]
    public const int XKB_KEY_XF86AudioNext = 0x1008FF17;

    [NativeTypeName("#define XKB_KEY_XF86HomePage 0x1008FF18")]
    public const int XKB_KEY_XF86HomePage = 0x1008FF18;

    [NativeTypeName("#define XKB_KEY_XF86Mail 0x1008FF19")]
    public const int XKB_KEY_XF86Mail = 0x1008FF19;

    [NativeTypeName("#define XKB_KEY_XF86Start 0x1008FF1A")]
    public const int XKB_KEY_XF86Start = 0x1008FF1A;

    [NativeTypeName("#define XKB_KEY_XF86Search 0x1008FF1B")]
    public const int XKB_KEY_XF86Search = 0x1008FF1B;

    [NativeTypeName("#define XKB_KEY_XF86AudioRecord 0x1008FF1C")]
    public const int XKB_KEY_XF86AudioRecord = 0x1008FF1C;

    [NativeTypeName("#define XKB_KEY_XF86Calculator 0x1008FF1D")]
    public const int XKB_KEY_XF86Calculator = 0x1008FF1D;

    [NativeTypeName("#define XKB_KEY_XF86Memo 0x1008FF1E")]
    public const int XKB_KEY_XF86Memo = 0x1008FF1E;

    [NativeTypeName("#define XKB_KEY_XF86ToDoList 0x1008FF1F")]
    public const int XKB_KEY_XF86ToDoList = 0x1008FF1F;

    [NativeTypeName("#define XKB_KEY_XF86Calendar 0x1008FF20")]
    public const int XKB_KEY_XF86Calendar = 0x1008FF20;

    [NativeTypeName("#define XKB_KEY_XF86PowerDown 0x1008FF21")]
    public const int XKB_KEY_XF86PowerDown = 0x1008FF21;

    [NativeTypeName("#define XKB_KEY_XF86ContrastAdjust 0x1008FF22")]
    public const int XKB_KEY_XF86ContrastAdjust = 0x1008FF22;

    [NativeTypeName("#define XKB_KEY_XF86RockerUp 0x1008FF23")]
    public const int XKB_KEY_XF86RockerUp = 0x1008FF23;

    [NativeTypeName("#define XKB_KEY_XF86RockerDown 0x1008FF24")]
    public const int XKB_KEY_XF86RockerDown = 0x1008FF24;

    [NativeTypeName("#define XKB_KEY_XF86RockerEnter 0x1008FF25")]
    public const int XKB_KEY_XF86RockerEnter = 0x1008FF25;

    [NativeTypeName("#define XKB_KEY_XF86Back 0x1008FF26")]
    public const int XKB_KEY_XF86Back = 0x1008FF26;

    [NativeTypeName("#define XKB_KEY_XF86Forward 0x1008FF27")]
    public const int XKB_KEY_XF86Forward = 0x1008FF27;

    [NativeTypeName("#define XKB_KEY_XF86Stop 0x1008FF28")]
    public const int XKB_KEY_XF86Stop = 0x1008FF28;

    [NativeTypeName("#define XKB_KEY_XF86Refresh 0x1008FF29")]
    public const int XKB_KEY_XF86Refresh = 0x1008FF29;

    [NativeTypeName("#define XKB_KEY_XF86PowerOff 0x1008FF2A")]
    public const int XKB_KEY_XF86PowerOff = 0x1008FF2A;

    [NativeTypeName("#define XKB_KEY_XF86WakeUp 0x1008FF2B")]
    public const int XKB_KEY_XF86WakeUp = 0x1008FF2B;

    [NativeTypeName("#define XKB_KEY_XF86Eject 0x1008FF2C")]
    public const int XKB_KEY_XF86Eject = 0x1008FF2C;

    [NativeTypeName("#define XKB_KEY_XF86ScreenSaver 0x1008FF2D")]
    public const int XKB_KEY_XF86ScreenSaver = 0x1008FF2D;

    [NativeTypeName("#define XKB_KEY_XF86WWW 0x1008FF2E")]
    public const int XKB_KEY_XF86WWW = 0x1008FF2E;

    [NativeTypeName("#define XKB_KEY_XF86Sleep 0x1008FF2F")]
    public const int XKB_KEY_XF86Sleep = 0x1008FF2F;

    [NativeTypeName("#define XKB_KEY_XF86Favorites 0x1008FF30")]
    public const int XKB_KEY_XF86Favorites = 0x1008FF30;

    [NativeTypeName("#define XKB_KEY_XF86AudioPause 0x1008FF31")]
    public const int XKB_KEY_XF86AudioPause = 0x1008FF31;

    [NativeTypeName("#define XKB_KEY_XF86AudioMedia 0x1008FF32")]
    public const int XKB_KEY_XF86AudioMedia = 0x1008FF32;

    [NativeTypeName("#define XKB_KEY_XF86MyComputer 0x1008FF33")]
    public const int XKB_KEY_XF86MyComputer = 0x1008FF33;

    [NativeTypeName("#define XKB_KEY_XF86VendorHome 0x1008FF34")]
    public const int XKB_KEY_XF86VendorHome = 0x1008FF34;

    [NativeTypeName("#define XKB_KEY_XF86LightBulb 0x1008FF35")]
    public const int XKB_KEY_XF86LightBulb = 0x1008FF35;

    [NativeTypeName("#define XKB_KEY_XF86Shop 0x1008FF36")]
    public const int XKB_KEY_XF86Shop = 0x1008FF36;

    [NativeTypeName("#define XKB_KEY_XF86History 0x1008FF37")]
    public const int XKB_KEY_XF86History = 0x1008FF37;

    [NativeTypeName("#define XKB_KEY_XF86OpenURL 0x1008FF38")]
    public const int XKB_KEY_XF86OpenURL = 0x1008FF38;

    [NativeTypeName("#define XKB_KEY_XF86AddFavorite 0x1008FF39")]
    public const int XKB_KEY_XF86AddFavorite = 0x1008FF39;

    [NativeTypeName("#define XKB_KEY_XF86HotLinks 0x1008FF3A")]
    public const int XKB_KEY_XF86HotLinks = 0x1008FF3A;

    [NativeTypeName("#define XKB_KEY_XF86BrightnessAdjust 0x1008FF3B")]
    public const int XKB_KEY_XF86BrightnessAdjust = 0x1008FF3B;

    [NativeTypeName("#define XKB_KEY_XF86Finance 0x1008FF3C")]
    public const int XKB_KEY_XF86Finance = 0x1008FF3C;

    [NativeTypeName("#define XKB_KEY_XF86Community 0x1008FF3D")]
    public const int XKB_KEY_XF86Community = 0x1008FF3D;

    [NativeTypeName("#define XKB_KEY_XF86AudioRewind 0x1008FF3E")]
    public const int XKB_KEY_XF86AudioRewind = 0x1008FF3E;

    [NativeTypeName("#define XKB_KEY_XF86BackForward 0x1008FF3F")]
    public const int XKB_KEY_XF86BackForward = 0x1008FF3F;

    [NativeTypeName("#define XKB_KEY_XF86Launch0 0x1008FF40")]
    public const int XKB_KEY_XF86Launch0 = 0x1008FF40;

    [NativeTypeName("#define XKB_KEY_XF86Launch1 0x1008FF41")]
    public const int XKB_KEY_XF86Launch1 = 0x1008FF41;

    [NativeTypeName("#define XKB_KEY_XF86Launch2 0x1008FF42")]
    public const int XKB_KEY_XF86Launch2 = 0x1008FF42;

    [NativeTypeName("#define XKB_KEY_XF86Launch3 0x1008FF43")]
    public const int XKB_KEY_XF86Launch3 = 0x1008FF43;

    [NativeTypeName("#define XKB_KEY_XF86Launch4 0x1008FF44")]
    public const int XKB_KEY_XF86Launch4 = 0x1008FF44;

    [NativeTypeName("#define XKB_KEY_XF86Launch5 0x1008FF45")]
    public const int XKB_KEY_XF86Launch5 = 0x1008FF45;

    [NativeTypeName("#define XKB_KEY_XF86Launch6 0x1008FF46")]
    public const int XKB_KEY_XF86Launch6 = 0x1008FF46;

    [NativeTypeName("#define XKB_KEY_XF86Launch7 0x1008FF47")]
    public const int XKB_KEY_XF86Launch7 = 0x1008FF47;

    [NativeTypeName("#define XKB_KEY_XF86Launch8 0x1008FF48")]
    public const int XKB_KEY_XF86Launch8 = 0x1008FF48;

    [NativeTypeName("#define XKB_KEY_XF86Launch9 0x1008FF49")]
    public const int XKB_KEY_XF86Launch9 = 0x1008FF49;

    [NativeTypeName("#define XKB_KEY_XF86LaunchA 0x1008FF4A")]
    public const int XKB_KEY_XF86LaunchA = 0x1008FF4A;

    [NativeTypeName("#define XKB_KEY_XF86LaunchB 0x1008FF4B")]
    public const int XKB_KEY_XF86LaunchB = 0x1008FF4B;

    [NativeTypeName("#define XKB_KEY_XF86LaunchC 0x1008FF4C")]
    public const int XKB_KEY_XF86LaunchC = 0x1008FF4C;

    [NativeTypeName("#define XKB_KEY_XF86LaunchD 0x1008FF4D")]
    public const int XKB_KEY_XF86LaunchD = 0x1008FF4D;

    [NativeTypeName("#define XKB_KEY_XF86LaunchE 0x1008FF4E")]
    public const int XKB_KEY_XF86LaunchE = 0x1008FF4E;

    [NativeTypeName("#define XKB_KEY_XF86LaunchF 0x1008FF4F")]
    public const int XKB_KEY_XF86LaunchF = 0x1008FF4F;

    [NativeTypeName("#define XKB_KEY_XF86ApplicationLeft 0x1008FF50")]
    public const int XKB_KEY_XF86ApplicationLeft = 0x1008FF50;

    [NativeTypeName("#define XKB_KEY_XF86ApplicationRight 0x1008FF51")]
    public const int XKB_KEY_XF86ApplicationRight = 0x1008FF51;

    [NativeTypeName("#define XKB_KEY_XF86Book 0x1008FF52")]
    public const int XKB_KEY_XF86Book = 0x1008FF52;

    [NativeTypeName("#define XKB_KEY_XF86CD 0x1008FF53")]
    public const int XKB_KEY_XF86CD = 0x1008FF53;

    [NativeTypeName("#define XKB_KEY_XF86Calculater 0x1008FF54")]
    public const int XKB_KEY_XF86Calculater = 0x1008FF54;

    [NativeTypeName("#define XKB_KEY_XF86Clear 0x1008FF55")]
    public const int XKB_KEY_XF86Clear = 0x1008FF55;

    [NativeTypeName("#define XKB_KEY_XF86Close 0x1008FF56")]
    public const int XKB_KEY_XF86Close = 0x1008FF56;

    [NativeTypeName("#define XKB_KEY_XF86Copy 0x1008FF57")]
    public const int XKB_KEY_XF86Copy = 0x1008FF57;

    [NativeTypeName("#define XKB_KEY_XF86Cut 0x1008FF58")]
    public const int XKB_KEY_XF86Cut = 0x1008FF58;

    [NativeTypeName("#define XKB_KEY_XF86Display 0x1008FF59")]
    public const int XKB_KEY_XF86Display = 0x1008FF59;

    [NativeTypeName("#define XKB_KEY_XF86DOS 0x1008FF5A")]
    public const int XKB_KEY_XF86DOS = 0x1008FF5A;

    [NativeTypeName("#define XKB_KEY_XF86Documents 0x1008FF5B")]
    public const int XKB_KEY_XF86Documents = 0x1008FF5B;

    [NativeTypeName("#define XKB_KEY_XF86Excel 0x1008FF5C")]
    public const int XKB_KEY_XF86Excel = 0x1008FF5C;

    [NativeTypeName("#define XKB_KEY_XF86Explorer 0x1008FF5D")]
    public const int XKB_KEY_XF86Explorer = 0x1008FF5D;

    [NativeTypeName("#define XKB_KEY_XF86Game 0x1008FF5E")]
    public const int XKB_KEY_XF86Game = 0x1008FF5E;

    [NativeTypeName("#define XKB_KEY_XF86Go 0x1008FF5F")]
    public const int XKB_KEY_XF86Go = 0x1008FF5F;

    [NativeTypeName("#define XKB_KEY_XF86iTouch 0x1008FF60")]
    public const int XKB_KEY_XF86iTouch = 0x1008FF60;

    [NativeTypeName("#define XKB_KEY_XF86LogOff 0x1008FF61")]
    public const int XKB_KEY_XF86LogOff = 0x1008FF61;

    [NativeTypeName("#define XKB_KEY_XF86Market 0x1008FF62")]
    public const int XKB_KEY_XF86Market = 0x1008FF62;

    [NativeTypeName("#define XKB_KEY_XF86Meeting 0x1008FF63")]
    public const int XKB_KEY_XF86Meeting = 0x1008FF63;

    [NativeTypeName("#define XKB_KEY_XF86MenuKB 0x1008FF65")]
    public const int XKB_KEY_XF86MenuKB = 0x1008FF65;

    [NativeTypeName("#define XKB_KEY_XF86MenuPB 0x1008FF66")]
    public const int XKB_KEY_XF86MenuPB = 0x1008FF66;

    [NativeTypeName("#define XKB_KEY_XF86MySites 0x1008FF67")]
    public const int XKB_KEY_XF86MySites = 0x1008FF67;

    [NativeTypeName("#define XKB_KEY_XF86New 0x1008FF68")]
    public const int XKB_KEY_XF86New = 0x1008FF68;

    [NativeTypeName("#define XKB_KEY_XF86News 0x1008FF69")]
    public const int XKB_KEY_XF86News = 0x1008FF69;

    [NativeTypeName("#define XKB_KEY_XF86OfficeHome 0x1008FF6A")]
    public const int XKB_KEY_XF86OfficeHome = 0x1008FF6A;

    [NativeTypeName("#define XKB_KEY_XF86Open 0x1008FF6B")]
    public const int XKB_KEY_XF86Open = 0x1008FF6B;

    [NativeTypeName("#define XKB_KEY_XF86Option 0x1008FF6C")]
    public const int XKB_KEY_XF86Option = 0x1008FF6C;

    [NativeTypeName("#define XKB_KEY_XF86Paste 0x1008FF6D")]
    public const int XKB_KEY_XF86Paste = 0x1008FF6D;

    [NativeTypeName("#define XKB_KEY_XF86Phone 0x1008FF6E")]
    public const int XKB_KEY_XF86Phone = 0x1008FF6E;

    [NativeTypeName("#define XKB_KEY_XF86Q 0x1008FF70")]
    public const int XKB_KEY_XF86Q = 0x1008FF70;

    [NativeTypeName("#define XKB_KEY_XF86Reply 0x1008FF72")]
    public const int XKB_KEY_XF86Reply = 0x1008FF72;

    [NativeTypeName("#define XKB_KEY_XF86Reload 0x1008FF73")]
    public const int XKB_KEY_XF86Reload = 0x1008FF73;

    [NativeTypeName("#define XKB_KEY_XF86RotateWindows 0x1008FF74")]
    public const int XKB_KEY_XF86RotateWindows = 0x1008FF74;

    [NativeTypeName("#define XKB_KEY_XF86RotationPB 0x1008FF75")]
    public const int XKB_KEY_XF86RotationPB = 0x1008FF75;

    [NativeTypeName("#define XKB_KEY_XF86RotationKB 0x1008FF76")]
    public const int XKB_KEY_XF86RotationKB = 0x1008FF76;

    [NativeTypeName("#define XKB_KEY_XF86Save 0x1008FF77")]
    public const int XKB_KEY_XF86Save = 0x1008FF77;

    [NativeTypeName("#define XKB_KEY_XF86ScrollUp 0x1008FF78")]
    public const int XKB_KEY_XF86ScrollUp = 0x1008FF78;

    [NativeTypeName("#define XKB_KEY_XF86ScrollDown 0x1008FF79")]
    public const int XKB_KEY_XF86ScrollDown = 0x1008FF79;

    [NativeTypeName("#define XKB_KEY_XF86ScrollClick 0x1008FF7A")]
    public const int XKB_KEY_XF86ScrollClick = 0x1008FF7A;

    [NativeTypeName("#define XKB_KEY_XF86Send 0x1008FF7B")]
    public const int XKB_KEY_XF86Send = 0x1008FF7B;

    [NativeTypeName("#define XKB_KEY_XF86Spell 0x1008FF7C")]
    public const int XKB_KEY_XF86Spell = 0x1008FF7C;

    [NativeTypeName("#define XKB_KEY_XF86SplitScreen 0x1008FF7D")]
    public const int XKB_KEY_XF86SplitScreen = 0x1008FF7D;

    [NativeTypeName("#define XKB_KEY_XF86Support 0x1008FF7E")]
    public const int XKB_KEY_XF86Support = 0x1008FF7E;

    [NativeTypeName("#define XKB_KEY_XF86TaskPane 0x1008FF7F")]
    public const int XKB_KEY_XF86TaskPane = 0x1008FF7F;

    [NativeTypeName("#define XKB_KEY_XF86Terminal 0x1008FF80")]
    public const int XKB_KEY_XF86Terminal = 0x1008FF80;

    [NativeTypeName("#define XKB_KEY_XF86Tools 0x1008FF81")]
    public const int XKB_KEY_XF86Tools = 0x1008FF81;

    [NativeTypeName("#define XKB_KEY_XF86Travel 0x1008FF82")]
    public const int XKB_KEY_XF86Travel = 0x1008FF82;

    [NativeTypeName("#define XKB_KEY_XF86UserPB 0x1008FF84")]
    public const int XKB_KEY_XF86UserPB = 0x1008FF84;

    [NativeTypeName("#define XKB_KEY_XF86User1KB 0x1008FF85")]
    public const int XKB_KEY_XF86User1KB = 0x1008FF85;

    [NativeTypeName("#define XKB_KEY_XF86User2KB 0x1008FF86")]
    public const int XKB_KEY_XF86User2KB = 0x1008FF86;

    [NativeTypeName("#define XKB_KEY_XF86Video 0x1008FF87")]
    public const int XKB_KEY_XF86Video = 0x1008FF87;

    [NativeTypeName("#define XKB_KEY_XF86WheelButton 0x1008FF88")]
    public const int XKB_KEY_XF86WheelButton = 0x1008FF88;

    [NativeTypeName("#define XKB_KEY_XF86Word 0x1008FF89")]
    public const int XKB_KEY_XF86Word = 0x1008FF89;

    [NativeTypeName("#define XKB_KEY_XF86Xfer 0x1008FF8A")]
    public const int XKB_KEY_XF86Xfer = 0x1008FF8A;

    [NativeTypeName("#define XKB_KEY_XF86ZoomIn 0x1008FF8B")]
    public const int XKB_KEY_XF86ZoomIn = 0x1008FF8B;

    [NativeTypeName("#define XKB_KEY_XF86ZoomOut 0x1008FF8C")]
    public const int XKB_KEY_XF86ZoomOut = 0x1008FF8C;

    [NativeTypeName("#define XKB_KEY_XF86Away 0x1008FF8D")]
    public const int XKB_KEY_XF86Away = 0x1008FF8D;

    [NativeTypeName("#define XKB_KEY_XF86Messenger 0x1008FF8E")]
    public const int XKB_KEY_XF86Messenger = 0x1008FF8E;

    [NativeTypeName("#define XKB_KEY_XF86WebCam 0x1008FF8F")]
    public const int XKB_KEY_XF86WebCam = 0x1008FF8F;

    [NativeTypeName("#define XKB_KEY_XF86MailForward 0x1008FF90")]
    public const int XKB_KEY_XF86MailForward = 0x1008FF90;

    [NativeTypeName("#define XKB_KEY_XF86Pictures 0x1008FF91")]
    public const int XKB_KEY_XF86Pictures = 0x1008FF91;

    [NativeTypeName("#define XKB_KEY_XF86Music 0x1008FF92")]
    public const int XKB_KEY_XF86Music = 0x1008FF92;

    [NativeTypeName("#define XKB_KEY_XF86Battery 0x1008FF93")]
    public const int XKB_KEY_XF86Battery = 0x1008FF93;

    [NativeTypeName("#define XKB_KEY_XF86Bluetooth 0x1008FF94")]
    public const int XKB_KEY_XF86Bluetooth = 0x1008FF94;

    [NativeTypeName("#define XKB_KEY_XF86WLAN 0x1008FF95")]
    public const int XKB_KEY_XF86WLAN = 0x1008FF95;

    [NativeTypeName("#define XKB_KEY_XF86UWB 0x1008FF96")]
    public const int XKB_KEY_XF86UWB = 0x1008FF96;

    [NativeTypeName("#define XKB_KEY_XF86AudioForward 0x1008FF97")]
    public const int XKB_KEY_XF86AudioForward = 0x1008FF97;

    [NativeTypeName("#define XKB_KEY_XF86AudioRepeat 0x1008FF98")]
    public const int XKB_KEY_XF86AudioRepeat = 0x1008FF98;

    [NativeTypeName("#define XKB_KEY_XF86AudioRandomPlay 0x1008FF99")]
    public const int XKB_KEY_XF86AudioRandomPlay = 0x1008FF99;

    [NativeTypeName("#define XKB_KEY_XF86Subtitle 0x1008FF9A")]
    public const int XKB_KEY_XF86Subtitle = 0x1008FF9A;

    [NativeTypeName("#define XKB_KEY_XF86AudioCycleTrack 0x1008FF9B")]
    public const int XKB_KEY_XF86AudioCycleTrack = 0x1008FF9B;

    [NativeTypeName("#define XKB_KEY_XF86CycleAngle 0x1008FF9C")]
    public const int XKB_KEY_XF86CycleAngle = 0x1008FF9C;

    [NativeTypeName("#define XKB_KEY_XF86FrameBack 0x1008FF9D")]
    public const int XKB_KEY_XF86FrameBack = 0x1008FF9D;

    [NativeTypeName("#define XKB_KEY_XF86FrameForward 0x1008FF9E")]
    public const int XKB_KEY_XF86FrameForward = 0x1008FF9E;

    [NativeTypeName("#define XKB_KEY_XF86Time 0x1008FF9F")]
    public const int XKB_KEY_XF86Time = 0x1008FF9F;

    [NativeTypeName("#define XKB_KEY_XF86Select 0x1008FFA0")]
    public const int XKB_KEY_XF86Select = 0x1008FFA0;

    [NativeTypeName("#define XKB_KEY_XF86View 0x1008FFA1")]
    public const int XKB_KEY_XF86View = 0x1008FFA1;

    [NativeTypeName("#define XKB_KEY_XF86TopMenu 0x1008FFA2")]
    public const int XKB_KEY_XF86TopMenu = 0x1008FFA2;

    [NativeTypeName("#define XKB_KEY_XF86Red 0x1008FFA3")]
    public const int XKB_KEY_XF86Red = 0x1008FFA3;

    [NativeTypeName("#define XKB_KEY_XF86Green 0x1008FFA4")]
    public const int XKB_KEY_XF86Green = 0x1008FFA4;

    [NativeTypeName("#define XKB_KEY_XF86Yellow 0x1008FFA5")]
    public const int XKB_KEY_XF86Yellow = 0x1008FFA5;

    [NativeTypeName("#define XKB_KEY_XF86Blue 0x1008FFA6")]
    public const int XKB_KEY_XF86Blue = 0x1008FFA6;

    [NativeTypeName("#define XKB_KEY_XF86Suspend 0x1008FFA7")]
    public const int XKB_KEY_XF86Suspend = 0x1008FFA7;

    [NativeTypeName("#define XKB_KEY_XF86Hibernate 0x1008FFA8")]
    public const int XKB_KEY_XF86Hibernate = 0x1008FFA8;

    [NativeTypeName("#define XKB_KEY_XF86TouchpadToggle 0x1008FFA9")]
    public const int XKB_KEY_XF86TouchpadToggle = 0x1008FFA9;

    [NativeTypeName("#define XKB_KEY_XF86TouchpadOn 0x1008FFB0")]
    public const int XKB_KEY_XF86TouchpadOn = 0x1008FFB0;

    [NativeTypeName("#define XKB_KEY_XF86TouchpadOff 0x1008FFB1")]
    public const int XKB_KEY_XF86TouchpadOff = 0x1008FFB1;

    [NativeTypeName("#define XKB_KEY_XF86AudioMicMute 0x1008FFB2")]
    public const int XKB_KEY_XF86AudioMicMute = 0x1008FFB2;

    [NativeTypeName("#define XKB_KEY_XF86Keyboard 0x1008FFB3")]
    public const int XKB_KEY_XF86Keyboard = 0x1008FFB3;

    [NativeTypeName("#define XKB_KEY_XF86WWAN 0x1008FFB4")]
    public const int XKB_KEY_XF86WWAN = 0x1008FFB4;

    [NativeTypeName("#define XKB_KEY_XF86RFKill 0x1008FFB5")]
    public const int XKB_KEY_XF86RFKill = 0x1008FFB5;

    [NativeTypeName("#define XKB_KEY_XF86AudioPreset 0x1008FFB6")]
    public const int XKB_KEY_XF86AudioPreset = 0x1008FFB6;

    [NativeTypeName("#define XKB_KEY_XF86RotationLockToggle 0x1008FFB7")]
    public const int XKB_KEY_XF86RotationLockToggle = 0x1008FFB7;

    [NativeTypeName("#define XKB_KEY_XF86FullScreen 0x1008FFB8")]
    public const int XKB_KEY_XF86FullScreen = 0x1008FFB8;

    [NativeTypeName("#define XKB_KEY_XF86Switch_VT_1 0x1008FE01")]
    public const int XKB_KEY_XF86Switch_VT_1 = 0x1008FE01;

    [NativeTypeName("#define XKB_KEY_XF86Switch_VT_2 0x1008FE02")]
    public const int XKB_KEY_XF86Switch_VT_2 = 0x1008FE02;

    [NativeTypeName("#define XKB_KEY_XF86Switch_VT_3 0x1008FE03")]
    public const int XKB_KEY_XF86Switch_VT_3 = 0x1008FE03;

    [NativeTypeName("#define XKB_KEY_XF86Switch_VT_4 0x1008FE04")]
    public const int XKB_KEY_XF86Switch_VT_4 = 0x1008FE04;

    [NativeTypeName("#define XKB_KEY_XF86Switch_VT_5 0x1008FE05")]
    public const int XKB_KEY_XF86Switch_VT_5 = 0x1008FE05;

    [NativeTypeName("#define XKB_KEY_XF86Switch_VT_6 0x1008FE06")]
    public const int XKB_KEY_XF86Switch_VT_6 = 0x1008FE06;

    [NativeTypeName("#define XKB_KEY_XF86Switch_VT_7 0x1008FE07")]
    public const int XKB_KEY_XF86Switch_VT_7 = 0x1008FE07;

    [NativeTypeName("#define XKB_KEY_XF86Switch_VT_8 0x1008FE08")]
    public const int XKB_KEY_XF86Switch_VT_8 = 0x1008FE08;

    [NativeTypeName("#define XKB_KEY_XF86Switch_VT_9 0x1008FE09")]
    public const int XKB_KEY_XF86Switch_VT_9 = 0x1008FE09;

    [NativeTypeName("#define XKB_KEY_XF86Switch_VT_10 0x1008FE0A")]
    public const int XKB_KEY_XF86Switch_VT_10 = 0x1008FE0A;

    [NativeTypeName("#define XKB_KEY_XF86Switch_VT_11 0x1008FE0B")]
    public const int XKB_KEY_XF86Switch_VT_11 = 0x1008FE0B;

    [NativeTypeName("#define XKB_KEY_XF86Switch_VT_12 0x1008FE0C")]
    public const int XKB_KEY_XF86Switch_VT_12 = 0x1008FE0C;

    [NativeTypeName("#define XKB_KEY_XF86Ungrab 0x1008FE20")]
    public const int XKB_KEY_XF86Ungrab = 0x1008FE20;

    [NativeTypeName("#define XKB_KEY_XF86ClearGrab 0x1008FE21")]
    public const int XKB_KEY_XF86ClearGrab = 0x1008FE21;

    [NativeTypeName("#define XKB_KEY_XF86Next_VMode 0x1008FE22")]
    public const int XKB_KEY_XF86Next_VMode = 0x1008FE22;

    [NativeTypeName("#define XKB_KEY_XF86Prev_VMode 0x1008FE23")]
    public const int XKB_KEY_XF86Prev_VMode = 0x1008FE23;

    [NativeTypeName("#define XKB_KEY_XF86LogWindowTree 0x1008FE24")]
    public const int XKB_KEY_XF86LogWindowTree = 0x1008FE24;

    [NativeTypeName("#define XKB_KEY_XF86LogGrabInfo 0x1008FE25")]
    public const int XKB_KEY_XF86LogGrabInfo = 0x1008FE25;

    [NativeTypeName("#define XKB_KEY_XF86BrightnessAuto 0x100810f4")]
    public const int XKB_KEY_XF86BrightnessAuto = 0x100810f4;

    [NativeTypeName("#define XKB_KEY_XF86DisplayOff 0x100810f5")]
    public const int XKB_KEY_XF86DisplayOff = 0x100810f5;

    [NativeTypeName("#define XKB_KEY_XF86Info 0x10081166")]
    public const int XKB_KEY_XF86Info = 0x10081166;

    [NativeTypeName("#define XKB_KEY_XF86AspectRatio 0x10081177")]
    public const int XKB_KEY_XF86AspectRatio = 0x10081177;

    [NativeTypeName("#define XKB_KEY_XF86DVD 0x10081185")]
    public const int XKB_KEY_XF86DVD = 0x10081185;

    [NativeTypeName("#define XKB_KEY_XF86Audio 0x10081188")]
    public const int XKB_KEY_XF86Audio = 0x10081188;

    [NativeTypeName("#define XKB_KEY_XF86ChannelUp 0x10081192")]
    public const int XKB_KEY_XF86ChannelUp = 0x10081192;

    [NativeTypeName("#define XKB_KEY_XF86ChannelDown 0x10081193")]
    public const int XKB_KEY_XF86ChannelDown = 0x10081193;

    [NativeTypeName("#define XKB_KEY_XF86Break 0x1008119b")]
    public const int XKB_KEY_XF86Break = 0x1008119b;

    [NativeTypeName("#define XKB_KEY_XF86VideoPhone 0x100811a0")]
    public const int XKB_KEY_XF86VideoPhone = 0x100811a0;

    [NativeTypeName("#define XKB_KEY_XF86ZoomReset 0x100811a4")]
    public const int XKB_KEY_XF86ZoomReset = 0x100811a4;

    [NativeTypeName("#define XKB_KEY_XF86Editor 0x100811a6")]
    public const int XKB_KEY_XF86Editor = 0x100811a6;

    [NativeTypeName("#define XKB_KEY_XF86GraphicsEditor 0x100811a8")]
    public const int XKB_KEY_XF86GraphicsEditor = 0x100811a8;

    [NativeTypeName("#define XKB_KEY_XF86Presentation 0x100811a9")]
    public const int XKB_KEY_XF86Presentation = 0x100811a9;

    [NativeTypeName("#define XKB_KEY_XF86Database 0x100811aa")]
    public const int XKB_KEY_XF86Database = 0x100811aa;

    [NativeTypeName("#define XKB_KEY_XF86Voicemail 0x100811ac")]
    public const int XKB_KEY_XF86Voicemail = 0x100811ac;

    [NativeTypeName("#define XKB_KEY_XF86Addressbook 0x100811ad")]
    public const int XKB_KEY_XF86Addressbook = 0x100811ad;

    [NativeTypeName("#define XKB_KEY_XF86DisplayToggle 0x100811af")]
    public const int XKB_KEY_XF86DisplayToggle = 0x100811af;

    [NativeTypeName("#define XKB_KEY_XF86SpellCheck 0x100811b0")]
    public const int XKB_KEY_XF86SpellCheck = 0x100811b0;

    [NativeTypeName("#define XKB_KEY_XF86ContextMenu 0x100811b6")]
    public const int XKB_KEY_XF86ContextMenu = 0x100811b6;

    [NativeTypeName("#define XKB_KEY_XF86MediaRepeat 0x100811b7")]
    public const int XKB_KEY_XF86MediaRepeat = 0x100811b7;

    [NativeTypeName("#define XKB_KEY_XF8610ChannelsUp 0x100811b8")]
    public const int XKB_KEY_XF8610ChannelsUp = 0x100811b8;

    [NativeTypeName("#define XKB_KEY_XF8610ChannelsDown 0x100811b9")]
    public const int XKB_KEY_XF8610ChannelsDown = 0x100811b9;

    [NativeTypeName("#define XKB_KEY_XF86Images 0x100811ba")]
    public const int XKB_KEY_XF86Images = 0x100811ba;

    [NativeTypeName("#define XKB_KEY_XF86NotificationCenter 0x100811bc")]
    public const int XKB_KEY_XF86NotificationCenter = 0x100811bc;

    [NativeTypeName("#define XKB_KEY_XF86PickupPhone 0x100811bd")]
    public const int XKB_KEY_XF86PickupPhone = 0x100811bd;

    [NativeTypeName("#define XKB_KEY_XF86HangupPhone 0x100811be")]
    public const int XKB_KEY_XF86HangupPhone = 0x100811be;

    [NativeTypeName("#define XKB_KEY_XF86Fn 0x100811d0")]
    public const int XKB_KEY_XF86Fn = 0x100811d0;

    [NativeTypeName("#define XKB_KEY_XF86Fn_Esc 0x100811d1")]
    public const int XKB_KEY_XF86Fn_Esc = 0x100811d1;

    [NativeTypeName("#define XKB_KEY_XF86FnRightShift 0x100811e5")]
    public const int XKB_KEY_XF86FnRightShift = 0x100811e5;

    [NativeTypeName("#define XKB_KEY_XF86Numeric0 0x10081200")]
    public const int XKB_KEY_XF86Numeric0 = 0x10081200;

    [NativeTypeName("#define XKB_KEY_XF86Numeric1 0x10081201")]
    public const int XKB_KEY_XF86Numeric1 = 0x10081201;

    [NativeTypeName("#define XKB_KEY_XF86Numeric2 0x10081202")]
    public const int XKB_KEY_XF86Numeric2 = 0x10081202;

    [NativeTypeName("#define XKB_KEY_XF86Numeric3 0x10081203")]
    public const int XKB_KEY_XF86Numeric3 = 0x10081203;

    [NativeTypeName("#define XKB_KEY_XF86Numeric4 0x10081204")]
    public const int XKB_KEY_XF86Numeric4 = 0x10081204;

    [NativeTypeName("#define XKB_KEY_XF86Numeric5 0x10081205")]
    public const int XKB_KEY_XF86Numeric5 = 0x10081205;

    [NativeTypeName("#define XKB_KEY_XF86Numeric6 0x10081206")]
    public const int XKB_KEY_XF86Numeric6 = 0x10081206;

    [NativeTypeName("#define XKB_KEY_XF86Numeric7 0x10081207")]
    public const int XKB_KEY_XF86Numeric7 = 0x10081207;

    [NativeTypeName("#define XKB_KEY_XF86Numeric8 0x10081208")]
    public const int XKB_KEY_XF86Numeric8 = 0x10081208;

    [NativeTypeName("#define XKB_KEY_XF86Numeric9 0x10081209")]
    public const int XKB_KEY_XF86Numeric9 = 0x10081209;

    [NativeTypeName("#define XKB_KEY_XF86NumericStar 0x1008120a")]
    public const int XKB_KEY_XF86NumericStar = 0x1008120a;

    [NativeTypeName("#define XKB_KEY_XF86NumericPound 0x1008120b")]
    public const int XKB_KEY_XF86NumericPound = 0x1008120b;

    [NativeTypeName("#define XKB_KEY_XF86NumericA 0x1008120c")]
    public const int XKB_KEY_XF86NumericA = 0x1008120c;

    [NativeTypeName("#define XKB_KEY_XF86NumericB 0x1008120d")]
    public const int XKB_KEY_XF86NumericB = 0x1008120d;

    [NativeTypeName("#define XKB_KEY_XF86NumericC 0x1008120e")]
    public const int XKB_KEY_XF86NumericC = 0x1008120e;

    [NativeTypeName("#define XKB_KEY_XF86NumericD 0x1008120f")]
    public const int XKB_KEY_XF86NumericD = 0x1008120f;

    [NativeTypeName("#define XKB_KEY_XF86CameraFocus 0x10081210")]
    public const int XKB_KEY_XF86CameraFocus = 0x10081210;

    [NativeTypeName("#define XKB_KEY_XF86WPSButton 0x10081211")]
    public const int XKB_KEY_XF86WPSButton = 0x10081211;

    [NativeTypeName("#define XKB_KEY_XF86CameraZoomIn 0x10081215")]
    public const int XKB_KEY_XF86CameraZoomIn = 0x10081215;

    [NativeTypeName("#define XKB_KEY_XF86CameraZoomOut 0x10081216")]
    public const int XKB_KEY_XF86CameraZoomOut = 0x10081216;

    [NativeTypeName("#define XKB_KEY_XF86CameraUp 0x10081217")]
    public const int XKB_KEY_XF86CameraUp = 0x10081217;

    [NativeTypeName("#define XKB_KEY_XF86CameraDown 0x10081218")]
    public const int XKB_KEY_XF86CameraDown = 0x10081218;

    [NativeTypeName("#define XKB_KEY_XF86CameraLeft 0x10081219")]
    public const int XKB_KEY_XF86CameraLeft = 0x10081219;

    [NativeTypeName("#define XKB_KEY_XF86CameraRight 0x1008121a")]
    public const int XKB_KEY_XF86CameraRight = 0x1008121a;

    [NativeTypeName("#define XKB_KEY_XF86AttendantOn 0x1008121b")]
    public const int XKB_KEY_XF86AttendantOn = 0x1008121b;

    [NativeTypeName("#define XKB_KEY_XF86AttendantOff 0x1008121c")]
    public const int XKB_KEY_XF86AttendantOff = 0x1008121c;

    [NativeTypeName("#define XKB_KEY_XF86AttendantToggle 0x1008121d")]
    public const int XKB_KEY_XF86AttendantToggle = 0x1008121d;

    [NativeTypeName("#define XKB_KEY_XF86LightsToggle 0x1008121e")]
    public const int XKB_KEY_XF86LightsToggle = 0x1008121e;

    [NativeTypeName("#define XKB_KEY_XF86ALSToggle 0x10081230")]
    public const int XKB_KEY_XF86ALSToggle = 0x10081230;

    [NativeTypeName("#define XKB_KEY_XF86Buttonconfig 0x10081240")]
    public const int XKB_KEY_XF86Buttonconfig = 0x10081240;

    [NativeTypeName("#define XKB_KEY_XF86Taskmanager 0x10081241")]
    public const int XKB_KEY_XF86Taskmanager = 0x10081241;

    [NativeTypeName("#define XKB_KEY_XF86Journal 0x10081242")]
    public const int XKB_KEY_XF86Journal = 0x10081242;

    [NativeTypeName("#define XKB_KEY_XF86ControlPanel 0x10081243")]
    public const int XKB_KEY_XF86ControlPanel = 0x10081243;

    [NativeTypeName("#define XKB_KEY_XF86AppSelect 0x10081244")]
    public const int XKB_KEY_XF86AppSelect = 0x10081244;

    [NativeTypeName("#define XKB_KEY_XF86Screensaver 0x10081245")]
    public const int XKB_KEY_XF86Screensaver = 0x10081245;

    [NativeTypeName("#define XKB_KEY_XF86VoiceCommand 0x10081246")]
    public const int XKB_KEY_XF86VoiceCommand = 0x10081246;

    [NativeTypeName("#define XKB_KEY_XF86Assistant 0x10081247")]
    public const int XKB_KEY_XF86Assistant = 0x10081247;

    [NativeTypeName("#define XKB_KEY_XF86BrightnessMin 0x10081250")]
    public const int XKB_KEY_XF86BrightnessMin = 0x10081250;

    [NativeTypeName("#define XKB_KEY_XF86BrightnessMax 0x10081251")]
    public const int XKB_KEY_XF86BrightnessMax = 0x10081251;

    [NativeTypeName("#define XKB_KEY_XF86KbdInputAssistPrev 0x10081260")]
    public const int XKB_KEY_XF86KbdInputAssistPrev = 0x10081260;

    [NativeTypeName("#define XKB_KEY_XF86KbdInputAssistNext 0x10081261")]
    public const int XKB_KEY_XF86KbdInputAssistNext = 0x10081261;

    [NativeTypeName("#define XKB_KEY_XF86KbdInputAssistPrevgroup 0x10081262")]
    public const int XKB_KEY_XF86KbdInputAssistPrevgroup = 0x10081262;

    [NativeTypeName("#define XKB_KEY_XF86KbdInputAssistNextgroup 0x10081263")]
    public const int XKB_KEY_XF86KbdInputAssistNextgroup = 0x10081263;

    [NativeTypeName("#define XKB_KEY_XF86KbdInputAssistAccept 0x10081264")]
    public const int XKB_KEY_XF86KbdInputAssistAccept = 0x10081264;

    [NativeTypeName("#define XKB_KEY_XF86KbdInputAssistCancel 0x10081265")]
    public const int XKB_KEY_XF86KbdInputAssistCancel = 0x10081265;

    [NativeTypeName("#define XKB_KEY_XF86RightUp 0x10081266")]
    public const int XKB_KEY_XF86RightUp = 0x10081266;

    [NativeTypeName("#define XKB_KEY_XF86RightDown 0x10081267")]
    public const int XKB_KEY_XF86RightDown = 0x10081267;

    [NativeTypeName("#define XKB_KEY_XF86LeftUp 0x10081268")]
    public const int XKB_KEY_XF86LeftUp = 0x10081268;

    [NativeTypeName("#define XKB_KEY_XF86LeftDown 0x10081269")]
    public const int XKB_KEY_XF86LeftDown = 0x10081269;

    [NativeTypeName("#define XKB_KEY_XF86RootMenu 0x1008126a")]
    public const int XKB_KEY_XF86RootMenu = 0x1008126a;

    [NativeTypeName("#define XKB_KEY_XF86MediaTopMenu 0x1008126b")]
    public const int XKB_KEY_XF86MediaTopMenu = 0x1008126b;

    [NativeTypeName("#define XKB_KEY_XF86Numeric11 0x1008126c")]
    public const int XKB_KEY_XF86Numeric11 = 0x1008126c;

    [NativeTypeName("#define XKB_KEY_XF86Numeric12 0x1008126d")]
    public const int XKB_KEY_XF86Numeric12 = 0x1008126d;

    [NativeTypeName("#define XKB_KEY_XF86AudioDesc 0x1008126e")]
    public const int XKB_KEY_XF86AudioDesc = 0x1008126e;

    [NativeTypeName("#define XKB_KEY_XF863DMode 0x1008126f")]
    public const int XKB_KEY_XF863DMode = 0x1008126f;

    [NativeTypeName("#define XKB_KEY_XF86NextFavorite 0x10081270")]
    public const int XKB_KEY_XF86NextFavorite = 0x10081270;

    [NativeTypeName("#define XKB_KEY_XF86StopRecord 0x10081271")]
    public const int XKB_KEY_XF86StopRecord = 0x10081271;

    [NativeTypeName("#define XKB_KEY_XF86PauseRecord 0x10081272")]
    public const int XKB_KEY_XF86PauseRecord = 0x10081272;

    [NativeTypeName("#define XKB_KEY_XF86VOD 0x10081273")]
    public const int XKB_KEY_XF86VOD = 0x10081273;

    [NativeTypeName("#define XKB_KEY_XF86Unmute 0x10081274")]
    public const int XKB_KEY_XF86Unmute = 0x10081274;

    [NativeTypeName("#define XKB_KEY_XF86FastReverse 0x10081275")]
    public const int XKB_KEY_XF86FastReverse = 0x10081275;

    [NativeTypeName("#define XKB_KEY_XF86SlowReverse 0x10081276")]
    public const int XKB_KEY_XF86SlowReverse = 0x10081276;

    [NativeTypeName("#define XKB_KEY_XF86Data 0x10081277")]
    public const int XKB_KEY_XF86Data = 0x10081277;

    [NativeTypeName("#define XKB_KEY_XF86OnScreenKeyboard 0x10081278")]
    public const int XKB_KEY_XF86OnScreenKeyboard = 0x10081278;

    [NativeTypeName("#define XKB_KEY_XF86PrivacyScreenToggle 0x10081279")]
    public const int XKB_KEY_XF86PrivacyScreenToggle = 0x10081279;

    [NativeTypeName("#define XKB_KEY_XF86SelectiveScreenshot 0x1008127a")]
    public const int XKB_KEY_XF86SelectiveScreenshot = 0x1008127a;

    [NativeTypeName("#define XKB_KEY_XF86Macro1 0x10081290")]
    public const int XKB_KEY_XF86Macro1 = 0x10081290;

    [NativeTypeName("#define XKB_KEY_XF86Macro2 0x10081291")]
    public const int XKB_KEY_XF86Macro2 = 0x10081291;

    [NativeTypeName("#define XKB_KEY_XF86Macro3 0x10081292")]
    public const int XKB_KEY_XF86Macro3 = 0x10081292;

    [NativeTypeName("#define XKB_KEY_XF86Macro4 0x10081293")]
    public const int XKB_KEY_XF86Macro4 = 0x10081293;

    [NativeTypeName("#define XKB_KEY_XF86Macro5 0x10081294")]
    public const int XKB_KEY_XF86Macro5 = 0x10081294;

    [NativeTypeName("#define XKB_KEY_XF86Macro6 0x10081295")]
    public const int XKB_KEY_XF86Macro6 = 0x10081295;

    [NativeTypeName("#define XKB_KEY_XF86Macro7 0x10081296")]
    public const int XKB_KEY_XF86Macro7 = 0x10081296;

    [NativeTypeName("#define XKB_KEY_XF86Macro8 0x10081297")]
    public const int XKB_KEY_XF86Macro8 = 0x10081297;

    [NativeTypeName("#define XKB_KEY_XF86Macro9 0x10081298")]
    public const int XKB_KEY_XF86Macro9 = 0x10081298;

    [NativeTypeName("#define XKB_KEY_XF86Macro10 0x10081299")]
    public const int XKB_KEY_XF86Macro10 = 0x10081299;

    [NativeTypeName("#define XKB_KEY_XF86Macro11 0x1008129a")]
    public const int XKB_KEY_XF86Macro11 = 0x1008129a;

    [NativeTypeName("#define XKB_KEY_XF86Macro12 0x1008129b")]
    public const int XKB_KEY_XF86Macro12 = 0x1008129b;

    [NativeTypeName("#define XKB_KEY_XF86Macro13 0x1008129c")]
    public const int XKB_KEY_XF86Macro13 = 0x1008129c;

    [NativeTypeName("#define XKB_KEY_XF86Macro14 0x1008129d")]
    public const int XKB_KEY_XF86Macro14 = 0x1008129d;

    [NativeTypeName("#define XKB_KEY_XF86Macro15 0x1008129e")]
    public const int XKB_KEY_XF86Macro15 = 0x1008129e;

    [NativeTypeName("#define XKB_KEY_XF86Macro16 0x1008129f")]
    public const int XKB_KEY_XF86Macro16 = 0x1008129f;

    [NativeTypeName("#define XKB_KEY_XF86Macro17 0x100812a0")]
    public const int XKB_KEY_XF86Macro17 = 0x100812a0;

    [NativeTypeName("#define XKB_KEY_XF86Macro18 0x100812a1")]
    public const int XKB_KEY_XF86Macro18 = 0x100812a1;

    [NativeTypeName("#define XKB_KEY_XF86Macro19 0x100812a2")]
    public const int XKB_KEY_XF86Macro19 = 0x100812a2;

    [NativeTypeName("#define XKB_KEY_XF86Macro20 0x100812a3")]
    public const int XKB_KEY_XF86Macro20 = 0x100812a3;

    [NativeTypeName("#define XKB_KEY_XF86Macro21 0x100812a4")]
    public const int XKB_KEY_XF86Macro21 = 0x100812a4;

    [NativeTypeName("#define XKB_KEY_XF86Macro22 0x100812a5")]
    public const int XKB_KEY_XF86Macro22 = 0x100812a5;

    [NativeTypeName("#define XKB_KEY_XF86Macro23 0x100812a6")]
    public const int XKB_KEY_XF86Macro23 = 0x100812a6;

    [NativeTypeName("#define XKB_KEY_XF86Macro24 0x100812a7")]
    public const int XKB_KEY_XF86Macro24 = 0x100812a7;

    [NativeTypeName("#define XKB_KEY_XF86Macro25 0x100812a8")]
    public const int XKB_KEY_XF86Macro25 = 0x100812a8;

    [NativeTypeName("#define XKB_KEY_XF86Macro26 0x100812a9")]
    public const int XKB_KEY_XF86Macro26 = 0x100812a9;

    [NativeTypeName("#define XKB_KEY_XF86Macro27 0x100812aa")]
    public const int XKB_KEY_XF86Macro27 = 0x100812aa;

    [NativeTypeName("#define XKB_KEY_XF86Macro28 0x100812ab")]
    public const int XKB_KEY_XF86Macro28 = 0x100812ab;

    [NativeTypeName("#define XKB_KEY_XF86Macro29 0x100812ac")]
    public const int XKB_KEY_XF86Macro29 = 0x100812ac;

    [NativeTypeName("#define XKB_KEY_XF86Macro30 0x100812ad")]
    public const int XKB_KEY_XF86Macro30 = 0x100812ad;

    [NativeTypeName("#define XKB_KEY_XF86MacroRecordStart 0x100812b0")]
    public const int XKB_KEY_XF86MacroRecordStart = 0x100812b0;

    [NativeTypeName("#define XKB_KEY_XF86MacroRecordStop 0x100812b1")]
    public const int XKB_KEY_XF86MacroRecordStop = 0x100812b1;

    [NativeTypeName("#define XKB_KEY_XF86MacroPresetCycle 0x100812b2")]
    public const int XKB_KEY_XF86MacroPresetCycle = 0x100812b2;

    [NativeTypeName("#define XKB_KEY_XF86MacroPreset1 0x100812b3")]
    public const int XKB_KEY_XF86MacroPreset1 = 0x100812b3;

    [NativeTypeName("#define XKB_KEY_XF86MacroPreset2 0x100812b4")]
    public const int XKB_KEY_XF86MacroPreset2 = 0x100812b4;

    [NativeTypeName("#define XKB_KEY_XF86MacroPreset3 0x100812b5")]
    public const int XKB_KEY_XF86MacroPreset3 = 0x100812b5;

    [NativeTypeName("#define XKB_KEY_XF86KbdLcdMenu1 0x100812b8")]
    public const int XKB_KEY_XF86KbdLcdMenu1 = 0x100812b8;

    [NativeTypeName("#define XKB_KEY_XF86KbdLcdMenu2 0x100812b9")]
    public const int XKB_KEY_XF86KbdLcdMenu2 = 0x100812b9;

    [NativeTypeName("#define XKB_KEY_XF86KbdLcdMenu3 0x100812ba")]
    public const int XKB_KEY_XF86KbdLcdMenu3 = 0x100812ba;

    [NativeTypeName("#define XKB_KEY_XF86KbdLcdMenu4 0x100812bb")]
    public const int XKB_KEY_XF86KbdLcdMenu4 = 0x100812bb;

    [NativeTypeName("#define XKB_KEY_XF86KbdLcdMenu5 0x100812bc")]
    public const int XKB_KEY_XF86KbdLcdMenu5 = 0x100812bc;

    [NativeTypeName("#define XKB_KEY_SunFA_Grave 0x1005FF00")]
    public const int XKB_KEY_SunFA_Grave = 0x1005FF00;

    [NativeTypeName("#define XKB_KEY_SunFA_Circum 0x1005FF01")]
    public const int XKB_KEY_SunFA_Circum = 0x1005FF01;

    [NativeTypeName("#define XKB_KEY_SunFA_Tilde 0x1005FF02")]
    public const int XKB_KEY_SunFA_Tilde = 0x1005FF02;

    [NativeTypeName("#define XKB_KEY_SunFA_Acute 0x1005FF03")]
    public const int XKB_KEY_SunFA_Acute = 0x1005FF03;

    [NativeTypeName("#define XKB_KEY_SunFA_Diaeresis 0x1005FF04")]
    public const int XKB_KEY_SunFA_Diaeresis = 0x1005FF04;

    [NativeTypeName("#define XKB_KEY_SunFA_Cedilla 0x1005FF05")]
    public const int XKB_KEY_SunFA_Cedilla = 0x1005FF05;

    [NativeTypeName("#define XKB_KEY_SunF36 0x1005FF10")]
    public const int XKB_KEY_SunF36 = 0x1005FF10;

    [NativeTypeName("#define XKB_KEY_SunF37 0x1005FF11")]
    public const int XKB_KEY_SunF37 = 0x1005FF11;

    [NativeTypeName("#define XKB_KEY_SunSys_Req 0x1005FF60")]
    public const int XKB_KEY_SunSys_Req = 0x1005FF60;

    [NativeTypeName("#define XKB_KEY_SunPrint_Screen 0x0000FF61")]
    public const int XKB_KEY_SunPrint_Screen = 0x0000FF61;

    [NativeTypeName("#define XKB_KEY_SunCompose 0x0000FF20")]
    public const int XKB_KEY_SunCompose = 0x0000FF20;

    [NativeTypeName("#define XKB_KEY_SunAltGraph 0x0000FF7E")]
    public const int XKB_KEY_SunAltGraph = 0x0000FF7E;

    [NativeTypeName("#define XKB_KEY_SunPageUp 0x0000FF55")]
    public const int XKB_KEY_SunPageUp = 0x0000FF55;

    [NativeTypeName("#define XKB_KEY_SunPageDown 0x0000FF56")]
    public const int XKB_KEY_SunPageDown = 0x0000FF56;

    [NativeTypeName("#define XKB_KEY_SunUndo 0x0000FF65")]
    public const int XKB_KEY_SunUndo = 0x0000FF65;

    [NativeTypeName("#define XKB_KEY_SunAgain 0x0000FF66")]
    public const int XKB_KEY_SunAgain = 0x0000FF66;

    [NativeTypeName("#define XKB_KEY_SunFind 0x0000FF68")]
    public const int XKB_KEY_SunFind = 0x0000FF68;

    [NativeTypeName("#define XKB_KEY_SunStop 0x0000FF69")]
    public const int XKB_KEY_SunStop = 0x0000FF69;

    [NativeTypeName("#define XKB_KEY_SunProps 0x1005FF70")]
    public const int XKB_KEY_SunProps = 0x1005FF70;

    [NativeTypeName("#define XKB_KEY_SunFront 0x1005FF71")]
    public const int XKB_KEY_SunFront = 0x1005FF71;

    [NativeTypeName("#define XKB_KEY_SunCopy 0x1005FF72")]
    public const int XKB_KEY_SunCopy = 0x1005FF72;

    [NativeTypeName("#define XKB_KEY_SunOpen 0x1005FF73")]
    public const int XKB_KEY_SunOpen = 0x1005FF73;

    [NativeTypeName("#define XKB_KEY_SunPaste 0x1005FF74")]
    public const int XKB_KEY_SunPaste = 0x1005FF74;

    [NativeTypeName("#define XKB_KEY_SunCut 0x1005FF75")]
    public const int XKB_KEY_SunCut = 0x1005FF75;

    [NativeTypeName("#define XKB_KEY_SunPowerSwitch 0x1005FF76")]
    public const int XKB_KEY_SunPowerSwitch = 0x1005FF76;

    [NativeTypeName("#define XKB_KEY_SunAudioLowerVolume 0x1005FF77")]
    public const int XKB_KEY_SunAudioLowerVolume = 0x1005FF77;

    [NativeTypeName("#define XKB_KEY_SunAudioMute 0x1005FF78")]
    public const int XKB_KEY_SunAudioMute = 0x1005FF78;

    [NativeTypeName("#define XKB_KEY_SunAudioRaiseVolume 0x1005FF79")]
    public const int XKB_KEY_SunAudioRaiseVolume = 0x1005FF79;

    [NativeTypeName("#define XKB_KEY_SunVideoDegauss 0x1005FF7A")]
    public const int XKB_KEY_SunVideoDegauss = 0x1005FF7A;

    [NativeTypeName("#define XKB_KEY_SunVideoLowerBrightness 0x1005FF7B")]
    public const int XKB_KEY_SunVideoLowerBrightness = 0x1005FF7B;

    [NativeTypeName("#define XKB_KEY_SunVideoRaiseBrightness 0x1005FF7C")]
    public const int XKB_KEY_SunVideoRaiseBrightness = 0x1005FF7C;

    [NativeTypeName("#define XKB_KEY_SunPowerSwitchShift 0x1005FF7D")]
    public const int XKB_KEY_SunPowerSwitchShift = 0x1005FF7D;

    [NativeTypeName("#define XKB_KEY_Dring_accent 0x1000FEB0")]
    public const int XKB_KEY_Dring_accent = 0x1000FEB0;

    [NativeTypeName("#define XKB_KEY_Dcircumflex_accent 0x1000FE5E")]
    public const int XKB_KEY_Dcircumflex_accent = 0x1000FE5E;

    [NativeTypeName("#define XKB_KEY_Dcedilla_accent 0x1000FE2C")]
    public const int XKB_KEY_Dcedilla_accent = 0x1000FE2C;

    [NativeTypeName("#define XKB_KEY_Dacute_accent 0x1000FE27")]
    public const int XKB_KEY_Dacute_accent = 0x1000FE27;

    [NativeTypeName("#define XKB_KEY_Dgrave_accent 0x1000FE60")]
    public const int XKB_KEY_Dgrave_accent = 0x1000FE60;

    [NativeTypeName("#define XKB_KEY_Dtilde 0x1000FE7E")]
    public const int XKB_KEY_Dtilde = 0x1000FE7E;

    [NativeTypeName("#define XKB_KEY_Ddiaeresis 0x1000FE22")]
    public const int XKB_KEY_Ddiaeresis = 0x1000FE22;

    [NativeTypeName("#define XKB_KEY_DRemove 0x1000FF00")]
    public const int XKB_KEY_DRemove = 0x1000FF00;

    [NativeTypeName("#define XKB_KEY_hpClearLine 0x1000FF6F")]
    public const int XKB_KEY_hpClearLine = 0x1000FF6F;

    [NativeTypeName("#define XKB_KEY_hpInsertLine 0x1000FF70")]
    public const int XKB_KEY_hpInsertLine = 0x1000FF70;

    [NativeTypeName("#define XKB_KEY_hpDeleteLine 0x1000FF71")]
    public const int XKB_KEY_hpDeleteLine = 0x1000FF71;

    [NativeTypeName("#define XKB_KEY_hpInsertChar 0x1000FF72")]
    public const int XKB_KEY_hpInsertChar = 0x1000FF72;

    [NativeTypeName("#define XKB_KEY_hpDeleteChar 0x1000FF73")]
    public const int XKB_KEY_hpDeleteChar = 0x1000FF73;

    [NativeTypeName("#define XKB_KEY_hpBackTab 0x1000FF74")]
    public const int XKB_KEY_hpBackTab = 0x1000FF74;

    [NativeTypeName("#define XKB_KEY_hpKP_BackTab 0x1000FF75")]
    public const int XKB_KEY_hpKP_BackTab = 0x1000FF75;

    [NativeTypeName("#define XKB_KEY_hpModelock1 0x1000FF48")]
    public const int XKB_KEY_hpModelock1 = 0x1000FF48;

    [NativeTypeName("#define XKB_KEY_hpModelock2 0x1000FF49")]
    public const int XKB_KEY_hpModelock2 = 0x1000FF49;

    [NativeTypeName("#define XKB_KEY_hpReset 0x1000FF6C")]
    public const int XKB_KEY_hpReset = 0x1000FF6C;

    [NativeTypeName("#define XKB_KEY_hpSystem 0x1000FF6D")]
    public const int XKB_KEY_hpSystem = 0x1000FF6D;

    [NativeTypeName("#define XKB_KEY_hpUser 0x1000FF6E")]
    public const int XKB_KEY_hpUser = 0x1000FF6E;

    [NativeTypeName("#define XKB_KEY_hpmute_acute 0x100000A8")]
    public const int XKB_KEY_hpmute_acute = 0x100000A8;

    [NativeTypeName("#define XKB_KEY_hpmute_grave 0x100000A9")]
    public const int XKB_KEY_hpmute_grave = 0x100000A9;

    [NativeTypeName("#define XKB_KEY_hpmute_asciicircum 0x100000AA")]
    public const int XKB_KEY_hpmute_asciicircum = 0x100000AA;

    [NativeTypeName("#define XKB_KEY_hpmute_diaeresis 0x100000AB")]
    public const int XKB_KEY_hpmute_diaeresis = 0x100000AB;

    [NativeTypeName("#define XKB_KEY_hpmute_asciitilde 0x100000AC")]
    public const int XKB_KEY_hpmute_asciitilde = 0x100000AC;

    [NativeTypeName("#define XKB_KEY_hplira 0x100000AF")]
    public const int XKB_KEY_hplira = 0x100000AF;

    [NativeTypeName("#define XKB_KEY_hpguilder 0x100000BE")]
    public const int XKB_KEY_hpguilder = 0x100000BE;

    [NativeTypeName("#define XKB_KEY_hpYdiaeresis 0x100000EE")]
    public const int XKB_KEY_hpYdiaeresis = 0x100000EE;

    [NativeTypeName("#define XKB_KEY_hpIO 0x100000EE")]
    public const int XKB_KEY_hpIO = 0x100000EE;

    [NativeTypeName("#define XKB_KEY_hplongminus 0x100000F6")]
    public const int XKB_KEY_hplongminus = 0x100000F6;

    [NativeTypeName("#define XKB_KEY_hpblock 0x100000FC")]
    public const int XKB_KEY_hpblock = 0x100000FC;

    [NativeTypeName("#define XKB_KEY_osfCopy 0x1004FF02")]
    public const int XKB_KEY_osfCopy = 0x1004FF02;

    [NativeTypeName("#define XKB_KEY_osfCut 0x1004FF03")]
    public const int XKB_KEY_osfCut = 0x1004FF03;

    [NativeTypeName("#define XKB_KEY_osfPaste 0x1004FF04")]
    public const int XKB_KEY_osfPaste = 0x1004FF04;

    [NativeTypeName("#define XKB_KEY_osfBackTab 0x1004FF07")]
    public const int XKB_KEY_osfBackTab = 0x1004FF07;

    [NativeTypeName("#define XKB_KEY_osfBackSpace 0x1004FF08")]
    public const int XKB_KEY_osfBackSpace = 0x1004FF08;

    [NativeTypeName("#define XKB_KEY_osfClear 0x1004FF0B")]
    public const int XKB_KEY_osfClear = 0x1004FF0B;

    [NativeTypeName("#define XKB_KEY_osfEscape 0x1004FF1B")]
    public const int XKB_KEY_osfEscape = 0x1004FF1B;

    [NativeTypeName("#define XKB_KEY_osfAddMode 0x1004FF31")]
    public const int XKB_KEY_osfAddMode = 0x1004FF31;

    [NativeTypeName("#define XKB_KEY_osfPrimaryPaste 0x1004FF32")]
    public const int XKB_KEY_osfPrimaryPaste = 0x1004FF32;

    [NativeTypeName("#define XKB_KEY_osfQuickPaste 0x1004FF33")]
    public const int XKB_KEY_osfQuickPaste = 0x1004FF33;

    [NativeTypeName("#define XKB_KEY_osfPageLeft 0x1004FF40")]
    public const int XKB_KEY_osfPageLeft = 0x1004FF40;

    [NativeTypeName("#define XKB_KEY_osfPageUp 0x1004FF41")]
    public const int XKB_KEY_osfPageUp = 0x1004FF41;

    [NativeTypeName("#define XKB_KEY_osfPageDown 0x1004FF42")]
    public const int XKB_KEY_osfPageDown = 0x1004FF42;

    [NativeTypeName("#define XKB_KEY_osfPageRight 0x1004FF43")]
    public const int XKB_KEY_osfPageRight = 0x1004FF43;

    [NativeTypeName("#define XKB_KEY_osfActivate 0x1004FF44")]
    public const int XKB_KEY_osfActivate = 0x1004FF44;

    [NativeTypeName("#define XKB_KEY_osfMenuBar 0x1004FF45")]
    public const int XKB_KEY_osfMenuBar = 0x1004FF45;

    [NativeTypeName("#define XKB_KEY_osfLeft 0x1004FF51")]
    public const int XKB_KEY_osfLeft = 0x1004FF51;

    [NativeTypeName("#define XKB_KEY_osfUp 0x1004FF52")]
    public const int XKB_KEY_osfUp = 0x1004FF52;

    [NativeTypeName("#define XKB_KEY_osfRight 0x1004FF53")]
    public const int XKB_KEY_osfRight = 0x1004FF53;

    [NativeTypeName("#define XKB_KEY_osfDown 0x1004FF54")]
    public const int XKB_KEY_osfDown = 0x1004FF54;

    [NativeTypeName("#define XKB_KEY_osfEndLine 0x1004FF57")]
    public const int XKB_KEY_osfEndLine = 0x1004FF57;

    [NativeTypeName("#define XKB_KEY_osfBeginLine 0x1004FF58")]
    public const int XKB_KEY_osfBeginLine = 0x1004FF58;

    [NativeTypeName("#define XKB_KEY_osfEndData 0x1004FF59")]
    public const int XKB_KEY_osfEndData = 0x1004FF59;

    [NativeTypeName("#define XKB_KEY_osfBeginData 0x1004FF5A")]
    public const int XKB_KEY_osfBeginData = 0x1004FF5A;

    [NativeTypeName("#define XKB_KEY_osfPrevMenu 0x1004FF5B")]
    public const int XKB_KEY_osfPrevMenu = 0x1004FF5B;

    [NativeTypeName("#define XKB_KEY_osfNextMenu 0x1004FF5C")]
    public const int XKB_KEY_osfNextMenu = 0x1004FF5C;

    [NativeTypeName("#define XKB_KEY_osfPrevField 0x1004FF5D")]
    public const int XKB_KEY_osfPrevField = 0x1004FF5D;

    [NativeTypeName("#define XKB_KEY_osfNextField 0x1004FF5E")]
    public const int XKB_KEY_osfNextField = 0x1004FF5E;

    [NativeTypeName("#define XKB_KEY_osfSelect 0x1004FF60")]
    public const int XKB_KEY_osfSelect = 0x1004FF60;

    [NativeTypeName("#define XKB_KEY_osfInsert 0x1004FF63")]
    public const int XKB_KEY_osfInsert = 0x1004FF63;

    [NativeTypeName("#define XKB_KEY_osfUndo 0x1004FF65")]
    public const int XKB_KEY_osfUndo = 0x1004FF65;

    [NativeTypeName("#define XKB_KEY_osfMenu 0x1004FF67")]
    public const int XKB_KEY_osfMenu = 0x1004FF67;

    [NativeTypeName("#define XKB_KEY_osfCancel 0x1004FF69")]
    public const int XKB_KEY_osfCancel = 0x1004FF69;

    [NativeTypeName("#define XKB_KEY_osfHelp 0x1004FF6A")]
    public const int XKB_KEY_osfHelp = 0x1004FF6A;

    [NativeTypeName("#define XKB_KEY_osfSelectAll 0x1004FF71")]
    public const int XKB_KEY_osfSelectAll = 0x1004FF71;

    [NativeTypeName("#define XKB_KEY_osfDeselectAll 0x1004FF72")]
    public const int XKB_KEY_osfDeselectAll = 0x1004FF72;

    [NativeTypeName("#define XKB_KEY_osfReselect 0x1004FF73")]
    public const int XKB_KEY_osfReselect = 0x1004FF73;

    [NativeTypeName("#define XKB_KEY_osfExtend 0x1004FF74")]
    public const int XKB_KEY_osfExtend = 0x1004FF74;

    [NativeTypeName("#define XKB_KEY_osfRestore 0x1004FF78")]
    public const int XKB_KEY_osfRestore = 0x1004FF78;

    [NativeTypeName("#define XKB_KEY_osfDelete 0x1004FFFF")]
    public const int XKB_KEY_osfDelete = 0x1004FFFF;

    [NativeTypeName("#define XKB_KEY_Reset 0x1000FF6C")]
    public const int XKB_KEY_Reset = 0x1000FF6C;

    [NativeTypeName("#define XKB_KEY_System 0x1000FF6D")]
    public const int XKB_KEY_System = 0x1000FF6D;

    [NativeTypeName("#define XKB_KEY_User 0x1000FF6E")]
    public const int XKB_KEY_User = 0x1000FF6E;

    [NativeTypeName("#define XKB_KEY_ClearLine 0x1000FF6F")]
    public const int XKB_KEY_ClearLine = 0x1000FF6F;

    [NativeTypeName("#define XKB_KEY_InsertLine 0x1000FF70")]
    public const int XKB_KEY_InsertLine = 0x1000FF70;

    [NativeTypeName("#define XKB_KEY_DeleteLine 0x1000FF71")]
    public const int XKB_KEY_DeleteLine = 0x1000FF71;

    [NativeTypeName("#define XKB_KEY_InsertChar 0x1000FF72")]
    public const int XKB_KEY_InsertChar = 0x1000FF72;

    [NativeTypeName("#define XKB_KEY_DeleteChar 0x1000FF73")]
    public const int XKB_KEY_DeleteChar = 0x1000FF73;

    [NativeTypeName("#define XKB_KEY_BackTab 0x1000FF74")]
    public const int XKB_KEY_BackTab = 0x1000FF74;

    [NativeTypeName("#define XKB_KEY_KP_BackTab 0x1000FF75")]
    public const int XKB_KEY_KP_BackTab = 0x1000FF75;

    [NativeTypeName("#define XKB_KEY_Ext16bit_L 0x1000FF76")]
    public const int XKB_KEY_Ext16bit_L = 0x1000FF76;

    [NativeTypeName("#define XKB_KEY_Ext16bit_R 0x1000FF77")]
    public const int XKB_KEY_Ext16bit_R = 0x1000FF77;

    [NativeTypeName("#define XKB_KEY_mute_acute 0x100000a8")]
    public const int XKB_KEY_mute_acute = 0x100000a8;

    [NativeTypeName("#define XKB_KEY_mute_grave 0x100000a9")]
    public const int XKB_KEY_mute_grave = 0x100000a9;

    [NativeTypeName("#define XKB_KEY_mute_asciicircum 0x100000aa")]
    public const int XKB_KEY_mute_asciicircum = 0x100000aa;

    [NativeTypeName("#define XKB_KEY_mute_diaeresis 0x100000ab")]
    public const int XKB_KEY_mute_diaeresis = 0x100000ab;

    [NativeTypeName("#define XKB_KEY_mute_asciitilde 0x100000ac")]
    public const int XKB_KEY_mute_asciitilde = 0x100000ac;

    [NativeTypeName("#define XKB_KEY_lira 0x100000af")]
    public const int XKB_KEY_lira = 0x100000af;

    [NativeTypeName("#define XKB_KEY_guilder 0x100000be")]
    public const int XKB_KEY_guilder = 0x100000be;

    [NativeTypeName("#define XKB_KEY_IO 0x100000ee")]
    public const int XKB_KEY_IO = 0x100000ee;

    [NativeTypeName("#define XKB_KEY_longminus 0x100000f6")]
    public const int XKB_KEY_longminus = 0x100000f6;

    [NativeTypeName("#define XKB_KEY_block 0x100000fc")]
    public const int XKB_KEY_block = 0x100000fc;
}
