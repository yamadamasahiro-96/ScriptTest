using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss {        
	private int hp = 100;          // 体力
	private int power = 25; // 攻撃力
	private int mp = 53;

	// 攻撃用の関数
	public void Attack() { 
		Debug.Log( this.power + "のダメージを与えた" );
	}

	// 防御用の関数
	public  void Defence(int damage) { 
		Debug.Log( damage+"のダメージを受けた" );
		// 残りhpを減らす
		this.hp -= damage;
	}

	public  void Magic(int num){
		for (int i = 1; i<=num ; i ++) {
			if (mp >= i*5) {
				Debug.Log ("魔法攻撃をした。残りMPは" + (mp - (5*i)));
			} else {
				Debug.Log ("MPが足りないため魔法が使えない。");
			}
		}
	}
}

public class Test : MonoBehaviour {

	void Start () {
		// Bossクラスの変数を宣言してインスタンスを代入
		Boss lastboss = new Boss ();

		// 攻撃用の関数を呼び出す
		//lastboss.Attack();
		// 防御用の関数を呼び出す
		//lastboss.Defence(3);

		//()内に魔法回数を入力
		lastboss.Magic (11);

		//Boss midboss = new Boss ();

		//midboss.Attack();

		//midboss.Defence(1);
	
	}

	// Update is called once per frame
	void Update () {

	}
}
