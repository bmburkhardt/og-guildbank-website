using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Og_Guild_Bank.Models
{
    public class Application
    {
        [Display(Name = "Character Name")]
        [Required]
        public string CharacterName { get; set; }

        [Required]
        public IEnumerable<SelectListItem> RaceList { get; set; }
        public string Race { get; set; }

        [Required]
        public IEnumerable<SelectListItem> ClassList { get; set; }
        public string Class { get; set; }

        [Required]
        public string Specialization { get; set; }

        [Required]
        public IEnumerable<SelectListItem> LevelList { get; set; }
        public string Level { get; set; }

        public string Realm { get; set; }
        [Required]
        public Boolean CanMakeRaidTimes { get; set; }
        public int Age { get; set; }
        public string RaidingExperience { get; set; }
        public string AnythingElse { get; set; }

        public Application()
        {
            RaceList = new List<SelectListItem>
            {
                new SelectListItem{ Text = "Dwarf", Value = "Dwarf"},
                new SelectListItem{ Text = "Gnome", Value = "Gnome"},
                new SelectListItem{ Text = "Human", Value = "Human"},
                new SelectListItem{ Text = "Night Elf", Value = "Night Elf"}
            };
            ClassList = new List<SelectListItem>
            {
                new SelectListItem{ Text = "Druid", Value = "Druid"},
                new SelectListItem{ Text = "Hunter", Value = "Hunter"},
                new SelectListItem{ Text = "Mage", Value = "Mage"},
                new SelectListItem{ Text = "Paladin", Value = "Paladin"},
                new SelectListItem{ Text = "Priest", Value = "Priest"},
                new SelectListItem{ Text = "Rogue", Value = "Rogue"},
                new SelectListItem{ Text = "Warlock", Value = "Warlock"},
                new SelectListItem{ Text = "Warrior", Value = "Warrior"}  
            };
            List<SelectListItem> tempLevelList = new List<SelectListItem>();
            for (int i = 60; i > 0; --i)
            {
                tempLevelList.Add(new SelectListItem { Text = i.ToString(), Value = i.ToString() });
            }
            LevelList = tempLevelList;
        }
    }
}
