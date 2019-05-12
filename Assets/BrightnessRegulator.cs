﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrightnessRegulator: MonoBehaviour {
	//materialを入れる
	Material myMaterial;
	//Emissonの最小値
	private float minEmission=0.3f;

	//Emissonの強度
	private float magEmission=2.0f;
	//角度
	private int degree=0;
	//発酵速度
	private int speed = 10;
	//ターゲットのdefault色
	Color defaultColor = Color.white;



	// Use this for initialization
	void Start () {
		//ターゲットによって光らせる色を決める

		if (tag == "SmallStarTag") {
			this.defaultColor = Color.white;
		} else if (tag == "LargeStarTag") {
			
			this.defaultColor = Color.yellow;
		}
		//オブジェクトにアタッチしているマテリアルを所得
		this.myMaterial = GetComponent<Renderer> ().material;
		//オブジェクトの最初の色を設定
		myMaterial.SetColor ("_EmissionColor", this.defaultColor * minEmission);
	

	}
	
	// Update is called once per frame
	void Update () {
		if (this.degree>=0) {
			//光らせる強度を計算する
			Color emissionColor = this.defaultColor * (this.minEmission +Mathf.Sin (this.degree * Mathf.Deg2Rad)*this.magEmission);
			//エミッションに色を設定する
			myMaterial.SetColor ("_EmissionColor",emissionColor);
			//現在の角度を小さくする
			this.degree -= this.speed;

	}
}
	void OnCollisionEnter(Collision other){
	//角度を１８０に設定
	this.degree = 180;
	}


}



