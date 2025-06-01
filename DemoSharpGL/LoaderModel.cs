using SharpGL;
using SharpGL.SceneGraph;
using SharpGL.SceneGraph.Quadrics;
using SharpGLTF.Schema2;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
public class LoaderModel
{
    public void LoadModel(OpenGL gl, string filePath, int figure)
    {
        if (!File.Exists(filePath))
        {
            throw new FileNotFoundException("Файл модели не найден.", filePath);
        }

        var stream = File.OpenRead(filePath);
        var model = ModelRoot.ReadGLB(stream, new ReadSettings
        {
            Validation = SharpGLTF.Validation.ValidationMode.Skip
        });

        var scene = model.DefaultScene;
        if (figure == 0) {
            gl.PushMatrix();
            gl.Rotate(90, 0, 1, 0);
            gl.Rotate(-30, 1, 0, 0);
            gl.Translate(15.0f, 150.0f, 0.0f);
            foreach (var node in scene.VisualChildren)
            {
                DrawNodeBranch(gl, node);
            }
            gl.PopMatrix();
        }
        if (figure == 1)
        {
            foreach (var node in scene.VisualChildren)
            {
                DrawNodeCloud(gl, node);
            }
        }
        if (figure == 2)
        {
            foreach (var node in scene.VisualChildren)
            {
                DrawNodeSun(gl, node);
            }
        }
    }

    private void DrawNodeBranch(OpenGL gl, Node node)
    {
        var mesh = node.Mesh;
        if (mesh != null)
        {
            foreach (var primitive in mesh.Primitives)
            {
                var positions = primitive.GetVertexAccessor("POSITION").AsVector3Array();
                var normals = primitive.GetVertexAccessor("NORMAL")?.AsVector3Array();
                var indices = primitive.IndexAccessor.AsIndicesArray();
                gl.Begin(OpenGL.GL_TRIANGLES);
                gl.Color(0.71f, 0.40f, 0.11f);

                foreach (var index in indices)
                {
                    int idx = (int)index;

                    // Установка нормали, если доступна
                    if (normals != null && idx < normals.Count)
                    {
                        var normal = normals[idx];
                        gl.Normal(normal.X, normal.Y, normal.Z);
                    }

                    var vertex = positions[idx];
                    gl.Vertex(vertex.X, vertex.Y, vertex.Z);
                    //gl.Vertex(800 * vertex.X, 800 * vertex.Y, 800 * vertex.Z); черепаха
                }
                gl.End();
            }
        }

        // Рекурсивный обход потомков
        foreach (var child in node.VisualChildren)
        {
            DrawNodeBranch(gl, child);
        }
    }

    private void DrawNodeCloud(OpenGL gl, Node node)
    {
        var mesh = node.Mesh;
        if (mesh != null)
        {
            foreach (var primitive in mesh.Primitives)
            {
                var positions = primitive.GetVertexAccessor("POSITION").AsVector3Array();
                var normals = primitive.GetVertexAccessor("NORMAL")?.AsVector3Array();
                var indices = primitive.IndexAccessor.AsIndicesArray();
                gl.Begin(OpenGL.GL_TRIANGLES);
                gl.Color(Color.FromName("White"));

                foreach (var index in indices)
                {
                    int idx = (int)index;

                    // Установка нормали, если доступна
                    if (normals != null && idx < normals.Count)
                    {
                        var normal = normals[idx];
                        gl.Normal(normal.X, normal.Y, normal.Z);
                    }

                    var vertex = positions[idx];
                    gl.Vertex(3*vertex.X, 3 * vertex.Y, 3 * vertex.Z);
                    //gl.Vertex(50 * vertex.X, 50 * vertex.Y, 50 * vertex.Z); 
                }
                gl.End();
            }
        }

        // Рекурсивный обход потомков
        foreach (var child in node.VisualChildren)
        {
            DrawNodeCloud(gl, child);
        }
    }
    private void DrawNodeSun(OpenGL gl, Node node)
    {
        var mesh = node.Mesh;
        if (mesh != null)
        {
            foreach (var primitive in mesh.Primitives)
            {
                var positions = primitive.GetVertexAccessor("POSITION").AsVector3Array();
                var normals = primitive.GetVertexAccessor("NORMAL")?.AsVector3Array();
                var indices = primitive.IndexAccessor.AsIndicesArray();
                gl.Begin(OpenGL.GL_TRIANGLES);
                gl.Color(Color.FromName("White"));

                foreach (var index in indices)
                {
                    int idx = (int)index;

                    // Установка нормали, если доступна
                    if (normals != null && idx < normals.Count)
                    {
                        var normal = normals[idx];
                        gl.Normal(normal.X, normal.Y, normal.Z);
                    }

                    var vertex = positions[idx];
                    gl.Vertex(3 * vertex.X, 3 * vertex.Y, 3 * vertex.Z);
                    //gl.Vertex(50 * vertex.X, 50 * vertex.Y, 50 * vertex.Z); 
                }
                gl.End();
            }
        }

        // Рекурсивный обход потомков
        foreach (var child in node.VisualChildren)
        {
            DrawNodeSun(gl, child);
        }
    }
}
