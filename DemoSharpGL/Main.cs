using System;
using System.Drawing;
using System.Windows.Forms;
using SharpGL;
using SharpGL.Enumerations;
using SharpGL.SceneGraph;
using Texture = SharpGL.SceneGraph.Assets.Texture;
using System.Collections.Generic;
using System.Numerics;


namespace DemoSharpGL
{
    public partial class FormMain : Form
    {
        float lenght = 2.0f;
        float f = 0.05f;
        float m = 1.0f;
        float angle = 90.0f;
        private float beta;              // коэффициент затухания (β)
        private float omega;             // собственная угловая частота (ω)
        private float x0;                // начальная амплитуда (в радианах)
        const float gravity = 9.81f;
        const float phi0 = 0.0f;         // начальная фаза (φ0)
        float time = 0.0f;               // текущее время t
        const float deltaTime = 0.01f;   // шаг времени для анимации      
        int q = 0;
        int h = 20;
        int radiusSphere = 20;

        //camera
        bool round = false;
        int radius = 800;
        double distanceX = 0;
        double distanceY = 100;
        double distanceZ = 800;
        double cameraAngle = 0.0;

        //color
        Color sphereColor = Color.FromName("Pink");
        Color floorColor = Color.FromName("Pink");
        Color boxColor = Color.FromName("Yellow");


        //start
        private Timer animationTimer;
        private OpenGLControl glControl;
        private bool isStarted = false;

        //texture
        uint[] textures = new uint[1];
        Bitmap textureImage;
        string sourseTextureFloor;
        string sourseTextureBall;
        private Texture texture = new Texture();
        private Texture texture1 = new Texture();
        private bool textureFlagFloor = false;
        private bool textureFlagBall = false;

        //Point
        List<Vector3> Points = new List<Vector3>();
        bool point = false;

        //Model
        private LoaderModel modelLoader = new LoaderModel();
        public FormMain()
        {
            InitializeComponent();

            glControl = new OpenGLControl();
            glControl.Name = "glControl";
            glControl.Dock = DockStyle.Fill;
            glControl.OpenGLInitialized += GL_OpenGLInitialized;
            glControl.OpenGLDraw += GL_OpenGLDraw;
            glControl.Resized += GL_Resized;
            glControl.RenderTrigger = RenderTrigger.Manual; 
            glControl.Visible = true; 
            this.Controls.Add(glControl);
            //60 FPS
            animationTimer = new Timer();
            animationTimer.Interval = 16;
            animationTimer.Tick += AnimationTimer_Tick;
            animationTimer.Start();

            changeLongThreads.DecimalPlaces = 1;
            changeLongThreads.Increment = 0.1M;
            changeLongThreads.Minimum = 0;
            changeLongThreads.Maximum = 2.2M;
            changeLongThreads.Value = (decimal)lenght;
            changeСargoWeights.Value = (decimal)m;

            changeAngleOfeviation.Increment = 10;
            changeAngleOfeviation.Minimum = 0;
            changeAngleOfeviation.Maximum = 90;
            changeAngleOfeviation.Value = (decimal)angle;

            changeResistanceParameter.DecimalPlaces = 2;
            changeResistanceParameter.Increment = 0.02M;
            changeResistanceParameter.Minimum = 0;
            changeResistanceParameter.Maximum = 1;
            changeResistanceParameter.Value = (decimal)f;

            SphereRadiusChanges.SelectedIndex = 4;
            TextureBall.SelectedIndex = 0;
            TextureFloor.SelectedIndex = 0;

            StepOnT.Increment = 10;
            StepOnT.Minimum = 0;
            StepOnT.Maximum = 100;
            StepOnT.Value = (decimal)h;
        }

        private void FillingInTheParameters() {
            lenght = (float)changeLongThreads.Value;
            m = (int)changeСargoWeights.Value;
            angle = (int)changeAngleOfeviation.Value;
            f = (float)changeResistanceParameter.Value;
        
            omega = (float)Math.Sqrt(gravity / lenght);
            beta = -f / 2 * m;
            x0 = (float)Math.PI * angle / 180;
        }

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            if (isStarted)
            {
                UpdatePendulum();
                glControl.DoRender(); 
            }
        }

