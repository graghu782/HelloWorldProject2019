using Godot;
using System;

public class Player : KinematicBody2D
{
    public const int SPEED = -270;
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        // var arrow = ResourceLoader.Load("res://Sprites/59595-200.png");
	    // Input.SetCustomMouseCursor(arrow);
    }

    //  // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(float delta)
    {
		Vector2 velocity = new Vector2();
      if (Input.IsActionPressed("ui_up"))
      {
          velocity.y = SPEED;
      }
      if (Input.IsActionPressed("ui_down"))
      {
          velocity.y = -SPEED;
      }
      if (Input.IsActionPressed("ui_right"))
      {
          velocity.x = -SPEED;
      }
      if (Input.IsActionPressed("ui_left"))
      {
          velocity.x = SPEED;
      }
	MoveAndSlide(velocity);
    }
}
