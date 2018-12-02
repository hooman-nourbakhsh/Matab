namespace Matab
{
    partial class frmAmalKard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAmalKard));
            this.groupPanel4 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.mskTaTarikh = new DevComponents.DotNetBar.Controls.MaskedTextBoxAdv();
            this.label2 = new System.Windows.Forms.Label();
            this.mskAzTarikh = new DevComponents.DotNetBar.Controls.MaskedTextBoxAdv();
            this.label1 = new System.Windows.Forms.Label();
            this.groupPanel3 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDaramadBimeh = new System.Windows.Forms.Label();
            this.lblTedadVizit = new System.Windows.Forms.Label();
            this.lblKoleDaramad = new System.Windows.Forms.Label();
            this.lblDaramadKhadamat = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnPrint = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel4.SuspendLayout();
            this.groupPanel3.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupPanel4
            // 
            this.groupPanel4.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel4.Controls.Add(this.lblKoleDaramad);
            this.groupPanel4.Controls.Add(this.label6);
            this.groupPanel4.Controls.Add(this.lblDaramadKhadamat);
            this.groupPanel4.Controls.Add(this.lblTedadVizit);
            this.groupPanel4.Controls.Add(this.label5);
            this.groupPanel4.Controls.Add(this.lblDaramadBimeh);
            this.groupPanel4.Controls.Add(this.label4);
            this.groupPanel4.Controls.Add(this.label3);
            this.groupPanel4.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel4.Location = new System.Drawing.Point(0, 51);
            this.groupPanel4.Name = "groupPanel4";
            this.groupPanel4.Size = new System.Drawing.Size(687, 144);
            // 
            // 
            // 
            this.groupPanel4.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel4.Style.BackColorGradientAngle = 90;
            this.groupPanel4.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel4.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel4.Style.BorderBottomWidth = 1;
            this.groupPanel4.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel4.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel4.Style.BorderLeftWidth = 1;
            this.groupPanel4.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel4.Style.BorderRightWidth = 1;
            this.groupPanel4.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel4.Style.BorderTopWidth = 1;
            this.groupPanel4.Style.CornerDiameter = 4;
            this.groupPanel4.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel4.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel4.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel4.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel4.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel4.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel4.TabIndex = 3;
            this.groupPanel4.Text = "گزارش عملکرد کلی پزشک بین دو تاریخ انتخاب شده";
            // 
            // mskTaTarikh
            // 
            // 
            // 
            // 
            this.mskTaTarikh.BackgroundStyle.Class = "TextBoxBorder";
            this.mskTaTarikh.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mskTaTarikh.ButtonClear.SymbolColor = System.Drawing.Color.Red;
            this.mskTaTarikh.ButtonClear.Visible = true;
            this.mskTaTarikh.FocusHighlightEnabled = true;
            this.mskTaTarikh.Location = new System.Drawing.Point(6, 4);
            this.mskTaTarikh.Mask = "####/##/##";
            this.mskTaTarikh.Name = "mskTaTarikh";
            this.mskTaTarikh.Size = new System.Drawing.Size(177, 31);
            this.mskTaTarikh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.mskTaTarikh.TabIndex = 1;
            this.mskTaTarikh.Text = "";
            this.mskTaTarikh.TextChanged += new System.EventHandler(this.mskTaTarikh_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(189, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 26);
            this.label2.TabIndex = 18;
            this.label2.Text = "تا تاریخ";
            // 
            // mskAzTarikh
            // 
            // 
            // 
            // 
            this.mskAzTarikh.BackgroundStyle.Class = "TextBoxBorder";
            this.mskAzTarikh.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mskAzTarikh.ButtonClear.SymbolColor = System.Drawing.Color.Red;
            this.mskAzTarikh.ButtonClear.Visible = true;
            this.mskAzTarikh.FocusHighlightEnabled = true;
            this.mskAzTarikh.Location = new System.Drawing.Point(437, 4);
            this.mskAzTarikh.Mask = "####/##/##";
            this.mskAzTarikh.Name = "mskAzTarikh";
            this.mskAzTarikh.Size = new System.Drawing.Size(177, 31);
            this.mskAzTarikh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.mskAzTarikh.TabIndex = 0;
            this.mskAzTarikh.Text = "";
            this.mskAzTarikh.TextChanged += new System.EventHandler(this.mskAzTarikh_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(620, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 26);
            this.label1.TabIndex = 16;
            this.label1.Text = "از تاریخ";
            // 
            // groupPanel3
            // 
            this.groupPanel3.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel3.Controls.Add(this.lblTel);
            this.groupPanel3.Controls.Add(this.label12);
            this.groupPanel3.Controls.Add(this.lblName);
            this.groupPanel3.Controls.Add(this.label14);
            this.groupPanel3.Controls.Add(this.btnPrint);
            this.groupPanel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupPanel3.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupPanel3.Location = new System.Drawing.Point(0, 198);
            this.groupPanel3.Name = "groupPanel3";
            this.groupPanel3.Size = new System.Drawing.Size(687, 46);
            // 
            // 
            // 
            this.groupPanel3.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel3.Style.BackColorGradientAngle = 90;
            this.groupPanel3.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel3.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderBottomWidth = 1;
            this.groupPanel3.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel3.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderLeftWidth = 1;
            this.groupPanel3.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderRightWidth = 1;
            this.groupPanel3.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderTopWidth = 1;
            this.groupPanel3.Style.CornerDiameter = 4;
            this.groupPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel3.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel3.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel3.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel3.TabIndex = 1;
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.mskTaTarikh);
            this.groupPanel2.Controls.Add(this.label2);
            this.groupPanel2.Controls.Add(this.mskAzTarikh);
            this.groupPanel2.Controls.Add(this.label1);
            this.groupPanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanel2.Location = new System.Drawing.Point(0, 0);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(687, 45);
            // 
            // 
            // 
            this.groupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel2.Style.BackColorGradientAngle = 90;
            this.groupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderBottomWidth = 1;
            this.groupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderLeftWidth = 1;
            this.groupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderRightWidth = 1;
            this.groupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderTopWidth = 1;
            this.groupPanel2.Style.CornerDiameter = 4;
            this.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel2.TabIndex = 0;
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.groupPanel4);
            this.groupPanel1.Controls.Add(this.groupPanel3);
            this.groupPanel1.Controls.Add(this.groupPanel2);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel1.Location = new System.Drawing.Point(0, 0);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(693, 250);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("IRANSans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(465, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "تعداد کل بیماران ویزیت شده";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("IRANSans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(121, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 30);
            this.label4.TabIndex = 0;
            this.label4.Text = "درآمد حاصل از بیمه";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("IRANSans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(465, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 30);
            this.label5.TabIndex = 0;
            this.label5.Text = "درآمد حاصل از خدمات";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("IRANSans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(133, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 30);
            this.label6.TabIndex = 0;
            this.label6.Text = "درآمد کل دوره";
            // 
            // lblDaramadBimeh
            // 
            this.lblDaramadBimeh.AutoSize = true;
            this.lblDaramadBimeh.BackColor = System.Drawing.Color.Transparent;
            this.lblDaramadBimeh.ForeColor = System.Drawing.Color.Brown;
            this.lblDaramadBimeh.Location = new System.Drawing.Point(4, 14);
            this.lblDaramadBimeh.Name = "lblDaramadBimeh";
            this.lblDaramadBimeh.Size = new System.Drawing.Size(96, 26);
            this.lblDaramadBimeh.TabIndex = 0;
            this.lblDaramadBimeh.Text = "000000000000";
            // 
            // lblTedadVizit
            // 
            this.lblTedadVizit.AutoSize = true;
            this.lblTedadVizit.BackColor = System.Drawing.Color.Transparent;
            this.lblTedadVizit.ForeColor = System.Drawing.Color.Brown;
            this.lblTedadVizit.Location = new System.Drawing.Point(353, 14);
            this.lblTedadVizit.Name = "lblTedadVizit";
            this.lblTedadVizit.Size = new System.Drawing.Size(96, 26);
            this.lblTedadVizit.TabIndex = 0;
            this.lblTedadVizit.Text = "000000000000";
            // 
            // lblKoleDaramad
            // 
            this.lblKoleDaramad.AutoSize = true;
            this.lblKoleDaramad.BackColor = System.Drawing.Color.Transparent;
            this.lblKoleDaramad.ForeColor = System.Drawing.Color.Brown;
            this.lblKoleDaramad.Location = new System.Drawing.Point(6, 72);
            this.lblKoleDaramad.Name = "lblKoleDaramad";
            this.lblKoleDaramad.Size = new System.Drawing.Size(96, 26);
            this.lblKoleDaramad.TabIndex = 0;
            this.lblKoleDaramad.Text = "000000000000";
            // 
            // lblDaramadKhadamat
            // 
            this.lblDaramadKhadamat.AutoSize = true;
            this.lblDaramadKhadamat.BackColor = System.Drawing.Color.Transparent;
            this.lblDaramadKhadamat.ForeColor = System.Drawing.Color.Brown;
            this.lblDaramadKhadamat.Location = new System.Drawing.Point(353, 72);
            this.lblDaramadKhadamat.Name = "lblDaramadKhadamat";
            this.lblDaramadKhadamat.Size = new System.Drawing.Size(96, 26);
            this.lblDaramadKhadamat.TabIndex = 0;
            this.lblDaramadKhadamat.Text = "000000000000";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.BackColor = System.Drawing.Color.Transparent;
            this.lblTel.ForeColor = System.Drawing.Color.Brown;
            this.lblTel.Location = new System.Drawing.Point(30, 8);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(89, 26);
            this.lblTel.TabIndex = 2;
            this.lblTel.Text = "-----------";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("IRANSans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label12.Location = new System.Drawing.Point(151, 5);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 30);
            this.label12.TabIndex = 3;
            this.label12.Text = "تلفن تماس";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.ForeColor = System.Drawing.Color.Brown;
            this.lblName.Location = new System.Drawing.Point(344, 8);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(82, 26);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "----------";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("IRANSans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label14.Location = new System.Drawing.Point(456, 5);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 30);
            this.label14.TabIndex = 5;
            this.label14.Text = "نام مطب";
            // 
            // btnPrint
            // 
            this.btnPrint.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPrint.BackColor = System.Drawing.Color.Transparent;
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.Image = global::Matab.Properties.Resources.icons8_print_32;
            this.btnPrint.Location = new System.Drawing.Point(539, 1);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2, 10, 10, 2);
            this.btnPrint.Size = new System.Drawing.Size(131, 38);
            this.btnPrint.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = "چاپ";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // frmAmalKard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 250);
            this.Controls.Add(this.groupPanel1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Font = new System.Drawing.Font("IRANSans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.MaximizeBox = false;
            this.Name = "frmAmalKard";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "گزارش عملکرد پزشک";
            this.Load += new System.EventHandler(this.frmAmalKard_Load);
            this.groupPanel4.ResumeLayout(false);
            this.groupPanel4.PerformLayout();
            this.groupPanel3.ResumeLayout(false);
            this.groupPanel3.PerformLayout();
            this.groupPanel2.ResumeLayout(false);
            this.groupPanel2.PerformLayout();
            this.groupPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel4;
        private System.Windows.Forms.Label lblKoleDaramad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblDaramadKhadamat;
        private System.Windows.Forms.Label lblTedadVizit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDaramadBimeh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private DevComponents.DotNetBar.Controls.MaskedTextBoxAdv mskTaTarikh;
        private System.Windows.Forms.Label label2;
        private DevComponents.DotNetBar.Controls.MaskedTextBoxAdv mskAzTarikh;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.ButtonX btnPrint;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel3;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label14;
    }
}