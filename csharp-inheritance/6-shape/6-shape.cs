/// <summary>
/// Represents a geometric shape.
/// </summary>
public class Shape
{
	/// <summary>
	/// Calculates the area of the shape.
	/// </summary>
	/// <returns>The area as an integer.</returns>
	/// <exception cref="System.NotImplementedException">Thrown when the method is not overridden.</exception>
	public virtual int Area()
	{
		throw new System.NotImplementedException("Area() is not implemented");
	}
}

/// <summary>
/// Represents a rectangle, derived from Shape.
/// </summary>
public class Rectangle : Shape
{
	private int width;
	private int height;

	/// <summary>
	/// Gets or sets the width of the rectangle.
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
	/// Gets or sets the height of the rectangle.
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
}
