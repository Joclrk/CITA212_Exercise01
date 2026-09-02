using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    //Similar to main variable location for a object in GameMaker
    [SerializeField] float MoveSpeed = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       float x = Input.GetAxis("Horizontal"); //Get + or - 1 movement for X plane ie left and right
       float y = Input.GetAxis("Vertical"); //Get + or - 1 movement FOr Y plane ie up and down
       Vector3 Move = new Vector3(x, y, 0f);
       transform.Translate(Move * MoveSpeed*Time.deltaTime);
    }
}
