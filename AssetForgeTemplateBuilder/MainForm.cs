namespace AssetForgeTemplateBuilder
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private async void saveToolStripButton_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Asset Forge Model files (*.model)|*.model|All files (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var fileBuilder = new ModelFileBuilder
                {
                    PaletteColor01 = palette01Button.BackColor,
                    PaletteColor02 = palette02Button.BackColor,
                    PaletteColor03 = palette03Button.BackColor,
                    PaletteColor04 = palette04Button.BackColor,
                    PaletteColor05 = palette05Button.BackColor,
                    PaletteColor06 = palette06Button.BackColor,
                    PaletteColor07 = palette07Button.BackColor,
                    PaletteColor08 = palette08Button.BackColor,
                    PaletteColor09 = palette09Button.BackColor,
                    PaletteColor10 = palette10Button.BackColor,
                    PaletteColor11 = palette11Button.BackColor,
                    PaletteColor12 = palette12Button.BackColor,
                    PaletteColor13 = palette13Button.BackColor,
                    PaletteColor14 = palette14Button.BackColor,
                    PaletteColor15 = palette15Button.BackColor,
                    PaletteColor16 = palette16Button.BackColor,
                    PaletteColor17 = palette17Button.BackColor,
                    PaletteColor18 = palette18Button.BackColor,
                    PaletteColor19 = palette19Button.BackColor,
                    PaletteColor20 = palette20Button.BackColor,
                    PaletteColor21 = palette21Button.BackColor,
                    PaletteColor22 = palette22Button.BackColor,
                    PaletteColor23 = palette23Button.BackColor,
                    PaletteColor24 = palette24Button.BackColor,
                    PaletteColor25 = palette25Button.BackColor,
                    PaletteColor26 = palette26Button.BackColor,
                    PaletteColor27 = palette27Button.BackColor,
                    PaletteColor28 = palette28Button.BackColor,
                    PaletteColor29 = palette29Button.BackColor,
                    PaletteColor30 = palette30Button.BackColor,
                    PaletteColor31 = palette31Button.BackColor,
                    PaletteColor32 = palette32Button.BackColor,
                    PaletteColor33 = palette33Button.BackColor,
                    PaletteColor34 = palette34Button.BackColor,
                    PaletteColor35 = palette35Button.BackColor,
                    PaletteColor36 = palette36Button.BackColor,
                    PaletteColor37 = palette37Button.BackColor,
                    PaletteColor38 = palette38Button.BackColor,
                    PaletteColor39 = palette39Button.BackColor,
                    PaletteColor40 = palette40Button.BackColor,
                    PaletteColor41 = palette41Button.BackColor,
                    PaletteColor42 = palette42Button.BackColor,
                    PaletteColor43 = palette43Button.BackColor,
                    PaletteColor44 = palette44Button.BackColor,
                    PaletteColor45 = palette45Button.BackColor,
                    PaletteColor46 = palette46Button.BackColor,
                    PaletteColor47 = palette47Button.BackColor,
                    PaletteColor48 = palette48Button.BackColor,
                    PaletteColor49 = palette49Button.BackColor,
                    PaletteColor50 = palette50Button.BackColor,
                    PaletteColor51 = palette51Button.BackColor,
                    PaletteColor52 = palette52Button.BackColor,
                    PaletteColor53 = palette53Button.BackColor,
                    PaletteColor54 = palette54Button.BackColor,
                    PaletteColor55 = palette55Button.BackColor,
                    PaletteColor56 = palette56Button.BackColor,
                    PaletteColor57 = palette57Button.BackColor,
                    PaletteColor58 = palette58Button.BackColor,
                    PaletteColor59 = palette59Button.BackColor,
                    PaletteColor60 = palette60Button.BackColor,
                    PaletteColor61 = palette61Button.BackColor,
                    PaletteColor62 = palette62Button.BackColor,
                    PaletteColor63 = palette63Button.BackColor,
                    PaletteColor64 = palette64Button.BackColor
                };

                await fileBuilder.Save(saveFileDialog.FileName);
            }
        }

        private async void loadToolStripButton_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                Filter = "Asset Forge Model files (*.model)|*.model|All files (*.*)|*.*"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var fileBuilder = new ModelFileBuilder();

                await fileBuilder.Load(openFileDialog.FileName);

                palette01Button.BackColor = fileBuilder.PaletteColor01;
                palette02Button.BackColor = fileBuilder.PaletteColor02;
                palette03Button.BackColor = fileBuilder.PaletteColor03;
                palette04Button.BackColor = fileBuilder.PaletteColor04;
                palette05Button.BackColor = fileBuilder.PaletteColor05;
                palette06Button.BackColor = fileBuilder.PaletteColor06;
                palette07Button.BackColor = fileBuilder.PaletteColor07;
                palette08Button.BackColor = fileBuilder.PaletteColor08;
                palette09Button.BackColor = fileBuilder.PaletteColor09;
                palette10Button.BackColor = fileBuilder.PaletteColor10;
                palette11Button.BackColor = fileBuilder.PaletteColor11;
                palette12Button.BackColor = fileBuilder.PaletteColor12;
                palette13Button.BackColor = fileBuilder.PaletteColor13;
                palette14Button.BackColor = fileBuilder.PaletteColor14;
                palette15Button.BackColor = fileBuilder.PaletteColor15;
                palette16Button.BackColor = fileBuilder.PaletteColor16;
                palette17Button.BackColor = fileBuilder.PaletteColor17;
                palette18Button.BackColor = fileBuilder.PaletteColor18;
                palette19Button.BackColor = fileBuilder.PaletteColor19;
                palette20Button.BackColor = fileBuilder.PaletteColor20;
                palette21Button.BackColor = fileBuilder.PaletteColor21;
                palette22Button.BackColor = fileBuilder.PaletteColor22;
                palette23Button.BackColor = fileBuilder.PaletteColor23;
                palette24Button.BackColor = fileBuilder.PaletteColor24;
                palette25Button.BackColor = fileBuilder.PaletteColor25;
                palette26Button.BackColor = fileBuilder.PaletteColor26;
                palette27Button.BackColor = fileBuilder.PaletteColor27;
                palette28Button.BackColor = fileBuilder.PaletteColor28;
                palette29Button.BackColor = fileBuilder.PaletteColor29;
                palette30Button.BackColor = fileBuilder.PaletteColor30;
                palette31Button.BackColor = fileBuilder.PaletteColor31;
                palette32Button.BackColor = fileBuilder.PaletteColor32;
                palette33Button.BackColor = fileBuilder.PaletteColor33;
                palette34Button.BackColor = fileBuilder.PaletteColor34;
                palette35Button.BackColor = fileBuilder.PaletteColor35;
                palette36Button.BackColor = fileBuilder.PaletteColor36;
                palette37Button.BackColor = fileBuilder.PaletteColor37;
                palette38Button.BackColor = fileBuilder.PaletteColor38;
                palette39Button.BackColor = fileBuilder.PaletteColor39;
                palette40Button.BackColor = fileBuilder.PaletteColor40;
                palette41Button.BackColor = fileBuilder.PaletteColor41;
                palette42Button.BackColor = fileBuilder.PaletteColor42;
                palette43Button.BackColor = fileBuilder.PaletteColor43;
                palette44Button.BackColor = fileBuilder.PaletteColor44;
                palette45Button.BackColor = fileBuilder.PaletteColor45;
                palette46Button.BackColor = fileBuilder.PaletteColor46;
                palette47Button.BackColor = fileBuilder.PaletteColor47;
                palette48Button.BackColor = fileBuilder.PaletteColor48;
                palette49Button.BackColor = fileBuilder.PaletteColor49;
                palette50Button.BackColor = fileBuilder.PaletteColor50;
                palette51Button.BackColor = fileBuilder.PaletteColor51;
                palette52Button.BackColor = fileBuilder.PaletteColor52;
                palette53Button.BackColor = fileBuilder.PaletteColor53;
                palette54Button.BackColor = fileBuilder.PaletteColor54;
                palette55Button.BackColor = fileBuilder.PaletteColor55;
                palette56Button.BackColor = fileBuilder.PaletteColor56;
                palette57Button.BackColor = fileBuilder.PaletteColor57;
                palette58Button.BackColor = fileBuilder.PaletteColor58;
                palette59Button.BackColor = fileBuilder.PaletteColor59;
                palette60Button.BackColor = fileBuilder.PaletteColor60;
                palette61Button.BackColor = fileBuilder.PaletteColor61;
                palette62Button.BackColor = fileBuilder.PaletteColor62;
                palette63Button.BackColor = fileBuilder.PaletteColor63;
                palette64Button.BackColor = fileBuilder.PaletteColor64;
            }
        }

        private void paletteButton_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                ChangeColor(button);
            }
        }

        private void ChangeColor(Button button)
        {
            var colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                button.BackColor = colorDialog.Color;
            }
        }
    }
}