        private void GL_OpenGLInitialized(object sender, EventArgs e)
        {
            var gl = GL.OpenGL;
            int W = GL.Width, H = GL.Height;

            //Область вывода
            gl.Viewport(0, 0, W, H);

            // Проекция
            gl.MatrixMode(OpenGL.GL_PROJECTION);
            gl.LoadIdentity();
            gl.Perspective(45.0f, (float)W / H, 1.0f, 2000.0f);

            //Модель‑вид — камера
            gl.MatrixMode(OpenGL.GL_MODELVIEW);
            gl.LoadIdentity();
            gl.LookAt(distanceX, distanceY, distanceZ,
                0, 0, 0,
                0, 1, 0);
            
            //Освещение и глубина
            gl.Enable(OpenGL.GL_DEPTH_TEST);

            SetupLighting(gl);
            SetupSpotlight(gl);
            
            //gl.PolygonMode(OpenGL.GL_FRONT_AND_BACK, OpenGL.GL_FILL);
        }

        private void GL_OpenGLDraw(object sender, RenderEventArgs args)
        {
            var gl = GL.OpenGL;

            if (!isStarted)
            {
                gl.ClearColor(1f, 1f, 1f, 1f);
              // gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);
                return;
            }

            gl.ClearColor(0.53f, 0.81f, 0.92f, 1.0f); 
            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);
            gl.MatrixMode(OpenGL.GL_MODELVIEW);
            gl.LoadIdentity();
            gl.LookAt(distanceX, distanceY, distanceZ,
                0, 0, 0,
                0, 1, 0);

            gl.PushMatrix();
            gl.Translate(0.0f, 300.0f, 0.0f);    // та же позиция, что и свет
            gl.Color(0.9f, 0.9f, 0.1f);
            DrawSphere(gl, 5, 10, 10);
            gl.PopMatrix();
            
            //DrawTexturedQuad(gl); // тест на квадрате

            DrawPendulum(gl);

           
            modelLoader.LoadModel(gl, @"D:\DemoSharpGL\source\gsc_branche.glb");
          

