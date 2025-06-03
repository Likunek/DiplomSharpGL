namespace DemoSharpGL
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.ramkaVertex = new System.Windows.Forms.GroupBox();
            this.gridVertex = new System.Windows.Forms.DataGridView();
            this.Column0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.z = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.StepOnT = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.radioButtonPositionalLight = new System.Windows.Forms.RadioButton();
            this.radioButtonSpotlight = new System.Windows.Forms.RadioButton();
            this.RadioButtonHeavenlyLighting = new System.Windows.Forms.RadioButton();
            this.GL = new SharpGL.OpenGLControl();
            this.colorDialogMain = new System.Windows.Forms.ColorDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.СounterClockwiseMovement = new System.Windows.Forms.Button();
            this.clockwiseMovement = new System.Windows.Forms.Button();
            this.CameraRound = new System.Windows.Forms.Button();
            this.distance = new System.Windows.Forms.Button();
            this.Zoom = new System.Windows.Forms.Button();
            this.CameraStartPoint = new System.Windows.Forms.Button();
            this.CameraTop = new System.Windows.Forms.Button();
            this.CameraRight = new System.Windows.Forms.Button();
            this.CameraLeft = new System.Windows.Forms.Button();
            this.CameraUp = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.changeResistanceParameter = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.changeAngleOfeviation = new System.Windows.Forms.NumericUpDown();
            this.changeСargoWeights = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.changeLongThreads = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.ButtonFloorColor = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.ButtonBoxColor = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ButtonСolorBall = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SphereRadiusChanges = new System.Windows.Forms.ComboBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TextureFloor = new System.Windows.Forms.ComboBox();
            this.TextureBall = new System.Windows.Forms.ComboBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.radioButtonСlearPoint = new System.Windows.Forms.RadioButton();
            this.radioButtonProjectionOff = new System.Windows.Forms.RadioButton();
            this.radioButtonProjectionOn = new System.Windows.Forms.RadioButton();
            this.label15 = new System.Windows.Forms.Label();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.buttonPause = new System.Windows.Forms.Button();
            this.buttonForth = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.ramkaVertex.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridVertex)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StepOnT)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GL)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.changeResistanceParameter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.changeAngleOfeviation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.changeСargoWeights)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.changeLongThreads)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // ramkaVertex
            // 
            this.ramkaVertex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ramkaVertex.BackColor = System.Drawing.Color.LavenderBlush;
            this.ramkaVertex.Controls.Add(this.gridVertex);
            this.ramkaVertex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ramkaVertex.Location = new System.Drawing.Point(981, 2);
            this.ramkaVertex.Margin = new System.Windows.Forms.Padding(4);
            this.ramkaVertex.Name = "ramkaVertex";
            this.ramkaVertex.Padding = new System.Windows.Forms.Padding(4);
            this.ramkaVertex.Size = new System.Drawing.Size(236, 698);
            this.ramkaVertex.TabIndex = 1;
            this.ramkaVertex.TabStop = false;
            this.ramkaVertex.Text = "Список контрольных точек";
            // 
            // gridVertex
            // 
            this.gridVertex.AllowUserToAddRows = false;
            this.gridVertex.AllowUserToDeleteRows = false;
            this.gridVertex.AllowUserToResizeRows = false;
            this.gridVertex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridVertex.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridVertex.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.gridVertex.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridVertex.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.gridVertex.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridVertex.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column0,
            this.z,
            this.Column1});
            this.gridVertex.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gridVertex.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.gridVertex.Location = new System.Drawing.Point(0, 21);
            this.gridVertex.Margin = new System.Windows.Forms.Padding(4);
            this.gridVertex.MultiSelect = false;
            this.gridVertex.Name = "gridVertex";
            this.gridVertex.ReadOnly = true;
            this.gridVertex.RowHeadersVisible = false;
            this.gridVertex.RowHeadersWidth = 51;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            this.gridVertex.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.gridVertex.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gridVertex.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridVertex.Size = new System.Drawing.Size(236, 677);
            this.gridVertex.StandardTab = true;
            this.gridVertex.TabIndex = 10;
            // 
            // Column0
            // 
            this.Column0.HeaderText = "t";
            this.Column0.MinimumWidth = 50;
            this.Column0.Name = "Column0";
            this.Column0.ReadOnly = true;
            this.Column0.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column0.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column0.Width = 50;
            // 
            // z
            // 
            this.z.HeaderText = "angle";
            this.z.MinimumWidth = 60;
            this.z.Name = "z";
            this.z.ReadOnly = true;
            this.z.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.z.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.z.Width = 60;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "x";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.BackColor = System.Drawing.Color.LightCoral;
            this.groupBox4.Controls.Add(this.StepOnT);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(981, 706);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(236, 68);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Параметр вывода";
            // 
            // StepOnT
            // 
            this.StepOnT.Location = new System.Drawing.Point(139, 36);
            this.StepOnT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StepOnT.Name = "StepOnT";
            this.StepOnT.Size = new System.Drawing.Size(79, 22);
            this.StepOnT.TabIndex = 1;
            this.StepOnT.ValueChanged += new System.EventHandler(this.StepOnT_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(8, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Шаг по t";
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.BackColor = System.Drawing.Color.LemonChiffon;
            this.groupBox6.Controls.Add(this.radioButtonPositionalLight);
            this.groupBox6.Controls.Add(this.radioButtonSpotlight);
            this.groupBox6.Controls.Add(this.RadioButtonHeavenlyLighting);
            this.groupBox6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox6.Location = new System.Drawing.Point(981, 782);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox6.Size = new System.Drawing.Size(236, 126);
            this.groupBox6.TabIndex = 9;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = " Освещение";
            // 
            // radioButtonPositionalLight
            // 
            this.radioButtonPositionalLight.AutoSize = true;
            this.radioButtonPositionalLight.Location = new System.Drawing.Point(35, 46);
            this.radioButtonPositionalLight.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonPositionalLight.Name = "radioButtonPositionalLight";
            this.radioButtonPositionalLight.Size = new System.Drawing.Size(152, 20);
            this.radioButtonPositionalLight.TabIndex = 2;
            this.radioButtonPositionalLight.Text = "Позиционный свет";
            this.radioButtonPositionalLight.UseVisualStyleBackColor = true;
            this.radioButtonPositionalLight.CheckedChanged += new System.EventHandler(this.radioButtonPositionalLight_CheckedChanged);
            // 
            // radioButtonSpotlight
            // 
            this.radioButtonSpotlight.AutoSize = true;
            this.radioButtonSpotlight.Location = new System.Drawing.Point(35, 69);
            this.radioButtonSpotlight.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonSpotlight.Name = "radioButtonSpotlight";
            this.radioButtonSpotlight.Size = new System.Drawing.Size(101, 20);
            this.radioButtonSpotlight.TabIndex = 4;
            this.radioButtonSpotlight.Text = "Прожектор";
            this.radioButtonSpotlight.UseVisualStyleBackColor = true;
            this.radioButtonSpotlight.CheckedChanged += new System.EventHandler(this.radioButtonSpotlight_CheckedChanged);
            // 
            // RadioButtonHeavenlyLighting
            // 
            this.RadioButtonHeavenlyLighting.AutoSize = true;
            this.RadioButtonHeavenlyLighting.Checked = true;
            this.RadioButtonHeavenlyLighting.Location = new System.Drawing.Point(35, 23);
            this.RadioButtonHeavenlyLighting.Margin = new System.Windows.Forms.Padding(4);
            this.RadioButtonHeavenlyLighting.Name = "RadioButtonHeavenlyLighting";
            this.RadioButtonHeavenlyLighting.Size = new System.Drawing.Size(127, 20);
            this.RadioButtonHeavenlyLighting.TabIndex = 1;
            this.RadioButtonHeavenlyLighting.TabStop = true;
            this.RadioButtonHeavenlyLighting.Text = "Небесный свет";
            this.RadioButtonHeavenlyLighting.UseVisualStyleBackColor = true;
            this.RadioButtonHeavenlyLighting.CheckedChanged += new System.EventHandler(this.RadioButtonHeavenlyLighting_CheckedChanged);
            // 
            // GL
            // 
            this.GL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GL.BackColor = System.Drawing.SystemColors.Info;
            this.GL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GL.Cursor = System.Windows.Forms.Cursors.Cross;
            this.GL.DrawFPS = false;
            this.GL.Location = new System.Drawing.Point(-1, 2);
            this.GL.Margin = new System.Windows.Forms.Padding(5);
            this.GL.Name = "GL";
            this.GL.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL1_4;
            this.GL.RenderContextType = SharpGL.RenderContextType.DIBSection;
            this.GL.RenderTrigger = SharpGL.RenderTrigger.TimerBased;
            this.GL.Size = new System.Drawing.Size(973, 916);
            this.GL.TabIndex = 0;
            this.GL.OpenGLInitialized += new System.EventHandler(this.GL_OpenGLInitialized);
            this.GL.OpenGLDraw += new SharpGL.RenderEventHandler(this.GL_OpenGLDraw);
            this.GL.Resized += new System.EventHandler(this.GL_Resized);
            this.GL.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GL_MouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Pink;
            this.groupBox1.Controls.Add(this.СounterClockwiseMovement);
            this.groupBox1.Controls.Add(this.clockwiseMovement);
            this.groupBox1.Controls.Add(this.CameraRound);
            this.groupBox1.Controls.Add(this.distance);
            this.groupBox1.Controls.Add(this.Zoom);
            this.groupBox1.Controls.Add(this.CameraStartPoint);
            this.groupBox1.Controls.Add(this.CameraTop);
            this.groupBox1.Controls.Add(this.CameraRight);
            this.groupBox1.Controls.Add(this.CameraLeft);
            this.groupBox1.Controls.Add(this.CameraUp);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(1225, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(213, 204);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Просмотр сцены";
            // 
            // СounterClockwiseMovement
            // 
            this.СounterClockwiseMovement.BackColor = System.Drawing.Color.Salmon;
            this.СounterClockwiseMovement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.СounterClockwiseMovement.Image = ((System.Drawing.Image)(resources.GetObject("СounterClockwiseMovement.Image")));
            this.СounterClockwiseMovement.Location = new System.Drawing.Point(143, 156);
            this.СounterClockwiseMovement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.СounterClockwiseMovement.Name = "СounterClockwiseMovement";
            this.СounterClockwiseMovement.Size = new System.Drawing.Size(45, 39);
            this.СounterClockwiseMovement.TabIndex = 9;
            this.СounterClockwiseMovement.UseVisualStyleBackColor = false;
            this.СounterClockwiseMovement.Click += new System.EventHandler(this.СounterClockwiseMovement_Click);
            // 
            // clockwiseMovement
            // 
            this.clockwiseMovement.BackColor = System.Drawing.Color.Salmon;
            this.clockwiseMovement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clockwiseMovement.Image = ((System.Drawing.Image)(resources.GetObject("clockwiseMovement.Image")));
            this.clockwiseMovement.Location = new System.Drawing.Point(25, 156);
            this.clockwiseMovement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clockwiseMovement.Name = "clockwiseMovement";
            this.clockwiseMovement.Size = new System.Drawing.Size(45, 39);
            this.clockwiseMovement.TabIndex = 8;
            this.clockwiseMovement.UseVisualStyleBackColor = false;
            this.clockwiseMovement.Click += new System.EventHandler(this.ClockwiseMovement_Click);
            // 
            // CameraRound
            // 
            this.CameraRound.BackColor = System.Drawing.Color.Salmon;
            this.CameraRound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CameraRound.Image = ((System.Drawing.Image)(resources.GetObject("CameraRound.Image")));
            this.CameraRound.Location = new System.Drawing.Point(84, 156);
            this.CameraRound.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CameraRound.Name = "CameraRound";
            this.CameraRound.Size = new System.Drawing.Size(45, 39);
            this.CameraRound.TabIndex = 7;
            this.CameraRound.UseVisualStyleBackColor = false;
            this.CameraRound.Click += new System.EventHandler(this.CameraRound_Click);
            // 
            // distance
            // 
            this.distance.BackColor = System.Drawing.Color.Salmon;
            this.distance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.distance.Image = ((System.Drawing.Image)(resources.GetObject("distance.Image")));
            this.distance.Location = new System.Drawing.Point(149, 22);
            this.distance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.distance.Name = "distance";
            this.distance.Size = new System.Drawing.Size(37, 37);
            this.distance.TabIndex = 6;
            this.distance.UseVisualStyleBackColor = false;
            this.distance.Click += new System.EventHandler(this.Distance_Click);
            // 
            // Zoom
            // 
            this.Zoom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Zoom.BackColor = System.Drawing.Color.Salmon;
            this.Zoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Zoom.Image = ((System.Drawing.Image)(resources.GetObject("Zoom.Image")));
            this.Zoom.Location = new System.Drawing.Point(27, 22);
            this.Zoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Zoom.Name = "Zoom";
            this.Zoom.Size = new System.Drawing.Size(37, 37);
            this.Zoom.TabIndex = 5;
            this.Zoom.UseVisualStyleBackColor = false;
            this.Zoom.Click += new System.EventHandler(this.Zoom_Click);
            // 
            // CameraStartPoint
            // 
            this.CameraStartPoint.BackColor = System.Drawing.Color.Salmon;
            this.CameraStartPoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CameraStartPoint.Image = ((System.Drawing.Image)(resources.GetObject("CameraStartPoint.Image")));
            this.CameraStartPoint.Location = new System.Drawing.Point(89, 78);
            this.CameraStartPoint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CameraStartPoint.Name = "CameraStartPoint";
            this.CameraStartPoint.Size = new System.Drawing.Size(35, 34);
            this.CameraStartPoint.TabIndex = 4;
            this.CameraStartPoint.UseVisualStyleBackColor = false;
            this.CameraStartPoint.Click += new System.EventHandler(this.CameraStartPoint_Click);
            // 
            // CameraTop
            // 
            this.CameraTop.BackColor = System.Drawing.Color.Salmon;
            this.CameraTop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CameraTop.Image = ((System.Drawing.Image)(resources.GetObject("CameraTop.Image")));
            this.CameraTop.Location = new System.Drawing.Point(89, 119);
            this.CameraTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CameraTop.Name = "CameraTop";
            this.CameraTop.Size = new System.Drawing.Size(35, 22);
            this.CameraTop.TabIndex = 3;
            this.CameraTop.UseVisualStyleBackColor = false;
            this.CameraTop.Click += new System.EventHandler(this.CameraTop_Click);
            // 
            // CameraRight
            // 
            this.CameraRight.BackColor = System.Drawing.Color.Salmon;
            this.CameraRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CameraRight.Image = ((System.Drawing.Image)(resources.GetObject("CameraRight.Image")));
            this.CameraRight.Location = new System.Drawing.Point(131, 78);
            this.CameraRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CameraRight.Name = "CameraRight";
            this.CameraRight.Size = new System.Drawing.Size(21, 34);
            this.CameraRight.TabIndex = 2;
            this.CameraRight.UseVisualStyleBackColor = false;
            this.CameraRight.Click += new System.EventHandler(this.CameraRight_Click);
            // 
            // CameraLeft
            // 
            this.CameraLeft.BackColor = System.Drawing.Color.Salmon;
            this.CameraLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CameraLeft.Image = ((System.Drawing.Image)(resources.GetObject("CameraLeft.Image")));
            this.CameraLeft.Location = new System.Drawing.Point(61, 78);
            this.CameraLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CameraLeft.Name = "CameraLeft";
            this.CameraLeft.Size = new System.Drawing.Size(21, 34);
            this.CameraLeft.TabIndex = 1;
            this.CameraLeft.Text = "L";
            this.CameraLeft.UseVisualStyleBackColor = false;
            this.CameraLeft.Click += new System.EventHandler(this.CameraLeft_Click);
            // 
            // CameraUp
            // 
            this.CameraUp.BackColor = System.Drawing.Color.Salmon;
            this.CameraUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CameraUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CameraUp.Image = ((System.Drawing.Image)(resources.GetObject("CameraUp.Image")));
            this.CameraUp.Location = new System.Drawing.Point(89, 50);
            this.CameraUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CameraUp.Name = "CameraUp";
            this.CameraUp.Size = new System.Drawing.Size(35, 22);
            this.CameraUp.TabIndex = 0;
            this.CameraUp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CameraUp.UseVisualStyleBackColor = false;
            this.CameraUp.Click += new System.EventHandler(this.CameraUp_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Location = new System.Drawing.Point(1212, 1237);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(191, 132);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackColor = System.Drawing.SystemColors.Menu;
            this.groupBox3.Controls.Add(this.changeResistanceParameter);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.changeAngleOfeviation);
            this.groupBox3.Controls.Add(this.changeСargoWeights);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.changeLongThreads);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(1225, 226);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(213, 194);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Параметры маятника";
            // 
            // changeResistanceParameter
            // 
            this.changeResistanceParameter.BackColor = System.Drawing.Color.MistyRose;
            this.changeResistanceParameter.Location = new System.Drawing.Point(140, 161);
            this.changeResistanceParameter.Margin = new System.Windows.Forms.Padding(4);
            this.changeResistanceParameter.Name = "changeResistanceParameter";
            this.changeResistanceParameter.Size = new System.Drawing.Size(64, 22);
            this.changeResistanceParameter.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(8, 122);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Угол";
            // 
            // changeAngleOfeviation
            // 
            this.changeAngleOfeviation.BackColor = System.Drawing.Color.MistyRose;
            this.changeAngleOfeviation.Location = new System.Drawing.Point(140, 119);
            this.changeAngleOfeviation.Margin = new System.Windows.Forms.Padding(4);
            this.changeAngleOfeviation.Name = "changeAngleOfeviation";
            this.changeAngleOfeviation.Size = new System.Drawing.Size(64, 22);
            this.changeAngleOfeviation.TabIndex = 6;
            // 
            // changeСargoWeights
            // 
            this.changeСargoWeights.BackColor = System.Drawing.Color.MistyRose;
            this.changeСargoWeights.Location = new System.Drawing.Point(140, 81);
            this.changeСargoWeights.Margin = new System.Windows.Forms.Padding(4);
            this.changeСargoWeights.Name = "changeСargoWeights";
            this.changeСargoWeights.Size = new System.Drawing.Size(64, 22);
            this.changeСargoWeights.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(8, 171);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "сопротивления";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(8, 153);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Параметр";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(8, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Вес груза";
            // 
            // changeLongThreads
            // 
            this.changeLongThreads.BackColor = System.Drawing.Color.MistyRose;
            this.changeLongThreads.Location = new System.Drawing.Point(140, 38);
            this.changeLongThreads.Margin = new System.Windows.Forms.Padding(4);
            this.changeLongThreads.Name = "changeLongThreads";
            this.changeLongThreads.Size = new System.Drawing.Size(64, 22);
            this.changeLongThreads.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(8, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Длина нити";
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox5.Controls.Add(this.ButtonFloorColor);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.ButtonBoxColor);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.ButtonСolorBall);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.SphereRadiusChanges);
            this.groupBox5.Location = new System.Drawing.Point(1225, 538);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Size = new System.Drawing.Size(213, 162);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Внешний вид";
            // 
            // ButtonFloorColor
            // 
            this.ButtonFloorColor.BackColor = System.Drawing.Color.IndianRed;
            this.ButtonFloorColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonFloorColor.Location = new System.Drawing.Point(137, 126);
            this.ButtonFloorColor.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonFloorColor.Name = "ButtonFloorColor";
            this.ButtonFloorColor.Size = new System.Drawing.Size(67, 25);
            this.ButtonFloorColor.TabIndex = 7;
            this.ButtonFloorColor.Text = "цвет";
            this.ButtonFloorColor.UseVisualStyleBackColor = false;
            this.ButtonFloorColor.Click += new System.EventHandler(this.ButtonFloorColor_Click_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 130);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 16);
            this.label10.TabIndex = 6;
            this.label10.Text = "Цвет пола";
            // 
            // ButtonBoxColor
            // 
            this.ButtonBoxColor.BackColor = System.Drawing.Color.LightCoral;
            this.ButtonBoxColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonBoxColor.Location = new System.Drawing.Point(137, 96);
            this.ButtonBoxColor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonBoxColor.Name = "ButtonBoxColor";
            this.ButtonBoxColor.Size = new System.Drawing.Size(67, 25);
            this.ButtonBoxColor.TabIndex = 5;
            this.ButtonBoxColor.Text = "цвет";
            this.ButtonBoxColor.UseVisualStyleBackColor = false;
            this.ButtonBoxColor.Click += new System.EventHandler(this.ButtonBoxColor_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 16);
            this.label9.TabIndex = 4;
            this.label9.Text = "Цвет платфрмы";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "Цвет сферы";
            // 
            // ButtonСolorBall
            // 
            this.ButtonСolorBall.BackColor = System.Drawing.Color.MistyRose;
            this.ButtonСolorBall.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonСolorBall.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonСolorBall.Location = new System.Drawing.Point(137, 66);
            this.ButtonСolorBall.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonСolorBall.Name = "ButtonСolorBall";
            this.ButtonСolorBall.Size = new System.Drawing.Size(67, 25);
            this.ButtonСolorBall.TabIndex = 2;
            this.ButtonСolorBall.Text = "цвет";
            this.ButtonСolorBall.UseVisualStyleBackColor = false;
            this.ButtonСolorBall.Click += new System.EventHandler(this.ButtonСolorBall_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Радиус Сферы";
            // 
            // SphereRadiusChanges
            // 
            this.SphereRadiusChanges.FormattingEnabled = true;
            this.SphereRadiusChanges.Items.AddRange(new object[] {
            "5",
            "10",
            "12",
            "15",
            "20",
            "25"});
            this.SphereRadiusChanges.Location = new System.Drawing.Point(137, 30);
            this.SphereRadiusChanges.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SphereRadiusChanges.Name = "SphereRadiusChanges";
            this.SphereRadiusChanges.Size = new System.Drawing.Size(65, 24);
            this.SphereRadiusChanges.TabIndex = 0;
            this.SphereRadiusChanges.SelectedIndexChanged += new System.EventHandler(this.SphereRadiusChanges_SelectedIndexChanged);
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox7.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox7.Controls.Add(this.label12);
            this.groupBox7.Controls.Add(this.label11);
            this.groupBox7.Controls.Add(this.TextureFloor);
            this.groupBox7.Controls.Add(this.TextureBall);
            this.groupBox7.Location = new System.Drawing.Point(1225, 428);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox7.Size = new System.Drawing.Size(213, 103);
            this.groupBox7.TabIndex = 10;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Текстуры";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(8, 70);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 18);
            this.label12.TabIndex = 3;
            this.label12.Text = "Пол";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(8, 33);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 18);
            this.label11.TabIndex = 2;
            this.label11.Text = "Шар";
            // 
            // TextureFloor
            // 
            this.TextureFloor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TextureFloor.FormattingEnabled = true;
            this.TextureFloor.Items.AddRange(new object[] {
            "Нет",
            "Песок",
            "Трава"});
            this.TextureFloor.Location = new System.Drawing.Point(104, 63);
            this.TextureFloor.Margin = new System.Windows.Forms.Padding(4);
            this.TextureFloor.Name = "TextureFloor";
            this.TextureFloor.Size = new System.Drawing.Size(99, 24);
            this.TextureFloor.TabIndex = 1;
            this.TextureFloor.SelectedIndexChanged += new System.EventHandler(this.TextureFloor_SelectedIndexChanged);
            // 
            // TextureBall
            // 
            this.TextureBall.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TextureBall.FormattingEnabled = true;
            this.TextureBall.Items.AddRange(new object[] {
            "Нет",
            "Кокос",
            "Цитрус"});
            this.TextureBall.Location = new System.Drawing.Point(104, 26);
            this.TextureBall.Margin = new System.Windows.Forms.Padding(4);
            this.TextureBall.Name = "TextureBall";
            this.TextureBall.Size = new System.Drawing.Size(99, 24);
            this.TextureBall.TabIndex = 0;
            this.TextureBall.SelectedIndexChanged += new System.EventHandler(this.TextureBall_SelectedIndexChanged);
            // 
            // groupBox10
            // 
            this.groupBox10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox10.BackColor = System.Drawing.Color.LightPink;
            this.groupBox10.Controls.Add(this.radioButtonСlearPoint);
            this.groupBox10.Controls.Add(this.radioButtonProjectionOff);
            this.groupBox10.Controls.Add(this.radioButtonProjectionOn);
            this.groupBox10.Controls.Add(this.label15);
            this.groupBox10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox10.Location = new System.Drawing.Point(1225, 709);
            this.groupBox10.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox10.Size = new System.Drawing.Size(213, 97);
            this.groupBox10.TabIndex = 11;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Проекция движения";
            // 
            // radioButtonСlearPoint
            // 
            this.radioButtonСlearPoint.AutoSize = true;
            this.radioButtonСlearPoint.Location = new System.Drawing.Point(57, 65);
            this.radioButtonСlearPoint.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonСlearPoint.Name = "radioButtonСlearPoint";
            this.radioButtonСlearPoint.Size = new System.Drawing.Size(90, 20);
            this.radioButtonСlearPoint.TabIndex = 3;
            this.radioButtonСlearPoint.TabStop = true;
            this.radioButtonСlearPoint.Text = "Очистить";
            this.radioButtonСlearPoint.UseVisualStyleBackColor = true;
            this.radioButtonСlearPoint.CheckedChanged += new System.EventHandler(this.radioButtonСlearPoint_CheckedChanged);
            // 
            // radioButtonProjectionOff
            // 
            this.radioButtonProjectionOff.AutoSize = true;
            this.radioButtonProjectionOff.Checked = true;
            this.radioButtonProjectionOff.Location = new System.Drawing.Point(57, 44);
            this.radioButtonProjectionOff.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonProjectionOff.Name = "radioButtonProjectionOff";
            this.radioButtonProjectionOff.Size = new System.Drawing.Size(60, 20);
            this.radioButtonProjectionOff.TabIndex = 2;
            this.radioButtonProjectionOff.TabStop = true;
            this.radioButtonProjectionOff.Text = "выкл";
            this.radioButtonProjectionOff.UseVisualStyleBackColor = true;
            // 
            // radioButtonProjectionOn
            // 
            this.radioButtonProjectionOn.AutoSize = true;
            this.radioButtonProjectionOn.Location = new System.Drawing.Point(57, 23);
            this.radioButtonProjectionOn.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonProjectionOn.Name = "radioButtonProjectionOn";
            this.radioButtonProjectionOn.Size = new System.Drawing.Size(51, 20);
            this.radioButtonProjectionOn.TabIndex = 1;
            this.radioButtonProjectionOn.Text = "вкл";
            this.radioButtonProjectionOn.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 39);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(0, 16);
            this.label15.TabIndex = 0;
            // 
            // ButtonStart
            // 
            this.ButtonStart.BackColor = System.Drawing.Color.IndianRed;
            this.ButtonStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonStart.Location = new System.Drawing.Point(0, 64);
            this.ButtonStart.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(213, 46);
            this.ButtonStart.TabIndex = 12;
            this.ButtonStart.Text = "Запуск";
            this.ButtonStart.UseVisualStyleBackColor = false;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // buttonPause
            // 
            this.buttonPause.BackColor = System.Drawing.Color.Salmon;
            this.buttonPause.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPause.Image = ((System.Drawing.Image)(resources.GetObject("buttonPause.Image")));
            this.buttonPause.Location = new System.Drawing.Point(0, 10);
            this.buttonPause.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(100, 47);
            this.buttonPause.TabIndex = 13;
            this.buttonPause.UseVisualStyleBackColor = false;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // buttonForth
            // 
            this.buttonForth.BackColor = System.Drawing.Color.Salmon;
            this.buttonForth.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonForth.Image = ((System.Drawing.Image)(resources.GetObject("buttonForth.Image")));
            this.buttonForth.Location = new System.Drawing.Point(113, 10);
            this.buttonForth.Margin = new System.Windows.Forms.Padding(4);
            this.buttonForth.Name = "buttonForth";
            this.buttonForth.Size = new System.Drawing.Size(100, 47);
            this.buttonForth.TabIndex = 14;
            this.buttonForth.UseVisualStyleBackColor = false;
            this.buttonForth.Click += new System.EventHandler(this.buttonForth_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox8.Controls.Add(this.buttonForth);
            this.groupBox8.Controls.Add(this.ButtonStart);
            this.groupBox8.Controls.Add(this.buttonPause);
            this.groupBox8.Location = new System.Drawing.Point(1225, 804);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox8.Size = new System.Drawing.Size(213, 114);
            this.groupBox8.TabIndex = 12;
            this.groupBox8.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1455, 921);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ramkaVertex);
            this.Controls.Add(this.GL);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1234, 745);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Визуализация маятника";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ramkaVertex.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridVertex)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StepOnT)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GL)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.changeResistanceParameter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.changeAngleOfeviation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.changeСargoWeights)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.changeLongThreads)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox ramkaVertex;
        private System.Windows.Forms.DataGridView gridVertex;
        private SharpGL.OpenGLControl GL;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown changeLongThreads;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown changeAngleOfeviation;
        private System.Windows.Forms.NumericUpDown changeСargoWeights;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown changeResistanceParameter;
        private System.Windows.Forms.Button CameraStartPoint;
        private System.Windows.Forms.Button CameraTop;
        private System.Windows.Forms.Button CameraRight;
        private System.Windows.Forms.Button CameraLeft;
        private System.Windows.Forms.Button CameraUp;
        private System.Windows.Forms.Button distance;
        private System.Windows.Forms.Button Zoom;
        private System.Windows.Forms.Button CameraRound;
        private System.Windows.Forms.Button СounterClockwiseMovement;
        private System.Windows.Forms.Button clockwiseMovement;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown StepOnT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox SphereRadiusChanges;
        private System.Windows.Forms.Button ButtonСolorBall;
        private System.Windows.Forms.ColorDialog colorDialogMain;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button ButtonBoxColor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ComboBox TextureBall;
        private System.Windows.Forms.ComboBox TextureFloor;
        private System.Windows.Forms.Button ButtonFloorColor;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton radioButtonPositionalLight;
        private System.Windows.Forms.RadioButton RadioButtonHeavenlyLighting;
        private System.Windows.Forms.RadioButton radioButtonSpotlight;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.RadioButton radioButtonProjectionOff;
        private System.Windows.Forms.RadioButton radioButtonProjectionOn;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.RadioButton radioButtonСlearPoint;
        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.Button buttonForth;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column0;
        private System.Windows.Forms.DataGridViewTextBoxColumn z;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}

