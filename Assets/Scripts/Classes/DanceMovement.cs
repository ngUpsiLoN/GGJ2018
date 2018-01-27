﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class DanceMovement {

	public	string		dance_name;
[Tooltip("Attention : Utiliser la syntaxe exacte de Unity pour définir l'input !")]
	public	string		dance_input;
[Space(10)]
	public	float		dance_power;
	public	float		dance_speed;
	public	float		dance_range;
[Space(10)]
	public	Sprite		dance_sprite;
	public	Sprite		dance_uiIndicator;
	public	AudioClip	dance_sound;		

}
