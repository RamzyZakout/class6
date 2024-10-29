using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rrr : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        int counter = 0;
        while (counter < 20)
        {
            int x = Random.Range(1, 21);
            Debug.Log(x);
            counter++;
            if (x == 5)
            {
                break;
                Debug.Log("kabssa");



            }


        } while (counter < 20)
        {
            int v = Random.Range(1, 21);
            Debug.Log(v); counter++;
            if (v == 5)
            {
                Debug.Log(v);
                continue;
                Debug.Log("kabssa");
            }
        }
        string[] word = { "cat", "dog", "car", "pizza", "hat", "fish", "tree", "monkey", "ball", "bird" };
        int count = 0;
        string jomla = "";

        // Loop to build a sentence with 7 random words
        while (count < 7)
        {
            // Generate a random index within the array bounds
            int randomIndex = Random.Range(0, word.Length);
            string randomWord = word[randomIndex];

            // Add the random word to the sentence
            jomla += randomWord + " ";
            count++;
        }

        // Print the full sentence
        Debug.Log("Here is a funny sentence: " + jomla.Trim());
        // Update is called once per frame
        void Update()
        {

        }

    }
}
