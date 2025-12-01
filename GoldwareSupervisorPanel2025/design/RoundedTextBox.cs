using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace GoldwareSupervisorPanel2025.design;
public partial class RoundedTextBoxControl : UserControl
{
    private TextBox textBox;

    [Browsable(true)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public int BorderRadius { get; set; } = 15;

    [Browsable(true)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public Color BorderColor { get; set; } = Color.FromArgb(73,52,255);

    [Browsable(true)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public int BorderSize { get; set; } = 2;

    [Browsable(true)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public string PlaceholderText { get; set; } = "Enter text...";

    [Browsable(true)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public Color PlaceholderColor { get; set; } = Color.Gray;

    private bool _isPlaceholderVisible { get; set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public string TextValue
    {
        get => textBox.Text;
        set => textBox.Text = value;
    }

    public RoundedTextBoxControl()
    {
        //InitializeComponent();
        this.BackColor = Color.Transparent;
        this.Size = new Size(300, 60);

        textBox = new TextBox
        {
            BorderStyle = BorderStyle.None,
            Location = new Point(10, 10),
            Width = this.Width - 20,
            Height = this.Height - 20,
            Font = new Font("Segoe UI", 10f),
            
        };
        _isPlaceholderVisible = string.IsNullOrEmpty(textBox.Text) && !textBox.Focused;
        this.Controls.Add(textBox);
    }

    private void RoundedTextBoxControl_Resize(object sender, EventArgs e)
    {
        textBox.Width = this.Width - 2 * this.Padding.Left;
        textBox.Height = this.Height - 2 * this.Padding.Top;
        Invalidate();
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

        using (GraphicsPath path = new GraphicsPath())
        {
            int radius = BorderRadius * 2;
            path.StartFigure();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(this.Width - radius - 1, 0, radius, radius, 270, 90);
            path.AddArc(this.Width - radius - 1, this.Height - radius - 1, radius, radius, 0, 90);
            path.AddArc(0, this.Height - radius - 1, radius, radius, 90, 90);
            path.CloseFigure();

            using (Pen pen = new Pen(BorderColor, BorderSize))
            {
                e.Graphics.DrawPath(pen, path);
            }
        }

        // Draw placeholder text
        if (_isPlaceholderVisible)
        {
            TextRenderer.DrawText(
                e.Graphics,
                PlaceholderText,
                textBox.Font,
                textBox.Bounds,
                PlaceholderColor,
                TextFormatFlags.VerticalCenter | TextFormatFlags.Left);
        }
    }
}
