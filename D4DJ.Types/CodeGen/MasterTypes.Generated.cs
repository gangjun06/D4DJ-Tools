using System;
using System.Collections.Generic;

namespace D4DJ_Tools.Masters
{
	public static partial class MasterTypes
	{
		private static Dictionary<string, Type> specialTypes = new Dictionary<string, Type>
		{
			{ "ClubItemDetailMaster", typeof(Dictionary<ValueTuple<int, int>, ClubItemDetailMaster>) },
			{ "EpisodeMaster", typeof(Dictionary<ValueTuple<EpisodeCategory, int>, EpisodeMaster>) },
			{ "LoginBonusItemMaster", typeof(Dictionary<ValueTuple<int, int>, LoginBonusItemMaster>) },
			{ "MapSpotMaster", typeof(Dictionary<ValueTuple<int, int>, MapSpotMaster>) },
			{ "MileageMaster", typeof(Dictionary<MileageRank, MileageMaster>) },
			{ "SlotBonusTimeMaster", typeof(Dictionary<ValueTuple<int, int>, SlotBonusTimeMaster>) },
			{ "MusicMixMaster", typeof(Dictionary<ValueTuple<int, ChartSectionType>, MusicMixMaster>) },
			{ "ADVLiveClubDeckMaster", typeof(Dictionary<ValueTuple<int, int>, ADVLiveClubDeckMaster>) },
			{ "ADVLiveDeckMaster", typeof(Dictionary<ValueTuple<int, int>, ADVLiveDeckMaster>) },
			{ "CampaignMaster", typeof(Dictionary<CampaignCategory, CampaignMaster>) },
			{ "PassiveSkillDescriptionMaster", typeof(Dictionary<PassiveSkillType, PassiveSkillDescriptionMaster>) },
			{ "SkillExpMaster", typeof(Dictionary<ValueTuple<int, int>, SkillExpMaster>) },
			{ "CommonValueMaster", typeof(Dictionary<CommonValueType, CommonValueMaster>) },
			{ "OverrideDefinedGameTextMaster", typeof(Dictionary<string, OverrideDefinedGameTextMaster>) },
			{ "DJSimulatorSetlistMusicMaster", typeof(Dictionary<ValueTuple<int, int>, DJSimulatorSetlistMusicMaster>) },
			{ "GrowthCharacterBlockMaster", typeof(Dictionary<ValueTuple<int, int>, GrowthCharacterBlockMaster>) },
			{ "PokerCoinMultiplierMaster", typeof(Dictionary<PokerHandCategory, PokerCoinMultiplierMaster>) },
			{ "RaidClubDeckMaster", typeof(Dictionary<ValueTuple<int, int>, RaidClubDeckMaster>) },
			{ "EventRaveMemberTrendGroupMaster", typeof(Dictionary<RaveMemberTrendGroupCategory, EventRaveMemberTrendGroupMaster>) },
			{ "EventRaveSeasonMaster", typeof(Dictionary<ValueTuple<int, int>, EventRaveSeasonMaster>) },
			{ "GachaBonusMaster", typeof(Dictionary<ValueTuple<int, bool>, GachaBonusMaster>) },
			{ "RemasterGachaMemberMaster", typeof(Dictionary<ValueTuple<int, int>, RemasterGachaMemberMaster>) },
			{ "ChartAchieveMaster", typeof(Dictionary<ValueTuple<int, ChartAchieveType, int>, ChartAchieveMaster>) },
			{ "EventLoginBonusItemMaster", typeof(Dictionary<ValueTuple<int, int, int>, EventLoginBonusItemMaster>) },
			{ "LoginBonusPositionTemplateMaster", typeof(Dictionary<ValueTuple<int, int>, LoginBonusPositionTemplateMaster>) },
			{ "ChartLessonMaster", typeof(Dictionary<ValueTuple<int, int>, ChartLessonMaster>) },
			{ "HiddenMusicMixDetailMaster", typeof(Dictionary<ValueTuple<int, int>, HiddenMusicMixDetailMaster>) },
			{ "ChartNoteCountMaster", typeof(Dictionary<ValueTuple<int, ChartSectionType>, ChartNoteCountMaster>) },
			{ "HiddenMusicMixNoteCountMaster", typeof(Dictionary<ValueTuple<int, int, ChartDifficulty>, HiddenMusicMixNoteCountMaster>) },
			{ "StaminaMaster", typeof(Dictionary<StaminaCategory, StaminaMaster>) },
			{ "TowerStageMaster", typeof(Dictionary<ValueTuple<int, int>, TowerStageMaster>) },
			{ "QuestClubDeckMaster", typeof(Dictionary<ValueTuple<int, int>, QuestClubDeckMaster>) },
			{ "QuestDeckMaster", typeof(Dictionary<ValueTuple<int, int>, QuestDeckMaster>) },
			{ "TrumpMaster", typeof(Dictionary<ValueTuple<TrumpSuit, int>, TrumpMaster>) },
		};
	}
}
