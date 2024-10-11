using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckScript : MonoBehaviour
{
    public List<string> deck = new();
    // Start is called before the first frame update
    void Start()
    {
        var suits = new string[] { "B", "C", "E", "O" };
        var ranks = new string[] { "1", "2", "3", "4", "5", "6", "7", "T", "O", "D"};
        foreach (var suit in suits)
        {
            foreach (var rank in ranks)
            {
                deck.Add($"{rank}{suit}");
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        var card = "1C";
        Debug.Log($"TU CARTA ES {card}");
    }
}
