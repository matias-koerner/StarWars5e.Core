﻿using System.Collections.Generic;
using StarWars5e.Models.Enums;
// ReSharper disable InconsistentNaming

namespace StarWars5e.Parser
{
    public static class SectionNames
    {
        public static List<(string name, GlobalSearchTermType globalSearchTermType, string pathOverride)> PHBChapterNames { get; } =
            new List<(string name, GlobalSearchTermType globalSearchTermType, string pathOverride)>
            {
                ( "Player's Handbook", GlobalSearchTermType.Book, "/handbook"),
                ( "Introduction", GlobalSearchTermType.HandbookChapter, "/handbook"),
                ( "What's Different?", GlobalSearchTermType.HandbookChapter, "/handbook/whatsDifferent"),
                ( "Chapter 1: Step-By-Step Characters", GlobalSearchTermType.HandbookChapter, "/handbook/stepByStep"),
                ( "Chapter 2: Species", GlobalSearchTermType.HandbookChapter, "/handbook/species"),
                ( "Chapter 3: Classes", GlobalSearchTermType.HandbookChapter, "/handbook/classes"),
                ( "Chapter 4: Backgrounds", GlobalSearchTermType.HandbookChapter, "/handbook/backgrounds"),
                ( "Chapter 5: Equipment", GlobalSearchTermType.HandbookChapter, "/handbook/equipment"),
                ( "Chapter 6: Customization Options", GlobalSearchTermType.HandbookChapter, "/handbook/customization"),
                ( "Chapter 7: Using Ability Scores", GlobalSearchTermType.HandbookChapter, "/handbook/abilityScores"),
                ( "Chapter 8: Adventuring", GlobalSearchTermType.HandbookChapter, "/handbook/adventuring"),
                ( "Chapter 9: Combat", GlobalSearchTermType.HandbookChapter, "/handbook/combat"),
                ( "Chapter 10: Force- And Tech- Casting", GlobalSearchTermType.HandbookChapter, "/handbook/casting"),
                ( "Appendix A: Conditions", GlobalSearchTermType.HandbookChapter, "/handbook/conditions"),
                ( "Appendix B: Recommended Variant Rules", GlobalSearchTermType.HandbookChapter, "/handbook/variantRules"),
                ( "Handbook Changelog", GlobalSearchTermType.Changelog, "/handbook/changelog")
            };

        public static List<(string name, GlobalSearchTermType globalSearchTermType, string pathOverride)> SOTGChapterNames { get; } =
            new List<(string name, GlobalSearchTermType globalSearchTermType, string pathOverride)>
            {
                ( "Starships Of The Galaxy", GlobalSearchTermType.Book, "/starships"),
                ( "Introduction", GlobalSearchTermType.StarshipChapter, "/starships"),
                ( "Chapter 1: Step-By-Step Starships", GlobalSearchTermType.StarshipChapter, "/starships/stepByStep"),
                ( "Chapter 2: Deployments", GlobalSearchTermType.StarshipChapter, "/starships/deployments"),
                ( "Chapter 3: Starships", GlobalSearchTermType.StarshipChapter, "/starships/starshipSizes"),
                ( "Chapter 4: Modifications", GlobalSearchTermType.StarshipChapter, "/starships/modifications"),
                ( "Chapter 5: Equipment", GlobalSearchTermType.StarshipChapter, "/starships/equipment"),
                ( "Chapter 6: Customization Options", GlobalSearchTermType.StarshipChapter, "/starships/customization"),
                ( "Chapter 7: Using Ability Scores", GlobalSearchTermType.StarshipChapter, "/starships/abilityScores"),
                ( "Chapter 8: Adventuring", GlobalSearchTermType.StarshipChapter, "/starships/adventuring"),
                ( "Chapter 9: Combat", GlobalSearchTermType.StarshipChapter, "/starships/combat"),
                ( "Chapter 10: Generating Encounters", GlobalSearchTermType.StarshipChapter, "/starships/generatingEncounters"),
                ( "Appendix A: Conditions", GlobalSearchTermType.StarshipChapter, "/starships/conditions"),
                ( "Starship Changelog", GlobalSearchTermType.Changelog, "/starships/changelog")
            };

        public static List<(string name, GlobalSearchTermType globalSearchTermType, string pathOverride)> MonsterChapterNames { get; } =
            new List<(string name, GlobalSearchTermType globalSearchTermType, string pathOverride)>
            {
                ( "Monster Manual", GlobalSearchTermType.Book, "/monsters")
            };

        public static List<(string name, GlobalSearchTermType globalSearchTermType, string pathOverride)> ReferenceNames { get; } =
            new List<(string name, GlobalSearchTermType globalSearchTermType, string pathOverride)>
            {
                ( "Monsters", GlobalSearchTermType.Reference, "/monsters/monsters"),
                ( "Species", GlobalSearchTermType.Reference, "/reference/species"),
                ( "Archetypes", GlobalSearchTermType.Reference, "/reference/archetypes"),
                ( "Backgrounds", GlobalSearchTermType.Reference, "/reference/backgrounds"),
                ( "Armor", GlobalSearchTermType.Reference, "/reference/armor"),
                ( "Adventuring Gear", GlobalSearchTermType.Reference, "/reference/adventuringGear"),
                ( "Feats", GlobalSearchTermType.Reference, "/reference/feats"),
                ( "Force Powers", GlobalSearchTermType.Reference, "/reference/forcePowers"),
                ( "Tech Powers", GlobalSearchTermType.Reference, "/reference/techPowers"),
                ( "Starship Modifications", GlobalSearchTermType.Reference, "/reference/starshipModifications"),
                ( "Starship Equipment", GlobalSearchTermType.Reference, "/reference/starshipEquipment"),
                ( "Starship Weapons", GlobalSearchTermType.Reference, "/reference/starshipWeapons"),
                ( "Ventures", GlobalSearchTermType.Reference, "/reference/ventures"),
                ( "Additional Variant Rules", GlobalSearchTermType.Reference, "/reference/additionalVariantRules"),
            };

