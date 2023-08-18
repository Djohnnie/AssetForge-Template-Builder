using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace AssetForgeTemplateBuilder;

internal class ModelFileBuilder
{
    public Color PaletteColor01 { get; set; }
    public Color PaletteColor02 { get; set; }
    public Color PaletteColor03 { get; set; }
    public Color PaletteColor04 { get; set; }
    public Color PaletteColor05 { get; set; }
    public Color PaletteColor06 { get; set; }
    public Color PaletteColor07 { get; set; }
    public Color PaletteColor08 { get; set; }
    public Color PaletteColor09 { get; set; }
    public Color PaletteColor10 { get; set; }
    public Color PaletteColor11 { get; set; }
    public Color PaletteColor12 { get; set; }
    public Color PaletteColor13 { get; set; }
    public Color PaletteColor14 { get; set; }
    public Color PaletteColor15 { get; set; }
    public Color PaletteColor16 { get; set; }
    public Color PaletteColor17 { get; set; }
    public Color PaletteColor18 { get; set; }
    public Color PaletteColor19 { get; set; }
    public Color PaletteColor20 { get; set; }
    public Color PaletteColor21 { get; set; }
    public Color PaletteColor22 { get; set; }
    public Color PaletteColor23 { get; set; }
    public Color PaletteColor24 { get; set; }
    public Color PaletteColor25 { get; set; }
    public Color PaletteColor26 { get; set; }
    public Color PaletteColor27 { get; set; }
    public Color PaletteColor28 { get; set; }
    public Color PaletteColor29 { get; set; }
    public Color PaletteColor30 { get; set; }
    public Color PaletteColor31 { get; set; }
    public Color PaletteColor32 { get; set; }
    public Color PaletteColor33 { get; set; }
    public Color PaletteColor34 { get; set; }
    public Color PaletteColor35 { get; set; }
    public Color PaletteColor36 { get; set; }
    public Color PaletteColor37 { get; set; }
    public Color PaletteColor38 { get; set; }
    public Color PaletteColor39 { get; set; }
    public Color PaletteColor40 { get; set; }
    public Color PaletteColor41 { get; set; }
    public Color PaletteColor42 { get; set; }
    public Color PaletteColor43 { get; set; }
    public Color PaletteColor44 { get; set; }
    public Color PaletteColor45 { get; set; }
    public Color PaletteColor46 { get; set; }
    public Color PaletteColor47 { get; set; }
    public Color PaletteColor48 { get; set; }
    public Color PaletteColor49 { get; set; }
    public Color PaletteColor50 { get; set; }
    public Color PaletteColor51 { get; set; }
    public Color PaletteColor52 { get; set; }
    public Color PaletteColor53 { get; set; }
    public Color PaletteColor54 { get; set; }
    public Color PaletteColor55 { get; set; }
    public Color PaletteColor56 { get; set; }
    public Color PaletteColor57 { get; set; }
    public Color PaletteColor58 { get; set; }
    public Color PaletteColor59 { get; set; }
    public Color PaletteColor60 { get; set; }
    public Color PaletteColor61 { get; set; }
    public Color PaletteColor62 { get; set; }
    public Color PaletteColor63 { get; set; }
    public Color PaletteColor64 { get; set; }

    public byte Width { get; set; }
    public byte Height { get; set; }
    public byte Depth { get; set; }


