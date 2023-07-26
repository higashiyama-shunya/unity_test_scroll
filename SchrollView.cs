using Mosframe;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SchrollView : MonoBehaviour
{
    public static SchrollView I;

    public List<ChatListResult> list;

    [SerializeField]
    public DynamicScrollView scrollView;

    private void Awake()
    {
        I = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 1; i < 4; i++)
        {
            I.list.Add(new ChatListResult() { id = i, chat_room_name = "room" + i, owner_id = i });
        }
        //Debug.Log("listcount:" + list.Count + "\ntotalItemCount" + scrollView.totalItemCount);
        scrollView.totalItemCount = list.Count;
        Debug.Log("listcount:" + list.Count + "\ntotalItemCount" + scrollView.totalItemCount);
    }
}