        public static List<(string name, GlobalSearchTermType globalSearchTermType, string pathOverride)> VariantRuleNames { get; } =
            new List<(string name, GlobalSearchTermType globalSearchTermType, string pathOverride)>
            {
                ( "Destiny", GlobalSearchTermType.VariantRule, "/reference/additionalVariantRules/Destiny"),
                ( "Force Alignment", GlobalSearchTermType.VariantRule, "/reference/additionalVariantRules/Force%20Alignment"),
                ( "Starship Destiny", GlobalSearchTermType.VariantRule, "/reference/additionalVariantRules/Starship%20Destiny"),
                ( "Weapon Sundering", GlobalSearchTermType.VariantRule, "/reference/additionalVariantRules/Weapon%20Sundering")
            };

        public static List<(string name, GlobalSearchTermType globalSearchTermType, string pathOverride)> PHBChapterOneSections { get; } =
            new List<(string name, GlobalSearchTermType globalSearchTermType, string pathOverride)>
            {
                ( "Level", GlobalSearchTermType.Rule, null),
                ( "Hit Points and Hit Dice", GlobalSearchTermType.Rule, null),
                ( "Proficiency Bonus", GlobalSearchTermType.Rule, null),
                ( "Variant: Customizing Ability Scores", GlobalSearchTermType.VariantRule, null),
                ( "Ability Score Point Cost", GlobalSearchTermType.Table, null),
                ( "Ability Scores and Modifiers", GlobalSearchTermType.Table, null),
                ( "Armor Class", GlobalSearchTermType.Rule, null),
                ( "Weapons", GlobalSearchTermType.Rule, null ),
                ( "Character Advancement", GlobalSearchTermType.Table, null )
            };

        public static List<(string name, GlobalSearchTermType globalSearchTermType, string pathOverride)> PHBChapterTwoSections { get; } =
            new List<(string name, GlobalSearchTermType globalSearchTermType, string pathOverride)>
            {
                ( "Choosing A Species", GlobalSearchTermType.Rule, null),
                ( "Ability Score Increase", GlobalSearchTermType.Rule, null),
                ( "Age", GlobalSearchTermType.Rule, null),
                ( "Alignment", GlobalSearchTermType.Rule, null),
                ( "Size", GlobalSearchTermType.Rule, null),
                ( "Speed", GlobalSearchTermType.Rule, null),
                ( "Languages", GlobalSearchTermType.Rule, null)
            };

        public static List<(string name, GlobalSearchTermType globalSearchTermType, string pathOverride)> PHBChapterThreeSections { get; } =
            new List<(string name, GlobalSearchTermType globalSearchTermType, string pathOverride)>();

        public static List<(string name, GlobalSearchTermType globalSearchTermType, string pathOverride)> PHBChapterFourSections { get; } =
            new List<(string name, GlobalSearchTermType globalSearchTermType, string pathOverride)>
            {
                ( "Name", GlobalSearchTermType.Rule, null),
                ( "Sex", GlobalSearchTermType.Rule, null),
                ( "Height And Weight", GlobalSearchTermType.Rule, null),
                ( "Other Physical Characteristics", GlobalSearchTermType.Rule, null),
                ( "Alignment", GlobalSearchTermType.Rule, null),
                ( "Languages", GlobalSearchTermType.Rule, null),
                ( "Personal Characteristics", GlobalSearchTermType.Rule, null),
                ( "Personality Traits", GlobalSearchTermType.Rule, null),
                ( "Ideals", GlobalSearchTermType.Rule, null),
                ( "Bonds", GlobalSearchTermType.Rule, null),
                ( "Flaws", GlobalSearchTermType.Rule, null),
                ( "Inspiration", GlobalSearchTermType.Rule, null),
                ( "Backgrounds", GlobalSearchTermType.Rule, null),
                ( "Customizing A Background", GlobalSearchTermType.Rule, null)
            };

