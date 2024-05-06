using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    public List<Quest> quests = new List<Quest>();

    public void AcceptQuest(Quest quest)
    {
        quests.Add(quest);
        Debug.Log("Quest accepted: " + quest.questName);
    }

    public void CompleteQuest(Quest quest)
    {
        quests.Remove(quest);
        Debug.Log("Quest completed: " + quest.questName);
    }
}
