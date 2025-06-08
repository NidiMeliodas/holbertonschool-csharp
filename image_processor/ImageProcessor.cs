using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Threading.Tasks;

public class ImageProcessor
{
	public static void Inverse(string[] filenames)
	{
		Parallel.ForEach(filenames, filename =>
		{
			try
			{
				using (Bitmap original = new Bitmap(filename))
				{
					int width = original.Width;
					int height = original.Height;

					// Invert colors pixel by pixel
					for (int y = 0; y < height; y++)
					{
						for (int x = 0; x < width; x++)
						{
							Color pixel = original.GetPixel(x, y);
							Color inverted = Color.FromArgb(255 - pixel.R, 255 - pixel.G, 255 - pixel.B);
							original.SetPixel(x, y, inverted);
						}
					}

					string ext = Path.GetExtension(filename);
					string nameWithoutExt = Path.GetFileNameWithoutExtension(filename);
					string newFileName = $"{nameWithoutExt}_inverse{ext}";
					string outputPath = Path.Combine(Directory.GetCurrentDirectory(), newFileName);

					ImageFormat format = GetImageFormat(ext);
					original.Save(outputPath, format);
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Error processing {filename}: {ex.Message}");
			}
		});
	}

	private static ImageFormat GetImageFormat(string extension)
	{
		switch (extension.ToLower())
		{
			case ".bmp": return ImageFormat.Bmp;
			case ".gif": return ImageFormat.Gif;
			case ".jpg":
			case ".jpeg": return ImageFormat.Jpeg;
			case ".png": return ImageFormat.Png;
			case ".tiff": return ImageFormat.Tiff;
			default: return ImageFormat.Png;
		}
	}
}