        public static List<(string name, GlobalSearchTermType globalSearchTermType, string pathOverride)> PHBChapterFiveSections { get; } =
            new List<(string name, GlobalSearchTermType globalSearchTermType, string pathOverride)>
            {
                ( "Variant: Starting Wealth By Class", GlobalSearchTermType.Table, null),
                ( "Wealth", GlobalSearchTermType.Rule, null),
                ( "Currency", GlobalSearchTermType.Rule, null),
                ( "Selling Treasure", GlobalSearchTermType.Rule, null),
                ( "Armor and Shields", GlobalSearchTermType.Rule, null),
                ( "Variant: Equipment Sizes", GlobalSearchTermType.VariantRule, null),
                ( "Armor And Shield Proficiency", GlobalSearchTermType.Rule, null),
                ( "Armor Class (AC)", GlobalSearchTermType.EquipmentProperty, null),
                ( "Strength", GlobalSearchTermType.EquipmentProperty, null),
                ( "Stealth", GlobalSearchTermType.EquipmentProperty, null),
                ( "Light Armor", GlobalSearchTermType.Rule, null),
                ( "Medium Armor", GlobalSearchTermType.Rule, null),
                ( "Powered Battle Armor", GlobalSearchTermType.Rule, null),
                ( "Heavy Armor", GlobalSearchTermType.Rule, null),
                ( "Shield Generators", GlobalSearchTermType.Rule, null),
                ( "Getting Into And Out Of Armor", GlobalSearchTermType.Rule, null),
                ( "Donning And Doffing Armor", GlobalSearchTermType.Rule, null),
                ( "Weapons", GlobalSearchTermType.Rule, null),
                ( "Ammunition", GlobalSearchTermType.WeaponProperty, null),
                ( "Burst", GlobalSearchTermType.WeaponProperty, null),
                ( "Double", GlobalSearchTermType.WeaponProperty, null),
                ( "Finesse", GlobalSearchTermType.WeaponProperty, null),
                ( "Heavy", GlobalSearchTermType.WeaponProperty, null),
                ( "Hidden", GlobalSearchTermType.WeaponProperty, null),
                ( "Light", GlobalSearchTermType.WeaponProperty, null),
                ( "Luminous", GlobalSearchTermType.WeaponProperty, null),
                ( "Range", GlobalSearchTermType.WeaponProperty, null),
                ( "Reach", GlobalSearchTermType.WeaponProperty, null),
                ( "Reload", GlobalSearchTermType.WeaponProperty, null),
                ( "Special", GlobalSearchTermType.WeaponProperty, null),
                ( "Strength", GlobalSearchTermType.WeaponProperty, "strength 2"),
                ( "Thrown", GlobalSearchTermType.WeaponProperty, null),
                ( "Two-Handed", GlobalSearchTermType.WeaponProperty, null),
                ( "Versatile", GlobalSearchTermType.WeaponProperty, null),
                ( "Improvised Weapons", GlobalSearchTermType.Rule, null),
                ( "Special Weapons", GlobalSearchTermType.Rule, null),
                ( "Adventuring Gear", GlobalSearchTermType.Rule, null),
                ( "Burglar's Pack", GlobalSearchTermType.AdventuringGear, null),
                ( "Diplomat's Pack", GlobalSearchTermType.AdventuringGear, null),
                ( "Dungeoneer's Pack", GlobalSearchTermType.AdventuringGear, null),
                ( "Entertainer's Pack", GlobalSearchTermType.AdventuringGear, null),
                ( "Explorer's Pack", GlobalSearchTermType.AdventuringGear, null),
                ( "Priest's Pack", GlobalSearchTermType.AdventuringGear, null),
                ( "Scholar's Pack", GlobalSearchTermType.AdventuringGear, null),
                ( "Technologist's Pack", GlobalSearchTermType.AdventuringGear, null),
                ( "Trade Goods", GlobalSearchTermType.Rule, null ),
                ( "Droids", GlobalSearchTermType.Rule, null ),
                ( "Mounts and Vehicles", GlobalSearchTermType.Rule, null ),
                ( "Mounts and Other Animals", GlobalSearchTermType.Table, null ),
                ( "Tack, Harness, and Drawn Vehicles", GlobalSearchTermType.Table, null ),
                ( "Vehicles", GlobalSearchTermType.Rule, null ),
                ( "Lifestyle Expenses", GlobalSearchTermType.Rule, null ),
                ( "Food, Drink, And Lodging", GlobalSearchTermType.Rule, null ),
                ( "Services", GlobalSearchTermType.Rule, null )
            };

        public static List<(string name, GlobalSearchTermType globalSearchTermType, string pathOverride)> PHBChapterSixSections { get; } =
            new List<(string name, GlobalSearchTermType globalSearchTermType, string pathOverride)>
            {
                ( "Multiclassing", GlobalSearchTermType.Rule, null),
                ( "Fighting Styles", GlobalSearchTermType.Rule, null)
            };

        public static List<(string name, GlobalSearchTermType globalSearchTermType, string pathOverride)> PHBChapterSevenSections { get; } =
            new List<(string name, GlobalSearchTermType globalSearchTermType, string pathOverride)>
            {
                ( "Ability Scores And Modifiers", GlobalSearchTermType.Rule, null),
                ( "Advantage and Disadvantage", GlobalSearchTermType.Rule, null),
                ( "Proficiency Bonus", GlobalSearchTermType.Rule, null),
                ( "Ability Checks", GlobalSearchTermType.Rule, null),
                ( "Contests", GlobalSearchTermType.Rule, null),
                ( "Passive Checks", GlobalSearchTermType.Rule, null),
                ( "Working Together", GlobalSearchTermType.Rule, null),
                ( "Strength", GlobalSearchTermType.Rule, null),
                ( "Dexterity", GlobalSearchTermType.Rule, null),
                ( "Constitution", GlobalSearchTermType.Rule, null),
                ( "Hiding", GlobalSearchTermType.Rule, null),
                ( "Intelligence", GlobalSearchTermType.Rule, null),
                ( "Wisdom", GlobalSearchTermType.Rule, null),
                ( "Charisma", GlobalSearchTermType.Rule, null),
                ( "Saving Throws", GlobalSearchTermType.Rule, null)
            };

        public static List<(string name, GlobalSearchTermType globalSearchTermType, string pathOverride)> PHBChapterEightSections { get; } =
            new List<(string name, GlobalSearchTermType globalSearchTermType, string pathOverride)>
            {
                ( "Movement", GlobalSearchTermType.Rule, null),
                ( "Speed", GlobalSearchTermType.Rule, null),
                ( "Difficult Terrain", GlobalSearchTermType.Rule, null),
                ( "Climbing, Swimming, and Crawling", GlobalSearchTermType.Rule, null),
                ( "Jumping", GlobalSearchTermType.Rule, null),
                ( "Activity While Traveling", GlobalSearchTermType.Rule, null),
                ( "Marching Order", GlobalSearchTermType.Rule, null),
                ( "Stealth", GlobalSearchTermType.Rule, null),
                ( "Noticing Threats", GlobalSearchTermType.Rule, null),
                ( "Splitting Up The Party", GlobalSearchTermType.Rule, null),
                ( "The Environment", GlobalSearchTermType.Rule, null),
                ( "Falling", GlobalSearchTermType.Rule, null),
                ( "Suffocating", GlobalSearchTermType.Rule, null),
                ( "Vision And Light", GlobalSearchTermType.Rule, null),
                ( "Blindsight", GlobalSearchTermType.Rule, null),
                ( "Darkvision", GlobalSearchTermType.Rule, null),
                ( "Truesight", GlobalSearchTermType.Rule, null),
                ( "Food And Water", GlobalSearchTermType.Rule, null),
                ( "Interacting With Objects", GlobalSearchTermType.Rule, null),
                ( "Social Interaction", GlobalSearchTermType.Rule, null),
                ( "Roleplaying", GlobalSearchTermType.Rule, null),
                ( "Resting", GlobalSearchTermType.Rule, null),
                ( "Short Rest", GlobalSearchTermType.Rule, null),
                ( "Long Rest", GlobalSearchTermType.Rule, null),
                ( "Between Adventures", GlobalSearchTermType.Rule, null),
                ( "Downtime Activities", GlobalSearchTermType.Rule, null),
                ( "Crafting", GlobalSearchTermType.Rule, null),
                ( "Practicing A Profession", GlobalSearchTermType.Rule, null),
                ( "Recuperating", GlobalSearchTermType.Rule, null),
                ( "Researching", GlobalSearchTermType.Rule, null),
                ( "Training", GlobalSearchTermType.Rule, null)
            };

