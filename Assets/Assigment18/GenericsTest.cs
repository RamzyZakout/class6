using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assigment18{
public class GenericsTest : MonoBehaviour
{
    void Start(){
    GameContainer<string> gameContainer = new GameContainer<string>();
    GameUtils gameUtils=new GameUtils();
    gameContainer.SetItem("Healing Potion");
    string save =gameContainer.GetItem();
    Debug.Log(save);
    string des=GameUtils.DescribeItem(save);
     Debug.Log(des);
}
}
}