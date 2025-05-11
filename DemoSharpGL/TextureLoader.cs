using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using SharpGL;

namespace DemoSharpGL
{
	public static class TextureLoader
	{
		public static uint LoadTexture(OpenGL gl, string path)
		{
			if (!File.Exists(path))
				throw new FileNotFoundException($"Texture file not found: {path}");

			// Load original bitmap
			using (var original = new Bitmap(path))
			{
				// Create a non-premultiplied RGB bitmap (no alpha)
				using (var bitmap = new Bitmap(original.Width, original.Height, PixelFormat.Format24bppRgb))
				using (var g = Graphics.FromImage(bitmap))
				{
					// Draw and flip vertically for OpenGL
					g.DrawImage(original, new Rectangle(0, 0, bitmap.Width, bitmap.Height),
						0, original.Height - 1, bitmap.Width, -bitmap.Height, GraphicsUnit.Pixel);

					// Lock bits to get pixel data (BGR order)
					var data = bitmap.LockBits(
						new Rectangle(0, 0, bitmap.Width, bitmap.Height),
						ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);

					// Generate texture ID
					gl.PixelStore(OpenGL.GL_UNPACK_ALIGNMENT, 1);
					uint[] textureIds = new uint[1];
					gl.GenTextures(1, textureIds);
					uint textureId = textureIds[0];

					// Bind texture
					gl.BindTexture(OpenGL.GL_TEXTURE_2D, textureId);

					// Upload texture data
					gl.TexImage2D(OpenGL.GL_TEXTURE_2D, 0, (int)OpenGL.GL_RGB,
						bitmap.Width, bitmap.Height, 0,
						OpenGL.GL_BGR, OpenGL.GL_UNSIGNED_BYTE, data.Scan0);

					// Set texture filtering to nearest
					gl.TexParameter(OpenGL.GL_TEXTURE_2D, OpenGL.GL_TEXTURE_MIN_FILTER, OpenGL.GL_NEAREST);
					gl.TexParameter(OpenGL.GL_TEXTURE_2D, OpenGL.GL_TEXTURE_MAG_FILTER, OpenGL.GL_NEAREST);

					// Set wrapping modes
					gl.TexParameter(OpenGL.GL_TEXTURE_2D, OpenGL.GL_TEXTURE_WRAP_S, OpenGL.GL_REPEAT);
					gl.TexParameter(OpenGL.GL_TEXTURE_2D, OpenGL.GL_TEXTURE_WRAP_T, OpenGL.GL_REPEAT);

					// Ensure texture replaces underlying color
					gl.TexEnv(OpenGL.GL_TEXTURE_ENV, OpenGL.GL_TEXTURE_ENV_MODE, OpenGL.GL_REPLACE);

					// Cleanup
					bitmap.UnlockBits(data);
					gl.BindTexture(OpenGL.GL_TEXTURE_2D, 0);

					return textureId;
				}
			}
		}
	}
}