        public static List<(string name, GlobalSearchTermType globalSearchTermType, string pathOverride)> PHBChapterNineSections { get; } =
            new List<(string name, GlobalSearchTermType globalSearchTermType, string pathOverride)>
            {
                ( "The Order Of Combat", GlobalSearchTermType.Rule, null),
                ( "Surprise", GlobalSearchTermType.Rule, null),
                ( "Your Turn", GlobalSearchTermType.Rule, null),
                ( "Bonus Actions", GlobalSearchTermType.Rule, null),
                ( "Other Activity On Your Turn", GlobalSearchTermType.Rule, null),
                ( "Interacting with Objects Around You", GlobalSearchTermType.Rule, null),
                ( "Reactions", GlobalSearchTermType.Rule, null),
                ( "Movement And Position", GlobalSearchTermType.Rule, null),
                ( "Breaking Up Your Move", GlobalSearchTermType.Rule, null),
                ( "Difficult Terrain", GlobalSearchTermType.Rule, null),
                ( "Moving Between Attacks", GlobalSearchTermType.Rule, null),
                ( "Being Prone", GlobalSearchTermType.Rule, null),
                ( "Moving Around Other Creatures", GlobalSearchTermType.Rule, null),
                ( "Flying Movement", GlobalSearchTermType.Rule, null),
                ( "Creature Size", GlobalSearchTermType.Rule, null),
                ( "Squeezing Into A Smaller Space", GlobalSearchTermType.Rule, null),
                ( "Variant: Playing On A Grid", GlobalSearchTermType.VariantRule, null),
                ( "Action In Combat", GlobalSearchTermType.Rule, null),
                ( "Attack", GlobalSearchTermType.Rule, null),
                ( "Cast A Power", GlobalSearchTermType.Rule, null),
                ( "Dash", GlobalSearchTermType.Rule, null),
                ( "Disengage", GlobalSearchTermType.Rule, null),
                ( "Dodge", GlobalSearchTermType.Rule, null),
                ( "Help", GlobalSearchTermType.Rule, null),
                ( "Hide", GlobalSearchTermType.Rule, null),
                ( "Ready", GlobalSearchTermType.Rule, null),
                ( "Search", GlobalSearchTermType.Rule, null),
                ( "Use An Object", GlobalSearchTermType.Rule, null),
                ( "Making An Attack", GlobalSearchTermType.Rule, null),
                ( "Attack Rolls", GlobalSearchTermType.Rule, null),
                ( "Unseen Attackers And Targets", GlobalSearchTermType.Rule, null),
                ( "Ranged Attacks", GlobalSearchTermType.Rule, null),
                ( "Opportunity Attacks", GlobalSearchTermType.Rule, null),
                ( "Two-Weapon Fighting", GlobalSearchTermType.Rule, null),
                ( "Range", GlobalSearchTermType.Rule, null),
                ( "Ranged Attacks In Close Combat", GlobalSearchTermType.Rule, null),
                ( "Melee Attacks", GlobalSearchTermType.Rule, null),
                ( "Grappling", GlobalSearchTermType.Rule, null),
                ( "Shoving", GlobalSearchTermType.Rule, null),
                ( "Cover", GlobalSearchTermType.Rule, null),
                ( "Damage And Healing", GlobalSearchTermType.Rule, null),
                ( "Hit Points", GlobalSearchTermType.Rule, null),
                ( "Damage Rolls", GlobalSearchTermType.Rule, null),
                ( "Critical Hits", GlobalSearchTermType.Rule, null),
                ( "Damage Types", GlobalSearchTermType.Rule, null),
                ( "Damage Resistance And Vulnerability", GlobalSearchTermType.Rule, null),
                ( "Healing", GlobalSearchTermType.Rule, null),
                ( "Dropping To 0 Hit Points", GlobalSearchTermType.Rule, null),
                ( "Instant Death", GlobalSearchTermType.Rule, null),
                ( "Falling Unconscious", GlobalSearchTermType.Rule, null),
                ( "Death Saving Throws", GlobalSearchTermType.Rule, null),
                ( "Stabilizing A Creature", GlobalSearchTermType.Rule, null),
                ( "Monsters And Death", GlobalSearchTermType.Rule, null),
                ( "Knocking A Creature Out", GlobalSearchTermType.Rule, null),
                ( "Temporary Hit Points", GlobalSearchTermType.Rule, null),
                ( "Mounted Combat", GlobalSearchTermType.Rule, null),
                ( "Underwater Combat", GlobalSearchTermType.Rule, null)
            };

