namespace Matab
{
    partial class frmListVisit
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListVisit));
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.groupPanel3 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.txtID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dgvListVisit = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.groupPanel4 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.groupPanel5 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.mskTaTarikh = new DevComponents.DotNetBar.Controls.MaskedTextBoxAdv();
            this.label2 = new System.Windows.Forms.Label();
            this.mskAzTarikh = new DevComponents.DotNetBar.Controls.MaskedTextBoxAdv();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnPrint = new DevComponents.DotNetBar.ButtonX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Visit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tarikh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameBimeh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TarefeBimeh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameKhadamat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TarefeKhadamat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MablaghKol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoskhePezeshk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReload = new DevComponents.DotNetBar.ButtonX();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDaramad = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupPanel1.SuspendLayout();
            this.groupPanel3.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListVisit)).BeginInit();
            this.groupPanel4.SuspendLayout();
            this.groupPanel5.SuspendLayout();
            this.SuspendLayout();
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
            this.groupPanel1.Size = new System.Drawing.Size(1029, 389);
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
            this.groupPanel1.TabIndex = 0;
            // 
            // groupPanel3
            // 
            this.groupPanel3.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel3.Controls.Add(this.label4);
            this.groupPanel3.Controls.Add(this.lblDaramad);
            this.groupPanel3.Controls.Add(this.label3);
            this.groupPanel3.Controls.Add(this.btnReload);
            this.groupPanel3.Controls.Add(this.btnPrint);
            this.groupPanel3.Controls.Add(this.buttonX1);
            this.groupPanel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupPanel3.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupPanel3.Location = new System.Drawing.Point(0, 337);
            this.groupPanel3.Name = "groupPanel3";
            this.groupPanel3.Size = new System.Drawing.Size(1023, 46);
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
            this.groupPanel2.Controls.Add(this.groupPanel5);
            this.groupPanel2.Controls.Add(this.txtID);
            this.groupPanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanel2.Location = new System.Drawing.Point(0, 0);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(1023, 48);
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
            // txtID
            // 
            // 
            // 
            // 
            this.txtID.Border.Class = "TextBoxBorder";
            this.txtID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtID.FocusHighlightEnabled = true;
            this.txtID.Location = new System.Drawing.Point(756, 10);
            this.txtID.Name = "txtID";
            this.txtID.PreventEnterBeep = true;
            this.txtID.Size = new System.Drawing.Size(258, 32);
            this.txtID.TabIndex = 0;
            // 
            // dgvListVisit
            // 
            this.dgvListVisit.AllowUserToAddRows = false;
            this.dgvListVisit.AllowUserToDeleteRows = false;
            this.dgvListVisit.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("IRANSans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListVisit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListVisit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListVisit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ID_Visit,
            this.Tarikh,
            this.FName,
            this.LName,
            this.NameBimeh,
            this.TarefeBimeh,
            this.NameKhadamat,
            this.TarefeKhadamat,
            this.MablaghKol,
            this.NoskhePezeshk});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("IRANSans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(41)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListVisit.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListVisit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListVisit.EnableHeadersVisualStyles = false;
            this.dgvListVisit.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dgvListVisit.Location = new System.Drawing.Point(0, 0);
            this.dgvListVisit.Name = "dgvListVisit";
            this.dgvListVisit.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("IRANSans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListVisit.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListVisit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListVisit.Size = new System.Drawing.Size(1017, 282);
            this.dgvListVisit.TabIndex = 0;
            // 
            // groupPanel4
            // 
            this.groupPanel4.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel4.Controls.Add(this.dgvListVisit);
            this.groupPanel4.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanel4.Location = new System.Drawing.Point(0, 48);
            this.groupPanel4.Name = "groupPanel4";
            this.groupPanel4.Size = new System.Drawing.Size(1023, 288);
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
            // 
            // groupPanel5
            // 
            this.groupPanel5.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel5.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel5.Controls.Add(this.txtLName);
            this.groupPanel5.Controls.Add(this.mskTaTarikh);
            this.groupPanel5.Controls.Add(this.label2);
            this.groupPanel5.Controls.Add(this.mskAzTarikh);
            this.groupPanel5.Controls.Add(this.label1);
            this.groupPanel5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupPanel5.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupPanel5.Location = new System.Drawing.Point(0, -4);
            this.groupPanel5.Name = "groupPanel5";
            this.groupPanel5.Size = new System.Drawing.Size(1017, 46);
            // 
            // 
            // 
            this.groupPanel5.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel5.Style.BackColorGradientAngle = 90;
            this.groupPanel5.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel5.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel5.Style.BorderBottomWidth = 1;
            this.groupPanel5.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel5.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel5.Style.BorderLeftWidth = 1;
            this.groupPanel5.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel5.Style.BorderRightWidth = 1;
            this.groupPanel5.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel5.Style.BorderTopWidth = 1;
            this.groupPanel5.Style.CornerDiameter = 4;
            this.groupPanel5.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel5.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel5.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel5.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel5.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel5.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel5.TabIndex = 0;
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
            this.mskTaTarikh.Location = new System.Drawing.Point(14, 5);
            this.mskTaTarikh.Mask = "####/##/##";
            this.mskTaTarikh.Name = "mskTaTarikh";
            this.mskTaTarikh.Size = new System.Drawing.Size(188, 31);
            this.mskTaTarikh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.mskTaTarikh.TabIndex = 2;
            this.mskTaTarikh.Text = "";
            this.mskTaTarikh.TextChanged += new System.EventHandler(this.mskTaTarikh_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(208, 7);
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
            this.mskAzTarikh.Location = new System.Drawing.Point(276, 5);
            this.mskAzTarikh.Mask = "####/##/##";
            this.mskAzTarikh.Name = "mskAzTarikh";
            this.mskAzTarikh.Size = new System.Drawing.Size(209, 31);
            this.mskAzTarikh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.mskAzTarikh.TabIndex = 1;
            this.mskAzTarikh.Text = "";
            this.mskAzTarikh.TextChanged += new System.EventHandler(this.mskAzTarikh_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(491, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 26);
            this.label1.TabIndex = 16;
            this.label1.Text = "از تاریخ";
            // 
            // txtLName
            // 
            // 
            // 
            // 
            this.txtLName.Border.Class = "TextBoxBorder";
            this.txtLName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtLName.FocusHighlightEnabled = true;
            this.txtLName.Location = new System.Drawing.Point(709, 4);
            this.txtLName.Name = "txtLName";
            this.txtLName.PreventEnterBeep = true;
            this.txtLName.Size = new System.Drawing.Size(299, 32);
            this.txtLName.TabIndex = 0;
            this.txtLName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLName.WatermarkText = "نام خانوادگی را وارد کنید";
            this.txtLName.TextChanged += new System.EventHandler(this.txtLName_TextChanged);
            // 
            // btnPrint
            // 
            this.btnPrint.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPrint.BackColor = System.Drawing.Color.Transparent;
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.Image = global::Matab.Properties.Resources.icons8_print_32;
            this.btnPrint.Location = new System.Drawing.Point(17, 0);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2, 10, 10, 2);
            this.btnPrint.Size = new System.Drawing.Size(131, 38);
            this.btnPrint.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "چاپ";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.BackColor = System.Drawing.Color.Transparent;
            this.buttonX1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonX1.Image = global::Matab.Properties.Resources.icons8_trash_32;
            this.buttonX1.Location = new System.Drawing.Point(154, 0);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2, 10, 10, 2);
            this.buttonX1.Size = new System.Drawing.Size(131, 38);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 0;
            this.buttonX1.Text = "حذف";
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ردیف";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // ID_Visit
            // 
            this.ID_Visit.DataPropertyName = "ID_Visit";
            this.ID_Visit.HeaderText = "شماره ویزیت";
            this.ID_Visit.Name = "ID_Visit";
            this.ID_Visit.ReadOnly = true;
            this.ID_Visit.Width = 120;
            // 
            // Tarikh
            // 
            this.Tarikh.DataPropertyName = "Tarikh";
            this.Tarikh.HeaderText = "تاریخ ویزیت";
            this.Tarikh.Name = "Tarikh";
            this.Tarikh.ReadOnly = true;
            this.Tarikh.Width = 110;
            // 
            // FName
            // 
            this.FName.DataPropertyName = "FNameBimar";
            this.FName.HeaderText = "نام بیمار";
            this.FName.Name = "FName";
            this.FName.ReadOnly = true;
            // 
            // LName
            // 
            this.LName.DataPropertyName = "LNameBimar";
            this.LName.HeaderText = "نام خانوادگی";
            this.LName.Name = "LName";
            this.LName.ReadOnly = true;
            this.LName.Width = 140;
            // 
            // NameBimeh
            // 
            this.NameBimeh.DataPropertyName = "NameBimeh";
            this.NameBimeh.HeaderText = "نام بیمه";
            this.NameBimeh.Name = "NameBimeh";
            this.NameBimeh.ReadOnly = true;
            this.NameBimeh.Width = 110;
            // 
            // TarefeBimeh
            // 
            this.TarefeBimeh.DataPropertyName = "TarefeBimeh";
            this.TarefeBimeh.HeaderText = "تعرفه بیمه";
            this.TarefeBimeh.Name = "TarefeBimeh";
            this.TarefeBimeh.ReadOnly = true;
            // 
            // NameKhadamat
            // 
            this.NameKhadamat.DataPropertyName = "NameKhadamat";
            this.NameKhadamat.HeaderText = "نام خدمات";
            this.NameKhadamat.Name = "NameKhadamat";
            this.NameKhadamat.ReadOnly = true;
            this.NameKhadamat.Width = 110;
            // 
            // TarefeKhadamat
            // 
            this.TarefeKhadamat.DataPropertyName = "TarefeKhadamat";
            this.TarefeKhadamat.HeaderText = "تعرفه خدمات";
            this.TarefeKhadamat.Name = "TarefeKhadamat";
            this.TarefeKhadamat.ReadOnly = true;
            this.TarefeKhadamat.Width = 120;
            // 
            // MablaghKol
            // 
            this.MablaghKol.DataPropertyName = "MablaghKol";
            this.MablaghKol.HeaderText = "مبلغ کل";
            this.MablaghKol.Name = "MablaghKol";
            this.MablaghKol.ReadOnly = true;
            // 
            // NoskhePezeshk
            // 
            this.NoskhePezeshk.DataPropertyName = "NoskhePezeshk";
            this.NoskhePezeshk.HeaderText = "دستور پزشک";
            this.NoskhePezeshk.Name = "NoskhePezeshk";
            this.NoskhePezeshk.ReadOnly = true;
            this.NoskhePezeshk.Width = 140;
            // 
            // btnReload
            // 
            this.btnReload.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnReload.BackColor = System.Drawing.Color.Transparent;
            this.btnReload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReload.Image = global::Matab.Properties.Resources.icons8_synchronize_32;
            this.btnReload.Location = new System.Drawing.Point(880, 3);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(131, 35);
            this.btnReload.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnReload.TabIndex = 15;
            this.btnReload.Text = "محاسبه درآمد";
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(573, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(301, 26);
            this.label3.TabIndex = 17;
            this.label3.Text = "درآمد حاصل از ویزیت بین تاریخ های انتخاب شده";
            // 
            // lblDaramad
            // 
            this.lblDaramad.AutoSize = true;
            this.lblDaramad.BackColor = System.Drawing.Color.Transparent;
            this.lblDaramad.Location = new System.Drawing.Point(515, 8);
            this.lblDaramad.Name = "lblDaramad";
            this.lblDaramad.Size = new System.Drawing.Size(54, 26);
            this.lblDaramad.TabIndex = 18;
            this.lblDaramad.Text = "000000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(468, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 26);
            this.label4.TabIndex = 19;
            this.label4.Text = "(ريال)";
            // 
            // frmListVisit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 389);
            this.Controls.Add(this.groupPanel1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Font = new System.Drawing.Font("IRANSans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.MaximizeBox = false;
            this.Name = "frmListVisit";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "لیست ویزیت ها";
            this.Load += new System.EventHandler(this.frmListVisit_Load);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel3.ResumeLayout(false);
            this.groupPanel3.PerformLayout();
            this.groupPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListVisit)).EndInit();
            this.groupPanel4.ResumeLayout(false);
            this.groupPanel5.ResumeLayout(false);
            this.groupPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel3;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtID;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel4;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvListVisit;
        private DevComponents.DotNetBar.ButtonX btnPrint;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel5;
        private DevComponents.DotNetBar.Controls.MaskedTextBoxAdv mskTaTarikh;
        private System.Windows.Forms.Label label2;
        private DevComponents.DotNetBar.Controls.MaskedTextBoxAdv mskAzTarikh;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtLName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Visit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarikh;
        private System.Windows.Forms.DataGridViewTextBoxColumn FName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LName;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameBimeh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TarefeBimeh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameKhadamat;
        private System.Windows.Forms.DataGridViewTextBoxColumn TarefeKhadamat;
        private System.Windows.Forms.DataGridViewTextBoxColumn MablaghKol;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoskhePezeshk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDaramad;
        private System.Windows.Forms.Label label3;
        private DevComponents.DotNetBar.ButtonX btnReload;
    }
}