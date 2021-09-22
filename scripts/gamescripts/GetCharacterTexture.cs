using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GetCharacterTexture : MonoBehaviour
{
    public Text Textfield1;
    public Text Textfield2;
    public Text Textfield3;
    public Text Textfield4;
    bool value=false;
    private int i = 0 ; 
    private int j = 0 ; 

    public string[] items;
    public string[] itemsanswers;
    // Start is called before the first frame update
    IEnumerator Start()
    {
        WWW itemsData = new WWW("http://localhost/unity/db2.php");
        WWW itemsData2 = new WWW("http://localhost/unity/db3.php");
        yield return itemsData;
        yield return itemsData2;
        string itemsDataString = itemsData.text;
        string itemsDataString2 = itemsData2.text;
       // print (itemsDataString);
        items = itemsDataString.Split(';');
        itemsanswers = itemsDataString2.Split(';');
        
        /*Textfield1.text = GetDataValue(items[0],"text:");
        Textfield2.text = GetDataValue(items[1],"text:");
        Textfield3.text = GetDataValue(items[2],"text:");
        Textfield4.text = GetDataValue(items[3],"text:");*/

        Textfield1.text = items[i];
        Textfield2.text = itemsanswers[j];
        Textfield3.text = itemsanswers [j+1];
        Textfield4.text = itemsanswers [j+2];

        
    }
   /* string GetDataValue(string data , string index)
    {
        string value = data.Substring(data.IndexOf(index)+index.Length);
        return value;
    }*/
    public void onButtonClicked()
    {   
        Textfield1.text = items[i];
        Textfield2.text = itemsanswers[j];
        Textfield3.text = itemsanswers [j+1];
        Textfield4.text = itemsanswers [j+2];
        i++; 
        j=j+3;

    }
}



  