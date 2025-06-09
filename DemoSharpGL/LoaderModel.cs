using SharpGL;
using SharpGLTF.Schema2;
using System.IO;


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
            DrawNode(gl, child);
        }
    }
}
