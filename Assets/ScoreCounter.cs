using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreCounter : MonoBehaviour {
	//スコアに初期値を代入する
	private int score = 0;
	//スコアを表示するテキスト
	public Text scoreText;

	// Use this for initialization
	void Start () {
		//シーン中のスコアテキストを表示する
		scoreText = GameObject.Find ("ScoreText").GetComponent<Text> ();
		//変数スコアを初期化する
		int score = 0;
		//
		scoreText.text = "score:" + score;
	}
	//衝突時に呼ばれる関数
	public void OnCollisionEnter(Collision collision) {
		//タグによってスコアを変える
		if (collision.gameObject.tag == "SmallStarTag") {
			score += 10;
		} else if (collision.gameObject.tag == "SmallCloudTag") {
			score += 30;
		} else if (collision.gameObject.tag == "LargeStarTag") {
			score += 20;
		} else if (collision.gameObject.tag == "LargeCloudTag") {
			score += 40;
		}
		//スコアに加算する
			scoreText.text = "score:" + score.ToString ();
		


			}
}