            gl.Finish();
        }

        void DrawTexturedQuad(OpenGL gl)
        {
            gl.Enable(OpenGL.GL_TEXTURE_2D); // Включаем поддержку 2D-текстур
            texture.Bind(gl);               // Привязываем текстуру

            gl.PushMatrix();
            gl.Translate(50.0f, 100.0f, 0.0f);
            gl.Scale(200.0f, 200.0f, 200.0f);
            gl.Color(1f, 1f, 1f);
            
            gl.Begin(OpenGL.GL_QUADS);

            gl.TexCoord(0.0f, 0.0f); gl.Vertex(-1.0f, -1.0f, 0.0f);

            gl.TexCoord(1.0f, 0.0f); gl.Vertex(1.0f, -1.0f, 0.0f);

            gl.TexCoord(1.0f, 1.0f); gl.Vertex(1.0f, 1.0f, 0.0f);

            gl.TexCoord(0.0f, 1.0f); gl.Vertex(-1.0f, 1.0f, 0.0f);

            gl.End();
            gl.PopMatrix();
            //gl.Disable(OpenGL.GL_TEXTURE_2D);
        }

        private void GL_Resized(object sender, EventArgs e)
        {
            GL_OpenGLInitialized(sender, e);
        }

        private void UpdatePendulum()
        {
            time += deltaTime;
            // вычисляем новый угол по формуле x0 e^(−βt) cos(ωt + φ0)
            angle = x0 * (float)Math.Exp(beta * time) * (float)Math.Cos(omega * time + phi0);
        }

        private void DrawPendulum(OpenGL gl)
        {
            q++;
            gl.PushMatrix();

            gl.Translate(0, 150, 0);

            float scale = 100f;
            float x = lenght * (float)Math.Sin(angle) * scale;
            float y = lenght * (float)Math.Cos(angle) * scale;

            gl.Color(0.2f, 0.2f, 0.2f);
            gl.LineWidth(1f);
            gl.Begin(OpenGL.GL_LINES);
            gl.Vertex(0f, 0f, 0f);
            gl.Vertex(x, -y, 0f);
            gl.End();

            gl.PushMatrix();
            gl.Translate(x, -y, 0f);
            gl.Color(sphereColor);
            DrawSphere(gl, radiusSphere, 20, 20);
            gl.PopMatrix();

            gl.PushMatrix();
            gl.Scale(3.0f, 3.0f, 3.0f);
            gl.Translate(0, -85, 0);
            gl.Color(floorColor);
            if (textureFlagFloor)
            {
                gl.Enable(OpenGL.GL_TEXTURE_2D);
                texture.Bind(gl);
            }
            //DrawSolidBox(gl, 150, 5, 100);
            DrawCylindricalScene(gl, 100, 5, 90);
            gl.Disable(OpenGL.GL_TEXTURE_2D);
            //DrawFloor(gl);
            gl.PopMatrix();

            /*
            gl.PushMatrix();
            // gl.Rotate(-45, 0, 1, 0);
            gl.Translate(0, 10, 0f);
            gl.Scale(2.0f, 2.0f, 2.0f);
            gl.Color(boxColor);
            DrawSolidBox(gl, 10, 5, 5);    
            gl.PopMatrix();
            */
            if (point)
            {
                Points.Add(new Vector3(x, -230, 0));
                gl.Color(0, 0, 0);
                gl.PointSize(3f);
                gl.Disable(OpenGL.GL_DEPTH_TEST);
                gl.Begin(OpenGL.GL_POINTS);
                foreach (Vector3 i in Points)
                {
                    gl.Vertex(i.X, i.Y, i.Z);
                }
                gl.End();
                gl.Enable(OpenGL.GL_DEPTH_TEST);
            }

            gl.PopMatrix();

            float angleValue = CalculateAngleFromPosition(x, y);

            if (q%h == 0) {
                int n = gridVertex.RowCount;
                gridVertex.Rows.Add();
                gridVertex[0, n].Value = time.ToString("F2");
                gridVertex[1, n].Value = angleValue.ToString("F2");
                gridVertex[2, n].Value = (x/100f).ToString("F2");
            }
        }

        private float CalculateAngleFromPosition(float dx, float dy)
        {
            float ropeLength = (float)Math.Sqrt(dx * dx + dy * dy);
            if (ropeLength == 0) return 0;

            float rx = dx / ropeLength;
            float ry = dy / ropeLength;

            // вертикаль — это (0, 1)
            float dot = rx * 0 + ry * 1;              
            dot = Math.Max(-1.0f, Math.Min(1.0f, dot));

            float angleRad = (float)Math.Acos(dot); 

            if (rx < 0)
                angleRad = -angleRad;

            return angleRad * (180.0f / (float)Math.PI);
        }

        private void DrawFloor(OpenGL gl) {
            float halfX = 100f, halfY = 0f, halfZ = 100f;
            gl.Color(floorColor);
 
            if (textureFlagFloor)
            {
                gl.Enable(OpenGL.GL_TEXTURE_2D);
                texture.Bind(gl);
            }

            gl.Normal(0f, 1f, 1f);
            gl.Begin(OpenGL.GL_QUADS);
            gl.TexCoord(0, 0); gl.Vertex(-halfX, halfY, halfZ);
            gl.TexCoord(1, 0); gl.Vertex(halfX, halfY, halfZ);
            gl.TexCoord(1, 1); gl.Vertex(halfX, halfY, -halfZ);
            gl.TexCoord(0, 1); gl.Vertex(-halfX, halfY, -halfZ);
            gl.End();
            gl.Disable(OpenGL.GL_TEXTURE_2D);
        }

        private void DrawSolidBox(OpenGL gl, float halfX, float halfY, float halfZ)
        {
            gl.Begin(OpenGL.GL_QUADS);

            // Передняя грань (+Z)
            gl.Normal(0, 0, 1);
            gl.TexCoord(0, 0); gl.Vertex(-halfX, -halfY, halfZ);
            gl.TexCoord(1, 0); gl.Vertex(halfX, -halfY, halfZ);
            gl.TexCoord(1, 1); gl.Vertex(halfX, halfY, halfZ);
            gl.TexCoord(0, 1); gl.Vertex(-halfX, halfY, halfZ);

            // Задняя грань (–Z)
            gl.Normal(0, 0, -1);
            gl.TexCoord(0, 0); gl.Vertex(halfX, -halfY, -halfZ);
            gl.TexCoord(1, 0); gl.Vertex(-halfX, -halfY, -halfZ);
            gl.TexCoord(1, 1); gl.Vertex(-halfX, halfY, -halfZ);
            gl.TexCoord(0, 1); gl.Vertex(halfX, halfY, -halfZ);

            // Левая грань (–X)
            gl.Normal(-1, 0, 0);
            gl.TexCoord(0, 0); gl.Vertex(-halfX, -halfY, -halfZ);
            gl.TexCoord(1, 0); gl.Vertex(-halfX, -halfY, halfZ);
            gl.TexCoord(1, 1); gl.Vertex(-halfX, halfY, halfZ);
            gl.TexCoord(0, 1); gl.Vertex(-halfX, halfY, -halfZ);

            // Правая грань (+X)
            gl.Normal(1, 0, 0);
            gl.TexCoord(0, 0); gl.Vertex(halfX, -halfY, halfZ);
            gl.TexCoord(1, 0); gl.Vertex(halfX, -halfY, -halfZ);
            gl.TexCoord(1, 1); gl.Vertex(halfX, halfY, -halfZ);
            gl.TexCoord(0, 1); gl.Vertex(halfX, halfY, halfZ);

            // Нижняя грань (–Y)
            gl.Normal(0, -1, 0);
            gl.TexCoord(0, 0); gl.Vertex(-halfX, -halfY, -halfZ);
            gl.TexCoord(1, 0); gl.Vertex(halfX, -halfY, -halfZ);
            gl.TexCoord(1, 1); gl.Vertex(halfX, -halfY, halfZ);
            gl.TexCoord(0, 1); gl.Vertex(-halfX, -halfY, halfZ);

            // Верхняя грань (+Y)
            gl.Normal(0, 1, 0);
            gl.TexCoord(0, 0); gl.Vertex(-halfX, halfY, halfZ);
            gl.TexCoord(1, 0); gl.Vertex(halfX, halfY, halfZ);
            gl.TexCoord(1, 1); gl.Vertex(halfX, halfY, -halfZ);
            gl.TexCoord(0, 1); gl.Vertex(-halfX, halfY, -halfZ);

            gl.End();
        }

        private void DrawCylindricalScene(OpenGL gl, float radius, float height, int segments)
        {
            float halfHeight = height / 2.0f;
            float angleStep = 2.0f * (float)Math.PI / segments;

            DrawCircle(gl, radius, -halfHeight, false, segments);

            DrawCircle(gl, radius, halfHeight, true, segments);

            gl.Begin(OpenGL.GL_QUAD_STRIP);
            for (int i = 0; i <= segments; i++)
            {
                float angle = i * angleStep;
                float x = radius * (float)Math.Cos(angle);
                float z = radius * (float)Math.Sin(angle);
                float s = (float)i / segments; 

                gl.Normal((float)Math.Cos(angle), 0, (float)Math.Sin(angle));
                gl.TexCoord(s, 0); gl.Vertex(x, -halfHeight, z);
                gl.TexCoord(s, 1); gl.Vertex(x, halfHeight, z);
            }
            gl.End();
        }

        private void DrawCircle(OpenGL gl, float radius, float y, bool isTop, int segments)
        {
            float angleStep = 2.0f * (float)Math.PI / segments;

            gl.Begin(OpenGL.GL_TRIANGLE_FAN);
            gl.Normal(0, isTop ? 1 : -1, 0);
            gl.TexCoord(0.5f, 0.5f);
            gl.Vertex(0, y, 0); 

            for (int i = 0; i <= segments; i++)
            {
                float angle = i * angleStep;
                float x = radius * (float)Math.Cos(angle);
                float z = radius * (float)Math.Sin(angle);

                gl.TexCoord((x / radius + 1) / 2, (z / radius + 1) / 2);
                gl.Vertex(x, y, z);
            }

            gl.End();
        }

        private void SetupLighting(OpenGL gl)
        {
            gl.Enable(OpenGL.GL_LIGHTING);
            gl.Enable(OpenGL.GL_LIGHT0);

            gl.Enable(OpenGL.GL_COLOR_MATERIAL);
            gl.ColorMaterial(OpenGL.GL_FRONT_AND_BACK, OpenGL.GL_AMBIENT_AND_DIFFUSE);

            gl.Enable(OpenGL.GL_NORMALIZE);

            gl.Light(LightName.Light0, LightParameter.Ambient, new float[] { 0.1f, 0.1f, 0.1f, 1 });
            gl.Light(LightName.Light0, LightParameter.Diffuse, new float[] { 0.8f, 0.8f, 0.9f, 1 });
            gl.Light(LightName.Light0, LightParameter.Specular, new float[] { 0.4f, 0.4f, 0.4f, 1 });
            // положение (после LoadIdentity — в мировых координатах)
            gl.Light(LightName.Light0, LightParameter.Position, new float[] { 0, 300, 0, 1 });
        }

        private void SetupSpotlight(OpenGL gl)
        {
            gl.Enable(OpenGL.GL_LIGHTING);
            gl.Enable(OpenGL.GL_LIGHT1);

            gl.Enable(OpenGL.GL_COLOR_MATERIAL);
            gl.ColorMaterial(OpenGL.GL_FRONT_AND_BACK, OpenGL.GL_AMBIENT_AND_DIFFUSE);

            gl.Enable(OpenGL.GL_NORMALIZE);

            // Сглаженное освещение
            gl.ShadeModel(OpenGL.GL_SMOOTH);


            // Цвета прожектора
            gl.Light(OpenGL.GL_LIGHT1, OpenGL.GL_AMBIENT, new float[] { 0.1f, 0.1f, 0.1f, 1 });
            gl.Light(OpenGL.GL_LIGHT1, OpenGL.GL_DIFFUSE, new float[] { 0.8f, 0.8f, 0.9f, 1 });
            gl.Light(OpenGL.GL_LIGHT1, OpenGL.GL_SPECULAR, new float[] { 0.4f, 0.4f, 0.4f, 1 });

            
            float[] position = { 0.0f, 200.0f, 0f, 1.0f };
            gl.Light(OpenGL.GL_LIGHT1, OpenGL.GL_POSITION, position);

            // Направление
            float[] direction = { 0.0f, -1.0f, 0f };
            gl.Light(OpenGL.GL_LIGHT1, OpenGL.GL_SPOT_DIRECTION, direction);

            // Параметры пятна 
            gl.Light(OpenGL.GL_LIGHT1, OpenGL.GL_SPOT_CUTOFF, 45.0f);
            gl.Light(OpenGL.GL_LIGHT1, OpenGL.GL_SPOT_EXPONENT, 10.0f);

            // Опционально: коэффициенты затухания
            //gl.Light(OpenGL.GL_LIGHT1, OpenGL.GL_CONSTANT_ATTENUATION, 1.0f);
            //gl.Light(OpenGL.GL_LIGHT1, OpenGL.GL_LINEAR_ATTENUATION, 0.005f);
            //gl.Light(OpenGL.GL_LIGHT1, OpenGL.GL_QUADRATIC_ATTENUATION, 0.0001f);
        }

        private void DrawSphere(OpenGL gl, float radius, int latSegments, int lonSegments)
        {
            if (textureFlagBall)
                gl.Enable(OpenGL.GL_TEXTURE_2D);
                texture1.Bind(gl);

            for (int i = 0; i < latSegments; i++)
            {
                float lat0 = (float)Math.PI * (-0.5f + (float)i / latSegments);
                float lat1 = (float)Math.PI * (-0.5f + (float)(i + 1) / latSegments);
                float z0 = radius * (float)Math.Sin(lat0), zr0 = radius * (float)Math.Cos(lat0);
                float z1 = radius * (float)Math.Sin(lat1), zr1 = radius * (float)Math.Cos(lat1);

                float v0 = (float)i / latSegments;
                float v1 = (float)(i + 1) / latSegments;

                gl.Begin(OpenGL.GL_QUAD_STRIP);
                for (int j = 0; j <= lonSegments; j++)
                {
                    float lng = 2.0f * (float)Math.PI * j / lonSegments;
                    float x = (float)Math.Cos(lng);
                    float y = (float)Math.Sin(lng);

                    float u = (float)j / lonSegments;

                    // вершина 1
                    gl.TexCoord(u, v0);
                    gl.Normal(x * zr0, y * zr0, z0);
                    gl.Vertex(x * zr0, y * zr0, z0);

                    // вершина 2
                    gl.TexCoord(u, v1);
                    gl.Normal(x * zr1, y * zr1, z1);
                    gl.Vertex(x * zr1, y * zr1, z1);
                }
                gl.End();
            }
            gl.Disable(OpenGL.GL_TEXTURE_2D);
        }

        private void GL_MouseClick(object sender, MouseEventArgs e)
        {
            /* Получение размкеров порта GL */
            int w = GL.Width;
            int h = GL.Height;

            /* Получение оконных координат мыши */
            int x = e.Location.X;
            int y = e.Location.Y;


        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            time = 0;
            isStarted = true;
            FillingInTheParameters();
            animationTimer.Start();
            gridVertex.Rows.Clear();
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
            isStarted = false;
        }

        private void buttonForth_Click(object sender, EventArgs e)
        {
            isStarted = true;
        }

        private void Zoom_Click(object sender, EventArgs e)
        {
            distanceZ -= 10;
        }

        private void Distance_Click(object sender, EventArgs e)
        {
            distanceZ += 10;
        }

        private void CameraUp_Click(object sender, EventArgs e)
        {
            distanceY += 10;
        }

        private void CameraTop_Click(object sender, EventArgs e)
        {
            distanceY -= 10;
        }

        private void CameraLeft_Click(object sender, EventArgs e)
        {
            distanceX -= 10;
            distanceZ -= 5;
        }

        private void CameraRight_Click(object sender, EventArgs e)
        {
            distanceX += 10;
            distanceZ += 5;
        }

        private void CameraStartPoint_Click(object sender, EventArgs e)
        {
            distanceX = 0;
            distanceY = 100;
            distanceZ = 800;
        }

        private void CameraRound_Click(object sender, EventArgs e)
        {
            round = true;
            cameraAngle = 0.5; // начальный угол
            distanceX = radius * Math.Sin(cameraAngle);
            distanceZ = radius * Math.Cos(cameraAngle);
        }

        private void ClockwiseMovement_Click(object sender, EventArgs e)
        {
            if (!round) return;

            cameraAngle -= 0.1;
            if (cameraAngle < 0)
                cameraAngle += 2 * Math.PI;

            distanceX = radius * Math.Sin(cameraAngle);
            distanceZ = radius * Math.Cos(cameraAngle);
        }

        private void СounterClockwiseMovement_Click(object sender, EventArgs e)
        {
            if (!round) return;

            cameraAngle += 0.1;
            if (cameraAngle > 2 * Math.PI)
                cameraAngle -= 2 * Math.PI;

            distanceX = radius * Math.Sin(cameraAngle);
            distanceZ = radius * Math.Cos(cameraAngle);
        }

        private void SphereRadiusChanges_SelectedIndexChanged(object sender, EventArgs e)
        {
                switch (SphereRadiusChanges.SelectedIndex)
            {
                case 0: radiusSphere = 5; break;
                case 1: radiusSphere = 10; break;
                case 2: radiusSphere = 12; break;
                case 3: radiusSphere = 15; break;
                case 4: radiusSphere = 20; break;
                case 5: radiusSphere = 25; break;
            }
        }

        private void StepOnT_ValueChanged(object sender, EventArgs e)
        {
            h = (int)StepOnT.Value;
        }

        private void ButtonСolorBall_Click(object sender, EventArgs e)
        {
            colorDialogMain.Color = sphereColor;
            colorDialogMain.ShowDialog();
            sphereColor = colorDialogMain.Color;
        }

        private void ButtonBoxColor_Click(object sender, EventArgs e)
        {
            colorDialogMain.Color = boxColor;
            colorDialogMain.ShowDialog();
            boxColor = colorDialogMain.Color;
        }

        private void ButtonFloorColor_Click_1(object sender, EventArgs e)
        {
            colorDialogMain.Color = floorColor;
            colorDialogMain.ShowDialog();
            floorColor = colorDialogMain.Color;
        }

        private void TextureBall_SelectedIndexChanged(object sender, EventArgs e)
        {
            var gl = GL.OpenGL;
            switch (TextureBall.SelectedIndex)
            {
                case 0: textureFlagBall = false; break;
                case 1: textureFlagBall = true;
                        sourseTextureBall = @"D:\DemoSharpGL\texture\coconut.jpg";
                        textureImage = new Bitmap(sourseTextureBall);
                        texture1.Create(gl, textureImage);
                        break;
                case 2: textureFlagBall = true;
                        sourseTextureBall = @"D:\DemoSharpGL\texture\orange.jpg";
                        textureImage = new Bitmap(sourseTextureBall);
                        texture1.Create(gl, textureImage);
                        break;
            }
        }

        private void TextureFloor_SelectedIndexChanged(object sender, EventArgs e)
        {
            var gl = GL.OpenGL;
            switch (TextureFloor.SelectedIndex)
            {
                case 0: textureFlagFloor = false; break;
                case 1: textureFlagFloor = true;
                        sourseTextureFloor = @"D:\DemoSharpGL\texture\sand1.jpg";
                        textureImage = new Bitmap(sourseTextureFloor);
                        texture.Create(gl, textureImage);
                        break;
                case 2: textureFlagFloor = true;
                        sourseTextureFloor = @"D:\DemoSharpGL\texture\grass.jpg";
                        textureImage = new Bitmap(sourseTextureFloor);
                        texture.Create(gl, textureImage);
                        break;
            }
        }

        private void RadioButtonLightingOn_CheckedChanged(object sender, EventArgs e)
        {
            var gl = GL.OpenGL;
            gl.Enable(OpenGL.GL_LIGHT0);
        }

        private void radioButtonLightingOff_CheckedChanged(object sender, EventArgs e)
        {
            var gl = GL.OpenGL;
            gl.Disable(OpenGL.GL_LIGHT0);
        }

        private void radioButtonSearchlightOn_CheckedChanged(object sender, EventArgs e)
        {
            var gl = GL.OpenGL;
            gl.Enable(OpenGL.GL_LIGHT1);
        }

        private void radioButtonSearchlightOff_CheckedChanged(object sender, EventArgs e)
        {
            var gl = GL.OpenGL;
            gl.Disable(OpenGL.GL_LIGHT1);
        }

        private void radioButtonProjectionOn_CheckedChanged(object sender, EventArgs e)
        {
            point = true;
        }

        private void radioButtonProjectionOff_CheckedChanged(object sender, EventArgs e)
        {
           point = false;
        }

        private void radioButtonСlearPoint_CheckedChanged(object sender, EventArgs e)
        {
            Points.Clear();
        }

    }
}