        public static List<(string name, GlobalSearchTermType globalSearchTermType, string pathOverride)> PHBChapterTenSections { get; } =
            new List<(string name, GlobalSearchTermType globalSearchTermType, string pathOverride)>
            {
                ( "Power Level", GlobalSearchTermType.Rule, null),
                ( "Known Powers", GlobalSearchTermType.Rule, null),
                ( "Force and Tech Points", GlobalSearchTermType.Rule, null),
                ( "Casting A Power At A Higher Level", GlobalSearchTermType.Rule, null),
                ( "At-Will Powers", GlobalSearchTermType.Rule, null),
                ( "Casting A Power", GlobalSearchTermType.Rule, null),
                ( "Power Alignments", GlobalSearchTermType.Rule, null),
                ( "Casting Time", GlobalSearchTermType.Rule, null),
                ( "Range", GlobalSearchTermType.Rule, null),
                ( "Duration", GlobalSearchTermType.Rule, null),
                ( "Concentration", GlobalSearchTermType.Rule, null),
                ( "Targets", GlobalSearchTermType.Rule, null),
                ( "Areas Of Effect", GlobalSearchTermType.Rule, null),
                ( "Cone", GlobalSearchTermType.Rule, null),
                ( "Cylinder", GlobalSearchTermType.Rule, null),
                ( "Cube", GlobalSearchTermType.Rule, null),
                ( "Line", GlobalSearchTermType.Rule, null),
                ( "Sphere", GlobalSearchTermType.Rule, null),
                ( "Saving Throws", GlobalSearchTermType.Rule, null),
                ( "Attack Rolls", GlobalSearchTermType.Rule, null),
                ( "Combining Effects", GlobalSearchTermType.Rule, null)
            };

        public static List<(string name, GlobalSearchTermType globalSearchTermType, string pathOverride)> PHBAppendixAConditionsSections { get; } =
            new List<(string name, GlobalSearchTermType globalSearchTermType, string pathOverride)>
            {
                ( "Blinded", GlobalSearchTermType.Condition, null),
                ( "Charmed", GlobalSearchTermType.Condition, null),
                ( "Deafened", GlobalSearchTermType.Condition, null),
                ( "Exhaustion", GlobalSearchTermType.Condition, null),
                ( "Frightened", GlobalSearchTermType.Condition, null),
                ( "Grappled", GlobalSearchTermType.Condition, null),
                ( "Incapacitated", GlobalSearchTermType.Condition, null),
                ( "Invisible", GlobalSearchTermType.Condition, null),
                ( "Paralyzed", GlobalSearchTermType.Condition, null),
                ( "Petrified", GlobalSearchTermType.Condition, null),
                ( "Poisoned", GlobalSearchTermType.Condition, null),
                ( "Prone", GlobalSearchTermType.Condition, null),
                ( "Restrained", GlobalSearchTermType.Condition, null),
                ( "Shocked", GlobalSearchTermType.Condition, null),
                ( "Stunned", GlobalSearchTermType.Condition, null),
                ( "Unconscious", GlobalSearchTermType.Condition, null)
            };

        public static List<(string name, GlobalSearchTermType globalSearchTermType, string pathOverride)> PHBAppendixBVariantRulesSections { get; } =
            new List<(string name, GlobalSearchTermType globalSearchTermType, string pathOverride)>
            {
                ( "Defense Rolls", GlobalSearchTermType.VariantRule, null),
                ( "Saving Throw Checks", GlobalSearchTermType.VariantRule, null),
                ( "Simplified Forcecasting", GlobalSearchTermType.VariantRule, null),
                ( "ASI And a Feat", GlobalSearchTermType.VariantRule, null),
                ( "Milestone Leveling", GlobalSearchTermType.VariantRule, null),
                ( "Hunted", GlobalSearchTermType.VariantRule, null)
            };

        public static List<(string name, GlobalSearchTermType globalSearchTermType, string pathOverride)> SOTGChapterZeroSections { get; } =
            new List<(string name, GlobalSearchTermType globalSearchTermType, string pathOverride)>
            {
                ( "Take To The Stars", GlobalSearchTermType.StarshipRule, null),
                ( "Using This Book", GlobalSearchTermType.StarshipRule, null),
                ( "Game Dice", GlobalSearchTermType.StarshipRule, null),
                ( "The D20", GlobalSearchTermType.StarshipRule, null),
                ( "Advantage And Disadvantage", GlobalSearchTermType.StarshipRule, null),
                ( "Specific Beats General", GlobalSearchTermType.StarshipRule, null),
                ( "Round Down", GlobalSearchTermType.StarshipRule, null),
                ( "Tier", GlobalSearchTermType.StarshipRule, null)
            };

        public static List<(string name, GlobalSearchTermType globalSearchTermType, string pathOverride)> SOTGChapterOneSections { get; } =
            new List<(string name, GlobalSearchTermType globalSearchTermType, string pathOverride)>
            {
                ( "1. Choose A Deployment", GlobalSearchTermType.StarshipRule, null),
                ( "2. Acquire A Starship", GlobalSearchTermType.StarshipRule, null),
                ( "Tier", GlobalSearchTermType.StarshipRule, null),
                ( "Hit Points And Hit Dice", GlobalSearchTermType.StarshipRule, null),
                ( "3. Installing Modifications", GlobalSearchTermType.StarshipRule, null),
                ( "4. Choose Equipment", GlobalSearchTermType.StarshipRule, null),
                ( "Armor Class", GlobalSearchTermType.StarshipRule, null),
                ( "Weapons", GlobalSearchTermType.StarshipRule, null),
                ( "5. Come Together", GlobalSearchTermType.StarshipRule, null),
                ( "Beyond The Basics", GlobalSearchTermType.StarshipRule, null),
                ( "Feature And Hit Dice", GlobalSearchTermType.StarshipRule, null),
            };

