using Godot;
using System;

public class Enemy : KinematicBody2D
{
	public const int SPEED = 200;
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        
    }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
 public override void _Process(float delta)
  {
KinematicBody2D player=(KinematicBody2D)GetNode("/root/Main/Player");
Vector2 direction = player.GetTransform().origin - GetTransform().origin;
direction = direction.Normalized() * SPEED;
MoveAndSlide(direction);

 }
}