    public async Task Save(string path)
    {
        var stringBuilder = new StringBuilder();
        stringBuilder.AppendLine("# Made using Asset Forge Template Builder");
        stringBuilder.AppendLine();
        stringBuilder.AppendLine(":materials");
        stringBuilder.AppendLine();

        stringBuilder.AppendLine(FormattableString.Invariant($"[name:palette01;color:RGBA({PaletteColor01.R / 255M:F3}, {PaletteColor01.G / 255M:F3}, {PaletteColor01.B / 255M:F3}, 1.000);scale:(1.0, 1.0);shader:Default;valueA:0.35;valueB:0.25;]"));
        stringBuilder.AppendLine(FormattableString.Invariant($"[name:palette02;color:RGBA({PaletteColor02.R / 255M:F3}, {PaletteColor02.G / 255M:F3}, {PaletteColor02.B / 255M:F3}, 1.000);scale:(1.0, 1.0);shader:Default;valueA:0.35;valueB:0.25;]"));
        stringBuilder.AppendLine(FormattableString.Invariant($"[name:palette03;color:RGBA({PaletteColor03.R / 255M:F3}, {PaletteColor03.G / 255M:F3}, {PaletteColor03.B / 255M:F3}, 1.000);scale:(1.0, 1.0);shader:Default;valueA:0.35;valueB:0.25;]"));
        stringBuilder.AppendLine(FormattableString.Invariant($"[name:palette04;color:RGBA({PaletteColor04.R / 255M:F3}, {PaletteColor04.G / 255M:F3}, {PaletteColor04.B / 255M:F3}, 1.000);scale:(1.0, 1.0);shader:Default;valueA:0.35;valueB:0.25;]"));
        stringBuilder.AppendLine(FormattableString.Invariant($"[name:palette05;color:RGBA({PaletteColor05.R / 255M:F3}, {PaletteColor05.G / 255M:F3}, {PaletteColor05.B / 255M:F3}, 1.000);scale:(1.0, 1.0);shader:Default;valueA:0.35;valueB:0.25;]"));
        stringBuilder.AppendLine(FormattableString.Invariant($"[name:palette06;color:RGBA({PaletteColor06.R / 255M:F3}, {PaletteColor06.G / 255M:F3}, {PaletteColor06.B / 255M:F3}, 1.000);scale:(1.0, 1.0);shader:Default;valueA:0.35;valueB:0.25;]"));
        stringBuilder.AppendLine(FormattableString.Invariant($"[name:palette07;color:RGBA({PaletteColor07.R / 255M:F3}, {PaletteColor07.G / 255M:F3}, {PaletteColor07.B / 255M:F3}, 1.000);scale:(1.0, 1.0);shader:Default;valueA:0.35;valueB:0.25;]"));
        stringBuilder.AppendLine(FormattableString.Invariant($"[name:palette08;color:RGBA({PaletteColor08.R / 255M:F3}, {PaletteColor08.G / 255M:F3}, {PaletteColor08.B / 255M:F3}, 1.000);scale:(1.0, 1.0);shader:Default;valueA:0.35;valueB:0.25;]"));

        stringBuilder.AppendLine(FormattableString.Invariant($"[name:palette09;color:RGBA({PaletteColor09.R / 255M:F3}, {PaletteColor09.G / 255M:F3}, {PaletteColor09.B / 255M:F3}, 1.000);scale:(1.0, 1.0);shader:Default;valueA:0.35;valueB:0.25;]"));
        stringBuilder.AppendLine(FormattableString.Invariant($"[name:palette10;color:RGBA({PaletteColor10.R / 255M:F3}, {PaletteColor10.G / 255M:F3}, {PaletteColor10.B / 255M:F3}, 1.000);scale:(1.0, 1.0);shader:Default;valueA:0.35;valueB:0.25;]"));
        stringBuilder.AppendLine(FormattableString.Invariant($"[name:palette11;color:RGBA({PaletteColor11.R / 255M:F3}, {PaletteColor11.G / 255M:F3}, {PaletteColor11.B / 255M:F3}, 1.000);scale:(1.0, 1.0);shader:Default;valueA:0.35;valueB:0.25;]"));
        stringBuilder.AppendLine(FormattableString.Invariant($"[name:palette12;color:RGBA({PaletteColor12.R / 255M:F3}, {PaletteColor12.G / 255M:F3}, {PaletteColor12.B / 255M:F3}, 1.000);scale:(1.0, 1.0);shader:Default;valueA:0.35;valueB:0.25;]"));
        stringBuilder.AppendLine(FormattableString.Invariant($"[name:palette13;color:RGBA({PaletteColor13.R / 255M:F3}, {PaletteColor13.G / 255M:F3}, {PaletteColor13.B / 255M:F3}, 1.000);scale:(1.0, 1.0);shader:Default;valueA:0.35;valueB:0.25;]"));
        stringBuilder.AppendLine(FormattableString.Invariant($"[name:palette14;color:RGBA({PaletteColor14.R / 255M:F3}, {PaletteColor14.G / 255M:F3}, {PaletteColor14.B / 255M:F3}, 1.000);scale:(1.0, 1.0);shader:Default;valueA:0.35;valueB:0.25;]"));
        stringBuilder.AppendLine(FormattableString.Invariant($"[name:palette15;color:RGBA({PaletteColor15.R / 255M:F3}, {PaletteColor15.G / 255M:F3}, {PaletteColor15.B / 255M:F3}, 1.000);scale:(1.0, 1.0);shader:Default;valueA:0.35;valueB:0.25;]"));
        stringBuilder.AppendLine(FormattableString.Invariant($"[name:palette16;color:RGBA({PaletteColor16.R / 255M:F3}, {PaletteColor16.G / 255M:F3}, {PaletteColor16.B / 255M:F3}, 1.000);scale:(1.0, 1.0);shader:Default;valueA:0.35;valueB:0.25;]"));

        stringBuilder.AppendLine(FormattableString.Invariant($"[name:palette17;color:RGBA({PaletteColor17.R / 255M:F3}, {PaletteColor17.G / 255M:F3}, {PaletteColor17.B / 255M:F3}, 1.000);scale:(1.0, 1.0);shader:Default;valueA:0.35;valueB:0.25;]"));
        stringBuilder.AppendLine(FormattableString.Invariant($"[name:palette18;color:RGBA({PaletteColor18.R / 255M:F3}, {PaletteColor18.G / 255M:F3}, {PaletteColor18.B / 255M:F3}, 1.000);scale:(1.0, 1.0);shader:Default;valueA:0.35;valueB:0.25;]"));
        stringBuilder.AppendLine(FormattableString.Invariant($"[name:palette19;color:RGBA({PaletteColor19.R / 255M:F3}, {PaletteColor19.G / 255M:F3}, {PaletteColor19.B / 255M:F3}, 1.000);scale:(1.0, 1.0);shader:Default;valueA:0.35;valueB:0.25;]"));
        stringBuilder.AppendLine(FormattableString.Invariant($"[name:palette20;color:RGBA({PaletteColor20.R / 255M:F3}, {PaletteColor20.G / 255M:F3}, {PaletteColor20.B / 255M:F3}, 1.000);scale:(1.0, 1.0);shader:Default;valueA:0.35;valueB:0.25;]"));
        stringBuilder.AppendLine(FormattableString.Invariant($"[name:palette21;color:RGBA({PaletteColor21.R / 255M:F3}, {PaletteColor21.G / 255M:F3}, {PaletteColor21.B / 255M:F3}, 1.000);scale:(1.0, 1.0);shader:Default;valueA:0.35;valueB:0.25;]"));
        stringBuilder.AppendLine(FormattableString.Invariant($"[name:palette22;color:RGBA({PaletteColor22.R / 255M:F3}, {PaletteColor22.G / 255M:F3}, {PaletteColor22.B / 255M:F3}, 1.000);scale:(1.0, 1.0);shader:Default;valueA:0.35;valueB:0.25;]"));
        stringBuilder.AppendLine(FormattableString.Invariant($"[name:palette23;color:RGBA({PaletteColor23.R / 255M:F3}, {PaletteColor23.G / 255M:F3}, {PaletteColor23.B / 255M:F3}, 1.000);scale:(1.0, 1.0);shader:Default;valueA:0.35;valueB:0.25;]"));
        stringBuilder.AppendLine(FormattableString.Invariant($"[name:palette24;color:RGBA({PaletteColor24.R / 255M:F3}, {PaletteColor24.G / 255M:F3}, {PaletteColor24.B / 255M:F3}, 1.000);scale:(1.0, 1.0);shader:Default;valueA:0.35;valueB:0.25;]"));

        stringBuilder.AppendLine(FormattableString.Invariant($"[name:palette25;color:RGBA({PaletteColor25.R / 255M:F3}, {PaletteColor25.G / 255M:F3}, {PaletteColor25.B / 255M:F3}, 1.000);scale:(1.0, 1.0);shader:Default;valueA:0.35;valueB:0.25;]"));
        stringBuilder.AppendLine(FormattableString.Invariant($"[name:palette26;color:RGBA({PaletteColor26.R / 255M:F3}, {PaletteColor26.G / 255M:F3}, {PaletteColor26.B / 255M:F3}, 1.000);scale:(1.0, 1.0);shader:Default;valueA:0.35;valueB:0.25;]"));
        stringBuilder.AppendLine(FormattableString.Invariant($"[name:palette27;color:RGBA({PaletteColor27.R / 255M:F3}, {PaletteColor27.G / 255M:F3}, {PaletteColor27.B / 255M:F3}, 1.000);scale:(1.0, 1.0);shader:Default;valueA:0.35;valueB:0.25;]"));
        stringBuilder.AppendLine(FormattableString.Invariant($"[name:palette28;color:RGBA({PaletteColor28.R / 255M:F3}, {PaletteColor28.G / 255M:F3}, {PaletteColor28.B / 255M:F3}, 1.000);scale:(1.0, 1.0);shader:Default;valueA:0.35;valueB:0.25;]"));
        stringBuilder.AppendLine(FormattableString.Invariant($"[name:palette29;color:RGBA({PaletteColor29.R / 255M:F3}, {PaletteColor29.G / 255M:F3}, {PaletteColor29.B / 255M:F3}, 1.000);scale:(1.0, 1.0);shader:Default;valueA:0.35;valueB:0.25;]"));
        stringBuilder.AppendLine(FormattableString.Invariant($"[name:palette30;color:RGBA({PaletteColor30.R / 255M:F3}, {PaletteColor30.G / 255M:F3}, {PaletteColor30.B / 255M:F3}, 1.000);scale:(1.0, 1.0);shader:Default;valueA:0.35;valueB:0.25;]"));
        stringBuilder.AppendLine(FormattableString.Invariant($"[name:palette31;color:RGBA({PaletteColor31.R / 255M:F3}, {PaletteColor31.G / 255M:F3}, {PaletteColor31.B / 255M:F3}, 1.000);scale:(1.0, 1.0);shader:Default;valueA:0.35;valueB:0.25;]"));
        stringBuilder.AppendLine(FormattableString.Invariant($"[name:palette32;color:RGBA({PaletteColor32.R / 255M:F3}, {PaletteColor32.G / 255M:F3}, {PaletteColor32.B / 255M:F3}, 1.000);scale:(1.0, 1.0);shader:Default;valueA:0.35;valueB:0.25;]"));

        stringBuilder.AppendLine(FormattableString.Invariant($"[name:palette33;color:RGBA({PaletteColor33.R / 255M:F3}, {PaletteColor33.G / 255M:F3}, {PaletteColor33.B / 255M:F3}, 1.000);scale:(1.0, 1.0);shader:Default;valueA:0.35;valueB:0.25;]"));
        stringBuilder.AppendLine(FormattableString.Invariant($"[name:palette34;color:RGBA({PaletteColor34.R / 255M:F3}, {PaletteColor34.G / 255M:F3}, {PaletteColor34.B / 255M:F3}, 1.000);scale:(1.0, 1.0);shader:Default;valueA:0.35;valueB:0.25;]"));
        stringBuilder.AppendLine(FormattableString.Invariant($"[name:palette35;color:RGBA({PaletteColor35.R / 255M:F3}, {PaletteColor35.G / 255M:F3}, {PaletteColor35.B / 255M:F3}, 1.000);scale:(1.0, 1.0);shader:Default;valueA:0.35;valueB:0.25;]"));
        stringBuilder.AppendLine(FormattableString.Invariant($"[name:palette36;color:RGBA({PaletteColor36.R / 255M:F3}, {PaletteColor36.G / 255M:F3}, {PaletteColor36.B / 255M:F3}, 1.000);scale:(1.0, 1.0);shader:Default;valueA:0.35;valueB:0.25;]"));
        stringBuilder.AppendLine(FormattableString.Invariant($"[name:palette37;color:RGBA({PaletteColor37.R / 255M:F3}, {PaletteColor37.G / 255M:F3}, {PaletteColor37.B / 255M:F3}, 1.000);scale:(1.0, 1.0);shader:Default;valueA:0.35;valueB:0.25;]"));
        stringBuilder.AppendLine(FormattableString.Invariant($"[name:palette38;color:RGBA({PaletteColor38.R / 255M:F3}, {PaletteColor38.G / 255M:F3}, {PaletteColor38.B / 255M:F3}, 1.000);scale:(1.0, 1.0);shader:Default;valueA:0.35;valueB:0.25;]"));
        stringBuilder.AppendLine(FormattableString.Invariant($"[name:palette39;color:RGBA({PaletteColor39.R / 255M:F3}, {PaletteColor39.G / 255M:F3}, {PaletteColor39.B / 255M:F3}, 1.000);scale:(1.0, 1.0);shader:Default;valueA:0.35;valueB:0.25;]"));
        stringBuilder.AppendLine(FormattableString.Invariant($"[name:palette40;color:RGBA({PaletteColor40.R / 255M:F3}, {PaletteColor40.G / 255M:F3}, {PaletteColor40.B / 255M:F3}, 1.000);scale:(1.0, 1.0);shader:Default;valueA:0.35;valueB:0.25;]"));

        stringBuilder.AppendLine(FormattableString.Invariant($"[name:palette41;color:RGBA({PaletteColor41.R / 255M:F3}, {PaletteColor41.G / 255M:F3}, {PaletteColor41.B / 255M:F3}, 1.000);scale:(1.0, 1.0);shader:Default;valueA:0.35;valueB:0.25;]"));
        stringBuilder.AppendLine(FormattableString.Invariant($"[name:palette42;color:RGBA({PaletteColor42.R / 255M:F3}, {PaletteColor42.G / 255M:F3}, {PaletteColor42.B / 255M:F3}, 1.000);scale:(1.0, 1.0);shader:Default;valueA:0.35;valueB:0.25;]"));
        stringBuilder.AppendLine(FormattableString.Invariant($"[name:palette43;color:RGBA({PaletteColor43.R / 255M:F3}, {PaletteColor43.G / 255M:F3}, {PaletteColor43.B / 255M:F3}, 1.000);scale:(1.0, 1.0);shader:Default;valueA:0.35;valueB:0.25;]"));
        stringBuilder.AppendLine(FormattableString.Invariant($"[name:palette44;color:RGBA({PaletteColor44.R / 255M:F3}, {PaletteColor44.G / 255M:F3}, {PaletteColor44.B / 255M:F3}, 1.000);scale:(1.0, 1.0);shader:Default;valueA:0.35;valueB:0.25;]"));
        stringBuilder.AppendLine(FormattableString.Invariant($"[name:palette45;color:RGBA({PaletteColor45.R / 255M:F3}, {PaletteColor45.G / 255M:F3}, {PaletteColor45.B / 255M:F3}, 1.000);scale:(1.0, 1.0);shader:Default;valueA:0.35;valueB:0.25;]"));
        stringBuilder.AppendLine(FormattableString.Invariant($"[name:palette46;color:RGBA({PaletteColor46.R / 255M:F3}, {PaletteColor46.G / 255M:F3}, {PaletteColor46.B / 255M:F3}, 1.000);scale:(1.0, 1.0);shader:Default;valueA:0.35;valueB:0.25;]"));
        stringBuilder.AppendLine(FormattableString.Invariant($"[name:palette47;color:RGBA({PaletteColor47.R / 255M:F3}, {PaletteColor47.G / 255M:F3}, {PaletteColor47.B / 255M:F3}, 1.000);scale:(1.0, 1.0);shader:Default;valueA:0.35;valueB:0.25;]"));
        stringBuilder.AppendLine(FormattableString.Invariant($"[name:palette48;color:RGBA({PaletteColor48.R / 255M:F3}, {PaletteColor48.G / 255M:F3}, {PaletteColor48.B / 255M:F3}, 1.000);scale:(1.0, 1.0);shader:Default;valueA:0.35;valueB:0.25;]"));

        stringBuilder.AppendLine(FormattableString.Invariant($"[name:palette49;color:RGBA({PaletteColor49.R / 255M:F3}, {PaletteColor49.G / 255M:F3}, {PaletteColor49.B / 255M:F3}, 1.000);scale:(1.0, 1.0);shader:Default;valueA:0.35;valueB:0.25;]"));
        stringBuilder.AppendLine(FormattableString.Invariant($"[name:palette50;color:RGBA({PaletteColor50.R / 255M:F3}, {PaletteColor50.G / 255M:F3}, {PaletteColor50.B / 255M:F3}, 1.000);scale:(1.0, 1.0);shader:Default;valueA:0.35;valueB:0.25;]"));
        stringBuilder.AppendLine(FormattableString.Invariant($"[name:palette51;color:RGBA({PaletteColor51.R / 255M:F3}, {PaletteColor51.G / 255M:F3}, {PaletteColor51.B / 255M:F3}, 1.000);scale:(1.0, 1.0);shader:Default;valueA:0.35;valueB:0.25;]"));
        stringBuilder.AppendLine(FormattableString.Invariant($"[name:palette52;color:RGBA({PaletteColor52.R / 255M:F3}, {PaletteColor52.G / 255M:F3}, {PaletteColor52.B / 255M:F3}, 1.000);scale:(1.0, 1.0);shader:Default;valueA:0.35;valueB:0.25;]"));
        stringBuilder.AppendLine(FormattableString.Invariant($"[name:palette53;color:RGBA({PaletteColor53.R / 255M:F3}, {PaletteColor53.G / 255M:F3}, {PaletteColor53.B / 255M:F3}, 1.000);scale:(1.0, 1.0);shader:Default;valueA:0.35;valueB:0.25;]"));
        stringBuilder.AppendLine(FormattableString.Invariant($"[name:palette54;color:RGBA({PaletteColor54.R / 255M:F3}, {PaletteColor54.G / 255M:F3}, {PaletteColor54.B / 255M:F3}, 1.000);scale:(1.0, 1.0);shader:Default;valueA:0.35;valueB:0.25;]"));
        stringBuilder.AppendLine(FormattableString.Invariant($"[name:palette55;color:RGBA({PaletteColor55.R / 255M:F3}, {PaletteColor55.G / 255M:F3}, {PaletteColor55.B / 255M:F3}, 1.000);scale:(1.0, 1.0);shader:Default;valueA:0.35;valueB:0.25;]"));
        stringBuilder.AppendLine(FormattableString.Invariant($"[name:palette56;color:RGBA({PaletteColor56.R / 255M:F3}, {PaletteColor56.G / 255M:F3}, {PaletteColor56.B / 255M:F3}, 1.000);scale:(1.0, 1.0);shader:Default;valueA:0.35;valueB:0.25;]"));

        stringBuilder.AppendLine(FormattableString.Invariant($"[name:palette57;color:RGBA({PaletteColor57.R / 255M:F3}, {PaletteColor57.G / 255M:F3}, {PaletteColor57.B / 255M:F3}, 1.000);scale:(1.0, 1.0);shader:Default;valueA:0.35;valueB:0.25;]"));
        stringBuilder.AppendLine(FormattableString.Invariant($"[name:palette58;color:RGBA({PaletteColor58.R / 255M:F3}, {PaletteColor58.G / 255M:F3}, {PaletteColor58.B / 255M:F3}, 1.000);scale:(1.0, 1.0);shader:Default;valueA:0.35;valueB:0.25;]"));
        stringBuilder.AppendLine(FormattableString.Invariant($"[name:palette59;color:RGBA({PaletteColor59.R / 255M:F3}, {PaletteColor59.G / 255M:F3}, {PaletteColor59.B / 255M:F3}, 1.000);scale:(1.0, 1.0);shader:Default;valueA:0.35;valueB:0.25;]"));
        stringBuilder.AppendLine(FormattableString.Invariant($"[name:palette60;color:RGBA({PaletteColor60.R / 255M:F3}, {PaletteColor60.G / 255M:F3}, {PaletteColor60.B / 255M:F3}, 1.000);scale:(1.0, 1.0);shader:Default;valueA:0.35;valueB:0.25;]"));
        stringBuilder.AppendLine(FormattableString.Invariant($"[name:palette61;color:RGBA({PaletteColor61.R / 255M:F3}, {PaletteColor61.G / 255M:F3}, {PaletteColor61.B / 255M:F3}, 1.000);scale:(1.0, 1.0);shader:Default;valueA:0.35;valueB:0.25;]"));
        stringBuilder.AppendLine(FormattableString.Invariant($"[name:palette62;color:RGBA({PaletteColor62.R / 255M:F3}, {PaletteColor62.G / 255M:F3}, {PaletteColor62.B / 255M:F3}, 1.000);scale:(1.0, 1.0);shader:Default;valueA:0.35;valueB:0.25;]"));
        stringBuilder.AppendLine(FormattableString.Invariant($"[name:palette63;color:RGBA({PaletteColor63.R / 255M:F3}, {PaletteColor63.G / 255M:F3}, {PaletteColor63.B / 255M:F3}, 1.000);scale:(1.0, 1.0);shader:Default;valueA:0.35;valueB:0.25;]"));
        stringBuilder.AppendLine(FormattableString.Invariant($"[name:palette64;color:RGBA({PaletteColor64.R / 255M:F3}, {PaletteColor64.G / 255M:F3}, {PaletteColor64.B / 255M:F3}, 1.000);scale:(1.0, 1.0);shader:Default;valueA:0.35;valueB:0.25;]"));

        stringBuilder.AppendLine();
        stringBuilder.AppendLine(":models");
        stringBuilder.AppendLine();

        stringBuilder.AppendLine("[name:;collection:Primitives;type:block;position:(-1.0000,0.0000,7.5000);rotation:(0.0000,0.0000,0.0000);scale:(1.0000,16.0000,16.0000);group:;locked:False;hidden:False;materials:palette24;]");
        stringBuilder.AppendLine("[name:;collection:Primitives;type:block;position:(7.5000,0.0000,-1.0000);rotation:(0.0000,0.0000,0.0000);scale:(16.0000,16.0000,1.0000);group:;locked:False;hidden:False;materials:palette24;]");
        stringBuilder.AppendLine("[name:;collection:Primitives;type:block;position:(7.5000,-1.0000,7.5000);rotation:(0.0000,0.0000,0.0000);scale:(16.0000,1.0000,16.0000);group:;locked:False;hidden:False;materials:palette24;]");

        //for (int x = 0; x < 16; x++)
        //{
        //    for (int y = 0; y < 16; y++)
        //    {
        //        for (int z = 0; z < 16; z++)
        //        {
        //            var material = $"palette{Random.Shared.Next(64)+1:D2}";
        //            stringBuilder.AppendLine(FormattableString.Invariant($"[name:;collection:Primitives;type:block;position:({x:F3}, {y:F3}, {z:F3});rotation:(0.0000, 0.0000, 0.0000);scale:(1.0000, 1.0000, 1.0000);group:;locked:False;hidden:False;materials:{material};]"));
        //        }
        //    }
        //}

        await File.WriteAllTextAsync(path, stringBuilder.ToString());
    }

