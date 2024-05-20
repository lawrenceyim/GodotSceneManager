using Godot;
using System;

public partial class Player : CharacterBody2D { 
	[Export] private float moveSpeed = 240f;
	
	public override void _Process(double delta)
	{
		if (Input.IsActionPressed("MoveRight")) {
			Translate(new Vector2(1, 0) * (float) delta * moveSpeed);
		}
	}
}
