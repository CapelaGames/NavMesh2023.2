using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HowToFunction : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int MyAnswer = AddTwoNumbers(4,5);
    }

    int AddTwoNumbers(int x, int y)
    {
        int answer = x + y;

        return answer;
    }
}
