using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using SharpGL;
using SharpGL.Enumerations;
using SharpGL.SceneGraph;

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
        bool textureLoaded = false;
        //camera
        bool round = false;
        int radius = 800;
        double distanceX = 0;
        double distanceY = 100;
        double distanceZ = 800;
        double cameraAngle = 0.0;

        //Цвет
        Color sphereColor = Color.FromName("Red");
        Color floorColor = Color.FromName("Yellow");
        Color boxColor = Color.FromName("Yellow");

        private Timer animationTimer;
        private OpenGLControl glControl;
        private bool isStarted = false;
        private uint textureId;
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
            gl.PolygonMode(OpenGL.GL_FRONT_AND_BACK, OpenGL.GL_FILL);
            /*
                gl.Enable(OpenGL.GL_TEXTURE_2D);
                textureId = TextureLoader.LoadTexture(gl, @"D:\DemoSharpGL\texture\sand.jpg");
                gl.TexParameter(OpenGL.GL_TEXTURE_2D, OpenGL.GL_TEXTURE_MIN_FILTER, OpenGL.GL_LINEAR);
                gl.TexParameter(OpenGL.GL_TEXTURE_2D, OpenGL.GL_TEXTURE_MAG_FILTER, OpenGL.GL_LINEAR);
                gl.TexEnv(OpenGL.GL_TEXTURE_ENV, OpenGL.GL_TEXTURE_ENV_MODE, OpenGL.GL_REPLACE);
                gl.BindTexture(OpenGL.GL_TEXTURE_2D, 0);*/
        }

        private void GL_OpenGLDraw(object sender, RenderEventArgs args)
        {
            var gl = GL.OpenGL;

            if (!isStarted)
            {
                gl.ClearColor(1f, 1f, 1f, 1f);
                gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);
                return;
            }

            gl.ClearColor(1f, 1f, 1f, 1f);
            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);
            gl.MatrixMode(OpenGL.GL_MODELVIEW);
            gl.LoadIdentity();
            gl.LookAt(distanceX, distanceY, distanceZ,
                0, 0, 0,
                0, 1, 0);

            gl.PushMatrix();
            gl.Translate(0, 300, 0);    // та же позиция, что и свет
            gl.Color(1f, 0f, 1f);
            DrawSphere(gl, 5, 10, 10);
            gl.PopMatrix();

            DrawPendulum(gl);

            gl.Finish();
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
            gl.Scale(3.0f, 3.0f, 3.0f);
            gl.Translate(0, -80, 0);
            DrawFloor(gl);
            gl.PopMatrix();

            gl.PushMatrix();
            gl.Translate(x, -y, 0f);
            gl.Color(sphereColor);
            DrawSphere(gl, radiusSphere, 20, 20);
            gl.PopMatrix();

            gl.PushMatrix();
            // gl.Rotate(-45, 0, 1, 0);
            gl.Translate(0, 10, 0f);
            gl.Scale(2.0f, 2.0f, 2.0f);
            DrawSolidBox(gl);    
            gl.PopMatrix();

            gl.PopMatrix();

            float angleValue = CalculateAngleFromPosition(x, y);
            if (q%h == 0) {
                int n = gridVertex.RowCount;
                gridVertex.Rows.Add();
                gridVertex[0, n].Value = time.ToString("F2");
                gridVertex[1, n].Value = angleValue.ToString("F2");
                gridVertex[2, n].Value = x.ToString("F2");
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

            float angleRad = (float)Math.Acos(dot); // угол от вертикали

            if (rx < 0)
                angleRad = -angleRad;

            return angleRad * (180.0f / (float)Math.PI);
        }

        private void DrawFloor(OpenGL gl) {
            float halfX = 100f, halfY = 0f, halfZ = 100f;
           // gl.Enable(OpenGL.GL_TEXTURE_2D);
            //gl.TexEnv(OpenGL.GL_TEXTURE_ENV, OpenGL.GL_TEXTURE_ENV_MODE, OpenGL.GL_REPLACE);
            //gl.BindTexture(OpenGL.GL_TEXTURE_2D, textureId);
            gl.Color(floorColor);

            gl.Begin(OpenGL.GL_QUADS);
            gl.TexCoord(0, 0); gl.Vertex(-halfX, halfY, halfZ);
            gl.TexCoord(1, 0); gl.Vertex(halfX, halfY, halfZ);
            gl.TexCoord(1, 1); gl.Vertex(halfX, halfY, -halfZ);
            gl.TexCoord(0, 1); gl.Vertex(-halfX, halfY, -halfZ);
            gl.End();

           // gl.BindTexture(OpenGL.GL_TEXTURE_2D, 0);
           // gl.PopAttrib();
        }

        private void DrawSolidBox(OpenGL gl)
        {
            float halfX = 10f; 
            float halfY = 5f;
            float halfZ = 2.5f;

            gl.Color(boxColor);
            gl.Begin(OpenGL.GL_QUADS);

            // Передняя грань (+Z)
            gl.Normal(0, 0, 1);
            gl.Vertex(-halfX, -halfY, halfZ);
            gl.Vertex(halfX, -halfY, halfZ);
            gl.Vertex(halfX, halfY, halfZ);
            gl.Vertex(-halfX, halfY, halfZ);

            // Задняя грань (–Z)
            gl.Normal(0, 0, -1);
            gl.Vertex(halfX, -halfY, -halfZ);
            gl.Vertex(-halfX, -halfY, -halfZ);
            gl.Vertex(-halfX, halfY, -halfZ);
            gl.Vertex(halfX, halfY, -halfZ);

            // Левая грань (–X)
            gl.Normal(-1, 0, 0);
            gl.Vertex(-halfX, -halfY, -halfZ);
            gl.Vertex(-halfX, -halfY, halfZ);
            gl.Vertex(-halfX, halfY, halfZ);
            gl.Vertex(-halfX, halfY, -halfZ);

            // Правая грань (+X)
            gl.Normal(1, 0, 0);
            gl.Vertex(halfX, -halfY, halfZ);
            gl.Vertex(halfX, -halfY, -halfZ);
            gl.Vertex(halfX, halfY, -halfZ);
            gl.Vertex(halfX, halfY, halfZ);

            // Нижняя грань (–Y)
            gl.Normal(0, -1, 0);
            gl.Vertex(-halfX, -halfY, -halfZ);
            gl.Vertex(halfX, -halfY, -halfZ);
            gl.Vertex(halfX, -halfY, halfZ);
            gl.Vertex(-halfX, -halfY, halfZ);

            // Верхняя грань (+Y)
            gl.Normal(0, 1, 0);
            gl.Vertex(-halfX, halfY, halfZ);
            gl.Vertex(halfX, halfY, halfZ);
            gl.Vertex(halfX, halfY, -halfZ);
            gl.Vertex(-halfX, halfY, -halfZ);

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

        private void DrawSphere(OpenGL gl, float radius, int latSegments, int lonSegments)
        {
            for (int i = 0; i < latSegments; i++)
            {
                float lat0 = (float)Math.PI * (-0.5f + (float)i / latSegments);
                float lat1 = (float)Math.PI * (-0.5f + (float)(i + 1) / latSegments);
                float z0 = radius * (float)Math.Sin(lat0), zr0 = radius * (float)Math.Cos(lat0);
                float z1 = radius * (float)Math.Sin(lat1), zr1 = radius * (float)Math.Cos(lat1);

                gl.Begin(OpenGL.GL_QUAD_STRIP);
                for (int j = 0; j <= lonSegments; j++)
                {
                    float lng = 2.0f * (float)Math.PI * j / lonSegments;
                    float x = (float)Math.Cos(lng);
                    float y = (float)Math.Sin(lng);

                    // вершина 1
                    gl.Normal(x * zr0, y * zr0, z0);    
                    gl.Vertex(x * zr0, y * zr0, z0);

                    // вершина 2
                    gl.Normal(x * zr1, y * zr1, z1);
                    gl.Vertex(x * zr1, y * zr1, z1);
                }
                gl.End();
            }
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
        }

        private void CameraRight_Click(object sender, EventArgs e)
        {
            distanceX += 10;
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

        private void ButtonFloorColor_Click(object sender, EventArgs e)
        {
            colorDialogMain.Color = floorColor;
            colorDialogMain.ShowDialog();
            floorColor = colorDialogMain.Color;
        }
    }
}
