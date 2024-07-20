using Godot;
using System;

public partial class ShipG : Sprite2D
{
	private float _speed = 0.05F;
	private float angle = 0;
	private double radius;
	private Vector2 center;
	
	[Export]
	public Vector2 Center { 
	get => center;
	set {
		center = value;
		radius = Math.Sqrt(Math.Pow((Position - center)[0], 2) + Math.Pow((Position - center)[1], 2));
		} 
	}
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		Center = new Vector2(300, 300);
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{		
		LookAt(center);
		
		angle += _speed;
		
		Position = center + Vector2.Up.Rotated(angle) * (float)radius;
	}
}