        public static List<(string name, GlobalSearchTermType globalSearchTermType, string pathOverride)> SOTGChapterThreeSections { get; } =
            new List<(string name, GlobalSearchTermType globalSearchTermType, string pathOverride)>
            {
                ( "Acquiring A Ship", GlobalSearchTermType.StarshipRule, null),
                ( "Joining A Faction", GlobalSearchTermType.StarshipRule, null),
                ( "Shipjacking", GlobalSearchTermType.StarshipRule, null),
                ( "Purchasing", GlobalSearchTermType.StarshipRule, null),
                ( "Building A Ship", GlobalSearchTermType.StarshipRule, null),
                ( "Upgrading A Starship", GlobalSearchTermType.StarshipRule, null),
                ( "Cost Modifiers", GlobalSearchTermType.StarshipRule, null),
                ( "Upgrade Workforce", GlobalSearchTermType.StarshipRule, null),
                ( "Upgrade Time", GlobalSearchTermType.StarshipRule, null)
            };

        public static List<(string name, GlobalSearchTermType globalSearchTermType, string pathOverride)> SOTGChapterFourSections { get; } =
            new List<(string name, GlobalSearchTermType globalSearchTermType, string pathOverride)>
            {
                ( "Modifying A Starship", GlobalSearchTermType.StarshipRule, null),
                ( "Cost Modifiers", GlobalSearchTermType.StarshipRule, null),
                ( "Modification Workforce", GlobalSearchTermType.StarshipRule, null),
                ( "Purchasing", GlobalSearchTermType.StarshipRule, null),
                ( "Building A Ship", GlobalSearchTermType.StarshipRule, null),
                ( "Upgrading A Starship", GlobalSearchTermType.StarshipRule, null),
                ( "Upgrade Workforce", GlobalSearchTermType.StarshipRule, null),
                ( "Modification Time", GlobalSearchTermType.StarshipRule, null),
                ( "Modification Tier Requirements", GlobalSearchTermType.StarshipRule, null),
                ( "Prerequisites", GlobalSearchTermType.StarshipRule, null),
                ( "Changing Saving Throw Proficiency", GlobalSearchTermType.StarshipRule, null),
                ( "Removing Modifications", GlobalSearchTermType.StarshipRule, null),
                ( "Starship Tier Features", GlobalSearchTermType.StarshipRule, null),
                ( "Modification Slots At Tier 0", GlobalSearchTermType.StarshipRule, null),
                ( "Stock Modifications", GlobalSearchTermType.StarshipRule, null)
            };

        public static List<(string name, GlobalSearchTermType globalSearchTermType, string pathOverride)> SOTGChapterFiveSections { get; } =
            new List<(string name, GlobalSearchTermType globalSearchTermType, string pathOverride)>
            {
                ( "Cost Modifiers", GlobalSearchTermType.StarshipRule, null),
                ( "Equipment Workforce", GlobalSearchTermType.StarshipRule, null),
                ( "Installation Time", GlobalSearchTermType.StarshipRule, null),
                ( "Cargo", GlobalSearchTermType.StarshipRule, null),
                ( "Cargo Capacity", GlobalSearchTermType.StarshipRule, null),
                ( "Armor And Shields", GlobalSearchTermType.StarshipRule, null),
                ( "Armor", GlobalSearchTermType.StarshipRule, null),
                ( "Armor Class", GlobalSearchTermType.StarshipRule, null),
                ( "Shields", GlobalSearchTermType.StarshipRule, null),
                ( "Weapons", GlobalSearchTermType.StarshipRule, null),
                ( "Primary Weapons", GlobalSearchTermType.StarshipRule, null),
                ( "Secondary Weapons", GlobalSearchTermType.StarshipRule, null),
                ( "Tertiary Weapons", GlobalSearchTermType.StarshipRule, null),
                ( "Quaternary Weapons", GlobalSearchTermType.StarshipRule, null),
                ( "Attack Bonus", GlobalSearchTermType.StarshipWeaponProperty, null),
                ( "Ammunition", GlobalSearchTermType.StarshipWeaponProperty, null),
                ( "Attacks Per Round", GlobalSearchTermType.StarshipWeaponProperty, null),
                ( "Power", GlobalSearchTermType.StarshipWeaponProperty, null),
                ( "Reload", GlobalSearchTermType.StarshipWeaponProperty, null),
                ( "Weapons By Size", GlobalSearchTermType.StarshipRule, null),
                ( "Tiny To Medium", GlobalSearchTermType.StarshipRule, null),
                ( "Large To Gargantuan", GlobalSearchTermType.StarshipRule, null),
                ( "Ammunition", GlobalSearchTermType.StarshipRule, "ammunition 2"),
                ( "Tertiary Ammunition", GlobalSearchTermType.StarshipRule, null),
                ( "Quaternary Ammunition", GlobalSearchTermType.StarshipRule, null),
                ( "Hyperdrive", GlobalSearchTermType.StarshipRule, null),
                ( "Navcomputer", GlobalSearchTermType.StarshipRule, null),
                ( "Docking", GlobalSearchTermType.StarshipRule, null),
                ( "Docking Fees", GlobalSearchTermType.StarshipRule, null),
                ( "Long Term Storage", GlobalSearchTermType.StarshipRule, null),
                ( "Refueling And Restocking", GlobalSearchTermType.StarshipRule, null),
            };

        public static List<(string name, GlobalSearchTermType globalSearchTermType, string pathOverride)> SOTGChapterSixSections { get; } =
            new List<(string name, GlobalSearchTermType globalSearchTermType, string pathOverride)>
            {
                ( "Multispecializing", GlobalSearchTermType.StarshipRule, null),
                ( "Gunning Styles", GlobalSearchTermType.StarshipRule, null),
                ( "Gunning Masteries", GlobalSearchTermType.StarshipRule, null),
                ( "Ventures", GlobalSearchTermType.StarshipRule, null)
            };

