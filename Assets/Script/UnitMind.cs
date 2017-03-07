using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitMind : MonoBehaviour {

	[SerializeField]
	private Grid myGrid;


	public void UpdateUnit(Unit unit)
	{
		int move;
		if (unit.MyTeam == Equipo.A) {
			move = 1;
		} else {
			move = -1;
		}

		int moveX = unit.x + move;
		if (myGrid.tiles [moveX, unit.y].UnitOn == null) {
			myGrid.tiles [unit.x, unit.y].UnitOn = null;
			myGrid.tiles [moveX , unit.y].UnitOn = unit;
			unit.Movimiento (moveX, unit.y);

		} else {
			unit.Ataque (myGrid.tiles [(unit.x + move), unit.y].UnitOn);
		}

	}

}
