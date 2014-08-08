public class HelloScript : MonoBehaviour
{
 public int num = 1000;
 void Start() {
  Debug.Log(num);
  Debug.Log(num+500);
  Debug.Log("テスト");
  Debug.Log(GetComponent<HelloScript>().num);
  Debug.Log(this.num);
 }
 void Update() {
 }
}