        public static List<(string name, GlobalSearchTermType globalSearchTermType, string pathOverride)> SOTGChapterSevenSections { get; } =
            new List<(string name, GlobalSearchTermType globalSearchTermType, string pathOverride)>
            {
                ( "Ability Scores And Modifiers", GlobalSearchTermType.StarshipRule, null),
                ( "Advantage And Disadvantage", GlobalSearchTermType.StarshipRule, null),
                ( "Proficiency Bonus", GlobalSearchTermType.StarshipRule, null),
                ( "Expertise", GlobalSearchTermType.StarshipRule, null),
                ( "Ability Checks", GlobalSearchTermType.StarshipRule, null),
                ( "Contests", GlobalSearchTermType.StarshipRule, null),
                ( "Strength", GlobalSearchTermType.StarshipRule, null),
                ( "Strength Checks", GlobalSearchTermType.StarshipRule, null),
                ( "Strength Saving Throws", GlobalSearchTermType.StarshipRule, null),
                ( "Flying Speed", GlobalSearchTermType.StarshipRule, null),
                ( "Weapon Hardpoints", GlobalSearchTermType.StarshipRule, null),
                ( "Dexterity", GlobalSearchTermType.StarshipRule, null),
                ( "Dexterity Checks", GlobalSearchTermType.StarshipRule, null),
                ( "Dexterity Saving Throws", GlobalSearchTermType.StarshipRule, null),
                ( "Attack And Damage Rolls", GlobalSearchTermType.StarshipRule, null),
                ( "Turning Speed", GlobalSearchTermType.StarshipRule, null),
                ( "Constitution", GlobalSearchTermType.StarshipRule, null),
                ( "Constitution Checks", GlobalSearchTermType.StarshipRule, null),
                ( "Constitution Saving Throws", GlobalSearchTermType.StarshipRule, null),
                ( "Hit Points", GlobalSearchTermType.StarshipRule, null)
            };

        public static List<(string name, GlobalSearchTermType globalSearchTermType, string pathOverride)> SOTGChapterEightSections { get; } =
            new List<(string name, GlobalSearchTermType globalSearchTermType, string pathOverride)>
            {
                ( "Ship Registration", GlobalSearchTermType.StarshipRule, null),
                ( "Transponder Codes", GlobalSearchTermType.StarshipRule, null),
                ( "Communications", GlobalSearchTermType.StarshipRule, null),
                ( "Metosp (Message to Spacers)", GlobalSearchTermType.StarshipRule, null),
                ( "Planetary Information Channels", GlobalSearchTermType.StarshipRule, null),
                ( "Time", GlobalSearchTermType.StarshipRule, null),
                ( "Movement and Travel", GlobalSearchTermType.StarshipRule, null),
                ( "Travel In Realspace", GlobalSearchTermType.StarshipRule, null),
                ( "Flying Speed", GlobalSearchTermType.StarshipRule, null),
                ( "Turning Speed", GlobalSearchTermType.StarshipRule, null),
                ( "Travel Pace", GlobalSearchTermType.StarshipRule, null),
                ( "Difficult Terrain", GlobalSearchTermType.StarshipRule, null),
                ( "Activity While Traveling", GlobalSearchTermType.StarshipRule, null),
                ( "Deployment Order", GlobalSearchTermType.StarshipRule, null),
                ( "Stealth", GlobalSearchTermType.StarshipRule, null),
                ( "Noticing Threats", GlobalSearchTermType.StarshipRule, null),
                ( "Other Activities", GlobalSearchTermType.StarshipRule, null),
                ( "Travel In Hyperspace", GlobalSearchTermType.StarshipRule, null),
                ( "Travel Pace", GlobalSearchTermType.StarshipRule, "travel pace 2"),
                ( "Detecting Hyperspace Travel", GlobalSearchTermType.StarshipRule, null),
                ( "Astrogation", GlobalSearchTermType.StarshipRule, null),
                ( "Hyperspace Hazards", GlobalSearchTermType.StarshipRule, null),
                ( "Landing Gear", GlobalSearchTermType.StarshipRule, null),
                ( "Movement In Zero Gravity", GlobalSearchTermType.StarshipRule, null),
                ( "Crew Capacity", GlobalSearchTermType.StarshipRule, null),
                ( "Deployed", GlobalSearchTermType.StarshipRule, null),
                ( "The Environment", GlobalSearchTermType.StarshipRule, null),
                ( "Vision And Light", GlobalSearchTermType.StarshipRule, null),
                ( "Blindsight", GlobalSearchTermType.StarshipRule, null),
                ( "Truesight", GlobalSearchTermType.StarshipRule, null),
                ( "Repairs And Maintenance", GlobalSearchTermType.StarshipRule, null),
                ( "Repairs", GlobalSearchTermType.StarshipRule, null),
                ( "Maintenance", GlobalSearchTermType.StarshipRule, null),
                ( "Repairing the \"Used\" Condition", GlobalSearchTermType.StarshipRule, null),
                ( "Primary System Failure", GlobalSearchTermType.StarshipRule, null),
                ( "Repairing Primary Systems", GlobalSearchTermType.StarshipRule, null)
            };

