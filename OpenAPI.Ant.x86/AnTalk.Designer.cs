using ShareInvest.Properties;

using System.ComponentModel;

namespace ShareInvest;

partial class AnTalk
{
    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            if (timer is not null)
            {
                timer.Stop();
                timer.Tick -= TimerTick;
                timer.Dispose();
            }
            if (strip is not null)
            {
                strip.ItemClicked -= StripItemClicked;
                strip.Dispose();
            }
            if (notifyIcon is not null)
            {
                if (notifyIcon.Icon is not null)
                {
                    notifyIcon.Icon.Dispose();
                }
                notifyIcon.Dispose();
            }
            if (Controls.Count > 0)
            {
                foreach (Control control in Controls)
                {
                    control.Dispose();
                }
                Talk?.Dispose();

                Controls.Clear();
            }
            if (components != null)
            {
                components.Dispose();
                components = null;
            }
        }
        base.Dispose(disposing);
    }
    void InitializeComponent()
    {
        resources = new ComponentResourceManager(typeof(AnTalk));
        components = new Container();
        notifyIcon = new NotifyIcon(components);
        strip = new ContextMenuStrip(components);
        reference = new ToolStripMenuItem();
        exit = new ToolStripMenuItem();
        timer = new System.Windows.Forms.Timer(components);
        strip.SuspendLayout();
        SuspendLayout();
        // 
        // notifyIcon
        // 
        notifyIcon.BalloonTipIcon = ToolTipIcon.Info;
        notifyIcon.ContextMenuStrip = strip;
        notifyIcon.Text = "AnTalk";
        notifyIcon.MouseDoubleClick += (_, e) =>
        {
            if (Visible)
            {
                Hide();
            }
            else
            {
                Show();
            }
        };
        // 
        // strip
        // 
        strip.AllowMerge = false;
        strip.AutoSize = false;
        strip.DropShadowEnabled = false;
        strip.Items.AddRange(new ToolStripItem[]
        {
            reference,
            exit
        });
        strip.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
        strip.Name = "strip";
        strip.RenderMode = ToolStripRenderMode.System;
        strip.ShowImageMargin = false;
        strip.ShowItemToolTips = false;
        strip.Size = new Size(48, 47);
        strip.ItemClicked += StripItemClicked;
        // 
        // reference
        // 
        reference.Name = "reference";
        reference.Size = new Size(73, 22);
        reference.Text = "연결";
        // 
        // exit
        // 
        exit.Name = "exit";
        exit.Size = new Size(73, 22);
        exit.Text = "종료";
        // 
        // timer
        // 
        timer.Interval = 1000;
        timer.Tick += TimerTick;
        // 
        // AnTalk
        //
        AutoScaleDimensions = new SizeF(96F, 96F);
        AutoScaleMode = AutoScaleMode.Dpi;
        BackColor = Color.Black;
        ClientSize = new Size(475, 835);
        Name = "StartUp";
        Text = "AnTalk";
        TopMost = true;
        DoubleBuffered = true;
        ShowInTaskbar = false;
        Icon = Resources.LOGO;
        StartPosition = FormStartPosition.CenterScreen;
        FormClosing += JustBeforeFormClosing;
        Resize += SecuritiesResize;
        strip.ResumeLayout(false);
        ResumeLayout(false);
    }
    System.Windows.Forms.Timer timer;
    ComponentResourceManager resources;
    ContextMenuStrip strip;
    ToolStripMenuItem reference;
    ToolStripMenuItem exit;
    NotifyIcon notifyIcon;
    IContainer components;
}