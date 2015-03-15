using UnityEngine;
using System.Collections;

public class SakuraCreater : MonoBehaviour {
	
	public GameObject flower;
	public ParticleSystem sakuraSakuEffect;
	public ParticleSystem sakuraTiruEffect;
	// Use this for initialization
	void Start () {
		sakuraSakuEffect.Stop();
		sakuraTiruEffect.Stop();
	}
	
	/// <summary>
	/// BoxColliderのIsTriggerをONにしている際に、
	/// オブジェクトが範囲に入った際に呼ばれるイベント
	/// </summary>
	/// <param name="col">Col.</param>
	void OnTriggerEnter(Collider col){
		
		for(int i = 0 ; i < 5 ; i++){
			createSakura();
		}
		
		sakuraSakuEffect.Play();
		sakuraTiruEffect.Play();
	}
	
	/// <summary>
	/// 桜の花を一つ作成します。
	/// </summary>
	/// <returns>The sakura.</returns>
	private void createSakura(){
		Vector3 pos = this.gameObject.transform.position;
		
		float x = Random.Range(-1.0f , 1.0f);
		float y = Random.Range(1.0f , 2.0f);
		float z = Random.Range(-1.0f , 1.0f);
		
		pos.x += x;
		pos.y += y;
		pos.z += z;
		
		GameObject obj = Instantiate(flower , pos , Quaternion.identity) as GameObject;
		obj.transform.SetParent(this.gameObject.transform);
	}
}
