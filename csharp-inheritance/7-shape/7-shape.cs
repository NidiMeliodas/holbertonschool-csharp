/// <summary>
/// Base class Shape with unimplemented Area method.
/// </summary>
public class Shape
{
	/// <summary>
	/// Calculate the area of a shape.
	/// </summary>
	public virtual int Area()
	{
		throw new System.NotImplementedException("Area() is not implemented");
	}
}

/// <summary>
/// Rectangle class derived from Shape, implements Area and ToString.
/// </summary>
public class Rectangle : Shape
{
	private int width;
	private int height;

	/// <summary>
	/// Calculate the area of a rectangle.
	/// </summary>
	public int Width
	{
		get { return width; }
		set
		{
			if (value < 0)
				throw new System.ArgumentException("Width must be greater than or equal to 0");
			width = value;
		}
	}
	/// <summary>
	/// Calculate the height of a rectangle.
	/// </summary>
	public int Height
	{
		get { return height; }
		set
		{
			if (value < 0)
				throw new System.ArgumentException("Height must be greater than or equal to 0");
			height = value;
		}
	}

	/// <summary>
	/// Calculate the area of a rectangle.
	/// </summary>
	public new int Area()
	{
		return width * height;
	}

	/// <summary>
	/// Calculate the area of a rectangle.
	/// </summary>
	public override string ToString()
	{
		return $"[Rectangle] {width} / {height}";
	}
}
