using AxKHOpenAPILib;

using System.ComponentModel;

namespace ShareInvest;

partial class AxKH
{
    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            if (axAPI is not null)
            {
                Controls.Remove(axAPI);

                axAPI.Dispose();
            }
            if (components is not null)
            {
                components.Dispose();
                components = null;
            }
        }
        base.Dispose(disposing);
    }
    void InitializeComponent()
    {
        components = new Container();
        this.resources = new ComponentResourceManager(typeof(AxKH));
        ((ISupportInitialize)(this.axAPI)).BeginInit();
        this.SuspendLayout();
        this.axAPI.Location = new System.Drawing.Point(0, 0);
        this.axAPI.Dock = System.Windows.Forms.DockStyle.Fill;
        this.axAPI.Enabled = true;
        this.axAPI.Margin = new System.Windows.Forms.Padding(0);
        this.axAPI.Name = "axAPI";
        this.axAPI.OcxState = (System.Windows.Forms.AxHost.State)resources.GetObject("axAPI.OcxState");
        this.axAPI.Size = new System.Drawing.Size(188, 39);
        this.axAPI.TabIndex = 0;
        this.axAPI.TabStop = false;
        this.axAPI.Visible = false;
        this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
        this.BackColor = System.Drawing.Color.Transparent;
        this.DoubleBuffered = true;
        this.Margin = new System.Windows.Forms.Padding(0);
        this.Name = "OpenAPI";
        this.Controls.Add(this.axAPI);
        ((ISupportInitialize)(this.axAPI)).EndInit();
        this.ResumeLayout(false);
    }
    IContainer components;
    ComponentResourceManager resources;

    protected readonly AxKHOpenAPI axAPI = new AxKHOpenAPI();
}