    public async Task Load(string path)
    {
        var content = await File.ReadAllLinesAsync(path);

        var regex = new Regex(@"\[name:palette([0-9]+);color:RGBA\(([0-9]*\.[0-9]+), ([0-9]*\.[0-9]+), ([0-9]*\.[0-9]+), 1\.000\);scale:\(1\.0, 1\.0\);shader:Default;valueA:0\.35;valueB:0\.25;\]");
        foreach (var line in content)
        {
            if (regex.IsMatch(line))
            {
                var match = regex.Match(line);

                if (match.Groups.Count == 5)
                {
                    switch (match.Groups[1].Value)
                    {
                        case "01":
                            PaletteColor01 = ParseColor(match.Groups);
                            break;
                        case "02":
                            PaletteColor02 = ParseColor(match.Groups);
                            break;
                        case "03":
                            PaletteColor03 = ParseColor(match.Groups);
                            break;
                        case "04":
                            PaletteColor04 = ParseColor(match.Groups);
                            break;
                        case "05":
                            PaletteColor05 = ParseColor(match.Groups);
                            break;
                        case "06":
                            PaletteColor06 = ParseColor(match.Groups);
                            break;
                        case "07":
                            PaletteColor07 = ParseColor(match.Groups);
                            break;
                        case "08":
                            PaletteColor08 = ParseColor(match.Groups);
                            break;
                        case "09":
                            PaletteColor09 = ParseColor(match.Groups);
                            break;
                        case "10":
                            PaletteColor10 = ParseColor(match.Groups);
                            break;
                        case "11":
                            PaletteColor11 = ParseColor(match.Groups);
                            break;
                        case "12":
                            PaletteColor12 = ParseColor(match.Groups);
                            break;
                        case "13":
                            PaletteColor13 = ParseColor(match.Groups);
                            break;
                        case "14":
                            PaletteColor14 = ParseColor(match.Groups);
                            break;
                        case "15":
                            PaletteColor15 = ParseColor(match.Groups);
                            break;
                        case "16":
                            PaletteColor16 = ParseColor(match.Groups);
                            break;
                        case "17":
                            PaletteColor17 = ParseColor(match.Groups);
                            break;
                        case "18":
                            PaletteColor18 = ParseColor(match.Groups);
                            break;
                        case "19":
                            PaletteColor19 = ParseColor(match.Groups);
                            break;
                        case "20":
                            PaletteColor20 = ParseColor(match.Groups);
                            break;
                        case "21":
                            PaletteColor21 = ParseColor(match.Groups);
                            break;
                        case "22":
                            PaletteColor22 = ParseColor(match.Groups);
                            break;
                        case "23":
                            PaletteColor23 = ParseColor(match.Groups);
                            break;
                        case "24":
                            PaletteColor24 = ParseColor(match.Groups);
                            break;
                        case "25":
                            PaletteColor25 = ParseColor(match.Groups);
                            break;
                        case "26":
                            PaletteColor26 = ParseColor(match.Groups);
                            break;
                        case "27":
                            PaletteColor27 = ParseColor(match.Groups);
                            break;
                        case "28":
                            PaletteColor28 = ParseColor(match.Groups);
                            break;
                        case "29":
                            PaletteColor29 = ParseColor(match.Groups);
                            break;
                        case "30":
                            PaletteColor30 = ParseColor(match.Groups);
                            break;
                        case "31":
                            PaletteColor31 = ParseColor(match.Groups);
                            break;
                        case "32":
                            PaletteColor32 = ParseColor(match.Groups);
                            break;
                        case "33":
                            PaletteColor33 = ParseColor(match.Groups);
                            break;
                        case "34":
                            PaletteColor34 = ParseColor(match.Groups);
                            break;
                        case "35":
                            PaletteColor35 = ParseColor(match.Groups);
                            break;
                        case "36":
                            PaletteColor36 = ParseColor(match.Groups);
                            break;
                        case "37":
                            PaletteColor37 = ParseColor(match.Groups);
                            break;
                        case "38":
                            PaletteColor38 = ParseColor(match.Groups);
                            break;
                        case "39":
                            PaletteColor39 = ParseColor(match.Groups);
                            break;
                        case "40":
                            PaletteColor40 = ParseColor(match.Groups);
                            break;
                        case "41":
                            PaletteColor41 = ParseColor(match.Groups);
                            break;
                        case "42":
                            PaletteColor42 = ParseColor(match.Groups);
                            break;
                        case "43":
                            PaletteColor43 = ParseColor(match.Groups);
                            break;
                        case "44":
                            PaletteColor44 = ParseColor(match.Groups);
                            break;
                        case "45":
                            PaletteColor45 = ParseColor(match.Groups);
                            break;
                        case "46":
                            PaletteColor46 = ParseColor(match.Groups);
                            break;
                        case "47":
                            PaletteColor47 = ParseColor(match.Groups);
                            break;
                        case "48":
                            PaletteColor48 = ParseColor(match.Groups);
                            break;
                        case "49":
                            PaletteColor49 = ParseColor(match.Groups);
                            break;
                        case "50":
                            PaletteColor50 = ParseColor(match.Groups);
                            break;
                        case "51":
                            PaletteColor51 = ParseColor(match.Groups);
                            break;
                        case "52":
                            PaletteColor52 = ParseColor(match.Groups);
                            break;
                        case "53":
                            PaletteColor53 = ParseColor(match.Groups);
                            break;
                        case "54":
                            PaletteColor54 = ParseColor(match.Groups);
                            break;
                        case "55":
                            PaletteColor55 = ParseColor(match.Groups);
                            break;
                        case "56":
                            PaletteColor56 = ParseColor(match.Groups);
                            break;
                        case "57":
                            PaletteColor57 = ParseColor(match.Groups);
                            break;
                        case "58":
                            PaletteColor58 = ParseColor(match.Groups);
                            break;
                        case "59":
                            PaletteColor59 = ParseColor(match.Groups);
                            break;
                        case "60":
                            PaletteColor60 = ParseColor(match.Groups);
                            break;
                        case "61":
                            PaletteColor61 = ParseColor(match.Groups);
                            break;
                        case "62":
                            PaletteColor62 = ParseColor(match.Groups);
                            break;
                        case "63":
                            PaletteColor63 = ParseColor(match.Groups);
                            break;
                        case "64":
                            PaletteColor64 = ParseColor(match.Groups);
                            break;
                    }
                }
            }
        }
    }

    private Color ParseColor(GroupCollection regexGroups)
    {
        return Color.FromArgb(
            (byte)(decimal.Parse(regexGroups[2].Value, CultureInfo.InvariantCulture) * 255M),
            (byte)(decimal.Parse(regexGroups[3].Value, CultureInfo.InvariantCulture) * 255M),
            (byte)(decimal.Parse(regexGroups[4].Value, CultureInfo.InvariantCulture) * 255M));
    }
}