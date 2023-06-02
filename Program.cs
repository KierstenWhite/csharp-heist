using System;
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

            //Create a way to store several team members.
            List<TeamMember> teamMembers = new List<TeamMember>();

            while (true)
            {

                //Prompt the user to enter a team member's name and save that name.
                Console.WriteLine("Please enter a team member's name:");
                string teamMemberName = Console.ReadLine();

                //Stop collecting team members when a blank name is entered.
                if (teamMemberName == "")
                break;

                //Prompt the user to enter a team member's skill level and save that skill level with the name.
                Console.WriteLine("Enter the team member's skill (should be a positive integer):");
                float teamMemberSkillLevel = float.Parse(Console.ReadLine());

                //Prompt the user to enter a team member's courage factor and save that courage factor with the name.
                Console.WriteLine("Enter the team member courage factor (should be a decimal between 0.0 - 2.0):");
                decimal teamMemberCourageFactor = decimal.Parse(Console.ReadLine());

                //Create a new object that stores all the Team Member information
                TeamMember teamMember = new TeamMember
                {
                    Name = teamMemberName,
                    SkillLevel = teamMemberSkillLevel,
                    CourageFactor = teamMemberCourageFactor
                };

                //Collect several team members' information. - I think this is what this does
                teamMembers.Add(teamMember);
                
                Console.WriteLine("Heist Team Member Added");
                Console.WriteLine("----------------------------");
            }
                //Display a message containing the number of members of the team.
                Console.WriteLine($"You have {teamMembers.Count} Team Members:");
                Console.WriteLine("----------------------------");

                //Display each team member's information.
                //Stop displaying each team member's information.
                // foreach (var member in teamMembers)
                //     Console.WriteLine($"{member.Name}, Skill Level: {member.SkillLevel}, Courage Factor: {member.CourageFactor}");

                //Store a value for the bank's difficulty level. Set this value to 100.
                int bankDifficulty = 100;

                //Sum the skill levels of the team. Save that number.
                float totalTeamSkillLevel = 0;

                //Compare the number with the bank's difficulty level.
                foreach (var member in teamMembers)
                {
                    totalTeamSkillLevel += member.SkillLevel;
                }
                if (totalTeamSkillLevel >= bankDifficulty) 
                {
                    Console.WriteLine("Your team skill level is enough to complete this bank job!"); //If the team's skill level is greater than or equal to the bank's difficulty level, Display a success message,
                }
                else
                {
                    Console.WriteLine("Your total team skill level is too low to complete this bank job."); //otherwise display a failure message.
                }
        }
    }
}

/*
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