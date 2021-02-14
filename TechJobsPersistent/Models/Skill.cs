using System;
using System.Collections.Generic;

namespace TechJobsPersistent.Models
{
    public class Skill
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<JobSkill> jobSkills { get; set; }
        public Skill()
        {
        }

        public Skill(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
