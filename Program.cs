﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Heist 
{
    public class ThePlan 
    {
        //Create a way to store a single team member. A team member will have a name, a skill Level and a courage factor. 
        public class TeamMember 
        {
            public string Name { get; set; }
            //The skill Level will be a positive integer
            public float SkillLevel { get; set; }
            //and the courage factor will be a decimal between 0.0 and 2.0.
            public decimal CourageFactor { get; set; }
        }

        static void Main(string[] args)
        {
            // Print the message "Plan Your Heist!".
            Console.WriteLine("Plan Your Heist!");

            //Prompt the user to enter a team member's name and save that name.
            Console.WriteLine("Please enter a team member's name:");
            string teamMemberName = Console.ReadLine();

            //Prompt the user to enter a team member's skill level and save that skill level with the name.
            Console.WriteLine("Enter the team member's skill (should be a positive integer):");
            float teamMemberSkillLevel = float.Parse(Console.ReadLine());

            //Prompt the user to enter a team member's courage factor and save that courage factor with the name.
            Console.WriteLine("Enter the team member courage factor (should be a decimal between 0.0 - 2.0):");
            decimal teamMemberCourageFactor = decimal.Parse(Console.ReadLine());

            TeamMember teamMember = new TeamMember
            {
                Name = teamMemberName,
                SkillLevel = teamMemberSkillLevel,
                CourageFactor = teamMemberCourageFactor
            };
            
            Console.WriteLine("Heist Team Member Added");
            Console.WriteLine("----------------------------");
            //Display the team member's information.
            Console.WriteLine($"{teamMember.Name}, Skill Level: {teamMember.SkillLevel}, Courage Factor: {teamMember.CourageFactor}");
        }

    }
}






/*
Phase One
The program should...







Phase Two
The program should be updated to...

Create a way to store several team members.
Collect several team members' information.
Stop collecting team members when a blank name is entered.
Display a message containing the number of members of the team.
Display each team member's information.
Phase Three
The program should be updated to...

Stop displaying each team member's information.
Store a value for the bank's difficulty level. Set this value to 100.
Sum the skill levels of the team. Save that number.
Compare the number with the bank's difficulty level. If the team's skill level is greater than or equal to the bank's difficulty level, Display a success message, otherwise display a failure message.
Phase Four
The program should be updated to...

Create a random number between -10 and 10 for the heist's luck value.
Add this number to the bank's difficulty level.
Before displaying the success or failure message, display a report that shows.
The team's combined skill level
The bank's difficulty level
Phase Five
The program should be updated to...

Run the scenario multiple times.
After the user enters the team information, prompt them to enter the number of trial runs the program should perform.
Loop through the difficulty / skill level calculation based on the user-entered number of trial runs. Choose a new luck value each time.
Phase Six
The program should be updated to...

At the beginning of the program, prompt the user to enter the difficulty level of the bank.
At the end of the program, display a report showing the number of successful runs and the number of failed runs.

*/