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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.ramkaVertex = new System.Windows.Forms.GroupBox();
            this.gridVertex = new System.Windows.Forms.DataGridView();
            this.Column0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.z = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GL = new SharpGL.OpenGLControl();
            this.colorDialogMain = new System.Windows.Forms.ColorDialog();
            this.ButtonStart = new System.Windows.Forms.Button();
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.StepOnT = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.ButtonFloorColor = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.ButtonBoxColor = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ButtonСolorBall = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SphereRadiusChanges = new System.Windows.Forms.ComboBox();
            this.ramkaVertex.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridVertex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GL)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.changeResistanceParameter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.changeAngleOfeviation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.changeСargoWeights)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.changeLongThreads)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StepOnT)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // ramkaVertex
            // 
            this.ramkaVertex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ramkaVertex.Controls.Add(this.gridVertex);
            this.ramkaVertex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ramkaVertex.Location = new System.Drawing.Point(1032, 2);
            this.ramkaVertex.Margin = new System.Windows.Forms.Padding(4);
            this.ramkaVertex.Name = "ramkaVertex";
            this.ramkaVertex.Padding = new System.Windows.Forms.Padding(4);
            this.ramkaVertex.Size = new System.Drawing.Size(223, 961);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridVertex.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.gridVertex.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.gridVertex.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gridVertex.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridVertex.Size = new System.Drawing.Size(223, 640);
            this.gridVertex.StandardTab = true;
            this.gridVertex.TabIndex = 10;
            // 
            // Column0
            // 
            this.Column0.HeaderText = "t";
            this.Column0.MinimumWidth = 40;
            this.Column0.Name = "Column0";
            this.Column0.ReadOnly = true;
            this.Column0.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column0.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column0.Width = 40;
            // 
            // z
            // 
            this.z.HeaderText = "angle";
            this.z.MinimumWidth = 50;
            this.z.Name = "z";
            this.z.ReadOnly = true;
            this.z.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.z.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.z.Width = 50;
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
            this.GL.Size = new System.Drawing.Size(1024, 961);
            this.GL.TabIndex = 0;
            this.GL.OpenGLInitialized += new System.EventHandler(this.GL_OpenGLInitialized);
            this.GL.OpenGLDraw += new SharpGL.RenderEventHandler(this.GL_OpenGLDraw);
            this.GL.Resized += new System.EventHandler(this.GL_Resized);
            this.GL.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GL_MouseClick);
            // 
            // ButtonStart
            // 
            this.ButtonStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonStart.Location = new System.Drawing.Point(8, 22);
            this.ButtonStart.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(144, 39);
            this.ButtonStart.TabIndex = 3;
            this.ButtonStart.Text = "Запуск";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.groupBox1.Location = new System.Drawing.Point(1263, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(187, 212);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Просмотр сцены";
            // 
            // СounterClockwiseMovement
            // 
            this.СounterClockwiseMovement.Location = new System.Drawing.Point(131, 182);
            this.СounterClockwiseMovement.Name = "СounterClockwiseMovement";
            this.СounterClockwiseMovement.Size = new System.Drawing.Size(51, 23);
            this.СounterClockwiseMovement.TabIndex = 9;
            this.СounterClockwiseMovement.Text = "Counterclockwise";
            this.СounterClockwiseMovement.UseVisualStyleBackColor = true;
            this.СounterClockwiseMovement.Click += new System.EventHandler(this.СounterClockwiseMovement_Click);
            // 
            // clockwiseMovement
            // 
            this.clockwiseMovement.Location = new System.Drawing.Point(77, 182);
            this.clockwiseMovement.Name = "clockwiseMovement";
            this.clockwiseMovement.Size = new System.Drawing.Size(49, 23);
            this.clockwiseMovement.TabIndex = 8;
            this.clockwiseMovement.Text = "clockwise";
            this.clockwiseMovement.UseVisualStyleBackColor = true;
            this.clockwiseMovement.Click += new System.EventHandler(this.ClockwiseMovement_Click);
            // 
            // CameraRound
            // 
            this.CameraRound.Location = new System.Drawing.Point(11, 161);
            this.CameraRound.Name = "CameraRound";
            this.CameraRound.Size = new System.Drawing.Size(52, 44);
            this.CameraRound.TabIndex = 7;
            this.CameraRound.Text = "round";
            this.CameraRound.UseVisualStyleBackColor = true;
            this.CameraRound.Click += new System.EventHandler(this.CameraRound_Click);
            // 
            // distance
            // 
            this.distance.Location = new System.Drawing.Point(99, 22);
            this.distance.Name = "distance";
            this.distance.Size = new System.Drawing.Size(77, 30);
            this.distance.TabIndex = 6;
            this.distance.Text = "far";
            this.distance.UseVisualStyleBackColor = true;
            this.distance.Click += new System.EventHandler(this.Distance_Click);
            // 
            // Zoom
            // 
            this.Zoom.Location = new System.Drawing.Point(7, 22);
            this.Zoom.Name = "Zoom";
            this.Zoom.Size = new System.Drawing.Size(77, 30);
            this.Zoom.TabIndex = 5;
            this.Zoom.Text = "close";
            this.Zoom.UseVisualStyleBackColor = true;
            this.Zoom.Click += new System.EventHandler(this.Zoom_Click);
            // 
            // CameraStartPoint
            // 
            this.CameraStartPoint.Location = new System.Drawing.Point(77, 98);
            this.CameraStartPoint.Name = "CameraStartPoint";
            this.CameraStartPoint.Size = new System.Drawing.Size(33, 30);
            this.CameraStartPoint.TabIndex = 4;
            this.CameraStartPoint.Text = "A";
            this.CameraStartPoint.UseVisualStyleBackColor = true;
            this.CameraStartPoint.Click += new System.EventHandler(this.CameraStartPoint_Click);
            // 
            // CameraTop
            // 
            this.CameraTop.Location = new System.Drawing.Point(77, 134);
            this.CameraTop.Name = "CameraTop";
            this.CameraTop.Size = new System.Drawing.Size(33, 30);
            this.CameraTop.TabIndex = 3;
            this.CameraTop.Text = "T";
            this.CameraTop.UseVisualStyleBackColor = true;
            this.CameraTop.Click += new System.EventHandler(this.CameraTop_Click);
            // 
            // CameraRight
            // 
            this.CameraRight.Location = new System.Drawing.Point(116, 98);
            this.CameraRight.Name = "CameraRight";
            this.CameraRight.Size = new System.Drawing.Size(33, 30);
            this.CameraRight.TabIndex = 2;
            this.CameraRight.Text = "R";
            this.CameraRight.UseVisualStyleBackColor = true;
            this.CameraRight.Click += new System.EventHandler(this.CameraRight_Click);
            // 
            // CameraLeft
            // 
            this.CameraLeft.Location = new System.Drawing.Point(38, 98);
            this.CameraLeft.Name = "CameraLeft";
            this.CameraLeft.Size = new System.Drawing.Size(33, 30);
            this.CameraLeft.TabIndex = 1;
            this.CameraLeft.Text = "L";
            this.CameraLeft.UseVisualStyleBackColor = true;
            this.CameraLeft.Click += new System.EventHandler(this.CameraLeft_Click);
            // 
            // CameraUp
            // 
            this.CameraUp.Location = new System.Drawing.Point(77, 62);
            this.CameraUp.Name = "CameraUp";
            this.CameraUp.Size = new System.Drawing.Size(33, 30);
            this.CameraUp.TabIndex = 0;
            this.CameraUp.Text = "U";
            this.CameraUp.UseVisualStyleBackColor = true;
            this.CameraUp.Click += new System.EventHandler(this.CameraUp_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.ButtonStart);
            this.groupBox2.Location = new System.Drawing.Point(1284, 880);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(161, 69);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "-";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.changeResistanceParameter);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.changeAngleOfeviation);
            this.groupBox3.Controls.Add(this.changeСargoWeights);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.changeLongThreads);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(1263, 227);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(187, 195);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Параметры маятника";
            // 
            // changeResistanceParameter
            // 
            this.changeResistanceParameter.Location = new System.Drawing.Point(128, 161);
            this.changeResistanceParameter.Margin = new System.Windows.Forms.Padding(4);
            this.changeResistanceParameter.Name = "changeResistanceParameter";
            this.changeResistanceParameter.Size = new System.Drawing.Size(59, 22);
            this.changeResistanceParameter.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 122);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Угол";
            // 
            // changeAngleOfeviation
            // 
            this.changeAngleOfeviation.Location = new System.Drawing.Point(127, 119);
            this.changeAngleOfeviation.Margin = new System.Windows.Forms.Padding(4);
            this.changeAngleOfeviation.Name = "changeAngleOfeviation";
            this.changeAngleOfeviation.Size = new System.Drawing.Size(60, 22);
            this.changeAngleOfeviation.TabIndex = 6;
            // 
            // changeСargoWeights
            // 
            this.changeСargoWeights.Location = new System.Drawing.Point(127, 81);
            this.changeСargoWeights.Margin = new System.Windows.Forms.Padding(4);
            this.changeСargoWeights.Name = "changeСargoWeights";
            this.changeСargoWeights.Size = new System.Drawing.Size(60, 22);
            this.changeСargoWeights.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 171);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "сопротивления";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 155);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Параметр";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Вес груза";
            // 
            // changeLongThreads
            // 
            this.changeLongThreads.Location = new System.Drawing.Point(127, 38);
            this.changeLongThreads.Margin = new System.Windows.Forms.Padding(4);
            this.changeLongThreads.Name = "changeLongThreads";
            this.changeLongThreads.Size = new System.Drawing.Size(60, 22);
            this.changeLongThreads.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Длина нити";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.StepOnT);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(1262, 429);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(188, 66);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Параметр вывода";
            // 
            // StepOnT
            // 
            this.StepOnT.Location = new System.Drawing.Point(129, 34);
            this.StepOnT.Name = "StepOnT";
            this.StepOnT.Size = new System.Drawing.Size(59, 22);
            this.StepOnT.TabIndex = 1;
            this.StepOnT.ValueChanged += new System.EventHandler(this.StepOnT_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Шаг по t";
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.ButtonFloorColor);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.ButtonBoxColor);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.ButtonСolorBall);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.SphereRadiusChanges);
            this.groupBox5.Location = new System.Drawing.Point(1262, 501);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(188, 162);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Внешний вид";
            // 
            // ButtonFloorColor
            // 
            this.ButtonFloorColor.Location = new System.Drawing.Point(129, 130);
            this.ButtonFloorColor.Name = "ButtonFloorColor";
            this.ButtonFloorColor.Size = new System.Drawing.Size(59, 23);
            this.ButtonFloorColor.TabIndex = 7;
            this.ButtonFloorColor.Text = "цвет";
            this.ButtonFloorColor.UseVisualStyleBackColor = true;
            this.ButtonFloorColor.Click += new System.EventHandler(this.ButtonFloorColor_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 16);
            this.label10.TabIndex = 6;
            this.label10.Text = "Цвет пола";
            // 
            // ButtonBoxColor
            // 
            this.ButtonBoxColor.Location = new System.Drawing.Point(129, 98);
            this.ButtonBoxColor.Name = "ButtonBoxColor";
            this.ButtonBoxColor.Size = new System.Drawing.Size(59, 26);
            this.ButtonBoxColor.TabIndex = 5;
            this.ButtonBoxColor.Text = "цвет";
            this.ButtonBoxColor.UseVisualStyleBackColor = true;
            this.ButtonBoxColor.Click += new System.EventHandler(this.ButtonBoxColor_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 16);
            this.label9.TabIndex = 4;
            this.label9.Text = "Цвет платфрмы";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "Цвет сферы";
            // 
            // ButtonСolorBall
            // 
            this.ButtonСolorBall.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonСolorBall.Location = new System.Drawing.Point(129, 66);
            this.ButtonСolorBall.Name = "ButtonСolorBall";
            this.ButtonСolorBall.Size = new System.Drawing.Size(59, 26);
            this.ButtonСolorBall.TabIndex = 2;
            this.ButtonСolorBall.Text = "цвет";
            this.ButtonСolorBall.UseVisualStyleBackColor = true;
            this.ButtonСolorBall.Click += new System.EventHandler(this.ButtonСolorBall_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 39);
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
            this.SphereRadiusChanges.Location = new System.Drawing.Point(129, 36);
            this.SphereRadiusChanges.Name = "SphereRadiusChanges";
            this.SphereRadiusChanges.Size = new System.Drawing.Size(59, 24);
            this.SphereRadiusChanges.TabIndex = 0;
            this.SphereRadiusChanges.SelectedIndexChanged += new System.EventHandler(this.SphereRadiusChanges_SelectedIndexChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1462, 964);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ramkaVertex);
            this.Controls.Add(this.GL);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1243, 750);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Визуализация маятника";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ramkaVertex.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridVertex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GL)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.changeResistanceParameter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.changeAngleOfeviation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.changeСargoWeights)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.changeLongThreads)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StepOnT)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox ramkaVertex;
        private System.Windows.Forms.DataGridView gridVertex;
        private SharpGL.OpenGLControl GL;
        private System.Windows.Forms.Button ButtonStart;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Column0;
        private System.Windows.Forms.DataGridViewTextBoxColumn z;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
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
        private System.Windows.Forms.Button ButtonFloorColor;
        private System.Windows.Forms.Label label10;
    }
}

