namespace AutoWedka
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel_titleBar = new System.Windows.Forms.Panel();
            this.siticoneHtmlLabel1 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.MinimizeBox = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.CloseBox = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.bind_button = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneHtmlLabel2 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.siticoneHtmlLabel3 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.slot_wedki = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.slot_mieczyka = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.panel_titleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_titleBar
            // 
            this.panel_titleBar.Controls.Add(this.siticoneHtmlLabel1);
            this.panel_titleBar.Controls.Add(this.MinimizeBox);
            this.panel_titleBar.Controls.Add(this.CloseBox);
            this.panel_titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_titleBar.Location = new System.Drawing.Point(0, 0);
            this.panel_titleBar.Name = "panel_titleBar";
            this.panel_titleBar.Size = new System.Drawing.Size(420, 45);
            this.panel_titleBar.TabIndex = 0;
            this.panel_titleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_titleBar_MouseDown);
            this.panel_titleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_titleBar_MouseMove);
            this.panel_titleBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_titleBar_MouseUp);
            // 
            // siticoneHtmlLabel1
            // 
            this.siticoneHtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.siticoneHtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.siticoneHtmlLabel1.Location = new System.Drawing.Point(12, 12);
            this.siticoneHtmlLabel1.Name = "siticoneHtmlLabel1";
            this.siticoneHtmlLabel1.Size = new System.Drawing.Size(87, 15);
            this.siticoneHtmlLabel1.TabIndex = 1;
            this.siticoneHtmlLabel1.Text = "WendkaHook.XYZ";
            // 
            // MinimizeBox
            // 
            this.MinimizeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeBox.ControlBoxType = Siticone.Desktop.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.MinimizeBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.MinimizeBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MinimizeBox.HoverState.FillColor = System.Drawing.Color.MediumTurquoise;
            this.MinimizeBox.HoverState.Parent = this.MinimizeBox;
            this.MinimizeBox.IconColor = System.Drawing.Color.White;
            this.MinimizeBox.Location = new System.Drawing.Point(318, 0);
            this.MinimizeBox.Name = "MinimizeBox";
            this.MinimizeBox.ShadowDecoration.Parent = this.MinimizeBox;
            this.MinimizeBox.Size = new System.Drawing.Size(48, 45);
            this.MinimizeBox.TabIndex = 1;
            // 
            // CloseBox
            // 
            this.CloseBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.CloseBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.CloseBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CloseBox.HoverState.FillColor = System.Drawing.Color.Red;
            this.CloseBox.HoverState.Parent = this.CloseBox;
            this.CloseBox.IconColor = System.Drawing.Color.White;
            this.CloseBox.Location = new System.Drawing.Point(372, 0);
            this.CloseBox.Name = "CloseBox";
            this.CloseBox.ShadowDecoration.Parent = this.CloseBox;
            this.CloseBox.Size = new System.Drawing.Size(48, 45);
            this.CloseBox.TabIndex = 0;
            // 
            // bind_button
            // 
            this.bind_button.CheckedState.Parent = this.bind_button;
            this.bind_button.CustomImages.Parent = this.bind_button;
            this.bind_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bind_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bind_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bind_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bind_button.DisabledState.Parent = this.bind_button;
            this.bind_button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.bind_button.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bind_button.ForeColor = System.Drawing.Color.White;
            this.bind_button.HoverState.Parent = this.bind_button;
            this.bind_button.Location = new System.Drawing.Point(108, 92);
            this.bind_button.Name = "bind_button";
            this.bind_button.ShadowDecoration.Parent = this.bind_button;
            this.bind_button.Size = new System.Drawing.Size(180, 45);
            this.bind_button.TabIndex = 1;
            this.bind_button.Text = "brak";
            this.bind_button.Click += new System.EventHandler(this.bind_button_Click);
            this.bind_button.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bind_button_KeyDown);
            // 
            // siticoneHtmlLabel2
            // 
            this.siticoneHtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.siticoneHtmlLabel2.ForeColor = System.Drawing.Color.White;
            this.siticoneHtmlLabel2.Location = new System.Drawing.Point(12, 156);
            this.siticoneHtmlLabel2.Name = "siticoneHtmlLabel2";
            this.siticoneHtmlLabel2.Size = new System.Drawing.Size(63, 15);
            this.siticoneHtmlLabel2.TabIndex = 2;
            this.siticoneHtmlLabel2.Text = "slot wedki";
            // 
            // siticoneHtmlLabel3
            // 
            this.siticoneHtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel3.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.siticoneHtmlLabel3.ForeColor = System.Drawing.Color.White;
            this.siticoneHtmlLabel3.Location = new System.Drawing.Point(12, 200);
            this.siticoneHtmlLabel3.Name = "siticoneHtmlLabel3";
            this.siticoneHtmlLabel3.Size = new System.Drawing.Size(81, 15);
            this.siticoneHtmlLabel3.TabIndex = 3;
            this.siticoneHtmlLabel3.Text = "slot mieczyka";
            // 
            // slot_wedki
            // 
            this.slot_wedki.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.slot_wedki.DefaultText = "";
            this.slot_wedki.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.slot_wedki.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.slot_wedki.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.slot_wedki.DisabledState.Parent = this.slot_wedki;
            this.slot_wedki.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.slot_wedki.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.slot_wedki.FocusedState.Parent = this.slot_wedki;
            this.slot_wedki.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.slot_wedki.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.slot_wedki.HoverState.Parent = this.slot_wedki;
            this.slot_wedki.Location = new System.Drawing.Point(81, 156);
            this.slot_wedki.Name = "slot_wedki";
            this.slot_wedki.PasswordChar = '\0';
            this.slot_wedki.PlaceholderText = "";
            this.slot_wedki.SelectedText = "";
            this.slot_wedki.ShadowDecoration.Parent = this.slot_wedki;
            this.slot_wedki.Size = new System.Drawing.Size(80, 15);
            this.slot_wedki.TabIndex = 5;
            // 
            // slot_mieczyka
            // 
            this.slot_mieczyka.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.slot_mieczyka.DefaultText = "";
            this.slot_mieczyka.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.slot_mieczyka.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.slot_mieczyka.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.slot_mieczyka.DisabledState.Parent = this.slot_mieczyka;
            this.slot_mieczyka.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.slot_mieczyka.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.slot_mieczyka.FocusedState.Parent = this.slot_mieczyka;
            this.slot_mieczyka.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.slot_mieczyka.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.slot_mieczyka.HoverState.Parent = this.slot_mieczyka;
            this.slot_mieczyka.Location = new System.Drawing.Point(99, 200);
            this.slot_mieczyka.Name = "slot_mieczyka";
            this.slot_mieczyka.PasswordChar = '\0';
            this.slot_mieczyka.PlaceholderText = "";
            this.slot_mieczyka.SelectedText = "";
            this.slot_mieczyka.ShadowDecoration.Parent = this.slot_mieczyka;
            this.slot_mieczyka.Size = new System.Drawing.Size(80, 15);
            this.slot_mieczyka.TabIndex = 6;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 125;
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox.ForeColor = System.Drawing.Color.White;
            this.checkBox.Location = new System.Drawing.Point(161, 241);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(62, 17);
            this.checkBox.TabIndex = 7;
            this.checkBox.Text = "toggle";
            this.checkBox.UseVisualStyleBackColor = true;
            this.checkBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(420, 420);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.slot_mieczyka);
            this.Controls.Add(this.slot_wedki);
            this.Controls.Add(this.siticoneHtmlLabel3);
            this.Controls.Add(this.siticoneHtmlLabel2);
            this.Controls.Add(this.bind_button);
            this.Controls.Add(this.panel_titleBar);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "WendkaHook.xyz";
            this.panel_titleBar.ResumeLayout(false);
            this.panel_titleBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_titleBar;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox CloseBox;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox MinimizeBox;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton bind_button;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel2;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel3;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox slot_wedki;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox slot_mieczyka;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.CheckBox checkBox;
    }
}

