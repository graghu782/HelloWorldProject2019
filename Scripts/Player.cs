using Godot;
using System;

public class Player : Area2D
{
    public const int SPEED = -270;
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        var arrow = ResourceLoader.Load("res://arrow.png");
        Input.SetCustomMouseCursor(arrow);
    }

    //  // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(float delta)
    {
      if (Input.IsActionPressed("ui_up"))
      {
          MoveLocalY(SPEED * delta);
      }
      if (Input.IsActionPressed("ui_down"))
      {
          MoveLocalY(-SPEED * delta);
      }
      if (Input.IsActionPressed("ui_right"))
      {
          MoveLocalX(-SPEED * delta);
      }
      if (Input.IsActionPressed("ui_left"))
      {
          MoveLocalX(SPEED * delta);
      }
    }
}
