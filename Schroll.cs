using Mosframe;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
//using UnityEngine.UIElements;

public class Schroll : MonoBehaviour, IDynamicScrollViewItem
{
    private readonly Color[] colors = new Color[] {
            Color.cyan,
            Color.green,
        };


    public static List<ChatListResult> list = new List<ChatListResult>()
    {
        new ChatListResult(){id=1,chat_room_name="room1",owner_id=1},
        new ChatListResult(){id=2,chat_room_name="room2",owner_id=2},
        new ChatListResult(){id=3,chat_room_name="room3",owner_id=3},
    };

    [SerializeField]
    public DynamicScrollView scrollView;
    [SerializeField]
    public Text title;
    [SerializeField]
    public Image background;


    private void Start()
    {
        /*
        for (int i = 1; i < 4; i++)
        {
            list.Add(new ChatListResult { id = i, chat_room_name = "room" + i, owner_id = i });
            //Debug.Log(list[i - 1].chat_room_name);
        }
        */
        //Debug.Log("listcount:" + list.Count + "\ntotalItemCount" + scrollView.totalItemCount);
        scrollView.totalItemCount = list.Count;
        Debug.Log("listcount:" + list.Count + "\ntotalItemCount" + scrollView.totalItemCount);

    }

    public void onUpdateItem(int index)
    {
        Debug.Log("onUpdateItemäJén:" + index);
        Debug.Log("listcount:" + list.Count + "\n index:" + index);
        if (list.Count > index)
        {
            var data = list[index];

            background.color = this.colors[Mathf.Abs(index) % colors.Length];

            title.text = string.Format("{0}:{1}", data.id, data.chat_room_name);
        }
        Debug.Log("onUpdateItemèIóπ:" + index);
    }

}
