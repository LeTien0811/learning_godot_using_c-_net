using Godot;
using System;

public partial class Coin1 : Area2D
{ 
	public override void _Ready() {
		GD.Print("Hello world!");
	}
	
	private void _on_body_entered(PhysicsBody2D body) {
		GD.Print("+1 coin");
		QueueFree();
	}
}