        public static List<(string name, GlobalSearchTermType globalSearchTermType, string pathOverride)> SOTGChapterNineSections { get; } =
            new List<(string name, GlobalSearchTermType globalSearchTermType, string pathOverride)>
            {
                ( "The Order Of Combat", GlobalSearchTermType.StarshipRule, null),
                ( "Surprise", GlobalSearchTermType.StarshipRule, null),
                ( "Your Role On Your Turn", GlobalSearchTermType.StarshipRule, null),
                ( "Actions", GlobalSearchTermType.StarshipRule, null),
                ( "Bonus Actions", GlobalSearchTermType.StarshipRule, null),
                ( "Other Activity On Your Turn", GlobalSearchTermType.StarshipRule, null),
                ( "Reactions", GlobalSearchTermType.StarshipRule, null),
                ( "Movement And Position", GlobalSearchTermType.StarshipRule, null),
                ( "Flying Speed", GlobalSearchTermType.StarshipRule, null),
                ( "Turning Speed", GlobalSearchTermType.StarshipRule, null),
                ( "Variant: Playing On A Grid", GlobalSearchTermType.StarshipRule, null),
                ( "Breaking Up Your Move", GlobalSearchTermType.StarshipRule, null),
                ( "Moving Between Attacks", GlobalSearchTermType.StarshipRule, null),
                ( "Difficult Terrain", GlobalSearchTermType.StarshipRule, null),
                ( "Moving Around Other Ships", GlobalSearchTermType.StarshipRule, null),
                ( "Ship Size", GlobalSearchTermType.StarshipRule, null),
                ( "Space", GlobalSearchTermType.StarshipRule, null),
                ( "Actions In Combat", GlobalSearchTermType.StarshipRule, null),
                ( "Attack", GlobalSearchTermType.StarshipRule, null),
                ( "Cast A Power", GlobalSearchTermType.StarshipRule, null),
                ( "Direct", GlobalSearchTermType.StarshipRule, null),
                ( "Evade", GlobalSearchTermType.StarshipRule, null),
                ( "Hide", GlobalSearchTermType.StarshipRule, null),
                ( "Interfere", GlobalSearchTermType.StarshipRule, null),
                ( "Patch", GlobalSearchTermType.StarshipRule, null),
                ( "Ram", GlobalSearchTermType.StarshipRule, null),
                ( "Ready", GlobalSearchTermType.StarshipRule, null),
                ( "Search", GlobalSearchTermType.StarshipRule, null),
                ( "Use An Object", GlobalSearchTermType.StarshipRule, null),
                ( "Making An Attack", GlobalSearchTermType.StarshipRule, null),
                ( "Attack Rolls", GlobalSearchTermType.StarshipRule, null),
                ( "Rolling 1 Or 20", GlobalSearchTermType.StarshipRule, null),
                ( "Range", GlobalSearchTermType.StarshipRule, null),
                ( "Ranged Attacks In Close Combat", GlobalSearchTermType.StarshipRule, null),
                ( "Firing Arc", GlobalSearchTermType.StarshipRule, null),
                ( "Limited Firing Arc", GlobalSearchTermType.StarshipRule, null),
                ( "Unlimited Firing Arc", GlobalSearchTermType.StarshipRule, null),
                ( "Saving Throws", GlobalSearchTermType.StarshipRule, null),
                ( "Damage Rolls", GlobalSearchTermType.StarshipRule, null),
                ( "Critical Hits", GlobalSearchTermType.StarshipRule, null),
                ( "Damage Types", GlobalSearchTermType.StarshipRule, null),
                ( "Damage Resistance And Vulnerability", GlobalSearchTermType.StarshipRule, null),
                ( "Cover", GlobalSearchTermType.StarshipRule, null),
                ( "Damage And Repairs", GlobalSearchTermType.StarshipRule, null),
                ( "Hit Points", GlobalSearchTermType.StarshipRule, null),
                ( "Shield Points", GlobalSearchTermType.StarshipRule, null),
                ( "Repairs", GlobalSearchTermType.StarshipRule, null),
                ( "Dropping To 0 Hit Points", GlobalSearchTermType.StarshipRule, null),
                ( "Describing The Effects Of Damage", GlobalSearchTermType.StarshipRule, null),
                ( "Instantly Destroyed", GlobalSearchTermType.StarshipRule, null),
                ( "Destruction Saving Throws", GlobalSearchTermType.StarshipRule, null),
                ( "Stabilizing A Ship", GlobalSearchTermType.StarshipRule, null),
                ( "Ships And Destruction", GlobalSearchTermType.StarshipRule, null),
                ( "Disabling A Ship", GlobalSearchTermType.StarshipRule, null)
            };

        public static List<(string name, GlobalSearchTermType globalSearchTermType, string pathOverride)> SOTGChapterTenSections { get; } =
            new List<(string name, GlobalSearchTermType globalSearchTermType, string pathOverride)>
            {
                ( "Escort Missions", GlobalSearchTermType.StarshipRule, null),
                ( "Blockade Run", GlobalSearchTermType.StarshipRule, null),
                ( "Base Assault", GlobalSearchTermType.StarshipRule, null),
                ( "Retrieval Mission", GlobalSearchTermType.StarshipRule, null),
                ( "Build Interesting Battlefields", GlobalSearchTermType.StarshipRule, null),
                ( "Asteroids, Debris, And Enclosed Terrain", GlobalSearchTermType.StarshipRule, null),
                ( "Damaging Environment", GlobalSearchTermType.StarshipRule, null),
                ( "Corrosive Gases", GlobalSearchTermType.StarshipRule, null),
                ( "Dust Clouds", GlobalSearchTermType.StarshipRule, null),
                ( "Ionic Discharges", GlobalSearchTermType.StarshipRule, null),
                ( "Radiation", GlobalSearchTermType.StarshipRule, null),
                ( "Create Exciting Scenarios With Complications", GlobalSearchTermType.StarshipRule, null),
                ( "Creating An Encounter", GlobalSearchTermType.StarshipRule, null)
            };

        public static List<(string name, GlobalSearchTermType globalSearchTermType, string pathOverride)> SOTGAppendixAConditionsSections { get; } =
            new List<(string name, GlobalSearchTermType globalSearchTermType, string pathOverride)>
            {
                ( "Blinded", GlobalSearchTermType.StarshipCondition, null),
                ( "Disabled", GlobalSearchTermType.StarshipCondition, null),
                ( "Ionized", GlobalSearchTermType.StarshipCondition, null),
                ( "Invisible", GlobalSearchTermType.StarshipCondition, null),
                ( "Shocked", GlobalSearchTermType.StarshipCondition, null),
                ( "Stalled", GlobalSearchTermType.StarshipCondition, null),
                ( "Stunned", GlobalSearchTermType.StarshipCondition, null),
                ( "System Damage", GlobalSearchTermType.StarshipCondition, null),
                ( "Tractored", GlobalSearchTermType.StarshipCondition, null),
                ( "Used", GlobalSearchTermType.StarshipCondition, null),
            };
    }
}