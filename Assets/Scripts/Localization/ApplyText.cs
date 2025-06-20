﻿using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ApplyText : MonoBehaviour, ILocalizeObject
{
    [SerializeField] private TMP_Text loading;
    [SerializeField] private TMP_Text button_start;
    [SerializeField] private TMP_Text title_choose_a_stage;
    [SerializeField] private TMP_Text warning_not_unlocked;
    [SerializeField] private TMP_Text warning_coming_soon;
    [SerializeField] private TMP_Text title_stage;
    [SerializeField] private TMP_Text guide_game_rule;
    [SerializeField] private TMP_Text title_rider_information;
    [SerializeField] private TMP_Text hp_hero_1001;
    [SerializeField] private TMP_Text hp_hero_1002;
    [SerializeField] private TMP_Text skill_info_hero_stage;
    [SerializeField] private TMP_Text skill_info_hero_onstage;
    [SerializeField] private TMP_Text[] button_skill;
    [SerializeField] private TMP_Text button_replay;
    [SerializeField] private TMP_Text title_setting;
    [SerializeField] private TMP_Text setting_sound;
    [SerializeField] private TMP_Text setting_sound_on;
    [SerializeField] private TMP_Text setting_sound_off;
    [SerializeField] private TMP_Text setting_language;
    [SerializeField] private TMP_Text setting_language_1;
    [SerializeField] private TMP_Text setting_language_2;
    [SerializeField] private TMP_Text setting_privacy_policy;
    [SerializeField] private TMP_Text[] button_view;
    [SerializeField] private TMP_Text setting_term_of_condition;
    [SerializeField] private TMP_Text setting_credit;
    [SerializeField] private TMP_Text setting_credit_popup1;
    [SerializeField] private TMP_Text setting_credit_popup2;
    [SerializeField] private TMP_Text[] title_notification;
    [SerializeField] private TMP_Text popup_detail_quit;
    [SerializeField] private TMP_Text popup_detail_language_change;
    [SerializeField] private TMP_Text popup_detail_language_change_stage;
    [SerializeField] private TMP_Text popup_detail_credit;
    [SerializeField] private TMP_Text popup_detail_credit2;
    [SerializeField] private TMP_Text login_popup_my_account_game;
    [SerializeField] private TMP_Text[] button_yes;
    [SerializeField] private TMP_Text[] button_no;
    [SerializeField] private TMP_Text[] button_ok;
    [SerializeField] private TMP_Text skill_info_hero_lib;
      [SerializeField] private TMP_Text title_setting_stage;
    [SerializeField] private TMP_Text setting_sound_stage, setting_sound_on_stage,
 setting_sound_off_stage,
setting_language_stage,
 setting_language_1_stage,
 setting_language_2_stage,
 setting_privacy_policy_stage,
setting_term_of_condition_stage,
 setting_credit_stage
, login_popup_my_account_stage, title_rider_information_stage;



    [Header("Object")]
    [SerializeField] private TMP_Text objectName;
    [SerializeField] private TMP_Text objectStory;
    [SerializeField] private TMP_Text objectBattle;
    [SerializeField] private TMP_Text libraryObjectStory;
    [SerializeField] private TMP_Text libraryObjectBattleInfor;
    [Header("Rider")]
    [SerializeField] private TMP_Text riderNameLib;
    [SerializeField] private TMP_Text riderStory;
    [SerializeField] private TMP_Text riderWeight;
    [SerializeField] private TMP_Text riderHeight;
    [SerializeField] private TMP_Text riderPunch;
    [SerializeField] private TMP_Text riderKick;
    [Header("Lib")]
    [SerializeField] private TMP_Text libraryFeatureName; 
    [SerializeField] private TMP_Text libraryButtonStory;
    [SerializeField] private TMP_Text libraryButtonTutorial;
    [SerializeField] private TMP_Text libraryRiderSectionTitle;
    [SerializeField] private TMP_Text libraryObjectSectionTitle;
    [SerializeField] private TMP_Text libraryStorySectionTitle;
    [SerializeField] private TMP_Text libraryRiderTitle;
    [SerializeField] private TMP_Text libraryObjectTitle;
    [SerializeField] private TMP_Text libraryRiderAmount;
    [SerializeField] private TMP_Text libraryObjectAmount;
    [SerializeField] private TMP_Text libraryStoryAmount;
    [SerializeField] private TMP_Text libraryRiderStory;
    [SerializeField] private TMP_Text libraryRiderBattleInfor;
    [SerializeField] private TMP_Text libraryRiderForm;
    [SerializeField] private TMP_Text libraryRiderWeight;
    [SerializeField] private TMP_Text libraryRiderHeight;
    [SerializeField] private TMP_Text libraryRiderPunchPower;
    [SerializeField] private TMP_Text libraryRiderKickPower;
    [Header("Toturial")]
    [SerializeField] private TMP_Text tutorial_how_to_win;
    [SerializeField] private TMP_Text tutorial_how_to_win_explain;
    [SerializeField] private TMP_Text tutorial_how_to_move;
    [SerializeField] private TMP_Text tutorial_how_to_move_explain;
    [SerializeField] private TMP_Text tutorial_use_skill;
    [SerializeField] private TMP_Text tutorial_use_skill_explain;
    [SerializeField] private TMP_Text tutorial_replay;
    [SerializeField] private TMP_Text tutorial_replay_explain;
    [Header("Shop")]
    [SerializeField] private TMP_Text shop_title;
    [SerializeField] private TMP_Text shop_daily_pack_title;
    //[SerializeField] private TMP_Text shop_daily_pack_title_receive;
    [SerializeField] private TMP_Text shop_daily_pack_tag_free;
    [SerializeField] private TMP_Text[] button_exchange;
    [SerializeField] private TMP_Text shop_help_money_1_title;
    [SerializeField] private TMP_Text shop_help_money_1_content;
    [SerializeField] private TMP_Text shop_help_hot_deal_title;
    [SerializeField] private TMP_Text shop_help_hot_deal_content;
    [SerializeField] private TMP_Text shop_help_rider_shop_title;
    [SerializeField] private TMP_Text shop_help_rider_shop_content;
    [SerializeField] private TMP_Text button_shop_hot_deal;
    [SerializeField] private TMP_Text button_shop_rider;
  //  [SerializeField] private TMP_Text shop_owned_rider;
    [SerializeField] private TMP_Text shop_noti_buy_rider;
    [SerializeField] private TMP_Text shop_congratulation;
    [SerializeField] private TMP_Text shop_congratulation_rider_get;
    [SerializeField] private TMP_Text shop_sort_default;
    [SerializeField] private TMP_Text shop_sort_day;
    [SerializeField] private TMP_Text shop_sort_price;

    [SerializeField] private TMP_Text libraryRiderStoryShop;
    [SerializeField] private TMP_Text libraryRiderBattleInforShop;
    [SerializeField] private TMP_Text libraryRiderFormShop;
    [SerializeField] private TMP_Text libraryRiderWeightShop;
    [SerializeField] private TMP_Text libraryRiderHeightShop;
    [SerializeField] private TMP_Text libraryRiderPunchPowerShop;
    [SerializeField] private TMP_Text libraryRiderKickPowerShop;
    [SerializeField] private TMP_Text riderSkillShop;
    [SerializeField] private TMP_Text riderNameLibShop;
    [SerializeField] private TMP_Text riderStoryShop;
    [SerializeField] private TMP_Text riderWeightShop;
    [SerializeField] private TMP_Text riderHeightShop;
    [SerializeField] private TMP_Text riderPunchShop;
    [SerializeField] private TMP_Text riderKickShop;
    [Header("Login")]
    [SerializeField] private TMP_Text button_return_player;
    [SerializeField] private TMP_Text[] button_new_player;
    [SerializeField] private TMP_Text login_popup_title;
    [SerializeField] private TMP_Text[] login_popup_email;
    [SerializeField] private TMP_Text[] login_popup_password;
    [SerializeField] private Text login_popup_email_guide_1;
    [SerializeField] private TMP_Text login_popup_display_name, login_popup_forget_password,
        button_login, login_popup_wrong_password
        , button_register, login_popup_register_success, login_popup_my_account, register_new_account, forget_password_title,
        forget_password_content, button_reset,  button_logout,my_account, logout_btn1, logout_btn2;
    [SerializeField] private Text login_popup_password_guide_1, login_popup_email_guide_2, login_popup_password_guide_2,
        login_popup_display_name_guide, login_popup_email_guide_3;
    [Header("Story")]
    [SerializeField] private TMP_Text titleStory;
    [SerializeField] private TMP_Text contentStory;
    [Header("Quest")]
    [SerializeField] private TMP_Text quest_daily_quest_title;
    [SerializeField] private TMP_Text button_complete_all, button_complete_all_2,
         button_achievement, quest_reset_time, quest_daily_quest_all_completed,
        quest_help_daily_quest_title, quest_help_daily_quest_content, quest_help_achivement_title, quest_help_achivement_content,
        quest_achievement_title, shop_help_quest_stamp_title, shop_help_quest_stamp_content
        ;
    [Header("New")]
    [SerializeField] private TMP_Text new_title;
     [SerializeField] private TMP_Text patch_note_infor;
    [Header("Update")]
    [SerializeField] private TMP_Text button_update;
    [SerializeField] private TMP_Text popup_update_title,popup_update_content;
    public static ApplyText instance;
    public  TextLocalizer textLocalizer;
    [Header("Upgrade")]
    [SerializeField] private TMP_Text heroSkill;
    private void Awake() => instance = this;
    //private void Start()
    //{
    //    UpdateLibInfo();
    //    UpdateToturialInfo();
    //}
    //public void LoadLangue()
    //{
    //    UpdateLibInfo();
    //    UpdateToturialInfo();

    //}

    public void ApplyTxt(ref Dictionary<string, string> localizedRichText, ref Dictionary<string, string> localizedTexts)
    {
        throw new System.NotImplementedException();
    }

    public void ApplyFont(ref Dictionary<string, TMP_FontAsset> localizedFonts)
    {
        throw new System.NotImplementedException();
    }
    //    private void SetInfo(string key, TMP_Text targetText, Dictionary<string, string> richText, Dictionary<string, string> plainText)
    //    {
    //        if (richText.ContainsKey(key) && plainText.ContainsKey(key))
    //            targetText.SetText(plainText[key]);
    //        else
    //            targetText.SetText("Thông tin kỹ năng không khả dụng.");
    //    }
    //    public void UpdateLibInfo()
    //    {
    //        var richText = LocalizationManager.instance.GetLocalizedRichText();
    //        var plainText = LocalizationManager.instance.GetLocalizedTexts();
    //        SetInfo("library_feature_name", libraryFeatureName, richText, plainText);
    //        SetInfo("library_button_tutorial", libraryButtonTutorial, richText, plainText);
    //        SetInfo("library_rider_section_title", libraryRiderSectionTitle, richText, plainText);
    //        SetInfo("library_object_section_title", libraryObjectSectionTitle, richText, plainText);
    //        SetInfo("library_rider_section_title", libraryRiderTitle, richText, plainText);
    //        SetInfo("library_object_section_title", libraryObjectTitle, richText, plainText);
    //        SetInfo("library_rider_amount", libraryRiderAmount, richText, plainText );
    //        SetInfo("library_object_amount", libraryObjectAmount, richText, plainText);
    //        SetInfo("library_rider_story", libraryRiderStory, richText, plainText);
    //        SetInfo("library_rider_battle infor", libraryRiderBattleInfor, richText, plainText);
    //        SetInfo("library_rider_story", libraryObjectStory, richText, plainText);
    //        SetInfo("library_rider_battle infor", libraryRiderBattleInfor, richText, plainText);
    //        SetInfo("library_rider_form", libraryRiderForm, richText, plainText);
    //        SetInfo("library_rider_weight", libraryRiderWeight, richText, plainText);
    //        SetInfo("library_rider_height", libraryRiderHeight, richText, plainText);
    //        SetInfo("library_rider_punch_power", libraryRiderPunchPower, richText, plainText);
    //        SetInfo("library_rider_kick_power", libraryRiderKickPower, richText, plainText);
    //        SetInfo("library_object_amount", libraryStoryAmount, richText, plainText);
    //        SetInfo("library_rider_story", libraryObjectStory, richText, plainText);
    //        SetInfo("library_rider_battle infor", libraryRiderBattleInforShop, richText, plainText);
    //        SetInfo("library_rider_form", libraryRiderFormShop, richText, plainText);
    //        SetInfo("library_rider_weight", libraryRiderWeightShop, richText, plainText);
    //        SetInfo("library_rider_height", libraryRiderHeightShop, richText, plainText);
    //        SetInfo("library_rider_punch_power", libraryRiderPunchPowerShop, richText, plainText);
    //        SetInfo("library_rider_kick_power", libraryRiderKickPowerShop, richText, plainText);
    //        SetInfo("library_rider_story", libraryButtonStory, richText, plainText);
    //        SetInfo("library_rider_story", libraryStorySectionTitle, richText, plainText);


    //    }
    //    public void UpdateToturialInfo()
    //    {
    //        var richText = LocalizationManager.instance.GetLocalizedRichText();
    //        var plainText = LocalizationManager.instance.GetLocalizedTexts();
    //        SetInfo("tutorial_how_to_win", tutorial_how_to_win, richText, plainText);
    //        SetInfo("tutorial_how_to_win_explain", tutorial_how_to_win_explain, richText, plainText);
    //        SetInfo("tutorial_how_to_move", tutorial_how_to_move, richText, plainText);
    //        SetInfo("tutorial_how_to_move_explain", tutorial_how_to_move_explain, richText, plainText);
    //        SetInfo("tutorial_use_skill", tutorial_use_skill, richText, plainText);
    //        SetInfo("tutorial_use_skill_explain", tutorial_use_skill_explain, richText, plainText);
    //        SetInfo("tutorial_replay", tutorial_replay, richText, plainText);
    //        SetInfo("tutorial_replay_explain", tutorial_replay_explain, richText, plainText);

    //    }
    //    public void UpdateSkillInfo(int heroId, TMP_Text targetText)
    //    {
    //        var richText = LocalizationManager.instance.GetLocalizedRichText();
    //        var plainText = LocalizationManager.instance.GetLocalizedTexts();

    //        SetInfo($"skill_info_hero_{heroId}", targetText, richText, plainText);
    //        SetInfo($"hero_story_{heroId}", riderStory, richText, plainText);
    //        SetInfo($"hero_weight_{heroId}", riderWeight, richText,plainText);
    //        SetInfo($"hero_height_{heroId}", riderHeight, richText, plainText);
    //        SetInfo($"hero_punch_{heroId}", riderPunch, richText, plainText);
    //        SetInfo($"hero_kick_{heroId}", riderKick, richText, plainText);

    //        SetInfo($"skill_info_hero_{heroId}", riderSkillShop, richText, plainText);
    //        SetInfo($"hero_story_{heroId}", riderStoryShop, richText, plainText);
    //        SetInfo($"hero_weight_{heroId}", riderWeightShop, richText, plainText);
    //        SetInfo($"hero_height_{heroId}", riderHeightShop, richText, plainText);
    //        SetInfo($"hero_punch_{heroId}", riderPunchShop, richText, plainText);
    //        SetInfo($"hero_kick_{heroId}", riderKickShop, richText, plainText);

    //    }
    //    public void UpdateUpgrade(int heroId)
    //    {
    //        var richText = LocalizationManager.instance.GetLocalizedRichText();
    //        var plainText = LocalizationManager.instance.GetLocalizedTexts();
    //        SetInfo($"skill_info_hero_{heroId}", heroSkill, richText, plainText);

    //    }
    //    public void UpdateObjectInfo(int objectId)
    //    {
    //        var richText = LocalizationManager.instance.GetLocalizedRichText();
    //        var plainText = LocalizationManager.instance.GetLocalizedTexts();
    //        SetInfo($"object_name_{objectId}", objectName, richText, plainText);
    //        SetInfo($"object_story_{objectId}", objectStory, richText, plainText);
    //        SetInfo($"object_battle_info_{objectId}", objectBattle, richText, plainText);
    //        if(objectId== 2032)
    //        {
    //            objectStory.text = LocalizationManager.instance.GetLocalizedText($"object_story_{objectId}", "Hepi");
    //            objectBattle.text = LocalizationManager.instance.GetLocalizedText($"object_battle_info_{objectId}", "Hepi");
    //        }
    //        if (objectId == 2030)
    //        {
    //            objectStory.text = LocalizationManager.instance.GetLocalizedText($"object_story_{objectId}",
    //                LocalizationManager.instance.GetLocalizedText($"object_name_{2001}"));
    //            objectBattle.text = LocalizationManager.instance.GetLocalizedText($"object_battle_info_{objectId}",
    //                LocalizationManager.instance.GetLocalizedText($"object_name_{2001}"));
    //        }

    //    }

    //    public void UpdateSkillInfoOnStage(int heroId) => UpdateSkillInfo(heroId, skill_info_hero_onstage);
    //    public void UpdateSkillInfoStage(int heroId) => UpdateSkillInfo(heroId, skill_info_hero_stage);
    //    public void UpdateSkillInfoLib(int heroId) => UpdateSkillInfo(heroId, skill_info_hero_lib);

    //    public void UpdateTitleStage(int level)
    //    {
    //        var localizedRichText = LocalizationManager.instance.GetLocalizedRichText();
    //        var localizedTexts = LocalizationManager.instance.GetLocalizedTexts();

    //        if ( localizedTexts.ContainsKey("title_stage"))
    //        {
    //            this.title_stage.SetText( localizedTexts["title_stage"] + " " + level);
    //        }
    //    }
    //    public void UpdateStoryInfo(string storyId)
    //    {
    //        var richText = LocalizationManager.instance.GetLocalizedRichText();
    //        var plainText = LocalizationManager.instance.GetLocalizedTexts();
    //        SetInfo($"story_title_{storyId}", titleStory, richText, plainText);
    //        SetInfo($"story_detail_{storyId}", contentStory, richText, plainText);
    //    }

    //    public void ApplyTxt(ref Dictionary<string, string> localizedRichText, ref Dictionary<string, string> localizedTexts)
    //    {
    //        textLocalizer = new TextLocalizer(localizedRichText, localizedTexts);
    //        SetCommonTexts(textLocalizer);
    //        SetRiderTexts(textLocalizer);
    //        SetShopTexts(textLocalizer);
    //        SetSettingTexts(textLocalizer);
    //    }

    //    private void SetCommonTexts(TextLocalizer textLocalizer)
    //    {
    //        textLocalizer.SetLocalizedText("loading", loading);
    //        textLocalizer.SetLocalizedText("button_start", button_start);
    //        textLocalizer.SetLocalizedText("title_stage", title_stage);
    //        textLocalizer.SetLocalizedText("title_choose_a_stage", title_choose_a_stage);
    //        textLocalizer.SetLocalizedText("warning_not_unlocked", warning_not_unlocked);
    //        textLocalizer.SetLocalizedText("warning_coming_soon", warning_coming_soon);
    //        textLocalizer.SetLocalizedText("guide_game_rule", guide_game_rule);
    //        textLocalizer.SetLocalizedText("title_notification", title_notification);
    //        textLocalizer.SetLocalizedText("popup_detail_quit", popup_detail_quit);
    //        textLocalizer.SetLocalizedText("popup_detail_language_change", popup_detail_language_change);
    //        textLocalizer.SetLocalizedText("popup_detail_language_change", popup_detail_language_change_stage);
    //        textLocalizer.SetLocalizedText("button_yes", button_yes);
    //        textLocalizer.SetLocalizedText("button_no", button_no);
    //        textLocalizer.SetLocalizedText("button_view", button_view);
    //        textLocalizer.SetLocalizedText("button_ok", button_ok);
    //        textLocalizer.SetLocalizedText("button_replay", button_replay);
    //        textLocalizer.SetLocalizedText("button_skill", button_skill);
    //        textLocalizer.SetLocalizedText("button_return_player", button_return_player);
    //        textLocalizer.SetLocalizedText("popup_detail_credit", popup_detail_credit);
    //        textLocalizer.SetLocalizedText("popup_detail_credit", popup_detail_credit2);
    //        textLocalizer.SetLocalizedText("button_new_player", button_new_player);
    //        textLocalizer.SetLocalizedText("login_popup_title", login_popup_title);
    //        textLocalizer.SetLocalizedText("login_popup_email", login_popup_email);
    //        textLocalizer.SetLocalizedText("login_popup_password", login_popup_password);
    //        textLocalizer.SetLocalizedText("login_popup_email_guide_1", login_popup_email_guide_1);
    //        textLocalizer.SetLocalizedText("login_popup_display_name", login_popup_display_name);
    //        textLocalizer.SetLocalizedText("login_popup_password_guide_1", login_popup_password_guide_1);
    //        textLocalizer.SetLocalizedText("login_popup_forget_password", login_popup_forget_password);
    //        textLocalizer.SetLocalizedText("login_popup_email_guide_1", login_popup_email_guide_1);
    //        textLocalizer.SetLocalizedText("button_login", button_login);
    //        textLocalizer.SetLocalizedText("button_logout", button_logout);
    //        textLocalizer.SetLocalizedText("button_logout", logout_btn1);
    //        textLocalizer.SetLocalizedText("button_logout", logout_btn2);
    //        textLocalizer.SetLocalizedText("login_popup_email_guide_1", login_popup_email_guide_3);
    //       // textLocalizer.SetLocalizedText("login_popup_wrong_password", login_popup_wrong_password);
    //        textLocalizer.SetLocalizedText("login_popup_email_guide_2", login_popup_email_guide_2);
    //        textLocalizer.SetLocalizedText("login_popup_password_guide_2", login_popup_password_guide_2);
    //        textLocalizer.SetLocalizedText("login_popup_display_name_guide", login_popup_display_name_guide);
    //        textLocalizer.SetLocalizedText("button_register", button_register);
    //       // textLocalizer.SetLocalizedText("login_popup_register_success", login_popup_register_success);
    //        textLocalizer.SetLocalizedText("button_my_account", login_popup_my_account);
    //        textLocalizer.SetLocalizedText("register_new_account", register_new_account);
    //        textLocalizer.SetLocalizedText("forget_password_title", forget_password_title);
    //        textLocalizer.SetLocalizedText("forget_password_content", forget_password_content);
    //        textLocalizer.SetLocalizedText("button_reset", button_reset);
    //        textLocalizer.SetLocalizedText("quest_daily_quest_title", quest_daily_quest_title);
    //        textLocalizer.SetLocalizedText("button_complete_all", button_complete_all);
    //       // textLocalizer.SetLocalizedText("button_daily_quest", button_daily_quest);
    //        textLocalizer.SetLocalizedText("button_achievement", button_achievement);
    //        textLocalizer.SetLocalizedText("quest_reset_time", quest_reset_time);
    //        //textLocalizer.SetLocalizedText("quest_tag_completed", quest_tag_completed);
    //        textLocalizer.SetLocalizedText("quest_daily_quest_all_completed", quest_daily_quest_all_completed);
    //        textLocalizer.SetLocalizedText("quest_help_daily_quest_title", quest_help_daily_quest_title);
    //        textLocalizer.SetLocalizedText("quest_help_daily_quest_content", quest_help_daily_quest_content);
    //        textLocalizer.SetLocalizedText("quest_help_achivement_title", quest_help_achivement_title);
    //        textLocalizer.SetLocalizedText("quest_help_achivement_content", quest_help_achivement_content);
    //        textLocalizer.SetLocalizedText("quest_achievement_title", quest_achievement_title);
    //        textLocalizer.SetLocalizedText("button_complete_all", button_complete_all_2);
    //        textLocalizer.SetLocalizedText("shop_help_quest_stamp_content", shop_help_quest_stamp_content);
    //        textLocalizer.SetLocalizedText("shop_help_quest_stamp_title", shop_help_quest_stamp_title);
    //        textLocalizer.SetLocalizedText("new_title", new_title);
    //        textLocalizer.SetLocalizedText("patch_note_infor", patch_note_infor);

    //        textLocalizer.SetLocalizedText("popup_update_content", popup_update_content);
    //        textLocalizer.SetLocalizedText("popup_update_title", popup_update_title);
    //        textLocalizer.SetLocalizedText("button_update", button_update);

    //    }

    //    private void SetRiderTexts(TextLocalizer textLocalizer)
    //    {
    //        textLocalizer.SetLocalizedText("title_rider_information", title_rider_information);
    //        textLocalizer.SetLocalizedText("title_rider_information", title_rider_information_stage);
    //        textLocalizer.SetLocalizedText("hp_hero_1001", hp_hero_1001);
    //        textLocalizer.SetLocalizedText("hp_hero_1002", hp_hero_1002);
    //        textLocalizer.SetLocalizedText("skill_info_hero_1001", skill_info_hero_stage);
    //        textLocalizer.SetLocalizedText("skill_info_hero_1002", skill_info_hero_onstage);
    //    }

    //    private void SetShopTexts(TextLocalizer textLocalizer)
    //    {
    //        textLocalizer.SetLocalizedText("shop_title", shop_title);
    //        textLocalizer.SetLocalizedText("shop_daily_pack_title", shop_daily_pack_title);
    //        textLocalizer.SetLocalizedText("shop_daily_pack_tag_free", shop_daily_pack_tag_free);
    //        textLocalizer.SetLocalizedText("button_exchange", button_exchange);
    //        textLocalizer.SetLocalizedText("shop_help_money_1_title", shop_help_money_1_title);
    //        textLocalizer.SetLocalizedText("shop_help_money_1_content", shop_help_money_1_content);
    //        textLocalizer.SetLocalizedText("shop_help_hot_deal_title", shop_help_hot_deal_title);
    //        textLocalizer.SetLocalizedText("shop_help_hot_deal_content", shop_help_hot_deal_content);
    //        textLocalizer.SetLocalizedText("shop_help_rider_shop_title", shop_help_rider_shop_title);
    //        textLocalizer.SetLocalizedText("shop_help_rider_shop_content", shop_help_rider_shop_content);
    //        textLocalizer.SetLocalizedText("button_shop_hot_deal", button_shop_hot_deal);
    //        textLocalizer.SetLocalizedText("button_shop_rider", button_shop_rider);
    //        //textLocalizer.SetLocalizedText("shop_claimed", shop_claimed);
    //        //textLocalizer.SetLocalizedText("shop_receive_package", shop_receive_package);
    //        //textLocalizer.SetLocalizedText("shop_owned_rider", shop_owned_rider);
    //        textLocalizer.SetLocalizedText("shop_noti_buy_rider", shop_noti_buy_rider);
    //        textLocalizer.SetLocalizedText("shop_congratulation_title", shop_congratulation);
    //        textLocalizer.SetLocalizedText("shop_congratulation_rider_get", shop_congratulation_rider_get);
    //        textLocalizer.SetLocalizedText("shop_sort_default", shop_sort_default);
    //        textLocalizer.SetLocalizedText("shop_sort_day", shop_sort_day);
    //        textLocalizer.SetLocalizedText("shop_sort_price", shop_sort_price);
    //    }

    //    private void SetSettingTexts(TextLocalizer textLocalizer)
    //    {
    //        textLocalizer.SetLocalizedText("title_setting", title_setting);
    //        textLocalizer.SetLocalizedText("setting_sound", setting_sound);
    //        textLocalizer.SetLocalizedText("setting_language", setting_language);
    //        textLocalizer.SetLocalizedText("setting_privacy_policy", setting_privacy_policy);
    //        textLocalizer.SetLocalizedText("setting_credit", setting_credit);
    //        textLocalizer.SetLocalizedText("setting_credit", setting_credit_popup1);
    //        textLocalizer.SetLocalizedText("setting_credit", setting_credit_popup2);
    //        textLocalizer.SetLocalizedText("setting_term_of_condition", setting_term_of_condition);
    //        textLocalizer.SetLocalizedText("setting_language_1", setting_language_1);
    //        textLocalizer.SetLocalizedText("setting_language_2", setting_language_2);
    //        textLocalizer.SetLocalizedText("setting_sound_on", setting_sound_on);
    //        textLocalizer.SetLocalizedText("setting_sound_off", setting_sound_off);

    //        textLocalizer.SetLocalizedText("title_setting", title_setting_stage);
    //        textLocalizer.SetLocalizedText("setting_sound", setting_sound_stage);
    //        textLocalizer.SetLocalizedText("setting_language", setting_language_stage);
    //        textLocalizer.SetLocalizedText("setting_privacy_policy", setting_privacy_policy_stage);
    //        textLocalizer.SetLocalizedText("setting_credit", setting_credit_stage);
    //        textLocalizer.SetLocalizedText("setting_term_of_condition", setting_term_of_condition_stage);
    //        textLocalizer.SetLocalizedText("setting_language_1", setting_language_1_stage);
    //        textLocalizer.SetLocalizedText("setting_language_2", setting_language_2_stage);
    //        textLocalizer.SetLocalizedText("setting_sound_on", setting_sound_on_stage);
    //        textLocalizer.SetLocalizedText("setting_sound_off", setting_sound_off_stage);

    //        textLocalizer.SetLocalizedText("login_popup_my_account", login_popup_my_account_game);
    //        textLocalizer.SetLocalizedText("login_popup_my_account", login_popup_my_account_stage);
    //        textLocalizer.SetLocalizedText("login_popup_my_account", my_account);

    //    }

    //    public void ApplyFont(ref Dictionary<string, TMP_FontAsset> localizedFonts)
    //    {
    //        var fontLocalizer = new FontLocalizer(localizedFonts);
    //        TMP_Text[] allTexts =
    //        {
    //            loading, button_start, title_stage, title_choose_a_stage, warning_not_unlocked, warning_coming_soon,
    //            guide_game_rule, title_rider_information, hp_hero_1001, hp_hero_1002, skill_info_hero_stage,title_rider_information_stage,
    //            skill_info_hero_onstage, skill_info_hero_lib, button_replay, title_setting,
    //            setting_sound, setting_sound_on, setting_sound_off, setting_language, setting_language_1,
    //            setting_language_2, setting_privacy_policy, setting_term_of_condition, setting_credit
    //           , popup_detail_quit, popup_detail_language_change, popup_detail_credit,popup_detail_language_change_stage,
    //            login_popup_title,button_return_player,titleStory,contentStory,
    //            quest_daily_quest_title, button_complete_all,button_update,popup_update_title,popup_update_content,popup_detail_credit2,

    //         button_achievement, quest_reset_time, quest_daily_quest_all_completed,
    //        quest_help_daily_quest_title, quest_help_daily_quest_content, quest_help_achivement_title, quest_help_achivement_content
    //        ,login_popup_display_name, login_popup_forget_password,
    //        button_login, login_popup_wrong_password
    //        , button_register, login_popup_register_success, login_popup_my_account, register_new_account, forget_password_title,
    //        forget_password_content, button_reset,setting_sound_stage, setting_sound_on_stage,
    // setting_sound_off_stage,
    //setting_language_stage,
    // setting_language_1_stage,
    // setting_language_2_stage,
    // setting_privacy_policy_stage,
    //setting_term_of_condition_stage,
    // setting_credit_stage,button_logout,logout_btn1,logout_btn2
    //, login_popup_my_account_stage,title_setting_stage,login_popup_my_account_game,my_account,quest_achievement_title,
    // shop_help_quest_stamp_title, shop_help_quest_stamp_content,new_title,patch_note_infor,
    //        // Object
    //        objectName, objectStory, objectBattle, libraryObjectStory, libraryObjectBattleInfor,

    //        // Rider
    //        riderNameLib, riderStory, riderWeight, riderHeight, riderPunch, riderKick,

    //        // Library
    //        libraryFeatureName, libraryButtonTutorial, libraryRiderSectionTitle, libraryObjectSectionTitle,
    //        libraryRiderTitle, libraryObjectTitle, libraryRiderAmount, libraryObjectAmount, libraryRiderStory,
    //        libraryRiderBattleInfor, libraryRiderForm, libraryRiderWeight, libraryRiderHeight,
    //        libraryRiderPunchPower, libraryRiderKickPower,

    //        // Tutorial
    //        tutorial_how_to_win, tutorial_how_to_win_explain, tutorial_how_to_move, tutorial_how_to_move_explain,
    //        tutorial_use_skill, tutorial_use_skill_explain, tutorial_replay, tutorial_replay_explain,

    //        // Shop
    //        shop_title, shop_daily_pack_title, shop_daily_pack_tag_free,
    //        shop_help_money_1_title, shop_help_money_1_content, shop_help_hot_deal_title, shop_help_hot_deal_content,
    //        shop_help_rider_shop_title, shop_help_rider_shop_content, button_shop_hot_deal, button_shop_rider,
    //        // shop_owned_rider, // Nếu có active lại thì thêm vào đây
    //        shop_noti_buy_rider, shop_congratulation, shop_congratulation_rider_get,
    //        shop_sort_default, shop_sort_day, shop_sort_price

    //        };

    //        foreach (var text in allTexts)
    //            fontLocalizer.SetLocalizedFont(text.name, text);

    //        fontLocalizer.SetLocalizedFont("button_view", button_view);
    //        fontLocalizer.SetLocalizedFont("button_ok", button_ok);
    //        fontLocalizer.SetLocalizedFont("button_no", button_no);
    //        fontLocalizer.SetLocalizedFont("button_yes", button_yes);
    //        fontLocalizer.SetLocalizedFont("button_skill", button_skill);
    //        fontLocalizer.SetLocalizedFont("button_skill", button_exchange);
    //        fontLocalizer.SetLocalizedFont("title_notification", title_notification);
    //      //  fontLocalizer.SetLocalizedFont("button_new_player", button_new_player);
    //        fontLocalizer.SetLocalizedFont("login_popup_email", login_popup_email);
    //        fontLocalizer.SetLocalizedFont("login_popup_password", login_popup_password);

    //    }
}
