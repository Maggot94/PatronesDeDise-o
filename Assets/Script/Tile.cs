using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour {

	private Vector2 TileP;


	private Unit On;



	// Use this for initialization
	void Start () {
		
	}

	public void SetTilePosition(int tempX, int tempY)
	{
		TileP = new Vector2 (tempX, tempY);
	}

	public Vector2 GetTilePosition()
	{
		return TileP;
	}

	public Unit UnitOn {
		get {
			return On;
		}
		set {
			On = value;
		}
	}
}
