using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[SerializeField]
public class EnablerCmtsDB
{
    public string welcome;
    public string tch_video;
    public string brain_gym_hook_ups;
    public string sound_games;
    public string word_building;
    public string auditory_activity;
    public string brain_gym_tree_pose;
    public string visual_activity;
    public string compound_words;
    public string syntax_activity;
    public string reading_passage;
    public string goodbye;

    public EnablerCmtsDB()
    {
        welcome = Main_Blended.OBJ_main_blended.enablerComments[0];
        tch_video = Main_Blended.OBJ_main_blended.enablerComments[1];
        brain_gym_hook_ups = Main_Blended.OBJ_main_blended.enablerComments[2];
        sound_games = Main_Blended.OBJ_main_blended.enablerComments[3];
        word_building = Main_Blended.OBJ_main_blended.enablerComments[4];
        auditory_activity = Main_Blended.OBJ_main_blended.enablerComments[5];
        brain_gym_tree_pose = Main_Blended.OBJ_main_blended.enablerComments[6];
        visual_activity = Main_Blended.OBJ_main_blended.enablerComments[7];
        compound_words = Main_Blended.OBJ_main_blended.enablerComments[8];
        syntax_activity = Main_Blended.OBJ_main_blended.enablerComments[9];
        reading_passage = Main_Blended.OBJ_main_blended.enablerComments[10];
        goodbye = Main_Blended.OBJ_main_blended.enablerComments[11];
    }
}