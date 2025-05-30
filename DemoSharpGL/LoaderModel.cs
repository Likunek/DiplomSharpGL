using SharpGL;
using SharpGL.SceneGraph;
using SharpGL.SceneGraph.Quadrics;
using SharpGLTF.Schema2;
using System;
using System.IO;
using System.Linq;
using System.Reflection;
public class LoaderModel
{
    public void LoadModel(OpenGL gl, string filePath)
    {
        if (!File.Exists(filePath))
        {
            throw new FileNotFoundException("���� ������ �� ������.", filePath);
        }

        var stream = File.OpenRead(filePath);
        var model = ModelRoot.ReadGLB(stream, new ReadSettings
        {
            Validation = SharpGLTF.Validation.ValidationMode.Skip
        });

        var scene = model.DefaultScene;
        gl.PushMatrix();
        gl.Rotate(90, 0, 1, 0);
        gl.Rotate(-30, 1, 0, 0);
        gl.Translate(15.0f, 150.0f, 0.0f);
        foreach (var node in scene.VisualChildren)
        {
            DrawNode(gl, node);
        }
        gl.PopMatrix();
    }

    private void DrawNode(OpenGL gl, Node node)
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

                    // ��������� �������, ���� ��������
                    if (normals != null && idx < normals.Count)
                    {
                        var normal = normals[idx];
                        gl.Normal(normal.X, normal.Y, normal.Z);
                    }

                    var vertex = positions[idx];
                    gl.Vertex(vertex.X, vertex.Y, vertex.Z);
                    //gl.Vertex(800 * vertex.X, 800 * vertex.Y, 800 * vertex.Z); ��������
                }
                gl.End();
            }
        }

        // ����������� ����� ��������
        foreach (var child in node.VisualChildren)
        {
            DrawNode(gl, child);
        }
    }
}
