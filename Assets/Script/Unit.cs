using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour {

	public int x;
	public int y;

	[SerializeField]
	private int vida;
	[SerializeField]
	private int ataque;
	[SerializeField]
	private int defensa;
	[SerializeField]
	private Equipo myTeam;
	[SerializeField]
	private UnitMind mind;

	private int movement;
	// Use this for initialization
	void Start () {
		transform.position = new Vector3 (x, y, -0.75f);

	}

	public void Ataque(Unit otherUnit){
		if (otherUnit.MyTeam != myTeam) {
			otherUnit.Daño (ataque);
		}
	}

	public void Movimiento(int tempX, int tempY){

		transform.position = new Vector3 (tempX, tempY, -0.75f);
		x = tempX;
		y = tempY;

	}

	public void Daño(int enemyAttack){
		vida += defensa - enemyAttack;
		if (vida <= 0)
			gameObject.SetActive (false);
	}

	public void StayThere(){
		Debug.Log("Im still");
	}

	public void UpdateState (){
	
		mind.UpdateUnit (this);

	}

	private void AsignarEquipo(){
		switch (myTeam) 
		{
		case Equipo.A:
			movement = 1;
			break;
		case Equipo.B:
			movement = -1;
			break;
		default:
			Debug.Log("Team no assigned");
			break;
		}
	}
		

	public Equipo MyTeam {
		get {
			return myTeam;
		}
	}

	public int Health {
		get {
			return vida;
		}
		set {
			vida = value;
		}
	}
}
