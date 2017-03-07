using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour {



	[SerializeField]
	private GameObject tilePrefab;

	[SerializeField]
	private Unit player1;

	[SerializeField]
	private Unit player2;

	public Tile[,] tiles;

	[SerializeField]
	private int SizeX;
	[SerializeField]
	private int SizeY;

	void Awake()
	{
	
		tiles = new Tile[SizeX, SizeY]; 

		for (int x = 0; x < SizeX; x++) 
		{
		
			for (int y = 0; y < SizeY; y++) 
			{
			
				GameObject tempCube = Instantiate (tilePrefab, new Vector3 (x, y, 0f), Quaternion.identity);
				tiles [x, y] = tempCube.GetComponent<Tile> ();
			
			}

		}
		InitUnits ();

	}

	void Start(){
	

	
	}

	public void InitUnits ()
	{
		
		tiles [0, (SizeY-1)].UnitOn = player1;
		player1.Movimiento (0, SizeY-1);

		tiles [(SizeX - 1), (SizeY - 1)].UnitOn = player2;
		player2.Movimiento ((SizeX - 1), (SizeY - 1));
	}

}
